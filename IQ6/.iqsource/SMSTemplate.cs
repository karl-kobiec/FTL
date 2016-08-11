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


public partial class SMSTemplateController : DSBaseController<SMSTemplate/*,SMSTemplateSearch*/> {
	public SMSTemplateController() : base ((IDatabase)IQApp.DB, new SMSTemplateRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select SMSTId from SMSTemplate where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<SMSTemplate>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(SMSTemplate data) {
						IQApp.DB.Execute("Delete from SMSTemplate where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.SMSTNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from SMSTemplate " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from SMSTemplate " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from SMSTemplate " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/SMSTemplate_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<SMSTemplate>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate  ").ToList();
		string urlpath = "/temp/SMS Template Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("SMS Template");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 3])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 71;
					worksheet.Cells[1, 1].Value = "Name";
						
								
					worksheet.Column(2).Width = 29;
					worksheet.Cells[1, 2].Value = "Applies To";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].SMSTName.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].SMSTDataset.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SMSTIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTId" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSTId(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTId" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTContent(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSTContentValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTContent" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTContent")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSTContent(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTContent" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTContent")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTDestination(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSTDestinationValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDestination" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDestination")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSTDestination(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDestination" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDestination")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSTNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTName" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSTName(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTName" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTDataset(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSTDatasetValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDataset" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDataset")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSMSTDataset(SMSTemplate m, int? id, string q) {

		
		string s = m.SMSTDataset.DataSource;
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
	public ActionResult CallbackSMSTDataset(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDataset" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTDataset")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTSender(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.SMSTSenderValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTSender" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTSender")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackSMSTSender(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTSender" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTSender")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveSMSTQuery(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<SMSTemplate>("select * from SMSTemplate where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.SMSTQueryValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTQuery" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTQuery")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteSMSTQuery(SMSTemplate m, int? id, string q) {

		
		string s = m.SMSTQuery.DataSource;
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
	public ActionResult CallbackSMSTQuery(SMSTemplate obj) {
			
		if(DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTQuery" ).Any()) {
			foreach(var itm in DS.GetManager<SMSTemplate>().OnChange.Where(f=> f.Key == "SMSTQuery")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<SMSTemplate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/SMSTemplate/List/");
	}

}

public partial class SMSTemplateRepository : DSRepository<SMSTemplate> {
	public SMSTemplateRepository() : base(53, "SMSTemplate", "SMS Template") {
	}
}
public partial class SMSTemplate 
: DatasetBase<SMSTemplate>, IDSBase

  {
	  public int KeyValue => SMSTIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "SMSTId":
			return SMSTIdField;
				case "SMSTContent":
			return SMSTContentField;
				case "SMSTDestination":
			return SMSTDestinationField;
				case "SMSTName":
			return SMSTNameField;
				case "SMSTDataset":
			return SMSTDatasetField;
				case "SMSTSender":
			return SMSTSenderField;
				case "SMSTQuery":
			return SMSTQueryField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(SMSTId,SMSTIdField);
				action(SMSTContent,SMSTContentField);
				action(SMSTDestination,SMSTDestinationField);
				action(SMSTName,SMSTNameField);
				action(SMSTDataset,SMSTDatasetField);
				action(SMSTSender,SMSTSenderField);
				action(SMSTQuery,SMSTQueryField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				SMSTId.Visible=false;SMSTContent.Visible=false;SMSTDestination.Visible=false;SMSTName.Visible=false;SMSTDataset.Visible=false;SMSTSender.Visible=false;			break;
					case 3:
				SMSTId.Visible=false;SMSTContent.Visible=false;SMSTDestination.Visible=false;SMSTName.Visible=false;SMSTDataset.Visible=false;SMSTSender.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update SMSTemplate set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (SMSTId.HasChanged && SMSTId.HasValue) {
					SQL += ", SMSTId=@SMSTIdValue";

				}
								if (SMSTContent.HasChanged && SMSTContent.HasValue) {
					SQL += ", SMSTContent=@SMSTContentValue";

				}
								if (SMSTDestination.HasChanged && SMSTDestination.HasValue) {
					SQL += ", SMSTDestination=@SMSTDestinationValue";

				}
								if (SMSTName.HasChanged && SMSTName.HasValue) {
					SQL += ", SMSTName=@SMSTNameValue";

				}
								if (SMSTDataset.HasChanged && SMSTDataset.HasValue) {
					SQL += ", SMSTDataset=@SMSTDatasetValue";

				}
								if (SMSTSender.HasChanged && SMSTSender.HasValue) {
					SQL += ", SMSTSender=@SMSTSenderValue";

				}
								if (SMSTQuery.HasChanged && SMSTQuery.HasValue) {
					SQL += ", SMSTQuery=@SMSTQueryValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									SMSTId.HasChanged = false;
									SMSTContent.HasChanged = false;
									SMSTDestination.HasChanged = false;
									SMSTName.HasChanged = false;
									SMSTDataset.HasChanged = false;
									SMSTSender.HasChanged = false;
									SMSTQuery.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into SMSTemplate(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				SMSTId.Value = IQApp.DB.GetInt("select isnull(max(SMSTId),0)+1 from SMSTemplate");
				if (SMSTId.HasValue) {
					SQL += ", SMSTId";
					Values += ", @SMSTIdValue";
				}
				
				if (SMSTContent.HasValue) {
					SQL += ", SMSTContent";
					Values += ", @SMSTContentValue";
				}
				
				if (SMSTDestination.HasValue) {
					SQL += ", SMSTDestination";
					Values += ", @SMSTDestinationValue";
				}
				
				if (SMSTName.HasValue) {
					SQL += ", SMSTName";
					Values += ", @SMSTNameValue";
				}
				
				if (SMSTDataset.HasValue) {
					SQL += ", SMSTDataset";
					Values += ", @SMSTDatasetValue";
				}
				
				if (SMSTSender.HasValue) {
					SQL += ", SMSTSender";
					Values += ", @SMSTSenderValue";
				}
				
				if (SMSTQuery.HasValue) {
					SQL += ", SMSTQuery";
					Values += ", @SMSTQueryValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from SMSTemplate");
					 IQApp.DB.Execute(SQL, this);
				                    					SMSTId.HasChanged = false;
									SMSTContent.HasChanged = false;
									SMSTDestination.HasChanged = false;
									SMSTName.HasChanged = false;
									SMSTDataset.HasChanged = false;
									SMSTSender.HasChanged = false;
									SMSTQuery.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "SMSTId":
					return (IDSFieldBase)SMSTId;
								case "SMSTContent":
					return (IDSFieldBase)SMSTContent;
								case "SMSTDestination":
					return (IDSFieldBase)SMSTDestination;
								case "SMSTName":
					return (IDSFieldBase)SMSTName;
								case "SMSTDataset":
					return (IDSFieldBase)SMSTDataset;
								case "SMSTSender":
					return (IDSFieldBase)SMSTSender;
								case "SMSTQuery":
					return (IDSFieldBase)SMSTQuery;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "SMSTId":
					return SMSTId.DisplayValue;
								case "SMSTContent":
					return SMSTContent.DisplayValue;
								case "SMSTDestination":
					return SMSTDestination.DisplayValue;
								case "SMSTName":
					return SMSTName.DisplayValue;
								case "SMSTDataset":
					return SMSTDataset.DisplayValue;
								case "SMSTSender":
					return SMSTSender.DisplayValue;
								case "SMSTQuery":
					return SMSTQuery.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "SMSTId":
					return SMSTId.Value.ToString();
								case "SMSTContent":
					return SMSTContent.Value.ToString();
								case "SMSTDestination":
					return SMSTDestination.Value.ToString();
								case "SMSTName":
					return SMSTName.Value.ToString();
								case "SMSTDataset":
					return SMSTDataset.Value.ToString();
								case "SMSTSender":
					return SMSTSender.Value.ToString();
								case "SMSTQuery":
					return SMSTQuery.Value.ToString();
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
					foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public SMSTemplate () : base("SMSTemplate") {
		base.obj = this;
	
					SMSTId = new SMSTemplate_SMSTId(this);
					SMSTContent = new SMSTemplate_SMSTContent(this);
					SMSTDestination = new SMSTemplate_SMSTDestination(this);
					SMSTName = new SMSTemplate_SMSTName(this);
					SMSTDataset = new SMSTemplate_SMSTDataset(this);
					SMSTSender = new SMSTemplate_SMSTSender(this);
					SMSTQuery = new SMSTemplate_SMSTQuery(this);
			}

	static SMSTemplate () {
					SMSTIdField = new SMSTemplate_SMSTIdFieldDef();
					SMSTContentField = new SMSTemplate_SMSTContentFieldDef();
					SMSTDestinationField = new SMSTemplate_SMSTDestinationFieldDef();
					SMSTNameField = new SMSTemplate_SMSTNameFieldDef();
					SMSTDatasetField = new SMSTemplate_SMSTDatasetFieldDef();
					SMSTSenderField = new SMSTemplate_SMSTSenderFieldDef();
					SMSTQueryField = new SMSTemplate_SMSTQueryFieldDef();
			}

	public string RecordTitle { 
		get { return SMSTNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "SMS Template"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/SMSTemplate/Load/?RecId=" + RecordID.Value;
			}
			return "/SMSTemplate/Add";
			}
	}

			
		
		[Ignore()]
		public SMSTemplate_SMSTId SMSTId { get; set; }
		public static SMSTemplate_SMSTIdFieldDef SMSTIdField { get; private set; }
        
			
			[Column("SMSTId")]
			public  int PopulateSMSTId  {
				get { return SMSTIdValue ;}
				set { SMSTId.DataValue = value; }
			}

	
			public int SMSTIdValue 
			{ 
				get 
				{
				   if(SMSTId.Value != null) {
				   					int i = 0;
					if (SMSTId != null)
					{
						if (SMSTId.Value != null)
						{
							if (Int32.TryParse(SMSTId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SMSTId.Value = value;  }
			}
			
		
		[Ignore()]
		public SMSTemplate_SMSTContent SMSTContent { get; set; }
		public static SMSTemplate_SMSTContentFieldDef SMSTContentField { get; private set; }
        
			
			[Column("SMSTContent")]
			public  string PopulateSMSTContent  {
				get { return SMSTContentValue ;}
				set { SMSTContent.DataValue = value; }
			}

	
			public string SMSTContentValue 
			{ 
				get 
				{
				   if(SMSTContent.Value != null) {
				   return SMSTContent.Value.ToString(); 					}
					return "";
                
				}
				set { SMSTContent.Value = value;  }
			}
			
		
		[Ignore()]
		public SMSTemplate_SMSTDestination SMSTDestination { get; set; }
		public static SMSTemplate_SMSTDestinationFieldDef SMSTDestinationField { get; private set; }
        
			
			[Column("SMSTDestination")]
			public  string PopulateSMSTDestination  {
				get { return SMSTDestinationValue ;}
				set { SMSTDestination.DataValue = value; }
			}

	
			public string SMSTDestinationValue 
			{ 
				get 
				{
				   if(SMSTDestination.Value != null) {
				   return SMSTDestination.Value.ToString(); 					}
					return "";
                
				}
				set { SMSTDestination.Value = value;  }
			}
			
		
		[Ignore()]
		public SMSTemplate_SMSTName SMSTName { get; set; }
		public static SMSTemplate_SMSTNameFieldDef SMSTNameField { get; private set; }
        
			
			[Column("SMSTName")]
			public  string PopulateSMSTName  {
				get { return SMSTNameValue ;}
				set { SMSTName.DataValue = value; }
			}

	
			public string SMSTNameValue 
			{ 
				get 
				{
				   if(SMSTName.Value != null) {
				   return SMSTName.Value.ToString(); 					}
					return "";
                
				}
				set { SMSTName.Value = value;  }
			}
			
		
		[Ignore()]
		public SMSTemplate_SMSTDataset SMSTDataset { get; set; }
		public static SMSTemplate_SMSTDatasetFieldDef SMSTDatasetField { get; private set; }
        
			
			[Column("SMSTDataset")]
			public  string PopulateSMSTDataset  {
				get { return SMSTDatasetValue ;}
				set { SMSTDataset.DataValue = value; }
			}

	
			public string SMSTDatasetValue 
			{ 
				get 
				{
				   if(SMSTDataset.Value != null) {
				   return SMSTDataset.Value.ToString(); 					}
					return "";
                
				}
				set { SMSTDataset.Value = value;  }
			}
			
		
		[Ignore()]
		public SMSTemplate_SMSTSender SMSTSender { get; set; }
		public static SMSTemplate_SMSTSenderFieldDef SMSTSenderField { get; private set; }
        
			
			[Column("SMSTSender")]
			public  string PopulateSMSTSender  {
				get { return SMSTSenderValue ;}
				set { SMSTSender.DataValue = value; }
			}

	
			public string SMSTSenderValue 
			{ 
				get 
				{
				   if(SMSTSender.Value != null) {
				   return SMSTSender.Value.ToString(); 					}
					return "";
                
				}
				set { SMSTSender.Value = value;  }
			}
			
		
		[Ignore()]
		public SMSTemplate_SMSTQuery SMSTQuery { get; set; }
		public static SMSTemplate_SMSTQueryFieldDef SMSTQueryField { get; private set; }
        
			
			[Column("SMSTQuery")]
			public  int PopulateSMSTQuery  {
				get { return SMSTQueryValue ;}
				set { SMSTQuery.DataValue = value; }
			}

	
			public int SMSTQueryValue 
			{ 
				get 
				{
				   if(SMSTQuery.Value != null) {
				   					int i = 0;
					if (SMSTQuery != null)
					{
						if (SMSTQuery.Value != null)
						{
							if (Int32.TryParse(SMSTQuery.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { SMSTQuery.Value = value;  }
			}
	}


public class SMSTemplate_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 53;
    public int PixelHeight => 0;
	public string Title => "SMS Template";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
