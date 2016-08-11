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


public partial class WeekController : DSBaseController<Week/*,WeekSearch*/> {
	public WeekController() : base ((IDatabase)IQApp.DB, new WeekRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select WkId from Week where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Week>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Week data) {
						IQApp.DB.Execute("Delete from Week where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.WkIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Week " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Week " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Week " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Week_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Week>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Week>("select * from Week  ").ToList();
		string urlpath = "/temp/Weeks Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Weeks");
				
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
							
					worksheet.Column(1).Width = 18;
					worksheet.Cells[1, 1].Value = "Week ID";
						
								
					worksheet.Column(2).Width = 27;
					worksheet.Cells[1, 2].Value = "Week Start (Mon)";
						
								
					worksheet.Column(3).Width = 27;
					worksheet.Cells[1, 3].Value = "Week End (Sun)";
						
								
					worksheet.Column(4).Width = 27;
					worksheet.Cells[1, 4].Value = "Belongs to Period";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].WkId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].WkSDate.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].WkEDate.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].WkBelongsTo.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWkId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Week>("select * from Week where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.WkIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkId" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWkId(Week obj) {
			
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkId" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWkSDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Week>("select * from Week where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.WkSDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDate" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWkSDate(Week obj) {
			
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDate" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWkEDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Week>("select * from Week where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.WkEDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDate" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWkEDate(Week obj) {
			
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDate" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWkBelongsTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Week>("select * from Week where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.WkBelongsToValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkBelongsTo" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkBelongsTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWkBelongsTo(Week obj) {
			
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkBelongsTo" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkBelongsTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWkSDateText(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Week>("select * from Week where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WkSDateTextValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDateText" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDateText")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWkSDateText(Week obj) {
			
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDateText" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkSDateText")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWkEDateText(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Week>("select * from Week where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WkEDateTextValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDateText" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDateText")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWkEDateText(Week obj) {
			
		if(DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDateText" ).Any()) {
			foreach(var itm in DS.GetManager<Week>().OnChange.Where(f=> f.Key == "WkEDateText")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Week>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Week/List/");
	}

}

public partial class WeekRepository : DSRepository<Week> {
	public WeekRepository() : base(21, "Week", "Weeks") {
	}
}
public partial class Week 
: DatasetBase<Week>, IDSBase

  {
	  public int KeyValue => WkIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "WkId":
			return WkIdField;
				case "WkSDate":
			return WkSDateField;
				case "WkEDate":
			return WkEDateField;
				case "WkBelongsTo":
			return WkBelongsToField;
				case "WkSDateText":
			return WkSDateTextField;
				case "WkEDateText":
			return WkEDateTextField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(WkId,WkIdField);
				action(WkSDate,WkSDateField);
				action(WkEDate,WkEDateField);
				action(WkBelongsTo,WkBelongsToField);
				action(WkSDateText,WkSDateTextField);
				action(WkEDateText,WkEDateTextField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				WkId.Visible=false;WkSDate.Visible=false;WkEDate.Visible=false;WkBelongsTo.Visible=false;WkSDateText.Visible=false;WkEDateText.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Week set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (WkId.HasChanged && WkId.HasValue) {
					SQL += ", WkId=@WkIdValue";

				}
								if (WkSDate.HasChanged && WkSDate.HasValue) {
					SQL += ", WkSDate=@WkSDateValue";

				}
								if (WkEDate.HasChanged && WkEDate.HasValue) {
					SQL += ", WkEDate=@WkEDateValue";

				}
								if (WkBelongsTo.HasChanged && WkBelongsTo.HasValue) {
					SQL += ", WkBelongsTo=@WkBelongsToValue";

				}
								if (WkSDateText.HasChanged && WkSDateText.HasValue) {
					SQL += ", WkSDateText=@WkSDateTextValue";

				}
								if (WkEDateText.HasChanged && WkEDateText.HasValue) {
					SQL += ", WkEDateText=@WkEDateTextValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									WkId.HasChanged = false;
									WkSDate.HasChanged = false;
									WkEDate.HasChanged = false;
									WkBelongsTo.HasChanged = false;
									WkSDateText.HasChanged = false;
									WkEDateText.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Week(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (WkId.HasValue) {
					SQL += ", WkId";
					Values += ", @WkIdValue";
				}
				
				if (WkSDate.HasValue) {
					SQL += ", WkSDate";
					Values += ", @WkSDateValue";
				}
				
				if (WkEDate.HasValue) {
					SQL += ", WkEDate";
					Values += ", @WkEDateValue";
				}
				
				if (WkBelongsTo.HasValue) {
					SQL += ", WkBelongsTo";
					Values += ", @WkBelongsToValue";
				}
				
				if (WkSDateText.HasValue) {
					SQL += ", WkSDateText";
					Values += ", @WkSDateTextValue";
				}
				
				if (WkEDateText.HasValue) {
					SQL += ", WkEDateText";
					Values += ", @WkEDateTextValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Week");
					 IQApp.DB.Execute(SQL, this);
				                    					WkId.HasChanged = false;
									WkSDate.HasChanged = false;
									WkEDate.HasChanged = false;
									WkBelongsTo.HasChanged = false;
									WkSDateText.HasChanged = false;
									WkEDateText.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "WkId":
					return (IDSFieldBase)WkId;
								case "WkSDate":
					return (IDSFieldBase)WkSDate;
								case "WkEDate":
					return (IDSFieldBase)WkEDate;
								case "WkBelongsTo":
					return (IDSFieldBase)WkBelongsTo;
								case "WkSDateText":
					return (IDSFieldBase)WkSDateText;
								case "WkEDateText":
					return (IDSFieldBase)WkEDateText;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "WkId":
					return WkId.DisplayValue;
								case "WkSDate":
					return WkSDate.DisplayValue;
								case "WkEDate":
					return WkEDate.DisplayValue;
								case "WkBelongsTo":
					return WkBelongsTo.DisplayValue;
								case "WkSDateText":
					return WkSDateText.DisplayValue;
								case "WkEDateText":
					return WkEDateText.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "WkId":
					return WkId.Value.ToString();
								case "WkSDate":
					return WkSDate.Value.ToString();
								case "WkEDate":
					return WkEDate.Value.ToString();
								case "WkBelongsTo":
					return WkBelongsTo.Value.ToString();
								case "WkSDateText":
					return WkSDateText.Value.ToString();
								case "WkEDateText":
					return WkEDateText.Value.ToString();
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
					foreach(var itm in DS.GetManager<Week>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Week () : base("Week") {
		base.obj = this;
	
					WkId = new Week_WkId(this);
					WkSDate = new Week_WkSDate(this);
					WkEDate = new Week_WkEDate(this);
					WkBelongsTo = new Week_WkBelongsTo(this);
					WkSDateText = new Week_WkSDateText(this);
					WkEDateText = new Week_WkEDateText(this);
			}

	static Week () {
					WkIdField = new Week_WkIdFieldDef();
					WkSDateField = new Week_WkSDateFieldDef();
					WkEDateField = new Week_WkEDateFieldDef();
					WkBelongsToField = new Week_WkBelongsToFieldDef();
					WkSDateTextField = new Week_WkSDateTextFieldDef();
					WkEDateTextField = new Week_WkEDateTextFieldDef();
			}

	public string RecordTitle { 
		get { return WkIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Weeks"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Week/Load/?RecId=" + RecordID.Value;
			}
			return "/Week/Add";
			}
	}

			
		
		[Ignore()]
		public Week_WkId WkId { get; set; }
		public static Week_WkIdFieldDef WkIdField { get; private set; }
        
			
			[Column("WkId")]
			public  int PopulateWkId  {
				get { return WkIdValue ;}
				set { WkId.DataValue = value; }
			}

	
			public int WkIdValue 
			{ 
				get 
				{
				   if(WkId.Value != null) {
				   					int i = 0;
					if (WkId != null)
					{
						if (WkId.Value != null)
						{
							if (Int32.TryParse(WkId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { WkId.Value = value;  }
			}
			
		
		[Ignore()]
		public Week_WkSDate WkSDate { get; set; }
		public static Week_WkSDateFieldDef WkSDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("WkSDate")]
			public  DateTime PopulateWkSDate  {
				get { return WkSDateValue ;}
				set { WkSDate.DataValue = value; }
			}

	
			public DateTime WkSDateValue 
			{ 
				get 
				{
				   if(WkSDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (WkSDate != null)
					{
						if (WkSDate.Value != null)
						{
							if (DateTime.TryParse(WkSDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { WkSDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Week_WkEDate WkEDate { get; set; }
		public static Week_WkEDateFieldDef WkEDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("WkEDate")]
			public  DateTime PopulateWkEDate  {
				get { return WkEDateValue ;}
				set { WkEDate.DataValue = value; }
			}

	
			public DateTime WkEDateValue 
			{ 
				get 
				{
				   if(WkEDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (WkEDate != null)
					{
						if (WkEDate.Value != null)
						{
							if (DateTime.TryParse(WkEDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { WkEDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Week_WkBelongsTo WkBelongsTo { get; set; }
		public static Week_WkBelongsToFieldDef WkBelongsToField { get; private set; }
        
			
			[Column("WkBelongsTo")]
			public  int PopulateWkBelongsTo  {
				get { return WkBelongsToValue ;}
				set { WkBelongsTo.DataValue = value; }
			}

	
			public int WkBelongsToValue 
			{ 
				get 
				{
				   if(WkBelongsTo.Value != null) {
				   					int i = 0;
					if (WkBelongsTo != null)
					{
						if (WkBelongsTo.Value != null)
						{
							if (Int32.TryParse(WkBelongsTo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { WkBelongsTo.Value = value;  }
			}
			
		
		[Ignore()]
		public Week_WkSDateText WkSDateText { get; set; }
		public static Week_WkSDateTextFieldDef WkSDateTextField { get; private set; }
        
			
			[Column("WkSDateText")]
			public  string PopulateWkSDateText  {
				get { return WkSDateTextValue ;}
				set { WkSDateText.DataValue = value; }
			}

	
			public string WkSDateTextValue 
			{ 
				get 
				{
				   if(WkSDateText.Value != null) {
				   return WkSDateText.Value.ToString(); 					}
					return "";
                
				}
				set { WkSDateText.Value = value;  }
			}
			
		
		[Ignore()]
		public Week_WkEDateText WkEDateText { get; set; }
		public static Week_WkEDateTextFieldDef WkEDateTextField { get; private set; }
        
			
			[Column("WkEDateText")]
			public  string PopulateWkEDateText  {
				get { return WkEDateTextValue ;}
				set { WkEDateText.DataValue = value; }
			}

	
			public string WkEDateTextValue 
			{ 
				get 
				{
				   if(WkEDateText.Value != null) {
				   return WkEDateText.Value.ToString(); 					}
					return "";
                
				}
				set { WkEDateText.Value = value;  }
			}
	}


public class Week_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 21;
    public int PixelHeight => 0;
	public string Title => "Weeks";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
