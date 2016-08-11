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


public partial class SMSController : DSBaseController<SMS/*,SMSSearch*/> {
	public SMSController() : base ((IDatabase)IQApp.DB, new SMSRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select SMSId from SMS where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<SMS>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(SMS data) {
						IQApp.DB.Execute("Delete from SMS where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.SMSDestinationValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from SMS " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from SMS " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from SMS " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/SMS_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<SMS>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<SMS>("select * from SMS  ").ToList();
		string urlpath = "/temp/SMS Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("SMS");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 1])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
			
				for(int j = 0; j < res.Count(); j++) {
					
									
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SMSIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSId" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSId(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSId" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSContent(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSContentValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSContent" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSContent")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSContent(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSContent" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSContent")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSDestination(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSDestinationValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDestination" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDestination")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSDestination(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDestination" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDestination")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSDataset(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSDatasetValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDataset" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDataset")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSDataset(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDataset" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDataset")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSRecordID(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SMSRecordIDValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSRecordID" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSRecordID")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSRecordID(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSRecordID" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSRecordID")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSDateQueued(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SMSDateQueuedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateQueued" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateQueued")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSDateQueued(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateQueued" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateQueued")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSDateConfirmed(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.SMSDateConfirmedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateConfirmed" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateConfirmed")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSDateConfirmed(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateConfirmed" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSDateConfirmed")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSStatus(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SMSStatusValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatus" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatus")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSMSStatus(SMS m, int? id, string q) {

		
		string s = m.SMSStatus.DataSource;
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
	public ActionResult CallbackSMSStatus(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatus" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatus")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSStatusMsg(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSStatusMsgValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatusMsg" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatusMsg")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSStatusMsg(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatusMsg" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSStatusMsg")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSSender(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSSenderValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSSender" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSSender")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSSender(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSSender" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSSender")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTemplate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMS>("select * from SMS where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SMSTemplateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSTemplate" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSTemplate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSMSTemplate(SMS m, int? id, string q) {

		
		string s = m.SMSTemplate.DataSource;
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
	public ActionResult CallbackSMSTemplate(SMS obj) {
			
		if(DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSTemplate" ).Any()) {
			foreach(var itm in DS.GetManager<SMS>().OnChange.Where(f=> f.Key == "SMSTemplate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMS>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/SMS/List/");
	}

}

public partial class SMSRepository : DSRepository<SMS> {
	public SMSRepository() : base(52, "SMS", "SMS") {
	}
}
public partial class SMS 
: DatasetBase<SMS>, IDSBase
, Intrinsiq.SMS.ISMS
  {
	  public int KeyValue => SMSIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "SMSId":
			return SMSIdField;
				case "SMSContent":
			return SMSContentField;
				case "SMSDestination":
			return SMSDestinationField;
				case "SMSDataset":
			return SMSDatasetField;
				case "SMSRecordID":
			return SMSRecordIDField;
				case "SMSDateQueued":
			return SMSDateQueuedField;
				case "SMSDateConfirmed":
			return SMSDateConfirmedField;
				case "SMSStatus":
			return SMSStatusField;
				case "SMSStatusMsg":
			return SMSStatusMsgField;
				case "SMSSender":
			return SMSSenderField;
				case "SMSTemplate":
			return SMSTemplateField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(SMSId,SMSIdField);
				action(SMSContent,SMSContentField);
				action(SMSDestination,SMSDestinationField);
				action(SMSDataset,SMSDatasetField);
				action(SMSRecordID,SMSRecordIDField);
				action(SMSDateQueued,SMSDateQueuedField);
				action(SMSDateConfirmed,SMSDateConfirmedField);
				action(SMSStatus,SMSStatusField);
				action(SMSStatusMsg,SMSStatusMsgField);
				action(SMSSender,SMSSenderField);
				action(SMSTemplate,SMSTemplateField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				SMSId.Visible=false;SMSContent.Visible=false;SMSDestination.Visible=false;SMSDataset.Visible=false;SMSRecordID.Visible=false;SMSDateQueued.Visible=false;SMSDateConfirmed.Visible=false;SMSStatus.Visible=false;SMSStatusMsg.Visible=false;SMSSender.Visible=false;SMSTemplate.Visible=false;			break;
					case 3:
				SMSId.Visible=false;SMSContent.Visible=false;SMSDestination.Visible=false;SMSDataset.Visible=false;SMSRecordID.Visible=false;SMSDateQueued.Visible=false;SMSDateConfirmed.Visible=false;SMSStatus.Visible=false;SMSStatusMsg.Visible=false;SMSSender.Visible=false;SMSTemplate.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update SMS set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (SMSId.HasChanged && SMSId.HasValue) {
					SQL += ", SMSId=@SMSIdValue";

				}
								if (SMSContent.HasChanged && SMSContent.HasValue) {
					SQL += ", SMSContent=@SMSContentValue";

				}
								if (SMSDestination.HasChanged && SMSDestination.HasValue) {
					SQL += ", SMSDestination=@SMSDestinationValue";

				}
								if (SMSDataset.HasChanged && SMSDataset.HasValue) {
					SQL += ", SMSDataset=@SMSDatasetValue";

				}
								if (SMSRecordID.HasChanged && SMSRecordID.HasValue) {
					SQL += ", SMSRecordID=@SMSRecordIDValue";

				}
								if (SMSDateQueued.HasChanged && SMSDateQueued.HasValue) {
					SQL += ", SMSDateQueued=@SMSDateQueuedValue";

				}
								if (SMSDateConfirmed.HasChanged && SMSDateConfirmed.HasValue) {
					SQL += ", SMSDateConfirmed=@SMSDateConfirmedValue";

				}
								if (SMSStatus.HasChanged && SMSStatus.HasValue) {
					SQL += ", SMSStatus=@SMSStatusValue";

				}
								if (SMSStatusMsg.HasChanged && SMSStatusMsg.HasValue) {
					SQL += ", SMSStatusMsg=@SMSStatusMsgValue";

				}
								if (SMSSender.HasChanged && SMSSender.HasValue) {
					SQL += ", SMSSender=@SMSSenderValue";

				}
								if (SMSTemplate.HasChanged && SMSTemplate.HasValue) {
					SQL += ", SMSTemplate=@SMSTemplateValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									SMSId.HasChanged = false;
									SMSContent.HasChanged = false;
									SMSDestination.HasChanged = false;
									SMSDataset.HasChanged = false;
									SMSRecordID.HasChanged = false;
									SMSDateQueued.HasChanged = false;
									SMSDateConfirmed.HasChanged = false;
									SMSStatus.HasChanged = false;
									SMSStatusMsg.HasChanged = false;
									SMSSender.HasChanged = false;
									SMSTemplate.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into SMS(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				SMSId.Value = IQApp.DB.GetInt("select isnull(max(SMSId),0)+1 from SMS");
				if (SMSId.HasValue) {
					SQL += ", SMSId";
					Values += ", @SMSIdValue";
				}
				
				if (SMSContent.HasValue) {
					SQL += ", SMSContent";
					Values += ", @SMSContentValue";
				}
				
				if (SMSDestination.HasValue) {
					SQL += ", SMSDestination";
					Values += ", @SMSDestinationValue";
				}
				
				if (SMSDataset.HasValue) {
					SQL += ", SMSDataset";
					Values += ", @SMSDatasetValue";
				}
				
				if (SMSRecordID.HasValue) {
					SQL += ", SMSRecordID";
					Values += ", @SMSRecordIDValue";
				}
				
				if (SMSDateQueued.HasValue) {
					SQL += ", SMSDateQueued";
					Values += ", @SMSDateQueuedValue";
				}
				
				if (SMSDateConfirmed.HasValue) {
					SQL += ", SMSDateConfirmed";
					Values += ", @SMSDateConfirmedValue";
				}
				
				if (SMSStatus.HasValue) {
					SQL += ", SMSStatus";
					Values += ", @SMSStatusValue";
				}
				
				if (SMSStatusMsg.HasValue) {
					SQL += ", SMSStatusMsg";
					Values += ", @SMSStatusMsgValue";
				}
				
				if (SMSSender.HasValue) {
					SQL += ", SMSSender";
					Values += ", @SMSSenderValue";
				}
				
				if (SMSTemplate.HasValue) {
					SQL += ", SMSTemplate";
					Values += ", @SMSTemplateValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from SMS");
					 IQApp.DB.Execute(SQL, this);
				                    					SMSId.HasChanged = false;
									SMSContent.HasChanged = false;
									SMSDestination.HasChanged = false;
									SMSDataset.HasChanged = false;
									SMSRecordID.HasChanged = false;
									SMSDateQueued.HasChanged = false;
									SMSDateConfirmed.HasChanged = false;
									SMSStatus.HasChanged = false;
									SMSStatusMsg.HasChanged = false;
									SMSSender.HasChanged = false;
									SMSTemplate.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "SMSId":
					return (IDSFieldBase)SMSId;
								case "SMSContent":
					return (IDSFieldBase)SMSContent;
								case "SMSDestination":
					return (IDSFieldBase)SMSDestination;
								case "SMSDataset":
					return (IDSFieldBase)SMSDataset;
								case "SMSRecordID":
					return (IDSFieldBase)SMSRecordID;
								case "SMSDateQueued":
					return (IDSFieldBase)SMSDateQueued;
								case "SMSDateConfirmed":
					return (IDSFieldBase)SMSDateConfirmed;
								case "SMSStatus":
					return (IDSFieldBase)SMSStatus;
								case "SMSStatusMsg":
					return (IDSFieldBase)SMSStatusMsg;
								case "SMSSender":
					return (IDSFieldBase)SMSSender;
								case "SMSTemplate":
					return (IDSFieldBase)SMSTemplate;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "SMSId":
					return SMSId.DisplayValue;
								case "SMSContent":
					return SMSContent.DisplayValue;
								case "SMSDestination":
					return SMSDestination.DisplayValue;
								case "SMSDataset":
					return SMSDataset.DisplayValue;
								case "SMSRecordID":
					return SMSRecordID.DisplayValue;
								case "SMSDateQueued":
					return SMSDateQueued.DisplayValue;
								case "SMSDateConfirmed":
					return SMSDateConfirmed.DisplayValue;
								case "SMSStatus":
					return SMSStatus.DisplayValue;
								case "SMSStatusMsg":
					return SMSStatusMsg.DisplayValue;
								case "SMSSender":
					return SMSSender.DisplayValue;
								case "SMSTemplate":
					return SMSTemplate.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "SMSId":
					return SMSId.Value.ToString();
								case "SMSContent":
					return SMSContent.Value.ToString();
								case "SMSDestination":
					return SMSDestination.Value.ToString();
								case "SMSDataset":
					return SMSDataset.Value.ToString();
								case "SMSRecordID":
					return SMSRecordID.Value.ToString();
								case "SMSDateQueued":
					return SMSDateQueued.Value.ToString();
								case "SMSDateConfirmed":
					return SMSDateConfirmed.Value.ToString();
								case "SMSStatus":
					return SMSStatus.Value.ToString();
								case "SMSStatusMsg":
					return SMSStatusMsg.Value.ToString();
								case "SMSSender":
					return SMSSender.Value.ToString();
								case "SMSTemplate":
					return SMSTemplate.Value.ToString();
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
					foreach(var itm in DS.GetManager<SMS>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public SMS () : base("SMS") {
		base.obj = this;
	
					SMSId = new SMS_SMSId(this);
					SMSContent = new SMS_SMSContent(this);
					SMSDestination = new SMS_SMSDestination(this);
					SMSDataset = new SMS_SMSDataset(this);
					SMSRecordID = new SMS_SMSRecordID(this);
					SMSDateQueued = new SMS_SMSDateQueued(this);
					SMSDateConfirmed = new SMS_SMSDateConfirmed(this);
					SMSStatus = new SMS_SMSStatus(this);
					SMSStatusMsg = new SMS_SMSStatusMsg(this);
					SMSSender = new SMS_SMSSender(this);
					SMSTemplate = new SMS_SMSTemplate(this);
			}

	static SMS () {
					SMSIdField = new SMS_SMSIdFieldDef();
					SMSContentField = new SMS_SMSContentFieldDef();
					SMSDestinationField = new SMS_SMSDestinationFieldDef();
					SMSDatasetField = new SMS_SMSDatasetFieldDef();
					SMSRecordIDField = new SMS_SMSRecordIDFieldDef();
					SMSDateQueuedField = new SMS_SMSDateQueuedFieldDef();
					SMSDateConfirmedField = new SMS_SMSDateConfirmedFieldDef();
					SMSStatusField = new SMS_SMSStatusFieldDef();
					SMSStatusMsgField = new SMS_SMSStatusMsgFieldDef();
					SMSSenderField = new SMS_SMSSenderFieldDef();
					SMSTemplateField = new SMS_SMSTemplateFieldDef();
			}

	public string RecordTitle { 
		get { return SMSDestinationValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "SMS"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/SMS/Load/?RecId=" + RecordID.Value;
			}
			return "/SMS/Add";
			}
	}

			
		
		[Ignore()]
		public SMS_SMSId SMSId { get; set; }
		public static SMS_SMSIdFieldDef SMSIdField { get; private set; }
        
			
			[Column("SMSId")]
			public  int PopulateSMSId  {
				get { return SMSIdValue ;}
				set { SMSId.DataValue = value; }
			}

	
			public int SMSIdValue 
			{ 
				get 
				{
				   if(SMSId.Value != null) {
				   					int i = 0;
					if (SMSId != null)
					{
						if (SMSId.Value != null)
						{
							if (Int32.TryParse(SMSId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SMSId.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSContent SMSContent { get; set; }
		public static SMS_SMSContentFieldDef SMSContentField { get; private set; }
        
			
			[Column("SMSContent")]
			public  string PopulateSMSContent  {
				get { return SMSContentValue ;}
				set { SMSContent.DataValue = value; }
			}

	
			public string SMSContentValue 
			{ 
				get 
				{
				   if(SMSContent.Value != null) {
				   return SMSContent.Value.ToString(); 					}
					return "";
                
				}
				set { SMSContent.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSDestination SMSDestination { get; set; }
		public static SMS_SMSDestinationFieldDef SMSDestinationField { get; private set; }
        
			
			[Column("SMSDestination")]
			public  string PopulateSMSDestination  {
				get { return SMSDestinationValue ;}
				set { SMSDestination.DataValue = value; }
			}

	
			public string SMSDestinationValue 
			{ 
				get 
				{
				   if(SMSDestination.Value != null) {
				   return SMSDestination.Value.ToString(); 					}
					return "";
                
				}
				set { SMSDestination.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSDataset SMSDataset { get; set; }
		public static SMS_SMSDatasetFieldDef SMSDatasetField { get; private set; }
        
			
			[Column("SMSDataset")]
			public  string PopulateSMSDataset  {
				get { return SMSDatasetValue ;}
				set { SMSDataset.DataValue = value; }
			}

	
			public string SMSDatasetValue 
			{ 
				get 
				{
				   if(SMSDataset.Value != null) {
				   return SMSDataset.Value.ToString(); 					}
					return "";
                
				}
				set { SMSDataset.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSRecordID SMSRecordID { get; set; }
		public static SMS_SMSRecordIDFieldDef SMSRecordIDField { get; private set; }
        
			
			[Column("SMSRecordID")]
			public  int PopulateSMSRecordID  {
				get { return SMSRecordIDValue ;}
				set { SMSRecordID.DataValue = value; }
			}

	
			public int SMSRecordIDValue 
			{ 
				get 
				{
				   if(SMSRecordID.Value != null) {
				   					int i = 0;
					if (SMSRecordID != null)
					{
						if (SMSRecordID.Value != null)
						{
							if (Int32.TryParse(SMSRecordID.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SMSRecordID.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSDateQueued SMSDateQueued { get; set; }
		public static SMS_SMSDateQueuedFieldDef SMSDateQueuedField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("SMSDateQueued")]
			public  DateTime PopulateSMSDateQueued  {
				get { return SMSDateQueuedValue ;}
				set { SMSDateQueued.DataValue = value; }
			}

	
			public DateTime SMSDateQueuedValue 
			{ 
				get 
				{
				   if(SMSDateQueued.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (SMSDateQueued != null)
					{
						if (SMSDateQueued.Value != null)
						{
							if (DateTime.TryParse(SMSDateQueued.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { SMSDateQueued.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSDateConfirmed SMSDateConfirmed { get; set; }
		public static SMS_SMSDateConfirmedFieldDef SMSDateConfirmedField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("SMSDateConfirmed")]
			public  DateTime PopulateSMSDateConfirmed  {
				get { return SMSDateConfirmedValue ;}
				set { SMSDateConfirmed.DataValue = value; }
			}

	
			public DateTime SMSDateConfirmedValue 
			{ 
				get 
				{
				   if(SMSDateConfirmed.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (SMSDateConfirmed != null)
					{
						if (SMSDateConfirmed.Value != null)
						{
							if (DateTime.TryParse(SMSDateConfirmed.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { SMSDateConfirmed.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSStatus SMSStatus { get; set; }
		public static SMS_SMSStatusFieldDef SMSStatusField { get; private set; }
        
			
			[Column("SMSStatus")]
			public  int PopulateSMSStatus  {
				get { return SMSStatusValue ;}
				set { SMSStatus.DataValue = value; }
			}

	
			public int SMSStatusValue 
			{ 
				get 
				{
				   if(SMSStatus.Value != null) {
				   					int i = 0;
					if (SMSStatus != null)
					{
						if (SMSStatus.Value != null)
						{
							if (Int32.TryParse(SMSStatus.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SMSStatus.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSStatusMsg SMSStatusMsg { get; set; }
		public static SMS_SMSStatusMsgFieldDef SMSStatusMsgField { get; private set; }
        
			
			[Column("SMSStatusMsg")]
			public  string PopulateSMSStatusMsg  {
				get { return SMSStatusMsgValue ;}
				set { SMSStatusMsg.DataValue = value; }
			}

	
			public string SMSStatusMsgValue 
			{ 
				get 
				{
				   if(SMSStatusMsg.Value != null) {
				   return SMSStatusMsg.Value.ToString(); 					}
					return "";
                
				}
				set { SMSStatusMsg.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSSender SMSSender { get; set; }
		public static SMS_SMSSenderFieldDef SMSSenderField { get; private set; }
        
			
			[Column("SMSSender")]
			public  string PopulateSMSSender  {
				get { return SMSSenderValue ;}
				set { SMSSender.DataValue = value; }
			}

	
			public string SMSSenderValue 
			{ 
				get 
				{
				   if(SMSSender.Value != null) {
				   return SMSSender.Value.ToString(); 					}
					return "";
                
				}
				set { SMSSender.Value = value;  }
			}
			
		
		[Ignore()]
		public SMS_SMSTemplate SMSTemplate { get; set; }
		public static SMS_SMSTemplateFieldDef SMSTemplateField { get; private set; }
        
			
			[Column("SMSTemplate")]
			public  int PopulateSMSTemplate  {
				get { return SMSTemplateValue ;}
				set { SMSTemplate.DataValue = value; }
			}

	
			public int SMSTemplateValue 
			{ 
				get 
				{
				   if(SMSTemplate.Value != null) {
				   					int i = 0;
					if (SMSTemplate != null)
					{
						if (SMSTemplate.Value != null)
						{
							if (Int32.TryParse(SMSTemplate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SMSTemplate.Value = value;  }
			}
	}


public class SMS_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 52;
    public int PixelHeight => 0;
	public string Title => "SMS";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
