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


public partial class EMailController : DSBaseController<EMail/*,EMailSearch*/> {
	public EMailController() : base ((IDatabase)IQApp.DB, new EMailRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select EMId from EMail where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<EMail>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(EMail data) {
						IQApp.DB.Execute("Delete from EMail where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.EMSubjectValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from EMail " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from EMail " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from EMail " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/EMail_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<EMail>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<EMail>("select * from EMail  ").ToList();
		string urlpath = "/temp/E-mails Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("E-mails");
				
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
							
					worksheet.Column(1).Width = 33;
					worksheet.Cells[1, 1].Value = "From";
						
								
					worksheet.Column(2).Width = 50;
					worksheet.Cells[1, 2].Value = "Subject";
						
								
					worksheet.Column(3).Width = 17;
					worksheet.Cells[1, 3].Value = "Date Sent";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].EMFrom.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].EMSubject.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].EMDateSent.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.EMIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMId" || f.Key == "Id" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMId(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMId" || f.Key == "Id" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.EMNameValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMName"  || f.Key == "TemplateId" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMName" || f.Key == "TemplateId" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteEMName(EMail m, int? id, string q) {

		
		string s = m.EMName.DataSource;
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
	public ActionResult CallbackEMName(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMName"  || f.Key == "TemplateId" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMName" || f.Key == "TemplateId" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMFrom(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMFromValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMFrom"  || f.Key == "FromAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMFrom" || f.Key == "FromAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMFrom(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMFrom"  || f.Key == "FromAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMFrom" || f.Key == "FromAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMDS(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMDSValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDS"  || f.Key == "Dataset" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDS" || f.Key == "Dataset" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMDS(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDS"  || f.Key == "Dataset" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDS" || f.Key == "Dataset" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMToValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMTo"  || f.Key == "ToAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMTo" || f.Key == "ToAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTo(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMTo"  || f.Key == "ToAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMTo" || f.Key == "ToAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMCC(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMCCValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCC"  || f.Key == "CCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCC" || f.Key == "CCAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMCC(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCC"  || f.Key == "CCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCC" || f.Key == "CCAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMSubject(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMSubjectValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMSubject"  || f.Key == "Subject" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMSubject" || f.Key == "Subject" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMSubject(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMSubject"  || f.Key == "Subject" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMSubject" || f.Key == "Subject" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMBody(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMBodyValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBody"  || f.Key == "Body" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBody" || f.Key == "Body" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMBody(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBody"  || f.Key == "Body" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBody" || f.Key == "Body" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMAttach(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMAttachValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMAttach"  || f.Key == "Attachments" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMAttach" || f.Key == "Attachments" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
					CR.AddJS("$('#FilesFor-EMAttachValue').load('/EMail/Update" + Request["ScreenInfo"] + "/?RecId=" + RecId + "');");
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMAttach(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMAttach"  || f.Key == "Attachments" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMAttach" || f.Key == "Attachments" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

			public ActionResult UpdateEMAttach(int RecId) {
			var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
			return PartialView("~/Views/DFPartial_EMAttach.cshtml", ds);
		}

	
	[ValidateInput(false)]
	public ActionResult SaveEMStatus(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.EMStatusValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMStatus" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMStatus")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteEMStatus(EMail m, int? id, string q) {

		
		string s = m.EMStatus.DataSource;
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
	public ActionResult CallbackEMStatus(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMStatus" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMStatus")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMDateSent(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.EMDateSentValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDateSent" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDateSent")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMDateSent(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDateSent" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDateSent")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMToRecords(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMToRecordsValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMToRecords"  || f.Key == "ToRecords" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMToRecords" || f.Key == "ToRecords" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteEMToRecords(EMail m, int? id, string q) {

		
		string s = m.EMToRecords.DataSource;
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
	public ActionResult CallbackEMToRecords(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMToRecords"  || f.Key == "ToRecords" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMToRecords" || f.Key == "ToRecords" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMDF(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMDFValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDF"  || f.Key == "DataField" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDF" || f.Key == "DataField" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMDF(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDF"  || f.Key == "DataField" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMDF" || f.Key == "DataField" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMCCRecords(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMCCRecordsValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCCRecords"  || f.Key == "CCRecords" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCCRecords" || f.Key == "CCRecords" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteEMCCRecords(EMail m, int? id, string q) {

		
		string s = m.EMCCRecords.DataSource;
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
	public ActionResult CallbackEMCCRecords(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCCRecords"  || f.Key == "CCRecords" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMCCRecords" || f.Key == "CCRecords" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMBCC(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMBCCValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCC"  || f.Key == "BCCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCC" || f.Key == "BCCAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMBCC(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCC"  || f.Key == "BCCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCC" || f.Key == "BCCAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMBCCRecords(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EMail>("select * from EMail where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMBCCRecordsValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCCRecords"  || f.Key == "BCCRecords" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCCRecords" || f.Key == "BCCRecords" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteEMBCCRecords(EMail m, int? id, string q) {

		
		string s = m.EMBCCRecords.DataSource;
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
	public ActionResult CallbackEMBCCRecords(EMail obj) {
			
		if(DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCCRecords"  || f.Key == "BCCRecords" ).Any()) {
			foreach(var itm in DS.GetManager<EMail>().OnChange.Where(f=> f.Key == "EMBCCRecords" || f.Key == "BCCRecords" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EMail>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=45 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/EMail/Search/" + FirstSearch);
		
		return Redirect("/EMail/List/");
	}

}

public partial class EMailRepository : DSRepository<EMail> {
	public EMailRepository() : base(45, "EMail", "E-mails") {
	}
}
public partial class EMail 
: DatasetBase<EMail>, IDSBase
, Intrinsiq.Email.IEMail
  {
	  public int KeyValue => EMIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "EMId":
			return EMIdField;
				case "EMName":
			return EMNameField;
				case "EMFrom":
			return EMFromField;
				case "EMDS":
			return EMDSField;
				case "EMTo":
			return EMToField;
				case "EMCC":
			return EMCCField;
				case "EMSubject":
			return EMSubjectField;
				case "EMBody":
			return EMBodyField;
				case "EMAttach":
			return EMAttachField;
				case "EMStatus":
			return EMStatusField;
				case "EMDateSent":
			return EMDateSentField;
				case "EMToRecords":
			return EMToRecordsField;
				case "EMDF":
			return EMDFField;
				case "EMCCRecords":
			return EMCCRecordsField;
				case "EMBCC":
			return EMBCCField;
				case "EMBCCRecords":
			return EMBCCRecordsField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(EMId,EMIdField);
				action(EMName,EMNameField);
				action(EMFrom,EMFromField);
				action(EMDS,EMDSField);
				action(EMTo,EMToField);
				action(EMCC,EMCCField);
				action(EMSubject,EMSubjectField);
				action(EMBody,EMBodyField);
				action(EMAttach,EMAttachField);
				action(EMStatus,EMStatusField);
				action(EMDateSent,EMDateSentField);
				action(EMToRecords,EMToRecordsField);
				action(EMDF,EMDFField);
				action(EMCCRecords,EMCCRecordsField);
				action(EMBCC,EMBCCField);
				action(EMBCCRecords,EMBCCRecordsField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				EMId.Visible=false;EMName.Visible=false;EMFrom.Visible=false;EMDS.Visible=false;EMTo.Visible=false;EMCC.Visible=false;EMSubject.Visible=false;EMBody.Visible=false;EMAttach.Visible=false;EMStatus.Visible=false;EMDateSent.Visible=false;EMToRecords.Visible=false;EMDF.Visible=false;EMCCRecords.Visible=false;EMBCC.Visible=false;EMBCCRecords.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update EMail set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (EMId.HasChanged && EMId.HasValue) {
					SQL += ", EMId=@EMIdValue";

				}
								if (EMName.HasChanged && EMName.HasValue) {
					SQL += ", EMName=@EMNameValue";

				}
								if (EMFrom.HasChanged && EMFrom.HasValue) {
					SQL += ", EMFrom=@EMFromValue";

				}
								if (EMDS.HasChanged && EMDS.HasValue) {
					SQL += ", EMDS=@EMDSValue";

				}
								if (EMTo.HasChanged && EMTo.HasValue) {
					SQL += ", EMTo=@EMToValue";

				}
								if (EMCC.HasChanged && EMCC.HasValue) {
					SQL += ", EMCC=@EMCCValue";

				}
								if (EMSubject.HasChanged && EMSubject.HasValue) {
					SQL += ", EMSubject=@EMSubjectValue";

				}
								if (EMBody.HasChanged && EMBody.HasValue) {
					SQL += ", EMBody=@EMBodyValue";

				}
								if (EMAttach.HasChanged && EMAttach.HasValue) {
					SQL += ", EMAttach=@EMAttachValue";

				}
								if (EMStatus.HasChanged && EMStatus.HasValue) {
					SQL += ", EMStatus=@EMStatusValue";

				}
								if (EMDateSent.HasChanged && EMDateSent.HasValue) {
					SQL += ", EMDateSent=@EMDateSentValue";

				}
								if (EMToRecords.HasChanged && EMToRecords.HasValue) {
					SQL += ", EMToRecords=@EMToRecordsValue";

				}
								if (EMDF.HasChanged && EMDF.HasValue) {
					SQL += ", EMDF=@EMDFValue";

				}
								if (EMCCRecords.HasChanged && EMCCRecords.HasValue) {
					SQL += ", EMCCRecords=@EMCCRecordsValue";

				}
								if (EMBCC.HasChanged && EMBCC.HasValue) {
					SQL += ", EMBCC=@EMBCCValue";

				}
								if (EMBCCRecords.HasChanged && EMBCCRecords.HasValue) {
					SQL += ", EMBCCRecords=@EMBCCRecordsValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									EMId.HasChanged = false;
									EMName.HasChanged = false;
									EMFrom.HasChanged = false;
									EMDS.HasChanged = false;
									EMTo.HasChanged = false;
									EMCC.HasChanged = false;
									EMSubject.HasChanged = false;
									EMBody.HasChanged = false;
									EMAttach.HasChanged = false;
									EMStatus.HasChanged = false;
									EMDateSent.HasChanged = false;
									EMToRecords.HasChanged = false;
									EMDF.HasChanged = false;
									EMCCRecords.HasChanged = false;
									EMBCC.HasChanged = false;
									EMBCCRecords.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into EMail(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				EMId.Value = IQApp.DB.GetInt("select isnull(max(EMId),0)+1 from EMail");
				if (EMId.HasValue) {
					SQL += ", EMId";
					Values += ", @EMIdValue";
				}
				
				if (EMName.HasValue) {
					SQL += ", EMName";
					Values += ", @EMNameValue";
				}
				
				if (EMFrom.HasValue) {
					SQL += ", EMFrom";
					Values += ", @EMFromValue";
				}
				
				if (EMDS.HasValue) {
					SQL += ", EMDS";
					Values += ", @EMDSValue";
				}
				
				if (EMTo.HasValue) {
					SQL += ", EMTo";
					Values += ", @EMToValue";
				}
				
				if (EMCC.HasValue) {
					SQL += ", EMCC";
					Values += ", @EMCCValue";
				}
				
				if (EMSubject.HasValue) {
					SQL += ", EMSubject";
					Values += ", @EMSubjectValue";
				}
				
				if (EMBody.HasValue) {
					SQL += ", EMBody";
					Values += ", @EMBodyValue";
				}
				
				if (EMAttach.HasValue) {
					SQL += ", EMAttach";
					Values += ", @EMAttachValue";
				}
				
				if (EMStatus.HasValue) {
					SQL += ", EMStatus";
					Values += ", @EMStatusValue";
				}
				
				if (EMDateSent.HasValue) {
					SQL += ", EMDateSent";
					Values += ", @EMDateSentValue";
				}
				
				if (EMToRecords.HasValue) {
					SQL += ", EMToRecords";
					Values += ", @EMToRecordsValue";
				}
				
				if (EMDF.HasValue) {
					SQL += ", EMDF";
					Values += ", @EMDFValue";
				}
				
				if (EMCCRecords.HasValue) {
					SQL += ", EMCCRecords";
					Values += ", @EMCCRecordsValue";
				}
				
				if (EMBCC.HasValue) {
					SQL += ", EMBCC";
					Values += ", @EMBCCValue";
				}
				
				if (EMBCCRecords.HasValue) {
					SQL += ", EMBCCRecords";
					Values += ", @EMBCCRecordsValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from EMail");
					 IQApp.DB.Execute(SQL, this);
				                    					EMId.HasChanged = false;
									EMName.HasChanged = false;
									EMFrom.HasChanged = false;
									EMDS.HasChanged = false;
									EMTo.HasChanged = false;
									EMCC.HasChanged = false;
									EMSubject.HasChanged = false;
									EMBody.HasChanged = false;
									EMAttach.HasChanged = false;
									EMStatus.HasChanged = false;
									EMDateSent.HasChanged = false;
									EMToRecords.HasChanged = false;
									EMDF.HasChanged = false;
									EMCCRecords.HasChanged = false;
									EMBCC.HasChanged = false;
									EMBCCRecords.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "EMId":
					return (IDSFieldBase)EMId;
								case "EMName":
					return (IDSFieldBase)EMName;
								case "EMFrom":
					return (IDSFieldBase)EMFrom;
								case "EMDS":
					return (IDSFieldBase)EMDS;
								case "EMTo":
					return (IDSFieldBase)EMTo;
								case "EMCC":
					return (IDSFieldBase)EMCC;
								case "EMSubject":
					return (IDSFieldBase)EMSubject;
								case "EMBody":
					return (IDSFieldBase)EMBody;
								case "EMAttach":
					return (IDSFieldBase)EMAttach;
								case "EMStatus":
					return (IDSFieldBase)EMStatus;
								case "EMDateSent":
					return (IDSFieldBase)EMDateSent;
								case "EMToRecords":
					return (IDSFieldBase)EMToRecords;
								case "EMDF":
					return (IDSFieldBase)EMDF;
								case "EMCCRecords":
					return (IDSFieldBase)EMCCRecords;
								case "EMBCC":
					return (IDSFieldBase)EMBCC;
								case "EMBCCRecords":
					return (IDSFieldBase)EMBCCRecords;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "EMId":
					return EMId.DisplayValue;
								case "EMName":
					return EMName.DisplayValue;
								case "EMFrom":
					return EMFrom.DisplayValue;
								case "EMDS":
					return EMDS.DisplayValue;
								case "EMTo":
					return EMTo.DisplayValue;
								case "EMCC":
					return EMCC.DisplayValue;
								case "EMSubject":
					return EMSubject.DisplayValue;
								case "EMBody":
					return EMBody.DisplayValue;
								case "EMAttach":
					return EMAttach.DisplayValue;
								case "EMStatus":
					return EMStatus.DisplayValue;
								case "EMDateSent":
					return EMDateSent.DisplayValue;
								case "EMToRecords":
					return EMToRecords.DisplayValue;
								case "EMDF":
					return EMDF.DisplayValue;
								case "EMCCRecords":
					return EMCCRecords.DisplayValue;
								case "EMBCC":
					return EMBCC.DisplayValue;
								case "EMBCCRecords":
					return EMBCCRecords.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "EMId":
					return EMId.Value.ToString();
								case "EMName":
					return EMName.Value.ToString();
								case "EMFrom":
					return EMFrom.Value.ToString();
								case "EMDS":
					return EMDS.Value.ToString();
								case "EMTo":
					return EMTo.Value.ToString();
								case "EMCC":
					return EMCC.Value.ToString();
								case "EMSubject":
					return EMSubject.Value.ToString();
								case "EMBody":
					return EMBody.Value.ToString();
								case "EMAttach":
					return EMAttach.Value.ToString();
								case "EMStatus":
					return EMStatus.Value.ToString();
								case "EMDateSent":
					return EMDateSent.Value.ToString();
								case "EMToRecords":
					return EMToRecords.Value.ToString();
								case "EMDF":
					return EMDF.Value.ToString();
								case "EMCCRecords":
					return EMCCRecords.Value.ToString();
								case "EMBCC":
					return EMBCC.Value.ToString();
								case "EMBCCRecords":
					return EMBCCRecords.Value.ToString();
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
					foreach(var itm in DS.GetManager<EMail>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public EMail () : base("EMail") {
		base.obj = this;
	
					EMId = new EMail_EMId(this);
					EMName = new EMail_EMName(this);
					EMFrom = new EMail_EMFrom(this);
					EMDS = new EMail_EMDS(this);
					EMTo = new EMail_EMTo(this);
					EMCC = new EMail_EMCC(this);
					EMSubject = new EMail_EMSubject(this);
					EMBody = new EMail_EMBody(this);
					EMAttach = new EMail_EMAttach(this);
					EMStatus = new EMail_EMStatus(this);
					EMDateSent = new EMail_EMDateSent(this);
					EMToRecords = new EMail_EMToRecords(this);
					EMDF = new EMail_EMDF(this);
					EMCCRecords = new EMail_EMCCRecords(this);
					EMBCC = new EMail_EMBCC(this);
					EMBCCRecords = new EMail_EMBCCRecords(this);
			}

	static EMail () {
					EMIdField = new EMail_EMIdFieldDef();
					EMNameField = new EMail_EMNameFieldDef();
					EMFromField = new EMail_EMFromFieldDef();
					EMDSField = new EMail_EMDSFieldDef();
					EMToField = new EMail_EMToFieldDef();
					EMCCField = new EMail_EMCCFieldDef();
					EMSubjectField = new EMail_EMSubjectFieldDef();
					EMBodyField = new EMail_EMBodyFieldDef();
					EMAttachField = new EMail_EMAttachFieldDef();
					EMStatusField = new EMail_EMStatusFieldDef();
					EMDateSentField = new EMail_EMDateSentFieldDef();
					EMToRecordsField = new EMail_EMToRecordsFieldDef();
					EMDFField = new EMail_EMDFFieldDef();
					EMCCRecordsField = new EMail_EMCCRecordsFieldDef();
					EMBCCField = new EMail_EMBCCFieldDef();
					EMBCCRecordsField = new EMail_EMBCCRecordsFieldDef();
			}

	public string RecordTitle { 
		get { return EMSubjectValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "E-mails"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/EMail/Load/?RecId=" + RecordID.Value;
			}
			return "/EMail/Add";
			}
	}

			
		
		[Ignore()]
		public EMail_EMId EMId { get; set; }
		public static EMail_EMIdFieldDef EMIdField { get; private set; }
        
			
			[Column("EMId")]
			public  int PopulateEMId  {
				get { return EMIdValue ;}
				set { EMId.DataValue = value; }
			}

			public int Id {
			get { return EMIdValue ; }
			set { EMIdValue  = value; } 
		}
		[IQFieldName("EMId")]
		public IDSFieldBase  IdField { 
			get { return (IDSFieldBase)EMId; } 
			set { EMId = (EMail_EMId)value; }
		}
	
			public int EMIdValue 
			{ 
				get 
				{
				   if(EMId.Value != null) {
				   					int i = 0;
					if (EMId != null)
					{
						if (EMId.Value != null)
						{
							if (Int32.TryParse(EMId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { EMId.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMName EMName { get; set; }
		public static EMail_EMNameFieldDef EMNameField { get; private set; }
        
			
			[Column("EMName")]
			public  int PopulateEMName  {
				get { return EMNameValue ;}
				set { EMName.DataValue = value; }
			}

			public int TemplateId {
			get { return EMNameValue ; }
			set { EMNameValue  = value; } 
		}
		[IQFieldName("EMName")]
		public IDSFieldBase  TemplateIdField { 
			get { return (IDSFieldBase)EMName; } 
			set { EMName = (EMail_EMName)value; }
		}
	
			public int EMNameValue 
			{ 
				get 
				{
				   if(EMName.Value != null) {
				   					int i = 0;
					if (EMName != null)
					{
						if (EMName.Value != null)
						{
							if (Int32.TryParse(EMName.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { EMName.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMFrom EMFrom { get; set; }
		public static EMail_EMFromFieldDef EMFromField { get; private set; }
        
			
			[Column("EMFrom")]
			public  string PopulateEMFrom  {
				get { return EMFromValue ;}
				set { EMFrom.DataValue = value; }
			}

			public string FromAddress {
			get { return EMFromValue ; }
			set { EMFromValue  = value; } 
		}
		[IQFieldName("EMFrom")]
		public IDSFieldBase  FromAddressField { 
			get { return (IDSFieldBase)EMFrom; } 
			set { EMFrom = (EMail_EMFrom)value; }
		}
	
			public string EMFromValue 
			{ 
				get 
				{
				   if(EMFrom.Value != null) {
				   return EMFrom.Value.ToString(); 					}
					return "";
                
				}
				set { EMFrom.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMDS EMDS { get; set; }
		public static EMail_EMDSFieldDef EMDSField { get; private set; }
        
			
			[Column("EMDS")]
			public  string PopulateEMDS  {
				get { return EMDSValue ;}
				set { EMDS.DataValue = value; }
			}

			public string Dataset {
			get { return EMDSValue ; }
			set { EMDSValue  = value; } 
		}
		[IQFieldName("EMDS")]
		public IDSFieldBase  DatasetField { 
			get { return (IDSFieldBase)EMDS; } 
			set { EMDS = (EMail_EMDS)value; }
		}
	
			public string EMDSValue 
			{ 
				get 
				{
				   if(EMDS.Value != null) {
				   return EMDS.Value.ToString(); 					}
					return "";
                
				}
				set { EMDS.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMTo EMTo { get; set; }
		public static EMail_EMToFieldDef EMToField { get; private set; }
        
			
			[Column("EMTo")]
			public  string PopulateEMTo  {
				get { return EMToValue ;}
				set { EMTo.DataValue = value; }
			}

			public string ToAddress {
			get { return EMToValue ; }
			set { EMToValue  = value; } 
		}
		[IQFieldName("EMTo")]
		public IDSFieldBase  ToAddressField { 
			get { return (IDSFieldBase)EMTo; } 
			set { EMTo = (EMail_EMTo)value; }
		}
	
			public string EMToValue 
			{ 
				get 
				{
				   if(EMTo.Value != null) {
				   return EMTo.Value.ToString(); 					}
					return "";
                
				}
				set { EMTo.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMCC EMCC { get; set; }
		public static EMail_EMCCFieldDef EMCCField { get; private set; }
        
			
			[Column("EMCC")]
			public  string PopulateEMCC  {
				get { return EMCCValue ;}
				set { EMCC.DataValue = value; }
			}

			public string CCAddress {
			get { return EMCCValue ; }
			set { EMCCValue  = value; } 
		}
		[IQFieldName("EMCC")]
		public IDSFieldBase  CCAddressField { 
			get { return (IDSFieldBase)EMCC; } 
			set { EMCC = (EMail_EMCC)value; }
		}
	
			public string EMCCValue 
			{ 
				get 
				{
				   if(EMCC.Value != null) {
				   return EMCC.Value.ToString(); 					}
					return "";
                
				}
				set { EMCC.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMSubject EMSubject { get; set; }
		public static EMail_EMSubjectFieldDef EMSubjectField { get; private set; }
        
			
			[Column("EMSubject")]
			public  string PopulateEMSubject  {
				get { return EMSubjectValue ;}
				set { EMSubject.DataValue = value; }
			}

			public string Subject {
			get { return EMSubjectValue ; }
			set { EMSubjectValue  = value; } 
		}
		[IQFieldName("EMSubject")]
		public IDSFieldBase  SubjectField { 
			get { return (IDSFieldBase)EMSubject; } 
			set { EMSubject = (EMail_EMSubject)value; }
		}
	
			public string EMSubjectValue 
			{ 
				get 
				{
				   if(EMSubject.Value != null) {
				   return EMSubject.Value.ToString(); 					}
					return "";
                
				}
				set { EMSubject.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMBody EMBody { get; set; }
		public static EMail_EMBodyFieldDef EMBodyField { get; private set; }
        
			
			[Column("EMBody")]
			public  string PopulateEMBody  {
				get { return EMBodyValue ;}
				set { EMBody.DataValue = value; }
			}

			public string Body {
			get { return EMBodyValue ; }
			set { EMBodyValue  = value; } 
		}
		[IQFieldName("EMBody")]
		public IDSFieldBase  BodyField { 
			get { return (IDSFieldBase)EMBody; } 
			set { EMBody = (EMail_EMBody)value; }
		}
	
			public string EMBodyValue 
			{ 
				get 
				{
				   if(EMBody.Value != null) {
				   return EMBody.Value.ToString(); 					}
					return "";
                
				}
				set { EMBody.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMAttach EMAttach { get; set; }
		public static EMail_EMAttachFieldDef EMAttachField { get; private set; }
        
			
			[Column("EMAttach")]
			public  string PopulateEMAttach  {
				get { return EMAttachValue ;}
				set { EMAttach.DataValue = value; }
			}

			public string Attachments {
			get { return EMAttachValue ; }
			set { EMAttachValue  = value; } 
		}
		[IQFieldName("EMAttach")]
		public IDSFieldBase  AttachmentsField { 
			get { return (IDSFieldBase)EMAttach; } 
			set { EMAttach = (EMail_EMAttach)value; }
		}
	
			public string EMAttachValue 
			{ 
				get 
				{
				   if(EMAttach.Value != null) {
				   return EMAttach.Value.ToString(); 					}
					return "";
                
				}
				set { EMAttach.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMStatus EMStatus { get; set; }
		public static EMail_EMStatusFieldDef EMStatusField { get; private set; }
        
			
			[Column("EMStatus")]
			public  int PopulateEMStatus  {
				get { return EMStatusValue ;}
				set { EMStatus.DataValue = value; }
			}

	
			public int EMStatusValue 
			{ 
				get 
				{
				   if(EMStatus.Value != null) {
				   					int i = 0;
					if (EMStatus != null)
					{
						if (EMStatus.Value != null)
						{
							if (Int32.TryParse(EMStatus.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { EMStatus.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMDateSent EMDateSent { get; set; }
		public static EMail_EMDateSentFieldDef EMDateSentField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("EMDateSent")]
			public  DateTime PopulateEMDateSent  {
				get { return EMDateSentValue ;}
				set { EMDateSent.DataValue = value; }
			}

	
			public DateTime EMDateSentValue 
			{ 
				get 
				{
				   if(EMDateSent.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (EMDateSent != null)
					{
						if (EMDateSent.Value != null)
						{
							if (DateTime.TryParse(EMDateSent.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { EMDateSent.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMToRecords EMToRecords { get; set; }
		public static EMail_EMToRecordsFieldDef EMToRecordsField { get; private set; }
        
			
			[Column("EMToRecords")]
			public  string PopulateEMToRecords  {
				get { return EMToRecordsValue ;}
				set { EMToRecords.DataValue = value; }
			}

			public string ToRecords {
			get { return EMToRecordsValue ; }
			set { EMToRecordsValue  = value; } 
		}
		[IQFieldName("EMToRecords")]
		public IDSFieldBase  ToRecordsField { 
			get { return (IDSFieldBase)EMToRecords; } 
			set { EMToRecords = (EMail_EMToRecords)value; }
		}
	
			public string EMToRecordsValue 
			{ 
				get 
				{
				   if(EMToRecords.Value != null) {
				   return EMToRecords.Value.ToString(); 					}
					return "";
                
				}
				set { EMToRecords.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMDF EMDF { get; set; }
		public static EMail_EMDFFieldDef EMDFField { get; private set; }
        
			
			[Column("EMDF")]
			public  string PopulateEMDF  {
				get { return EMDFValue ;}
				set { EMDF.DataValue = value; }
			}

			public string DataField {
			get { return EMDFValue ; }
			set { EMDFValue  = value; } 
		}
		[IQFieldName("EMDF")]
		public IDSFieldBase  DataFieldField { 
			get { return (IDSFieldBase)EMDF; } 
			set { EMDF = (EMail_EMDF)value; }
		}
	
			public string EMDFValue 
			{ 
				get 
				{
				   if(EMDF.Value != null) {
				   return EMDF.Value.ToString(); 					}
					return "";
                
				}
				set { EMDF.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMCCRecords EMCCRecords { get; set; }
		public static EMail_EMCCRecordsFieldDef EMCCRecordsField { get; private set; }
        
			
			[Column("EMCCRecords")]
			public  string PopulateEMCCRecords  {
				get { return EMCCRecordsValue ;}
				set { EMCCRecords.DataValue = value; }
			}

			public string CCRecords {
			get { return EMCCRecordsValue ; }
			set { EMCCRecordsValue  = value; } 
		}
		[IQFieldName("EMCCRecords")]
		public IDSFieldBase  CCRecordsField { 
			get { return (IDSFieldBase)EMCCRecords; } 
			set { EMCCRecords = (EMail_EMCCRecords)value; }
		}
	
			public string EMCCRecordsValue 
			{ 
				get 
				{
				   if(EMCCRecords.Value != null) {
				   return EMCCRecords.Value.ToString(); 					}
					return "";
                
				}
				set { EMCCRecords.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMBCC EMBCC { get; set; }
		public static EMail_EMBCCFieldDef EMBCCField { get; private set; }
        
			
			[Column("EMBCC")]
			public  string PopulateEMBCC  {
				get { return EMBCCValue ;}
				set { EMBCC.DataValue = value; }
			}

			public string BCCAddress {
			get { return EMBCCValue ; }
			set { EMBCCValue  = value; } 
		}
		[IQFieldName("EMBCC")]
		public IDSFieldBase  BCCAddressField { 
			get { return (IDSFieldBase)EMBCC; } 
			set { EMBCC = (EMail_EMBCC)value; }
		}
	
			public string EMBCCValue 
			{ 
				get 
				{
				   if(EMBCC.Value != null) {
				   return EMBCC.Value.ToString(); 					}
					return "";
                
				}
				set { EMBCC.Value = value;  }
			}
			
		
		[Ignore()]
		public EMail_EMBCCRecords EMBCCRecords { get; set; }
		public static EMail_EMBCCRecordsFieldDef EMBCCRecordsField { get; private set; }
        
			
			[Column("EMBCCRecords")]
			public  string PopulateEMBCCRecords  {
				get { return EMBCCRecordsValue ;}
				set { EMBCCRecords.DataValue = value; }
			}

			public string BCCRecords {
			get { return EMBCCRecordsValue ; }
			set { EMBCCRecordsValue  = value; } 
		}
		[IQFieldName("EMBCCRecords")]
		public IDSFieldBase  BCCRecordsField { 
			get { return (IDSFieldBase)EMBCCRecords; } 
			set { EMBCCRecords = (EMail_EMBCCRecords)value; }
		}
	
			public string EMBCCRecordsValue 
			{ 
				get 
				{
				   if(EMBCCRecords.Value != null) {
				   return EMBCCRecords.Value.ToString(); 					}
					return "";
                
				}
				set { EMBCCRecords.Value = value;  }
			}
	}


public class EMail_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 45;
    public int PixelHeight => 0;
	public string Title => "E-mails";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
