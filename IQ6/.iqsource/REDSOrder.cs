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

namespace FTL { 


public partial class REDSOrderController : DSBaseController<REDSOrder/*,REDSOrderSearch*/> {
	public REDSOrderController() : base ((IDatabase)IQApp.DB, new REDSOrderRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select RDOrdId from REDSOrder where RecordID=@RecId", new { RecId = RecId});

					int count = 0;
						count += IQApp.DB.GetInt("select count(*) from REDSOrdLine where RDOLRDId=@Val", new { Val = Key});
						count += IQApp.DB.GetInt("select count(*) from REDSEAD where RDEADRDId=@Val", new { Val = Key});
						if(count > 0) {
				return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
			}
		
		string Msg = "Are you sure you want to delete this record?";
				
				Msg += " This will also delete any existing sub records.";
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<REDSOrder>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(REDSOrder data) {
											IQApp.DB.Execute("delete from REDSOrdLine where RDOLRDId=@Val", new { Val = data.RDOrdIdValue});
								IQApp.DB.Execute("delete from REDSEAD where RDEADRDId=@Val", new { Val = data.RDOrdIdValue});
										IQApp.DB.Execute("Delete from REDSOrder where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.RDOrdIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from REDSOrder " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from REDSOrder " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from REDSOrder " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/REDSOrder_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<REDSOrder>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<REDSOrder>("select * from REDSOrder  ").ToList();
		string urlpath = "/temp/REDS Order Header Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("REDS Order Header");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 6])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 18;
					worksheet.Cells[1, 1].Value = "Order Number";
						
								
					worksheet.Column(2).Width = 18;
					worksheet.Cells[1, 2].Value = "Client ID";
						
								
					worksheet.Column(3).Width = 23;
					worksheet.Cells[1, 3].Value = "Job Number";
						
								
					worksheet.Column(4).Width = 23;
					worksheet.Cells[1, 4].Value = "Job Letter";
						
								
					worksheet.Column(5).Width = 18;
					worksheet.Cells[1, 5].Value = "REDS ID";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].RDOrdOrder.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].RDOrdCustId.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].RDOrdJobNo.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].RDOrdJobLetter.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].RDOrdId.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					int i = 0;
		
			bool UnableToContinue = false;

			if(!Int32.TryParse(NewValue.ToString(), out i)) {
									if(NewValue.Contains(",")) {
						NewValue = NewValue.Split(',')[0];
						if(!Int32.TryParse(NewValue.ToString(), out i)) {
							UnableToContinue=true;
						}
					}else {
						UnableToContinue=true;
					}
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdId(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdCustId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					int i = 0;
		
			bool UnableToContinue = false;

			if(!Int32.TryParse(NewValue.ToString(), out i)) {
									if(NewValue.Contains(",")) {
						NewValue = NewValue.Split(',')[0];
						if(!Int32.TryParse(NewValue.ToString(), out i)) {
							UnableToContinue=true;
						}
					}else {
						UnableToContinue=true;
					}
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdCustIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdCustId(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdDANNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDOrdDANNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDANNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDANNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdDANNo(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDANNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDANNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					int i = 0;
		
			bool UnableToContinue = false;

			if(!Int32.TryParse(NewValue.ToString(), out i)) {
									if(NewValue.Contains(",")) {
						NewValue = NewValue.Split(',')[0];
						if(!Int32.TryParse(NewValue.ToString(), out i)) {
							UnableToContinue=true;
						}
					}else {
						UnableToContinue=true;
					}
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdJobNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteRDOrdJobNo(REDSOrder m, int? id, string q) {

		
		string s = m.RDOrdJobNo.DataSource;
		if(s.Contains("0, '' ")){
			s = s.Replace("0, '' ", "0 as KeyValue, '' as Description ");
			}
		if(s.Contains("ORDER BY")) {
			s = s.Replace("SELECT ", "SELECT TOP 100000 ");
		}
			var result = new {
				results = IQApp.DB.Load<Pair<string, string>>(@";with RowSourceSQL as (" + s + @")
					select top 10 KeyValue, [Description] + ' (' + cast(KeyValue as varchar)  + ')' as [Description] from RowSourceSQL  where [Description] like @query or [KeyValue] like @query", new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false };
						
			return Json(result);
		}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdJobNo(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdJobLetter(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDOrdJobLetterValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobLetter")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdJobLetter(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdJobLetter")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdCustOrd(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDOrdCustOrdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustOrd")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdCustOrd(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCustOrd")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdArrDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdArrDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdArrDate" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdArrDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdArrDate(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdArrDate" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdArrDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdDelDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdDelDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDelDate" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDelDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdDelDate(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDelDate" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDelDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					int i = 0;
		
			bool UnableToContinue = false;

			if(!Int32.TryParse(NewValue.ToString(), out i)) {
									if(NewValue.Contains(",")) {
						NewValue = NewValue.Split(',')[0];
						if(!Int32.TryParse(NewValue.ToString(), out i)) {
							UnableToContinue=true;
						}
					}else {
						UnableToContinue=true;
					}
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdOrder" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdOrder(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdOrder" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDOrdCustValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCust" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdCust(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCust" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdInvCreated(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdInvCreatedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdInvCreated" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdInvCreated")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdInvCreated(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdInvCreated" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdInvCreated")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDOrdDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDesc" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdDesc(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDesc" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdLocked(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdLockedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdLocked" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdLocked")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdLocked(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdLocked" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdLocked")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdDutyPaid(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdDutyPaidValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDutyPaid" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDutyPaid")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdDutyPaid(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDutyPaid" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdDutyPaid")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdARCNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDOrdARCNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdARCNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdARCNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdARCNo(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdARCNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdARCNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOrdHM10(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOrdHM10Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdHM10" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdHM10")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOrdHM10(REDSOrder obj) {
			
		if(DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdHM10" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrder>().OnChange.Where(f=> f.Key == "RDOrdHM10")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=35 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/REDSOrder/Search/" + FirstSearch);
		
		return Redirect("/REDSOrder/List/");
	}

}

public partial class REDSOrderRepository : DSRepository<REDSOrder> {
	public REDSOrderRepository() : base(35, "REDSOrder", "REDS Order Header") {
	}
}
public partial class REDSOrder 
: DatasetBase<REDSOrder>, IDSBase

  {
	  public int KeyValue => RDOrdIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "RDOrdId":
			return RDOrdIdField;
				case "RDOrdCustId":
			return RDOrdCustIdField;
				case "RDOrdDANNo":
			return RDOrdDANNoField;
				case "RDOrdJobNo":
			return RDOrdJobNoField;
				case "RDOrdJobLetter":
			return RDOrdJobLetterField;
				case "RDOrdCustOrd":
			return RDOrdCustOrdField;
				case "RDOrdArrDate":
			return RDOrdArrDateField;
				case "RDOrdDelDate":
			return RDOrdDelDateField;
				case "RDOrdOrder":
			return RDOrdOrderField;
				case "RDOrdCust":
			return RDOrdCustField;
				case "RDOrdInvCreated":
			return RDOrdInvCreatedField;
				case "RDOrdDesc":
			return RDOrdDescField;
				case "RDOrdLocked":
			return RDOrdLockedField;
				case "RDOrdDutyPaid":
			return RDOrdDutyPaidField;
				case "RDOrdARCNo":
			return RDOrdARCNoField;
				case "RDOrdHM10":
			return RDOrdHM10Field;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(RDOrdId,RDOrdIdField);
				action(RDOrdCustId,RDOrdCustIdField);
				action(RDOrdDANNo,RDOrdDANNoField);
				action(RDOrdJobNo,RDOrdJobNoField);
				action(RDOrdJobLetter,RDOrdJobLetterField);
				action(RDOrdCustOrd,RDOrdCustOrdField);
				action(RDOrdArrDate,RDOrdArrDateField);
				action(RDOrdDelDate,RDOrdDelDateField);
				action(RDOrdOrder,RDOrdOrderField);
				action(RDOrdCust,RDOrdCustField);
				action(RDOrdInvCreated,RDOrdInvCreatedField);
				action(RDOrdDesc,RDOrdDescField);
				action(RDOrdLocked,RDOrdLockedField);
				action(RDOrdDutyPaid,RDOrdDutyPaidField);
				action(RDOrdARCNo,RDOrdARCNoField);
				action(RDOrdHM10,RDOrdHM10Field);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				RDOrdId.Visible=false;RDOrdCustId.Visible=false;RDOrdDANNo.Visible=false;RDOrdJobNo.Visible=false;RDOrdJobLetter.Visible=false;RDOrdCustOrd.Visible=false;RDOrdArrDate.Visible=false;RDOrdDelDate.Visible=false;RDOrdOrder.Visible=false;RDOrdCust.Visible=false;RDOrdInvCreated.Visible=false;RDOrdDesc.Visible=false;RDOrdLocked.Visible=false;RDOrdDutyPaid.Visible=false;RDOrdARCNo.Visible=false;RDOrdHM10.Visible=false;			break;
					case 3:
				RDOrdId.Visible=false;RDOrdCustId.Visible=false;RDOrdDANNo.Visible=false;RDOrdJobNo.Visible=false;RDOrdJobLetter.Visible=false;RDOrdCustOrd.Visible=false;RDOrdArrDate.Visible=false;RDOrdDelDate.Visible=false;RDOrdOrder.Visible=false;RDOrdCust.Visible=false;RDOrdInvCreated.Visible=false;RDOrdDesc.Visible=false;RDOrdLocked.Visible=false;RDOrdDutyPaid.Visible=false;RDOrdARCNo.Visible=false;RDOrdHM10.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update REDSOrder set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (RDOrdId.HasChanged && RDOrdId.HasValue) {
					SQL += ", RDOrdId=@RDOrdIdValue";

				}
								if (RDOrdCustId.HasChanged && RDOrdCustId.HasValue) {
					SQL += ", RDOrdCustId=@RDOrdCustIdValue";

				}
								if (RDOrdDANNo.HasChanged && RDOrdDANNo.HasValue) {
					SQL += ", RDOrdDANNo=@RDOrdDANNoValue";

				}
								if (RDOrdJobNo.HasChanged && RDOrdJobNo.HasValue) {
					SQL += ", RDOrdJobNo=@RDOrdJobNoValue";

				}
								if (RDOrdJobLetter.HasChanged && RDOrdJobLetter.HasValue) {
					SQL += ", RDOrdJobLetter=@RDOrdJobLetterValue";

				}
								if (RDOrdCustOrd.HasChanged && RDOrdCustOrd.HasValue) {
					SQL += ", RDOrdCustOrd=@RDOrdCustOrdValue";

				}
								if (RDOrdArrDate.HasChanged && RDOrdArrDate.HasValue) {
					SQL += ", RDOrdArrDate=@RDOrdArrDateValue";

				}
								if (RDOrdDelDate.HasChanged && RDOrdDelDate.HasValue) {
					SQL += ", RDOrdDelDate=@RDOrdDelDateValue";

				}
								if (RDOrdOrder.HasChanged && RDOrdOrder.HasValue) {
					SQL += ", RDOrdOrder=@RDOrdOrderValue";

				}
								if (RDOrdCust.HasChanged && RDOrdCust.HasValue) {
					SQL += ", RDOrdCust=@RDOrdCustValue";

				}
								if (RDOrdInvCreated.HasChanged && RDOrdInvCreated.HasValue) {
					SQL += ", RDOrdInvCreated=@RDOrdInvCreatedValue";

				}
								if (RDOrdDesc.HasChanged && RDOrdDesc.HasValue) {
					SQL += ", RDOrdDesc=@RDOrdDescValue";

				}
								if (RDOrdLocked.HasChanged && RDOrdLocked.HasValue) {
					SQL += ", RDOrdLocked=@RDOrdLockedValue";

				}
								if (RDOrdDutyPaid.HasChanged && RDOrdDutyPaid.HasValue) {
					SQL += ", RDOrdDutyPaid=@RDOrdDutyPaidValue";

				}
								if (RDOrdARCNo.HasChanged && RDOrdARCNo.HasValue) {
					SQL += ", RDOrdARCNo=@RDOrdARCNoValue";

				}
								if (RDOrdHM10.HasChanged && RDOrdHM10.HasValue) {
					SQL += ", RDOrdHM10=@RDOrdHM10Value";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									RDOrdId.HasChanged = false;
									RDOrdCustId.HasChanged = false;
									RDOrdDANNo.HasChanged = false;
									RDOrdJobNo.HasChanged = false;
									RDOrdJobLetter.HasChanged = false;
									RDOrdCustOrd.HasChanged = false;
									RDOrdArrDate.HasChanged = false;
									RDOrdDelDate.HasChanged = false;
									RDOrdOrder.HasChanged = false;
									RDOrdCust.HasChanged = false;
									RDOrdInvCreated.HasChanged = false;
									RDOrdDesc.HasChanged = false;
									RDOrdLocked.HasChanged = false;
									RDOrdDutyPaid.HasChanged = false;
									RDOrdARCNo.HasChanged = false;
									RDOrdHM10.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into REDSOrder(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				RDOrdId.Value = IQApp.DB.GetInt("select isnull(max(RDOrdId),0)+1 from REDSOrder");
				if (RDOrdId.HasValue) {
					SQL += ", RDOrdId";
					Values += ", @RDOrdIdValue";
				}
				
				if (RDOrdCustId.HasValue) {
					SQL += ", RDOrdCustId";
					Values += ", @RDOrdCustIdValue";
				}
				
				if (RDOrdDANNo.HasValue) {
					SQL += ", RDOrdDANNo";
					Values += ", @RDOrdDANNoValue";
				}
				
				if (RDOrdJobNo.HasValue) {
					SQL += ", RDOrdJobNo";
					Values += ", @RDOrdJobNoValue";
				}
				
				if (RDOrdJobLetter.HasValue) {
					SQL += ", RDOrdJobLetter";
					Values += ", @RDOrdJobLetterValue";
				}
				
				if (RDOrdCustOrd.HasValue) {
					SQL += ", RDOrdCustOrd";
					Values += ", @RDOrdCustOrdValue";
				}
				
				if (RDOrdArrDate.HasValue) {
					SQL += ", RDOrdArrDate";
					Values += ", @RDOrdArrDateValue";
				}
				
				if (RDOrdDelDate.HasValue) {
					SQL += ", RDOrdDelDate";
					Values += ", @RDOrdDelDateValue";
				}
				
				if (RDOrdOrder.HasValue) {
					SQL += ", RDOrdOrder";
					Values += ", @RDOrdOrderValue";
				}
				
				if (RDOrdCust.HasValue) {
					SQL += ", RDOrdCust";
					Values += ", @RDOrdCustValue";
				}
				
				if (RDOrdInvCreated.HasValue) {
					SQL += ", RDOrdInvCreated";
					Values += ", @RDOrdInvCreatedValue";
				}
				
				if (RDOrdDesc.HasValue) {
					SQL += ", RDOrdDesc";
					Values += ", @RDOrdDescValue";
				}
				
				if (RDOrdLocked.HasValue) {
					SQL += ", RDOrdLocked";
					Values += ", @RDOrdLockedValue";
				}
				
				if (RDOrdDutyPaid.HasValue) {
					SQL += ", RDOrdDutyPaid";
					Values += ", @RDOrdDutyPaidValue";
				}
				
				if (RDOrdARCNo.HasValue) {
					SQL += ", RDOrdARCNo";
					Values += ", @RDOrdARCNoValue";
				}
				
				if (RDOrdHM10.HasValue) {
					SQL += ", RDOrdHM10";
					Values += ", @RDOrdHM10Value";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from REDSOrder");
					 IQApp.DB.Execute(SQL, this);
				                    					RDOrdId.HasChanged = false;
									RDOrdCustId.HasChanged = false;
									RDOrdDANNo.HasChanged = false;
									RDOrdJobNo.HasChanged = false;
									RDOrdJobLetter.HasChanged = false;
									RDOrdCustOrd.HasChanged = false;
									RDOrdArrDate.HasChanged = false;
									RDOrdDelDate.HasChanged = false;
									RDOrdOrder.HasChanged = false;
									RDOrdCust.HasChanged = false;
									RDOrdInvCreated.HasChanged = false;
									RDOrdDesc.HasChanged = false;
									RDOrdLocked.HasChanged = false;
									RDOrdDutyPaid.HasChanged = false;
									RDOrdARCNo.HasChanged = false;
									RDOrdHM10.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "RDOrdId":
					return (IDSFieldBase)RDOrdId;
								case "RDOrdCustId":
					return (IDSFieldBase)RDOrdCustId;
								case "RDOrdDANNo":
					return (IDSFieldBase)RDOrdDANNo;
								case "RDOrdJobNo":
					return (IDSFieldBase)RDOrdJobNo;
								case "RDOrdJobLetter":
					return (IDSFieldBase)RDOrdJobLetter;
								case "RDOrdCustOrd":
					return (IDSFieldBase)RDOrdCustOrd;
								case "RDOrdArrDate":
					return (IDSFieldBase)RDOrdArrDate;
								case "RDOrdDelDate":
					return (IDSFieldBase)RDOrdDelDate;
								case "RDOrdOrder":
					return (IDSFieldBase)RDOrdOrder;
								case "RDOrdCust":
					return (IDSFieldBase)RDOrdCust;
								case "RDOrdInvCreated":
					return (IDSFieldBase)RDOrdInvCreated;
								case "RDOrdDesc":
					return (IDSFieldBase)RDOrdDesc;
								case "RDOrdLocked":
					return (IDSFieldBase)RDOrdLocked;
								case "RDOrdDutyPaid":
					return (IDSFieldBase)RDOrdDutyPaid;
								case "RDOrdARCNo":
					return (IDSFieldBase)RDOrdARCNo;
								case "RDOrdHM10":
					return (IDSFieldBase)RDOrdHM10;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "RDOrdId":
					return RDOrdId.DisplayValue;
								case "RDOrdCustId":
					return RDOrdCustId.DisplayValue;
								case "RDOrdDANNo":
					return RDOrdDANNo.DisplayValue;
								case "RDOrdJobNo":
					return RDOrdJobNo.DisplayValue;
								case "RDOrdJobLetter":
					return RDOrdJobLetter.DisplayValue;
								case "RDOrdCustOrd":
					return RDOrdCustOrd.DisplayValue;
								case "RDOrdArrDate":
					return RDOrdArrDate.DisplayValue;
								case "RDOrdDelDate":
					return RDOrdDelDate.DisplayValue;
								case "RDOrdOrder":
					return RDOrdOrder.DisplayValue;
								case "RDOrdCust":
					return RDOrdCust.DisplayValue;
								case "RDOrdInvCreated":
					return RDOrdInvCreated.DisplayValue;
								case "RDOrdDesc":
					return RDOrdDesc.DisplayValue;
								case "RDOrdLocked":
					return RDOrdLocked.DisplayValue;
								case "RDOrdDutyPaid":
					return RDOrdDutyPaid.DisplayValue;
								case "RDOrdARCNo":
					return RDOrdARCNo.DisplayValue;
								case "RDOrdHM10":
					return RDOrdHM10.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "RDOrdId":
					return RDOrdId.Value.ToString();
								case "RDOrdCustId":
					return RDOrdCustId.Value.ToString();
								case "RDOrdDANNo":
					return RDOrdDANNo.Value.ToString();
								case "RDOrdJobNo":
					return RDOrdJobNo.Value.ToString();
								case "RDOrdJobLetter":
					return RDOrdJobLetter.Value.ToString();
								case "RDOrdCustOrd":
					return RDOrdCustOrd.Value.ToString();
								case "RDOrdArrDate":
					return RDOrdArrDate.Value.ToString();
								case "RDOrdDelDate":
					return RDOrdDelDate.Value.ToString();
								case "RDOrdOrder":
					return RDOrdOrder.Value.ToString();
								case "RDOrdCust":
					return RDOrdCust.Value.ToString();
								case "RDOrdInvCreated":
					return RDOrdInvCreated.Value.ToString();
								case "RDOrdDesc":
					return RDOrdDesc.Value.ToString();
								case "RDOrdLocked":
					return RDOrdLocked.Value.ToString();
								case "RDOrdDutyPaid":
					return RDOrdDutyPaid.Value.ToString();
								case "RDOrdARCNo":
					return RDOrdARCNo.Value.ToString();
								case "RDOrdHM10":
					return RDOrdHM10.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								scrns.Add(new REDSOrdLine_ListScreen());
								scrns.Add(new REDSEAD_ListScreen());
								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<REDSOrder>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		        private List<REDSOrdLine> _ChildREDSOrdLine;
        public List<REDSOrdLine> REDSOrdLines
        {
            get
            {
                if (_ChildREDSOrdLine == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildREDSOrdLine = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RDOLRDId=@itm",new { itm= this.RDOrdId.Value}).ToList();
				
                }
                return _ChildREDSOrdLine;
            }set {}
        }
        public int REDSOrdLineCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from REDSOrdLine where RDOLRDId=@itm", new { itm= this.RDOrdId.Value}));
            }
			set {}
        }
     
	        private List<REDSEAD> _ChildREDSEAD;
        public List<REDSEAD> REDSEADs
        {
            get
            {
                if (_ChildREDSEAD == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildREDSEAD = IQApp.DB.Load<REDSEAD>("select * from REDSEAD where RDEADRDId=@itm",new { itm= this.RDOrdId.Value}).ToList();
				
                }
                return _ChildREDSEAD;
            }set {}
        }
        public int REDSEADCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from REDSEAD where RDEADRDId=@itm", new { itm= this.RDOrdId.Value}));
            }
			set {}
        }
     
	
	public REDSOrder () : base("REDSOrder") {
		base.obj = this;
	
					RDOrdId = new REDSOrder_RDOrdId(this);
					RDOrdCustId = new REDSOrder_RDOrdCustId(this);
					RDOrdDANNo = new REDSOrder_RDOrdDANNo(this);
					RDOrdJobNo = new REDSOrder_RDOrdJobNo(this);
					RDOrdJobLetter = new REDSOrder_RDOrdJobLetter(this);
					RDOrdCustOrd = new REDSOrder_RDOrdCustOrd(this);
					RDOrdArrDate = new REDSOrder_RDOrdArrDate(this);
					RDOrdDelDate = new REDSOrder_RDOrdDelDate(this);
					RDOrdOrder = new REDSOrder_RDOrdOrder(this);
					RDOrdCust = new REDSOrder_RDOrdCust(this);
					RDOrdInvCreated = new REDSOrder_RDOrdInvCreated(this);
					RDOrdDesc = new REDSOrder_RDOrdDesc(this);
					RDOrdLocked = new REDSOrder_RDOrdLocked(this);
					RDOrdDutyPaid = new REDSOrder_RDOrdDutyPaid(this);
					RDOrdARCNo = new REDSOrder_RDOrdARCNo(this);
					RDOrdHM10 = new REDSOrder_RDOrdHM10(this);
			}

	static REDSOrder () {
					RDOrdIdField = new REDSOrder_RDOrdIdFieldDef();
					RDOrdCustIdField = new REDSOrder_RDOrdCustIdFieldDef();
					RDOrdDANNoField = new REDSOrder_RDOrdDANNoFieldDef();
					RDOrdJobNoField = new REDSOrder_RDOrdJobNoFieldDef();
					RDOrdJobLetterField = new REDSOrder_RDOrdJobLetterFieldDef();
					RDOrdCustOrdField = new REDSOrder_RDOrdCustOrdFieldDef();
					RDOrdArrDateField = new REDSOrder_RDOrdArrDateFieldDef();
					RDOrdDelDateField = new REDSOrder_RDOrdDelDateFieldDef();
					RDOrdOrderField = new REDSOrder_RDOrdOrderFieldDef();
					RDOrdCustField = new REDSOrder_RDOrdCustFieldDef();
					RDOrdInvCreatedField = new REDSOrder_RDOrdInvCreatedFieldDef();
					RDOrdDescField = new REDSOrder_RDOrdDescFieldDef();
					RDOrdLockedField = new REDSOrder_RDOrdLockedFieldDef();
					RDOrdDutyPaidField = new REDSOrder_RDOrdDutyPaidFieldDef();
					RDOrdARCNoField = new REDSOrder_RDOrdARCNoFieldDef();
					RDOrdHM10Field = new REDSOrder_RDOrdHM10FieldDef();
			}

	public string RecordTitle { 
		get { return RDOrdIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "REDS Order Header"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/REDSOrder/Load/?RecId=" + RecordID.Value;
			}
			return "/REDSOrder/Add";
			}
	}

			
		
		[Ignore()]
		public REDSOrder_RDOrdId RDOrdId { get; set; }
		public static REDSOrder_RDOrdIdFieldDef RDOrdIdField { get; private set; }
        
			
			[Column("RDOrdId")]
			public  int PopulateRDOrdId  {
				get { return RDOrdIdValue ;}
				set { RDOrdId.DataValue = value; }
			}

	
			public int RDOrdIdValue 
			{ 
				get 
				{
				   if(RDOrdId.Value != null) {
				   					int i = 0;
					if (RDOrdId != null)
					{
						if (RDOrdId.Value != null)
						{
							if (Int32.TryParse(RDOrdId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOrdId.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdCustId RDOrdCustId { get; set; }
		public static REDSOrder_RDOrdCustIdFieldDef RDOrdCustIdField { get; private set; }
        
			
			[Column("RDOrdCustId")]
			public  int PopulateRDOrdCustId  {
				get { return RDOrdCustIdValue ;}
				set { RDOrdCustId.DataValue = value; }
			}

	
			public int RDOrdCustIdValue 
			{ 
				get 
				{
				   if(RDOrdCustId.Value != null) {
				   					int i = 0;
					if (RDOrdCustId != null)
					{
						if (RDOrdCustId.Value != null)
						{
							if (Int32.TryParse(RDOrdCustId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOrdCustId.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdDANNo RDOrdDANNo { get; set; }
		public static REDSOrder_RDOrdDANNoFieldDef RDOrdDANNoField { get; private set; }
        
			
			[Column("RDOrdDANNo")]
			public  string PopulateRDOrdDANNo  {
				get { return RDOrdDANNoValue ;}
				set { RDOrdDANNo.DataValue = value; }
			}

	
			public string RDOrdDANNoValue 
			{ 
				get 
				{
				   if(RDOrdDANNo.Value != null) {
				   return RDOrdDANNo.Value.ToString(); 					}
					return "";
                
				}
				set { RDOrdDANNo.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdJobNo RDOrdJobNo { get; set; }
		public static REDSOrder_RDOrdJobNoFieldDef RDOrdJobNoField { get; private set; }
        
			
			[Column("RDOrdJobNo")]
			public  int PopulateRDOrdJobNo  {
				get { return RDOrdJobNoValue ;}
				set { RDOrdJobNo.DataValue = value; }
			}

	
			public int RDOrdJobNoValue 
			{ 
				get 
				{
				   if(RDOrdJobNo.Value != null) {
				   					int i = 0;
					if (RDOrdJobNo != null)
					{
						if (RDOrdJobNo.Value != null)
						{
							if (Int32.TryParse(RDOrdJobNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOrdJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdJobLetter RDOrdJobLetter { get; set; }
		public static REDSOrder_RDOrdJobLetterFieldDef RDOrdJobLetterField { get; private set; }
        
			
			[Column("RDOrdJobLetter")]
			public  string PopulateRDOrdJobLetter  {
				get { return RDOrdJobLetterValue ;}
				set { RDOrdJobLetter.DataValue = value; }
			}

	
			public string RDOrdJobLetterValue 
			{ 
				get 
				{
				   if(RDOrdJobLetter.Value != null) {
				   return RDOrdJobLetter.Value.ToString(); 					}
					return "";
                
				}
				set { RDOrdJobLetter.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdCustOrd RDOrdCustOrd { get; set; }
		public static REDSOrder_RDOrdCustOrdFieldDef RDOrdCustOrdField { get; private set; }
        
			
			[Column("RDOrdCustOrd")]
			public  string PopulateRDOrdCustOrd  {
				get { return RDOrdCustOrdValue ;}
				set { RDOrdCustOrd.DataValue = value; }
			}

	
			public string RDOrdCustOrdValue 
			{ 
				get 
				{
				   if(RDOrdCustOrd.Value != null) {
				   return RDOrdCustOrd.Value.ToString(); 					}
					return "";
                
				}
				set { RDOrdCustOrd.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdArrDate RDOrdArrDate { get; set; }
		public static REDSOrder_RDOrdArrDateFieldDef RDOrdArrDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("RDOrdArrDate")]
			public  DateTime PopulateRDOrdArrDate  {
				get { return RDOrdArrDateValue ;}
				set { RDOrdArrDate.DataValue = value; }
			}

	
			public DateTime RDOrdArrDateValue 
			{ 
				get 
				{
				   if(RDOrdArrDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (RDOrdArrDate != null)
					{
						if (RDOrdArrDate.Value != null)
						{
							if (DateTime.TryParse(RDOrdArrDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { RDOrdArrDate.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdDelDate RDOrdDelDate { get; set; }
		public static REDSOrder_RDOrdDelDateFieldDef RDOrdDelDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("RDOrdDelDate")]
			public  DateTime PopulateRDOrdDelDate  {
				get { return RDOrdDelDateValue ;}
				set { RDOrdDelDate.DataValue = value; }
			}

	
			public DateTime RDOrdDelDateValue 
			{ 
				get 
				{
				   if(RDOrdDelDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (RDOrdDelDate != null)
					{
						if (RDOrdDelDate.Value != null)
						{
							if (DateTime.TryParse(RDOrdDelDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { RDOrdDelDate.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdOrder RDOrdOrder { get; set; }
		public static REDSOrder_RDOrdOrderFieldDef RDOrdOrderField { get; private set; }
        
			
			[Column("RDOrdOrder")]
			public  int PopulateRDOrdOrder  {
				get { return RDOrdOrderValue ;}
				set { RDOrdOrder.DataValue = value; }
			}

	
			public int RDOrdOrderValue 
			{ 
				get 
				{
				   if(RDOrdOrder.Value != null) {
				   					int i = 0;
					if (RDOrdOrder != null)
					{
						if (RDOrdOrder.Value != null)
						{
							if (Int32.TryParse(RDOrdOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOrdOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdCust RDOrdCust { get; set; }
		public static REDSOrder_RDOrdCustFieldDef RDOrdCustField { get; private set; }
        
			
			[Column("RDOrdCust")]
			public  string PopulateRDOrdCust  {
				get { return RDOrdCustValue ;}
				set { RDOrdCust.DataValue = value; }
			}

	
			public string RDOrdCustValue 
			{ 
				get 
				{
				   if(RDOrdCust.Value != null) {
				   return RDOrdCust.Value.ToString(); 					}
					return "";
                
				}
				set { RDOrdCust.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdInvCreated RDOrdInvCreated { get; set; }
		public static REDSOrder_RDOrdInvCreatedFieldDef RDOrdInvCreatedField { get; private set; }
        
			
			[Column("RDOrdInvCreated")]
			public  bool PopulateRDOrdInvCreated  {
				get { return RDOrdInvCreatedValue ;}
				set { RDOrdInvCreated.DataValue = value; }
			}

	
			public bool RDOrdInvCreatedValue 
			{ 
				get 
				{
				   if(RDOrdInvCreated.Value != null) {
				   					bool i = false;
					if (RDOrdInvCreated != null)
					{
						if (RDOrdInvCreated.Value != null)
						{
							if (Boolean.TryParse(RDOrdInvCreated.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { RDOrdInvCreated.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdDesc RDOrdDesc { get; set; }
		public static REDSOrder_RDOrdDescFieldDef RDOrdDescField { get; private set; }
        
			
			[Column("RDOrdDesc")]
			public  string PopulateRDOrdDesc  {
				get { return RDOrdDescValue ;}
				set { RDOrdDesc.DataValue = value; }
			}

	
			public string RDOrdDescValue 
			{ 
				get 
				{
				   if(RDOrdDesc.Value != null) {
				   return RDOrdDesc.Value.ToString(); 					}
					return "";
                
				}
				set { RDOrdDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdLocked RDOrdLocked { get; set; }
		public static REDSOrder_RDOrdLockedFieldDef RDOrdLockedField { get; private set; }
        
			
			[Column("RDOrdLocked")]
			public  bool PopulateRDOrdLocked  {
				get { return RDOrdLockedValue ;}
				set { RDOrdLocked.DataValue = value; }
			}

	
			public bool RDOrdLockedValue 
			{ 
				get 
				{
				   if(RDOrdLocked.Value != null) {
				   					bool i = false;
					if (RDOrdLocked != null)
					{
						if (RDOrdLocked.Value != null)
						{
							if (Boolean.TryParse(RDOrdLocked.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { RDOrdLocked.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdDutyPaid RDOrdDutyPaid { get; set; }
		public static REDSOrder_RDOrdDutyPaidFieldDef RDOrdDutyPaidField { get; private set; }
        
			
			[Column("RDOrdDutyPaid")]
			public  bool PopulateRDOrdDutyPaid  {
				get { return RDOrdDutyPaidValue ;}
				set { RDOrdDutyPaid.DataValue = value; }
			}

	
			public bool RDOrdDutyPaidValue 
			{ 
				get 
				{
				   if(RDOrdDutyPaid.Value != null) {
				   					bool i = false;
					if (RDOrdDutyPaid != null)
					{
						if (RDOrdDutyPaid.Value != null)
						{
							if (Boolean.TryParse(RDOrdDutyPaid.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { RDOrdDutyPaid.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdARCNo RDOrdARCNo { get; set; }
		public static REDSOrder_RDOrdARCNoFieldDef RDOrdARCNoField { get; private set; }
        
			
			[Column("RDOrdARCNo")]
			public  string PopulateRDOrdARCNo  {
				get { return RDOrdARCNoValue ;}
				set { RDOrdARCNo.DataValue = value; }
			}

	
			public string RDOrdARCNoValue 
			{ 
				get 
				{
				   if(RDOrdARCNo.Value != null) {
				   return RDOrdARCNo.Value.ToString(); 					}
					return "";
                
				}
				set { RDOrdARCNo.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrder_RDOrdHM10 RDOrdHM10 { get; set; }
		public static REDSOrder_RDOrdHM10FieldDef RDOrdHM10Field { get; private set; }
        
			
			[Column("RDOrdHM10")]
			public  bool PopulateRDOrdHM10  {
				get { return RDOrdHM10Value ;}
				set { RDOrdHM10.DataValue = value; }
			}

	
			public bool RDOrdHM10Value 
			{ 
				get 
				{
				   if(RDOrdHM10.Value != null) {
				   					bool i = false;
					if (RDOrdHM10 != null)
					{
						if (RDOrdHM10.Value != null)
						{
							if (Boolean.TryParse(RDOrdHM10.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { RDOrdHM10.Value = value;  }
			}
	}


public class REDSOrder_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 35;
    public int PixelHeight => 0;
	public string Title => "REDS Order Header";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
