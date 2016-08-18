using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.Mvc;
using IQ6.Core;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;

namespace FTL
{


    public partial class OrdersController : DSBaseController<Orders/*,OrdersSearch*/>
    {
        public OrdersController() : base((IDatabase)IQApp.DB, new OrdersRepository())
        {

        }

        [ValidateInput(false)]
        public ActionResult Delete(int RecId)
        {
            var Key = IQApp.DB.GetInt("select OrdId from Orders where RecordID=@RecId", new { RecId = RecId });

            int count = 0;
            count += IQApp.DB.GetInt("select count(*) from OrderLine where OrdLOrder=@Val", new { Val = Key });
            count += IQApp.DB.GetInt("select count(*) from EADNum where EADOrder=@Val", new { Val = Key });
            if (count > 0)
            {
                return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
            }

            string Msg = "Are you sure you want to delete this record?";

            Msg += " This will also delete any existing sub records.";

            return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
            WebButton.CallbackButton<Orders>("Delete", DeleteClick),
                WebButton.ClosePopupButton("Close", "btn-info", "float:left")
        }));
        }

        public void DeleteClick(Orders data)
        {
            IQApp.DB.Execute("delete from OrderLine where OrdLOrder=@Val", new { Val = data.OrdIdValue });
            IQApp.DB.Execute("delete from EADNum where EADOrder=@Val", new { Val = data.OrdIdValue });
            IQApp.DB.Execute("Delete from Orders where RecordID=@RecId", new { RecId = data.RecordID });
            IQApp.CR.UrlToLoad("/?message=" + data.OrdIdValue + " has been removed.");
        }



        public ActionResult ListFromQuery(string Clause, string Ord, int? Limit)
        {

            Clause = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
            Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

            string Query = "select * from Orders " + Clause + Ord;
            ViewBag.MoreResults = false;
            ViewBag.Clause = Clause;
            ViewBag.Ord = Ord;
            if (Limit.HasValue)
            {
                int ResultCount = IQApp.DB.GetInt("select count(*) from Orders " + Clause);
                if (ResultCount > Limit)
                {
                    Query = "select top " + Limit.Value + " * from Orders " + Clause + Ord;
                    ViewBag.MoreResults = true;
                    ViewBag.Limit = Limit.Value;
                    ViewBag.ResultCount = ResultCount;
                }
            }
            return IQView("~/Views/Orders_List_" + IQApp.User.GetSecurityGroup() + ".cshtml",
                    IQApp.DB.Load<Orders>(Query).ToList());

        }

        public ActionResult SearchSendEmail()
        {

            EMail model = new EMail();
            model.EMDSValue = "Orders";

            string field = "OrdEMTo  (E-Mail To)";
            if (!string.IsNullOrEmpty(IQApp.WD.GetString("FieldToEmail")))
            {
                field = IQApp.WD.GetString("FieldToEmail");
            }
            model.EMDFValue = field;
            model.EMToRecordsValue = IQApp.DB.GetString("select cast(OrdId as varchar) + ',' from Orders where RecordID in (" + IQApp.WD.GetString("RecordIDs") + ") for xml path ('')");
            model.Save();
            return Redirect("/EMail/Load/?RecId=" + model.RecordID.Value);
        }

        public ActionResult ExportAll()
        {

            var res = IQApp.DB.Load<Orders>("select * from Orders  ").ToList();
            string urlpath = "/temp/Orders Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            string path = Server.MapPath(urlpath);
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);

            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Orders");

                worksheet.Cells.Style.Font.Size = 9;
                worksheet.Cells.Style.Font.Name = "Calibri";
                worksheet.Cells.Style.WrapText = true;

                using (var range = worksheet.Cells[1, 1, 1, 7])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Font.Size = 11;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                    range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                }

                worksheet.Column(1).Width = 14;
                worksheet.Cells[1, 1].Value = "Order Number";


                worksheet.Column(2).Width = 18;
                worksheet.Cells[1, 2].Value = "Client Order No";


                worksheet.Column(3).Width = 18;
                worksheet.Cells[1, 3].Value = "Order Date";


                worksheet.Column(4).Width = 14;
                worksheet.Cells[1, 4].Value = "Status";


                worksheet.Column(5).Width = 18;
                worksheet.Cells[1, 5].Value = "Supplier Name";


                worksheet.Column(6).Width = 18;
                worksheet.Cells[1, 6].Value = "Client Name";


                for (int j = 0; j < res.Count(); j++)
                {

                    worksheet.Cells[j + 2, 1].Value = res[j].OrdId.DisplayValue;
                    worksheet.Cells[j + 2, 2].Value = res[j].OrdCustOrd.DisplayValue;
                    worksheet.Cells[j + 2, 3].Value = res[j].OrdDate.DisplayValue;
                    worksheet.Cells[j + 2, 4].Value = res[j].OrdStatus.DisplayValue;
                    worksheet.Cells[j + 2, 5].Value = res[j].OrdSupp.DisplayValue;
                    worksheet.Cells[j + 2, 6].Value = res[j].OrdCust.DisplayValue;

                }

                package.Save();

                return Redirect(urlpath);

            }
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdExpImp(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdExpImpValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdExpImp").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdExpImp"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdExpImp(Orders m, int? id, string q)
        {


            string s = m.OrdExpImp.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdExpImp(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdExpImp").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdExpImp"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdId(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdIdValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdId").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdId"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdId(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdId").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdId"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCustOrd(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdCustOrdValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustOrd").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustOrd"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCustOrd(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustOrd").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustOrd"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDate(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdDateValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDate").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDate"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDate(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDate").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDate"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdStatus(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdStatusValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdStatus").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdStatus"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdStatus(Orders m, int? id, string q)
        {


            string s = m.OrdStatus.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdStatus(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdStatus").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdStatus"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdReqDate(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdReqDateValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqDate").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqDate"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdReqDate(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqDate").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqDate"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdSupp(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdSuppValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupp").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupp"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdSupp(Orders m, int? id, string q)
        {


            string s = m.OrdSupp.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdSupp(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupp").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupp"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdSupPC(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdSupPCValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupPC"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdSupPC(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSupPC"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCollPoint(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdCollPointValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPoint").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPoint"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdCollPoint(Orders m, int? id, string q)
        {


            string s = m.OrdCollPoint.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCollPoint(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPoint").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPoint"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCollPointPC(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdCollPointPCValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPointPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPointPC"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCollPointPC(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPointPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollPointPC"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdSuppRef(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdSuppRefValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSuppRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSuppRef"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdSuppRef(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSuppRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSuppRef"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdConsign(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdConsignValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsign").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsign"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdConsign(Orders m, int? id, string q)
        {


            string s = m.OrdConsign.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdConsign(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsign").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsign"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdConsignPC(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdConsignPCValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsignPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsignPC"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdConsignPC(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsignPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsignPC"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDelPoint(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdDelPointValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPoint").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPoint"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdDelPoint(Orders m, int? id, string q)
        {


            string s = m.OrdDelPoint.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDelPoint(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPoint").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPoint"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDelPointPC(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdDelPointPCValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPointPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPointPC"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDelPointPC(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPointPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelPointPC"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdVATPaidBy(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdVATPaidByValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATPaidBy").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATPaidBy"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdVATPaidBy(Orders m, int? id, string q)
        {


            string s = m.OrdVATPaidBy.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdVATPaidBy(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATPaidBy").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATPaidBy"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdVATNo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdVATNoValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATNo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdVATNo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdVATNo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDANNoFrom(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdDANNoFromValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNoFrom").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNoFrom"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdDANNoFrom(Orders m, int? id, string q)
        {


            string s = m.OrdDANNoFrom.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDANNoFrom(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNoFrom").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNoFrom"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDANNo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdDANNoValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDANNo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDANNo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdBondFrom(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdBondFromValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondFrom").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondFrom"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdBondFrom(Orders m, int? id, string q)
        {


            string s = m.OrdBondFrom.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdBondFrom(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondFrom").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondFrom"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdBondCode(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdBondCodeValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondCode").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondCode"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdBondCode(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondCode").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdBondCode"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCust(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdCustValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCust").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCust"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdCust(Orders m, int? id, string q)
        {


            string s = m.OrdCust.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCust(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCust").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCust"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCustPC(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdCustPCValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustPC"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCustPC(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustPC").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustPC"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDateAvail(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdDateAvailValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateAvail").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateAvail"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDateAvail(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateAvail").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateAvail"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdJob(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdJobValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJob").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJob"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdJob(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJob").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJob"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCollDate(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdCollDateValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCollDate(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCollDate2(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdCollDate2Value = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate2").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate2"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCollDate2(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate2").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollDate2"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDateDel(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdDateDelValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateDel").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateDel"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDateDel(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateDel").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDateDel"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdNotes(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdNotesValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdNotes").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdNotes"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdNotes(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdNotes").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdNotes"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdJobNo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdJobNoValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobNo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdJobNo(Orders m, int? id, string q)
        {


            string s = m.OrdJobNo.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdJobNo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobNo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdJobLetter(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdJobLetterValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobLetter").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobLetter"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdJobLetter(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobLetter").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdJobLetter"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdInvoiced(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            bool i = false;

            bool UnableToContinue = false;

            if (!Boolean.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdInvoicedValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdInvoiced").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdInvoiced"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdInvoiced(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdInvoiced").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdInvoiced"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdFreightInv(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdFreightInvValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFreightInv").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFreightInv"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdFreightInv(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFreightInv").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFreightInv"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdTimeAvail(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            TimeSpan i = TimeSpan.MinValue;

            bool UnableToContinue = false;

            if (!TimeSpan.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdTimeAvailValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTimeAvail").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTimeAvail"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdTimeAvail(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTimeAvail").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTimeAvail"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDutyInv(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdDutyInvValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDutyInv").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDutyInv"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDutyInv(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDutyInv").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDutyInv"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdPriceAllowed(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            double i = 0.0;

            bool UnableToContinue = false;

            if (!Double.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdPriceAllowedValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdPriceAllowed").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdPriceAllowed"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdPriceAllowed(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdPriceAllowed").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdPriceAllowed"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdReqdChanged(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdReqdChangedValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqdChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqdChanged"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdReqdChanged(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqdChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdReqdChanged"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdAvailChanged(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdAvailChangedValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAvailChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAvailChanged"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdAvailChanged(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAvailChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAvailChanged"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCollChanged(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdCollChangedValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollChanged"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCollChanged(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollChanged"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDelChanged(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            DateTime i = DateTime.MinValue;

            bool UnableToContinue = false;

            if (!DateTime.TryParse(NewValue.ToString(), out i))
            {
                UnableToContinue = true;
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdDelChangedValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelChanged"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDelChanged(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelChanged").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelChanged"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdTescoRef(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdTescoRefValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoRef"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdTescoRef(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoRef"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCreatedBy(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdCreatedByValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCreatedBy").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCreatedBy"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdCreatedBy(Orders m, int? id, string q)
        {


            string s = m.OrdCreatedBy.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCreatedBy(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCreatedBy").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCreatedBy"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdEMTo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdEMToValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdEMTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdEMTo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdEMTo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdEMTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdEMTo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdFaxTo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdFaxToValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFaxTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFaxTo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdFaxTo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFaxTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdFaxTo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdAgentId(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdAgentIdValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgentId").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgentId"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdAgentId(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgentId").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgentId"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdAgent(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdAgentValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgent").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgent"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdAgent(Orders m, int? id, string q)
        {


            string s = m.OrdAgent.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdAgent(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgent").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAgent"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdAADSys(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdAADSysValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAADSys").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAADSys"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdAADSys(Orders m, int? id, string q)
        {


            string s = m.OrdAADSys.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdAADSys(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAADSys").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdAADSys"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdARCRef(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdARCRefValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdARCRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdARCRef"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdARCRef(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdARCRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdARCRef"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdGBWKNoFrom(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdGBWKNoFromValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNoFrom").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNoFrom"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdGBWKNoFrom(Orders m, int? id, string q)
        {


            string s = m.OrdGBWKNoFrom.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdGBWKNoFrom(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNoFrom").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNoFrom"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdGBWKNo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdGBWKNoValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdGBWKNo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdGBWKNo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdTescoPSWk(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdTescoPSWkValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoPSWk").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoPSWk"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdTescoPSWk(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoPSWk").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdTescoPSWk"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCollectCtry(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdCollectCtryValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollectCtry").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollectCtry"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCollectCtry(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollectCtry").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCollectCtry"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdSelEMTo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdSelEMToValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelEMTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelEMTo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdSelEMTo(Orders m, int? id, string q)
        {


            string s = m.OrdSelEMTo.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdSelEMTo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelEMTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelEMTo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdSelFaxTo(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            int i = 0;

            bool UnableToContinue = false;

            if (!Int32.TryParse(NewValue.ToString(), out i))
            {
                if (NewValue.Contains(","))
                {
                    NewValue = NewValue.Split(',')[0];
                    if (!Int32.TryParse(NewValue.ToString(), out i))
                    {
                        UnableToContinue = true;
                    }
                }
                else
                {
                    UnableToContinue = true;
                }
            }
            if (UnableToContinue)
            {
                return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
            }
            ds.OrdSelFaxToValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelFaxTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelFaxTo"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteOrdSelFaxTo(Orders m, int? id, string q)
        {


            string s = m.OrdSelFaxTo.DataSource;
            if (s.Contains("0, '' "))
            {
                s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
            }
            if (s.Contains("ORDER BY"))
            {
                s = s.Replace("SELECT ", "SELECT TOP 100000 ");
            }
            var result = new
            {
                results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description }),
                more = false
            };

            return Json(result);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdSelFaxTo(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelFaxTo").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdSelFaxTo"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdConsOrd(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdConsOrdValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsOrd").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsOrd"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdConsOrd(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsOrd").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdConsOrd"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdCustName(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdCustNameValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustName").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustName"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdCustName(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustName").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdCustName"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveOrdDelRef(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.OrdDelRefValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelRef"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackOrdDelRef(Orders obj)
        {

            if (DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelRef").Any())
            {
                foreach (var itm in DS.GetManager<Orders>().OnChange.Where(f => f.Key == "OrdDelRef"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Orders>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult ListOrSearch()
        {
            int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=2 and UserId=0");
            if (FirstSearch > 0)
                return Redirect("/Orders/Search/" + FirstSearch);

            return Redirect("/Orders/List/");
        }

    }

    public partial class OrdersRepository : DSRepository<Orders>
    {
        public OrdersRepository() : base(2, "Orders", "Orders")
        {
        }
    }
    public partial class Orders
    : DatasetBase<Orders>, IDSBase

    {
        public int KeyValue => OrdIdValue;
        public IFieldDefinition GetFieldDef(string DF)
        {
            switch (DF)
            {

                case "OrdExpImp":
                    return OrdExpImpField;
                case "OrdId":
                    return OrdIdField;
                case "OrdCustOrd":
                    return OrdCustOrdField;
                case "OrdDate":
                    return OrdDateField;
                case "OrdStatus":
                    return OrdStatusField;
                case "OrdReqDate":
                    return OrdReqDateField;
                case "OrdSupp":
                    return OrdSuppField;
                case "OrdSupPC":
                    return OrdSupPCField;
                case "OrdCollPoint":
                    return OrdCollPointField;
                case "OrdCollPointPC":
                    return OrdCollPointPCField;
                case "OrdSuppRef":
                    return OrdSuppRefField;
                case "OrdConsign":
                    return OrdConsignField;
                case "OrdConsignPC":
                    return OrdConsignPCField;
                case "OrdDelPoint":
                    return OrdDelPointField;
                case "OrdDelPointPC":
                    return OrdDelPointPCField;
                case "OrdVATPaidBy":
                    return OrdVATPaidByField;
                case "OrdVATNo":
                    return OrdVATNoField;
                case "OrdDANNoFrom":
                    return OrdDANNoFromField;
                case "OrdDANNo":
                    return OrdDANNoField;
                case "OrdBondFrom":
                    return OrdBondFromField;
                case "OrdBondCode":
                    return OrdBondCodeField;
                case "OrdCust":
                    return OrdCustField;
                case "OrdCustPC":
                    return OrdCustPCField;
                case "OrdDateAvail":
                    return OrdDateAvailField;
                case "OrdJob":
                    return OrdJobField;
                case "OrdCollDate":
                    return OrdCollDateField;
                case "OrdCollDate2":
                    return OrdCollDate2Field;
                case "OrdDateDel":
                    return OrdDateDelField;
                case "OrdNotes":
                    return OrdNotesField;
                case "OrdJobNo":
                    return OrdJobNoField;
                case "OrdJobLetter":
                    return OrdJobLetterField;
                case "OrdInvoiced":
                    return OrdInvoicedField;
                case "OrdFreightInv":
                    return OrdFreightInvField;
                case "OrdTimeAvail":
                    return OrdTimeAvailField;
                case "OrdDutyInv":
                    return OrdDutyInvField;
                case "OrdPriceAllowed":
                    return OrdPriceAllowedField;
                case "OrdReqdChanged":
                    return OrdReqdChangedField;
                case "OrdAvailChanged":
                    return OrdAvailChangedField;
                case "OrdCollChanged":
                    return OrdCollChangedField;
                case "OrdDelChanged":
                    return OrdDelChangedField;
                case "OrdTescoRef":
                    return OrdTescoRefField;
                case "OrdCreatedBy":
                    return OrdCreatedByField;
                case "OrdEMTo":
                    return OrdEMToField;
                case "OrdFaxTo":
                    return OrdFaxToField;
                case "OrdAgentId":
                    return OrdAgentIdField;
                case "OrdAgent":
                    return OrdAgentField;
                case "OrdAADSys":
                    return OrdAADSysField;
                case "OrdARCRef":
                    return OrdARCRefField;
                case "OrdGBWKNoFrom":
                    return OrdGBWKNoFromField;
                case "OrdGBWKNo":
                    return OrdGBWKNoField;
                case "OrdTescoPSWk":
                    return OrdTescoPSWkField;
                case "OrdCollectCtry":
                    return OrdCollectCtryField;
                case "OrdSelEMTo":
                    return OrdSelEMToField;
                case "OrdSelFaxTo":
                    return OrdSelFaxToField;
                case "OrdConsOrd":
                    return OrdConsOrdField;
                case "OrdCustName":
                    return OrdCustNameField;
                case "OrdDelRef":
                    return OrdDelRefField;
            }
            return null;
        }

        public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action)
        {
            action(OrdExpImp, OrdExpImpField);
            action(OrdId, OrdIdField);
            action(OrdCustOrd, OrdCustOrdField);
            action(OrdDate, OrdDateField);
            action(OrdStatus, OrdStatusField);
            action(OrdReqDate, OrdReqDateField);
            action(OrdSupp, OrdSuppField);
            action(OrdSupPC, OrdSupPCField);
            action(OrdCollPoint, OrdCollPointField);
            action(OrdCollPointPC, OrdCollPointPCField);
            action(OrdSuppRef, OrdSuppRefField);
            action(OrdConsign, OrdConsignField);
            action(OrdConsignPC, OrdConsignPCField);
            action(OrdDelPoint, OrdDelPointField);
            action(OrdDelPointPC, OrdDelPointPCField);
            action(OrdVATPaidBy, OrdVATPaidByField);
            action(OrdVATNo, OrdVATNoField);
            action(OrdDANNoFrom, OrdDANNoFromField);
            action(OrdDANNo, OrdDANNoField);
            action(OrdBondFrom, OrdBondFromField);
            action(OrdBondCode, OrdBondCodeField);
            action(OrdCust, OrdCustField);
            action(OrdCustPC, OrdCustPCField);
            action(OrdDateAvail, OrdDateAvailField);
            action(OrdJob, OrdJobField);
            action(OrdCollDate, OrdCollDateField);
            action(OrdCollDate2, OrdCollDate2Field);
            action(OrdDateDel, OrdDateDelField);
            action(OrdNotes, OrdNotesField);
            action(OrdJobNo, OrdJobNoField);
            action(OrdJobLetter, OrdJobLetterField);
            action(OrdInvoiced, OrdInvoicedField);
            action(OrdFreightInv, OrdFreightInvField);
            action(OrdTimeAvail, OrdTimeAvailField);
            action(OrdDutyInv, OrdDutyInvField);
            action(OrdPriceAllowed, OrdPriceAllowedField);
            action(OrdReqdChanged, OrdReqdChangedField);
            action(OrdAvailChanged, OrdAvailChangedField);
            action(OrdCollChanged, OrdCollChangedField);
            action(OrdDelChanged, OrdDelChangedField);
            action(OrdTescoRef, OrdTescoRefField);
            action(OrdCreatedBy, OrdCreatedByField);
            action(OrdEMTo, OrdEMToField);
            action(OrdFaxTo, OrdFaxToField);
            action(OrdAgentId, OrdAgentIdField);
            action(OrdAgent, OrdAgentField);
            action(OrdAADSys, OrdAADSysField);
            action(OrdARCRef, OrdARCRefField);
            action(OrdGBWKNoFrom, OrdGBWKNoFromField);
            action(OrdGBWKNo, OrdGBWKNoField);
            action(OrdTescoPSWk, OrdTescoPSWkField);
            action(OrdCollectCtry, OrdCollectCtryField);
            action(OrdSelEMTo, OrdSelEMToField);
            action(OrdSelFaxTo, OrdSelFaxToField);
            action(OrdConsOrd, OrdConsOrdField);
            action(OrdCustName, OrdCustNameField);
            action(OrdDelRef, OrdDelRefField);
        }
        public void PrepareForSecGroup(int id)
        {
            switch (id)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    OrdExpImp.Visible = false; OrdId.Visible = false; OrdCustOrd.Visible = false; OrdDate.Visible = false; OrdStatus.Visible = false; OrdReqDate.Visible = false; OrdSupp.Visible = false; OrdSupPC.Visible = false; OrdCollPoint.Visible = false; OrdCollPointPC.Visible = false; OrdSuppRef.Visible = false; OrdConsign.Visible = false; OrdConsignPC.Visible = false; OrdDelPoint.Visible = false; OrdDelPointPC.Visible = false; OrdVATPaidBy.Visible = false; OrdVATNo.Visible = false; OrdDANNoFrom.Visible = false; OrdDANNo.Visible = false; OrdBondFrom.Visible = false; OrdBondCode.Visible = false; OrdCust.Visible = false; OrdCustPC.Visible = false; OrdDateAvail.Visible = false; OrdJob.Visible = false; OrdCollDate.Visible = false; OrdCollDate2.Visible = false; OrdDateDel.Visible = false; OrdNotes.Visible = false; OrdJobNo.Visible = false; OrdJobLetter.Visible = false; OrdInvoiced.Visible = false; OrdFreightInv.Visible = false; OrdTimeAvail.Visible = false; OrdDutyInv.Visible = false; OrdPriceAllowed.Visible = false; OrdReqdChanged.Visible = false; OrdAvailChanged.Visible = false; OrdCollChanged.Visible = false; OrdDelChanged.Visible = false; OrdTescoRef.Visible = false; OrdCreatedBy.Visible = false; OrdEMTo.Visible = false; OrdFaxTo.Visible = false; OrdAgentId.Visible = false; OrdAgent.Visible = false; OrdAADSys.Visible = false; OrdARCRef.Visible = false; OrdGBWKNoFrom.Visible = false; OrdGBWKNo.Visible = false; OrdTescoPSWk.Visible = false; OrdCollectCtry.Visible = false; OrdSelEMTo.Visible = false; OrdSelFaxTo.Visible = false; OrdConsOrd.Visible = false; OrdCustName.Visible = false; OrdDelRef.Visible = false; break;
            }
        }




        public override int Save()
        {
            if (RecordID.HasValue)
            {
                string SQL = "update Orders set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
                if (OrdExpImp.HasChanged && OrdExpImp.HasValue)
                {
                    SQL += ", OrdExpImp=@OrdExpImpValue";

                }
                if (OrdId.HasChanged && OrdId.HasValue)
                {
                    SQL += ", OrdId=@OrdIdValue";

                }
                if (OrdCustOrd.HasChanged && OrdCustOrd.HasValue)
                {
                    SQL += ", OrdCustOrd=@OrdCustOrdValue";

                }
                if (OrdDate.HasChanged && OrdDate.HasValue)
                {
                    SQL += ", OrdDate=@OrdDateValue";

                }
                if (OrdStatus.HasChanged && OrdStatus.HasValue)
                {
                    SQL += ", OrdStatus=@OrdStatusValue";

                }
                if (OrdReqDate.HasChanged && OrdReqDate.HasValue)
                {
                    SQL += ", OrdReqDate=@OrdReqDateValue";

                }
                if (OrdSupp.HasChanged && OrdSupp.HasValue)
                {
                    SQL += ", OrdSupp=@OrdSuppValue";

                }
                if (OrdSupPC.HasChanged && OrdSupPC.HasValue)
                {
                    SQL += ", OrdSupPC=@OrdSupPCValue";

                }
                if (OrdCollPoint.HasChanged && OrdCollPoint.HasValue)
                {
                    SQL += ", OrdCollPoint=@OrdCollPointValue";

                }
                if (OrdCollPointPC.HasChanged && OrdCollPointPC.HasValue)
                {
                    SQL += ", OrdCollPointPC=@OrdCollPointPCValue";

                }
                if (OrdSuppRef.HasChanged && OrdSuppRef.HasValue)
                {
                    SQL += ", OrdSuppRef=@OrdSuppRefValue";

                }
                if (OrdConsign.HasChanged && OrdConsign.HasValue)
                {
                    SQL += ", OrdConsign=@OrdConsignValue";

                }
                if (OrdConsignPC.HasChanged && OrdConsignPC.HasValue)
                {
                    SQL += ", OrdConsignPC=@OrdConsignPCValue";

                }
                if (OrdDelPoint.HasChanged && OrdDelPoint.HasValue)
                {
                    SQL += ", OrdDelPoint=@OrdDelPointValue";

                }
                if (OrdDelPointPC.HasChanged && OrdDelPointPC.HasValue)
                {
                    SQL += ", OrdDelPointPC=@OrdDelPointPCValue";

                }
                if (OrdVATPaidBy.HasChanged && OrdVATPaidBy.HasValue)
                {
                    SQL += ", OrdVATPaidBy=@OrdVATPaidByValue";

                }
                if (OrdVATNo.HasChanged && OrdVATNo.HasValue)
                {
                    SQL += ", OrdVATNo=@OrdVATNoValue";

                }
                if (OrdDANNoFrom.HasChanged && OrdDANNoFrom.HasValue)
                {
                    SQL += ", OrdDANNoFrom=@OrdDANNoFromValue";

                }
                if (OrdDANNo.HasChanged && OrdDANNo.HasValue)
                {
                    SQL += ", OrdDANNo=@OrdDANNoValue";

                }
                if (OrdBondFrom.HasChanged && OrdBondFrom.HasValue)
                {
                    SQL += ", OrdBondFrom=@OrdBondFromValue";

                }
                if (OrdBondCode.HasChanged && OrdBondCode.HasValue)
                {
                    SQL += ", OrdBondCode=@OrdBondCodeValue";

                }
                if (OrdCust.HasChanged && OrdCust.HasValue)
                {
                    SQL += ", OrdCust=@OrdCustValue";

                }
                if (OrdCustPC.HasChanged && OrdCustPC.HasValue)
                {
                    SQL += ", OrdCustPC=@OrdCustPCValue";

                }
                if (OrdDateAvail.HasChanged && OrdDateAvail.HasValue)
                {
                    SQL += ", OrdDateAvail=@OrdDateAvailValue";

                }
                if (OrdJob.HasChanged && OrdJob.HasValue)
                {
                    SQL += ", OrdJob=@OrdJobValue";

                }
                if (OrdCollDate.HasChanged && OrdCollDate.HasValue)
                {
                    SQL += ", OrdCollDate=@OrdCollDateValue";

                }
                if (OrdCollDate2.HasChanged && OrdCollDate2.HasValue)
                {
                    SQL += ", OrdCollDate2=@OrdCollDate2Value";

                }
                if (OrdDateDel.HasChanged && OrdDateDel.HasValue)
                {
                    SQL += ", OrdDateDel=@OrdDateDelValue";

                }
                if (OrdNotes.HasChanged && OrdNotes.HasValue)
                {
                    SQL += ", OrdNotes=@OrdNotesValue";

                }
                if (OrdJobNo.HasChanged && OrdJobNo.HasValue)
                {
                    SQL += ", OrdJobNo=@OrdJobNoValue";

                }
                if (OrdJobLetter.HasChanged && OrdJobLetter.HasValue)
                {
                    SQL += ", OrdJobLetter=@OrdJobLetterValue";

                }
                if (OrdInvoiced.HasChanged && OrdInvoiced.HasValue)
                {
                    SQL += ", OrdInvoiced=@OrdInvoicedValue";

                }
                if (OrdFreightInv.HasChanged && OrdFreightInv.HasValue)
                {
                    SQL += ", OrdFreightInv=@OrdFreightInvValue";

                }
                if (OrdTimeAvail.HasChanged && OrdTimeAvail.HasValue)
                {
                    SQL += ", OrdTimeAvail=@OrdTimeAvailValue";

                }
                if (OrdDutyInv.HasChanged && OrdDutyInv.HasValue)
                {
                    SQL += ", OrdDutyInv=@OrdDutyInvValue";

                }
                if (OrdPriceAllowed.HasChanged && OrdPriceAllowed.HasValue)
                {
                    SQL += ", OrdPriceAllowed=@OrdPriceAllowedValue";

                }
                if (OrdReqdChanged.HasChanged && OrdReqdChanged.HasValue)
                {
                    SQL += ", OrdReqdChanged=@OrdReqdChangedValue";

                }
                if (OrdAvailChanged.HasChanged && OrdAvailChanged.HasValue)
                {
                    SQL += ", OrdAvailChanged=@OrdAvailChangedValue";

                }
                if (OrdCollChanged.HasChanged && OrdCollChanged.HasValue)
                {
                    SQL += ", OrdCollChanged=@OrdCollChangedValue";

                }
                if (OrdDelChanged.HasChanged && OrdDelChanged.HasValue)
                {
                    SQL += ", OrdDelChanged=@OrdDelChangedValue";

                }
                if (OrdTescoRef.HasChanged && OrdTescoRef.HasValue)
                {
                    SQL += ", OrdTescoRef=@OrdTescoRefValue";

                }
                if (OrdCreatedBy.HasChanged && OrdCreatedBy.HasValue)
                {
                    SQL += ", OrdCreatedBy=@OrdCreatedByValue";

                }
                if (OrdEMTo.HasChanged && OrdEMTo.HasValue)
                {
                    SQL += ", OrdEMTo=@OrdEMToValue";

                }
                if (OrdFaxTo.HasChanged && OrdFaxTo.HasValue)
                {
                    SQL += ", OrdFaxTo=@OrdFaxToValue";

                }
                if (OrdAgentId.HasChanged && OrdAgentId.HasValue)
                {
                    SQL += ", OrdAgentId=@OrdAgentIdValue";

                }
                if (OrdAgent.HasChanged && OrdAgent.HasValue)
                {
                    SQL += ", OrdAgent=@OrdAgentValue";

                }
                if (OrdAADSys.HasChanged && OrdAADSys.HasValue)
                {
                    SQL += ", OrdAADSys=@OrdAADSysValue";

                }
                if (OrdARCRef.HasChanged && OrdARCRef.HasValue)
                {
                    SQL += ", OrdARCRef=@OrdARCRefValue";

                }
                if (OrdGBWKNoFrom.HasChanged && OrdGBWKNoFrom.HasValue)
                {
                    SQL += ", OrdGBWKNoFrom=@OrdGBWKNoFromValue";

                }
                if (OrdGBWKNo.HasChanged && OrdGBWKNo.HasValue)
                {
                    SQL += ", OrdGBWKNo=@OrdGBWKNoValue";

                }
                if (OrdTescoPSWk.HasChanged && OrdTescoPSWk.HasValue)
                {
                    SQL += ", OrdTescoPSWk=@OrdTescoPSWkValue";

                }
                if (OrdCollectCtry.HasChanged && OrdCollectCtry.HasValue)
                {
                    SQL += ", OrdCollectCtry=@OrdCollectCtryValue";

                }
                if (OrdSelEMTo.HasChanged && OrdSelEMTo.HasValue)
                {
                    SQL += ", OrdSelEMTo=@OrdSelEMToValue";

                }
                if (OrdSelFaxTo.HasChanged && OrdSelFaxTo.HasValue)
                {
                    SQL += ", OrdSelFaxTo=@OrdSelFaxToValue";

                }
                if (OrdConsOrd.HasChanged && OrdConsOrd.HasValue)
                {
                    SQL += ", OrdConsOrd=@OrdConsOrdValue";

                }
                if (OrdCustName.HasChanged && OrdCustName.HasValue)
                {
                    SQL += ", OrdCustName=@OrdCustNameValue";

                }
                if (OrdDelRef.HasChanged && OrdDelRef.HasValue)
                {
                    SQL += ", OrdDelRef=@OrdDelRefValue";

                }

                SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
                OrdExpImp.HasChanged = false;
                OrdId.HasChanged = false;
                OrdCustOrd.HasChanged = false;
                OrdDate.HasChanged = false;
                OrdStatus.HasChanged = false;
                OrdReqDate.HasChanged = false;
                OrdSupp.HasChanged = false;
                OrdSupPC.HasChanged = false;
                OrdCollPoint.HasChanged = false;
                OrdCollPointPC.HasChanged = false;
                OrdSuppRef.HasChanged = false;
                OrdConsign.HasChanged = false;
                OrdConsignPC.HasChanged = false;
                OrdDelPoint.HasChanged = false;
                OrdDelPointPC.HasChanged = false;
                OrdVATPaidBy.HasChanged = false;
                OrdVATNo.HasChanged = false;
                OrdDANNoFrom.HasChanged = false;
                OrdDANNo.HasChanged = false;
                OrdBondFrom.HasChanged = false;
                OrdBondCode.HasChanged = false;
                OrdCust.HasChanged = false;
                OrdCustPC.HasChanged = false;
                OrdDateAvail.HasChanged = false;
                OrdJob.HasChanged = false;
                OrdCollDate.HasChanged = false;
                OrdCollDate2.HasChanged = false;
                OrdDateDel.HasChanged = false;
                OrdNotes.HasChanged = false;
                OrdJobNo.HasChanged = false;
                OrdJobLetter.HasChanged = false;
                OrdInvoiced.HasChanged = false;
                OrdFreightInv.HasChanged = false;
                OrdTimeAvail.HasChanged = false;
                OrdDutyInv.HasChanged = false;
                OrdPriceAllowed.HasChanged = false;
                OrdReqdChanged.HasChanged = false;
                OrdAvailChanged.HasChanged = false;
                OrdCollChanged.HasChanged = false;
                OrdDelChanged.HasChanged = false;
                OrdTescoRef.HasChanged = false;
                OrdCreatedBy.HasChanged = false;
                OrdEMTo.HasChanged = false;
                OrdFaxTo.HasChanged = false;
                OrdAgentId.HasChanged = false;
                OrdAgent.HasChanged = false;
                OrdAADSys.HasChanged = false;
                OrdARCRef.HasChanged = false;
                OrdGBWKNoFrom.HasChanged = false;
                OrdGBWKNo.HasChanged = false;
                OrdTescoPSWk.HasChanged = false;
                OrdCollectCtry.HasChanged = false;
                OrdSelEMTo.HasChanged = false;
                OrdSelFaxTo.HasChanged = false;
                OrdConsOrd.HasChanged = false;
                OrdCustName.HasChanged = false;
                OrdDelRef.HasChanged = false;

                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
                if (!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
                if (!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();

                string SQL = "insert into Orders(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";


                if (OrdExpImp.HasValue)
                {
                    SQL += ", OrdExpImp";
                    Values += ", @OrdExpImpValue";
                }

                if (OrdId.HasValue)
                {
                    SQL += ", OrdId";
                    Values += ", @OrdIdValue";
                }

                if (OrdCustOrd.HasValue)
                {
                    SQL += ", OrdCustOrd";
                    Values += ", @OrdCustOrdValue";
                }

                if (OrdDate.HasValue)
                {
                    SQL += ", OrdDate";
                    Values += ", @OrdDateValue";
                }

                if (OrdStatus.HasValue)
                {
                    SQL += ", OrdStatus";
                    Values += ", @OrdStatusValue";
                }

                if (OrdReqDate.HasValue)
                {
                    SQL += ", OrdReqDate";
                    Values += ", @OrdReqDateValue";
                }

                if (OrdSupp.HasValue)
                {
                    SQL += ", OrdSupp";
                    Values += ", @OrdSuppValue";
                }

                if (OrdSupPC.HasValue)
                {
                    SQL += ", OrdSupPC";
                    Values += ", @OrdSupPCValue";
                }

                if (OrdCollPoint.HasValue)
                {
                    SQL += ", OrdCollPoint";
                    Values += ", @OrdCollPointValue";
                }

                if (OrdCollPointPC.HasValue)
                {
                    SQL += ", OrdCollPointPC";
                    Values += ", @OrdCollPointPCValue";
                }

                if (OrdSuppRef.HasValue)
                {
                    SQL += ", OrdSuppRef";
                    Values += ", @OrdSuppRefValue";
                }

                if (OrdConsign.HasValue)
                {
                    SQL += ", OrdConsign";
                    Values += ", @OrdConsignValue";
                }

                if (OrdConsignPC.HasValue)
                {
                    SQL += ", OrdConsignPC";
                    Values += ", @OrdConsignPCValue";
                }

                if (OrdDelPoint.HasValue)
                {
                    SQL += ", OrdDelPoint";
                    Values += ", @OrdDelPointValue";
                }

                if (OrdDelPointPC.HasValue)
                {
                    SQL += ", OrdDelPointPC";
                    Values += ", @OrdDelPointPCValue";
                }

                if (OrdVATPaidBy.HasValue)
                {
                    SQL += ", OrdVATPaidBy";
                    Values += ", @OrdVATPaidByValue";
                }

                if (OrdVATNo.HasValue)
                {
                    SQL += ", OrdVATNo";
                    Values += ", @OrdVATNoValue";
                }

                if (OrdDANNoFrom.HasValue)
                {
                    SQL += ", OrdDANNoFrom";
                    Values += ", @OrdDANNoFromValue";
                }

                if (OrdDANNo.HasValue)
                {
                    SQL += ", OrdDANNo";
                    Values += ", @OrdDANNoValue";
                }

                if (OrdBondFrom.HasValue)
                {
                    SQL += ", OrdBondFrom";
                    Values += ", @OrdBondFromValue";
                }

                if (OrdBondCode.HasValue)
                {
                    SQL += ", OrdBondCode";
                    Values += ", @OrdBondCodeValue";
                }

                if (OrdCust.HasValue)
                {
                    SQL += ", OrdCust";
                    Values += ", @OrdCustValue";
                }

                if (OrdCustPC.HasValue)
                {
                    SQL += ", OrdCustPC";
                    Values += ", @OrdCustPCValue";
                }

                if (OrdDateAvail.HasValue)
                {
                    SQL += ", OrdDateAvail";
                    Values += ", @OrdDateAvailValue";
                }

                if (OrdJob.HasValue)
                {
                    SQL += ", OrdJob";
                    Values += ", @OrdJobValue";
                }

                if (OrdCollDate.HasValue)
                {
                    SQL += ", OrdCollDate";
                    Values += ", @OrdCollDateValue";
                }

                if (OrdCollDate2.HasValue)
                {
                    SQL += ", OrdCollDate2";
                    Values += ", @OrdCollDate2Value";
                }

                if (OrdDateDel.HasValue)
                {
                    SQL += ", OrdDateDel";
                    Values += ", @OrdDateDelValue";
                }

                if (OrdNotes.HasValue)
                {
                    SQL += ", OrdNotes";
                    Values += ", @OrdNotesValue";
                }

                if (OrdJobNo.HasValue)
                {
                    SQL += ", OrdJobNo";
                    Values += ", @OrdJobNoValue";
                }

                if (OrdJobLetter.HasValue)
                {
                    SQL += ", OrdJobLetter";
                    Values += ", @OrdJobLetterValue";
                }

                if (OrdInvoiced.HasValue)
                {
                    SQL += ", OrdInvoiced";
                    Values += ", @OrdInvoicedValue";
                }

                if (OrdFreightInv.HasValue)
                {
                    SQL += ", OrdFreightInv";
                    Values += ", @OrdFreightInvValue";
                }

                if (OrdTimeAvail.HasValue)
                {
                    SQL += ", OrdTimeAvail";
                    Values += ", @OrdTimeAvailValue";
                }

                if (OrdDutyInv.HasValue)
                {
                    SQL += ", OrdDutyInv";
                    Values += ", @OrdDutyInvValue";
                }

                if (OrdPriceAllowed.HasValue)
                {
                    SQL += ", OrdPriceAllowed";
                    Values += ", @OrdPriceAllowedValue";
                }

                if (OrdReqdChanged.HasValue)
                {
                    SQL += ", OrdReqdChanged";
                    Values += ", @OrdReqdChangedValue";
                }

                if (OrdAvailChanged.HasValue)
                {
                    SQL += ", OrdAvailChanged";
                    Values += ", @OrdAvailChangedValue";
                }

                if (OrdCollChanged.HasValue)
                {
                    SQL += ", OrdCollChanged";
                    Values += ", @OrdCollChangedValue";
                }

                if (OrdDelChanged.HasValue)
                {
                    SQL += ", OrdDelChanged";
                    Values += ", @OrdDelChangedValue";
                }

                if (OrdTescoRef.HasValue)
                {
                    SQL += ", OrdTescoRef";
                    Values += ", @OrdTescoRefValue";
                }

                if (OrdCreatedBy.HasValue)
                {
                    SQL += ", OrdCreatedBy";
                    Values += ", @OrdCreatedByValue";
                }

                if (OrdEMTo.HasValue)
                {
                    SQL += ", OrdEMTo";
                    Values += ", @OrdEMToValue";
                }

                if (OrdFaxTo.HasValue)
                {
                    SQL += ", OrdFaxTo";
                    Values += ", @OrdFaxToValue";
                }

                if (OrdAgentId.HasValue)
                {
                    SQL += ", OrdAgentId";
                    Values += ", @OrdAgentIdValue";
                }

                if (OrdAgent.HasValue)
                {
                    SQL += ", OrdAgent";
                    Values += ", @OrdAgentValue";
                }

                if (OrdAADSys.HasValue)
                {
                    SQL += ", OrdAADSys";
                    Values += ", @OrdAADSysValue";
                }

                if (OrdARCRef.HasValue)
                {
                    SQL += ", OrdARCRef";
                    Values += ", @OrdARCRefValue";
                }

                if (OrdGBWKNoFrom.HasValue)
                {
                    SQL += ", OrdGBWKNoFrom";
                    Values += ", @OrdGBWKNoFromValue";
                }

                if (OrdGBWKNo.HasValue)
                {
                    SQL += ", OrdGBWKNo";
                    Values += ", @OrdGBWKNoValue";
                }

                if (OrdTescoPSWk.HasValue)
                {
                    SQL += ", OrdTescoPSWk";
                    Values += ", @OrdTescoPSWkValue";
                }

                if (OrdCollectCtry.HasValue)
                {
                    SQL += ", OrdCollectCtry";
                    Values += ", @OrdCollectCtryValue";
                }

                if (OrdSelEMTo.HasValue)
                {
                    SQL += ", OrdSelEMTo";
                    Values += ", @OrdSelEMToValue";
                }

                if (OrdSelFaxTo.HasValue)
                {
                    SQL += ", OrdSelFaxTo";
                    Values += ", @OrdSelFaxToValue";
                }

                if (OrdConsOrd.HasValue)
                {
                    SQL += ", OrdConsOrd";
                    Values += ", @OrdConsOrdValue";
                }

                if (OrdCustName.HasValue)
                {
                    SQL += ", OrdCustName";
                    Values += ", @OrdCustNameValue";
                }

                if (OrdDelRef.HasValue)
                {
                    SQL += ", OrdDelRef";
                    Values += ", @OrdDelRefValue";
                }

                SQL += ") values (" + Values + ")";
                RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Orders");
                IQApp.DB.Execute(SQL, this);
                OrdExpImp.HasChanged = false;
                OrdId.HasChanged = false;
                OrdCustOrd.HasChanged = false;
                OrdDate.HasChanged = false;
                OrdStatus.HasChanged = false;
                OrdReqDate.HasChanged = false;
                OrdSupp.HasChanged = false;
                OrdSupPC.HasChanged = false;
                OrdCollPoint.HasChanged = false;
                OrdCollPointPC.HasChanged = false;
                OrdSuppRef.HasChanged = false;
                OrdConsign.HasChanged = false;
                OrdConsignPC.HasChanged = false;
                OrdDelPoint.HasChanged = false;
                OrdDelPointPC.HasChanged = false;
                OrdVATPaidBy.HasChanged = false;
                OrdVATNo.HasChanged = false;
                OrdDANNoFrom.HasChanged = false;
                OrdDANNo.HasChanged = false;
                OrdBondFrom.HasChanged = false;
                OrdBondCode.HasChanged = false;
                OrdCust.HasChanged = false;
                OrdCustPC.HasChanged = false;
                OrdDateAvail.HasChanged = false;
                OrdJob.HasChanged = false;
                OrdCollDate.HasChanged = false;
                OrdCollDate2.HasChanged = false;
                OrdDateDel.HasChanged = false;
                OrdNotes.HasChanged = false;
                OrdJobNo.HasChanged = false;
                OrdJobLetter.HasChanged = false;
                OrdInvoiced.HasChanged = false;
                OrdFreightInv.HasChanged = false;
                OrdTimeAvail.HasChanged = false;
                OrdDutyInv.HasChanged = false;
                OrdPriceAllowed.HasChanged = false;
                OrdReqdChanged.HasChanged = false;
                OrdAvailChanged.HasChanged = false;
                OrdCollChanged.HasChanged = false;
                OrdDelChanged.HasChanged = false;
                OrdTescoRef.HasChanged = false;
                OrdCreatedBy.HasChanged = false;
                OrdEMTo.HasChanged = false;
                OrdFaxTo.HasChanged = false;
                OrdAgentId.HasChanged = false;
                OrdAgent.HasChanged = false;
                OrdAADSys.HasChanged = false;
                OrdARCRef.HasChanged = false;
                OrdGBWKNoFrom.HasChanged = false;
                OrdGBWKNo.HasChanged = false;
                OrdTescoPSWk.HasChanged = false;
                OrdCollectCtry.HasChanged = false;
                OrdSelEMTo.HasChanged = false;
                OrdSelFaxTo.HasChanged = false;
                OrdConsOrd.HasChanged = false;
                OrdCustName.HasChanged = false;
                OrdDelRef.HasChanged = false;
                return RecordID.Value;
            }


        }

        public IDSFieldBase GetField(string DFName)
        {
            switch (DFName)
            {
                case "OrdExpImp":
                    return (IDSFieldBase)OrdExpImp;
                case "OrdId":
                    return (IDSFieldBase)OrdId;
                case "OrdCustOrd":
                    return (IDSFieldBase)OrdCustOrd;
                case "OrdDate":
                    return (IDSFieldBase)OrdDate;
                case "OrdStatus":
                    return (IDSFieldBase)OrdStatus;
                case "OrdReqDate":
                    return (IDSFieldBase)OrdReqDate;
                case "OrdSupp":
                    return (IDSFieldBase)OrdSupp;
                case "OrdSupPC":
                    return (IDSFieldBase)OrdSupPC;
                case "OrdCollPoint":
                    return (IDSFieldBase)OrdCollPoint;
                case "OrdCollPointPC":
                    return (IDSFieldBase)OrdCollPointPC;
                case "OrdSuppRef":
                    return (IDSFieldBase)OrdSuppRef;
                case "OrdConsign":
                    return (IDSFieldBase)OrdConsign;
                case "OrdConsignPC":
                    return (IDSFieldBase)OrdConsignPC;
                case "OrdDelPoint":
                    return (IDSFieldBase)OrdDelPoint;
                case "OrdDelPointPC":
                    return (IDSFieldBase)OrdDelPointPC;
                case "OrdVATPaidBy":
                    return (IDSFieldBase)OrdVATPaidBy;
                case "OrdVATNo":
                    return (IDSFieldBase)OrdVATNo;
                case "OrdDANNoFrom":
                    return (IDSFieldBase)OrdDANNoFrom;
                case "OrdDANNo":
                    return (IDSFieldBase)OrdDANNo;
                case "OrdBondFrom":
                    return (IDSFieldBase)OrdBondFrom;
                case "OrdBondCode":
                    return (IDSFieldBase)OrdBondCode;
                case "OrdCust":
                    return (IDSFieldBase)OrdCust;
                case "OrdCustPC":
                    return (IDSFieldBase)OrdCustPC;
                case "OrdDateAvail":
                    return (IDSFieldBase)OrdDateAvail;
                case "OrdJob":
                    return (IDSFieldBase)OrdJob;
                case "OrdCollDate":
                    return (IDSFieldBase)OrdCollDate;
                case "OrdCollDate2":
                    return (IDSFieldBase)OrdCollDate2;
                case "OrdDateDel":
                    return (IDSFieldBase)OrdDateDel;
                case "OrdNotes":
                    return (IDSFieldBase)OrdNotes;
                case "OrdJobNo":
                    return (IDSFieldBase)OrdJobNo;
                case "OrdJobLetter":
                    return (IDSFieldBase)OrdJobLetter;
                case "OrdInvoiced":
                    return (IDSFieldBase)OrdInvoiced;
                case "OrdFreightInv":
                    return (IDSFieldBase)OrdFreightInv;
                case "OrdTimeAvail":
                    return (IDSFieldBase)OrdTimeAvail;
                case "OrdDutyInv":
                    return (IDSFieldBase)OrdDutyInv;
                case "OrdPriceAllowed":
                    return (IDSFieldBase)OrdPriceAllowed;
                case "OrdReqdChanged":
                    return (IDSFieldBase)OrdReqdChanged;
                case "OrdAvailChanged":
                    return (IDSFieldBase)OrdAvailChanged;
                case "OrdCollChanged":
                    return (IDSFieldBase)OrdCollChanged;
                case "OrdDelChanged":
                    return (IDSFieldBase)OrdDelChanged;
                case "OrdTescoRef":
                    return (IDSFieldBase)OrdTescoRef;
                case "OrdCreatedBy":
                    return (IDSFieldBase)OrdCreatedBy;
                case "OrdEMTo":
                    return (IDSFieldBase)OrdEMTo;
                case "OrdFaxTo":
                    return (IDSFieldBase)OrdFaxTo;
                case "OrdAgentId":
                    return (IDSFieldBase)OrdAgentId;
                case "OrdAgent":
                    return (IDSFieldBase)OrdAgent;
                case "OrdAADSys":
                    return (IDSFieldBase)OrdAADSys;
                case "OrdARCRef":
                    return (IDSFieldBase)OrdARCRef;
                case "OrdGBWKNoFrom":
                    return (IDSFieldBase)OrdGBWKNoFrom;
                case "OrdGBWKNo":
                    return (IDSFieldBase)OrdGBWKNo;
                case "OrdTescoPSWk":
                    return (IDSFieldBase)OrdTescoPSWk;
                case "OrdCollectCtry":
                    return (IDSFieldBase)OrdCollectCtry;
                case "OrdSelEMTo":
                    return (IDSFieldBase)OrdSelEMTo;
                case "OrdSelFaxTo":
                    return (IDSFieldBase)OrdSelFaxTo;
                case "OrdConsOrd":
                    return (IDSFieldBase)OrdConsOrd;
                case "OrdCustName":
                    return (IDSFieldBase)OrdCustName;
                case "OrdDelRef":
                    return (IDSFieldBase)OrdDelRef;
            }
            return null;
        }

        public string GetDisplayValue(string DFName)
        {
            switch (DFName)
            {
                case "OrdExpImp":
                    return OrdExpImp.DisplayValue;
                case "OrdId":
                    return OrdId.DisplayValue;
                case "OrdCustOrd":
                    return OrdCustOrd.DisplayValue;
                case "OrdDate":
                    return OrdDate.DisplayValue;
                case "OrdStatus":
                    return OrdStatus.DisplayValue;
                case "OrdReqDate":
                    return OrdReqDate.DisplayValue;
                case "OrdSupp":
                    return OrdSupp.DisplayValue;
                case "OrdSupPC":
                    return OrdSupPC.DisplayValue;
                case "OrdCollPoint":
                    return OrdCollPoint.DisplayValue;
                case "OrdCollPointPC":
                    return OrdCollPointPC.DisplayValue;
                case "OrdSuppRef":
                    return OrdSuppRef.DisplayValue;
                case "OrdConsign":
                    return OrdConsign.DisplayValue;
                case "OrdConsignPC":
                    return OrdConsignPC.DisplayValue;
                case "OrdDelPoint":
                    return OrdDelPoint.DisplayValue;
                case "OrdDelPointPC":
                    return OrdDelPointPC.DisplayValue;
                case "OrdVATPaidBy":
                    return OrdVATPaidBy.DisplayValue;
                case "OrdVATNo":
                    return OrdVATNo.DisplayValue;
                case "OrdDANNoFrom":
                    return OrdDANNoFrom.DisplayValue;
                case "OrdDANNo":
                    return OrdDANNo.DisplayValue;
                case "OrdBondFrom":
                    return OrdBondFrom.DisplayValue;
                case "OrdBondCode":
                    return OrdBondCode.DisplayValue;
                case "OrdCust":
                    return OrdCust.DisplayValue;
                case "OrdCustPC":
                    return OrdCustPC.DisplayValue;
                case "OrdDateAvail":
                    return OrdDateAvail.DisplayValue;
                case "OrdJob":
                    return OrdJob.DisplayValue;
                case "OrdCollDate":
                    return OrdCollDate.DisplayValue;
                case "OrdCollDate2":
                    return OrdCollDate2.DisplayValue;
                case "OrdDateDel":
                    return OrdDateDel.DisplayValue;
                case "OrdNotes":
                    return OrdNotes.DisplayValue;
                case "OrdJobNo":
                    return OrdJobNo.DisplayValue;
                case "OrdJobLetter":
                    return OrdJobLetter.DisplayValue;
                case "OrdInvoiced":
                    return OrdInvoiced.DisplayValue;
                case "OrdFreightInv":
                    return OrdFreightInv.DisplayValue;
                case "OrdTimeAvail":
                    return OrdTimeAvail.DisplayValue;
                case "OrdDutyInv":
                    return OrdDutyInv.DisplayValue;
                case "OrdPriceAllowed":
                    return OrdPriceAllowed.DisplayValue;
                case "OrdReqdChanged":
                    return OrdReqdChanged.DisplayValue;
                case "OrdAvailChanged":
                    return OrdAvailChanged.DisplayValue;
                case "OrdCollChanged":
                    return OrdCollChanged.DisplayValue;
                case "OrdDelChanged":
                    return OrdDelChanged.DisplayValue;
                case "OrdTescoRef":
                    return OrdTescoRef.DisplayValue;
                case "OrdCreatedBy":
                    return OrdCreatedBy.DisplayValue;
                case "OrdEMTo":
                    return OrdEMTo.DisplayValue;
                case "OrdFaxTo":
                    return OrdFaxTo.DisplayValue;
                case "OrdAgentId":
                    return OrdAgentId.DisplayValue;
                case "OrdAgent":
                    return OrdAgent.DisplayValue;
                case "OrdAADSys":
                    return OrdAADSys.DisplayValue;
                case "OrdARCRef":
                    return OrdARCRef.DisplayValue;
                case "OrdGBWKNoFrom":
                    return OrdGBWKNoFrom.DisplayValue;
                case "OrdGBWKNo":
                    return OrdGBWKNo.DisplayValue;
                case "OrdTescoPSWk":
                    return OrdTescoPSWk.DisplayValue;
                case "OrdCollectCtry":
                    return OrdCollectCtry.DisplayValue;
                case "OrdSelEMTo":
                    return OrdSelEMTo.DisplayValue;
                case "OrdSelFaxTo":
                    return OrdSelFaxTo.DisplayValue;
                case "OrdConsOrd":
                    return OrdConsOrd.DisplayValue;
                case "OrdCustName":
                    return OrdCustName.DisplayValue;
                case "OrdDelRef":
                    return OrdDelRef.DisplayValue;
            }
            return "";
        }

        public string GetValue(string DFName)
        {
            switch (DFName)
            {
                case "OrdExpImp":
                    return OrdExpImp.Value.ToString();
                case "OrdId":
                    return OrdId.Value.ToString();
                case "OrdCustOrd":
                    return OrdCustOrd.Value.ToString();
                case "OrdDate":
                    return OrdDate.Value.ToString();
                case "OrdStatus":
                    return OrdStatus.Value.ToString();
                case "OrdReqDate":
                    return OrdReqDate.Value.ToString();
                case "OrdSupp":
                    return OrdSupp.Value.ToString();
                case "OrdSupPC":
                    return OrdSupPC.Value.ToString();
                case "OrdCollPoint":
                    return OrdCollPoint.Value.ToString();
                case "OrdCollPointPC":
                    return OrdCollPointPC.Value.ToString();
                case "OrdSuppRef":
                    return OrdSuppRef.Value.ToString();
                case "OrdConsign":
                    return OrdConsign.Value.ToString();
                case "OrdConsignPC":
                    return OrdConsignPC.Value.ToString();
                case "OrdDelPoint":
                    return OrdDelPoint.Value.ToString();
                case "OrdDelPointPC":
                    return OrdDelPointPC.Value.ToString();
                case "OrdVATPaidBy":
                    return OrdVATPaidBy.Value.ToString();
                case "OrdVATNo":
                    return OrdVATNo.Value.ToString();
                case "OrdDANNoFrom":
                    return OrdDANNoFrom.Value.ToString();
                case "OrdDANNo":
                    return OrdDANNo.Value.ToString();
                case "OrdBondFrom":
                    return OrdBondFrom.Value.ToString();
                case "OrdBondCode":
                    return OrdBondCode.Value.ToString();
                case "OrdCust":
                    return OrdCust.Value.ToString();
                case "OrdCustPC":
                    return OrdCustPC.Value.ToString();
                case "OrdDateAvail":
                    return OrdDateAvail.Value.ToString();
                case "OrdJob":
                    return OrdJob.Value.ToString();
                case "OrdCollDate":
                    return OrdCollDate.Value.ToString();
                case "OrdCollDate2":
                    return OrdCollDate2.Value.ToString();
                case "OrdDateDel":
                    return OrdDateDel.Value.ToString();
                case "OrdNotes":
                    return OrdNotes.Value.ToString();
                case "OrdJobNo":
                    return OrdJobNo.Value.ToString();
                case "OrdJobLetter":
                    return OrdJobLetter.Value.ToString();
                case "OrdInvoiced":
                    return OrdInvoiced.Value.ToString();
                case "OrdFreightInv":
                    return OrdFreightInv.Value.ToString();
                case "OrdTimeAvail":
                    return OrdTimeAvail.Value.ToString();
                case "OrdDutyInv":
                    return OrdDutyInv.Value.ToString();
                case "OrdPriceAllowed":
                    return OrdPriceAllowed.Value.ToString();
                case "OrdReqdChanged":
                    return OrdReqdChanged.Value.ToString();
                case "OrdAvailChanged":
                    return OrdAvailChanged.Value.ToString();
                case "OrdCollChanged":
                    return OrdCollChanged.Value.ToString();
                case "OrdDelChanged":
                    return OrdDelChanged.Value.ToString();
                case "OrdTescoRef":
                    return OrdTescoRef.Value.ToString();
                case "OrdCreatedBy":
                    return OrdCreatedBy.Value.ToString();
                case "OrdEMTo":
                    return OrdEMTo.Value.ToString();
                case "OrdFaxTo":
                    return OrdFaxTo.Value.ToString();
                case "OrdAgentId":
                    return OrdAgentId.Value.ToString();
                case "OrdAgent":
                    return OrdAgent.Value.ToString();
                case "OrdAADSys":
                    return OrdAADSys.Value.ToString();
                case "OrdARCRef":
                    return OrdARCRef.Value.ToString();
                case "OrdGBWKNoFrom":
                    return OrdGBWKNoFrom.Value.ToString();
                case "OrdGBWKNo":
                    return OrdGBWKNo.Value.ToString();
                case "OrdTescoPSWk":
                    return OrdTescoPSWk.Value.ToString();
                case "OrdCollectCtry":
                    return OrdCollectCtry.Value.ToString();
                case "OrdSelEMTo":
                    return OrdSelEMTo.Value.ToString();
                case "OrdSelFaxTo":
                    return OrdSelFaxTo.Value.ToString();
                case "OrdConsOrd":
                    return OrdConsOrd.Value.ToString();
                case "OrdCustName":
                    return OrdCustName.Value.ToString();
                case "OrdDelRef":
                    return OrdDelRef.Value.ToString();
            }
            return "";
        }


        public static List<IScreen> DefaultSubForms
        {
            get
            {
                List<IScreen> scrns = new List<IScreen>();

                scrns.Add(new OrderLine_ListScreen());
                scrns.Add(new EADNum_ListScreen());
                scrns.Add(new CertShip_ListScreen());
                scrns.Add(new CN_ListScreen());
                scrns.Add(new Inv_ListScreen());
                return scrns;
            }
        }
        private List<IScreen> _CachedSubForms;
        public List<IScreen> CachedSubForms
        {
            get
            {
                if (_CachedSubForms == null)
                {
                    _CachedSubForms = DefaultSubForms;
                    foreach (var itm in DS.GetManager<Orders>().OnDrawScreens)
                    {
                        _CachedSubForms = itm(this, _CachedSubForms);
                    }
                }
                return _CachedSubForms;
            }
        }

        private List<OrderLine> _ChildOrderLine;
        public List<OrderLine> OrderLines
        {
            get
            {
                if (_ChildOrderLine == null)
                {
                    //MM: Check for User Filter here, maybe needed?
                    _ChildOrderLine = IQApp.DB.Load<OrderLine>("select * from OrderLine where OrdLOrder=@itm", new { itm = this.OrdId.Value }).ToList();

                }
                return _ChildOrderLine;
            }
            set { }
        }
        public int OrderLineCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from OrderLine where OrdLOrder=@itm", new { itm = this.OrdId.Value }));
            }
            set { }
        }

        private List<EADNum> _ChildEADNum;
        public List<EADNum> EADNums
        {
            get
            {
                if (_ChildEADNum == null)
                {
                    //MM: Check for User Filter here, maybe needed?
                    _ChildEADNum = IQApp.DB.Load<EADNum>("select * from EADNum where EADOrder=@itm", new { itm = this.OrdId.Value }).ToList();

                }
                return _ChildEADNum;
            }
            set { }
        }
        public int EADNumCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from EADNum where EADOrder=@itm", new { itm = this.OrdId.Value }));
            }
            set { }
        }

        private List<CertShip> _ChildCertShip;
        public List<CertShip> CertShips
        {
            get
            {
                if (_ChildCertShip == null)
                {
                    //MM: Check for User Filter here, maybe needed?
                    _ChildCertShip = IQApp.DB.Load<CertShip>("select * from CertShip where CSOrder=@itm", new { itm = this.OrdId.Value }).ToList();

                }
                return _ChildCertShip;
            }
            set { }
        }
        public int CertShipCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CertShip where CSOrder=@itm", new { itm = this.OrdId.Value }));
            }
            set { }
        }

        private List<CN> _ChildCN;
        public List<CN> CNs
        {
            get
            {
                if (_ChildCN == null)
                {
                    //MM: Check for User Filter here, maybe needed?
                    _ChildCN = IQApp.DB.Load<CN>("select * from CN where CNOrder=@itm", new { itm = this.OrdId.Value }).ToList();

                }
                return _ChildCN;
            }
            set { }
        }
        public int CNCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CN where CNOrder=@itm", new { itm = this.OrdId.Value }));
            }
            set { }
        }

        private List<Inv> _ChildInv;
        public List<Inv> Invs
        {
            get
            {
                if (_ChildInv == null)
                {
                    //MM: Check for User Filter here, maybe needed?
                    _ChildInv = IQApp.DB.Load<Inv>("select * from Inv where InvOrder=@itm", new { itm = this.OrdId.Value }).ToList();

                }
                return _ChildInv;
            }
            set { }
        }
        public int InvCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Inv where InvOrder=@itm", new { itm = this.OrdId.Value }));
            }
            set { }
        }


        public Orders() : base("Orders")
        {
            base.obj = this;

            OrdExpImp = new Orders_OrdExpImp(this);
            OrdId = new Orders_OrdId(this);
            OrdCustOrd = new Orders_OrdCustOrd(this);
            OrdDate = new Orders_OrdDate(this);
            OrdStatus = new Orders_OrdStatus(this);
            OrdReqDate = new Orders_OrdReqDate(this);
            OrdSupp = new Orders_OrdSupp(this);
            OrdSupPC = new Orders_OrdSupPC(this);
            OrdCollPoint = new Orders_OrdCollPoint(this);
            OrdCollPointPC = new Orders_OrdCollPointPC(this);
            OrdSuppRef = new Orders_OrdSuppRef(this);
            OrdConsign = new Orders_OrdConsign(this);
            OrdConsignPC = new Orders_OrdConsignPC(this);
            OrdDelPoint = new Orders_OrdDelPoint(this);
            OrdDelPointPC = new Orders_OrdDelPointPC(this);
            OrdVATPaidBy = new Orders_OrdVATPaidBy(this);
            OrdVATNo = new Orders_OrdVATNo(this);
            OrdDANNoFrom = new Orders_OrdDANNoFrom(this);
            OrdDANNo = new Orders_OrdDANNo(this);
            OrdBondFrom = new Orders_OrdBondFrom(this);
            OrdBondCode = new Orders_OrdBondCode(this);
            OrdCust = new Orders_OrdCust(this);
            OrdCustPC = new Orders_OrdCustPC(this);
            OrdDateAvail = new Orders_OrdDateAvail(this);
            OrdJob = new Orders_OrdJob(this);
            OrdCollDate = new Orders_OrdCollDate(this);
            OrdCollDate2 = new Orders_OrdCollDate2(this);
            OrdDateDel = new Orders_OrdDateDel(this);
            OrdNotes = new Orders_OrdNotes(this);
            OrdJobNo = new Orders_OrdJobNo(this);
            OrdJobLetter = new Orders_OrdJobLetter(this);
            OrdInvoiced = new Orders_OrdInvoiced(this);
            OrdFreightInv = new Orders_OrdFreightInv(this);
            OrdTimeAvail = new Orders_OrdTimeAvail(this);
            OrdDutyInv = new Orders_OrdDutyInv(this);
            OrdPriceAllowed = new Orders_OrdPriceAllowed(this);
            OrdReqdChanged = new Orders_OrdReqdChanged(this);
            OrdAvailChanged = new Orders_OrdAvailChanged(this);
            OrdCollChanged = new Orders_OrdCollChanged(this);
            OrdDelChanged = new Orders_OrdDelChanged(this);
            OrdTescoRef = new Orders_OrdTescoRef(this);
            OrdCreatedBy = new Orders_OrdCreatedBy(this);
            OrdEMTo = new Orders_OrdEMTo(this);
            OrdFaxTo = new Orders_OrdFaxTo(this);
            OrdAgentId = new Orders_OrdAgentId(this);
            OrdAgent = new Orders_OrdAgent(this);
            OrdAADSys = new Orders_OrdAADSys(this);
            OrdARCRef = new Orders_OrdARCRef(this);
            OrdGBWKNoFrom = new Orders_OrdGBWKNoFrom(this);
            OrdGBWKNo = new Orders_OrdGBWKNo(this);
            OrdTescoPSWk = new Orders_OrdTescoPSWk(this);
            OrdCollectCtry = new Orders_OrdCollectCtry(this);
            OrdSelEMTo = new Orders_OrdSelEMTo(this);
            OrdSelFaxTo = new Orders_OrdSelFaxTo(this);
            OrdConsOrd = new Orders_OrdConsOrd(this);
            OrdCustName = new Orders_OrdCustName(this);
            OrdDelRef = new Orders_OrdDelRef(this);
        }

        static Orders()
        {
            OrdExpImpField = new Orders_OrdExpImpFieldDef();
            OrdIdField = new Orders_OrdIdFieldDef();
            OrdCustOrdField = new Orders_OrdCustOrdFieldDef();
            OrdDateField = new Orders_OrdDateFieldDef();
            OrdStatusField = new Orders_OrdStatusFieldDef();
            OrdReqDateField = new Orders_OrdReqDateFieldDef();
            OrdSuppField = new Orders_OrdSuppFieldDef();
            OrdSupPCField = new Orders_OrdSupPCFieldDef();
            OrdCollPointField = new Orders_OrdCollPointFieldDef();
            OrdCollPointPCField = new Orders_OrdCollPointPCFieldDef();
            OrdSuppRefField = new Orders_OrdSuppRefFieldDef();
            OrdConsignField = new Orders_OrdConsignFieldDef();
            OrdConsignPCField = new Orders_OrdConsignPCFieldDef();
            OrdDelPointField = new Orders_OrdDelPointFieldDef();
            OrdDelPointPCField = new Orders_OrdDelPointPCFieldDef();
            OrdVATPaidByField = new Orders_OrdVATPaidByFieldDef();
            OrdVATNoField = new Orders_OrdVATNoFieldDef();
            OrdDANNoFromField = new Orders_OrdDANNoFromFieldDef();
            OrdDANNoField = new Orders_OrdDANNoFieldDef();
            OrdBondFromField = new Orders_OrdBondFromFieldDef();
            OrdBondCodeField = new Orders_OrdBondCodeFieldDef();
            OrdCustField = new Orders_OrdCustFieldDef();
            OrdCustPCField = new Orders_OrdCustPCFieldDef();
            OrdDateAvailField = new Orders_OrdDateAvailFieldDef();
            OrdJobField = new Orders_OrdJobFieldDef();
            OrdCollDateField = new Orders_OrdCollDateFieldDef();
            OrdCollDate2Field = new Orders_OrdCollDate2FieldDef();
            OrdDateDelField = new Orders_OrdDateDelFieldDef();
            OrdNotesField = new Orders_OrdNotesFieldDef();
            OrdJobNoField = new Orders_OrdJobNoFieldDef();
            OrdJobLetterField = new Orders_OrdJobLetterFieldDef();
            OrdInvoicedField = new Orders_OrdInvoicedFieldDef();
            OrdFreightInvField = new Orders_OrdFreightInvFieldDef();
            OrdTimeAvailField = new Orders_OrdTimeAvailFieldDef();
            OrdDutyInvField = new Orders_OrdDutyInvFieldDef();
            OrdPriceAllowedField = new Orders_OrdPriceAllowedFieldDef();
            OrdReqdChangedField = new Orders_OrdReqdChangedFieldDef();
            OrdAvailChangedField = new Orders_OrdAvailChangedFieldDef();
            OrdCollChangedField = new Orders_OrdCollChangedFieldDef();
            OrdDelChangedField = new Orders_OrdDelChangedFieldDef();
            OrdTescoRefField = new Orders_OrdTescoRefFieldDef();
            OrdCreatedByField = new Orders_OrdCreatedByFieldDef();
            OrdEMToField = new Orders_OrdEMToFieldDef();
            OrdFaxToField = new Orders_OrdFaxToFieldDef();
            OrdAgentIdField = new Orders_OrdAgentIdFieldDef();
            OrdAgentField = new Orders_OrdAgentFieldDef();
            OrdAADSysField = new Orders_OrdAADSysFieldDef();
            OrdARCRefField = new Orders_OrdARCRefFieldDef();
            OrdGBWKNoFromField = new Orders_OrdGBWKNoFromFieldDef();
            OrdGBWKNoField = new Orders_OrdGBWKNoFieldDef();
            OrdTescoPSWkField = new Orders_OrdTescoPSWkFieldDef();
            OrdCollectCtryField = new Orders_OrdCollectCtryFieldDef();
            OrdSelEMToField = new Orders_OrdSelEMToFieldDef();
            OrdSelFaxToField = new Orders_OrdSelFaxToFieldDef();
            OrdConsOrdField = new Orders_OrdConsOrdFieldDef();
            OrdCustNameField = new Orders_OrdCustNameFieldDef();
            OrdDelRefField = new Orders_OrdDelRefFieldDef();
        }

        public string RecordTitle
        {
            get { return OrdIdValue.ToString(); }
        }

        public string DSNiceName
        {
            get { return "Orders"; }
        }


        public string DataUrl
        {
            get
            {
                if (RecordID.HasValue)
                {
                    return "/Orders/Load/?RecId=" + RecordID.Value;
                }
                return "/Orders/Add";
            }
        }



        [Ignore()]
        public Orders_OrdExpImp OrdExpImp { get; set; }
        public static Orders_OrdExpImpFieldDef OrdExpImpField { get; private set; }


        [Column("OrdExpImp")]
        public int PopulateOrdExpImp
        {
            get { return OrdExpImpValue; }
            set { OrdExpImp.DataValue = value; }
        }


        public int OrdExpImpValue
        {
            get
            {
                if (OrdExpImp.Value != null)
                {
                    int i = 0;
                    if (OrdExpImp != null)
                    {
                        if (OrdExpImp.Value != null)
                        {
                            if (Int32.TryParse(OrdExpImp.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdExpImp.Value = value; }
        }


        [Ignore()]
        public Orders_OrdId OrdId { get; set; }
        public static Orders_OrdIdFieldDef OrdIdField { get; private set; }


        [Column("OrdId")]
        public int PopulateOrdId
        {
            get { return OrdIdValue; }
            set { OrdId.DataValue = value; }
        }


        public int OrdIdValue
        {
            get
            {
                if (OrdId.Value != null)
                {
                    int i = 0;
                    if (OrdId != null)
                    {
                        if (OrdId.Value != null)
                        {
                            if (Int32.TryParse(OrdId.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdId.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCustOrd OrdCustOrd { get; set; }
        public static Orders_OrdCustOrdFieldDef OrdCustOrdField { get; private set; }


        [Column("OrdCustOrd")]
        public string PopulateOrdCustOrd
        {
            get { return OrdCustOrdValue; }
            set { OrdCustOrd.DataValue = value; }
        }


        public string OrdCustOrdValue
        {
            get
            {
                if (OrdCustOrd.Value != null)
                {
                    return OrdCustOrd.Value.ToString();
                }
                return "";

            }
            set { OrdCustOrd.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDate OrdDate { get; set; }
        public static Orders_OrdDateFieldDef OrdDateField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdDate")]
        public DateTime PopulateOrdDate
        {
            get { return OrdDateValue; }
            set { OrdDate.DataValue = value; }
        }


        public DateTime OrdDateValue
        {
            get
            {
                if (OrdDate.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdDate != null)
                    {
                        if (OrdDate.Value != null)
                        {
                            if (DateTime.TryParse(OrdDate.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdDate.Value = value; }
        }


        [Ignore()]
        public Orders_OrdStatus OrdStatus { get; set; }
        public static Orders_OrdStatusFieldDef OrdStatusField { get; private set; }


        [Column("OrdStatus")]
        public int PopulateOrdStatus
        {
            get { return OrdStatusValue; }
            set { OrdStatus.DataValue = value; }
        }


        public int OrdStatusValue
        {
            get
            {
                if (OrdStatus.Value != null)
                {
                    int i = 0;
                    if (OrdStatus != null)
                    {
                        if (OrdStatus.Value != null)
                        {
                            if (Int32.TryParse(OrdStatus.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdStatus.Value = value; }
        }


        [Ignore()]
        public Orders_OrdReqDate OrdReqDate { get; set; }
        public static Orders_OrdReqDateFieldDef OrdReqDateField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdReqDate")]
        public DateTime PopulateOrdReqDate
        {
            get { return OrdReqDateValue; }
            set { OrdReqDate.DataValue = value; }
        }


        public DateTime OrdReqDateValue
        {
            get
            {
                if (OrdReqDate.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdReqDate != null)
                    {
                        if (OrdReqDate.Value != null)
                        {
                            if (DateTime.TryParse(OrdReqDate.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdReqDate.Value = value; }
        }


        [Ignore()]
        public Orders_OrdSupp OrdSupp { get; set; }
        public static Orders_OrdSuppFieldDef OrdSuppField { get; private set; }


        [Column("OrdSupp")]
        public int PopulateOrdSupp
        {
            get { return OrdSuppValue; }
            set { OrdSupp.DataValue = value; }
        }


        public int OrdSuppValue
        {
            get
            {
                if (OrdSupp.Value != null)
                {
                    int i = 0;
                    if (OrdSupp != null)
                    {
                        if (OrdSupp.Value != null)
                        {
                            if (Int32.TryParse(OrdSupp.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdSupp.Value = value; }
        }


        [Ignore()]
        public Orders_OrdSupPC OrdSupPC { get; set; }
        public static Orders_OrdSupPCFieldDef OrdSupPCField { get; private set; }


        [Column("OrdSupPC")]
        public string PopulateOrdSupPC
        {
            get { return OrdSupPCValue; }
            set { OrdSupPC.DataValue = value; }
        }


        public string OrdSupPCValue
        {
            get
            {
                if (OrdSupPC.Value != null)
                {
                    return OrdSupPC.Value.ToString();
                }
                return "";

            }
            set { OrdSupPC.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCollPoint OrdCollPoint { get; set; }
        public static Orders_OrdCollPointFieldDef OrdCollPointField { get; private set; }


        [Column("OrdCollPoint")]
        public int PopulateOrdCollPoint
        {
            get { return OrdCollPointValue; }
            set { OrdCollPoint.DataValue = value; }
        }


        public int OrdCollPointValue
        {
            get
            {
                if (OrdCollPoint.Value != null)
                {
                    int i = 0;
                    if (OrdCollPoint != null)
                    {
                        if (OrdCollPoint.Value != null)
                        {
                            if (Int32.TryParse(OrdCollPoint.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdCollPoint.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCollPointPC OrdCollPointPC { get; set; }
        public static Orders_OrdCollPointPCFieldDef OrdCollPointPCField { get; private set; }


        [Column("OrdCollPointPC")]
        public string PopulateOrdCollPointPC
        {
            get { return OrdCollPointPCValue; }
            set { OrdCollPointPC.DataValue = value; }
        }


        public string OrdCollPointPCValue
        {
            get
            {
                if (OrdCollPointPC.Value != null)
                {
                    return OrdCollPointPC.Value.ToString();
                }
                return "";

            }
            set { OrdCollPointPC.Value = value; }
        }


        [Ignore()]
        public Orders_OrdSuppRef OrdSuppRef { get; set; }
        public static Orders_OrdSuppRefFieldDef OrdSuppRefField { get; private set; }


        [Column("OrdSuppRef")]
        public string PopulateOrdSuppRef
        {
            get { return OrdSuppRefValue; }
            set { OrdSuppRef.DataValue = value; }
        }


        public string OrdSuppRefValue
        {
            get
            {
                if (OrdSuppRef.Value != null)
                {
                    return OrdSuppRef.Value.ToString();
                }
                return "";

            }
            set { OrdSuppRef.Value = value; }
        }


        [Ignore()]
        public Orders_OrdConsign OrdConsign { get; set; }
        public static Orders_OrdConsignFieldDef OrdConsignField { get; private set; }


        [Column("OrdConsign")]
        public int PopulateOrdConsign
        {
            get { return OrdConsignValue; }
            set { OrdConsign.DataValue = value; }
        }


        public int OrdConsignValue
        {
            get
            {
                if (OrdConsign.Value != null)
                {
                    int i = 0;
                    if (OrdConsign != null)
                    {
                        if (OrdConsign.Value != null)
                        {
                            if (Int32.TryParse(OrdConsign.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdConsign.Value = value; }
        }


        [Ignore()]
        public Orders_OrdConsignPC OrdConsignPC { get; set; }
        public static Orders_OrdConsignPCFieldDef OrdConsignPCField { get; private set; }


        [Column("OrdConsignPC")]
        public string PopulateOrdConsignPC
        {
            get { return OrdConsignPCValue; }
            set { OrdConsignPC.DataValue = value; }
        }


        public string OrdConsignPCValue
        {
            get
            {
                if (OrdConsignPC.Value != null)
                {
                    return OrdConsignPC.Value.ToString();
                }
                return "";

            }
            set { OrdConsignPC.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDelPoint OrdDelPoint { get; set; }
        public static Orders_OrdDelPointFieldDef OrdDelPointField { get; private set; }


        [Column("OrdDelPoint")]
        public int PopulateOrdDelPoint
        {
            get { return OrdDelPointValue; }
            set { OrdDelPoint.DataValue = value; }
        }


        public int OrdDelPointValue
        {
            get
            {
                if (OrdDelPoint.Value != null)
                {
                    int i = 0;
                    if (OrdDelPoint != null)
                    {
                        if (OrdDelPoint.Value != null)
                        {
                            if (Int32.TryParse(OrdDelPoint.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdDelPoint.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDelPointPC OrdDelPointPC { get; set; }
        public static Orders_OrdDelPointPCFieldDef OrdDelPointPCField { get; private set; }


        [Column("OrdDelPointPC")]
        public string PopulateOrdDelPointPC
        {
            get { return OrdDelPointPCValue; }
            set { OrdDelPointPC.DataValue = value; }
        }


        public string OrdDelPointPCValue
        {
            get
            {
                if (OrdDelPointPC.Value != null)
                {
                    return OrdDelPointPC.Value.ToString();
                }
                return "";

            }
            set { OrdDelPointPC.Value = value; }
        }


        [Ignore()]
        public Orders_OrdVATPaidBy OrdVATPaidBy { get; set; }
        public static Orders_OrdVATPaidByFieldDef OrdVATPaidByField { get; private set; }


        [Column("OrdVATPaidBy")]
        public int PopulateOrdVATPaidBy
        {
            get { return OrdVATPaidByValue; }
            set { OrdVATPaidBy.DataValue = value; }
        }


        public int OrdVATPaidByValue
        {
            get
            {
                if (OrdVATPaidBy.Value != null)
                {
                    int i = 0;
                    if (OrdVATPaidBy != null)
                    {
                        if (OrdVATPaidBy.Value != null)
                        {
                            if (Int32.TryParse(OrdVATPaidBy.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdVATPaidBy.Value = value; }
        }


        [Ignore()]
        public Orders_OrdVATNo OrdVATNo { get; set; }
        public static Orders_OrdVATNoFieldDef OrdVATNoField { get; private set; }


        [Column("OrdVATNo")]
        public string PopulateOrdVATNo
        {
            get { return OrdVATNoValue; }
            set { OrdVATNo.DataValue = value; }
        }


        public string OrdVATNoValue
        {
            get
            {
                if (OrdVATNo.Value != null)
                {
                    return OrdVATNo.Value.ToString();
                }
                return "";

            }
            set { OrdVATNo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDANNoFrom OrdDANNoFrom { get; set; }
        public static Orders_OrdDANNoFromFieldDef OrdDANNoFromField { get; private set; }


        [Column("OrdDANNoFrom")]
        public int PopulateOrdDANNoFrom
        {
            get { return OrdDANNoFromValue; }
            set { OrdDANNoFrom.DataValue = value; }
        }


        public int OrdDANNoFromValue
        {
            get
            {
                if (OrdDANNoFrom.Value != null)
                {
                    int i = 0;
                    if (OrdDANNoFrom != null)
                    {
                        if (OrdDANNoFrom.Value != null)
                        {
                            if (Int32.TryParse(OrdDANNoFrom.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdDANNoFrom.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDANNo OrdDANNo { get; set; }
        public static Orders_OrdDANNoFieldDef OrdDANNoField { get; private set; }


        [Column("OrdDANNo")]
        public string PopulateOrdDANNo
        {
            get { return OrdDANNoValue; }
            set { OrdDANNo.DataValue = value; }
        }


        public string OrdDANNoValue
        {
            get
            {
                if (OrdDANNo.Value != null)
                {
                    return OrdDANNo.Value.ToString();
                }
                return "";

            }
            set { OrdDANNo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdBondFrom OrdBondFrom { get; set; }
        public static Orders_OrdBondFromFieldDef OrdBondFromField { get; private set; }


        [Column("OrdBondFrom")]
        public int PopulateOrdBondFrom
        {
            get { return OrdBondFromValue; }
            set { OrdBondFrom.DataValue = value; }
        }


        public int OrdBondFromValue
        {
            get
            {
                if (OrdBondFrom.Value != null)
                {
                    int i = 0;
                    if (OrdBondFrom != null)
                    {
                        if (OrdBondFrom.Value != null)
                        {
                            if (Int32.TryParse(OrdBondFrom.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdBondFrom.Value = value; }
        }


        [Ignore()]
        public Orders_OrdBondCode OrdBondCode { get; set; }
        public static Orders_OrdBondCodeFieldDef OrdBondCodeField { get; private set; }


        [Column("OrdBondCode")]
        public string PopulateOrdBondCode
        {
            get { return OrdBondCodeValue; }
            set { OrdBondCode.DataValue = value; }
        }


        public string OrdBondCodeValue
        {
            get
            {
                if (OrdBondCode.Value != null)
                {
                    return OrdBondCode.Value.ToString();
                }
                return "";

            }
            set { OrdBondCode.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCust OrdCust { get; set; }
        public static Orders_OrdCustFieldDef OrdCustField { get; private set; }


        [Column("OrdCust")]
        public int PopulateOrdCust
        {
            get { return OrdCustValue; }
            set { OrdCust.DataValue = value; }
        }


        public int OrdCustValue
        {
            get
            {
                if (OrdCust.Value != null)
                {
                    int i = 0;
                    if (OrdCust != null)
                    {
                        if (OrdCust.Value != null)
                        {
                            if (Int32.TryParse(OrdCust.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdCust.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCustPC OrdCustPC { get; set; }
        public static Orders_OrdCustPCFieldDef OrdCustPCField { get; private set; }


        [Column("OrdCustPC")]
        public string PopulateOrdCustPC
        {
            get { return OrdCustPCValue; }
            set { OrdCustPC.DataValue = value; }
        }


        public string OrdCustPCValue
        {
            get
            {
                if (OrdCustPC.Value != null)
                {
                    return OrdCustPC.Value.ToString();
                }
                return "";

            }
            set { OrdCustPC.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDateAvail OrdDateAvail { get; set; }
        public static Orders_OrdDateAvailFieldDef OrdDateAvailField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdDateAvail")]
        public DateTime PopulateOrdDateAvail
        {
            get { return OrdDateAvailValue; }
            set { OrdDateAvail.DataValue = value; }
        }


        public DateTime OrdDateAvailValue
        {
            get
            {
                if (OrdDateAvail.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdDateAvail != null)
                    {
                        if (OrdDateAvail.Value != null)
                        {
                            if (DateTime.TryParse(OrdDateAvail.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdDateAvail.Value = value; }
        }


        [Ignore()]
        public Orders_OrdJob OrdJob { get; set; }
        public static Orders_OrdJobFieldDef OrdJobField { get; private set; }


        [Column("OrdJob")]
        public string PopulateOrdJob
        {
            get { return OrdJobValue; }
            set { OrdJob.DataValue = value; }
        }


        public string OrdJobValue
        {
            get
            {
                if (OrdJob.Value != null)
                {
                    return OrdJob.Value.ToString();
                }
                return "";

            }
            set { OrdJob.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCollDate OrdCollDate { get; set; }
        public static Orders_OrdCollDateFieldDef OrdCollDateField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdCollDate")]
        public DateTime PopulateOrdCollDate
        {
            get { return OrdCollDateValue; }
            set { OrdCollDate.DataValue = value; }
        }


        public DateTime OrdCollDateValue
        {
            get
            {
                if (OrdCollDate.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdCollDate != null)
                    {
                        if (OrdCollDate.Value != null)
                        {
                            if (DateTime.TryParse(OrdCollDate.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdCollDate.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCollDate2 OrdCollDate2 { get; set; }
        public static Orders_OrdCollDate2FieldDef OrdCollDate2Field { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdCollDate2")]
        public DateTime PopulateOrdCollDate2
        {
            get { return OrdCollDate2Value; }
            set { OrdCollDate2.DataValue = value; }
        }


        public DateTime OrdCollDate2Value
        {
            get
            {
                if (OrdCollDate2.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdCollDate2 != null)
                    {
                        if (OrdCollDate2.Value != null)
                        {
                            if (DateTime.TryParse(OrdCollDate2.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdCollDate2.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDateDel OrdDateDel { get; set; }
        public static Orders_OrdDateDelFieldDef OrdDateDelField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdDateDel")]
        public DateTime PopulateOrdDateDel
        {
            get { return OrdDateDelValue; }
            set { OrdDateDel.DataValue = value; }
        }


        public DateTime OrdDateDelValue
        {
            get
            {
                if (OrdDateDel.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdDateDel != null)
                    {
                        if (OrdDateDel.Value != null)
                        {
                            if (DateTime.TryParse(OrdDateDel.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdDateDel.Value = value; }
        }


        [Ignore()]
        public Orders_OrdNotes OrdNotes { get; set; }
        public static Orders_OrdNotesFieldDef OrdNotesField { get; private set; }


        [Column("OrdNotes")]
        public string PopulateOrdNotes
        {
            get { return OrdNotesValue; }
            set { OrdNotes.DataValue = value; }
        }


        public string OrdNotesValue
        {
            get
            {
                if (OrdNotes.Value != null)
                {
                    return OrdNotes.Value.ToString();
                }
                return "";

            }
            set { OrdNotes.Value = value; }
        }


        [Ignore()]
        public Orders_OrdJobNo OrdJobNo { get; set; }
        public static Orders_OrdJobNoFieldDef OrdJobNoField { get; private set; }


        [Column("OrdJobNo")]
        public int PopulateOrdJobNo
        {
            get { return OrdJobNoValue; }
            set { OrdJobNo.DataValue = value; }
        }


        public int OrdJobNoValue
        {
            get
            {
                if (OrdJobNo.Value != null)
                {
                    int i = 0;
                    if (OrdJobNo != null)
                    {
                        if (OrdJobNo.Value != null)
                        {
                            if (Int32.TryParse(OrdJobNo.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdJobNo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdJobLetter OrdJobLetter { get; set; }
        public static Orders_OrdJobLetterFieldDef OrdJobLetterField { get; private set; }


        [Column("OrdJobLetter")]
        public string PopulateOrdJobLetter
        {
            get { return OrdJobLetterValue; }
            set { OrdJobLetter.DataValue = value; }
        }


        public string OrdJobLetterValue
        {
            get
            {
                if (OrdJobLetter.Value != null)
                {
                    return OrdJobLetter.Value.ToString();
                }
                return "";

            }
            set { OrdJobLetter.Value = value; }
        }


        [Ignore()]
        public Orders_OrdInvoiced OrdInvoiced { get; set; }
        public static Orders_OrdInvoicedFieldDef OrdInvoicedField { get; private set; }


        [Column("OrdInvoiced")]
        public bool PopulateOrdInvoiced
        {
            get { return OrdInvoicedValue; }
            set { OrdInvoiced.DataValue = value; }
        }


        public bool OrdInvoicedValue
        {
            get
            {
                if (OrdInvoiced.Value != null)
                {
                    bool i = false;
                    if (OrdInvoiced != null)
                    {
                        if (OrdInvoiced.Value != null)
                        {
                            if (Boolean.TryParse(OrdInvoiced.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return false;

            }
            set { OrdInvoiced.Value = value; }
        }


        [Ignore()]
        public Orders_OrdFreightInv OrdFreightInv { get; set; }
        public static Orders_OrdFreightInvFieldDef OrdFreightInvField { get; private set; }


        [Column("OrdFreightInv")]
        public string PopulateOrdFreightInv
        {
            get { return OrdFreightInvValue; }
            set { OrdFreightInv.DataValue = value; }
        }


        public string OrdFreightInvValue
        {
            get
            {
                if (OrdFreightInv.Value != null)
                {
                    return OrdFreightInv.Value.ToString();
                }
                return "";

            }
            set { OrdFreightInv.Value = value; }
        }


        [Ignore()]
        public Orders_OrdTimeAvail OrdTimeAvail { get; set; }
        public static Orders_OrdTimeAvailFieldDef OrdTimeAvailField { get; private set; }


        [Column("OrdTimeAvail")]
        public TimeSpan PopulateOrdTimeAvail
        {
            get { return OrdTimeAvailValue; }
            set { OrdTimeAvail.DataValue = value; }
        }


        public TimeSpan OrdTimeAvailValue
        {
            get
            {
                if (OrdTimeAvail.Value != null)
                {
                    TimeSpan i = TimeSpan.MinValue;
                    if (OrdTimeAvail != null)
                    {
                        if (OrdTimeAvail.Value != null)
                        {
                            if (TimeSpan.TryParse(OrdTimeAvail.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return TimeSpan.MinValue;

            }
            set { OrdTimeAvail.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDutyInv OrdDutyInv { get; set; }
        public static Orders_OrdDutyInvFieldDef OrdDutyInvField { get; private set; }


        [Column("OrdDutyInv")]
        public string PopulateOrdDutyInv
        {
            get { return OrdDutyInvValue; }
            set { OrdDutyInv.DataValue = value; }
        }


        public string OrdDutyInvValue
        {
            get
            {
                if (OrdDutyInv.Value != null)
                {
                    return OrdDutyInv.Value.ToString();
                }
                return "";

            }
            set { OrdDutyInv.Value = value; }
        }


        [Ignore()]
        public Orders_OrdPriceAllowed OrdPriceAllowed { get; set; }
        public static Orders_OrdPriceAllowedFieldDef OrdPriceAllowedField { get; private set; }


        [Column("OrdPriceAllowed")]
        public double PopulateOrdPriceAllowed
        {
            get { return OrdPriceAllowedValue; }
            set { OrdPriceAllowed.DataValue = value; }
        }


        public double OrdPriceAllowedValue
        {
            get
            {
                if (OrdPriceAllowed.Value != null)
                {
                    double i = 0.0;
                    if (OrdPriceAllowed != null)
                    {
                        if (OrdPriceAllowed.Value != null)
                        {
                            if (Double.TryParse(OrdPriceAllowed.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0.0;

            }
            set { OrdPriceAllowed.Value = value; }
        }


        [Ignore()]
        public Orders_OrdReqdChanged OrdReqdChanged { get; set; }
        public static Orders_OrdReqdChangedFieldDef OrdReqdChangedField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdReqdChanged")]
        public DateTime PopulateOrdReqdChanged
        {
            get { return OrdReqdChangedValue; }
            set { OrdReqdChanged.DataValue = value; }
        }


        public DateTime OrdReqdChangedValue
        {
            get
            {
                if (OrdReqdChanged.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdReqdChanged != null)
                    {
                        if (OrdReqdChanged.Value != null)
                        {
                            if (DateTime.TryParse(OrdReqdChanged.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdReqdChanged.Value = value; }
        }


        [Ignore()]
        public Orders_OrdAvailChanged OrdAvailChanged { get; set; }
        public static Orders_OrdAvailChangedFieldDef OrdAvailChangedField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdAvailChanged")]
        public DateTime PopulateOrdAvailChanged
        {
            get { return OrdAvailChangedValue; }
            set { OrdAvailChanged.DataValue = value; }
        }


        public DateTime OrdAvailChangedValue
        {
            get
            {
                if (OrdAvailChanged.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdAvailChanged != null)
                    {
                        if (OrdAvailChanged.Value != null)
                        {
                            if (DateTime.TryParse(OrdAvailChanged.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdAvailChanged.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCollChanged OrdCollChanged { get; set; }
        public static Orders_OrdCollChangedFieldDef OrdCollChangedField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdCollChanged")]
        public DateTime PopulateOrdCollChanged
        {
            get { return OrdCollChangedValue; }
            set { OrdCollChanged.DataValue = value; }
        }


        public DateTime OrdCollChangedValue
        {
            get
            {
                if (OrdCollChanged.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdCollChanged != null)
                    {
                        if (OrdCollChanged.Value != null)
                        {
                            if (DateTime.TryParse(OrdCollChanged.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdCollChanged.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDelChanged OrdDelChanged { get; set; }
        public static Orders_OrdDelChangedFieldDef OrdDelChangedField { get; private set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]

        [Column("OrdDelChanged")]
        public DateTime PopulateOrdDelChanged
        {
            get { return OrdDelChangedValue; }
            set { OrdDelChanged.DataValue = value; }
        }


        public DateTime OrdDelChangedValue
        {
            get
            {
                if (OrdDelChanged.Value != null)
                {
                    DateTime i = DateTime.MinValue;
                    if (OrdDelChanged != null)
                    {
                        if (OrdDelChanged.Value != null)
                        {
                            if (DateTime.TryParse(OrdDelChanged.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return DateTime.MinValue;

            }
            set { OrdDelChanged.Value = value; }
        }


        [Ignore()]
        public Orders_OrdTescoRef OrdTescoRef { get; set; }
        public static Orders_OrdTescoRefFieldDef OrdTescoRefField { get; private set; }


        [Column("OrdTescoRef")]
        public string PopulateOrdTescoRef
        {
            get { return OrdTescoRefValue; }
            set { OrdTescoRef.DataValue = value; }
        }


        public string OrdTescoRefValue
        {
            get
            {
                if (OrdTescoRef.Value != null)
                {
                    return OrdTescoRef.Value.ToString();
                }
                return "";

            }
            set { OrdTescoRef.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCreatedBy OrdCreatedBy { get; set; }
        public static Orders_OrdCreatedByFieldDef OrdCreatedByField { get; private set; }


        [Column("OrdCreatedBy")]
        public int PopulateOrdCreatedBy
        {
            get { return OrdCreatedByValue; }
            set { OrdCreatedBy.DataValue = value; }
        }


        public int OrdCreatedByValue
        {
            get
            {
                if (OrdCreatedBy.Value != null)
                {
                    int i = 0;
                    if (OrdCreatedBy != null)
                    {
                        if (OrdCreatedBy.Value != null)
                        {
                            if (Int32.TryParse(OrdCreatedBy.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdCreatedBy.Value = value; }
        }


        [Ignore()]
        public Orders_OrdEMTo OrdEMTo { get; set; }
        public static Orders_OrdEMToFieldDef OrdEMToField { get; private set; }


        [Column("OrdEMTo")]
        public string PopulateOrdEMTo
        {
            get { return OrdEMToValue; }
            set { OrdEMTo.DataValue = value; }
        }


        public string OrdEMToValue
        {
            get
            {
                if (OrdEMTo.Value != null)
                {
                    return OrdEMTo.Value.ToString();
                }
                return "";

            }
            set { OrdEMTo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdFaxTo OrdFaxTo { get; set; }
        public static Orders_OrdFaxToFieldDef OrdFaxToField { get; private set; }


        [Column("OrdFaxTo")]
        public string PopulateOrdFaxTo
        {
            get { return OrdFaxToValue; }
            set { OrdFaxTo.DataValue = value; }
        }


        public string OrdFaxToValue
        {
            get
            {
                if (OrdFaxTo.Value != null)
                {
                    return OrdFaxTo.Value.ToString();
                }
                return "";

            }
            set { OrdFaxTo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdAgentId OrdAgentId { get; set; }
        public static Orders_OrdAgentIdFieldDef OrdAgentIdField { get; private set; }


        [Column("OrdAgentId")]
        public int PopulateOrdAgentId
        {
            get { return OrdAgentIdValue; }
            set { OrdAgentId.DataValue = value; }
        }


        public int OrdAgentIdValue
        {
            get
            {
                if (OrdAgentId.Value != null)
                {
                    int i = 0;
                    if (OrdAgentId != null)
                    {
                        if (OrdAgentId.Value != null)
                        {
                            if (Int32.TryParse(OrdAgentId.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdAgentId.Value = value; }
        }


        [Ignore()]
        public Orders_OrdAgent OrdAgent { get; set; }
        public static Orders_OrdAgentFieldDef OrdAgentField { get; private set; }


        [Column("OrdAgent")]
        public int PopulateOrdAgent
        {
            get { return OrdAgentValue; }
            set { OrdAgent.DataValue = value; }
        }


        public int OrdAgentValue
        {
            get
            {
                if (OrdAgent.Value != null)
                {
                    int i = 0;
                    if (OrdAgent != null)
                    {
                        if (OrdAgent.Value != null)
                        {
                            if (Int32.TryParse(OrdAgent.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdAgent.Value = value; }
        }


        [Ignore()]
        public Orders_OrdAADSys OrdAADSys { get; set; }
        public static Orders_OrdAADSysFieldDef OrdAADSysField { get; private set; }


        [Column("OrdAADSys")]
        public int PopulateOrdAADSys
        {
            get { return OrdAADSysValue; }
            set { OrdAADSys.DataValue = value; }
        }


        public int OrdAADSysValue
        {
            get
            {
                if (OrdAADSys.Value != null)
                {
                    int i = 0;
                    if (OrdAADSys != null)
                    {
                        if (OrdAADSys.Value != null)
                        {
                            if (Int32.TryParse(OrdAADSys.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdAADSys.Value = value; }
        }


        [Ignore()]
        public Orders_OrdARCRef OrdARCRef { get; set; }
        public static Orders_OrdARCRefFieldDef OrdARCRefField { get; private set; }


        [Column("OrdARCRef")]
        public string PopulateOrdARCRef
        {
            get { return OrdARCRefValue; }
            set { OrdARCRef.DataValue = value; }
        }


        public string OrdARCRefValue
        {
            get
            {
                if (OrdARCRef.Value != null)
                {
                    return OrdARCRef.Value.ToString();
                }
                return "";

            }
            set { OrdARCRef.Value = value; }
        }


        [Ignore()]
        public Orders_OrdGBWKNoFrom OrdGBWKNoFrom { get; set; }
        public static Orders_OrdGBWKNoFromFieldDef OrdGBWKNoFromField { get; private set; }


        [Column("OrdGBWKNoFrom")]
        public int PopulateOrdGBWKNoFrom
        {
            get { return OrdGBWKNoFromValue; }
            set { OrdGBWKNoFrom.DataValue = value; }
        }


        public int OrdGBWKNoFromValue
        {
            get
            {
                if (OrdGBWKNoFrom.Value != null)
                {
                    int i = 0;
                    if (OrdGBWKNoFrom != null)
                    {
                        if (OrdGBWKNoFrom.Value != null)
                        {
                            if (Int32.TryParse(OrdGBWKNoFrom.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdGBWKNoFrom.Value = value; }
        }


        [Ignore()]
        public Orders_OrdGBWKNo OrdGBWKNo { get; set; }
        public static Orders_OrdGBWKNoFieldDef OrdGBWKNoField { get; private set; }


        [Column("OrdGBWKNo")]
        public string PopulateOrdGBWKNo
        {
            get { return OrdGBWKNoValue; }
            set { OrdGBWKNo.DataValue = value; }
        }


        public string OrdGBWKNoValue
        {
            get
            {
                if (OrdGBWKNo.Value != null)
                {
                    return OrdGBWKNo.Value.ToString();
                }
                return "";

            }
            set { OrdGBWKNo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdTescoPSWk OrdTescoPSWk { get; set; }
        public static Orders_OrdTescoPSWkFieldDef OrdTescoPSWkField { get; private set; }


        [Column("OrdTescoPSWk")]
        public int PopulateOrdTescoPSWk
        {
            get { return OrdTescoPSWkValue; }
            set { OrdTescoPSWk.DataValue = value; }
        }


        public int OrdTescoPSWkValue
        {
            get
            {
                if (OrdTescoPSWk.Value != null)
                {
                    int i = 0;
                    if (OrdTescoPSWk != null)
                    {
                        if (OrdTescoPSWk.Value != null)
                        {
                            if (Int32.TryParse(OrdTescoPSWk.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdTescoPSWk.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCollectCtry OrdCollectCtry { get; set; }
        public static Orders_OrdCollectCtryFieldDef OrdCollectCtryField { get; private set; }


        [Column("OrdCollectCtry")]
        public string PopulateOrdCollectCtry
        {
            get { return OrdCollectCtryValue; }
            set { OrdCollectCtry.DataValue = value; }
        }


        public string OrdCollectCtryValue
        {
            get
            {
                if (OrdCollectCtry.Value != null)
                {
                    return OrdCollectCtry.Value.ToString();
                }
                return "";

            }
            set { OrdCollectCtry.Value = value; }
        }


        [Ignore()]
        public Orders_OrdSelEMTo OrdSelEMTo { get; set; }
        public static Orders_OrdSelEMToFieldDef OrdSelEMToField { get; private set; }


        [Column("OrdSelEMTo")]
        public int PopulateOrdSelEMTo
        {
            get { return OrdSelEMToValue; }
            set { OrdSelEMTo.DataValue = value; }
        }


        public int OrdSelEMToValue
        {
            get
            {
                if (OrdSelEMTo.Value != null)
                {
                    int i = 0;
                    if (OrdSelEMTo != null)
                    {
                        if (OrdSelEMTo.Value != null)
                        {
                            if (Int32.TryParse(OrdSelEMTo.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdSelEMTo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdSelFaxTo OrdSelFaxTo { get; set; }
        public static Orders_OrdSelFaxToFieldDef OrdSelFaxToField { get; private set; }


        [Column("OrdSelFaxTo")]
        public int PopulateOrdSelFaxTo
        {
            get { return OrdSelFaxToValue; }
            set { OrdSelFaxTo.DataValue = value; }
        }


        public int OrdSelFaxToValue
        {
            get
            {
                if (OrdSelFaxTo.Value != null)
                {
                    int i = 0;
                    if (OrdSelFaxTo != null)
                    {
                        if (OrdSelFaxTo.Value != null)
                        {
                            if (Int32.TryParse(OrdSelFaxTo.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { OrdSelFaxTo.Value = value; }
        }


        [Ignore()]
        public Orders_OrdConsOrd OrdConsOrd { get; set; }
        public static Orders_OrdConsOrdFieldDef OrdConsOrdField { get; private set; }


        [Column("OrdConsOrd")]
        public string PopulateOrdConsOrd
        {
            get { return OrdConsOrdValue; }
            set { OrdConsOrd.DataValue = value; }
        }


        public string OrdConsOrdValue
        {
            get
            {
                if (OrdConsOrd.Value != null)
                {
                    return OrdConsOrd.Value.ToString();
                }
                return "";

            }
            set { OrdConsOrd.Value = value; }
        }


        [Ignore()]
        public Orders_OrdCustName OrdCustName { get; set; }
        public static Orders_OrdCustNameFieldDef OrdCustNameField { get; private set; }


        [Column("OrdCustName")]
        public string PopulateOrdCustName
        {
            get { return OrdCustNameValue; }
            set { OrdCustName.DataValue = value; }
        }


        public string OrdCustNameValue
        {
            get
            {
                if (OrdCustName.Value != null)
                {
                    return OrdCustName.Value.ToString();
                }
                return "";

            }
            set { OrdCustName.Value = value; }
        }


        [Ignore()]
        public Orders_OrdDelRef OrdDelRef { get; set; }
        public static Orders_OrdDelRefFieldDef OrdDelRefField { get; private set; }


        [Column("OrdDelRef")]
        public string PopulateOrdDelRef
        {
            get { return OrdDelRefValue; }
            set { OrdDelRef.DataValue = value; }
        }


        public string OrdDelRefValue
        {
            get
            {
                if (OrdDelRef.Value != null)
                {
                    return OrdDelRef.Value.ToString();
                }
                return "";

            }
            set { OrdDelRef.Value = value; }
        }
    }


    public class Orders_ListScreen : IScreen
    {
        public bool CustomScreen => false;
        public bool AllowedToDraw => true;
        public int Id => 2;
        public int PixelHeight => 0;
        public string Title => "Orders";

        public string DrawContents(IDSBase dataset, string FormID)
        {
            throw new NotImplementedException();
        }
    }

}
