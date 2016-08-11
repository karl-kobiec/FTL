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


public partial class DutyRateHistController : DSBaseController<DutyRateHist/*,DutyRateHistSearch*/> {
	public DutyRateHistController() : base ((IDatabase)IQApp.DB, new DutyRateHistRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select DRHId from DutyRateHist where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<DutyRateHist>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(DutyRateHist data) {
						IQApp.DB.Execute("Delete from DutyRateHist where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.DRHTaxCodeValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from DutyRateHist " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from DutyRateHist " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from DutyRateHist " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/DutyRateHist_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<DutyRateHist>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<DutyRateHist>("select * from DutyRateHist  ").ToList();
		string urlpath = "/temp/Duty Rate History Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Duty Rate History");
				
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
							
					worksheet.Column(1).Width = 38;
					worksheet.Cells[1, 1].Value = "Date of Change";
						
								
					worksheet.Column(2).Width = 31;
					worksheet.Cells[1, 2].Value = "Tax Code";
						
								
					worksheet.Column(3).Width = 31;
					worksheet.Cells[1, 3].Value = "Duty Rate";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].DRHChangeDate.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].DRHTaxCode.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].DRHDutyRate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDRHTaxCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DutyRateHist>("select * from DutyRateHist where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DRHTaxCodeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHTaxCode" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHTaxCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteDRHTaxCode(DutyRateHist m, int? id, string q) {

		
		string s = m.DRHTaxCode.DataSource;
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
	public ActionResult CallbackDRHTaxCode(DutyRateHist obj) {
			
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHTaxCode" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHTaxCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDRHChangeDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DutyRateHist>("select * from DutyRateHist where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DRHChangeDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHChangeDate" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHChangeDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDRHChangeDate(DutyRateHist obj) {
			
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHChangeDate" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHChangeDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDRHDutyRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DutyRateHist>("select * from DutyRateHist where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DRHDutyRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHDutyRate" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHDutyRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDRHDutyRate(DutyRateHist obj) {
			
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHDutyRate" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHDutyRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDRHAlcPct(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DutyRateHist>("select * from DutyRateHist where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DRHAlcPctValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHAlcPct" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHAlcPct")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDRHAlcPct(DutyRateHist obj) {
			
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHAlcPct" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHAlcPct")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDRHId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DutyRateHist>("select * from DutyRateHist where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DRHIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHId" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDRHId(DutyRateHist obj) {
			
		if(DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHId" ).Any()) {
			foreach(var itm in DS.GetManager<DutyRateHist>().OnChange.Where(f=> f.Key == "DRHId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DutyRateHist>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=38 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/DutyRateHist/Search/" + FirstSearch);
		
		return Redirect("/DutyRateHist/List/");
	}

}

public partial class DutyRateHistRepository : DSRepository<DutyRateHist> {
	public DutyRateHistRepository() : base(38, "DutyRateHist", "Duty Rate History") {
	}
}
public partial class DutyRateHist 
: DatasetBase<DutyRateHist>, IDSBase

  {
	  public int KeyValue => DRHIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "DRHTaxCode":
			return DRHTaxCodeField;
				case "DRHChangeDate":
			return DRHChangeDateField;
				case "DRHDutyRate":
			return DRHDutyRateField;
				case "DRHAlcPct":
			return DRHAlcPctField;
				case "DRHId":
			return DRHIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(DRHTaxCode,DRHTaxCodeField);
				action(DRHChangeDate,DRHChangeDateField);
				action(DRHDutyRate,DRHDutyRateField);
				action(DRHAlcPct,DRHAlcPctField);
				action(DRHId,DRHIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				DRHTaxCode.Visible=false;DRHChangeDate.Visible=false;DRHDutyRate.Visible=false;DRHAlcPct.Visible=false;DRHId.Visible=false;			break;
					case 3:
				DRHTaxCode.Visible=false;DRHChangeDate.Visible=false;DRHDutyRate.Visible=false;DRHAlcPct.Visible=false;DRHId.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update DutyRateHist set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (DRHTaxCode.HasChanged && DRHTaxCode.HasValue) {
					SQL += ", DRHTaxCode=@DRHTaxCodeValue";

				}
								if (DRHChangeDate.HasChanged && DRHChangeDate.HasValue) {
					SQL += ", DRHChangeDate=@DRHChangeDateValue";

				}
								if (DRHDutyRate.HasChanged && DRHDutyRate.HasValue) {
					SQL += ", DRHDutyRate=@DRHDutyRateValue";

				}
								if (DRHAlcPct.HasChanged && DRHAlcPct.HasValue) {
					SQL += ", DRHAlcPct=@DRHAlcPctValue";

				}
								if (DRHId.HasChanged && DRHId.HasValue) {
					SQL += ", DRHId=@DRHIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									DRHTaxCode.HasChanged = false;
									DRHChangeDate.HasChanged = false;
									DRHDutyRate.HasChanged = false;
									DRHAlcPct.HasChanged = false;
									DRHId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into DutyRateHist(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (DRHTaxCode.HasValue) {
					SQL += ", DRHTaxCode";
					Values += ", @DRHTaxCodeValue";
				}
				
				if (DRHChangeDate.HasValue) {
					SQL += ", DRHChangeDate";
					Values += ", @DRHChangeDateValue";
				}
				
				if (DRHDutyRate.HasValue) {
					SQL += ", DRHDutyRate";
					Values += ", @DRHDutyRateValue";
				}
				
				if (DRHAlcPct.HasValue) {
					SQL += ", DRHAlcPct";
					Values += ", @DRHAlcPctValue";
				}
				DRHId.Value = IQApp.DB.GetInt("select isnull(max(DRHId),0)+1 from DutyRateHist");
				if (DRHId.HasValue) {
					SQL += ", DRHId";
					Values += ", @DRHIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from DutyRateHist");
					 IQApp.DB.Execute(SQL, this);
				                    					DRHTaxCode.HasChanged = false;
									DRHChangeDate.HasChanged = false;
									DRHDutyRate.HasChanged = false;
									DRHAlcPct.HasChanged = false;
									DRHId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "DRHTaxCode":
					return (IDSFieldBase)DRHTaxCode;
								case "DRHChangeDate":
					return (IDSFieldBase)DRHChangeDate;
								case "DRHDutyRate":
					return (IDSFieldBase)DRHDutyRate;
								case "DRHAlcPct":
					return (IDSFieldBase)DRHAlcPct;
								case "DRHId":
					return (IDSFieldBase)DRHId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "DRHTaxCode":
					return DRHTaxCode.DisplayValue;
								case "DRHChangeDate":
					return DRHChangeDate.DisplayValue;
								case "DRHDutyRate":
					return DRHDutyRate.DisplayValue;
								case "DRHAlcPct":
					return DRHAlcPct.DisplayValue;
								case "DRHId":
					return DRHId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "DRHTaxCode":
					return DRHTaxCode.Value.ToString();
								case "DRHChangeDate":
					return DRHChangeDate.Value.ToString();
								case "DRHDutyRate":
					return DRHDutyRate.Value.ToString();
								case "DRHAlcPct":
					return DRHAlcPct.Value.ToString();
								case "DRHId":
					return DRHId.Value.ToString();
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
					foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public DutyRateHist () : base("DutyRateHist") {
		base.obj = this;
	
					DRHTaxCode = new DutyRateHist_DRHTaxCode(this);
					DRHChangeDate = new DutyRateHist_DRHChangeDate(this);
					DRHDutyRate = new DutyRateHist_DRHDutyRate(this);
					DRHAlcPct = new DutyRateHist_DRHAlcPct(this);
					DRHId = new DutyRateHist_DRHId(this);
			}

	static DutyRateHist () {
					DRHTaxCodeField = new DutyRateHist_DRHTaxCodeFieldDef();
					DRHChangeDateField = new DutyRateHist_DRHChangeDateFieldDef();
					DRHDutyRateField = new DutyRateHist_DRHDutyRateFieldDef();
					DRHAlcPctField = new DutyRateHist_DRHAlcPctFieldDef();
					DRHIdField = new DutyRateHist_DRHIdFieldDef();
			}

	public string RecordTitle { 
		get { return DRHTaxCodeValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Duty Rate History"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/DutyRateHist/Load/?RecId=" + RecordID.Value;
			}
			return "/DutyRateHist/Add";
			}
	}

			
		
		[Ignore()]
		public DutyRateHist_DRHTaxCode DRHTaxCode { get; set; }
		public static DutyRateHist_DRHTaxCodeFieldDef DRHTaxCodeField { get; private set; }
        
			
			[Column("DRHTaxCode")]
			public  int PopulateDRHTaxCode  {
				get { return DRHTaxCodeValue ;}
				set { DRHTaxCode.DataValue = value; }
			}

	
			public int DRHTaxCodeValue 
			{ 
				get 
				{
				   if(DRHTaxCode.Value != null) {
				   					int i = 0;
					if (DRHTaxCode != null)
					{
						if (DRHTaxCode.Value != null)
						{
							if (Int32.TryParse(DRHTaxCode.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DRHTaxCode.Value = value;  }
			}
			
		
		[Ignore()]
		public DutyRateHist_DRHChangeDate DRHChangeDate { get; set; }
		public static DutyRateHist_DRHChangeDateFieldDef DRHChangeDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("DRHChangeDate")]
			public  DateTime PopulateDRHChangeDate  {
				get { return DRHChangeDateValue ;}
				set { DRHChangeDate.DataValue = value; }
			}

	
			public DateTime DRHChangeDateValue 
			{ 
				get 
				{
				   if(DRHChangeDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (DRHChangeDate != null)
					{
						if (DRHChangeDate.Value != null)
						{
							if (DateTime.TryParse(DRHChangeDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { DRHChangeDate.Value = value;  }
			}
			
		
		[Ignore()]
		public DutyRateHist_DRHDutyRate DRHDutyRate { get; set; }
		public static DutyRateHist_DRHDutyRateFieldDef DRHDutyRateField { get; private set; }
        
			
			[Column("DRHDutyRate")]
			public  double PopulateDRHDutyRate  {
				get { return DRHDutyRateValue ;}
				set { DRHDutyRate.DataValue = value; }
			}

	
			public double DRHDutyRateValue 
			{ 
				get 
				{
				   if(DRHDutyRate.Value != null) {
				   					double i = 0.0;
					if (DRHDutyRate != null)
					{
						if (DRHDutyRate.Value != null)
						{
							if (Double.TryParse(DRHDutyRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { DRHDutyRate.Value = value;  }
			}
			
		
		[Ignore()]
		public DutyRateHist_DRHAlcPct DRHAlcPct { get; set; }
		public static DutyRateHist_DRHAlcPctFieldDef DRHAlcPctField { get; private set; }
        
			
			[Column("DRHAlcPct")]
			public  double PopulateDRHAlcPct  {
				get { return DRHAlcPctValue ;}
				set { DRHAlcPct.DataValue = value; }
			}

	
			public double DRHAlcPctValue 
			{ 
				get 
				{
				   if(DRHAlcPct.Value != null) {
				   					double i = 0.0;
					if (DRHAlcPct != null)
					{
						if (DRHAlcPct.Value != null)
						{
							if (Double.TryParse(DRHAlcPct.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { DRHAlcPct.Value = value;  }
			}
			
		
		[Ignore()]
		public DutyRateHist_DRHId DRHId { get; set; }
		public static DutyRateHist_DRHIdFieldDef DRHIdField { get; private set; }
        
			
			[Column("DRHId")]
			public  int PopulateDRHId  {
				get { return DRHIdValue ;}
				set { DRHId.DataValue = value; }
			}

	
			public int DRHIdValue 
			{ 
				get 
				{
				   if(DRHId.Value != null) {
				   					int i = 0;
					if (DRHId != null)
					{
						if (DRHId.Value != null)
						{
							if (Int32.TryParse(DRHId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DRHId.Value = value;  }
			}
	}


public class DutyRateHist_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 38;
    public int PixelHeight => 0;
	public string Title => "Duty Rate History";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
