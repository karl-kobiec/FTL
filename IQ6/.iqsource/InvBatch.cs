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


public partial class InvBatchController : DSBaseController<InvBatch/*,InvBatchSearch*/> {
	public InvBatchController() : base ((IDatabase)IQApp.DB, new InvBatchRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select InvBId from InvBatch where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<InvBatch>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(InvBatch data) {
						IQApp.DB.Execute("Delete from InvBatch where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.InvBIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from InvBatch " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from InvBatch " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from InvBatch " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/InvBatch_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<InvBatch>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<InvBatch>("select * from InvBatch  ").ToList();
		string urlpath = "/temp/Invoice Batches Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Invoice Batches");
				
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
							
					worksheet.Column(1).Width = 19;
					worksheet.Cells[1, 1].Value = "Batch Number";
						
								
					worksheet.Column(2).Width = 29;
					worksheet.Cells[1, 2].Value = "Invoice Type";
						
								
					worksheet.Column(3).Width = 19;
					worksheet.Cells[1, 3].Value = "Printed On";
						
								
					worksheet.Column(4).Width = 19;
					worksheet.Cells[1, 4].Value = "Sent to Dover On";
						
								
					worksheet.Column(5).Width = 14;
					worksheet.Cells[1, 5].Value = "Sent";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].InvBId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].InvBType.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].InvBPrintedOn.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].InvBExportedDate.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].InvBExported.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvBId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvBatch>("select * from InvBatch where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvBIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBId" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvBId(InvBatch obj) {
			
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBId" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvBType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvBatch>("select * from InvBatch where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvBTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBType" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvBType(InvBatch m, int? id, string q) {

		
		string s = m.InvBType.DataSource;
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
	public ActionResult CallbackInvBType(InvBatch obj) {
			
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBType" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvBPrintedOn(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvBatch>("select * from InvBatch where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvBPrintedOnValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBPrintedOn" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBPrintedOn")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvBPrintedOn(InvBatch obj) {
			
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBPrintedOn" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBPrintedOn")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvBExportedDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvBatch>("select * from InvBatch where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvBExportedDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExportedDate" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExportedDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvBExportedDate(InvBatch obj) {
			
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExportedDate" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExportedDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvBExported(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvBatch>("select * from InvBatch where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvBExportedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExported" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExported")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvBExported(InvBatch obj) {
			
		if(DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExported" ).Any()) {
			foreach(var itm in DS.GetManager<InvBatch>().OnChange.Where(f=> f.Key == "InvBExported")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvBatch>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=23 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/InvBatch/Search/" + FirstSearch);
		
		return Redirect("/InvBatch/List/");
	}

}

public partial class InvBatchRepository : DSRepository<InvBatch> {
	public InvBatchRepository() : base(23, "InvBatch", "Invoice Batches") {
	}
}
public partial class InvBatch 
: DatasetBase<InvBatch>, IDSBase

  {
	  public int KeyValue => InvBIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "InvBId":
			return InvBIdField;
				case "InvBType":
			return InvBTypeField;
				case "InvBPrintedOn":
			return InvBPrintedOnField;
				case "InvBExportedDate":
			return InvBExportedDateField;
				case "InvBExported":
			return InvBExportedField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(InvBId,InvBIdField);
				action(InvBType,InvBTypeField);
				action(InvBPrintedOn,InvBPrintedOnField);
				action(InvBExportedDate,InvBExportedDateField);
				action(InvBExported,InvBExportedField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				InvBId.Visible=false;InvBType.Visible=false;InvBPrintedOn.Visible=false;InvBExportedDate.Visible=false;InvBExported.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update InvBatch set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (InvBId.HasChanged && InvBId.HasValue) {
					SQL += ", InvBId=@InvBIdValue";

				}
								if (InvBType.HasChanged && InvBType.HasValue) {
					SQL += ", InvBType=@InvBTypeValue";

				}
								if (InvBPrintedOn.HasChanged && InvBPrintedOn.HasValue) {
					SQL += ", InvBPrintedOn=@InvBPrintedOnValue";

				}
								if (InvBExportedDate.HasChanged && InvBExportedDate.HasValue) {
					SQL += ", InvBExportedDate=@InvBExportedDateValue";

				}
								if (InvBExported.HasChanged && InvBExported.HasValue) {
					SQL += ", InvBExported=@InvBExportedValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									InvBId.HasChanged = false;
									InvBType.HasChanged = false;
									InvBPrintedOn.HasChanged = false;
									InvBExportedDate.HasChanged = false;
									InvBExported.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into InvBatch(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				InvBId.Value = IQApp.DB.GetInt("select isnull(max(InvBId),0)+1 from InvBatch");
				if (InvBId.HasValue) {
					SQL += ", InvBId";
					Values += ", @InvBIdValue";
				}
				
				if (InvBType.HasValue) {
					SQL += ", InvBType";
					Values += ", @InvBTypeValue";
				}
				
				if (InvBPrintedOn.HasValue) {
					SQL += ", InvBPrintedOn";
					Values += ", @InvBPrintedOnValue";
				}
				
				if (InvBExportedDate.HasValue) {
					SQL += ", InvBExportedDate";
					Values += ", @InvBExportedDateValue";
				}
				
				if (InvBExported.HasValue) {
					SQL += ", InvBExported";
					Values += ", @InvBExportedValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from InvBatch");
					 IQApp.DB.Execute(SQL, this);
				                    					InvBId.HasChanged = false;
									InvBType.HasChanged = false;
									InvBPrintedOn.HasChanged = false;
									InvBExportedDate.HasChanged = false;
									InvBExported.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "InvBId":
					return (IDSFieldBase)InvBId;
								case "InvBType":
					return (IDSFieldBase)InvBType;
								case "InvBPrintedOn":
					return (IDSFieldBase)InvBPrintedOn;
								case "InvBExportedDate":
					return (IDSFieldBase)InvBExportedDate;
								case "InvBExported":
					return (IDSFieldBase)InvBExported;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "InvBId":
					return InvBId.DisplayValue;
								case "InvBType":
					return InvBType.DisplayValue;
								case "InvBPrintedOn":
					return InvBPrintedOn.DisplayValue;
								case "InvBExportedDate":
					return InvBExportedDate.DisplayValue;
								case "InvBExported":
					return InvBExported.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "InvBId":
					return InvBId.Value.ToString();
								case "InvBType":
					return InvBType.Value.ToString();
								case "InvBPrintedOn":
					return InvBPrintedOn.Value.ToString();
								case "InvBExportedDate":
					return InvBExportedDate.Value.ToString();
								case "InvBExported":
					return InvBExported.Value.ToString();
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
					foreach(var itm in DS.GetManager<InvBatch>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public InvBatch () : base("InvBatch") {
		base.obj = this;
	
					InvBId = new InvBatch_InvBId(this);
					InvBType = new InvBatch_InvBType(this);
					InvBPrintedOn = new InvBatch_InvBPrintedOn(this);
					InvBExportedDate = new InvBatch_InvBExportedDate(this);
					InvBExported = new InvBatch_InvBExported(this);
			}

	static InvBatch () {
					InvBIdField = new InvBatch_InvBIdFieldDef();
					InvBTypeField = new InvBatch_InvBTypeFieldDef();
					InvBPrintedOnField = new InvBatch_InvBPrintedOnFieldDef();
					InvBExportedDateField = new InvBatch_InvBExportedDateFieldDef();
					InvBExportedField = new InvBatch_InvBExportedFieldDef();
			}

	public string RecordTitle { 
		get { return InvBIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Invoice Batches"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/InvBatch/Load/?RecId=" + RecordID.Value;
			}
			return "/InvBatch/Add";
			}
	}

			
		
		[Ignore()]
		public InvBatch_InvBId InvBId { get; set; }
		public static InvBatch_InvBIdFieldDef InvBIdField { get; private set; }
        
			
			[Column("InvBId")]
			public  int PopulateInvBId  {
				get { return InvBIdValue ;}
				set { InvBId.DataValue = value; }
			}

	
			public int InvBIdValue 
			{ 
				get 
				{
				   if(InvBId.Value != null) {
				   					int i = 0;
					if (InvBId != null)
					{
						if (InvBId.Value != null)
						{
							if (Int32.TryParse(InvBId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvBId.Value = value;  }
			}
			
		
		[Ignore()]
		public InvBatch_InvBType InvBType { get; set; }
		public static InvBatch_InvBTypeFieldDef InvBTypeField { get; private set; }
        
			
			[Column("InvBType")]
			public  int PopulateInvBType  {
				get { return InvBTypeValue ;}
				set { InvBType.DataValue = value; }
			}

	
			public int InvBTypeValue 
			{ 
				get 
				{
				   if(InvBType.Value != null) {
				   					int i = 0;
					if (InvBType != null)
					{
						if (InvBType.Value != null)
						{
							if (Int32.TryParse(InvBType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvBType.Value = value;  }
			}
			
		
		[Ignore()]
		public InvBatch_InvBPrintedOn InvBPrintedOn { get; set; }
		public static InvBatch_InvBPrintedOnFieldDef InvBPrintedOnField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("InvBPrintedOn")]
			public  DateTime PopulateInvBPrintedOn  {
				get { return InvBPrintedOnValue ;}
				set { InvBPrintedOn.DataValue = value; }
			}

	
			public DateTime InvBPrintedOnValue 
			{ 
				get 
				{
				   if(InvBPrintedOn.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (InvBPrintedOn != null)
					{
						if (InvBPrintedOn.Value != null)
						{
							if (DateTime.TryParse(InvBPrintedOn.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { InvBPrintedOn.Value = value;  }
			}
			
		
		[Ignore()]
		public InvBatch_InvBExportedDate InvBExportedDate { get; set; }
		public static InvBatch_InvBExportedDateFieldDef InvBExportedDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("InvBExportedDate")]
			public  DateTime PopulateInvBExportedDate  {
				get { return InvBExportedDateValue ;}
				set { InvBExportedDate.DataValue = value; }
			}

	
			public DateTime InvBExportedDateValue 
			{ 
				get 
				{
				   if(InvBExportedDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (InvBExportedDate != null)
					{
						if (InvBExportedDate.Value != null)
						{
							if (DateTime.TryParse(InvBExportedDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { InvBExportedDate.Value = value;  }
			}
			
		
		[Ignore()]
		public InvBatch_InvBExported InvBExported { get; set; }
		public static InvBatch_InvBExportedFieldDef InvBExportedField { get; private set; }
        
			
			[Column("InvBExported")]
			public  bool PopulateInvBExported  {
				get { return InvBExportedValue ;}
				set { InvBExported.DataValue = value; }
			}

	
			public bool InvBExportedValue 
			{ 
				get 
				{
				   if(InvBExported.Value != null) {
				   					bool i = false;
					if (InvBExported != null)
					{
						if (InvBExported.Value != null)
						{
							if (Boolean.TryParse(InvBExported.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvBExported.Value = value;  }
			}
	}


public class InvBatch_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 23;
    public int PixelHeight => 0;
	public string Title => "Invoice Batches";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
