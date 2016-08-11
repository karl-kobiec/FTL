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


public partial class REDSTaxController : DSBaseController<REDSTax/*,REDSTaxSearch*/> {
	public REDSTaxController() : base ((IDatabase)IQApp.DB, new REDSTaxRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select RDTaxId from REDSTax where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<REDSTax>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(REDSTax data) {
						IQApp.DB.Execute("Delete from REDSTax where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.RDTaxCodeValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from REDSTax " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from REDSTax " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from REDSTax " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/REDSTax_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<REDSTax>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<REDSTax>("select * from REDSTax  ").ToList();
		string urlpath = "/temp/REDS Tax Codes Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("REDS Tax Codes");
				
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
							
					worksheet.Column(1).Width = 32;
					worksheet.Cells[1, 1].Value = "Tax Code";
						
								
					worksheet.Column(2).Width = 16;
					worksheet.Cells[1, 2].Value = "Type";
						
								
					worksheet.Column(3).Width = 26;
					worksheet.Cells[1, 3].Value = "Alcohol Percentage";
						
								
					worksheet.Column(4).Width = 26;
					worksheet.Cells[1, 4].Value = "Duty Rate £ per ltr";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].RDTaxCode.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].RDTaxType.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].RDTaxAlcPct.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].RDTaxDutyRate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDTaxCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSTax>("select * from REDSTax where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDTaxCodeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxCode" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDTaxCode(REDSTax obj) {
			
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxCode" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDTaxAlcPct(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSTax>("select * from REDSTax where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDTaxAlcPctValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxAlcPct" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxAlcPct")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDTaxAlcPct(REDSTax obj) {
			
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxAlcPct" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxAlcPct")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDTaxType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSTax>("select * from REDSTax where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDTaxTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxType" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDTaxType(REDSTax obj) {
			
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxType" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDTaxDutyRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSTax>("select * from REDSTax where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDTaxDutyRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxDutyRate" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxDutyRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDTaxDutyRate(REDSTax obj) {
			
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxDutyRate" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxDutyRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDTaxId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSTax>("select * from REDSTax where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDTaxIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDTaxId(REDSTax obj) {
			
		if(DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSTax>().OnChange.Where(f=> f.Key == "RDTaxId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSTax>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/REDSTax/List/");
	}

}

public partial class REDSTaxRepository : DSRepository<REDSTax> {
	public REDSTaxRepository() : base(37, "REDSTax", "REDS Tax Codes") {
	}
}
public partial class REDSTax 
: DatasetBase<REDSTax>, IDSBase

  {
	  public int KeyValue => RDTaxIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "RDTaxCode":
			return RDTaxCodeField;
				case "RDTaxAlcPct":
			return RDTaxAlcPctField;
				case "RDTaxType":
			return RDTaxTypeField;
				case "RDTaxDutyRate":
			return RDTaxDutyRateField;
				case "RDTaxId":
			return RDTaxIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(RDTaxCode,RDTaxCodeField);
				action(RDTaxAlcPct,RDTaxAlcPctField);
				action(RDTaxType,RDTaxTypeField);
				action(RDTaxDutyRate,RDTaxDutyRateField);
				action(RDTaxId,RDTaxIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				RDTaxCode.Visible=false;RDTaxAlcPct.Visible=false;RDTaxType.Visible=false;RDTaxDutyRate.Visible=false;RDTaxId.Visible=false;			break;
					case 3:
				RDTaxCode.Visible=false;RDTaxAlcPct.Visible=false;RDTaxType.Visible=false;RDTaxDutyRate.Visible=false;RDTaxId.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update REDSTax set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (RDTaxCode.HasChanged && RDTaxCode.HasValue) {
					SQL += ", RDTaxCode=@RDTaxCodeValue";

				}
								if (RDTaxAlcPct.HasChanged && RDTaxAlcPct.HasValue) {
					SQL += ", RDTaxAlcPct=@RDTaxAlcPctValue";

				}
								if (RDTaxType.HasChanged && RDTaxType.HasValue) {
					SQL += ", RDTaxType=@RDTaxTypeValue";

				}
								if (RDTaxDutyRate.HasChanged && RDTaxDutyRate.HasValue) {
					SQL += ", RDTaxDutyRate=@RDTaxDutyRateValue";

				}
								if (RDTaxId.HasChanged && RDTaxId.HasValue) {
					SQL += ", RDTaxId=@RDTaxIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									RDTaxCode.HasChanged = false;
									RDTaxAlcPct.HasChanged = false;
									RDTaxType.HasChanged = false;
									RDTaxDutyRate.HasChanged = false;
									RDTaxId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into REDSTax(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (RDTaxCode.HasValue) {
					SQL += ", RDTaxCode";
					Values += ", @RDTaxCodeValue";
				}
				
				if (RDTaxAlcPct.HasValue) {
					SQL += ", RDTaxAlcPct";
					Values += ", @RDTaxAlcPctValue";
				}
				
				if (RDTaxType.HasValue) {
					SQL += ", RDTaxType";
					Values += ", @RDTaxTypeValue";
				}
				
				if (RDTaxDutyRate.HasValue) {
					SQL += ", RDTaxDutyRate";
					Values += ", @RDTaxDutyRateValue";
				}
				RDTaxId.Value = IQApp.DB.GetInt("select isnull(max(RDTaxId),0)+1 from REDSTax");
				if (RDTaxId.HasValue) {
					SQL += ", RDTaxId";
					Values += ", @RDTaxIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from REDSTax");
					 IQApp.DB.Execute(SQL, this);
				                    					RDTaxCode.HasChanged = false;
									RDTaxAlcPct.HasChanged = false;
									RDTaxType.HasChanged = false;
									RDTaxDutyRate.HasChanged = false;
									RDTaxId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "RDTaxCode":
					return (IDSFieldBase)RDTaxCode;
								case "RDTaxAlcPct":
					return (IDSFieldBase)RDTaxAlcPct;
								case "RDTaxType":
					return (IDSFieldBase)RDTaxType;
								case "RDTaxDutyRate":
					return (IDSFieldBase)RDTaxDutyRate;
								case "RDTaxId":
					return (IDSFieldBase)RDTaxId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "RDTaxCode":
					return RDTaxCode.DisplayValue;
								case "RDTaxAlcPct":
					return RDTaxAlcPct.DisplayValue;
								case "RDTaxType":
					return RDTaxType.DisplayValue;
								case "RDTaxDutyRate":
					return RDTaxDutyRate.DisplayValue;
								case "RDTaxId":
					return RDTaxId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "RDTaxCode":
					return RDTaxCode.Value.ToString();
								case "RDTaxAlcPct":
					return RDTaxAlcPct.Value.ToString();
								case "RDTaxType":
					return RDTaxType.Value.ToString();
								case "RDTaxDutyRate":
					return RDTaxDutyRate.Value.ToString();
								case "RDTaxId":
					return RDTaxId.Value.ToString();
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
					foreach(var itm in DS.GetManager<REDSTax>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public REDSTax () : base("REDSTax") {
		base.obj = this;
	
					RDTaxCode = new REDSTax_RDTaxCode(this);
					RDTaxAlcPct = new REDSTax_RDTaxAlcPct(this);
					RDTaxType = new REDSTax_RDTaxType(this);
					RDTaxDutyRate = new REDSTax_RDTaxDutyRate(this);
					RDTaxId = new REDSTax_RDTaxId(this);
			}

	static REDSTax () {
					RDTaxCodeField = new REDSTax_RDTaxCodeFieldDef();
					RDTaxAlcPctField = new REDSTax_RDTaxAlcPctFieldDef();
					RDTaxTypeField = new REDSTax_RDTaxTypeFieldDef();
					RDTaxDutyRateField = new REDSTax_RDTaxDutyRateFieldDef();
					RDTaxIdField = new REDSTax_RDTaxIdFieldDef();
			}

	public string RecordTitle { 
		get { return RDTaxCodeValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "REDS Tax Codes"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/REDSTax/Load/?RecId=" + RecordID.Value;
			}
			return "/REDSTax/Add";
			}
	}

			
		
		[Ignore()]
		public REDSTax_RDTaxCode RDTaxCode { get; set; }
		public static REDSTax_RDTaxCodeFieldDef RDTaxCodeField { get; private set; }
        
			
			[Column("RDTaxCode")]
			public  string PopulateRDTaxCode  {
				get { return RDTaxCodeValue ;}
				set { RDTaxCode.DataValue = value; }
			}

	
			public string RDTaxCodeValue 
			{ 
				get 
				{
				   if(RDTaxCode.Value != null) {
				   return RDTaxCode.Value.ToString(); 					}
					return "";
                
				}
				set { RDTaxCode.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSTax_RDTaxAlcPct RDTaxAlcPct { get; set; }
		public static REDSTax_RDTaxAlcPctFieldDef RDTaxAlcPctField { get; private set; }
        
			
			[Column("RDTaxAlcPct")]
			public  double PopulateRDTaxAlcPct  {
				get { return RDTaxAlcPctValue ;}
				set { RDTaxAlcPct.DataValue = value; }
			}

	
			public double RDTaxAlcPctValue 
			{ 
				get 
				{
				   if(RDTaxAlcPct.Value != null) {
				   					double i = 0.0;
					if (RDTaxAlcPct != null)
					{
						if (RDTaxAlcPct.Value != null)
						{
							if (Double.TryParse(RDTaxAlcPct.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { RDTaxAlcPct.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSTax_RDTaxType RDTaxType { get; set; }
		public static REDSTax_RDTaxTypeFieldDef RDTaxTypeField { get; private set; }
        
			
			[Column("RDTaxType")]
			public  int PopulateRDTaxType  {
				get { return RDTaxTypeValue ;}
				set { RDTaxType.DataValue = value; }
			}

	
			public int RDTaxTypeValue 
			{ 
				get 
				{
				   if(RDTaxType.Value != null) {
				   					int i = 0;
					if (RDTaxType != null)
					{
						if (RDTaxType.Value != null)
						{
							if (Int32.TryParse(RDTaxType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDTaxType.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSTax_RDTaxDutyRate RDTaxDutyRate { get; set; }
		public static REDSTax_RDTaxDutyRateFieldDef RDTaxDutyRateField { get; private set; }
        
			
			[Column("RDTaxDutyRate")]
			public  double PopulateRDTaxDutyRate  {
				get { return RDTaxDutyRateValue ;}
				set { RDTaxDutyRate.DataValue = value; }
			}

	
			public double RDTaxDutyRateValue 
			{ 
				get 
				{
				   if(RDTaxDutyRate.Value != null) {
				   					double i = 0.0;
					if (RDTaxDutyRate != null)
					{
						if (RDTaxDutyRate.Value != null)
						{
							if (Double.TryParse(RDTaxDutyRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { RDTaxDutyRate.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSTax_RDTaxId RDTaxId { get; set; }
		public static REDSTax_RDTaxIdFieldDef RDTaxIdField { get; private set; }
        
			
			[Column("RDTaxId")]
			public  int PopulateRDTaxId  {
				get { return RDTaxIdValue ;}
				set { RDTaxId.DataValue = value; }
			}

	
			public int RDTaxIdValue 
			{ 
				get 
				{
				   if(RDTaxId.Value != null) {
				   					int i = 0;
					if (RDTaxId != null)
					{
						if (RDTaxId.Value != null)
						{
							if (Int32.TryParse(RDTaxId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDTaxId.Value = value;  }
			}
	}


public class REDSTax_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 37;
    public int PixelHeight => 0;
	public string Title => "REDS Tax Codes";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
