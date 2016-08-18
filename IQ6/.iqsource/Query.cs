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


    public partial class QueryController : DSBaseController<Query/*,QuerySearch*/>
    {
        public QueryController() : base((IDatabase)IQApp.DB, new QueryRepository())
        {

        }

        [ValidateInput(false)]
        public ActionResult Delete(int RecId)
        {
            var Key = IQApp.DB.GetInt("select QryId from Query where RecordID=@RecId", new { RecId = RecId });


            string Msg = "Are you sure you want to delete this record?";


            return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
            WebButton.CallbackButton<Query>("Delete", DeleteClick),
                WebButton.ClosePopupButton("Close", "btn-info", "float:left")
        }));
        }

        public void DeleteClick(Query data)
        {
            IQApp.DB.Execute("Delete from Query where RecordID=@RecId", new { RecId = data.RecordID });
            IQApp.CR.UrlToLoad("/?message=" + data.QryNameValue + " has been removed.");
        }



        public ActionResult ListFromQuery(string Clause, string Ord, int? Limit)
        {

            Clause = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
            Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

            string Query = "select * from Query " + Clause + Ord;
            ViewBag.MoreResults = false;
            ViewBag.Clause = Clause;
            ViewBag.Ord = Ord;
            if (Limit.HasValue)
            {
                int ResultCount = IQApp.DB.GetInt("select count(*) from Query " + Clause);
                if (ResultCount > Limit)
                {
                    Query = "select top " + Limit.Value + " * from Query " + Clause + Ord;
                    ViewBag.MoreResults = true;
                    ViewBag.Limit = Limit.Value;
                    ViewBag.ResultCount = ResultCount;
                }
            }
            return IQView("~/Views/Query_List_" + IQApp.User.GetSecurityGroup() + ".cshtml",
                    IQApp.DB.Load<Query>(Query).ToList());

        }


        public ActionResult ExportAll()
        {

            var res = IQApp.DB.Load<Query>("select * from Query  ").ToList();
            string urlpath = "/temp/Query Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            string path = Server.MapPath(urlpath);
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);

            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Query");

                worksheet.Cells.Style.Font.Size = 9;
                worksheet.Cells.Style.Font.Name = "Calibri";
                worksheet.Cells.Style.WrapText = true;

                using (var range = worksheet.Cells[1, 1, 1, 4])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Font.Size = 11;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                    range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                }

                worksheet.Column(1).Width = 25;
                worksheet.Cells[1, 1].Value = "Name";


                worksheet.Column(2).Width = 25;
                worksheet.Cells[1, 2].Value = "System Name";


                worksheet.Column(3).Width = 50;
                worksheet.Cells[1, 3].Value = "Content";


                for (int j = 0; j < res.Count(); j++)
                {

                    worksheet.Cells[j + 2, 1].Value = res[j].QryName.DisplayValue;
                    worksheet.Cells[j + 2, 2].Value = res[j].QrySysName.DisplayValue;
                    worksheet.Cells[j + 2, 3].Value = res[j].QryContent.DisplayValue;

                }

                package.Save();

                return Redirect(urlpath);

            }
        }


        [ValidateInput(false)]
        public ActionResult SaveQryId(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

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
            ds.QryIdValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryId" || f.Key == "Id").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryId" || f.Key == "Id"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackQryId(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryId" || f.Key == "Id").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryId" || f.Key == "Id"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryName(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QryNameValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryName" || f.Key == "Name").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryName" || f.Key == "Name"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackQryName(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryName" || f.Key == "Name").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryName" || f.Key == "Name"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQrySysName(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QrySysNameValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QrySysName").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QrySysName"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackQrySysName(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QrySysName").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QrySysName"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryContent(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QryContentValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryContent" || f.Key == "Content").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryContent" || f.Key == "Content"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackQryContent(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryContent" || f.Key == "Content").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryContent" || f.Key == "Content"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryPrimaryDS(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QryPrimaryDSValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryPrimaryDS" || f.Key == "Dataset").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryPrimaryDS" || f.Key == "Dataset"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteQryPrimaryDS(Query m, int? id, string q)
        {


            string s = m.QryPrimaryDS.DataSource;
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
        public ActionResult CallbackQryPrimaryDS(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryPrimaryDS" || f.Key == "Dataset").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryPrimaryDS" || f.Key == "Dataset"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryScreen(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QryScreenValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryScreen" || f.Key == "Screen").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryScreen" || f.Key == "Screen"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteQryScreen(Query m, int? id, string q)
        {


            string s = m.QryScreen.DataSource;
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
        public ActionResult CallbackQryScreen(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryScreen" || f.Key == "Screen").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryScreen" || f.Key == "Screen"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryType(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

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
            ds.QryTypeValue = i;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryType" || f.Key == "Type").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryType" || f.Key == "Type"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult AutoCompleteQryType(Query m, int? id, string q)
        {


            string s = m.QryType.DataSource;
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
        public ActionResult CallbackQryType(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryType" || f.Key == "Type").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryType" || f.Key == "Type"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryCategory(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QryCategoryValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryCategory" || f.Key == "Category").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryCategory" || f.Key == "Category"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackQryCategory(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryCategory" || f.Key == "Category").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryCategory" || f.Key == "Category"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult SaveQryRelationships(string NewValue, int RecId)
        {
            var ds = IQApp.DB.Load<Query>("select * from Query where RecordID=@RecId ", new { RecId = RecId }).First();

            if (Request["NewValue[]"] != null)
            {
                NewValue = Request["NewValue[]"].ToString();
            }
            ds.QryRelationshipsValue = NewValue;

            var CR = IQApp.CR;

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryRelationships" || f.Key == "Relationships").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryRelationships" || f.Key == "Relationships"))
                {
                    itm.Value(ds);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(ds);

            ds.Save();


            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult CallbackQryRelationships(Query obj)
        {

            if (DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryRelationships" || f.Key == "Relationships").Any())
            {
                foreach (var itm in DS.GetManager<Query>().OnChange.Where(f => f.Key == "QryRelationships" || f.Key == "Relationships"))
                {
                    itm.Value(obj);
                }
            }

            IQApp.CR.TransferToWebAction<Query>(obj);
            return IQJS(IQApp.CR);
        }


        [ValidateInput(false)]
        public ActionResult ListOrSearch()
        {

            return Redirect("/Query/List/");
        }

    }

    public partial class QueryRepository : DSRepository<Query>
    {
        public QueryRepository() : base(47, "Query", "Query")
        {
        }
    }

    public partial class Query : DatasetBase<Query>, IDSBase, Intrinsiq.Query.IDynamicQuery
    {
        public int KeyValue => QryIdValue;

        public IFieldDefinition GetFieldDef(string DF)
        {
            switch (DF)
            {

                case "QryId":
                    return QryIdField;
                case "QryName":
                    return QryNameField;
                case "QrySysName":
                    return QrySysNameField;
                case "QryContent":
                    return QryContentField;
                case "QryPrimaryDS":
                    return QryPrimaryDSField;
                case "QryScreen":
                    return QryScreenField;
                case "QryType":
                    return QryTypeField;
                case "QryCategory":
                    return QryCategoryField;
                case "QryRelationships":
                    return QryRelationshipsField;
            }
            return null;
        }

        public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action)
        {
            action(QryId, QryIdField);
            action(QryName, QryNameField);
            action(QrySysName, QrySysNameField);
            action(QryContent, QryContentField);
            action(QryPrimaryDS, QryPrimaryDSField);
            action(QryScreen, QryScreenField);
            action(QryType, QryTypeField);
            action(QryCategory, QryCategoryField);
            action(QryRelationships, QryRelationshipsField);
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
                    QryId.Visible = false; QryName.Visible = false; QrySysName.Visible = false; QryContent.Visible = false; QryPrimaryDS.Visible = false; QryScreen.Visible = false; QryType.Visible = false; break;
            }
        }




        public override int Save()
        {
            if (RecordID.HasValue)
            {
                string SQL = "update Query set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
                if (QryId.HasChanged && QryId.HasValue)
                {
                    SQL += ", QryId=@QryIdValue";

                }
                if (QryName.HasChanged && QryName.HasValue)
                {
                    SQL += ", QryName=@QryNameValue";

                }
                if (QrySysName.HasChanged && QrySysName.HasValue)
                {
                    SQL += ", QrySysName=@QrySysNameValue";

                }
                if (QryContent.HasChanged && QryContent.HasValue)
                {
                    SQL += ", QryContent=@QryContentValue";

                }
                if (QryPrimaryDS.HasChanged && QryPrimaryDS.HasValue)
                {
                    SQL += ", QryPrimaryDS=@QryPrimaryDSValue";

                }
                if (QryScreen.HasChanged && QryScreen.HasValue)
                {
                    SQL += ", QryScreen=@QryScreenValue";

                }
                if (QryType.HasChanged && QryType.HasValue)
                {
                    SQL += ", QryType=@QryTypeValue";

                }
                if (QryCategory.HasChanged && QryCategory.HasValue)
                {
                    SQL += ", QryCategory=@QryCategoryValue";

                }
                if (QryRelationships.HasChanged && QryRelationships.HasValue)
                {
                    SQL += ", QryRelationships=@QryRelationshipsValue";

                }

                SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
                QryId.HasChanged = false;
                QryName.HasChanged = false;
                QrySysName.HasChanged = false;
                QryContent.HasChanged = false;
                QryPrimaryDS.HasChanged = false;
                QryScreen.HasChanged = false;
                QryType.HasChanged = false;
                QryCategory.HasChanged = false;
                QryRelationships.HasChanged = false;

                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
                if (!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
                if (!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();

                string SQL = "insert into Query(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";

                QryId.Value = IQApp.DB.GetInt("select isnull(max(QryId),0)+1 from Query");
                if (QryId.HasValue)
                {
                    SQL += ", QryId";
                    Values += ", @QryIdValue";
                }

                if (QryName.HasValue)
                {
                    SQL += ", QryName";
                    Values += ", @QryNameValue";
                }

                if (QrySysName.HasValue)
                {
                    SQL += ", QrySysName";
                    Values += ", @QrySysNameValue";
                }

                if (QryContent.HasValue)
                {
                    SQL += ", QryContent";
                    Values += ", @QryContentValue";
                }

                if (QryPrimaryDS.HasValue)
                {
                    SQL += ", QryPrimaryDS";
                    Values += ", @QryPrimaryDSValue";
                }

                if (QryScreen.HasValue)
                {
                    SQL += ", QryScreen";
                    Values += ", @QryScreenValue";
                }

                if (QryType.HasValue)
                {
                    SQL += ", QryType";
                    Values += ", @QryTypeValue";
                }

                if (QryCategory.HasValue)
                {
                    SQL += ", QryCategory";
                    Values += ", @QryCategoryValue";
                }

                if (QryRelationships.HasValue)
                {
                    SQL += ", QryRelationships";
                    Values += ", @QryRelationshipsValue";
                }

                SQL += ") values (" + Values + ")";
                RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Query");
                IQApp.DB.Execute(SQL, this);
                QryId.HasChanged = false;
                QryName.HasChanged = false;
                QrySysName.HasChanged = false;
                QryContent.HasChanged = false;
                QryPrimaryDS.HasChanged = false;
                QryScreen.HasChanged = false;
                QryType.HasChanged = false;
                QryCategory.HasChanged = false;
                QryRelationships.HasChanged = false;
                return RecordID.Value;
            }


        }

        public IDSFieldBase GetField(string DFName)
        {
            switch (DFName)
            {
                case "QryId":
                    return (IDSFieldBase)QryId;
                case "QryName":
                    return (IDSFieldBase)QryName;
                case "QrySysName":
                    return (IDSFieldBase)QrySysName;
                case "QryContent":
                    return (IDSFieldBase)QryContent;
                case "QryPrimaryDS":
                    return (IDSFieldBase)QryPrimaryDS;
                case "QryScreen":
                    return (IDSFieldBase)QryScreen;
                case "QryType":
                    return (IDSFieldBase)QryType;
                case "QryCategory":
                    return (IDSFieldBase)QryCategory;
                case "QryRelationships":
                    return (IDSFieldBase)QryRelationships;
            }
            return null;
        }

        public string GetDisplayValue(string DFName)
        {
            switch (DFName)
            {
                case "QryId":
                    return QryId.DisplayValue;
                case "QryName":
                    return QryName.DisplayValue;
                case "QrySysName":
                    return QrySysName.DisplayValue;
                case "QryContent":
                    return QryContent.DisplayValue;
                case "QryPrimaryDS":
                    return QryPrimaryDS.DisplayValue;
                case "QryScreen":
                    return QryScreen.DisplayValue;
                case "QryType":
                    return QryType.DisplayValue;
                case "QryCategory":
                    return QryCategory.DisplayValue;
                case "QryRelationships":
                    return QryRelationships.DisplayValue;
            }
            return "";
        }

        public string GetValue(string DFName)
        {
            switch (DFName)
            {
                case "QryId":
                    return QryId.Value.ToString();
                case "QryName":
                    return QryName.Value.ToString();
                case "QrySysName":
                    return QrySysName.Value.ToString();
                case "QryContent":
                    return QryContent.Value.ToString();
                case "QryPrimaryDS":
                    return QryPrimaryDS.Value.ToString();
                case "QryScreen":
                    return QryScreen.Value.ToString();
                case "QryType":
                    return QryType.Value.ToString();
                case "QryCategory":
                    return QryCategory.Value.ToString();
                case "QryRelationships":
                    return QryRelationships.Value.ToString();
            }
            return "";
        }


        public static List<IScreen> DefaultSubForms
        {
            get
            {
                List<IScreen> scrns = new List<IScreen>();

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
                    foreach (var itm in DS.GetManager<Query>().OnDrawScreens)
                    {
                        _CachedSubForms = itm(this, _CachedSubForms);
                    }
                }
                return _CachedSubForms;
            }
        }


        public Query() : base("Query")
        {
            base.obj = this;

            QryId = new Query_QryId(this);
            QryName = new Query_QryName(this);
            QrySysName = new Query_QrySysName(this);
            QryContent = new Query_QryContent(this);
            QryPrimaryDS = new Query_QryPrimaryDS(this);
            QryScreen = new Query_QryScreen(this);
            QryType = new Query_QryType(this);
            QryCategory = new Query_QryCategory(this);
            QryRelationships = new Query_QryRelationships(this);
        }

        static Query()
        {
            QryIdField = new Query_QryIdFieldDef();
            QryNameField = new Query_QryNameFieldDef();
            QrySysNameField = new Query_QrySysNameFieldDef();
            QryContentField = new Query_QryContentFieldDef();
            QryPrimaryDSField = new Query_QryPrimaryDSFieldDef();
            QryScreenField = new Query_QryScreenFieldDef();
            QryTypeField = new Query_QryTypeFieldDef();
            QryCategoryField = new Query_QryCategoryFieldDef();
            QryRelationshipsField = new Query_QryRelationshipsFieldDef();
        }

        public string RecordTitle
        {
            get { return QryNameValue.ToString(); }
        }

        public string DSNiceName
        {
            get { return "Query"; }
        }


        public string DataUrl
        {
            get
            {
                if (RecordID.HasValue)
                {
                    return "/Query/Load/?RecId=" + RecordID.Value;
                }
                return "/Query/Add";
            }
        }



        [Ignore()]
        public Query_QryId QryId { get; set; }
        public static Query_QryIdFieldDef QryIdField { get; private set; }


        [Column("QryId")]
        public int PopulateQryId
        {
            get { return QryIdValue; }
            set { QryId.DataValue = value; }
        }

        public int Id
        {
            get { return QryIdValue; }
            set { QryIdValue = value; }
        }
        [IQFieldName("QryId")]
        public IDSFieldBase IdField
        {
            get { return (IDSFieldBase)QryId; }
            set { QryId = (Query_QryId)value; }
        }

        public int QryIdValue
        {
            get
            {
                if (QryId.Value != null)
                {
                    int i = 0;
                    if (QryId != null)
                    {
                        if (QryId.Value != null)
                        {
                            if (Int32.TryParse(QryId.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { QryId.Value = value; }
        }


        [Ignore()]
        public Query_QryName QryName { get; set; }
        public static Query_QryNameFieldDef QryNameField { get; private set; }


        [Column("QryName")]
        public string PopulateQryName
        {
            get { return QryNameValue; }
            set { QryName.DataValue = value; }
        }

        public string Name
        {
            get { return QryNameValue; }
            set { QryNameValue = value; }
        }
        [IQFieldName("QryName")]
        public IDSFieldBase NameField
        {
            get { return (IDSFieldBase)QryName; }
            set { QryName = (Query_QryName)value; }
        }

        public string QryNameValue
        {
            get
            {
                if (QryName.Value != null)
                {
                    return QryName.Value.ToString();
                }
                return "";

            }
            set { QryName.Value = value; }
        }


        [Ignore()]
        public Query_QrySysName QrySysName { get; set; }
        public static Query_QrySysNameFieldDef QrySysNameField { get; private set; }


        [Column("QrySysName")]
        public string PopulateQrySysName
        {
            get { return QrySysNameValue; }
            set { QrySysName.DataValue = value; }
        }


        public string QrySysNameValue
        {
            get
            {
                if (QrySysName.Value != null)
                {
                    return QrySysName.Value.ToString();
                }
                return "";

            }
            set { QrySysName.Value = value; }
        }


        [Ignore()]
        public Query_QryContent QryContent { get; set; }
        public static Query_QryContentFieldDef QryContentField { get; private set; }


        [Column("QryContent")]
        public string PopulateQryContent
        {
            get { return QryContentValue; }
            set { QryContent.DataValue = value; }
        }

        public string Content
        {
            get { return QryContentValue; }
            set { QryContentValue = value; }
        }
        [IQFieldName("QryContent")]
        public IDSFieldBase ContentField
        {
            get { return (IDSFieldBase)QryContent; }
            set { QryContent = (Query_QryContent)value; }
        }

        public string QryContentValue
        {
            get
            {
                if (QryContent.Value != null)
                {
                    return QryContent.Value.ToString();
                }
                return "";

            }
            set { QryContent.Value = value; }
        }


        [Ignore()]
        public Query_QryPrimaryDS QryPrimaryDS { get; set; }
        public static Query_QryPrimaryDSFieldDef QryPrimaryDSField { get; private set; }


        [Column("QryPrimaryDS")]
        public string PopulateQryPrimaryDS
        {
            get { return QryPrimaryDSValue; }
            set { QryPrimaryDS.DataValue = value; }
        }

        public string Dataset
        {
            get { return QryPrimaryDSValue; }
            set { QryPrimaryDSValue = value; }
        }
        [IQFieldName("QryPrimaryDS")]
        public IDSFieldBase DatasetField
        {
            get { return (IDSFieldBase)QryPrimaryDS; }
            set { QryPrimaryDS = (Query_QryPrimaryDS)value; }
        }

        public string QryPrimaryDSValue
        {
            get
            {
                if (QryPrimaryDS.Value != null)
                {
                    return QryPrimaryDS.Value.ToString();
                }
                return "";

            }
            set { QryPrimaryDS.Value = value; }
        }


        [Ignore()]
        public Query_QryScreen QryScreen { get; set; }
        public static Query_QryScreenFieldDef QryScreenField { get; private set; }


        [Column("QryScreen")]
        public string PopulateQryScreen
        {
            get { return QryScreenValue; }
            set { QryScreen.DataValue = value; }
        }

        public string Screen
        {
            get { return QryScreenValue; }
            set { QryScreenValue = value; }
        }
        [IQFieldName("QryScreen")]
        public IDSFieldBase ScreenField
        {
            get { return (IDSFieldBase)QryScreen; }
            set { QryScreen = (Query_QryScreen)value; }
        }

        public string QryScreenValue
        {
            get
            {
                if (QryScreen.Value != null)
                {
                    return QryScreen.Value.ToString();
                }
                return "";

            }
            set { QryScreen.Value = value; }
        }


        [Ignore()]
        public Query_QryType QryType { get; set; }
        public static Query_QryTypeFieldDef QryTypeField { get; private set; }


        [Column("QryType")]
        public int PopulateQryType
        {
            get { return QryTypeValue; }
            set { QryType.DataValue = value; }
        }

        public int Type
        {
            get { return QryTypeValue; }
            set { QryTypeValue = value; }
        }
        [IQFieldName("QryType")]
        public IDSFieldBase TypeField
        {
            get { return (IDSFieldBase)QryType; }
            set { QryType = (Query_QryType)value; }
        }

        public int QryTypeValue
        {
            get
            {
                if (QryType.Value != null)
                {
                    int i = 0;
                    if (QryType != null)
                    {
                        if (QryType.Value != null)
                        {
                            if (Int32.TryParse(QryType.Value.ToString(), out i))
                                return i;
                        }
                    }
                    return i;
                }
                return 0;

            }
            set { QryType.Value = value; }
        }


        [Ignore()]
        public Query_QryCategory QryCategory { get; set; }
        public static Query_QryCategoryFieldDef QryCategoryField { get; private set; }


        [Column("QryCategory")]
        public string PopulateQryCategory
        {
            get { return QryCategoryValue; }
            set { QryCategory.DataValue = value; }
        }

        public string Category
        {
            get { return QryCategoryValue; }
            set { QryCategoryValue = value; }
        }
        [IQFieldName("QryCategory")]
        public IDSFieldBase CategoryField
        {
            get { return (IDSFieldBase)QryCategory; }
            set { QryCategory = (Query_QryCategory)value; }
        }

        public string QryCategoryValue
        {
            get
            {
                if (QryCategory.Value != null)
                {
                    return QryCategory.Value.ToString();
                }
                return "";

            }
            set { QryCategory.Value = value; }
        }


        [Ignore()]
        public Query_QryRelationships QryRelationships { get; set; }
        public static Query_QryRelationshipsFieldDef QryRelationshipsField { get; private set; }


        [Column("QryRelationships")]
        public string PopulateQryRelationships
        {
            get { return QryRelationshipsValue; }
            set { QryRelationships.DataValue = value; }
        }

        public string Relationships
        {
            get { return QryRelationshipsValue; }
            set { QryRelationshipsValue = value; }
        }
        [IQFieldName("QryRelationships")]
        public IDSFieldBase RelationshipsField
        {
            get { return (IDSFieldBase)QryRelationships; }
            set { QryRelationships = (Query_QryRelationships)value; }
        }

        public string QryRelationshipsValue
        {
            get
            {
                if (QryRelationships.Value != null)
                {
                    return QryRelationships.Value.ToString();
                }
                return "";

            }
            set { QryRelationships.Value = value; }
        }
    }


    public class Query_ListScreen : IScreen
    {
        public bool CustomScreen => false;
        public bool AllowedToDraw => true;
        public int Id => 47;
        public int PixelHeight => 0;
        public string Title => "Query";

        public string DrawContents(IDSBase dataset, string FormID)
        {
            throw new NotImplementedException();
        }
    }

}
