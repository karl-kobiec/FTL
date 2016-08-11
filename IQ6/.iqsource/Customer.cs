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


public partial class CustomerController : DSBaseController<Customer/*,CustomerSearch*/> {
	public CustomerController() : base ((IDatabase)IQApp.DB, new CustomerRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select CustId from Customer where RecordID=@RecId", new { RecId = RecId});

					int count = 0;
						count += IQApp.DB.GetInt("select count(*) from Contact where ContCust=@Val", new { Val = Key});
						if(count > 0) {
				return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
			}
		
		string Msg = "Are you sure you want to delete this record?";
				
				Msg += " This will also delete any existing sub records.";
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Customer>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Customer data) {
											IQApp.DB.Execute("delete from Contact where ContCust=@Val", new { Val = data.CustIdValue});
										IQApp.DB.Execute("Delete from Customer where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.CustNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Customer " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Customer " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Customer " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Customer_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Customer>(Query).ToList());
				
	}
	
			public ActionResult SearchSendEmail() {
		
			EMail model = new EMail ();
			model.EMDSValue = "Customer";

			string field = "CustEM2  (E-Mail 2)";
			if(!string.IsNullOrEmpty(IQApp.WD.GetString("FieldToEmail"))) {
				field = IQApp.WD.GetString("FieldToEmail");
			} 
			model.EMDFValue = field;
			model.EMToRecordsValue = IQApp.DB.GetString("select cast(CustId as varchar) + ',' from Customer where RecordID in (" + IQApp.WD.GetString("RecordIDs") + ") for xml path ('')");
			model.Save();
			return Redirect("/EMail/Load/?RecId=" +model.RecordID.Value);
		}
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Customer>("select * from Customer  ").ToList();
		string urlpath = "/temp/Customers Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Customers");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 5])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 38;
					worksheet.Cells[1, 1].Value = "Company Name";
						
								
					worksheet.Column(2).Width = 24;
					worksheet.Cells[1, 2].Value = "Postcode";
						
								
					worksheet.Column(3).Width = 19;
					worksheet.Cells[1, 3].Value = "Country";
						
								
					worksheet.Column(4).Width = 19;
					worksheet.Cells[1, 4].Value = "Company ID";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].CustName.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].CustPC.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].CustCtry.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].CustId.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustSortCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustSortCodeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSortCode" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSortCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustSortCode(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSortCode" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSortCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustType" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustType(Customer m, int? id, string q) {

		
		string s = m.CustType.DataSource;
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
	public ActionResult CallbackCustType(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustType" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustVATNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustVATNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustVATNo" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustVATNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustVATNo(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustVATNo" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustVATNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustDANNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustDANNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDANNo" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDANNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustDANNo(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDANNo" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDANNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustBondCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustBondCodeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustBondCode" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustBondCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustBondCode(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustBondCode" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustBondCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustIntrastat(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustIntrastatValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustIntrastat" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustIntrastat")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustIntrastat(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustIntrastat" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustIntrastat")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCurr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustCurrValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCurr" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCurr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustCurr(Customer m, int? id, string q) {

		
		string s = m.CustCurr.DataSource;
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
	public ActionResult CallbackCustCurr(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCurr" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCurr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustRates(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustRatesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRates" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRates")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustRates(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRates" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRates")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustGenNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustGenNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGenNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGenNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustGenNotes(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGenNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGenNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustLang(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustLangValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustLang" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustLang")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustLang(Customer m, int? id, string q) {

		
		string s = m.CustLang.DataSource;
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
	public ActionResult CallbackCustLang(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustLang" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustLang")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustSendStatus(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustSendStatusValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSendStatus" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSendStatus")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustSendStatus(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSendStatus" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustSendStatus")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustFTLNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustFTLNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFTLNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFTLNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustFTLNotes(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFTLNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFTLNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustOnFTrack(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustOnFTrackValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustOnFTrack" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustOnFTrack")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustOnFTrack(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustOnFTrack" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustOnFTrack")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustDelZone(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustDelZoneValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDelZone" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDelZone")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustDelZone(Customer m, int? id, string q) {

		
		string s = m.CustDelZone.DataSource;
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
	public ActionResult CallbackCustDelZone(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDelZone" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDelZone")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCreatedBy(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustCreatedByValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCreatedBy" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCreatedBy")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustCreatedBy(Customer m, int? id, string q) {

		
		string s = m.CustCreatedBy.DataSource;
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
	public ActionResult CallbackCustCreatedBy(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCreatedBy" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCreatedBy")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustEM2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustEM2Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM2" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustEM2(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM2" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustEM3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustEM3Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM3" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustEM3(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM3" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustEM4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustEM4Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM4" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustEM4(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM4" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustAADSys(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustAADSysValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAADSys" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAADSys")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustAADSys(Customer m, int? id, string q) {

		
		string s = m.CustAADSys.DataSource;
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
	public ActionResult CallbackCustAADSys(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAADSys" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAADSys")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustGBWK(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustGBWKValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGBWK" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGBWK")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustGBWK(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGBWK" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustGBWK")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustId" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustId(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustId" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustName" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustName(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustName" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustAddr(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustAddr2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustAddr2Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr2" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustAddr2(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr2" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustAddr3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustAddr3Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr3" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustAddr3(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr3" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAddr3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustTown(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustTownValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustTown" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustTown")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustTown(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustTown" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustTown")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCounty(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustCountyValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCounty" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCounty")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCounty(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCounty" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCounty")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustPC(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustPCValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPC" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPC")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustPC(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPC" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPC")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCtry(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustCtryValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCtry" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCtry")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCustCtry(Customer m, int? id, string q) {

		
		string s = m.CustCtry.DataSource;
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
	public ActionResult CallbackCustCtry(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCtry" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCtry")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustPhone(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustPhoneValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPhone" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPhone")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustPhone(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPhone" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPhone")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustFax(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustFaxValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFax" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFax")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustFax(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFax" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustFax")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustEM(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustEMValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustEM(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustEM")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustUserName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustUserNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustUserName" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustUserName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustUserName(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustUserName" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustUserName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustPassword(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustPasswordValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPassword" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPassword")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustPassword(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPassword" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustPassword")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustDueDiligence(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustDueDiligenceValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDueDiligence" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDueDiligence")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustDueDiligence(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDueDiligence" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustDueDiligence")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCredScoreSearch(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustCredScoreSearchValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreSearch" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreSearch")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCredScoreSearch(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreSearch" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreSearch")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCredScore(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CustCredScoreValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScore" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScore")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCredScore(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScore" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScore")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCredScoreReview(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustCredScoreReviewValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreReview" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreReview")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCredScoreReview(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreReview" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCredScoreReview")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustWebsite(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustWebsiteValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustWebsite" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustWebsite")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustWebsite(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustWebsite" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustWebsite")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustRecDueDil(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustRecDueDilValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRecDueDil" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRecDueDil")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustRecDueDil(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRecDueDil" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustRecDueDil")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCrdChecked(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustCrdCheckedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdChecked" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdChecked")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCrdChecked(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdChecked" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdChecked")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCrdScr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustCrdScrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdScr" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdScr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCrdScr(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdScr" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdScr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustCrdRvDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CustCrdRvDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdRvDate" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdRvDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustCrdRvDate(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdRvDate" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustCrdRvDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustAccContact(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustAccContactValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccContact" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccContact")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustAccContact(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccContact" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccContact")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCustAccEmail(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CustAccEmailValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccEmail" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccEmail")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCustAccEmail(Customer obj) {
			
		if(DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccEmail" ).Any()) {
			foreach(var itm in DS.GetManager<Customer>().OnChange.Where(f=> f.Key == "CustAccEmail")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Customer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=33 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/Customer/Search/" + FirstSearch);
		
		return Redirect("/Customer/List/");
	}

}

public partial class CustomerRepository : DSRepository<Customer> {
	public CustomerRepository() : base(33, "Customer", "Customers") {
	}
}
public partial class Customer 
: DatasetBase<Customer>, IDSBase

  {
	  public int KeyValue => CustIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "CustSortCode":
			return CustSortCodeField;
				case "CustType":
			return CustTypeField;
				case "CustVATNo":
			return CustVATNoField;
				case "CustDANNo":
			return CustDANNoField;
				case "CustBondCode":
			return CustBondCodeField;
				case "CustIntrastat":
			return CustIntrastatField;
				case "CustCurr":
			return CustCurrField;
				case "CustRates":
			return CustRatesField;
				case "CustGenNotes":
			return CustGenNotesField;
				case "CustLang":
			return CustLangField;
				case "CustSendStatus":
			return CustSendStatusField;
				case "CustFTLNotes":
			return CustFTLNotesField;
				case "CustOnFTrack":
			return CustOnFTrackField;
				case "CustDelZone":
			return CustDelZoneField;
				case "CustCreatedBy":
			return CustCreatedByField;
				case "CustEM2":
			return CustEM2Field;
				case "CustEM3":
			return CustEM3Field;
				case "CustEM4":
			return CustEM4Field;
				case "CustAADSys":
			return CustAADSysField;
				case "CustGBWK":
			return CustGBWKField;
				case "CustId":
			return CustIdField;
				case "CustName":
			return CustNameField;
				case "CustAddr":
			return CustAddrField;
				case "CustAddr2":
			return CustAddr2Field;
				case "CustAddr3":
			return CustAddr3Field;
				case "CustTown":
			return CustTownField;
				case "CustCounty":
			return CustCountyField;
				case "CustPC":
			return CustPCField;
				case "CustCtry":
			return CustCtryField;
				case "CustPhone":
			return CustPhoneField;
				case "CustFax":
			return CustFaxField;
				case "CustEM":
			return CustEMField;
				case "CustUserName":
			return CustUserNameField;
				case "CustPassword":
			return CustPasswordField;
				case "CustDueDiligence":
			return CustDueDiligenceField;
				case "CustCredScoreSearch":
			return CustCredScoreSearchField;
				case "CustCredScore":
			return CustCredScoreField;
				case "CustCredScoreReview":
			return CustCredScoreReviewField;
				case "CustWebsite":
			return CustWebsiteField;
				case "CustRecDueDil":
			return CustRecDueDilField;
				case "CustCrdChecked":
			return CustCrdCheckedField;
				case "CustCrdScr":
			return CustCrdScrField;
				case "CustCrdRvDate":
			return CustCrdRvDateField;
				case "CustAccContact":
			return CustAccContactField;
				case "CustAccEmail":
			return CustAccEmailField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(CustSortCode,CustSortCodeField);
				action(CustType,CustTypeField);
				action(CustVATNo,CustVATNoField);
				action(CustDANNo,CustDANNoField);
				action(CustBondCode,CustBondCodeField);
				action(CustIntrastat,CustIntrastatField);
				action(CustCurr,CustCurrField);
				action(CustRates,CustRatesField);
				action(CustGenNotes,CustGenNotesField);
				action(CustLang,CustLangField);
				action(CustSendStatus,CustSendStatusField);
				action(CustFTLNotes,CustFTLNotesField);
				action(CustOnFTrack,CustOnFTrackField);
				action(CustDelZone,CustDelZoneField);
				action(CustCreatedBy,CustCreatedByField);
				action(CustEM2,CustEM2Field);
				action(CustEM3,CustEM3Field);
				action(CustEM4,CustEM4Field);
				action(CustAADSys,CustAADSysField);
				action(CustGBWK,CustGBWKField);
				action(CustId,CustIdField);
				action(CustName,CustNameField);
				action(CustAddr,CustAddrField);
				action(CustAddr2,CustAddr2Field);
				action(CustAddr3,CustAddr3Field);
				action(CustTown,CustTownField);
				action(CustCounty,CustCountyField);
				action(CustPC,CustPCField);
				action(CustCtry,CustCtryField);
				action(CustPhone,CustPhoneField);
				action(CustFax,CustFaxField);
				action(CustEM,CustEMField);
				action(CustUserName,CustUserNameField);
				action(CustPassword,CustPasswordField);
				action(CustDueDiligence,CustDueDiligenceField);
				action(CustCredScoreSearch,CustCredScoreSearchField);
				action(CustCredScore,CustCredScoreField);
				action(CustCredScoreReview,CustCredScoreReviewField);
				action(CustWebsite,CustWebsiteField);
				action(CustRecDueDil,CustRecDueDilField);
				action(CustCrdChecked,CustCrdCheckedField);
				action(CustCrdScr,CustCrdScrField);
				action(CustCrdRvDate,CustCrdRvDateField);
				action(CustAccContact,CustAccContactField);
				action(CustAccEmail,CustAccEmailField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				CustSortCode.Visible=false;CustType.Visible=false;CustVATNo.Visible=false;CustDANNo.Visible=false;CustBondCode.Visible=false;CustIntrastat.Visible=false;CustCurr.Visible=false;CustRates.Visible=false;CustGenNotes.Visible=false;CustLang.Visible=false;CustSendStatus.Visible=false;CustFTLNotes.Visible=false;CustOnFTrack.Visible=false;CustDelZone.Visible=false;CustCreatedBy.Visible=false;CustEM2.Visible=false;CustEM3.Visible=false;CustEM4.Visible=false;CustAADSys.Visible=false;CustGBWK.Visible=false;CustId.Visible=false;CustName.Visible=false;CustAddr.Visible=false;CustAddr2.Visible=false;CustAddr3.Visible=false;CustTown.Visible=false;CustCounty.Visible=false;CustPC.Visible=false;CustCtry.Visible=false;CustPhone.Visible=false;CustFax.Visible=false;CustEM.Visible=false;CustUserName.Visible=false;CustPassword.Visible=false;CustDueDiligence.Visible=false;CustCredScoreSearch.Visible=false;CustCredScore.Visible=false;CustCredScoreReview.Visible=false;CustWebsite.Visible=false;CustRecDueDil.Visible=false;CustCrdChecked.Visible=false;CustCrdScr.Visible=false;CustCrdRvDate.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Customer set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (CustSortCode.HasChanged && CustSortCode.HasValue) {
					SQL += ", CustSortCode=@CustSortCodeValue";

				}
								if (CustType.HasChanged && CustType.HasValue) {
					SQL += ", CustType=@CustTypeValue";

				}
								if (CustVATNo.HasChanged && CustVATNo.HasValue) {
					SQL += ", CustVATNo=@CustVATNoValue";

				}
								if (CustDANNo.HasChanged && CustDANNo.HasValue) {
					SQL += ", CustDANNo=@CustDANNoValue";

				}
								if (CustBondCode.HasChanged && CustBondCode.HasValue) {
					SQL += ", CustBondCode=@CustBondCodeValue";

				}
								if (CustIntrastat.HasChanged && CustIntrastat.HasValue) {
					SQL += ", CustIntrastat=@CustIntrastatValue";

				}
								if (CustCurr.HasChanged && CustCurr.HasValue) {
					SQL += ", CustCurr=@CustCurrValue";

				}
								if (CustRates.HasChanged && CustRates.HasValue) {
					SQL += ", CustRates=@CustRatesValue";

				}
								if (CustGenNotes.HasChanged && CustGenNotes.HasValue) {
					SQL += ", CustGenNotes=@CustGenNotesValue";

				}
								if (CustLang.HasChanged && CustLang.HasValue) {
					SQL += ", CustLang=@CustLangValue";

				}
								if (CustSendStatus.HasChanged && CustSendStatus.HasValue) {
					SQL += ", CustSendStatus=@CustSendStatusValue";

				}
								if (CustFTLNotes.HasChanged && CustFTLNotes.HasValue) {
					SQL += ", CustFTLNotes=@CustFTLNotesValue";

				}
								if (CustOnFTrack.HasChanged && CustOnFTrack.HasValue) {
					SQL += ", CustOnFTrack=@CustOnFTrackValue";

				}
								if (CustDelZone.HasChanged && CustDelZone.HasValue) {
					SQL += ", CustDelZone=@CustDelZoneValue";

				}
								if (CustCreatedBy.HasChanged && CustCreatedBy.HasValue) {
					SQL += ", CustCreatedBy=@CustCreatedByValue";

				}
								if (CustEM2.HasChanged && CustEM2.HasValue) {
					SQL += ", CustEM2=@CustEM2Value";

				}
								if (CustEM3.HasChanged && CustEM3.HasValue) {
					SQL += ", CustEM3=@CustEM3Value";

				}
								if (CustEM4.HasChanged && CustEM4.HasValue) {
					SQL += ", CustEM4=@CustEM4Value";

				}
								if (CustAADSys.HasChanged && CustAADSys.HasValue) {
					SQL += ", CustAADSys=@CustAADSysValue";

				}
								if (CustGBWK.HasChanged && CustGBWK.HasValue) {
					SQL += ", CustGBWK=@CustGBWKValue";

				}
								if (CustId.HasChanged && CustId.HasValue) {
					SQL += ", CustId=@CustIdValue";

				}
								if (CustName.HasChanged && CustName.HasValue) {
					SQL += ", CustName=@CustNameValue";

				}
								if (CustAddr.HasChanged && CustAddr.HasValue) {
					SQL += ", CustAddr=@CustAddrValue";

				}
								if (CustAddr2.HasChanged && CustAddr2.HasValue) {
					SQL += ", CustAddr2=@CustAddr2Value";

				}
								if (CustAddr3.HasChanged && CustAddr3.HasValue) {
					SQL += ", CustAddr3=@CustAddr3Value";

				}
								if (CustTown.HasChanged && CustTown.HasValue) {
					SQL += ", CustTown=@CustTownValue";

				}
								if (CustCounty.HasChanged && CustCounty.HasValue) {
					SQL += ", CustCounty=@CustCountyValue";

				}
								if (CustPC.HasChanged && CustPC.HasValue) {
					SQL += ", CustPC=@CustPCValue";

				}
								if (CustCtry.HasChanged && CustCtry.HasValue) {
					SQL += ", CustCtry=@CustCtryValue";

				}
								if (CustPhone.HasChanged && CustPhone.HasValue) {
					SQL += ", CustPhone=@CustPhoneValue";

				}
								if (CustFax.HasChanged && CustFax.HasValue) {
					SQL += ", CustFax=@CustFaxValue";

				}
								if (CustEM.HasChanged && CustEM.HasValue) {
					SQL += ", CustEM=@CustEMValue";

				}
								if (CustUserName.HasChanged && CustUserName.HasValue) {
					SQL += ", CustUserName=@CustUserNameValue";

				}
								if (CustPassword.HasChanged && CustPassword.HasValue) {
					SQL += ", CustPassword=@CustPasswordValue";

				}
								if (CustDueDiligence.HasChanged && CustDueDiligence.HasValue) {
					SQL += ", CustDueDiligence=@CustDueDiligenceValue";

				}
								if (CustCredScoreSearch.HasChanged && CustCredScoreSearch.HasValue) {
					SQL += ", CustCredScoreSearch=@CustCredScoreSearchValue";

				}
								if (CustCredScore.HasChanged && CustCredScore.HasValue) {
					SQL += ", CustCredScore=@CustCredScoreValue";

				}
								if (CustCredScoreReview.HasChanged && CustCredScoreReview.HasValue) {
					SQL += ", CustCredScoreReview=@CustCredScoreReviewValue";

				}
								if (CustWebsite.HasChanged && CustWebsite.HasValue) {
					SQL += ", CustWebsite=@CustWebsiteValue";

				}
								if (CustRecDueDil.HasChanged && CustRecDueDil.HasValue) {
					SQL += ", CustRecDueDil=@CustRecDueDilValue";

				}
								if (CustCrdChecked.HasChanged && CustCrdChecked.HasValue) {
					SQL += ", CustCrdChecked=@CustCrdCheckedValue";

				}
								if (CustCrdScr.HasChanged && CustCrdScr.HasValue) {
					SQL += ", CustCrdScr=@CustCrdScrValue";

				}
								if (CustCrdRvDate.HasChanged && CustCrdRvDate.HasValue) {
					SQL += ", CustCrdRvDate=@CustCrdRvDateValue";

				}
								if (CustAccContact.HasChanged && CustAccContact.HasValue) {
					SQL += ", CustAccContact=@CustAccContactValue";

				}
								if (CustAccEmail.HasChanged && CustAccEmail.HasValue) {
					SQL += ", CustAccEmail=@CustAccEmailValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									CustSortCode.HasChanged = false;
									CustType.HasChanged = false;
									CustVATNo.HasChanged = false;
									CustDANNo.HasChanged = false;
									CustBondCode.HasChanged = false;
									CustIntrastat.HasChanged = false;
									CustCurr.HasChanged = false;
									CustRates.HasChanged = false;
									CustGenNotes.HasChanged = false;
									CustLang.HasChanged = false;
									CustSendStatus.HasChanged = false;
									CustFTLNotes.HasChanged = false;
									CustOnFTrack.HasChanged = false;
									CustDelZone.HasChanged = false;
									CustCreatedBy.HasChanged = false;
									CustEM2.HasChanged = false;
									CustEM3.HasChanged = false;
									CustEM4.HasChanged = false;
									CustAADSys.HasChanged = false;
									CustGBWK.HasChanged = false;
									CustId.HasChanged = false;
									CustName.HasChanged = false;
									CustAddr.HasChanged = false;
									CustAddr2.HasChanged = false;
									CustAddr3.HasChanged = false;
									CustTown.HasChanged = false;
									CustCounty.HasChanged = false;
									CustPC.HasChanged = false;
									CustCtry.HasChanged = false;
									CustPhone.HasChanged = false;
									CustFax.HasChanged = false;
									CustEM.HasChanged = false;
									CustUserName.HasChanged = false;
									CustPassword.HasChanged = false;
									CustDueDiligence.HasChanged = false;
									CustCredScoreSearch.HasChanged = false;
									CustCredScore.HasChanged = false;
									CustCredScoreReview.HasChanged = false;
									CustWebsite.HasChanged = false;
									CustRecDueDil.HasChanged = false;
									CustCrdChecked.HasChanged = false;
									CustCrdScr.HasChanged = false;
									CustCrdRvDate.HasChanged = false;
									CustAccContact.HasChanged = false;
									CustAccEmail.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Customer(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (CustSortCode.HasValue) {
					SQL += ", CustSortCode";
					Values += ", @CustSortCodeValue";
				}
				
				if (CustType.HasValue) {
					SQL += ", CustType";
					Values += ", @CustTypeValue";
				}
				
				if (CustVATNo.HasValue) {
					SQL += ", CustVATNo";
					Values += ", @CustVATNoValue";
				}
				
				if (CustDANNo.HasValue) {
					SQL += ", CustDANNo";
					Values += ", @CustDANNoValue";
				}
				
				if (CustBondCode.HasValue) {
					SQL += ", CustBondCode";
					Values += ", @CustBondCodeValue";
				}
				
				if (CustIntrastat.HasValue) {
					SQL += ", CustIntrastat";
					Values += ", @CustIntrastatValue";
				}
				
				if (CustCurr.HasValue) {
					SQL += ", CustCurr";
					Values += ", @CustCurrValue";
				}
				
				if (CustRates.HasValue) {
					SQL += ", CustRates";
					Values += ", @CustRatesValue";
				}
				
				if (CustGenNotes.HasValue) {
					SQL += ", CustGenNotes";
					Values += ", @CustGenNotesValue";
				}
				
				if (CustLang.HasValue) {
					SQL += ", CustLang";
					Values += ", @CustLangValue";
				}
				
				if (CustSendStatus.HasValue) {
					SQL += ", CustSendStatus";
					Values += ", @CustSendStatusValue";
				}
				
				if (CustFTLNotes.HasValue) {
					SQL += ", CustFTLNotes";
					Values += ", @CustFTLNotesValue";
				}
				
				if (CustOnFTrack.HasValue) {
					SQL += ", CustOnFTrack";
					Values += ", @CustOnFTrackValue";
				}
				
				if (CustDelZone.HasValue) {
					SQL += ", CustDelZone";
					Values += ", @CustDelZoneValue";
				}
				
				if (CustCreatedBy.HasValue) {
					SQL += ", CustCreatedBy";
					Values += ", @CustCreatedByValue";
				}
				
				if (CustEM2.HasValue) {
					SQL += ", CustEM2";
					Values += ", @CustEM2Value";
				}
				
				if (CustEM3.HasValue) {
					SQL += ", CustEM3";
					Values += ", @CustEM3Value";
				}
				
				if (CustEM4.HasValue) {
					SQL += ", CustEM4";
					Values += ", @CustEM4Value";
				}
				
				if (CustAADSys.HasValue) {
					SQL += ", CustAADSys";
					Values += ", @CustAADSysValue";
				}
				
				if (CustGBWK.HasValue) {
					SQL += ", CustGBWK";
					Values += ", @CustGBWKValue";
				}
				CustId.Value = IQApp.DB.GetInt("select isnull(max(CustId),0)+1 from Customer");
				if (CustId.HasValue) {
					SQL += ", CustId";
					Values += ", @CustIdValue";
				}
				
				if (CustName.HasValue) {
					SQL += ", CustName";
					Values += ", @CustNameValue";
				}
				
				if (CustAddr.HasValue) {
					SQL += ", CustAddr";
					Values += ", @CustAddrValue";
				}
				
				if (CustAddr2.HasValue) {
					SQL += ", CustAddr2";
					Values += ", @CustAddr2Value";
				}
				
				if (CustAddr3.HasValue) {
					SQL += ", CustAddr3";
					Values += ", @CustAddr3Value";
				}
				
				if (CustTown.HasValue) {
					SQL += ", CustTown";
					Values += ", @CustTownValue";
				}
				
				if (CustCounty.HasValue) {
					SQL += ", CustCounty";
					Values += ", @CustCountyValue";
				}
				
				if (CustPC.HasValue) {
					SQL += ", CustPC";
					Values += ", @CustPCValue";
				}
				
				if (CustCtry.HasValue) {
					SQL += ", CustCtry";
					Values += ", @CustCtryValue";
				}
				
				if (CustPhone.HasValue) {
					SQL += ", CustPhone";
					Values += ", @CustPhoneValue";
				}
				
				if (CustFax.HasValue) {
					SQL += ", CustFax";
					Values += ", @CustFaxValue";
				}
				
				if (CustEM.HasValue) {
					SQL += ", CustEM";
					Values += ", @CustEMValue";
				}
				
				if (CustUserName.HasValue) {
					SQL += ", CustUserName";
					Values += ", @CustUserNameValue";
				}
				
				if (CustPassword.HasValue) {
					SQL += ", CustPassword";
					Values += ", @CustPasswordValue";
				}
				
				if (CustDueDiligence.HasValue) {
					SQL += ", CustDueDiligence";
					Values += ", @CustDueDiligenceValue";
				}
				
				if (CustCredScoreSearch.HasValue) {
					SQL += ", CustCredScoreSearch";
					Values += ", @CustCredScoreSearchValue";
				}
				
				if (CustCredScore.HasValue) {
					SQL += ", CustCredScore";
					Values += ", @CustCredScoreValue";
				}
				
				if (CustCredScoreReview.HasValue) {
					SQL += ", CustCredScoreReview";
					Values += ", @CustCredScoreReviewValue";
				}
				
				if (CustWebsite.HasValue) {
					SQL += ", CustWebsite";
					Values += ", @CustWebsiteValue";
				}
				
				if (CustRecDueDil.HasValue) {
					SQL += ", CustRecDueDil";
					Values += ", @CustRecDueDilValue";
				}
				
				if (CustCrdChecked.HasValue) {
					SQL += ", CustCrdChecked";
					Values += ", @CustCrdCheckedValue";
				}
				
				if (CustCrdScr.HasValue) {
					SQL += ", CustCrdScr";
					Values += ", @CustCrdScrValue";
				}
				
				if (CustCrdRvDate.HasValue) {
					SQL += ", CustCrdRvDate";
					Values += ", @CustCrdRvDateValue";
				}
				
				if (CustAccContact.HasValue) {
					SQL += ", CustAccContact";
					Values += ", @CustAccContactValue";
				}
				
				if (CustAccEmail.HasValue) {
					SQL += ", CustAccEmail";
					Values += ", @CustAccEmailValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Customer");
					 IQApp.DB.Execute(SQL, this);
				                    					CustSortCode.HasChanged = false;
									CustType.HasChanged = false;
									CustVATNo.HasChanged = false;
									CustDANNo.HasChanged = false;
									CustBondCode.HasChanged = false;
									CustIntrastat.HasChanged = false;
									CustCurr.HasChanged = false;
									CustRates.HasChanged = false;
									CustGenNotes.HasChanged = false;
									CustLang.HasChanged = false;
									CustSendStatus.HasChanged = false;
									CustFTLNotes.HasChanged = false;
									CustOnFTrack.HasChanged = false;
									CustDelZone.HasChanged = false;
									CustCreatedBy.HasChanged = false;
									CustEM2.HasChanged = false;
									CustEM3.HasChanged = false;
									CustEM4.HasChanged = false;
									CustAADSys.HasChanged = false;
									CustGBWK.HasChanged = false;
									CustId.HasChanged = false;
									CustName.HasChanged = false;
									CustAddr.HasChanged = false;
									CustAddr2.HasChanged = false;
									CustAddr3.HasChanged = false;
									CustTown.HasChanged = false;
									CustCounty.HasChanged = false;
									CustPC.HasChanged = false;
									CustCtry.HasChanged = false;
									CustPhone.HasChanged = false;
									CustFax.HasChanged = false;
									CustEM.HasChanged = false;
									CustUserName.HasChanged = false;
									CustPassword.HasChanged = false;
									CustDueDiligence.HasChanged = false;
									CustCredScoreSearch.HasChanged = false;
									CustCredScore.HasChanged = false;
									CustCredScoreReview.HasChanged = false;
									CustWebsite.HasChanged = false;
									CustRecDueDil.HasChanged = false;
									CustCrdChecked.HasChanged = false;
									CustCrdScr.HasChanged = false;
									CustCrdRvDate.HasChanged = false;
									CustAccContact.HasChanged = false;
									CustAccEmail.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "CustSortCode":
					return (IDSFieldBase)CustSortCode;
								case "CustType":
					return (IDSFieldBase)CustType;
								case "CustVATNo":
					return (IDSFieldBase)CustVATNo;
								case "CustDANNo":
					return (IDSFieldBase)CustDANNo;
								case "CustBondCode":
					return (IDSFieldBase)CustBondCode;
								case "CustIntrastat":
					return (IDSFieldBase)CustIntrastat;
								case "CustCurr":
					return (IDSFieldBase)CustCurr;
								case "CustRates":
					return (IDSFieldBase)CustRates;
								case "CustGenNotes":
					return (IDSFieldBase)CustGenNotes;
								case "CustLang":
					return (IDSFieldBase)CustLang;
								case "CustSendStatus":
					return (IDSFieldBase)CustSendStatus;
								case "CustFTLNotes":
					return (IDSFieldBase)CustFTLNotes;
								case "CustOnFTrack":
					return (IDSFieldBase)CustOnFTrack;
								case "CustDelZone":
					return (IDSFieldBase)CustDelZone;
								case "CustCreatedBy":
					return (IDSFieldBase)CustCreatedBy;
								case "CustEM2":
					return (IDSFieldBase)CustEM2;
								case "CustEM3":
					return (IDSFieldBase)CustEM3;
								case "CustEM4":
					return (IDSFieldBase)CustEM4;
								case "CustAADSys":
					return (IDSFieldBase)CustAADSys;
								case "CustGBWK":
					return (IDSFieldBase)CustGBWK;
								case "CustId":
					return (IDSFieldBase)CustId;
								case "CustName":
					return (IDSFieldBase)CustName;
								case "CustAddr":
					return (IDSFieldBase)CustAddr;
								case "CustAddr2":
					return (IDSFieldBase)CustAddr2;
								case "CustAddr3":
					return (IDSFieldBase)CustAddr3;
								case "CustTown":
					return (IDSFieldBase)CustTown;
								case "CustCounty":
					return (IDSFieldBase)CustCounty;
								case "CustPC":
					return (IDSFieldBase)CustPC;
								case "CustCtry":
					return (IDSFieldBase)CustCtry;
								case "CustPhone":
					return (IDSFieldBase)CustPhone;
								case "CustFax":
					return (IDSFieldBase)CustFax;
								case "CustEM":
					return (IDSFieldBase)CustEM;
								case "CustUserName":
					return (IDSFieldBase)CustUserName;
								case "CustPassword":
					return (IDSFieldBase)CustPassword;
								case "CustDueDiligence":
					return (IDSFieldBase)CustDueDiligence;
								case "CustCredScoreSearch":
					return (IDSFieldBase)CustCredScoreSearch;
								case "CustCredScore":
					return (IDSFieldBase)CustCredScore;
								case "CustCredScoreReview":
					return (IDSFieldBase)CustCredScoreReview;
								case "CustWebsite":
					return (IDSFieldBase)CustWebsite;
								case "CustRecDueDil":
					return (IDSFieldBase)CustRecDueDil;
								case "CustCrdChecked":
					return (IDSFieldBase)CustCrdChecked;
								case "CustCrdScr":
					return (IDSFieldBase)CustCrdScr;
								case "CustCrdRvDate":
					return (IDSFieldBase)CustCrdRvDate;
								case "CustAccContact":
					return (IDSFieldBase)CustAccContact;
								case "CustAccEmail":
					return (IDSFieldBase)CustAccEmail;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "CustSortCode":
					return CustSortCode.DisplayValue;
								case "CustType":
					return CustType.DisplayValue;
								case "CustVATNo":
					return CustVATNo.DisplayValue;
								case "CustDANNo":
					return CustDANNo.DisplayValue;
								case "CustBondCode":
					return CustBondCode.DisplayValue;
								case "CustIntrastat":
					return CustIntrastat.DisplayValue;
								case "CustCurr":
					return CustCurr.DisplayValue;
								case "CustRates":
					return CustRates.DisplayValue;
								case "CustGenNotes":
					return CustGenNotes.DisplayValue;
								case "CustLang":
					return CustLang.DisplayValue;
								case "CustSendStatus":
					return CustSendStatus.DisplayValue;
								case "CustFTLNotes":
					return CustFTLNotes.DisplayValue;
								case "CustOnFTrack":
					return CustOnFTrack.DisplayValue;
								case "CustDelZone":
					return CustDelZone.DisplayValue;
								case "CustCreatedBy":
					return CustCreatedBy.DisplayValue;
								case "CustEM2":
					return CustEM2.DisplayValue;
								case "CustEM3":
					return CustEM3.DisplayValue;
								case "CustEM4":
					return CustEM4.DisplayValue;
								case "CustAADSys":
					return CustAADSys.DisplayValue;
								case "CustGBWK":
					return CustGBWK.DisplayValue;
								case "CustId":
					return CustId.DisplayValue;
								case "CustName":
					return CustName.DisplayValue;
								case "CustAddr":
					return CustAddr.DisplayValue;
								case "CustAddr2":
					return CustAddr2.DisplayValue;
								case "CustAddr3":
					return CustAddr3.DisplayValue;
								case "CustTown":
					return CustTown.DisplayValue;
								case "CustCounty":
					return CustCounty.DisplayValue;
								case "CustPC":
					return CustPC.DisplayValue;
								case "CustCtry":
					return CustCtry.DisplayValue;
								case "CustPhone":
					return CustPhone.DisplayValue;
								case "CustFax":
					return CustFax.DisplayValue;
								case "CustEM":
					return CustEM.DisplayValue;
								case "CustUserName":
					return CustUserName.DisplayValue;
								case "CustPassword":
					return CustPassword.DisplayValue;
								case "CustDueDiligence":
					return CustDueDiligence.DisplayValue;
								case "CustCredScoreSearch":
					return CustCredScoreSearch.DisplayValue;
								case "CustCredScore":
					return CustCredScore.DisplayValue;
								case "CustCredScoreReview":
					return CustCredScoreReview.DisplayValue;
								case "CustWebsite":
					return CustWebsite.DisplayValue;
								case "CustRecDueDil":
					return CustRecDueDil.DisplayValue;
								case "CustCrdChecked":
					return CustCrdChecked.DisplayValue;
								case "CustCrdScr":
					return CustCrdScr.DisplayValue;
								case "CustCrdRvDate":
					return CustCrdRvDate.DisplayValue;
								case "CustAccContact":
					return CustAccContact.DisplayValue;
								case "CustAccEmail":
					return CustAccEmail.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "CustSortCode":
					return CustSortCode.Value.ToString();
								case "CustType":
					return CustType.Value.ToString();
								case "CustVATNo":
					return CustVATNo.Value.ToString();
								case "CustDANNo":
					return CustDANNo.Value.ToString();
								case "CustBondCode":
					return CustBondCode.Value.ToString();
								case "CustIntrastat":
					return CustIntrastat.Value.ToString();
								case "CustCurr":
					return CustCurr.Value.ToString();
								case "CustRates":
					return CustRates.Value.ToString();
								case "CustGenNotes":
					return CustGenNotes.Value.ToString();
								case "CustLang":
					return CustLang.Value.ToString();
								case "CustSendStatus":
					return CustSendStatus.Value.ToString();
								case "CustFTLNotes":
					return CustFTLNotes.Value.ToString();
								case "CustOnFTrack":
					return CustOnFTrack.Value.ToString();
								case "CustDelZone":
					return CustDelZone.Value.ToString();
								case "CustCreatedBy":
					return CustCreatedBy.Value.ToString();
								case "CustEM2":
					return CustEM2.Value.ToString();
								case "CustEM3":
					return CustEM3.Value.ToString();
								case "CustEM4":
					return CustEM4.Value.ToString();
								case "CustAADSys":
					return CustAADSys.Value.ToString();
								case "CustGBWK":
					return CustGBWK.Value.ToString();
								case "CustId":
					return CustId.Value.ToString();
								case "CustName":
					return CustName.Value.ToString();
								case "CustAddr":
					return CustAddr.Value.ToString();
								case "CustAddr2":
					return CustAddr2.Value.ToString();
								case "CustAddr3":
					return CustAddr3.Value.ToString();
								case "CustTown":
					return CustTown.Value.ToString();
								case "CustCounty":
					return CustCounty.Value.ToString();
								case "CustPC":
					return CustPC.Value.ToString();
								case "CustCtry":
					return CustCtry.Value.ToString();
								case "CustPhone":
					return CustPhone.Value.ToString();
								case "CustFax":
					return CustFax.Value.ToString();
								case "CustEM":
					return CustEM.Value.ToString();
								case "CustUserName":
					return CustUserName.Value.ToString();
								case "CustPassword":
					return CustPassword.Value.ToString();
								case "CustDueDiligence":
					return CustDueDiligence.Value.ToString();
								case "CustCredScoreSearch":
					return CustCredScoreSearch.Value.ToString();
								case "CustCredScore":
					return CustCredScore.Value.ToString();
								case "CustCredScoreReview":
					return CustCredScoreReview.Value.ToString();
								case "CustWebsite":
					return CustWebsite.Value.ToString();
								case "CustRecDueDil":
					return CustRecDueDil.Value.ToString();
								case "CustCrdChecked":
					return CustCrdChecked.Value.ToString();
								case "CustCrdScr":
					return CustCrdScr.Value.ToString();
								case "CustCrdRvDate":
					return CustCrdRvDate.Value.ToString();
								case "CustAccContact":
					return CustAccContact.Value.ToString();
								case "CustAccEmail":
					return CustAccEmail.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								scrns.Add(new Contact_ListScreen());
								scrns.Add(new CertShip_ListScreen());
								scrns.Add(new CN_ListScreen());
								scrns.Add(new Inv_ListScreen());
								scrns.Add(new Job_ListScreen());
								scrns.Add(new Orders_ListScreen());
								scrns.Add(new ShipDoc_ListScreen());
								scrns.Add(new UKOrder_ListScreen());
								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<Customer>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		        private List<Contact> _ChildContact;
        public List<Contact> Contacts
        {
            get
            {
                if (_ChildContact == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildContact = IQApp.DB.Load<Contact>("select * from Contact where ContCust=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildContact;
            }set {}
        }
        public int ContactCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Contact where ContCust=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<CertShip> _ChildCertShip;
        public List<CertShip> CertShips
        {
            get
            {
                if (_ChildCertShip == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildCertShip = IQApp.DB.Load<CertShip>("select * from CertShip where CSCust=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildCertShip;
            }set {}
        }
        public int CertShipCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CertShip where CSCust=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<CN> _ChildCN;
        public List<CN> CNs
        {
            get
            {
                if (_ChildCN == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildCN = IQApp.DB.Load<CN>("select * from CN where CNTo=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildCN;
            }set {}
        }
        public int CNCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CN where CNTo=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<Inv> _ChildInv;
        public List<Inv> Invs
        {
            get
            {
                if (_ChildInv == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildInv = IQApp.DB.Load<Inv>("select * from Inv where InvTo=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildInv;
            }set {}
        }
        public int InvCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Inv where InvTo=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<Job> _ChildJob;
        public List<Job> Jobs
        {
            get
            {
                if (_ChildJob == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildJob = IQApp.DB.Load<Job>("select * from Job where JobTransp=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildJob;
            }set {}
        }
        public int JobCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Job where JobTransp=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<Orders> _ChildOrders;
        public List<Orders> Orderss
        {
            get
            {
                if (_ChildOrders == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildOrders = IQApp.DB.Load<Orders>("select * from Orders where OrdSupp=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildOrders;
            }set {}
        }
        public int OrdersCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Orders where OrdSupp=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<ShipDoc> _ChildShipDoc;
        public List<ShipDoc> ShipDocs
        {
            get
            {
                if (_ChildShipDoc == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildShipDoc = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where SDSupp=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildShipDoc;
            }set {}
        }
        public int ShipDocCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from ShipDoc where SDSupp=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	        private List<UKOrder> _ChildUKOrder;
        public List<UKOrder> UKOrders
        {
            get
            {
                if (_ChildUKOrder == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildUKOrder = IQApp.DB.Load<UKOrder>("select * from UKOrder where UKOCust=@itm",new { itm= this.CustId.Value}).ToList();
				
                }
                return _ChildUKOrder;
            }set {}
        }
        public int UKOrderCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from UKOrder where UKOCust=@itm", new { itm= this.CustId.Value}));
            }
			set {}
        }
     
	
	public Customer () : base("Customer") {
		base.obj = this;
	
					CustSortCode = new Customer_CustSortCode(this);
					CustType = new Customer_CustType(this);
					CustVATNo = new Customer_CustVATNo(this);
					CustDANNo = new Customer_CustDANNo(this);
					CustBondCode = new Customer_CustBondCode(this);
					CustIntrastat = new Customer_CustIntrastat(this);
					CustCurr = new Customer_CustCurr(this);
					CustRates = new Customer_CustRates(this);
					CustGenNotes = new Customer_CustGenNotes(this);
					CustLang = new Customer_CustLang(this);
					CustSendStatus = new Customer_CustSendStatus(this);
					CustFTLNotes = new Customer_CustFTLNotes(this);
					CustOnFTrack = new Customer_CustOnFTrack(this);
					CustDelZone = new Customer_CustDelZone(this);
					CustCreatedBy = new Customer_CustCreatedBy(this);
					CustEM2 = new Customer_CustEM2(this);
					CustEM3 = new Customer_CustEM3(this);
					CustEM4 = new Customer_CustEM4(this);
					CustAADSys = new Customer_CustAADSys(this);
					CustGBWK = new Customer_CustGBWK(this);
					CustId = new Customer_CustId(this);
					CustName = new Customer_CustName(this);
					CustAddr = new Customer_CustAddr(this);
					CustAddr2 = new Customer_CustAddr2(this);
					CustAddr3 = new Customer_CustAddr3(this);
					CustTown = new Customer_CustTown(this);
					CustCounty = new Customer_CustCounty(this);
					CustPC = new Customer_CustPC(this);
					CustCtry = new Customer_CustCtry(this);
					CustPhone = new Customer_CustPhone(this);
					CustFax = new Customer_CustFax(this);
					CustEM = new Customer_CustEM(this);
					CustUserName = new Customer_CustUserName(this);
					CustPassword = new Customer_CustPassword(this);
					CustDueDiligence = new Customer_CustDueDiligence(this);
					CustCredScoreSearch = new Customer_CustCredScoreSearch(this);
					CustCredScore = new Customer_CustCredScore(this);
					CustCredScoreReview = new Customer_CustCredScoreReview(this);
					CustWebsite = new Customer_CustWebsite(this);
					CustRecDueDil = new Customer_CustRecDueDil(this);
					CustCrdChecked = new Customer_CustCrdChecked(this);
					CustCrdScr = new Customer_CustCrdScr(this);
					CustCrdRvDate = new Customer_CustCrdRvDate(this);
					CustAccContact = new Customer_CustAccContact(this);
					CustAccEmail = new Customer_CustAccEmail(this);
			}

	static Customer () {
					CustSortCodeField = new Customer_CustSortCodeFieldDef();
					CustTypeField = new Customer_CustTypeFieldDef();
					CustVATNoField = new Customer_CustVATNoFieldDef();
					CustDANNoField = new Customer_CustDANNoFieldDef();
					CustBondCodeField = new Customer_CustBondCodeFieldDef();
					CustIntrastatField = new Customer_CustIntrastatFieldDef();
					CustCurrField = new Customer_CustCurrFieldDef();
					CustRatesField = new Customer_CustRatesFieldDef();
					CustGenNotesField = new Customer_CustGenNotesFieldDef();
					CustLangField = new Customer_CustLangFieldDef();
					CustSendStatusField = new Customer_CustSendStatusFieldDef();
					CustFTLNotesField = new Customer_CustFTLNotesFieldDef();
					CustOnFTrackField = new Customer_CustOnFTrackFieldDef();
					CustDelZoneField = new Customer_CustDelZoneFieldDef();
					CustCreatedByField = new Customer_CustCreatedByFieldDef();
					CustEM2Field = new Customer_CustEM2FieldDef();
					CustEM3Field = new Customer_CustEM3FieldDef();
					CustEM4Field = new Customer_CustEM4FieldDef();
					CustAADSysField = new Customer_CustAADSysFieldDef();
					CustGBWKField = new Customer_CustGBWKFieldDef();
					CustIdField = new Customer_CustIdFieldDef();
					CustNameField = new Customer_CustNameFieldDef();
					CustAddrField = new Customer_CustAddrFieldDef();
					CustAddr2Field = new Customer_CustAddr2FieldDef();
					CustAddr3Field = new Customer_CustAddr3FieldDef();
					CustTownField = new Customer_CustTownFieldDef();
					CustCountyField = new Customer_CustCountyFieldDef();
					CustPCField = new Customer_CustPCFieldDef();
					CustCtryField = new Customer_CustCtryFieldDef();
					CustPhoneField = new Customer_CustPhoneFieldDef();
					CustFaxField = new Customer_CustFaxFieldDef();
					CustEMField = new Customer_CustEMFieldDef();
					CustUserNameField = new Customer_CustUserNameFieldDef();
					CustPasswordField = new Customer_CustPasswordFieldDef();
					CustDueDiligenceField = new Customer_CustDueDiligenceFieldDef();
					CustCredScoreSearchField = new Customer_CustCredScoreSearchFieldDef();
					CustCredScoreField = new Customer_CustCredScoreFieldDef();
					CustCredScoreReviewField = new Customer_CustCredScoreReviewFieldDef();
					CustWebsiteField = new Customer_CustWebsiteFieldDef();
					CustRecDueDilField = new Customer_CustRecDueDilFieldDef();
					CustCrdCheckedField = new Customer_CustCrdCheckedFieldDef();
					CustCrdScrField = new Customer_CustCrdScrFieldDef();
					CustCrdRvDateField = new Customer_CustCrdRvDateFieldDef();
					CustAccContactField = new Customer_CustAccContactFieldDef();
					CustAccEmailField = new Customer_CustAccEmailFieldDef();
			}

	public string RecordTitle { 
		get { return CustNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Customers"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Customer/Load/?RecId=" + RecordID.Value;
			}
			return "/Customer/Add";
			}
	}

			
		
		[Ignore()]
		public Customer_CustSortCode CustSortCode { get; set; }
		public static Customer_CustSortCodeFieldDef CustSortCodeField { get; private set; }
        
			
			[Column("CustSortCode")]
			public  string PopulateCustSortCode  {
				get { return CustSortCodeValue ;}
				set { CustSortCode.DataValue = value; }
			}

	
			public string CustSortCodeValue 
			{ 
				get 
				{
				   if(CustSortCode.Value != null) {
				   return CustSortCode.Value.ToString(); 					}
					return "";
                
				}
				set { CustSortCode.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustType CustType { get; set; }
		public static Customer_CustTypeFieldDef CustTypeField { get; private set; }
        
			
			[Column("CustType")]
			public  int PopulateCustType  {
				get { return CustTypeValue ;}
				set { CustType.DataValue = value; }
			}

	
			public int CustTypeValue 
			{ 
				get 
				{
				   if(CustType.Value != null) {
				   					int i = 0;
					if (CustType != null)
					{
						if (CustType.Value != null)
						{
							if (Int32.TryParse(CustType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustType.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustVATNo CustVATNo { get; set; }
		public static Customer_CustVATNoFieldDef CustVATNoField { get; private set; }
        
			
			[Column("CustVATNo")]
			public  string PopulateCustVATNo  {
				get { return CustVATNoValue ;}
				set { CustVATNo.DataValue = value; }
			}

	
			public string CustVATNoValue 
			{ 
				get 
				{
				   if(CustVATNo.Value != null) {
				   return CustVATNo.Value.ToString(); 					}
					return "";
                
				}
				set { CustVATNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustDANNo CustDANNo { get; set; }
		public static Customer_CustDANNoFieldDef CustDANNoField { get; private set; }
        
			
			[Column("CustDANNo")]
			public  string PopulateCustDANNo  {
				get { return CustDANNoValue ;}
				set { CustDANNo.DataValue = value; }
			}

	
			public string CustDANNoValue 
			{ 
				get 
				{
				   if(CustDANNo.Value != null) {
				   return CustDANNo.Value.ToString(); 					}
					return "";
                
				}
				set { CustDANNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustBondCode CustBondCode { get; set; }
		public static Customer_CustBondCodeFieldDef CustBondCodeField { get; private set; }
        
			
			[Column("CustBondCode")]
			public  string PopulateCustBondCode  {
				get { return CustBondCodeValue ;}
				set { CustBondCode.DataValue = value; }
			}

	
			public string CustBondCodeValue 
			{ 
				get 
				{
				   if(CustBondCode.Value != null) {
				   return CustBondCode.Value.ToString(); 					}
					return "";
                
				}
				set { CustBondCode.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustIntrastat CustIntrastat { get; set; }
		public static Customer_CustIntrastatFieldDef CustIntrastatField { get; private set; }
        
			
			[Column("CustIntrastat")]
			public  bool PopulateCustIntrastat  {
				get { return CustIntrastatValue ;}
				set { CustIntrastat.DataValue = value; }
			}

	
			public bool CustIntrastatValue 
			{ 
				get 
				{
				   if(CustIntrastat.Value != null) {
				   					bool i = false;
					if (CustIntrastat != null)
					{
						if (CustIntrastat.Value != null)
						{
							if (Boolean.TryParse(CustIntrastat.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustIntrastat.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCurr CustCurr { get; set; }
		public static Customer_CustCurrFieldDef CustCurrField { get; private set; }
        
			
			[Column("CustCurr")]
			public  int PopulateCustCurr  {
				get { return CustCurrValue ;}
				set { CustCurr.DataValue = value; }
			}

	
			public int CustCurrValue 
			{ 
				get 
				{
				   if(CustCurr.Value != null) {
				   					int i = 0;
					if (CustCurr != null)
					{
						if (CustCurr.Value != null)
						{
							if (Int32.TryParse(CustCurr.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustCurr.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustRates CustRates { get; set; }
		public static Customer_CustRatesFieldDef CustRatesField { get; private set; }
        
			
			[Column("CustRates")]
			public  string PopulateCustRates  {
				get { return CustRatesValue ;}
				set { CustRates.DataValue = value; }
			}

	
			public string CustRatesValue 
			{ 
				get 
				{
				   if(CustRates.Value != null) {
				   return CustRates.Value.ToString(); 					}
					return "";
                
				}
				set { CustRates.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustGenNotes CustGenNotes { get; set; }
		public static Customer_CustGenNotesFieldDef CustGenNotesField { get; private set; }
        
			
			[Column("CustGenNotes")]
			public  string PopulateCustGenNotes  {
				get { return CustGenNotesValue ;}
				set { CustGenNotes.DataValue = value; }
			}

	
			public string CustGenNotesValue 
			{ 
				get 
				{
				   if(CustGenNotes.Value != null) {
				   return CustGenNotes.Value.ToString(); 					}
					return "";
                
				}
				set { CustGenNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustLang CustLang { get; set; }
		public static Customer_CustLangFieldDef CustLangField { get; private set; }
        
			
			[Column("CustLang")]
			public  string PopulateCustLang  {
				get { return CustLangValue ;}
				set { CustLang.DataValue = value; }
			}

	
			public string CustLangValue 
			{ 
				get 
				{
				   if(CustLang.Value != null) {
				   return CustLang.Value.ToString(); 					}
					return "";
                
				}
				set { CustLang.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustSendStatus CustSendStatus { get; set; }
		public static Customer_CustSendStatusFieldDef CustSendStatusField { get; private set; }
        
			
			[Column("CustSendStatus")]
			public  bool PopulateCustSendStatus  {
				get { return CustSendStatusValue ;}
				set { CustSendStatus.DataValue = value; }
			}

	
			public bool CustSendStatusValue 
			{ 
				get 
				{
				   if(CustSendStatus.Value != null) {
				   					bool i = false;
					if (CustSendStatus != null)
					{
						if (CustSendStatus.Value != null)
						{
							if (Boolean.TryParse(CustSendStatus.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustSendStatus.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustFTLNotes CustFTLNotes { get; set; }
		public static Customer_CustFTLNotesFieldDef CustFTLNotesField { get; private set; }
        
			
			[Column("CustFTLNotes")]
			public  string PopulateCustFTLNotes  {
				get { return CustFTLNotesValue ;}
				set { CustFTLNotes.DataValue = value; }
			}

	
			public string CustFTLNotesValue 
			{ 
				get 
				{
				   if(CustFTLNotes.Value != null) {
				   return CustFTLNotes.Value.ToString(); 					}
					return "";
                
				}
				set { CustFTLNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustOnFTrack CustOnFTrack { get; set; }
		public static Customer_CustOnFTrackFieldDef CustOnFTrackField { get; private set; }
        
			
			[Column("CustOnFTrack")]
			public  bool PopulateCustOnFTrack  {
				get { return CustOnFTrackValue ;}
				set { CustOnFTrack.DataValue = value; }
			}

	
			public bool CustOnFTrackValue 
			{ 
				get 
				{
				   if(CustOnFTrack.Value != null) {
				   					bool i = false;
					if (CustOnFTrack != null)
					{
						if (CustOnFTrack.Value != null)
						{
							if (Boolean.TryParse(CustOnFTrack.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustOnFTrack.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustDelZone CustDelZone { get; set; }
		public static Customer_CustDelZoneFieldDef CustDelZoneField { get; private set; }
        
			
			[Column("CustDelZone")]
			public  int PopulateCustDelZone  {
				get { return CustDelZoneValue ;}
				set { CustDelZone.DataValue = value; }
			}

	
			public int CustDelZoneValue 
			{ 
				get 
				{
				   if(CustDelZone.Value != null) {
				   					int i = 0;
					if (CustDelZone != null)
					{
						if (CustDelZone.Value != null)
						{
							if (Int32.TryParse(CustDelZone.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustDelZone.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCreatedBy CustCreatedBy { get; set; }
		public static Customer_CustCreatedByFieldDef CustCreatedByField { get; private set; }
        
			
			[Column("CustCreatedBy")]
			public  int PopulateCustCreatedBy  {
				get { return CustCreatedByValue ;}
				set { CustCreatedBy.DataValue = value; }
			}

	
			public int CustCreatedByValue 
			{ 
				get 
				{
				   if(CustCreatedBy.Value != null) {
				   					int i = 0;
					if (CustCreatedBy != null)
					{
						if (CustCreatedBy.Value != null)
						{
							if (Int32.TryParse(CustCreatedBy.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustCreatedBy.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustEM2 CustEM2 { get; set; }
		public static Customer_CustEM2FieldDef CustEM2Field { get; private set; }
        
			
			[Column("CustEM2")]
			public  string PopulateCustEM2  {
				get { return CustEM2Value ;}
				set { CustEM2.DataValue = value; }
			}

	
			public string CustEM2Value 
			{ 
				get 
				{
				   if(CustEM2.Value != null) {
				   return CustEM2.Value.ToString(); 					}
					return "";
                
				}
				set { CustEM2.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustEM3 CustEM3 { get; set; }
		public static Customer_CustEM3FieldDef CustEM3Field { get; private set; }
        
			
			[Column("CustEM3")]
			public  string PopulateCustEM3  {
				get { return CustEM3Value ;}
				set { CustEM3.DataValue = value; }
			}

	
			public string CustEM3Value 
			{ 
				get 
				{
				   if(CustEM3.Value != null) {
				   return CustEM3.Value.ToString(); 					}
					return "";
                
				}
				set { CustEM3.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustEM4 CustEM4 { get; set; }
		public static Customer_CustEM4FieldDef CustEM4Field { get; private set; }
        
			
			[Column("CustEM4")]
			public  string PopulateCustEM4  {
				get { return CustEM4Value ;}
				set { CustEM4.DataValue = value; }
			}

	
			public string CustEM4Value 
			{ 
				get 
				{
				   if(CustEM4.Value != null) {
				   return CustEM4.Value.ToString(); 					}
					return "";
                
				}
				set { CustEM4.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustAADSys CustAADSys { get; set; }
		public static Customer_CustAADSysFieldDef CustAADSysField { get; private set; }
        
			
			[Column("CustAADSys")]
			public  int PopulateCustAADSys  {
				get { return CustAADSysValue ;}
				set { CustAADSys.DataValue = value; }
			}

	
			public int CustAADSysValue 
			{ 
				get 
				{
				   if(CustAADSys.Value != null) {
				   					int i = 0;
					if (CustAADSys != null)
					{
						if (CustAADSys.Value != null)
						{
							if (Int32.TryParse(CustAADSys.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustAADSys.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustGBWK CustGBWK { get; set; }
		public static Customer_CustGBWKFieldDef CustGBWKField { get; private set; }
        
			
			[Column("CustGBWK")]
			public  string PopulateCustGBWK  {
				get { return CustGBWKValue ;}
				set { CustGBWK.DataValue = value; }
			}

	
			public string CustGBWKValue 
			{ 
				get 
				{
				   if(CustGBWK.Value != null) {
				   return CustGBWK.Value.ToString(); 					}
					return "";
                
				}
				set { CustGBWK.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustId CustId { get; set; }
		public static Customer_CustIdFieldDef CustIdField { get; private set; }
        
			
			[Column("CustId")]
			public  int PopulateCustId  {
				get { return CustIdValue ;}
				set { CustId.DataValue = value; }
			}

	
			public int CustIdValue 
			{ 
				get 
				{
				   if(CustId.Value != null) {
				   					int i = 0;
					if (CustId != null)
					{
						if (CustId.Value != null)
						{
							if (Int32.TryParse(CustId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustId.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustName CustName { get; set; }
		public static Customer_CustNameFieldDef CustNameField { get; private set; }
        
			
			[Column("CustName")]
			public  string PopulateCustName  {
				get { return CustNameValue ;}
				set { CustName.DataValue = value; }
			}

	
			public string CustNameValue 
			{ 
				get 
				{
				   if(CustName.Value != null) {
				   return CustName.Value.ToString(); 					}
					return "";
                
				}
				set { CustName.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustAddr CustAddr { get; set; }
		public static Customer_CustAddrFieldDef CustAddrField { get; private set; }
        
			
			[Column("CustAddr")]
			public  string PopulateCustAddr  {
				get { return CustAddrValue ;}
				set { CustAddr.DataValue = value; }
			}

	
			public string CustAddrValue 
			{ 
				get 
				{
				   if(CustAddr.Value != null) {
				   return CustAddr.Value.ToString(); 					}
					return "";
                
				}
				set { CustAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustAddr2 CustAddr2 { get; set; }
		public static Customer_CustAddr2FieldDef CustAddr2Field { get; private set; }
        
			
			[Column("CustAddr2")]
			public  string PopulateCustAddr2  {
				get { return CustAddr2Value ;}
				set { CustAddr2.DataValue = value; }
			}

	
			public string CustAddr2Value 
			{ 
				get 
				{
				   if(CustAddr2.Value != null) {
				   return CustAddr2.Value.ToString(); 					}
					return "";
                
				}
				set { CustAddr2.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustAddr3 CustAddr3 { get; set; }
		public static Customer_CustAddr3FieldDef CustAddr3Field { get; private set; }
        
			
			[Column("CustAddr3")]
			public  string PopulateCustAddr3  {
				get { return CustAddr3Value ;}
				set { CustAddr3.DataValue = value; }
			}

	
			public string CustAddr3Value 
			{ 
				get 
				{
				   if(CustAddr3.Value != null) {
				   return CustAddr3.Value.ToString(); 					}
					return "";
                
				}
				set { CustAddr3.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustTown CustTown { get; set; }
		public static Customer_CustTownFieldDef CustTownField { get; private set; }
        
			
			[Column("CustTown")]
			public  string PopulateCustTown  {
				get { return CustTownValue ;}
				set { CustTown.DataValue = value; }
			}

	
			public string CustTownValue 
			{ 
				get 
				{
				   if(CustTown.Value != null) {
				   return CustTown.Value.ToString(); 					}
					return "";
                
				}
				set { CustTown.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCounty CustCounty { get; set; }
		public static Customer_CustCountyFieldDef CustCountyField { get; private set; }
        
			
			[Column("CustCounty")]
			public  string PopulateCustCounty  {
				get { return CustCountyValue ;}
				set { CustCounty.DataValue = value; }
			}

	
			public string CustCountyValue 
			{ 
				get 
				{
				   if(CustCounty.Value != null) {
				   return CustCounty.Value.ToString(); 					}
					return "";
                
				}
				set { CustCounty.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustPC CustPC { get; set; }
		public static Customer_CustPCFieldDef CustPCField { get; private set; }
        
			
			[Column("CustPC")]
			public  string PopulateCustPC  {
				get { return CustPCValue ;}
				set { CustPC.DataValue = value; }
			}

	
			public string CustPCValue 
			{ 
				get 
				{
				   if(CustPC.Value != null) {
				   return CustPC.Value.ToString(); 					}
					return "";
                
				}
				set { CustPC.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCtry CustCtry { get; set; }
		public static Customer_CustCtryFieldDef CustCtryField { get; private set; }
        
			
			[Column("CustCtry")]
			public  int PopulateCustCtry  {
				get { return CustCtryValue ;}
				set { CustCtry.DataValue = value; }
			}

	
			public int CustCtryValue 
			{ 
				get 
				{
				   if(CustCtry.Value != null) {
				   					int i = 0;
					if (CustCtry != null)
					{
						if (CustCtry.Value != null)
						{
							if (Int32.TryParse(CustCtry.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustCtry.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustPhone CustPhone { get; set; }
		public static Customer_CustPhoneFieldDef CustPhoneField { get; private set; }
        
			
			[Column("CustPhone")]
			public  string PopulateCustPhone  {
				get { return CustPhoneValue ;}
				set { CustPhone.DataValue = value; }
			}

	
			public string CustPhoneValue 
			{ 
				get 
				{
				   if(CustPhone.Value != null) {
				   return CustPhone.Value.ToString(); 					}
					return "";
                
				}
				set { CustPhone.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustFax CustFax { get; set; }
		public static Customer_CustFaxFieldDef CustFaxField { get; private set; }
        
			
			[Column("CustFax")]
			public  string PopulateCustFax  {
				get { return CustFaxValue ;}
				set { CustFax.DataValue = value; }
			}

	
			public string CustFaxValue 
			{ 
				get 
				{
				   if(CustFax.Value != null) {
				   return CustFax.Value.ToString(); 					}
					return "";
                
				}
				set { CustFax.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustEM CustEM { get; set; }
		public static Customer_CustEMFieldDef CustEMField { get; private set; }
        
			
			[Column("CustEM")]
			public  string PopulateCustEM  {
				get { return CustEMValue ;}
				set { CustEM.DataValue = value; }
			}

	
			public string CustEMValue 
			{ 
				get 
				{
				   if(CustEM.Value != null) {
				   return CustEM.Value.ToString(); 					}
					return "";
                
				}
				set { CustEM.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustUserName CustUserName { get; set; }
		public static Customer_CustUserNameFieldDef CustUserNameField { get; private set; }
        
			
			[Column("CustUserName")]
			public  string PopulateCustUserName  {
				get { return CustUserNameValue ;}
				set { CustUserName.DataValue = value; }
			}

	
			public string CustUserNameValue 
			{ 
				get 
				{
				   if(CustUserName.Value != null) {
				   return CustUserName.Value.ToString(); 					}
					return "";
                
				}
				set { CustUserName.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustPassword CustPassword { get; set; }
		public static Customer_CustPasswordFieldDef CustPasswordField { get; private set; }
        
			
			[Column("CustPassword")]
			public  string PopulateCustPassword  {
				get { return CustPasswordValue ;}
				set { CustPassword.DataValue = value; }
			}

	
			public string CustPasswordValue 
			{ 
				get 
				{
				   if(CustPassword.Value != null) {
				   return CustPassword.Value.ToString(); 					}
					return "";
                
				}
				set { CustPassword.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustDueDiligence CustDueDiligence { get; set; }
		public static Customer_CustDueDiligenceFieldDef CustDueDiligenceField { get; private set; }
        
			
			[Column("CustDueDiligence")]
			public  bool PopulateCustDueDiligence  {
				get { return CustDueDiligenceValue ;}
				set { CustDueDiligence.DataValue = value; }
			}

	
			public bool CustDueDiligenceValue 
			{ 
				get 
				{
				   if(CustDueDiligence.Value != null) {
				   					bool i = false;
					if (CustDueDiligence != null)
					{
						if (CustDueDiligence.Value != null)
						{
							if (Boolean.TryParse(CustDueDiligence.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustDueDiligence.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCredScoreSearch CustCredScoreSearch { get; set; }
		public static Customer_CustCredScoreSearchFieldDef CustCredScoreSearchField { get; private set; }
        
			
			[Column("CustCredScoreSearch")]
			public  bool PopulateCustCredScoreSearch  {
				get { return CustCredScoreSearchValue ;}
				set { CustCredScoreSearch.DataValue = value; }
			}

	
			public bool CustCredScoreSearchValue 
			{ 
				get 
				{
				   if(CustCredScoreSearch.Value != null) {
				   					bool i = false;
					if (CustCredScoreSearch != null)
					{
						if (CustCredScoreSearch.Value != null)
						{
							if (Boolean.TryParse(CustCredScoreSearch.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustCredScoreSearch.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCredScore CustCredScore { get; set; }
		public static Customer_CustCredScoreFieldDef CustCredScoreField { get; private set; }
        
			
			[Column("CustCredScore")]
			public  int PopulateCustCredScore  {
				get { return CustCredScoreValue ;}
				set { CustCredScore.DataValue = value; }
			}

	
			public int CustCredScoreValue 
			{ 
				get 
				{
				   if(CustCredScore.Value != null) {
				   					int i = 0;
					if (CustCredScore != null)
					{
						if (CustCredScore.Value != null)
						{
							if (Int32.TryParse(CustCredScore.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CustCredScore.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCredScoreReview CustCredScoreReview { get; set; }
		public static Customer_CustCredScoreReviewFieldDef CustCredScoreReviewField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("CustCredScoreReview")]
			public  DateTime PopulateCustCredScoreReview  {
				get { return CustCredScoreReviewValue ;}
				set { CustCredScoreReview.DataValue = value; }
			}

	
			public DateTime CustCredScoreReviewValue 
			{ 
				get 
				{
				   if(CustCredScoreReview.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (CustCredScoreReview != null)
					{
						if (CustCredScoreReview.Value != null)
						{
							if (DateTime.TryParse(CustCredScoreReview.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { CustCredScoreReview.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustWebsite CustWebsite { get; set; }
		public static Customer_CustWebsiteFieldDef CustWebsiteField { get; private set; }
        
			
			[Column("CustWebsite")]
			public  string PopulateCustWebsite  {
				get { return CustWebsiteValue ;}
				set { CustWebsite.DataValue = value; }
			}

	
			public string CustWebsiteValue 
			{ 
				get 
				{
				   if(CustWebsite.Value != null) {
				   return CustWebsite.Value.ToString(); 					}
					return "";
                
				}
				set { CustWebsite.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustRecDueDil CustRecDueDil { get; set; }
		public static Customer_CustRecDueDilFieldDef CustRecDueDilField { get; private set; }
        
			
			[Column("CustRecDueDil")]
			public  bool PopulateCustRecDueDil  {
				get { return CustRecDueDilValue ;}
				set { CustRecDueDil.DataValue = value; }
			}

	
			public bool CustRecDueDilValue 
			{ 
				get 
				{
				   if(CustRecDueDil.Value != null) {
				   					bool i = false;
					if (CustRecDueDil != null)
					{
						if (CustRecDueDil.Value != null)
						{
							if (Boolean.TryParse(CustRecDueDil.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustRecDueDil.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCrdChecked CustCrdChecked { get; set; }
		public static Customer_CustCrdCheckedFieldDef CustCrdCheckedField { get; private set; }
        
			
			[Column("CustCrdChecked")]
			public  bool PopulateCustCrdChecked  {
				get { return CustCrdCheckedValue ;}
				set { CustCrdChecked.DataValue = value; }
			}

	
			public bool CustCrdCheckedValue 
			{ 
				get 
				{
				   if(CustCrdChecked.Value != null) {
				   					bool i = false;
					if (CustCrdChecked != null)
					{
						if (CustCrdChecked.Value != null)
						{
							if (Boolean.TryParse(CustCrdChecked.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CustCrdChecked.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCrdScr CustCrdScr { get; set; }
		public static Customer_CustCrdScrFieldDef CustCrdScrField { get; private set; }
        
			
			[Column("CustCrdScr")]
			public  string PopulateCustCrdScr  {
				get { return CustCrdScrValue ;}
				set { CustCrdScr.DataValue = value; }
			}

	
			public string CustCrdScrValue 
			{ 
				get 
				{
				   if(CustCrdScr.Value != null) {
				   return CustCrdScr.Value.ToString(); 					}
					return "";
                
				}
				set { CustCrdScr.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustCrdRvDate CustCrdRvDate { get; set; }
		public static Customer_CustCrdRvDateFieldDef CustCrdRvDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("CustCrdRvDate")]
			public  DateTime PopulateCustCrdRvDate  {
				get { return CustCrdRvDateValue ;}
				set { CustCrdRvDate.DataValue = value; }
			}

	
			public DateTime CustCrdRvDateValue 
			{ 
				get 
				{
				   if(CustCrdRvDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (CustCrdRvDate != null)
					{
						if (CustCrdRvDate.Value != null)
						{
							if (DateTime.TryParse(CustCrdRvDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { CustCrdRvDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustAccContact CustAccContact { get; set; }
		public static Customer_CustAccContactFieldDef CustAccContactField { get; private set; }
        
			
			[Column("CustAccContact")]
			public  string PopulateCustAccContact  {
				get { return CustAccContactValue ;}
				set { CustAccContact.DataValue = value; }
			}

	
			public string CustAccContactValue 
			{ 
				get 
				{
				   if(CustAccContact.Value != null) {
				   return CustAccContact.Value.ToString(); 					}
					return "";
                
				}
				set { CustAccContact.Value = value;  }
			}
			
		
		[Ignore()]
		public Customer_CustAccEmail CustAccEmail { get; set; }
		public static Customer_CustAccEmailFieldDef CustAccEmailField { get; private set; }
        
			
			[Column("CustAccEmail")]
			public  string PopulateCustAccEmail  {
				get { return CustAccEmailValue ;}
				set { CustAccEmail.DataValue = value; }
			}

	
			public string CustAccEmailValue 
			{ 
				get 
				{
				   if(CustAccEmail.Value != null) {
				   return CustAccEmail.Value.ToString(); 					}
					return "";
                
				}
				set { CustAccEmail.Value = value;  }
			}
	}


public class Customer_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 33;
    public int PixelHeight => 0;
	public string Title => "Customers";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
