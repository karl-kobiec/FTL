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


public partial class ReportingController : DSBaseController<Reporting/*,ReportingSearch*/> {
	public ReportingController() : base ((IDatabase)IQApp.DB, new ReportingRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select RptId from Reporting where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Reporting>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Reporting data) {
						IQApp.DB.Execute("Delete from Reporting where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.RptTitleValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Reporting " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Reporting " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Reporting " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Reporting_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Reporting>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Reporting>("select * from Reporting  ").ToList();
		string urlpath = "/temp/Reporting Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Reporting");
				
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
	public ActionResult SaveRptId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Reporting>("select * from Reporting where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RptIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptId" || f.Key == "Id" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRptId(Reporting obj) {
			
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptId" || f.Key == "Id" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRptTitle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Reporting>("select * from Reporting where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RptTitleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptTitle"  || f.Key == "Title" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptTitle" || f.Key == "Title" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRptTitle(Reporting obj) {
			
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptTitle"  || f.Key == "Title" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptTitle" || f.Key == "Title" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRptContent(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Reporting>("select * from Reporting where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RptContentValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptContent"  || f.Key == "Content" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptContent" || f.Key == "Content" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRptContent(Reporting obj) {
			
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptContent"  || f.Key == "Content" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptContent" || f.Key == "Content" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRptDataset(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Reporting>("select * from Reporting where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RptDatasetValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptDataset"  || f.Key == "Dataset" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptDataset" || f.Key == "Dataset" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRptDataset(Reporting obj) {
			
		if(DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptDataset"  || f.Key == "Dataset" ).Any()) {
			foreach(var itm in DS.GetManager<Reporting>().OnChange.Where(f=> f.Key == "RptDataset" || f.Key == "Dataset" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Reporting>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Reporting/List/");
	}

}

public partial class ReportingRepository : DSRepository<Reporting> {
	public ReportingRepository() : base(56, "Reporting", "Reporting") {
	}
}
public partial class Reporting 
: DatasetBase<Reporting>, IDSBase
, Intrinsiq.Reporting.IReportRecord
  {
	  public int KeyValue => RptIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "RptId":
			return RptIdField;
				case "RptTitle":
			return RptTitleField;
				case "RptContent":
			return RptContentField;
				case "RptDataset":
			return RptDatasetField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(RptId,RptIdField);
				action(RptTitle,RptTitleField);
				action(RptContent,RptContentField);
				action(RptDataset,RptDatasetField);
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
                string SQL = "update Reporting set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (RptId.HasChanged && RptId.HasValue) {
					SQL += ", RptId=@RptIdValue";

				}
								if (RptTitle.HasChanged && RptTitle.HasValue) {
					SQL += ", RptTitle=@RptTitleValue";

				}
								if (RptContent.HasChanged && RptContent.HasValue) {
					SQL += ", RptContent=@RptContentValue";

				}
								if (RptDataset.HasChanged && RptDataset.HasValue) {
					SQL += ", RptDataset=@RptDatasetValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									RptId.HasChanged = false;
									RptTitle.HasChanged = false;
									RptContent.HasChanged = false;
									RptDataset.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Reporting(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				RptId.Value = IQApp.DB.GetInt("select isnull(max(RptId),0)+1 from Reporting");
				if (RptId.HasValue) {
					SQL += ", RptId";
					Values += ", @RptIdValue";
				}
				
				if (RptTitle.HasValue) {
					SQL += ", RptTitle";
					Values += ", @RptTitleValue";
				}
				
				if (RptContent.HasValue) {
					SQL += ", RptContent";
					Values += ", @RptContentValue";
				}
				
				if (RptDataset.HasValue) {
					SQL += ", RptDataset";
					Values += ", @RptDatasetValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Reporting");
					 IQApp.DB.Execute(SQL, this);
				                    					RptId.HasChanged = false;
									RptTitle.HasChanged = false;
									RptContent.HasChanged = false;
									RptDataset.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "RptId":
					return (IDSFieldBase)RptId;
								case "RptTitle":
					return (IDSFieldBase)RptTitle;
								case "RptContent":
					return (IDSFieldBase)RptContent;
								case "RptDataset":
					return (IDSFieldBase)RptDataset;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "RptId":
					return RptId.DisplayValue;
								case "RptTitle":
					return RptTitle.DisplayValue;
								case "RptContent":
					return RptContent.DisplayValue;
								case "RptDataset":
					return RptDataset.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "RptId":
					return RptId.Value.ToString();
								case "RptTitle":
					return RptTitle.Value.ToString();
								case "RptContent":
					return RptContent.Value.ToString();
								case "RptDataset":
					return RptDataset.Value.ToString();
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
					foreach(var itm in DS.GetManager<Reporting>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Reporting () : base("Reporting") {
		base.obj = this;
	
					RptId = new Reporting_RptId(this);
					RptTitle = new Reporting_RptTitle(this);
					RptContent = new Reporting_RptContent(this);
					RptDataset = new Reporting_RptDataset(this);
			}

	static Reporting () {
					RptIdField = new Reporting_RptIdFieldDef();
					RptTitleField = new Reporting_RptTitleFieldDef();
					RptContentField = new Reporting_RptContentFieldDef();
					RptDatasetField = new Reporting_RptDatasetFieldDef();
			}

	public string RecordTitle { 
		get { return RptTitleValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Reporting"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Reporting/Load/?RecId=" + RecordID.Value;
			}
			return "/Reporting/Add";
			}
	}

			
		
		[Ignore()]
		public Reporting_RptId RptId { get; set; }
		public static Reporting_RptIdFieldDef RptIdField { get; private set; }
        
			
			[Column("RptId")]
			public  int PopulateRptId  {
				get { return RptIdValue ;}
				set { RptId.DataValue = value; }
			}

			public int Id {
			get { return RptIdValue ; }
			set { RptIdValue  = value; } 
		}
		[IQFieldName("RptId")]
		public IDSFieldBase  IdField { 
			get { return (IDSFieldBase)RptId; } 
			set { RptId = (Reporting_RptId)value; }
		}
	
			public int RptIdValue 
			{ 
				get 
				{
				   if(RptId.Value != null) {
				   					int i = 0;
					if (RptId != null)
					{
						if (RptId.Value != null)
						{
							if (Int32.TryParse(RptId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RptId.Value = value;  }
			}
			
		
		[Ignore()]
		public Reporting_RptTitle RptTitle { get; set; }
		public static Reporting_RptTitleFieldDef RptTitleField { get; private set; }
        
			
			[Column("RptTitle")]
			public  string PopulateRptTitle  {
				get { return RptTitleValue ;}
				set { RptTitle.DataValue = value; }
			}

			public string Title {
			get { return RptTitleValue ; }
			set { RptTitleValue  = value; } 
		}
		[IQFieldName("RptTitle")]
		public IDSFieldBase  TitleField { 
			get { return (IDSFieldBase)RptTitle; } 
			set { RptTitle = (Reporting_RptTitle)value; }
		}
	
			public string RptTitleValue 
			{ 
				get 
				{
				   if(RptTitle.Value != null) {
				   return RptTitle.Value.ToString(); 					}
					return "";
                
				}
				set { RptTitle.Value = value;  }
			}
			
		
		[Ignore()]
		public Reporting_RptContent RptContent { get; set; }
		public static Reporting_RptContentFieldDef RptContentField { get; private set; }
        
			
			[Column("RptContent")]
			public  string PopulateRptContent  {
				get { return RptContentValue ;}
				set { RptContent.DataValue = value; }
			}

			public string Content {
			get { return RptContentValue ; }
			set { RptContentValue  = value; } 
		}
		[IQFieldName("RptContent")]
		public IDSFieldBase  ContentField { 
			get { return (IDSFieldBase)RptContent; } 
			set { RptContent = (Reporting_RptContent)value; }
		}
	
			public string RptContentValue 
			{ 
				get 
				{
				   if(RptContent.Value != null) {
				   return RptContent.Value.ToString(); 					}
					return "";
                
				}
				set { RptContent.Value = value;  }
			}
			
		
		[Ignore()]
		public Reporting_RptDataset RptDataset { get; set; }
		public static Reporting_RptDatasetFieldDef RptDatasetField { get; private set; }
        
			
			[Column("RptDataset")]
			public  string PopulateRptDataset  {
				get { return RptDatasetValue ;}
				set { RptDataset.DataValue = value; }
			}

			public string Dataset {
			get { return RptDatasetValue ; }
			set { RptDatasetValue  = value; } 
		}
		[IQFieldName("RptDataset")]
		public IDSFieldBase  DatasetField { 
			get { return (IDSFieldBase)RptDataset; } 
			set { RptDataset = (Reporting_RptDataset)value; }
		}
	
			public string RptDatasetValue 
			{ 
				get 
				{
				   if(RptDataset.Value != null) {
				   return RptDataset.Value.ToString(); 					}
					return "";
                
				}
				set { RptDataset.Value = value;  }
			}
	}


public class Reporting_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 56;
    public int PixelHeight => 0;
	public string Title => "Reporting";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
