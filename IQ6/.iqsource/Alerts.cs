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


public partial class AlertsController : DSBaseController<Alerts/*,AlertsSearch*/> {
	public AlertsController() : base ((IDatabase)IQApp.DB, new AlertsRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select AlrtId from Alerts where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Alerts>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Alerts data) {
						IQApp.DB.Execute("Delete from Alerts where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.AlrtTitleValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Alerts " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Alerts " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Alerts " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Alerts_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Alerts>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Alerts>("select * from Alerts  ").ToList();
		string urlpath = "/temp/Alerts Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Alerts");
				
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
	public ActionResult SaveAlrtId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.AlrtIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtId" || f.Key == "Id" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackAlrtId(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtId" || f.Key == "Id" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveAlrtUserID(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.AlrtUserIDValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtUserID"  || f.Key == "User" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtUserID" || f.Key == "User" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteAlrtUserID(Alerts m, int? id, string q) {

		
		string s = m.AlrtUserID.DataSource;
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
	public ActionResult CallbackAlrtUserID(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtUserID"  || f.Key == "User" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtUserID" || f.Key == "User" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveAlrtData(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.AlrtDataValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtData"  || f.Key == "Data" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtData" || f.Key == "Data" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackAlrtData(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtData"  || f.Key == "Data" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtData" || f.Key == "Data" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveAlrtTitle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.AlrtTitleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtTitle"  || f.Key == "Title" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtTitle" || f.Key == "Title" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackAlrtTitle(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtTitle"  || f.Key == "Title" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtTitle" || f.Key == "Title" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveAlrtQueueDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.AlrtQueueDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtQueueDate"  || f.Key == "QueueDate" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtQueueDate" || f.Key == "QueueDate" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackAlrtQueueDate(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtQueueDate"  || f.Key == "QueueDate" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtQueueDate" || f.Key == "QueueDate" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveAlrtCompletedDat(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.AlrtCompletedDatValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCompletedDat"  || f.Key == "CompletedDate" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCompletedDat" || f.Key == "CompletedDate" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackAlrtCompletedDat(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCompletedDat"  || f.Key == "CompletedDate" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCompletedDat" || f.Key == "CompletedDate" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveAlrtCallbackUrl(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Alerts>("select * from Alerts where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.AlrtCallbackUrlValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCallbackUrl"  || f.Key == "Callback" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCallbackUrl" || f.Key == "Callback" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackAlrtCallbackUrl(Alerts obj) {
			
		if(DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCallbackUrl"  || f.Key == "Callback" ).Any()) {
			foreach(var itm in DS.GetManager<Alerts>().OnChange.Where(f=> f.Key == "AlrtCallbackUrl" || f.Key == "Callback" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Alerts>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Alerts/List/");
	}

}

public partial class AlertsRepository : DSRepository<Alerts> {
	public AlertsRepository() : base(54, "Alerts", "Alerts") {
	}
}
public partial class Alerts 
: DatasetBase<Alerts>, IDSBase
, Intrinsiq.Alerts.IAlert
  {
	  public int KeyValue => AlrtIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "AlrtId":
			return AlrtIdField;
				case "AlrtUserID":
			return AlrtUserIDField;
				case "AlrtData":
			return AlrtDataField;
				case "AlrtTitle":
			return AlrtTitleField;
				case "AlrtQueueDate":
			return AlrtQueueDateField;
				case "AlrtCompletedDat":
			return AlrtCompletedDatField;
				case "AlrtCallbackUrl":
			return AlrtCallbackUrlField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(AlrtId,AlrtIdField);
				action(AlrtUserID,AlrtUserIDField);
				action(AlrtData,AlrtDataField);
				action(AlrtTitle,AlrtTitleField);
				action(AlrtQueueDate,AlrtQueueDateField);
				action(AlrtCompletedDat,AlrtCompletedDatField);
				action(AlrtCallbackUrl,AlrtCallbackUrlField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
							break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Alerts set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (AlrtId.HasChanged && AlrtId.HasValue) {
					SQL += ", AlrtId=@AlrtIdValue";

				}
								if (AlrtUserID.HasChanged && AlrtUserID.HasValue) {
					SQL += ", AlrtUserID=@AlrtUserIDValue";

				}
								if (AlrtData.HasChanged && AlrtData.HasValue) {
					SQL += ", AlrtData=@AlrtDataValue";

				}
								if (AlrtTitle.HasChanged && AlrtTitle.HasValue) {
					SQL += ", AlrtTitle=@AlrtTitleValue";

				}
								if (AlrtQueueDate.HasChanged && AlrtQueueDate.HasValue) {
					SQL += ", AlrtQueueDate=@AlrtQueueDateValue";

				}
								if (AlrtCompletedDat.HasChanged && AlrtCompletedDat.HasValue) {
					SQL += ", AlrtCompletedDat=@AlrtCompletedDatValue";

				}
								if (AlrtCallbackUrl.HasChanged && AlrtCallbackUrl.HasValue) {
					SQL += ", AlrtCallbackUrl=@AlrtCallbackUrlValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									AlrtId.HasChanged = false;
									AlrtUserID.HasChanged = false;
									AlrtData.HasChanged = false;
									AlrtTitle.HasChanged = false;
									AlrtQueueDate.HasChanged = false;
									AlrtCompletedDat.HasChanged = false;
									AlrtCallbackUrl.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Alerts(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				AlrtId.Value = IQApp.DB.GetInt("select isnull(max(AlrtId),0)+1 from Alerts");
				if (AlrtId.HasValue) {
					SQL += ", AlrtId";
					Values += ", @AlrtIdValue";
				}
				
				if (AlrtUserID.HasValue) {
					SQL += ", AlrtUserID";
					Values += ", @AlrtUserIDValue";
				}
				
				if (AlrtData.HasValue) {
					SQL += ", AlrtData";
					Values += ", @AlrtDataValue";
				}
				
				if (AlrtTitle.HasValue) {
					SQL += ", AlrtTitle";
					Values += ", @AlrtTitleValue";
				}
				
				if (AlrtQueueDate.HasValue) {
					SQL += ", AlrtQueueDate";
					Values += ", @AlrtQueueDateValue";
				}
				
				if (AlrtCompletedDat.HasValue) {
					SQL += ", AlrtCompletedDat";
					Values += ", @AlrtCompletedDatValue";
				}
				
				if (AlrtCallbackUrl.HasValue) {
					SQL += ", AlrtCallbackUrl";
					Values += ", @AlrtCallbackUrlValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Alerts");
					 IQApp.DB.Execute(SQL, this);
				                    					AlrtId.HasChanged = false;
									AlrtUserID.HasChanged = false;
									AlrtData.HasChanged = false;
									AlrtTitle.HasChanged = false;
									AlrtQueueDate.HasChanged = false;
									AlrtCompletedDat.HasChanged = false;
									AlrtCallbackUrl.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "AlrtId":
					return (IDSFieldBase)AlrtId;
								case "AlrtUserID":
					return (IDSFieldBase)AlrtUserID;
								case "AlrtData":
					return (IDSFieldBase)AlrtData;
								case "AlrtTitle":
					return (IDSFieldBase)AlrtTitle;
								case "AlrtQueueDate":
					return (IDSFieldBase)AlrtQueueDate;
								case "AlrtCompletedDat":
					return (IDSFieldBase)AlrtCompletedDat;
								case "AlrtCallbackUrl":
					return (IDSFieldBase)AlrtCallbackUrl;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "AlrtId":
					return AlrtId.DisplayValue;
								case "AlrtUserID":
					return AlrtUserID.DisplayValue;
								case "AlrtData":
					return AlrtData.DisplayValue;
								case "AlrtTitle":
					return AlrtTitle.DisplayValue;
								case "AlrtQueueDate":
					return AlrtQueueDate.DisplayValue;
								case "AlrtCompletedDat":
					return AlrtCompletedDat.DisplayValue;
								case "AlrtCallbackUrl":
					return AlrtCallbackUrl.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "AlrtId":
					return AlrtId.Value.ToString();
								case "AlrtUserID":
					return AlrtUserID.Value.ToString();
								case "AlrtData":
					return AlrtData.Value.ToString();
								case "AlrtTitle":
					return AlrtTitle.Value.ToString();
								case "AlrtQueueDate":
					return AlrtQueueDate.Value.ToString();
								case "AlrtCompletedDat":
					return AlrtCompletedDat.Value.ToString();
								case "AlrtCallbackUrl":
					return AlrtCallbackUrl.Value.ToString();
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
					foreach(var itm in DS.GetManager<Alerts>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Alerts () : base("Alerts") {
		base.obj = this;
	
					AlrtId = new Alerts_AlrtId(this);
					AlrtUserID = new Alerts_AlrtUserID(this);
					AlrtData = new Alerts_AlrtData(this);
					AlrtTitle = new Alerts_AlrtTitle(this);
					AlrtQueueDate = new Alerts_AlrtQueueDate(this);
					AlrtCompletedDat = new Alerts_AlrtCompletedDat(this);
					AlrtCallbackUrl = new Alerts_AlrtCallbackUrl(this);
			}

	static Alerts () {
					AlrtIdField = new Alerts_AlrtIdFieldDef();
					AlrtUserIDField = new Alerts_AlrtUserIDFieldDef();
					AlrtDataField = new Alerts_AlrtDataFieldDef();
					AlrtTitleField = new Alerts_AlrtTitleFieldDef();
					AlrtQueueDateField = new Alerts_AlrtQueueDateFieldDef();
					AlrtCompletedDatField = new Alerts_AlrtCompletedDatFieldDef();
					AlrtCallbackUrlField = new Alerts_AlrtCallbackUrlFieldDef();
			}

	public string RecordTitle { 
		get { return AlrtTitleValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Alerts"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Alerts/Load/?RecId=" + RecordID.Value;
			}
			return "/Alerts/Add";
			}
	}

			
		
		[Ignore()]
		public Alerts_AlrtId AlrtId { get; set; }
		public static Alerts_AlrtIdFieldDef AlrtIdField { get; private set; }
        
			
			[Column("AlrtId")]
			public  int PopulateAlrtId  {
				get { return AlrtIdValue ;}
				set { AlrtId.DataValue = value; }
			}

			public int Id {
			get { return AlrtIdValue ; }
			set { AlrtIdValue  = value; } 
		}
		[IQFieldName("AlrtId")]
		public IDSFieldBase  IdField { 
			get { return (IDSFieldBase)AlrtId; } 
			set { AlrtId = (Alerts_AlrtId)value; }
		}
	
			public int AlrtIdValue 
			{ 
				get 
				{
				   if(AlrtId.Value != null) {
				   					int i = 0;
					if (AlrtId != null)
					{
						if (AlrtId.Value != null)
						{
							if (Int32.TryParse(AlrtId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { AlrtId.Value = value;  }
			}
			
		
		[Ignore()]
		public Alerts_AlrtUserID AlrtUserID { get; set; }
		public static Alerts_AlrtUserIDFieldDef AlrtUserIDField { get; private set; }
        
			
			[Column("AlrtUserID")]
			public  int PopulateAlrtUserID  {
				get { return AlrtUserIDValue ;}
				set { AlrtUserID.DataValue = value; }
			}

			public int User {
			get { return AlrtUserIDValue ; }
			set { AlrtUserIDValue  = value; } 
		}
		[IQFieldName("AlrtUserID")]
		public IDSFieldBase  UserField { 
			get { return (IDSFieldBase)AlrtUserID; } 
			set { AlrtUserID = (Alerts_AlrtUserID)value; }
		}
	
			public int AlrtUserIDValue 
			{ 
				get 
				{
				   if(AlrtUserID.Value != null) {
				   					int i = 0;
					if (AlrtUserID != null)
					{
						if (AlrtUserID.Value != null)
						{
							if (Int32.TryParse(AlrtUserID.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { AlrtUserID.Value = value;  }
			}
			
		
		[Ignore()]
		public Alerts_AlrtData AlrtData { get; set; }
		public static Alerts_AlrtDataFieldDef AlrtDataField { get; private set; }
        
			
			[Column("AlrtData")]
			public  string PopulateAlrtData  {
				get { return AlrtDataValue ;}
				set { AlrtData.DataValue = value; }
			}

			public string Data {
			get { return AlrtDataValue ; }
			set { AlrtDataValue  = value; } 
		}
		[IQFieldName("AlrtData")]
		public IDSFieldBase  DataField { 
			get { return (IDSFieldBase)AlrtData; } 
			set { AlrtData = (Alerts_AlrtData)value; }
		}
	
			public string AlrtDataValue 
			{ 
				get 
				{
				   if(AlrtData.Value != null) {
				   return AlrtData.Value.ToString(); 					}
					return "";
                
				}
				set { AlrtData.Value = value;  }
			}
			
		
		[Ignore()]
		public Alerts_AlrtTitle AlrtTitle { get; set; }
		public static Alerts_AlrtTitleFieldDef AlrtTitleField { get; private set; }
        
			
			[Column("AlrtTitle")]
			public  string PopulateAlrtTitle  {
				get { return AlrtTitleValue ;}
				set { AlrtTitle.DataValue = value; }
			}

			public string Title {
			get { return AlrtTitleValue ; }
			set { AlrtTitleValue  = value; } 
		}
		[IQFieldName("AlrtTitle")]
		public IDSFieldBase  TitleField { 
			get { return (IDSFieldBase)AlrtTitle; } 
			set { AlrtTitle = (Alerts_AlrtTitle)value; }
		}
	
			public string AlrtTitleValue 
			{ 
				get 
				{
				   if(AlrtTitle.Value != null) {
				   return AlrtTitle.Value.ToString(); 					}
					return "";
                
				}
				set { AlrtTitle.Value = value;  }
			}
			
		
		[Ignore()]
		public Alerts_AlrtQueueDate AlrtQueueDate { get; set; }
		public static Alerts_AlrtQueueDateFieldDef AlrtQueueDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("AlrtQueueDate")]
			public  DateTime PopulateAlrtQueueDate  {
				get { return AlrtQueueDateValue ;}
				set { AlrtQueueDate.DataValue = value; }
			}

			public DateTime QueueDate {
			get { return AlrtQueueDateValue ; }
			set { AlrtQueueDateValue  = value; } 
		}
		[IQFieldName("AlrtQueueDate")]
		public IDSFieldBase  QueueDateField { 
			get { return (IDSFieldBase)AlrtQueueDate; } 
			set { AlrtQueueDate = (Alerts_AlrtQueueDate)value; }
		}
	
			public DateTime AlrtQueueDateValue 
			{ 
				get 
				{
				   if(AlrtQueueDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (AlrtQueueDate != null)
					{
						if (AlrtQueueDate.Value != null)
						{
							if (DateTime.TryParse(AlrtQueueDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { AlrtQueueDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Alerts_AlrtCompletedDat AlrtCompletedDat { get; set; }
		public static Alerts_AlrtCompletedDatFieldDef AlrtCompletedDatField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("AlrtCompletedDat")]
			public  DateTime PopulateAlrtCompletedDat  {
				get { return AlrtCompletedDatValue ;}
				set { AlrtCompletedDat.DataValue = value; }
			}

			public DateTime CompletedDate {
			get { return AlrtCompletedDatValue ; }
			set { AlrtCompletedDatValue  = value; } 
		}
		[IQFieldName("AlrtCompletedDat")]
		public IDSFieldBase  CompletedDateField { 
			get { return (IDSFieldBase)AlrtCompletedDat; } 
			set { AlrtCompletedDat = (Alerts_AlrtCompletedDat)value; }
		}
	
			public DateTime AlrtCompletedDatValue 
			{ 
				get 
				{
				   if(AlrtCompletedDat.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (AlrtCompletedDat != null)
					{
						if (AlrtCompletedDat.Value != null)
						{
							if (DateTime.TryParse(AlrtCompletedDat.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { AlrtCompletedDat.Value = value;  }
			}
			
		
		[Ignore()]
		public Alerts_AlrtCallbackUrl AlrtCallbackUrl { get; set; }
		public static Alerts_AlrtCallbackUrlFieldDef AlrtCallbackUrlField { get; private set; }
        
			
			[Column("AlrtCallbackUrl")]
			public  string PopulateAlrtCallbackUrl  {
				get { return AlrtCallbackUrlValue ;}
				set { AlrtCallbackUrl.DataValue = value; }
			}

			public string Callback {
			get { return AlrtCallbackUrlValue ; }
			set { AlrtCallbackUrlValue  = value; } 
		}
		[IQFieldName("AlrtCallbackUrl")]
		public IDSFieldBase  CallbackField { 
			get { return (IDSFieldBase)AlrtCallbackUrl; } 
			set { AlrtCallbackUrl = (Alerts_AlrtCallbackUrl)value; }
		}
	
			public string AlrtCallbackUrlValue 
			{ 
				get 
				{
				   if(AlrtCallbackUrl.Value != null) {
				   return AlrtCallbackUrl.Value.ToString(); 					}
					return "";
                
				}
				set { AlrtCallbackUrl.Value = value;  }
			}
	}


public class Alerts_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 54;
    public int PixelHeight => 0;
	public string Title => "Alerts";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
