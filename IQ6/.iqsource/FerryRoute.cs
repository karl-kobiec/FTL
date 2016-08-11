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


public partial class FerryRouteController : DSBaseController<FerryRoute/*,FerryRouteSearch*/> {
	public FerryRouteController() : base ((IDatabase)IQApp.DB, new FerryRouteRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select FRId from FerryRoute where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<FerryRoute>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(FerryRoute data) {
						IQApp.DB.Execute("Delete from FerryRoute where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.FRNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from FerryRoute " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from FerryRoute " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from FerryRoute " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/FerryRoute_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<FerryRoute>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<FerryRoute>("select * from FerryRoute  ").ToList();
		string urlpath = "/temp/Ferry Routes Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Ferry Routes");
				
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
							
					worksheet.Column(1).Width = 38;
					worksheet.Cells[1, 1].Value = "Route Code";
						
								
					worksheet.Column(2).Width = 62;
					worksheet.Cells[1, 2].Value = "Route";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].FRCode.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].FRName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveFRCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<FerryRoute>("select * from FerryRoute where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.FRCodeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRCode" ).Any()) {
			foreach(var itm in DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<FerryRoute>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackFRCode(FerryRoute obj) {
			
		if(DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRCode" ).Any()) {
			foreach(var itm in DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<FerryRoute>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveFRName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<FerryRoute>("select * from FerryRoute where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.FRNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRName" ).Any()) {
			foreach(var itm in DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<FerryRoute>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackFRName(FerryRoute obj) {
			
		if(DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRName" ).Any()) {
			foreach(var itm in DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<FerryRoute>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveFRId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<FerryRoute>("select * from FerryRoute where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.FRIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRId" ).Any()) {
			foreach(var itm in DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<FerryRoute>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackFRId(FerryRoute obj) {
			
		if(DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRId" ).Any()) {
			foreach(var itm in DS.GetManager<FerryRoute>().OnChange.Where(f=> f.Key == "FRId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<FerryRoute>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/FerryRoute/List/");
	}

}

public partial class FerryRouteRepository : DSRepository<FerryRoute> {
	public FerryRouteRepository() : base(10, "FerryRoute", "Ferry Routes") {
	}
}
public partial class FerryRoute 
: DatasetBase<FerryRoute>, IDSBase

  {
	  public int KeyValue => FRIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "FRCode":
			return FRCodeField;
				case "FRName":
			return FRNameField;
				case "FRId":
			return FRIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(FRCode,FRCodeField);
				action(FRName,FRNameField);
				action(FRId,FRIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				FRCode.Visible=false;FRName.Visible=false;FRId.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update FerryRoute set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (FRCode.HasChanged && FRCode.HasValue) {
					SQL += ", FRCode=@FRCodeValue";

				}
								if (FRName.HasChanged && FRName.HasValue) {
					SQL += ", FRName=@FRNameValue";

				}
								if (FRId.HasChanged && FRId.HasValue) {
					SQL += ", FRId=@FRIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									FRCode.HasChanged = false;
									FRName.HasChanged = false;
									FRId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into FerryRoute(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (FRCode.HasValue) {
					SQL += ", FRCode";
					Values += ", @FRCodeValue";
				}
				
				if (FRName.HasValue) {
					SQL += ", FRName";
					Values += ", @FRNameValue";
				}
				FRId.Value = IQApp.DB.GetInt("select isnull(max(FRId),0)+1 from FerryRoute");
				if (FRId.HasValue) {
					SQL += ", FRId";
					Values += ", @FRIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from FerryRoute");
					 IQApp.DB.Execute(SQL, this);
				                    					FRCode.HasChanged = false;
									FRName.HasChanged = false;
									FRId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "FRCode":
					return (IDSFieldBase)FRCode;
								case "FRName":
					return (IDSFieldBase)FRName;
								case "FRId":
					return (IDSFieldBase)FRId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "FRCode":
					return FRCode.DisplayValue;
								case "FRName":
					return FRName.DisplayValue;
								case "FRId":
					return FRId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "FRCode":
					return FRCode.Value.ToString();
								case "FRName":
					return FRName.Value.ToString();
								case "FRId":
					return FRId.Value.ToString();
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
					foreach(var itm in DS.GetManager<FerryRoute>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public FerryRoute () : base("FerryRoute") {
		base.obj = this;
	
					FRCode = new FerryRoute_FRCode(this);
					FRName = new FerryRoute_FRName(this);
					FRId = new FerryRoute_FRId(this);
			}

	static FerryRoute () {
					FRCodeField = new FerryRoute_FRCodeFieldDef();
					FRNameField = new FerryRoute_FRNameFieldDef();
					FRIdField = new FerryRoute_FRIdFieldDef();
			}

	public string RecordTitle { 
		get { return FRNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Ferry Routes"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/FerryRoute/Load/?RecId=" + RecordID.Value;
			}
			return "/FerryRoute/Add";
			}
	}

			
		
		[Ignore()]
		public FerryRoute_FRCode FRCode { get; set; }
		public static FerryRoute_FRCodeFieldDef FRCodeField { get; private set; }
        
			
			[Column("FRCode")]
			public  string PopulateFRCode  {
				get { return FRCodeValue ;}
				set { FRCode.DataValue = value; }
			}

	
			public string FRCodeValue 
			{ 
				get 
				{
				   if(FRCode.Value != null) {
				   return FRCode.Value.ToString(); 					}
					return "";
                
				}
				set { FRCode.Value = value;  }
			}
			
		
		[Ignore()]
		public FerryRoute_FRName FRName { get; set; }
		public static FerryRoute_FRNameFieldDef FRNameField { get; private set; }
        
			
			[Column("FRName")]
			public  string PopulateFRName  {
				get { return FRNameValue ;}
				set { FRName.DataValue = value; }
			}

	
			public string FRNameValue 
			{ 
				get 
				{
				   if(FRName.Value != null) {
				   return FRName.Value.ToString(); 					}
					return "";
                
				}
				set { FRName.Value = value;  }
			}
			
		
		[Ignore()]
		public FerryRoute_FRId FRId { get; set; }
		public static FerryRoute_FRIdFieldDef FRIdField { get; private set; }
        
			
			[Column("FRId")]
			public  int PopulateFRId  {
				get { return FRIdValue ;}
				set { FRId.DataValue = value; }
			}

	
			public int FRIdValue 
			{ 
				get 
				{
				   if(FRId.Value != null) {
				   					int i = 0;
					if (FRId != null)
					{
						if (FRId.Value != null)
						{
							if (Int32.TryParse(FRId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { FRId.Value = value;  }
			}
	}


public class FerryRoute_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 10;
    public int PixelHeight => 0;
	public string Title => "Ferry Routes";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
