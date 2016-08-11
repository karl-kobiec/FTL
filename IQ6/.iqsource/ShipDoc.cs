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


public partial class ShipDocController : DSBaseController<ShipDoc/*,ShipDocSearch*/> {
	public ShipDocController() : base ((IDatabase)IQApp.DB, new ShipDocRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select SDId from ShipDoc where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<ShipDoc>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(ShipDoc data) {
						IQApp.DB.Execute("Delete from ShipDoc where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.SDIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from ShipDoc " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from ShipDoc " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from ShipDoc " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/ShipDoc_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<ShipDoc>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<ShipDoc>("select * from ShipDoc  ").ToList();
		string urlpath = "/temp/Shipping Documents Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Shipping Documents");
				
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
							
					worksheet.Column(1).Width = 13;
					worksheet.Cells[1, 1].Value = "Document ID";
						
								
					worksheet.Column(2).Width = 27;
					worksheet.Cells[1, 2].Value = "Supplier Name";
						
								
					worksheet.Column(3).Width = 27;
					worksheet.Cells[1, 3].Value = "Recipient Name";
						
								
					worksheet.Column(4).Width = 20;
					worksheet.Cells[1, 4].Value = "Currency";
						
								
					worksheet.Column(5).Width = 13;
					worksheet.Cells[1, 5].Value = "Show HMRC details";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].SDId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].SDSupp.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].SDRecip.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].SDCurr.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].SDHMRCDets.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDId" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDId(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDId" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDSuppId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDSuppIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppId" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDSuppId(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppId" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDSupp(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDSuppValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSupp" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSupp")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSDSupp(ShipDoc m, int? id, string q) {

		
		string s = m.SDSupp.DataSource;
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
	public ActionResult CallbackSDSupp(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSupp" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSupp")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDSuppAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDSuppAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppAddr" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppAddr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDSuppAddr(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppAddr" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppAddr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDSuppVATNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDSuppVATNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppVATNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppVATNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDSuppVATNo(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppVATNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSuppVATNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDTransRef(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDTransRefValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDTransRef" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDTransRef")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDTransRef(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDTransRef" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDTransRef")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDCompAuth(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDCompAuthValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCompAuth" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCompAuth")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDCompAuth(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCompAuth" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCompAuth")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDRecipId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDRecipIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipId" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDRecipId(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipId" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDRecip(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDRecipValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecip" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecip")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSDRecip(ShipDoc m, int? id, string q) {

		
		string s = m.SDRecip.DataSource;
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
	public ActionResult CallbackSDRecip(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecip" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecip")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDRecipAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDRecipAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipAddr" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipAddr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDRecipAddr(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipAddr" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipAddr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDRecipVATNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDRecipVATNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipVATNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipVATNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDRecipVATNo(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipVATNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecipVATNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDRefNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDRefNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRefNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRefNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDRefNo(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRefNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRefNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDDeclareDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDDeclareDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDeclareDate" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDeclareDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDDeclareDate(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDeclareDate" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDeclareDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDDelPlace(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDDelPlaceValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDelPlace" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDelPlace")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDDelPlace(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDelPlace" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDelPlace")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDDesc(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDCommCode1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDCommCode1Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDCommCode1(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDQty1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDQty1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDQty1(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDGWeight1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDGWeight1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDGWeight1(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDNWeight1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDNWeight1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDNWeight1(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDValue1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDValue1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDValue1(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue1" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDDesc2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDDesc2Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDDesc2(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDCommCode2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDCommCode2Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDCommCode2(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDQty2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDQty2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDQty2(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDGWeight2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDGWeight2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDGWeight2(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDNWeight2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDNWeight2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDNWeight2(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDValue2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDValue2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDValue2(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue2" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDDesc3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDDesc3Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDDesc3(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDCommCode3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDCommCode3Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDCommCode3(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDQty3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDQty3Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDQty3(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDGWeight3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDGWeight3Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDGWeight3(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDNWeight3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDNWeight3Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDNWeight3(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDValue3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDValue3Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDValue3(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue3" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDDesc4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDDesc4Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDDesc4(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDDesc4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDCommCode4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDCommCode4Value =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDCommCode4(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCommCode4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDQty4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDQty4Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDQty4(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDQty4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDGWeight4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDGWeight4Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDGWeight4(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDGWeight4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDNWeight4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDNWeight4Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDNWeight4(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDNWeight4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDValue4(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDValue4Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue4")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDValue4(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue4" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDValue4")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDRecordControl(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDRecordControlValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecordControl" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecordControl")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDRecordControl(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecordControl" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDRecordControl")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDSignedBy(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDSignedByValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedBy" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedBy")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSDSignedBy(ShipDoc m, int? id, string q) {

		
		string s = m.SDSignedBy.DataSource;
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
	public ActionResult CallbackSDSignedBy(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedBy" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedBy")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDSignedByText(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDSignedByTextValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedByText" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedByText")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDSignedByText(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedByText" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDSignedByText")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDVehNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SDVehNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDVehNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDVehNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDVehNo(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDVehNo" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDVehNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDCurr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SDCurrValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCurr" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCurr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSDCurr(ShipDoc m, int? id, string q) {

		
		string s = m.SDCurr.DataSource;
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
	public ActionResult CallbackSDCurr(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCurr" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDCurr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSDHMRCDets(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ShipDoc>("select * from ShipDoc where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SDHMRCDetsValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDHMRCDets" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDHMRCDets")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSDHMRCDets(ShipDoc obj) {
			
		if(DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDHMRCDets" ).Any()) {
			foreach(var itm in DS.GetManager<ShipDoc>().OnChange.Where(f=> f.Key == "SDHMRCDets")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ShipDoc>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=30 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/ShipDoc/Search/" + FirstSearch);
		
		return Redirect("/ShipDoc/List/");
	}

}

public partial class ShipDocRepository : DSRepository<ShipDoc> {
	public ShipDocRepository() : base(30, "ShipDoc", "Shipping Documents") {
	}
}
public partial class ShipDoc 
: DatasetBase<ShipDoc>, IDSBase

  {
	  public int KeyValue => SDIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "SDId":
			return SDIdField;
				case "SDSuppId":
			return SDSuppIdField;
				case "SDSupp":
			return SDSuppField;
				case "SDSuppAddr":
			return SDSuppAddrField;
				case "SDSuppVATNo":
			return SDSuppVATNoField;
				case "SDTransRef":
			return SDTransRefField;
				case "SDCompAuth":
			return SDCompAuthField;
				case "SDRecipId":
			return SDRecipIdField;
				case "SDRecip":
			return SDRecipField;
				case "SDRecipAddr":
			return SDRecipAddrField;
				case "SDRecipVATNo":
			return SDRecipVATNoField;
				case "SDRefNo":
			return SDRefNoField;
				case "SDDeclareDate":
			return SDDeclareDateField;
				case "SDDelPlace":
			return SDDelPlaceField;
				case "SDDesc":
			return SDDescField;
				case "SDCommCode1":
			return SDCommCode1Field;
				case "SDQty1":
			return SDQty1Field;
				case "SDGWeight1":
			return SDGWeight1Field;
				case "SDNWeight1":
			return SDNWeight1Field;
				case "SDValue1":
			return SDValue1Field;
				case "SDDesc2":
			return SDDesc2Field;
				case "SDCommCode2":
			return SDCommCode2Field;
				case "SDQty2":
			return SDQty2Field;
				case "SDGWeight2":
			return SDGWeight2Field;
				case "SDNWeight2":
			return SDNWeight2Field;
				case "SDValue2":
			return SDValue2Field;
				case "SDDesc3":
			return SDDesc3Field;
				case "SDCommCode3":
			return SDCommCode3Field;
				case "SDQty3":
			return SDQty3Field;
				case "SDGWeight3":
			return SDGWeight3Field;
				case "SDNWeight3":
			return SDNWeight3Field;
				case "SDValue3":
			return SDValue3Field;
				case "SDDesc4":
			return SDDesc4Field;
				case "SDCommCode4":
			return SDCommCode4Field;
				case "SDQty4":
			return SDQty4Field;
				case "SDGWeight4":
			return SDGWeight4Field;
				case "SDNWeight4":
			return SDNWeight4Field;
				case "SDValue4":
			return SDValue4Field;
				case "SDRecordControl":
			return SDRecordControlField;
				case "SDSignedBy":
			return SDSignedByField;
				case "SDSignedByText":
			return SDSignedByTextField;
				case "SDVehNo":
			return SDVehNoField;
				case "SDCurr":
			return SDCurrField;
				case "SDHMRCDets":
			return SDHMRCDetsField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(SDId,SDIdField);
				action(SDSuppId,SDSuppIdField);
				action(SDSupp,SDSuppField);
				action(SDSuppAddr,SDSuppAddrField);
				action(SDSuppVATNo,SDSuppVATNoField);
				action(SDTransRef,SDTransRefField);
				action(SDCompAuth,SDCompAuthField);
				action(SDRecipId,SDRecipIdField);
				action(SDRecip,SDRecipField);
				action(SDRecipAddr,SDRecipAddrField);
				action(SDRecipVATNo,SDRecipVATNoField);
				action(SDRefNo,SDRefNoField);
				action(SDDeclareDate,SDDeclareDateField);
				action(SDDelPlace,SDDelPlaceField);
				action(SDDesc,SDDescField);
				action(SDCommCode1,SDCommCode1Field);
				action(SDQty1,SDQty1Field);
				action(SDGWeight1,SDGWeight1Field);
				action(SDNWeight1,SDNWeight1Field);
				action(SDValue1,SDValue1Field);
				action(SDDesc2,SDDesc2Field);
				action(SDCommCode2,SDCommCode2Field);
				action(SDQty2,SDQty2Field);
				action(SDGWeight2,SDGWeight2Field);
				action(SDNWeight2,SDNWeight2Field);
				action(SDValue2,SDValue2Field);
				action(SDDesc3,SDDesc3Field);
				action(SDCommCode3,SDCommCode3Field);
				action(SDQty3,SDQty3Field);
				action(SDGWeight3,SDGWeight3Field);
				action(SDNWeight3,SDNWeight3Field);
				action(SDValue3,SDValue3Field);
				action(SDDesc4,SDDesc4Field);
				action(SDCommCode4,SDCommCode4Field);
				action(SDQty4,SDQty4Field);
				action(SDGWeight4,SDGWeight4Field);
				action(SDNWeight4,SDNWeight4Field);
				action(SDValue4,SDValue4Field);
				action(SDRecordControl,SDRecordControlField);
				action(SDSignedBy,SDSignedByField);
				action(SDSignedByText,SDSignedByTextField);
				action(SDVehNo,SDVehNoField);
				action(SDCurr,SDCurrField);
				action(SDHMRCDets,SDHMRCDetsField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				SDId.Visible=false;SDSuppId.Visible=false;SDSupp.Visible=false;SDSuppAddr.Visible=false;SDSuppVATNo.Visible=false;SDTransRef.Visible=false;SDCompAuth.Visible=false;SDRecipId.Visible=false;SDRecip.Visible=false;SDRecipAddr.Visible=false;SDRecipVATNo.Visible=false;SDRefNo.Visible=false;SDDeclareDate.Visible=false;SDDelPlace.Visible=false;SDDesc.Visible=false;SDCommCode1.Visible=false;SDQty1.Visible=false;SDGWeight1.Visible=false;SDNWeight1.Visible=false;SDValue1.Visible=false;SDDesc2.Visible=false;SDCommCode2.Visible=false;SDQty2.Visible=false;SDGWeight2.Visible=false;SDNWeight2.Visible=false;SDValue2.Visible=false;SDDesc3.Visible=false;SDCommCode3.Visible=false;SDQty3.Visible=false;SDGWeight3.Visible=false;SDNWeight3.Visible=false;SDValue3.Visible=false;SDDesc4.Visible=false;SDCommCode4.Visible=false;SDQty4.Visible=false;SDGWeight4.Visible=false;SDNWeight4.Visible=false;SDValue4.Visible=false;SDRecordControl.Visible=false;SDSignedBy.Visible=false;SDSignedByText.Visible=false;SDVehNo.Visible=false;SDCurr.Visible=false;SDHMRCDets.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update ShipDoc set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (SDId.HasChanged && SDId.HasValue) {
					SQL += ", SDId=@SDIdValue";

				}
								if (SDSuppId.HasChanged && SDSuppId.HasValue) {
					SQL += ", SDSuppId=@SDSuppIdValue";

				}
								if (SDSupp.HasChanged && SDSupp.HasValue) {
					SQL += ", SDSupp=@SDSuppValue";

				}
								if (SDSuppAddr.HasChanged && SDSuppAddr.HasValue) {
					SQL += ", SDSuppAddr=@SDSuppAddrValue";

				}
								if (SDSuppVATNo.HasChanged && SDSuppVATNo.HasValue) {
					SQL += ", SDSuppVATNo=@SDSuppVATNoValue";

				}
								if (SDTransRef.HasChanged && SDTransRef.HasValue) {
					SQL += ", SDTransRef=@SDTransRefValue";

				}
								if (SDCompAuth.HasChanged && SDCompAuth.HasValue) {
					SQL += ", SDCompAuth=@SDCompAuthValue";

				}
								if (SDRecipId.HasChanged && SDRecipId.HasValue) {
					SQL += ", SDRecipId=@SDRecipIdValue";

				}
								if (SDRecip.HasChanged && SDRecip.HasValue) {
					SQL += ", SDRecip=@SDRecipValue";

				}
								if (SDRecipAddr.HasChanged && SDRecipAddr.HasValue) {
					SQL += ", SDRecipAddr=@SDRecipAddrValue";

				}
								if (SDRecipVATNo.HasChanged && SDRecipVATNo.HasValue) {
					SQL += ", SDRecipVATNo=@SDRecipVATNoValue";

				}
								if (SDRefNo.HasChanged && SDRefNo.HasValue) {
					SQL += ", SDRefNo=@SDRefNoValue";

				}
								if (SDDeclareDate.HasChanged && SDDeclareDate.HasValue) {
					SQL += ", SDDeclareDate=@SDDeclareDateValue";

				}
								if (SDDelPlace.HasChanged && SDDelPlace.HasValue) {
					SQL += ", SDDelPlace=@SDDelPlaceValue";

				}
								if (SDDesc.HasChanged && SDDesc.HasValue) {
					SQL += ", SDDesc=@SDDescValue";

				}
								if (SDCommCode1.HasChanged && SDCommCode1.HasValue) {
					SQL += ", SDCommCode1=@SDCommCode1Value";

				}
								if (SDQty1.HasChanged && SDQty1.HasValue) {
					SQL += ", SDQty1=@SDQty1Value";

				}
								if (SDGWeight1.HasChanged && SDGWeight1.HasValue) {
					SQL += ", SDGWeight1=@SDGWeight1Value";

				}
								if (SDNWeight1.HasChanged && SDNWeight1.HasValue) {
					SQL += ", SDNWeight1=@SDNWeight1Value";

				}
								if (SDValue1.HasChanged && SDValue1.HasValue) {
					SQL += ", SDValue1=@SDValue1Value";

				}
								if (SDDesc2.HasChanged && SDDesc2.HasValue) {
					SQL += ", SDDesc2=@SDDesc2Value";

				}
								if (SDCommCode2.HasChanged && SDCommCode2.HasValue) {
					SQL += ", SDCommCode2=@SDCommCode2Value";

				}
								if (SDQty2.HasChanged && SDQty2.HasValue) {
					SQL += ", SDQty2=@SDQty2Value";

				}
								if (SDGWeight2.HasChanged && SDGWeight2.HasValue) {
					SQL += ", SDGWeight2=@SDGWeight2Value";

				}
								if (SDNWeight2.HasChanged && SDNWeight2.HasValue) {
					SQL += ", SDNWeight2=@SDNWeight2Value";

				}
								if (SDValue2.HasChanged && SDValue2.HasValue) {
					SQL += ", SDValue2=@SDValue2Value";

				}
								if (SDDesc3.HasChanged && SDDesc3.HasValue) {
					SQL += ", SDDesc3=@SDDesc3Value";

				}
								if (SDCommCode3.HasChanged && SDCommCode3.HasValue) {
					SQL += ", SDCommCode3=@SDCommCode3Value";

				}
								if (SDQty3.HasChanged && SDQty3.HasValue) {
					SQL += ", SDQty3=@SDQty3Value";

				}
								if (SDGWeight3.HasChanged && SDGWeight3.HasValue) {
					SQL += ", SDGWeight3=@SDGWeight3Value";

				}
								if (SDNWeight3.HasChanged && SDNWeight3.HasValue) {
					SQL += ", SDNWeight3=@SDNWeight3Value";

				}
								if (SDValue3.HasChanged && SDValue3.HasValue) {
					SQL += ", SDValue3=@SDValue3Value";

				}
								if (SDDesc4.HasChanged && SDDesc4.HasValue) {
					SQL += ", SDDesc4=@SDDesc4Value";

				}
								if (SDCommCode4.HasChanged && SDCommCode4.HasValue) {
					SQL += ", SDCommCode4=@SDCommCode4Value";

				}
								if (SDQty4.HasChanged && SDQty4.HasValue) {
					SQL += ", SDQty4=@SDQty4Value";

				}
								if (SDGWeight4.HasChanged && SDGWeight4.HasValue) {
					SQL += ", SDGWeight4=@SDGWeight4Value";

				}
								if (SDNWeight4.HasChanged && SDNWeight4.HasValue) {
					SQL += ", SDNWeight4=@SDNWeight4Value";

				}
								if (SDValue4.HasChanged && SDValue4.HasValue) {
					SQL += ", SDValue4=@SDValue4Value";

				}
								if (SDRecordControl.HasChanged && SDRecordControl.HasValue) {
					SQL += ", SDRecordControl=@SDRecordControlValue";

				}
								if (SDSignedBy.HasChanged && SDSignedBy.HasValue) {
					SQL += ", SDSignedBy=@SDSignedByValue";

				}
								if (SDSignedByText.HasChanged && SDSignedByText.HasValue) {
					SQL += ", SDSignedByText=@SDSignedByTextValue";

				}
								if (SDVehNo.HasChanged && SDVehNo.HasValue) {
					SQL += ", SDVehNo=@SDVehNoValue";

				}
								if (SDCurr.HasChanged && SDCurr.HasValue) {
					SQL += ", SDCurr=@SDCurrValue";

				}
								if (SDHMRCDets.HasChanged && SDHMRCDets.HasValue) {
					SQL += ", SDHMRCDets=@SDHMRCDetsValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									SDId.HasChanged = false;
									SDSuppId.HasChanged = false;
									SDSupp.HasChanged = false;
									SDSuppAddr.HasChanged = false;
									SDSuppVATNo.HasChanged = false;
									SDTransRef.HasChanged = false;
									SDCompAuth.HasChanged = false;
									SDRecipId.HasChanged = false;
									SDRecip.HasChanged = false;
									SDRecipAddr.HasChanged = false;
									SDRecipVATNo.HasChanged = false;
									SDRefNo.HasChanged = false;
									SDDeclareDate.HasChanged = false;
									SDDelPlace.HasChanged = false;
									SDDesc.HasChanged = false;
									SDCommCode1.HasChanged = false;
									SDQty1.HasChanged = false;
									SDGWeight1.HasChanged = false;
									SDNWeight1.HasChanged = false;
									SDValue1.HasChanged = false;
									SDDesc2.HasChanged = false;
									SDCommCode2.HasChanged = false;
									SDQty2.HasChanged = false;
									SDGWeight2.HasChanged = false;
									SDNWeight2.HasChanged = false;
									SDValue2.HasChanged = false;
									SDDesc3.HasChanged = false;
									SDCommCode3.HasChanged = false;
									SDQty3.HasChanged = false;
									SDGWeight3.HasChanged = false;
									SDNWeight3.HasChanged = false;
									SDValue3.HasChanged = false;
									SDDesc4.HasChanged = false;
									SDCommCode4.HasChanged = false;
									SDQty4.HasChanged = false;
									SDGWeight4.HasChanged = false;
									SDNWeight4.HasChanged = false;
									SDValue4.HasChanged = false;
									SDRecordControl.HasChanged = false;
									SDSignedBy.HasChanged = false;
									SDSignedByText.HasChanged = false;
									SDVehNo.HasChanged = false;
									SDCurr.HasChanged = false;
									SDHMRCDets.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into ShipDoc(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				SDId.Value = IQApp.DB.GetInt("select isnull(max(SDId),0)+1 from ShipDoc");
				if (SDId.HasValue) {
					SQL += ", SDId";
					Values += ", @SDIdValue";
				}
				
				if (SDSuppId.HasValue) {
					SQL += ", SDSuppId";
					Values += ", @SDSuppIdValue";
				}
				
				if (SDSupp.HasValue) {
					SQL += ", SDSupp";
					Values += ", @SDSuppValue";
				}
				
				if (SDSuppAddr.HasValue) {
					SQL += ", SDSuppAddr";
					Values += ", @SDSuppAddrValue";
				}
				
				if (SDSuppVATNo.HasValue) {
					SQL += ", SDSuppVATNo";
					Values += ", @SDSuppVATNoValue";
				}
				
				if (SDTransRef.HasValue) {
					SQL += ", SDTransRef";
					Values += ", @SDTransRefValue";
				}
				
				if (SDCompAuth.HasValue) {
					SQL += ", SDCompAuth";
					Values += ", @SDCompAuthValue";
				}
				
				if (SDRecipId.HasValue) {
					SQL += ", SDRecipId";
					Values += ", @SDRecipIdValue";
				}
				
				if (SDRecip.HasValue) {
					SQL += ", SDRecip";
					Values += ", @SDRecipValue";
				}
				
				if (SDRecipAddr.HasValue) {
					SQL += ", SDRecipAddr";
					Values += ", @SDRecipAddrValue";
				}
				
				if (SDRecipVATNo.HasValue) {
					SQL += ", SDRecipVATNo";
					Values += ", @SDRecipVATNoValue";
				}
				
				if (SDRefNo.HasValue) {
					SQL += ", SDRefNo";
					Values += ", @SDRefNoValue";
				}
				
				if (SDDeclareDate.HasValue) {
					SQL += ", SDDeclareDate";
					Values += ", @SDDeclareDateValue";
				}
				
				if (SDDelPlace.HasValue) {
					SQL += ", SDDelPlace";
					Values += ", @SDDelPlaceValue";
				}
				
				if (SDDesc.HasValue) {
					SQL += ", SDDesc";
					Values += ", @SDDescValue";
				}
				
				if (SDCommCode1.HasValue) {
					SQL += ", SDCommCode1";
					Values += ", @SDCommCode1Value";
				}
				
				if (SDQty1.HasValue) {
					SQL += ", SDQty1";
					Values += ", @SDQty1Value";
				}
				
				if (SDGWeight1.HasValue) {
					SQL += ", SDGWeight1";
					Values += ", @SDGWeight1Value";
				}
				
				if (SDNWeight1.HasValue) {
					SQL += ", SDNWeight1";
					Values += ", @SDNWeight1Value";
				}
				
				if (SDValue1.HasValue) {
					SQL += ", SDValue1";
					Values += ", @SDValue1Value";
				}
				
				if (SDDesc2.HasValue) {
					SQL += ", SDDesc2";
					Values += ", @SDDesc2Value";
				}
				
				if (SDCommCode2.HasValue) {
					SQL += ", SDCommCode2";
					Values += ", @SDCommCode2Value";
				}
				
				if (SDQty2.HasValue) {
					SQL += ", SDQty2";
					Values += ", @SDQty2Value";
				}
				
				if (SDGWeight2.HasValue) {
					SQL += ", SDGWeight2";
					Values += ", @SDGWeight2Value";
				}
				
				if (SDNWeight2.HasValue) {
					SQL += ", SDNWeight2";
					Values += ", @SDNWeight2Value";
				}
				
				if (SDValue2.HasValue) {
					SQL += ", SDValue2";
					Values += ", @SDValue2Value";
				}
				
				if (SDDesc3.HasValue) {
					SQL += ", SDDesc3";
					Values += ", @SDDesc3Value";
				}
				
				if (SDCommCode3.HasValue) {
					SQL += ", SDCommCode3";
					Values += ", @SDCommCode3Value";
				}
				
				if (SDQty3.HasValue) {
					SQL += ", SDQty3";
					Values += ", @SDQty3Value";
				}
				
				if (SDGWeight3.HasValue) {
					SQL += ", SDGWeight3";
					Values += ", @SDGWeight3Value";
				}
				
				if (SDNWeight3.HasValue) {
					SQL += ", SDNWeight3";
					Values += ", @SDNWeight3Value";
				}
				
				if (SDValue3.HasValue) {
					SQL += ", SDValue3";
					Values += ", @SDValue3Value";
				}
				
				if (SDDesc4.HasValue) {
					SQL += ", SDDesc4";
					Values += ", @SDDesc4Value";
				}
				
				if (SDCommCode4.HasValue) {
					SQL += ", SDCommCode4";
					Values += ", @SDCommCode4Value";
				}
				
				if (SDQty4.HasValue) {
					SQL += ", SDQty4";
					Values += ", @SDQty4Value";
				}
				
				if (SDGWeight4.HasValue) {
					SQL += ", SDGWeight4";
					Values += ", @SDGWeight4Value";
				}
				
				if (SDNWeight4.HasValue) {
					SQL += ", SDNWeight4";
					Values += ", @SDNWeight4Value";
				}
				
				if (SDValue4.HasValue) {
					SQL += ", SDValue4";
					Values += ", @SDValue4Value";
				}
				
				if (SDRecordControl.HasValue) {
					SQL += ", SDRecordControl";
					Values += ", @SDRecordControlValue";
				}
				
				if (SDSignedBy.HasValue) {
					SQL += ", SDSignedBy";
					Values += ", @SDSignedByValue";
				}
				
				if (SDSignedByText.HasValue) {
					SQL += ", SDSignedByText";
					Values += ", @SDSignedByTextValue";
				}
				
				if (SDVehNo.HasValue) {
					SQL += ", SDVehNo";
					Values += ", @SDVehNoValue";
				}
				
				if (SDCurr.HasValue) {
					SQL += ", SDCurr";
					Values += ", @SDCurrValue";
				}
				
				if (SDHMRCDets.HasValue) {
					SQL += ", SDHMRCDets";
					Values += ", @SDHMRCDetsValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from ShipDoc");
					 IQApp.DB.Execute(SQL, this);
				                    					SDId.HasChanged = false;
									SDSuppId.HasChanged = false;
									SDSupp.HasChanged = false;
									SDSuppAddr.HasChanged = false;
									SDSuppVATNo.HasChanged = false;
									SDTransRef.HasChanged = false;
									SDCompAuth.HasChanged = false;
									SDRecipId.HasChanged = false;
									SDRecip.HasChanged = false;
									SDRecipAddr.HasChanged = false;
									SDRecipVATNo.HasChanged = false;
									SDRefNo.HasChanged = false;
									SDDeclareDate.HasChanged = false;
									SDDelPlace.HasChanged = false;
									SDDesc.HasChanged = false;
									SDCommCode1.HasChanged = false;
									SDQty1.HasChanged = false;
									SDGWeight1.HasChanged = false;
									SDNWeight1.HasChanged = false;
									SDValue1.HasChanged = false;
									SDDesc2.HasChanged = false;
									SDCommCode2.HasChanged = false;
									SDQty2.HasChanged = false;
									SDGWeight2.HasChanged = false;
									SDNWeight2.HasChanged = false;
									SDValue2.HasChanged = false;
									SDDesc3.HasChanged = false;
									SDCommCode3.HasChanged = false;
									SDQty3.HasChanged = false;
									SDGWeight3.HasChanged = false;
									SDNWeight3.HasChanged = false;
									SDValue3.HasChanged = false;
									SDDesc4.HasChanged = false;
									SDCommCode4.HasChanged = false;
									SDQty4.HasChanged = false;
									SDGWeight4.HasChanged = false;
									SDNWeight4.HasChanged = false;
									SDValue4.HasChanged = false;
									SDRecordControl.HasChanged = false;
									SDSignedBy.HasChanged = false;
									SDSignedByText.HasChanged = false;
									SDVehNo.HasChanged = false;
									SDCurr.HasChanged = false;
									SDHMRCDets.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "SDId":
					return (IDSFieldBase)SDId;
								case "SDSuppId":
					return (IDSFieldBase)SDSuppId;
								case "SDSupp":
					return (IDSFieldBase)SDSupp;
								case "SDSuppAddr":
					return (IDSFieldBase)SDSuppAddr;
								case "SDSuppVATNo":
					return (IDSFieldBase)SDSuppVATNo;
								case "SDTransRef":
					return (IDSFieldBase)SDTransRef;
								case "SDCompAuth":
					return (IDSFieldBase)SDCompAuth;
								case "SDRecipId":
					return (IDSFieldBase)SDRecipId;
								case "SDRecip":
					return (IDSFieldBase)SDRecip;
								case "SDRecipAddr":
					return (IDSFieldBase)SDRecipAddr;
								case "SDRecipVATNo":
					return (IDSFieldBase)SDRecipVATNo;
								case "SDRefNo":
					return (IDSFieldBase)SDRefNo;
								case "SDDeclareDate":
					return (IDSFieldBase)SDDeclareDate;
								case "SDDelPlace":
					return (IDSFieldBase)SDDelPlace;
								case "SDDesc":
					return (IDSFieldBase)SDDesc;
								case "SDCommCode1":
					return (IDSFieldBase)SDCommCode1;
								case "SDQty1":
					return (IDSFieldBase)SDQty1;
								case "SDGWeight1":
					return (IDSFieldBase)SDGWeight1;
								case "SDNWeight1":
					return (IDSFieldBase)SDNWeight1;
								case "SDValue1":
					return (IDSFieldBase)SDValue1;
								case "SDDesc2":
					return (IDSFieldBase)SDDesc2;
								case "SDCommCode2":
					return (IDSFieldBase)SDCommCode2;
								case "SDQty2":
					return (IDSFieldBase)SDQty2;
								case "SDGWeight2":
					return (IDSFieldBase)SDGWeight2;
								case "SDNWeight2":
					return (IDSFieldBase)SDNWeight2;
								case "SDValue2":
					return (IDSFieldBase)SDValue2;
								case "SDDesc3":
					return (IDSFieldBase)SDDesc3;
								case "SDCommCode3":
					return (IDSFieldBase)SDCommCode3;
								case "SDQty3":
					return (IDSFieldBase)SDQty3;
								case "SDGWeight3":
					return (IDSFieldBase)SDGWeight3;
								case "SDNWeight3":
					return (IDSFieldBase)SDNWeight3;
								case "SDValue3":
					return (IDSFieldBase)SDValue3;
								case "SDDesc4":
					return (IDSFieldBase)SDDesc4;
								case "SDCommCode4":
					return (IDSFieldBase)SDCommCode4;
								case "SDQty4":
					return (IDSFieldBase)SDQty4;
								case "SDGWeight4":
					return (IDSFieldBase)SDGWeight4;
								case "SDNWeight4":
					return (IDSFieldBase)SDNWeight4;
								case "SDValue4":
					return (IDSFieldBase)SDValue4;
								case "SDRecordControl":
					return (IDSFieldBase)SDRecordControl;
								case "SDSignedBy":
					return (IDSFieldBase)SDSignedBy;
								case "SDSignedByText":
					return (IDSFieldBase)SDSignedByText;
								case "SDVehNo":
					return (IDSFieldBase)SDVehNo;
								case "SDCurr":
					return (IDSFieldBase)SDCurr;
								case "SDHMRCDets":
					return (IDSFieldBase)SDHMRCDets;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "SDId":
					return SDId.DisplayValue;
								case "SDSuppId":
					return SDSuppId.DisplayValue;
								case "SDSupp":
					return SDSupp.DisplayValue;
								case "SDSuppAddr":
					return SDSuppAddr.DisplayValue;
								case "SDSuppVATNo":
					return SDSuppVATNo.DisplayValue;
								case "SDTransRef":
					return SDTransRef.DisplayValue;
								case "SDCompAuth":
					return SDCompAuth.DisplayValue;
								case "SDRecipId":
					return SDRecipId.DisplayValue;
								case "SDRecip":
					return SDRecip.DisplayValue;
								case "SDRecipAddr":
					return SDRecipAddr.DisplayValue;
								case "SDRecipVATNo":
					return SDRecipVATNo.DisplayValue;
								case "SDRefNo":
					return SDRefNo.DisplayValue;
								case "SDDeclareDate":
					return SDDeclareDate.DisplayValue;
								case "SDDelPlace":
					return SDDelPlace.DisplayValue;
								case "SDDesc":
					return SDDesc.DisplayValue;
								case "SDCommCode1":
					return SDCommCode1.DisplayValue;
								case "SDQty1":
					return SDQty1.DisplayValue;
								case "SDGWeight1":
					return SDGWeight1.DisplayValue;
								case "SDNWeight1":
					return SDNWeight1.DisplayValue;
								case "SDValue1":
					return SDValue1.DisplayValue;
								case "SDDesc2":
					return SDDesc2.DisplayValue;
								case "SDCommCode2":
					return SDCommCode2.DisplayValue;
								case "SDQty2":
					return SDQty2.DisplayValue;
								case "SDGWeight2":
					return SDGWeight2.DisplayValue;
								case "SDNWeight2":
					return SDNWeight2.DisplayValue;
								case "SDValue2":
					return SDValue2.DisplayValue;
								case "SDDesc3":
					return SDDesc3.DisplayValue;
								case "SDCommCode3":
					return SDCommCode3.DisplayValue;
								case "SDQty3":
					return SDQty3.DisplayValue;
								case "SDGWeight3":
					return SDGWeight3.DisplayValue;
								case "SDNWeight3":
					return SDNWeight3.DisplayValue;
								case "SDValue3":
					return SDValue3.DisplayValue;
								case "SDDesc4":
					return SDDesc4.DisplayValue;
								case "SDCommCode4":
					return SDCommCode4.DisplayValue;
								case "SDQty4":
					return SDQty4.DisplayValue;
								case "SDGWeight4":
					return SDGWeight4.DisplayValue;
								case "SDNWeight4":
					return SDNWeight4.DisplayValue;
								case "SDValue4":
					return SDValue4.DisplayValue;
								case "SDRecordControl":
					return SDRecordControl.DisplayValue;
								case "SDSignedBy":
					return SDSignedBy.DisplayValue;
								case "SDSignedByText":
					return SDSignedByText.DisplayValue;
								case "SDVehNo":
					return SDVehNo.DisplayValue;
								case "SDCurr":
					return SDCurr.DisplayValue;
								case "SDHMRCDets":
					return SDHMRCDets.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "SDId":
					return SDId.Value.ToString();
								case "SDSuppId":
					return SDSuppId.Value.ToString();
								case "SDSupp":
					return SDSupp.Value.ToString();
								case "SDSuppAddr":
					return SDSuppAddr.Value.ToString();
								case "SDSuppVATNo":
					return SDSuppVATNo.Value.ToString();
								case "SDTransRef":
					return SDTransRef.Value.ToString();
								case "SDCompAuth":
					return SDCompAuth.Value.ToString();
								case "SDRecipId":
					return SDRecipId.Value.ToString();
								case "SDRecip":
					return SDRecip.Value.ToString();
								case "SDRecipAddr":
					return SDRecipAddr.Value.ToString();
								case "SDRecipVATNo":
					return SDRecipVATNo.Value.ToString();
								case "SDRefNo":
					return SDRefNo.Value.ToString();
								case "SDDeclareDate":
					return SDDeclareDate.Value.ToString();
								case "SDDelPlace":
					return SDDelPlace.Value.ToString();
								case "SDDesc":
					return SDDesc.Value.ToString();
								case "SDCommCode1":
					return SDCommCode1.Value.ToString();
								case "SDQty1":
					return SDQty1.Value.ToString();
								case "SDGWeight1":
					return SDGWeight1.Value.ToString();
								case "SDNWeight1":
					return SDNWeight1.Value.ToString();
								case "SDValue1":
					return SDValue1.Value.ToString();
								case "SDDesc2":
					return SDDesc2.Value.ToString();
								case "SDCommCode2":
					return SDCommCode2.Value.ToString();
								case "SDQty2":
					return SDQty2.Value.ToString();
								case "SDGWeight2":
					return SDGWeight2.Value.ToString();
								case "SDNWeight2":
					return SDNWeight2.Value.ToString();
								case "SDValue2":
					return SDValue2.Value.ToString();
								case "SDDesc3":
					return SDDesc3.Value.ToString();
								case "SDCommCode3":
					return SDCommCode3.Value.ToString();
								case "SDQty3":
					return SDQty3.Value.ToString();
								case "SDGWeight3":
					return SDGWeight3.Value.ToString();
								case "SDNWeight3":
					return SDNWeight3.Value.ToString();
								case "SDValue3":
					return SDValue3.Value.ToString();
								case "SDDesc4":
					return SDDesc4.Value.ToString();
								case "SDCommCode4":
					return SDCommCode4.Value.ToString();
								case "SDQty4":
					return SDQty4.Value.ToString();
								case "SDGWeight4":
					return SDGWeight4.Value.ToString();
								case "SDNWeight4":
					return SDNWeight4.Value.ToString();
								case "SDValue4":
					return SDValue4.Value.ToString();
								case "SDRecordControl":
					return SDRecordControl.Value.ToString();
								case "SDSignedBy":
					return SDSignedBy.Value.ToString();
								case "SDSignedByText":
					return SDSignedByText.Value.ToString();
								case "SDVehNo":
					return SDVehNo.Value.ToString();
								case "SDCurr":
					return SDCurr.Value.ToString();
								case "SDHMRCDets":
					return SDHMRCDets.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<ShipDoc>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public ShipDoc () : base("ShipDoc") {
		base.obj = this;
	
					SDId = new ShipDoc_SDId(this);
					SDSuppId = new ShipDoc_SDSuppId(this);
					SDSupp = new ShipDoc_SDSupp(this);
					SDSuppAddr = new ShipDoc_SDSuppAddr(this);
					SDSuppVATNo = new ShipDoc_SDSuppVATNo(this);
					SDTransRef = new ShipDoc_SDTransRef(this);
					SDCompAuth = new ShipDoc_SDCompAuth(this);
					SDRecipId = new ShipDoc_SDRecipId(this);
					SDRecip = new ShipDoc_SDRecip(this);
					SDRecipAddr = new ShipDoc_SDRecipAddr(this);
					SDRecipVATNo = new ShipDoc_SDRecipVATNo(this);
					SDRefNo = new ShipDoc_SDRefNo(this);
					SDDeclareDate = new ShipDoc_SDDeclareDate(this);
					SDDelPlace = new ShipDoc_SDDelPlace(this);
					SDDesc = new ShipDoc_SDDesc(this);
					SDCommCode1 = new ShipDoc_SDCommCode1(this);
					SDQty1 = new ShipDoc_SDQty1(this);
					SDGWeight1 = new ShipDoc_SDGWeight1(this);
					SDNWeight1 = new ShipDoc_SDNWeight1(this);
					SDValue1 = new ShipDoc_SDValue1(this);
					SDDesc2 = new ShipDoc_SDDesc2(this);
					SDCommCode2 = new ShipDoc_SDCommCode2(this);
					SDQty2 = new ShipDoc_SDQty2(this);
					SDGWeight2 = new ShipDoc_SDGWeight2(this);
					SDNWeight2 = new ShipDoc_SDNWeight2(this);
					SDValue2 = new ShipDoc_SDValue2(this);
					SDDesc3 = new ShipDoc_SDDesc3(this);
					SDCommCode3 = new ShipDoc_SDCommCode3(this);
					SDQty3 = new ShipDoc_SDQty3(this);
					SDGWeight3 = new ShipDoc_SDGWeight3(this);
					SDNWeight3 = new ShipDoc_SDNWeight3(this);
					SDValue3 = new ShipDoc_SDValue3(this);
					SDDesc4 = new ShipDoc_SDDesc4(this);
					SDCommCode4 = new ShipDoc_SDCommCode4(this);
					SDQty4 = new ShipDoc_SDQty4(this);
					SDGWeight4 = new ShipDoc_SDGWeight4(this);
					SDNWeight4 = new ShipDoc_SDNWeight4(this);
					SDValue4 = new ShipDoc_SDValue4(this);
					SDRecordControl = new ShipDoc_SDRecordControl(this);
					SDSignedBy = new ShipDoc_SDSignedBy(this);
					SDSignedByText = new ShipDoc_SDSignedByText(this);
					SDVehNo = new ShipDoc_SDVehNo(this);
					SDCurr = new ShipDoc_SDCurr(this);
					SDHMRCDets = new ShipDoc_SDHMRCDets(this);
			}

	static ShipDoc () {
					SDIdField = new ShipDoc_SDIdFieldDef();
					SDSuppIdField = new ShipDoc_SDSuppIdFieldDef();
					SDSuppField = new ShipDoc_SDSuppFieldDef();
					SDSuppAddrField = new ShipDoc_SDSuppAddrFieldDef();
					SDSuppVATNoField = new ShipDoc_SDSuppVATNoFieldDef();
					SDTransRefField = new ShipDoc_SDTransRefFieldDef();
					SDCompAuthField = new ShipDoc_SDCompAuthFieldDef();
					SDRecipIdField = new ShipDoc_SDRecipIdFieldDef();
					SDRecipField = new ShipDoc_SDRecipFieldDef();
					SDRecipAddrField = new ShipDoc_SDRecipAddrFieldDef();
					SDRecipVATNoField = new ShipDoc_SDRecipVATNoFieldDef();
					SDRefNoField = new ShipDoc_SDRefNoFieldDef();
					SDDeclareDateField = new ShipDoc_SDDeclareDateFieldDef();
					SDDelPlaceField = new ShipDoc_SDDelPlaceFieldDef();
					SDDescField = new ShipDoc_SDDescFieldDef();
					SDCommCode1Field = new ShipDoc_SDCommCode1FieldDef();
					SDQty1Field = new ShipDoc_SDQty1FieldDef();
					SDGWeight1Field = new ShipDoc_SDGWeight1FieldDef();
					SDNWeight1Field = new ShipDoc_SDNWeight1FieldDef();
					SDValue1Field = new ShipDoc_SDValue1FieldDef();
					SDDesc2Field = new ShipDoc_SDDesc2FieldDef();
					SDCommCode2Field = new ShipDoc_SDCommCode2FieldDef();
					SDQty2Field = new ShipDoc_SDQty2FieldDef();
					SDGWeight2Field = new ShipDoc_SDGWeight2FieldDef();
					SDNWeight2Field = new ShipDoc_SDNWeight2FieldDef();
					SDValue2Field = new ShipDoc_SDValue2FieldDef();
					SDDesc3Field = new ShipDoc_SDDesc3FieldDef();
					SDCommCode3Field = new ShipDoc_SDCommCode3FieldDef();
					SDQty3Field = new ShipDoc_SDQty3FieldDef();
					SDGWeight3Field = new ShipDoc_SDGWeight3FieldDef();
					SDNWeight3Field = new ShipDoc_SDNWeight3FieldDef();
					SDValue3Field = new ShipDoc_SDValue3FieldDef();
					SDDesc4Field = new ShipDoc_SDDesc4FieldDef();
					SDCommCode4Field = new ShipDoc_SDCommCode4FieldDef();
					SDQty4Field = new ShipDoc_SDQty4FieldDef();
					SDGWeight4Field = new ShipDoc_SDGWeight4FieldDef();
					SDNWeight4Field = new ShipDoc_SDNWeight4FieldDef();
					SDValue4Field = new ShipDoc_SDValue4FieldDef();
					SDRecordControlField = new ShipDoc_SDRecordControlFieldDef();
					SDSignedByField = new ShipDoc_SDSignedByFieldDef();
					SDSignedByTextField = new ShipDoc_SDSignedByTextFieldDef();
					SDVehNoField = new ShipDoc_SDVehNoFieldDef();
					SDCurrField = new ShipDoc_SDCurrFieldDef();
					SDHMRCDetsField = new ShipDoc_SDHMRCDetsFieldDef();
			}

	public string RecordTitle { 
		get { return SDIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Shipping Documents"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/ShipDoc/Load/?RecId=" + RecordID.Value;
			}
			return "/ShipDoc/Add";
			}
	}

			
		
		[Ignore()]
		public ShipDoc_SDId SDId { get; set; }
		public static ShipDoc_SDIdFieldDef SDIdField { get; private set; }
        
			
			[Column("SDId")]
			public  int PopulateSDId  {
				get { return SDIdValue ;}
				set { SDId.DataValue = value; }
			}

	
			public int SDIdValue 
			{ 
				get 
				{
				   if(SDId.Value != null) {
				   					int i = 0;
					if (SDId != null)
					{
						if (SDId.Value != null)
						{
							if (Int32.TryParse(SDId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDId.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDSuppId SDSuppId { get; set; }
		public static ShipDoc_SDSuppIdFieldDef SDSuppIdField { get; private set; }
        
			
			[Column("SDSuppId")]
			public  int PopulateSDSuppId  {
				get { return SDSuppIdValue ;}
				set { SDSuppId.DataValue = value; }
			}

	
			public int SDSuppIdValue 
			{ 
				get 
				{
				   if(SDSuppId.Value != null) {
				   					int i = 0;
					if (SDSuppId != null)
					{
						if (SDSuppId.Value != null)
						{
							if (Int32.TryParse(SDSuppId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDSuppId.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDSupp SDSupp { get; set; }
		public static ShipDoc_SDSuppFieldDef SDSuppField { get; private set; }
        
			
			[Column("SDSupp")]
			public  int PopulateSDSupp  {
				get { return SDSuppValue ;}
				set { SDSupp.DataValue = value; }
			}

	
			public int SDSuppValue 
			{ 
				get 
				{
				   if(SDSupp.Value != null) {
				   					int i = 0;
					if (SDSupp != null)
					{
						if (SDSupp.Value != null)
						{
							if (Int32.TryParse(SDSupp.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDSupp.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDSuppAddr SDSuppAddr { get; set; }
		public static ShipDoc_SDSuppAddrFieldDef SDSuppAddrField { get; private set; }
        
			
			[Column("SDSuppAddr")]
			public  string PopulateSDSuppAddr  {
				get { return SDSuppAddrValue ;}
				set { SDSuppAddr.DataValue = value; }
			}

	
			public string SDSuppAddrValue 
			{ 
				get 
				{
				   if(SDSuppAddr.Value != null) {
				   return SDSuppAddr.Value.ToString(); 					}
					return "";
                
				}
				set { SDSuppAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDSuppVATNo SDSuppVATNo { get; set; }
		public static ShipDoc_SDSuppVATNoFieldDef SDSuppVATNoField { get; private set; }
        
			
			[Column("SDSuppVATNo")]
			public  string PopulateSDSuppVATNo  {
				get { return SDSuppVATNoValue ;}
				set { SDSuppVATNo.DataValue = value; }
			}

	
			public string SDSuppVATNoValue 
			{ 
				get 
				{
				   if(SDSuppVATNo.Value != null) {
				   return SDSuppVATNo.Value.ToString(); 					}
					return "";
                
				}
				set { SDSuppVATNo.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDTransRef SDTransRef { get; set; }
		public static ShipDoc_SDTransRefFieldDef SDTransRefField { get; private set; }
        
			
			[Column("SDTransRef")]
			public  string PopulateSDTransRef  {
				get { return SDTransRefValue ;}
				set { SDTransRef.DataValue = value; }
			}

	
			public string SDTransRefValue 
			{ 
				get 
				{
				   if(SDTransRef.Value != null) {
				   return SDTransRef.Value.ToString(); 					}
					return "";
                
				}
				set { SDTransRef.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDCompAuth SDCompAuth { get; set; }
		public static ShipDoc_SDCompAuthFieldDef SDCompAuthField { get; private set; }
        
			
			[Column("SDCompAuth")]
			public  string PopulateSDCompAuth  {
				get { return SDCompAuthValue ;}
				set { SDCompAuth.DataValue = value; }
			}

	
			public string SDCompAuthValue 
			{ 
				get 
				{
				   if(SDCompAuth.Value != null) {
				   return SDCompAuth.Value.ToString(); 					}
					return "";
                
				}
				set { SDCompAuth.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDRecipId SDRecipId { get; set; }
		public static ShipDoc_SDRecipIdFieldDef SDRecipIdField { get; private set; }
        
			
			[Column("SDRecipId")]
			public  int PopulateSDRecipId  {
				get { return SDRecipIdValue ;}
				set { SDRecipId.DataValue = value; }
			}

	
			public int SDRecipIdValue 
			{ 
				get 
				{
				   if(SDRecipId.Value != null) {
				   					int i = 0;
					if (SDRecipId != null)
					{
						if (SDRecipId.Value != null)
						{
							if (Int32.TryParse(SDRecipId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDRecipId.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDRecip SDRecip { get; set; }
		public static ShipDoc_SDRecipFieldDef SDRecipField { get; private set; }
        
			
			[Column("SDRecip")]
			public  int PopulateSDRecip  {
				get { return SDRecipValue ;}
				set { SDRecip.DataValue = value; }
			}

	
			public int SDRecipValue 
			{ 
				get 
				{
				   if(SDRecip.Value != null) {
				   					int i = 0;
					if (SDRecip != null)
					{
						if (SDRecip.Value != null)
						{
							if (Int32.TryParse(SDRecip.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDRecip.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDRecipAddr SDRecipAddr { get; set; }
		public static ShipDoc_SDRecipAddrFieldDef SDRecipAddrField { get; private set; }
        
			
			[Column("SDRecipAddr")]
			public  string PopulateSDRecipAddr  {
				get { return SDRecipAddrValue ;}
				set { SDRecipAddr.DataValue = value; }
			}

	
			public string SDRecipAddrValue 
			{ 
				get 
				{
				   if(SDRecipAddr.Value != null) {
				   return SDRecipAddr.Value.ToString(); 					}
					return "";
                
				}
				set { SDRecipAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDRecipVATNo SDRecipVATNo { get; set; }
		public static ShipDoc_SDRecipVATNoFieldDef SDRecipVATNoField { get; private set; }
        
			
			[Column("SDRecipVATNo")]
			public  string PopulateSDRecipVATNo  {
				get { return SDRecipVATNoValue ;}
				set { SDRecipVATNo.DataValue = value; }
			}

	
			public string SDRecipVATNoValue 
			{ 
				get 
				{
				   if(SDRecipVATNo.Value != null) {
				   return SDRecipVATNo.Value.ToString(); 					}
					return "";
                
				}
				set { SDRecipVATNo.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDRefNo SDRefNo { get; set; }
		public static ShipDoc_SDRefNoFieldDef SDRefNoField { get; private set; }
        
			
			[Column("SDRefNo")]
			public  string PopulateSDRefNo  {
				get { return SDRefNoValue ;}
				set { SDRefNo.DataValue = value; }
			}

	
			public string SDRefNoValue 
			{ 
				get 
				{
				   if(SDRefNo.Value != null) {
				   return SDRefNo.Value.ToString(); 					}
					return "";
                
				}
				set { SDRefNo.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDDeclareDate SDDeclareDate { get; set; }
		public static ShipDoc_SDDeclareDateFieldDef SDDeclareDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("SDDeclareDate")]
			public  DateTime PopulateSDDeclareDate  {
				get { return SDDeclareDateValue ;}
				set { SDDeclareDate.DataValue = value; }
			}

	
			public DateTime SDDeclareDateValue 
			{ 
				get 
				{
				   if(SDDeclareDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (SDDeclareDate != null)
					{
						if (SDDeclareDate.Value != null)
						{
							if (DateTime.TryParse(SDDeclareDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { SDDeclareDate.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDDelPlace SDDelPlace { get; set; }
		public static ShipDoc_SDDelPlaceFieldDef SDDelPlaceField { get; private set; }
        
			
			[Column("SDDelPlace")]
			public  string PopulateSDDelPlace  {
				get { return SDDelPlaceValue ;}
				set { SDDelPlace.DataValue = value; }
			}

	
			public string SDDelPlaceValue 
			{ 
				get 
				{
				   if(SDDelPlace.Value != null) {
				   return SDDelPlace.Value.ToString(); 					}
					return "";
                
				}
				set { SDDelPlace.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDDesc SDDesc { get; set; }
		public static ShipDoc_SDDescFieldDef SDDescField { get; private set; }
        
			
			[Column("SDDesc")]
			public  string PopulateSDDesc  {
				get { return SDDescValue ;}
				set { SDDesc.DataValue = value; }
			}

	
			public string SDDescValue 
			{ 
				get 
				{
				   if(SDDesc.Value != null) {
				   return SDDesc.Value.ToString(); 					}
					return "";
                
				}
				set { SDDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDCommCode1 SDCommCode1 { get; set; }
		public static ShipDoc_SDCommCode1FieldDef SDCommCode1Field { get; private set; }
        
			
			[Column("SDCommCode1")]
			public  string PopulateSDCommCode1  {
				get { return SDCommCode1Value ;}
				set { SDCommCode1.DataValue = value; }
			}

	
			public string SDCommCode1Value 
			{ 
				get 
				{
				   if(SDCommCode1.Value != null) {
				   return SDCommCode1.Value.ToString(); 					}
					return "";
                
				}
				set { SDCommCode1.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDQty1 SDQty1 { get; set; }
		public static ShipDoc_SDQty1FieldDef SDQty1Field { get; private set; }
        
			
			[Column("SDQty1")]
			public  double PopulateSDQty1  {
				get { return SDQty1Value ;}
				set { SDQty1.DataValue = value; }
			}

	
			public double SDQty1Value 
			{ 
				get 
				{
				   if(SDQty1.Value != null) {
				   					double i = 0.0;
					if (SDQty1 != null)
					{
						if (SDQty1.Value != null)
						{
							if (Double.TryParse(SDQty1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDQty1.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDGWeight1 SDGWeight1 { get; set; }
		public static ShipDoc_SDGWeight1FieldDef SDGWeight1Field { get; private set; }
        
			
			[Column("SDGWeight1")]
			public  double PopulateSDGWeight1  {
				get { return SDGWeight1Value ;}
				set { SDGWeight1.DataValue = value; }
			}

	
			public double SDGWeight1Value 
			{ 
				get 
				{
				   if(SDGWeight1.Value != null) {
				   					double i = 0.0;
					if (SDGWeight1 != null)
					{
						if (SDGWeight1.Value != null)
						{
							if (Double.TryParse(SDGWeight1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDGWeight1.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDNWeight1 SDNWeight1 { get; set; }
		public static ShipDoc_SDNWeight1FieldDef SDNWeight1Field { get; private set; }
        
			
			[Column("SDNWeight1")]
			public  double PopulateSDNWeight1  {
				get { return SDNWeight1Value ;}
				set { SDNWeight1.DataValue = value; }
			}

	
			public double SDNWeight1Value 
			{ 
				get 
				{
				   if(SDNWeight1.Value != null) {
				   					double i = 0.0;
					if (SDNWeight1 != null)
					{
						if (SDNWeight1.Value != null)
						{
							if (Double.TryParse(SDNWeight1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDNWeight1.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDValue1 SDValue1 { get; set; }
		public static ShipDoc_SDValue1FieldDef SDValue1Field { get; private set; }
        
			
			[Column("SDValue1")]
			public  double PopulateSDValue1  {
				get { return SDValue1Value ;}
				set { SDValue1.DataValue = value; }
			}

	
			public double SDValue1Value 
			{ 
				get 
				{
				   if(SDValue1.Value != null) {
				   					double i = 0.0;
					if (SDValue1 != null)
					{
						if (SDValue1.Value != null)
						{
							if (Double.TryParse(SDValue1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDValue1.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDDesc2 SDDesc2 { get; set; }
		public static ShipDoc_SDDesc2FieldDef SDDesc2Field { get; private set; }
        
			
			[Column("SDDesc2")]
			public  string PopulateSDDesc2  {
				get { return SDDesc2Value ;}
				set { SDDesc2.DataValue = value; }
			}

	
			public string SDDesc2Value 
			{ 
				get 
				{
				   if(SDDesc2.Value != null) {
				   return SDDesc2.Value.ToString(); 					}
					return "";
                
				}
				set { SDDesc2.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDCommCode2 SDCommCode2 { get; set; }
		public static ShipDoc_SDCommCode2FieldDef SDCommCode2Field { get; private set; }
        
			
			[Column("SDCommCode2")]
			public  string PopulateSDCommCode2  {
				get { return SDCommCode2Value ;}
				set { SDCommCode2.DataValue = value; }
			}

	
			public string SDCommCode2Value 
			{ 
				get 
				{
				   if(SDCommCode2.Value != null) {
				   return SDCommCode2.Value.ToString(); 					}
					return "";
                
				}
				set { SDCommCode2.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDQty2 SDQty2 { get; set; }
		public static ShipDoc_SDQty2FieldDef SDQty2Field { get; private set; }
        
			
			[Column("SDQty2")]
			public  double PopulateSDQty2  {
				get { return SDQty2Value ;}
				set { SDQty2.DataValue = value; }
			}

	
			public double SDQty2Value 
			{ 
				get 
				{
				   if(SDQty2.Value != null) {
				   					double i = 0.0;
					if (SDQty2 != null)
					{
						if (SDQty2.Value != null)
						{
							if (Double.TryParse(SDQty2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDQty2.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDGWeight2 SDGWeight2 { get; set; }
		public static ShipDoc_SDGWeight2FieldDef SDGWeight2Field { get; private set; }
        
			
			[Column("SDGWeight2")]
			public  double PopulateSDGWeight2  {
				get { return SDGWeight2Value ;}
				set { SDGWeight2.DataValue = value; }
			}

	
			public double SDGWeight2Value 
			{ 
				get 
				{
				   if(SDGWeight2.Value != null) {
				   					double i = 0.0;
					if (SDGWeight2 != null)
					{
						if (SDGWeight2.Value != null)
						{
							if (Double.TryParse(SDGWeight2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDGWeight2.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDNWeight2 SDNWeight2 { get; set; }
		public static ShipDoc_SDNWeight2FieldDef SDNWeight2Field { get; private set; }
        
			
			[Column("SDNWeight2")]
			public  double PopulateSDNWeight2  {
				get { return SDNWeight2Value ;}
				set { SDNWeight2.DataValue = value; }
			}

	
			public double SDNWeight2Value 
			{ 
				get 
				{
				   if(SDNWeight2.Value != null) {
				   					double i = 0.0;
					if (SDNWeight2 != null)
					{
						if (SDNWeight2.Value != null)
						{
							if (Double.TryParse(SDNWeight2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDNWeight2.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDValue2 SDValue2 { get; set; }
		public static ShipDoc_SDValue2FieldDef SDValue2Field { get; private set; }
        
			
			[Column("SDValue2")]
			public  double PopulateSDValue2  {
				get { return SDValue2Value ;}
				set { SDValue2.DataValue = value; }
			}

	
			public double SDValue2Value 
			{ 
				get 
				{
				   if(SDValue2.Value != null) {
				   					double i = 0.0;
					if (SDValue2 != null)
					{
						if (SDValue2.Value != null)
						{
							if (Double.TryParse(SDValue2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDValue2.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDDesc3 SDDesc3 { get; set; }
		public static ShipDoc_SDDesc3FieldDef SDDesc3Field { get; private set; }
        
			
			[Column("SDDesc3")]
			public  string PopulateSDDesc3  {
				get { return SDDesc3Value ;}
				set { SDDesc3.DataValue = value; }
			}

	
			public string SDDesc3Value 
			{ 
				get 
				{
				   if(SDDesc3.Value != null) {
				   return SDDesc3.Value.ToString(); 					}
					return "";
                
				}
				set { SDDesc3.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDCommCode3 SDCommCode3 { get; set; }
		public static ShipDoc_SDCommCode3FieldDef SDCommCode3Field { get; private set; }
        
			
			[Column("SDCommCode3")]
			public  string PopulateSDCommCode3  {
				get { return SDCommCode3Value ;}
				set { SDCommCode3.DataValue = value; }
			}

	
			public string SDCommCode3Value 
			{ 
				get 
				{
				   if(SDCommCode3.Value != null) {
				   return SDCommCode3.Value.ToString(); 					}
					return "";
                
				}
				set { SDCommCode3.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDQty3 SDQty3 { get; set; }
		public static ShipDoc_SDQty3FieldDef SDQty3Field { get; private set; }
        
			
			[Column("SDQty3")]
			public  double PopulateSDQty3  {
				get { return SDQty3Value ;}
				set { SDQty3.DataValue = value; }
			}

	
			public double SDQty3Value 
			{ 
				get 
				{
				   if(SDQty3.Value != null) {
				   					double i = 0.0;
					if (SDQty3 != null)
					{
						if (SDQty3.Value != null)
						{
							if (Double.TryParse(SDQty3.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDQty3.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDGWeight3 SDGWeight3 { get; set; }
		public static ShipDoc_SDGWeight3FieldDef SDGWeight3Field { get; private set; }
        
			
			[Column("SDGWeight3")]
			public  double PopulateSDGWeight3  {
				get { return SDGWeight3Value ;}
				set { SDGWeight3.DataValue = value; }
			}

	
			public double SDGWeight3Value 
			{ 
				get 
				{
				   if(SDGWeight3.Value != null) {
				   					double i = 0.0;
					if (SDGWeight3 != null)
					{
						if (SDGWeight3.Value != null)
						{
							if (Double.TryParse(SDGWeight3.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDGWeight3.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDNWeight3 SDNWeight3 { get; set; }
		public static ShipDoc_SDNWeight3FieldDef SDNWeight3Field { get; private set; }
        
			
			[Column("SDNWeight3")]
			public  double PopulateSDNWeight3  {
				get { return SDNWeight3Value ;}
				set { SDNWeight3.DataValue = value; }
			}

	
			public double SDNWeight3Value 
			{ 
				get 
				{
				   if(SDNWeight3.Value != null) {
				   					double i = 0.0;
					if (SDNWeight3 != null)
					{
						if (SDNWeight3.Value != null)
						{
							if (Double.TryParse(SDNWeight3.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDNWeight3.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDValue3 SDValue3 { get; set; }
		public static ShipDoc_SDValue3FieldDef SDValue3Field { get; private set; }
        
			
			[Column("SDValue3")]
			public  double PopulateSDValue3  {
				get { return SDValue3Value ;}
				set { SDValue3.DataValue = value; }
			}

	
			public double SDValue3Value 
			{ 
				get 
				{
				   if(SDValue3.Value != null) {
				   					double i = 0.0;
					if (SDValue3 != null)
					{
						if (SDValue3.Value != null)
						{
							if (Double.TryParse(SDValue3.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDValue3.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDDesc4 SDDesc4 { get; set; }
		public static ShipDoc_SDDesc4FieldDef SDDesc4Field { get; private set; }
        
			
			[Column("SDDesc4")]
			public  string PopulateSDDesc4  {
				get { return SDDesc4Value ;}
				set { SDDesc4.DataValue = value; }
			}

	
			public string SDDesc4Value 
			{ 
				get 
				{
				   if(SDDesc4.Value != null) {
				   return SDDesc4.Value.ToString(); 					}
					return "";
                
				}
				set { SDDesc4.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDCommCode4 SDCommCode4 { get; set; }
		public static ShipDoc_SDCommCode4FieldDef SDCommCode4Field { get; private set; }
        
			
			[Column("SDCommCode4")]
			public  string PopulateSDCommCode4  {
				get { return SDCommCode4Value ;}
				set { SDCommCode4.DataValue = value; }
			}

	
			public string SDCommCode4Value 
			{ 
				get 
				{
				   if(SDCommCode4.Value != null) {
				   return SDCommCode4.Value.ToString(); 					}
					return "";
                
				}
				set { SDCommCode4.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDQty4 SDQty4 { get; set; }
		public static ShipDoc_SDQty4FieldDef SDQty4Field { get; private set; }
        
			
			[Column("SDQty4")]
			public  double PopulateSDQty4  {
				get { return SDQty4Value ;}
				set { SDQty4.DataValue = value; }
			}

	
			public double SDQty4Value 
			{ 
				get 
				{
				   if(SDQty4.Value != null) {
				   					double i = 0.0;
					if (SDQty4 != null)
					{
						if (SDQty4.Value != null)
						{
							if (Double.TryParse(SDQty4.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDQty4.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDGWeight4 SDGWeight4 { get; set; }
		public static ShipDoc_SDGWeight4FieldDef SDGWeight4Field { get; private set; }
        
			
			[Column("SDGWeight4")]
			public  double PopulateSDGWeight4  {
				get { return SDGWeight4Value ;}
				set { SDGWeight4.DataValue = value; }
			}

	
			public double SDGWeight4Value 
			{ 
				get 
				{
				   if(SDGWeight4.Value != null) {
				   					double i = 0.0;
					if (SDGWeight4 != null)
					{
						if (SDGWeight4.Value != null)
						{
							if (Double.TryParse(SDGWeight4.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDGWeight4.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDNWeight4 SDNWeight4 { get; set; }
		public static ShipDoc_SDNWeight4FieldDef SDNWeight4Field { get; private set; }
        
			
			[Column("SDNWeight4")]
			public  double PopulateSDNWeight4  {
				get { return SDNWeight4Value ;}
				set { SDNWeight4.DataValue = value; }
			}

	
			public double SDNWeight4Value 
			{ 
				get 
				{
				   if(SDNWeight4.Value != null) {
				   					double i = 0.0;
					if (SDNWeight4 != null)
					{
						if (SDNWeight4.Value != null)
						{
							if (Double.TryParse(SDNWeight4.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDNWeight4.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDValue4 SDValue4 { get; set; }
		public static ShipDoc_SDValue4FieldDef SDValue4Field { get; private set; }
        
			
			[Column("SDValue4")]
			public  double PopulateSDValue4  {
				get { return SDValue4Value ;}
				set { SDValue4.DataValue = value; }
			}

	
			public double SDValue4Value 
			{ 
				get 
				{
				   if(SDValue4.Value != null) {
				   					double i = 0.0;
					if (SDValue4 != null)
					{
						if (SDValue4.Value != null)
						{
							if (Double.TryParse(SDValue4.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { SDValue4.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDRecordControl SDRecordControl { get; set; }
		public static ShipDoc_SDRecordControlFieldDef SDRecordControlField { get; private set; }
        
			
			[Column("SDRecordControl")]
			public  string PopulateSDRecordControl  {
				get { return SDRecordControlValue ;}
				set { SDRecordControl.DataValue = value; }
			}

	
			public string SDRecordControlValue 
			{ 
				get 
				{
				   if(SDRecordControl.Value != null) {
				   return SDRecordControl.Value.ToString(); 					}
					return "";
                
				}
				set { SDRecordControl.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDSignedBy SDSignedBy { get; set; }
		public static ShipDoc_SDSignedByFieldDef SDSignedByField { get; private set; }
        
			
			[Column("SDSignedBy")]
			public  int PopulateSDSignedBy  {
				get { return SDSignedByValue ;}
				set { SDSignedBy.DataValue = value; }
			}

	
			public int SDSignedByValue 
			{ 
				get 
				{
				   if(SDSignedBy.Value != null) {
				   					int i = 0;
					if (SDSignedBy != null)
					{
						if (SDSignedBy.Value != null)
						{
							if (Int32.TryParse(SDSignedBy.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDSignedBy.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDSignedByText SDSignedByText { get; set; }
		public static ShipDoc_SDSignedByTextFieldDef SDSignedByTextField { get; private set; }
        
			
			[Column("SDSignedByText")]
			public  string PopulateSDSignedByText  {
				get { return SDSignedByTextValue ;}
				set { SDSignedByText.DataValue = value; }
			}

	
			public string SDSignedByTextValue 
			{ 
				get 
				{
				   if(SDSignedByText.Value != null) {
				   return SDSignedByText.Value.ToString(); 					}
					return "";
                
				}
				set { SDSignedByText.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDVehNo SDVehNo { get; set; }
		public static ShipDoc_SDVehNoFieldDef SDVehNoField { get; private set; }
        
			
			[Column("SDVehNo")]
			public  string PopulateSDVehNo  {
				get { return SDVehNoValue ;}
				set { SDVehNo.DataValue = value; }
			}

	
			public string SDVehNoValue 
			{ 
				get 
				{
				   if(SDVehNo.Value != null) {
				   return SDVehNo.Value.ToString(); 					}
					return "";
                
				}
				set { SDVehNo.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDCurr SDCurr { get; set; }
		public static ShipDoc_SDCurrFieldDef SDCurrField { get; private set; }
        
			
			[Column("SDCurr")]
			public  int PopulateSDCurr  {
				get { return SDCurrValue ;}
				set { SDCurr.DataValue = value; }
			}

	
			public int SDCurrValue 
			{ 
				get 
				{
				   if(SDCurr.Value != null) {
				   					int i = 0;
					if (SDCurr != null)
					{
						if (SDCurr.Value != null)
						{
							if (Int32.TryParse(SDCurr.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SDCurr.Value = value;  }
			}
			
		
		[Ignore()]
		public ShipDoc_SDHMRCDets SDHMRCDets { get; set; }
		public static ShipDoc_SDHMRCDetsFieldDef SDHMRCDetsField { get; private set; }
        
			
			[Column("SDHMRCDets")]
			public  bool PopulateSDHMRCDets  {
				get { return SDHMRCDetsValue ;}
				set { SDHMRCDets.DataValue = value; }
			}

	
			public bool SDHMRCDetsValue 
			{ 
				get 
				{
				   if(SDHMRCDets.Value != null) {
				   					bool i = false;
					if (SDHMRCDets != null)
					{
						if (SDHMRCDets.Value != null)
						{
							if (Boolean.TryParse(SDHMRCDets.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { SDHMRCDets.Value = value;  }
			}
	}


public class ShipDoc_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 30;
    public int PixelHeight => 0;
	public string Title => "Shipping Documents";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
