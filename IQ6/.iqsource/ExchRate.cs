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


public partial class ExchRateController : DSBaseController<ExchRate/*,ExchRateSearch*/> {
	public ExchRateController() : base ((IDatabase)IQApp.DB, new ExchRateRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select ExRId from ExchRate where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<ExchRate>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(ExchRate data) {
						IQApp.DB.Execute("Delete from ExchRate where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.ExRNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from ExchRate " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from ExchRate " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from ExchRate " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/ExchRate_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<ExchRate>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<ExchRate>("select * from ExchRate  ").ToList();
		string urlpath = "/temp/Exchange Rates Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Exchange Rates");
				
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
							
					worksheet.Column(1).Width = 17;
					worksheet.Cells[1, 1].Value = "Period Rate ID";
						
								
					worksheet.Column(2).Width = 33;
					worksheet.Cells[1, 2].Value = "Period Rate";
						
								
					worksheet.Column(3).Width = 17;
					worksheet.Cells[1, 3].Value = "Rate";
						
								
					worksheet.Column(4).Width = 17;
					worksheet.Cells[1, 4].Value = "From";
						
								
					worksheet.Column(5).Width = 17;
					worksheet.Cells[1, 5].Value = "To";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].ExRId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].ExRName.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].ExRRate.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].ExRSDate.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].ExREDate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveExRId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ExchRate>("select * from ExchRate where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.ExRIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRId" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackExRId(ExchRate obj) {
			
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRId" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveExRName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ExchRate>("select * from ExchRate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ExRNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRName" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackExRName(ExchRate obj) {
			
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRName" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveExRRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ExchRate>("select * from ExchRate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.ExRRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRRate" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackExRRate(ExchRate obj) {
			
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRRate" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveExRSDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ExchRate>("select * from ExchRate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.ExRSDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRSDate" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRSDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackExRSDate(ExchRate obj) {
			
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRSDate" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExRSDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveExREDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<ExchRate>("select * from ExchRate where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.ExREDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExREDate" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExREDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackExREDate(ExchRate obj) {
			
		if(DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExREDate" ).Any()) {
			foreach(var itm in DS.GetManager<ExchRate>().OnChange.Where(f=> f.Key == "ExREDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<ExchRate>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=18 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/ExchRate/Search/" + FirstSearch);
		
		return Redirect("/ExchRate/List/");
	}

}

public partial class ExchRateRepository : DSRepository<ExchRate> {
	public ExchRateRepository() : base(18, "ExchRate", "Exchange Rates") {
	}
}
public partial class ExchRate 
: DatasetBase<ExchRate>, IDSBase

  {
	  public int KeyValue => ExRIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "ExRId":
			return ExRIdField;
				case "ExRName":
			return ExRNameField;
				case "ExRRate":
			return ExRRateField;
				case "ExRSDate":
			return ExRSDateField;
				case "ExREDate":
			return ExREDateField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(ExRId,ExRIdField);
				action(ExRName,ExRNameField);
				action(ExRRate,ExRRateField);
				action(ExRSDate,ExRSDateField);
				action(ExREDate,ExREDateField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				ExRId.Visible=false;ExRName.Visible=false;ExRRate.Visible=false;ExRSDate.Visible=false;ExREDate.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update ExchRate set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (ExRId.HasChanged && ExRId.HasValue) {
					SQL += ", ExRId=@ExRIdValue";

				}
								if (ExRName.HasChanged && ExRName.HasValue) {
					SQL += ", ExRName=@ExRNameValue";

				}
								if (ExRRate.HasChanged && ExRRate.HasValue) {
					SQL += ", ExRRate=@ExRRateValue";

				}
								if (ExRSDate.HasChanged && ExRSDate.HasValue) {
					SQL += ", ExRSDate=@ExRSDateValue";

				}
								if (ExREDate.HasChanged && ExREDate.HasValue) {
					SQL += ", ExREDate=@ExREDateValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									ExRId.HasChanged = false;
									ExRName.HasChanged = false;
									ExRRate.HasChanged = false;
									ExRSDate.HasChanged = false;
									ExREDate.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into ExchRate(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				ExRId.Value = IQApp.DB.GetInt("select isnull(max(ExRId),0)+1 from ExchRate");
				if (ExRId.HasValue) {
					SQL += ", ExRId";
					Values += ", @ExRIdValue";
				}
				
				if (ExRName.HasValue) {
					SQL += ", ExRName";
					Values += ", @ExRNameValue";
				}
				
				if (ExRRate.HasValue) {
					SQL += ", ExRRate";
					Values += ", @ExRRateValue";
				}
				
				if (ExRSDate.HasValue) {
					SQL += ", ExRSDate";
					Values += ", @ExRSDateValue";
				}
				
				if (ExREDate.HasValue) {
					SQL += ", ExREDate";
					Values += ", @ExREDateValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from ExchRate");
					 IQApp.DB.Execute(SQL, this);
				                    					ExRId.HasChanged = false;
									ExRName.HasChanged = false;
									ExRRate.HasChanged = false;
									ExRSDate.HasChanged = false;
									ExREDate.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "ExRId":
					return (IDSFieldBase)ExRId;
								case "ExRName":
					return (IDSFieldBase)ExRName;
								case "ExRRate":
					return (IDSFieldBase)ExRRate;
								case "ExRSDate":
					return (IDSFieldBase)ExRSDate;
								case "ExREDate":
					return (IDSFieldBase)ExREDate;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "ExRId":
					return ExRId.DisplayValue;
								case "ExRName":
					return ExRName.DisplayValue;
								case "ExRRate":
					return ExRRate.DisplayValue;
								case "ExRSDate":
					return ExRSDate.DisplayValue;
								case "ExREDate":
					return ExREDate.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "ExRId":
					return ExRId.Value.ToString();
								case "ExRName":
					return ExRName.Value.ToString();
								case "ExRRate":
					return ExRRate.Value.ToString();
								case "ExRSDate":
					return ExRSDate.Value.ToString();
								case "ExREDate":
					return ExREDate.Value.ToString();
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
					foreach(var itm in DS.GetManager<ExchRate>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public ExchRate () : base("ExchRate") {
		base.obj = this;
	
					ExRId = new ExchRate_ExRId(this);
					ExRName = new ExchRate_ExRName(this);
					ExRRate = new ExchRate_ExRRate(this);
					ExRSDate = new ExchRate_ExRSDate(this);
					ExREDate = new ExchRate_ExREDate(this);
			}

	static ExchRate () {
					ExRIdField = new ExchRate_ExRIdFieldDef();
					ExRNameField = new ExchRate_ExRNameFieldDef();
					ExRRateField = new ExchRate_ExRRateFieldDef();
					ExRSDateField = new ExchRate_ExRSDateFieldDef();
					ExREDateField = new ExchRate_ExREDateFieldDef();
			}

	public string RecordTitle { 
		get { return ExRNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Exchange Rates"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/ExchRate/Load/?RecId=" + RecordID.Value;
			}
			return "/ExchRate/Add";
			}
	}

			
		
		[Ignore()]
		public ExchRate_ExRId ExRId { get; set; }
		public static ExchRate_ExRIdFieldDef ExRIdField { get; private set; }
        
			
			[Column("ExRId")]
			public  int PopulateExRId  {
				get { return ExRIdValue ;}
				set { ExRId.DataValue = value; }
			}

	
			public int ExRIdValue 
			{ 
				get 
				{
				   if(ExRId.Value != null) {
				   					int i = 0;
					if (ExRId != null)
					{
						if (ExRId.Value != null)
						{
							if (Int32.TryParse(ExRId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { ExRId.Value = value;  }
			}
			
		
		[Ignore()]
		public ExchRate_ExRName ExRName { get; set; }
		public static ExchRate_ExRNameFieldDef ExRNameField { get; private set; }
        
			
			[Column("ExRName")]
			public  string PopulateExRName  {
				get { return ExRNameValue ;}
				set { ExRName.DataValue = value; }
			}

	
			public string ExRNameValue 
			{ 
				get 
				{
				   if(ExRName.Value != null) {
				   return ExRName.Value.ToString(); 					}
					return "";
                
				}
				set { ExRName.Value = value;  }
			}
			
		
		[Ignore()]
		public ExchRate_ExRRate ExRRate { get; set; }
		public static ExchRate_ExRRateFieldDef ExRRateField { get; private set; }
        
			
			[Column("ExRRate")]
			public  double PopulateExRRate  {
				get { return ExRRateValue ;}
				set { ExRRate.DataValue = value; }
			}

	
			public double ExRRateValue 
			{ 
				get 
				{
				   if(ExRRate.Value != null) {
				   					double i = 0.0;
					if (ExRRate != null)
					{
						if (ExRRate.Value != null)
						{
							if (Double.TryParse(ExRRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { ExRRate.Value = value;  }
			}
			
		
		[Ignore()]
		public ExchRate_ExRSDate ExRSDate { get; set; }
		public static ExchRate_ExRSDateFieldDef ExRSDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("ExRSDate")]
			public  DateTime PopulateExRSDate  {
				get { return ExRSDateValue ;}
				set { ExRSDate.DataValue = value; }
			}

	
			public DateTime ExRSDateValue 
			{ 
				get 
				{
				   if(ExRSDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (ExRSDate != null)
					{
						if (ExRSDate.Value != null)
						{
							if (DateTime.TryParse(ExRSDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { ExRSDate.Value = value;  }
			}
			
		
		[Ignore()]
		public ExchRate_ExREDate ExREDate { get; set; }
		public static ExchRate_ExREDateFieldDef ExREDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("ExREDate")]
			public  DateTime PopulateExREDate  {
				get { return ExREDateValue ;}
				set { ExREDate.DataValue = value; }
			}

	
			public DateTime ExREDateValue 
			{ 
				get 
				{
				   if(ExREDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (ExREDate != null)
					{
						if (ExREDate.Value != null)
						{
							if (DateTime.TryParse(ExREDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { ExREDate.Value = value;  }
			}
	}


public class ExchRate_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 18;
    public int PixelHeight => 0;
	public string Title => "Exchange Rates";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
