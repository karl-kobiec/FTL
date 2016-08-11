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


public partial class VATCodesController : DSBaseController<VATCodes/*,VATCodesSearch*/> {
	public VATCodesController() : base ((IDatabase)IQApp.DB, new VATCodesRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select VATId from VATCodes where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<VATCodes>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(VATCodes data) {
						IQApp.DB.Execute("Delete from VATCodes where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.VATCodeValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from VATCodes " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from VATCodes " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from VATCodes " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/VATCodes_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<VATCodes>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<VATCodes>("select * from VATCodes  ").ToList();
		string urlpath = "/temp/VAT Codes Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("VAT Codes");
				
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
							
					worksheet.Column(1).Width = 29;
					worksheet.Cells[1, 1].Value = "VAT Code";
						
								
					worksheet.Column(2).Width = 47;
					worksheet.Cells[1, 2].Value = "Description";
						
								
					worksheet.Column(3).Width = 24;
					worksheet.Cells[1, 3].Value = "VAT Rate";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].VATCode.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].VATName.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].VATRate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveVATCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<VATCodes>("select * from VATCodes where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.VATCodeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATCode" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackVATCode(VATCodes obj) {
			
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATCode" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveVATName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<VATCodes>("select * from VATCodes where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.VATNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATName" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackVATName(VATCodes obj) {
			
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATName" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveVATRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<VATCodes>("select * from VATCodes where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.VATRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATRate" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackVATRate(VATCodes obj) {
			
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATRate" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveVATId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<VATCodes>("select * from VATCodes where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.VATIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATId" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackVATId(VATCodes obj) {
			
		if(DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATId" ).Any()) {
			foreach(var itm in DS.GetManager<VATCodes>().OnChange.Where(f=> f.Key == "VATId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<VATCodes>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/VATCodes/List/");
	}

}

public partial class VATCodesRepository : DSRepository<VATCodes> {
	public VATCodesRepository() : base(12, "VATCodes", "VAT Codes") {
	}
}
public partial class VATCodes 
: DatasetBase<VATCodes>, IDSBase

  {
	  public int KeyValue => VATIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "VATCode":
			return VATCodeField;
				case "VATName":
			return VATNameField;
				case "VATRate":
			return VATRateField;
				case "VATId":
			return VATIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(VATCode,VATCodeField);
				action(VATName,VATNameField);
				action(VATRate,VATRateField);
				action(VATId,VATIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				VATCode.Visible=false;VATName.Visible=false;VATRate.Visible=false;VATId.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update VATCodes set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (VATCode.HasChanged && VATCode.HasValue) {
					SQL += ", VATCode=@VATCodeValue";

				}
								if (VATName.HasChanged && VATName.HasValue) {
					SQL += ", VATName=@VATNameValue";

				}
								if (VATRate.HasChanged && VATRate.HasValue) {
					SQL += ", VATRate=@VATRateValue";

				}
								if (VATId.HasChanged && VATId.HasValue) {
					SQL += ", VATId=@VATIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									VATCode.HasChanged = false;
									VATName.HasChanged = false;
									VATRate.HasChanged = false;
									VATId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into VATCodes(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (VATCode.HasValue) {
					SQL += ", VATCode";
					Values += ", @VATCodeValue";
				}
				
				if (VATName.HasValue) {
					SQL += ", VATName";
					Values += ", @VATNameValue";
				}
				
				if (VATRate.HasValue) {
					SQL += ", VATRate";
					Values += ", @VATRateValue";
				}
				VATId.Value = IQApp.DB.GetInt("select isnull(max(VATId),0)+1 from VATCodes");
				if (VATId.HasValue) {
					SQL += ", VATId";
					Values += ", @VATIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from VATCodes");
					 IQApp.DB.Execute(SQL, this);
				                    					VATCode.HasChanged = false;
									VATName.HasChanged = false;
									VATRate.HasChanged = false;
									VATId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "VATCode":
					return (IDSFieldBase)VATCode;
								case "VATName":
					return (IDSFieldBase)VATName;
								case "VATRate":
					return (IDSFieldBase)VATRate;
								case "VATId":
					return (IDSFieldBase)VATId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "VATCode":
					return VATCode.DisplayValue;
								case "VATName":
					return VATName.DisplayValue;
								case "VATRate":
					return VATRate.DisplayValue;
								case "VATId":
					return VATId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "VATCode":
					return VATCode.Value.ToString();
								case "VATName":
					return VATName.Value.ToString();
								case "VATRate":
					return VATRate.Value.ToString();
								case "VATId":
					return VATId.Value.ToString();
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
					foreach(var itm in DS.GetManager<VATCodes>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public VATCodes () : base("VATCodes") {
		base.obj = this;
	
					VATCode = new VATCodes_VATCode(this);
					VATName = new VATCodes_VATName(this);
					VATRate = new VATCodes_VATRate(this);
					VATId = new VATCodes_VATId(this);
			}

	static VATCodes () {
					VATCodeField = new VATCodes_VATCodeFieldDef();
					VATNameField = new VATCodes_VATNameFieldDef();
					VATRateField = new VATCodes_VATRateFieldDef();
					VATIdField = new VATCodes_VATIdFieldDef();
			}

	public string RecordTitle { 
		get { return VATCodeValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "VAT Codes"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/VATCodes/Load/?RecId=" + RecordID.Value;
			}
			return "/VATCodes/Add";
			}
	}

			
		
		[Ignore()]
		public VATCodes_VATCode VATCode { get; set; }
		public static VATCodes_VATCodeFieldDef VATCodeField { get; private set; }
        
			
			[Column("VATCode")]
			public  string PopulateVATCode  {
				get { return VATCodeValue ;}
				set { VATCode.DataValue = value; }
			}

	
			public string VATCodeValue 
			{ 
				get 
				{
				   if(VATCode.Value != null) {
				   return VATCode.Value.ToString(); 					}
					return "";
                
				}
				set { VATCode.Value = value;  }
			}
			
		
		[Ignore()]
		public VATCodes_VATName VATName { get; set; }
		public static VATCodes_VATNameFieldDef VATNameField { get; private set; }
        
			
			[Column("VATName")]
			public  string PopulateVATName  {
				get { return VATNameValue ;}
				set { VATName.DataValue = value; }
			}

	
			public string VATNameValue 
			{ 
				get 
				{
				   if(VATName.Value != null) {
				   return VATName.Value.ToString(); 					}
					return "";
                
				}
				set { VATName.Value = value;  }
			}
			
		
		[Ignore()]
		public VATCodes_VATRate VATRate { get; set; }
		public static VATCodes_VATRateFieldDef VATRateField { get; private set; }
        
			
			[Column("VATRate")]
			public  double PopulateVATRate  {
				get { return VATRateValue ;}
				set { VATRate.DataValue = value; }
			}

	
			public double VATRateValue 
			{ 
				get 
				{
				   if(VATRate.Value != null) {
				   					double i = 0.0;
					if (VATRate != null)
					{
						if (VATRate.Value != null)
						{
							if (Double.TryParse(VATRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { VATRate.Value = value;  }
			}
			
		
		[Ignore()]
		public VATCodes_VATId VATId { get; set; }
		public static VATCodes_VATIdFieldDef VATIdField { get; private set; }
        
			
			[Column("VATId")]
			public  int PopulateVATId  {
				get { return VATIdValue ;}
				set { VATId.DataValue = value; }
			}

	
			public int VATIdValue 
			{ 
				get 
				{
				   if(VATId.Value != null) {
				   					int i = 0;
					if (VATId != null)
					{
						if (VATId.Value != null)
						{
							if (Int32.TryParse(VATId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { VATId.Value = value;  }
			}
	}


public class VATCodes_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 12;
    public int PixelHeight => 0;
	public string Title => "VAT Codes";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
