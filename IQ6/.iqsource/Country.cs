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


public partial class CountryController : DSBaseController<Country/*,CountrySearch*/> {
	public CountryController() : base ((IDatabase)IQApp.DB, new CountryRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select CtryId from Country where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Country>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Country data) {
						IQApp.DB.Execute("Delete from Country where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.CtryNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Country " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Country " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Country " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Country_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Country>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Country>("select * from Country  ").ToList();
		string urlpath = "/temp/Countries Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Countries");
				
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
							
					worksheet.Column(1).Width = 24;
					worksheet.Cells[1, 1].Value = "Country ID";
						
								
					worksheet.Column(2).Width = 29;
					worksheet.Cells[1, 2].Value = "Country Code";
						
								
					worksheet.Column(3).Width = 47;
					worksheet.Cells[1, 3].Value = "Country";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].CtryId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].CtryCode.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].CtryName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCtryId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Country>("select * from Country where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CtryIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryId" ).Any()) {
			foreach(var itm in DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Country>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCtryId(Country obj) {
			
		if(DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryId" ).Any()) {
			foreach(var itm in DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Country>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCtryCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Country>("select * from Country where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CtryCodeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryCode" ).Any()) {
			foreach(var itm in DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Country>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCtryCode(Country obj) {
			
		if(DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryCode" ).Any()) {
			foreach(var itm in DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Country>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCtryName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Country>("select * from Country where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CtryNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryName" ).Any()) {
			foreach(var itm in DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Country>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCtryName(Country obj) {
			
		if(DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryName" ).Any()) {
			foreach(var itm in DS.GetManager<Country>().OnChange.Where(f=> f.Key == "CtryName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Country>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Country/List/");
	}

}

public partial class CountryRepository : DSRepository<Country> {
	public CountryRepository() : base(34, "Country", "Countries") {
	}
}
public partial class Country 
: DatasetBase<Country>, IDSBase

  {
	  public int KeyValue => CtryIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "CtryId":
			return CtryIdField;
				case "CtryCode":
			return CtryCodeField;
				case "CtryName":
			return CtryNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(CtryId,CtryIdField);
				action(CtryCode,CtryCodeField);
				action(CtryName,CtryNameField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				CtryId.Visible=false;CtryCode.Visible=false;CtryName.Visible=false;			break;
					case 3:
				CtryId.Visible=false;CtryCode.Visible=false;CtryName.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Country set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (CtryId.HasChanged && CtryId.HasValue) {
					SQL += ", CtryId=@CtryIdValue";

				}
								if (CtryCode.HasChanged && CtryCode.HasValue) {
					SQL += ", CtryCode=@CtryCodeValue";

				}
								if (CtryName.HasChanged && CtryName.HasValue) {
					SQL += ", CtryName=@CtryNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									CtryId.HasChanged = false;
									CtryCode.HasChanged = false;
									CtryName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Country(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (CtryId.HasValue) {
					SQL += ", CtryId";
					Values += ", @CtryIdValue";
				}
				
				if (CtryCode.HasValue) {
					SQL += ", CtryCode";
					Values += ", @CtryCodeValue";
				}
				
				if (CtryName.HasValue) {
					SQL += ", CtryName";
					Values += ", @CtryNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Country");
					 IQApp.DB.Execute(SQL, this);
				                    					CtryId.HasChanged = false;
									CtryCode.HasChanged = false;
									CtryName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "CtryId":
					return (IDSFieldBase)CtryId;
								case "CtryCode":
					return (IDSFieldBase)CtryCode;
								case "CtryName":
					return (IDSFieldBase)CtryName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "CtryId":
					return CtryId.DisplayValue;
								case "CtryCode":
					return CtryCode.DisplayValue;
								case "CtryName":
					return CtryName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "CtryId":
					return CtryId.Value.ToString();
								case "CtryCode":
					return CtryCode.Value.ToString();
								case "CtryName":
					return CtryName.Value.ToString();
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
					foreach(var itm in DS.GetManager<Country>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Country () : base("Country") {
		base.obj = this;
	
					CtryId = new Country_CtryId(this);
					CtryCode = new Country_CtryCode(this);
					CtryName = new Country_CtryName(this);
			}

	static Country () {
					CtryIdField = new Country_CtryIdFieldDef();
					CtryCodeField = new Country_CtryCodeFieldDef();
					CtryNameField = new Country_CtryNameFieldDef();
			}

	public string RecordTitle { 
		get { return CtryNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Countries"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Country/Load/?RecId=" + RecordID.Value;
			}
			return "/Country/Add";
			}
	}

			
		
		[Ignore()]
		public Country_CtryId CtryId { get; set; }
		public static Country_CtryIdFieldDef CtryIdField { get; private set; }
        
			
			[Column("CtryId")]
			public  int PopulateCtryId  {
				get { return CtryIdValue ;}
				set { CtryId.DataValue = value; }
			}

	
			public int CtryIdValue 
			{ 
				get 
				{
				   if(CtryId.Value != null) {
				   					int i = 0;
					if (CtryId != null)
					{
						if (CtryId.Value != null)
						{
							if (Int32.TryParse(CtryId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CtryId.Value = value;  }
			}
			
		
		[Ignore()]
		public Country_CtryCode CtryCode { get; set; }
		public static Country_CtryCodeFieldDef CtryCodeField { get; private set; }
        
			
			[Column("CtryCode")]
			public  string PopulateCtryCode  {
				get { return CtryCodeValue ;}
				set { CtryCode.DataValue = value; }
			}

	
			public string CtryCodeValue 
			{ 
				get 
				{
				   if(CtryCode.Value != null) {
				   return CtryCode.Value.ToString(); 					}
					return "";
                
				}
				set { CtryCode.Value = value;  }
			}
			
		
		[Ignore()]
		public Country_CtryName CtryName { get; set; }
		public static Country_CtryNameFieldDef CtryNameField { get; private set; }
        
			
			[Column("CtryName")]
			public  string PopulateCtryName  {
				get { return CtryNameValue ;}
				set { CtryName.DataValue = value; }
			}

	
			public string CtryNameValue 
			{ 
				get 
				{
				   if(CtryName.Value != null) {
				   return CtryName.Value.ToString(); 					}
					return "";
                
				}
				set { CtryName.Value = value;  }
			}
	}


public class Country_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 34;
    public int PixelHeight => 0;
	public string Title => "Countries";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
