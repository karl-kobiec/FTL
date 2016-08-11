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


public partial class ChangeReqController : DSBaseController<ChangeReq/*,ChangeReqSearch*/> {
	public ChangeReqController() : base ((IDatabase)IQApp.DB, new ChangeReqRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select CRId from ChangeReq where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<ChangeReq>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(ChangeReq data) {
						IQApp.DB.Execute("Delete from ChangeReq where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.CRNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from ChangeReq " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from ChangeReq " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from ChangeReq " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/ChangeReq_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<ChangeReq>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<ChangeReq>("select * from ChangeReq  ").ToList();
		string urlpath = "/temp/Change Requests Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Change Requests");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 2])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 100;
					worksheet.Cells[1, 1].Value = "Title";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].CRName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CRIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRId" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRId(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRId" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CRNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRName" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRName(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRName" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CRTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRType" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCRType(ChangeReq m, int? id, string q) {

		
		string s = m.CRType.DataSource;
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
	public ActionResult CallbackCRType(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRType" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRPriority(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CRPriorityValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRPriority" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRPriority")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCRPriority(ChangeReq m, int? id, string q) {

		
		string s = m.CRPriority.DataSource;
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
	public ActionResult CallbackCRPriority(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRPriority" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRPriority")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRStatus(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CRStatusValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRStatus" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRStatus")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCRStatus(ChangeReq m, int? id, string q) {

		
		string s = m.CRStatus.DataSource;
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
	public ActionResult CallbackCRStatus(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRStatus" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRStatus")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CRDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRDate" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRDate(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRDate" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRClosed(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CRClosedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRClosed" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRClosed")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRClosed(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRClosed" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRClosed")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRIssues(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CRIssuesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIssues" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIssues")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRIssues(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIssues" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIssues")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRIqNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CRIqNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotes" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRIqNotes(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotes" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRResolved(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CRResolvedValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRResolved" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRResolved")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRResolved(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRResolved" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRResolved")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCRIqNotesArch(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ChangeReq>("select * from ChangeReq where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CRIqNotesArchValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotesArch" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotesArch")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCRIqNotesArch(ChangeReq obj) {
			
		if(DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotesArch" ).Any()) {
			foreach(var itm in DS.GetManager<ChangeReq>().OnChange.Where(f=> f.Key == "CRIqNotesArch")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ChangeReq>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/ChangeReq/List/");
	}

}

public partial class ChangeReqRepository : DSRepository<ChangeReq> {
	public ChangeReqRepository() : base(43, "ChangeReq", "Change Requests") {
	}
}
public partial class ChangeReq 
: DatasetBase<ChangeReq>, IDSBase

  {
	  public int KeyValue => CRIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "CRId":
			return CRIdField;
				case "CRName":
			return CRNameField;
				case "CRType":
			return CRTypeField;
				case "CRPriority":
			return CRPriorityField;
				case "CRStatus":
			return CRStatusField;
				case "CRDate":
			return CRDateField;
				case "CRClosed":
			return CRClosedField;
				case "CRIssues":
			return CRIssuesField;
				case "CRIqNotes":
			return CRIqNotesField;
				case "CRResolved":
			return CRResolvedField;
				case "CRIqNotesArch":
			return CRIqNotesArchField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(CRId,CRIdField);
				action(CRName,CRNameField);
				action(CRType,CRTypeField);
				action(CRPriority,CRPriorityField);
				action(CRStatus,CRStatusField);
				action(CRDate,CRDateField);
				action(CRClosed,CRClosedField);
				action(CRIssues,CRIssuesField);
				action(CRIqNotes,CRIqNotesField);
				action(CRResolved,CRResolvedField);
				action(CRIqNotesArch,CRIqNotesArchField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				CRId.Visible=false;CRName.Visible=false;CRType.Visible=false;CRPriority.Visible=false;CRStatus.Visible=false;CRDate.Visible=false;CRClosed.Visible=false;CRIssues.Visible=false;CRIqNotes.Visible=false;CRResolved.Visible=false;CRIqNotesArch.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update ChangeReq set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (CRId.HasChanged && CRId.HasValue) {
					SQL += ", CRId=@CRIdValue";

				}
								if (CRName.HasChanged && CRName.HasValue) {
					SQL += ", CRName=@CRNameValue";

				}
								if (CRType.HasChanged && CRType.HasValue) {
					SQL += ", CRType=@CRTypeValue";

				}
								if (CRPriority.HasChanged && CRPriority.HasValue) {
					SQL += ", CRPriority=@CRPriorityValue";

				}
								if (CRStatus.HasChanged && CRStatus.HasValue) {
					SQL += ", CRStatus=@CRStatusValue";

				}
								if (CRDate.HasChanged && CRDate.HasValue) {
					SQL += ", CRDate=@CRDateValue";

				}
								if (CRClosed.HasChanged && CRClosed.HasValue) {
					SQL += ", CRClosed=@CRClosedValue";

				}
								if (CRIssues.HasChanged && CRIssues.HasValue) {
					SQL += ", CRIssues=@CRIssuesValue";

				}
								if (CRIqNotes.HasChanged && CRIqNotes.HasValue) {
					SQL += ", CRIqNotes=@CRIqNotesValue";

				}
								if (CRResolved.HasChanged && CRResolved.HasValue) {
					SQL += ", CRResolved=@CRResolvedValue";

				}
								if (CRIqNotesArch.HasChanged && CRIqNotesArch.HasValue) {
					SQL += ", CRIqNotesArch=@CRIqNotesArchValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									CRId.HasChanged = false;
									CRName.HasChanged = false;
									CRType.HasChanged = false;
									CRPriority.HasChanged = false;
									CRStatus.HasChanged = false;
									CRDate.HasChanged = false;
									CRClosed.HasChanged = false;
									CRIssues.HasChanged = false;
									CRIqNotes.HasChanged = false;
									CRResolved.HasChanged = false;
									CRIqNotesArch.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into ChangeReq(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				CRId.Value = IQApp.DB.GetInt("select isnull(max(CRId),0)+1 from ChangeReq");
				if (CRId.HasValue) {
					SQL += ", CRId";
					Values += ", @CRIdValue";
				}
				
				if (CRName.HasValue) {
					SQL += ", CRName";
					Values += ", @CRNameValue";
				}
				
				if (CRType.HasValue) {
					SQL += ", CRType";
					Values += ", @CRTypeValue";
				}
				
				if (CRPriority.HasValue) {
					SQL += ", CRPriority";
					Values += ", @CRPriorityValue";
				}
				
				if (CRStatus.HasValue) {
					SQL += ", CRStatus";
					Values += ", @CRStatusValue";
				}
				
				if (CRDate.HasValue) {
					SQL += ", CRDate";
					Values += ", @CRDateValue";
				}
				
				if (CRClosed.HasValue) {
					SQL += ", CRClosed";
					Values += ", @CRClosedValue";
				}
				
				if (CRIssues.HasValue) {
					SQL += ", CRIssues";
					Values += ", @CRIssuesValue";
				}
				
				if (CRIqNotes.HasValue) {
					SQL += ", CRIqNotes";
					Values += ", @CRIqNotesValue";
				}
				
				if (CRResolved.HasValue) {
					SQL += ", CRResolved";
					Values += ", @CRResolvedValue";
				}
				
				if (CRIqNotesArch.HasValue) {
					SQL += ", CRIqNotesArch";
					Values += ", @CRIqNotesArchValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from ChangeReq");
					 IQApp.DB.Execute(SQL, this);
				                    					CRId.HasChanged = false;
									CRName.HasChanged = false;
									CRType.HasChanged = false;
									CRPriority.HasChanged = false;
									CRStatus.HasChanged = false;
									CRDate.HasChanged = false;
									CRClosed.HasChanged = false;
									CRIssues.HasChanged = false;
									CRIqNotes.HasChanged = false;
									CRResolved.HasChanged = false;
									CRIqNotesArch.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "CRId":
					return (IDSFieldBase)CRId;
								case "CRName":
					return (IDSFieldBase)CRName;
								case "CRType":
					return (IDSFieldBase)CRType;
								case "CRPriority":
					return (IDSFieldBase)CRPriority;
								case "CRStatus":
					return (IDSFieldBase)CRStatus;
								case "CRDate":
					return (IDSFieldBase)CRDate;
								case "CRClosed":
					return (IDSFieldBase)CRClosed;
								case "CRIssues":
					return (IDSFieldBase)CRIssues;
								case "CRIqNotes":
					return (IDSFieldBase)CRIqNotes;
								case "CRResolved":
					return (IDSFieldBase)CRResolved;
								case "CRIqNotesArch":
					return (IDSFieldBase)CRIqNotesArch;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "CRId":
					return CRId.DisplayValue;
								case "CRName":
					return CRName.DisplayValue;
								case "CRType":
					return CRType.DisplayValue;
								case "CRPriority":
					return CRPriority.DisplayValue;
								case "CRStatus":
					return CRStatus.DisplayValue;
								case "CRDate":
					return CRDate.DisplayValue;
								case "CRClosed":
					return CRClosed.DisplayValue;
								case "CRIssues":
					return CRIssues.DisplayValue;
								case "CRIqNotes":
					return CRIqNotes.DisplayValue;
								case "CRResolved":
					return CRResolved.DisplayValue;
								case "CRIqNotesArch":
					return CRIqNotesArch.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "CRId":
					return CRId.Value.ToString();
								case "CRName":
					return CRName.Value.ToString();
								case "CRType":
					return CRType.Value.ToString();
								case "CRPriority":
					return CRPriority.Value.ToString();
								case "CRStatus":
					return CRStatus.Value.ToString();
								case "CRDate":
					return CRDate.Value.ToString();
								case "CRClosed":
					return CRClosed.Value.ToString();
								case "CRIssues":
					return CRIssues.Value.ToString();
								case "CRIqNotes":
					return CRIqNotes.Value.ToString();
								case "CRResolved":
					return CRResolved.Value.ToString();
								case "CRIqNotesArch":
					return CRIqNotesArch.Value.ToString();
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
					foreach(var itm in DS.GetManager<ChangeReq>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public ChangeReq () : base("ChangeReq") {
		base.obj = this;
	
					CRId = new ChangeReq_CRId(this);
					CRName = new ChangeReq_CRName(this);
					CRType = new ChangeReq_CRType(this);
					CRPriority = new ChangeReq_CRPriority(this);
					CRStatus = new ChangeReq_CRStatus(this);
					CRDate = new ChangeReq_CRDate(this);
					CRClosed = new ChangeReq_CRClosed(this);
					CRIssues = new ChangeReq_CRIssues(this);
					CRIqNotes = new ChangeReq_CRIqNotes(this);
					CRResolved = new ChangeReq_CRResolved(this);
					CRIqNotesArch = new ChangeReq_CRIqNotesArch(this);
			}

	static ChangeReq () {
					CRIdField = new ChangeReq_CRIdFieldDef();
					CRNameField = new ChangeReq_CRNameFieldDef();
					CRTypeField = new ChangeReq_CRTypeFieldDef();
					CRPriorityField = new ChangeReq_CRPriorityFieldDef();
					CRStatusField = new ChangeReq_CRStatusFieldDef();
					CRDateField = new ChangeReq_CRDateFieldDef();
					CRClosedField = new ChangeReq_CRClosedFieldDef();
					CRIssuesField = new ChangeReq_CRIssuesFieldDef();
					CRIqNotesField = new ChangeReq_CRIqNotesFieldDef();
					CRResolvedField = new ChangeReq_CRResolvedFieldDef();
					CRIqNotesArchField = new ChangeReq_CRIqNotesArchFieldDef();
			}

	public string RecordTitle { 
		get { return CRNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Change Requests"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/ChangeReq/Load/?RecId=" + RecordID.Value;
			}
			return "/ChangeReq/Add";
			}
	}

			
		
		[Ignore()]
		public ChangeReq_CRId CRId { get; set; }
		public static ChangeReq_CRIdFieldDef CRIdField { get; private set; }
        
			
			[Column("CRId")]
			public  int PopulateCRId  {
				get { return CRIdValue ;}
				set { CRId.DataValue = value; }
			}

	
			public int CRIdValue 
			{ 
				get 
				{
				   if(CRId.Value != null) {
				   					int i = 0;
					if (CRId != null)
					{
						if (CRId.Value != null)
						{
							if (Int32.TryParse(CRId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CRId.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRName CRName { get; set; }
		public static ChangeReq_CRNameFieldDef CRNameField { get; private set; }
        
			
			[Column("CRName")]
			public  string PopulateCRName  {
				get { return CRNameValue ;}
				set { CRName.DataValue = value; }
			}

	
			public string CRNameValue 
			{ 
				get 
				{
				   if(CRName.Value != null) {
				   return CRName.Value.ToString(); 					}
					return "";
                
				}
				set { CRName.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRType CRType { get; set; }
		public static ChangeReq_CRTypeFieldDef CRTypeField { get; private set; }
        
			
			[Column("CRType")]
			public  int PopulateCRType  {
				get { return CRTypeValue ;}
				set { CRType.DataValue = value; }
			}

	
			public int CRTypeValue 
			{ 
				get 
				{
				   if(CRType.Value != null) {
				   					int i = 0;
					if (CRType != null)
					{
						if (CRType.Value != null)
						{
							if (Int32.TryParse(CRType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CRType.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRPriority CRPriority { get; set; }
		public static ChangeReq_CRPriorityFieldDef CRPriorityField { get; private set; }
        
			
			[Column("CRPriority")]
			public  int PopulateCRPriority  {
				get { return CRPriorityValue ;}
				set { CRPriority.DataValue = value; }
			}

	
			public int CRPriorityValue 
			{ 
				get 
				{
				   if(CRPriority.Value != null) {
				   					int i = 0;
					if (CRPriority != null)
					{
						if (CRPriority.Value != null)
						{
							if (Int32.TryParse(CRPriority.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CRPriority.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRStatus CRStatus { get; set; }
		public static ChangeReq_CRStatusFieldDef CRStatusField { get; private set; }
        
			
			[Column("CRStatus")]
			public  int PopulateCRStatus  {
				get { return CRStatusValue ;}
				set { CRStatus.DataValue = value; }
			}

	
			public int CRStatusValue 
			{ 
				get 
				{
				   if(CRStatus.Value != null) {
				   					int i = 0;
					if (CRStatus != null)
					{
						if (CRStatus.Value != null)
						{
							if (Int32.TryParse(CRStatus.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CRStatus.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRDate CRDate { get; set; }
		public static ChangeReq_CRDateFieldDef CRDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("CRDate")]
			public  DateTime PopulateCRDate  {
				get { return CRDateValue ;}
				set { CRDate.DataValue = value; }
			}

	
			public DateTime CRDateValue 
			{ 
				get 
				{
				   if(CRDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (CRDate != null)
					{
						if (CRDate.Value != null)
						{
							if (DateTime.TryParse(CRDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { CRDate.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRClosed CRClosed { get; set; }
		public static ChangeReq_CRClosedFieldDef CRClosedField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("CRClosed")]
			public  DateTime PopulateCRClosed  {
				get { return CRClosedValue ;}
				set { CRClosed.DataValue = value; }
			}

	
			public DateTime CRClosedValue 
			{ 
				get 
				{
				   if(CRClosed.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (CRClosed != null)
					{
						if (CRClosed.Value != null)
						{
							if (DateTime.TryParse(CRClosed.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { CRClosed.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRIssues CRIssues { get; set; }
		public static ChangeReq_CRIssuesFieldDef CRIssuesField { get; private set; }
        
			
			[Column("CRIssues")]
			public  string PopulateCRIssues  {
				get { return CRIssuesValue ;}
				set { CRIssues.DataValue = value; }
			}

	
			public string CRIssuesValue 
			{ 
				get 
				{
				   if(CRIssues.Value != null) {
				   return CRIssues.Value.ToString(); 					}
					return "";
                
				}
				set { CRIssues.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRIqNotes CRIqNotes { get; set; }
		public static ChangeReq_CRIqNotesFieldDef CRIqNotesField { get; private set; }
        
			
			[Column("CRIqNotes")]
			public  string PopulateCRIqNotes  {
				get { return CRIqNotesValue ;}
				set { CRIqNotes.DataValue = value; }
			}

	
			public string CRIqNotesValue 
			{ 
				get 
				{
				   if(CRIqNotes.Value != null) {
				   return CRIqNotes.Value.ToString(); 					}
					return "";
                
				}
				set { CRIqNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRResolved CRResolved { get; set; }
		public static ChangeReq_CRResolvedFieldDef CRResolvedField { get; private set; }
        
			
			[Column("CRResolved")]
			public  string PopulateCRResolved  {
				get { return CRResolvedValue ;}
				set { CRResolved.DataValue = value; }
			}

	
			public string CRResolvedValue 
			{ 
				get 
				{
				   if(CRResolved.Value != null) {
				   return CRResolved.Value.ToString(); 					}
					return "";
                
				}
				set { CRResolved.Value = value;  }
			}
			
		
		[Ignore()]
		public ChangeReq_CRIqNotesArch CRIqNotesArch { get; set; }
		public static ChangeReq_CRIqNotesArchFieldDef CRIqNotesArchField { get; private set; }
        
			
			[Column("CRIqNotesArch")]
			public  string PopulateCRIqNotesArch  {
				get { return CRIqNotesArchValue ;}
				set { CRIqNotesArch.DataValue = value; }
			}

	
			public string CRIqNotesArchValue 
			{ 
				get 
				{
				   if(CRIqNotesArch.Value != null) {
				   return CRIqNotesArch.Value.ToString(); 					}
					return "";
                
				}
				set { CRIqNotesArch.Value = value;  }
			}
	}


public class ChangeReq_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 43;
    public int PixelHeight => 0;
	public string Title => "Change Requests";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
