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


public partial class DriverHrsController : DSBaseController<DriverHrs/*,DriverHrsSearch*/> {
	public DriverHrsController() : base ((IDatabase)IQApp.DB, new DriverHrsRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select DrvHDriver from DriverHrs where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<DriverHrs>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(DriverHrs data) {
						IQApp.DB.Execute("Delete from DriverHrs where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.DrvHDriverValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from DriverHrs " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from DriverHrs " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from DriverHrs " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/DriverHrs_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<DriverHrs>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<DriverHrs>("select * from DriverHrs  ").ToList();
		string urlpath = "/temp/Driver Hours Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Driver Hours");
				
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
							
					worksheet.Column(1).Width = 33;
					worksheet.Cells[1, 1].Value = "Driver";
						
								
					worksheet.Column(2).Width = 33;
					worksheet.Cells[1, 2].Value = "Week";
						
								
					worksheet.Column(3).Width = 33;
					worksheet.Cells[1, 3].Value = "Hours";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].DrvHDriver.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].DrvHWk.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].DrvHHrs.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvHDriver(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DriverHrs>("select * from DriverHrs where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DrvHDriverValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHDriver" ).Any()) {
			foreach(var itm in DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHDriver")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DriverHrs>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteDrvHDriver(DriverHrs m, int? id, string q) {

		
		string s = m.DrvHDriver.DataSource;
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
	public ActionResult CallbackDrvHDriver(DriverHrs obj) {
			
		if(DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHDriver" ).Any()) {
			foreach(var itm in DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHDriver")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DriverHrs>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvHWk(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DriverHrs>("select * from DriverHrs where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DrvHWkValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHWk" ).Any()) {
			foreach(var itm in DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHWk")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DriverHrs>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteDrvHWk(DriverHrs m, int? id, string q) {

		
		string s = m.DrvHWk.DataSource;
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
	public ActionResult CallbackDrvHWk(DriverHrs obj) {
			
		if(DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHWk" ).Any()) {
			foreach(var itm in DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHWk")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DriverHrs>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvHHrs(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DriverHrs>("select * from DriverHrs where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DrvHHrsValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHHrs" ).Any()) {
			foreach(var itm in DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHHrs")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DriverHrs>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvHHrs(DriverHrs obj) {
			
		if(DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHHrs" ).Any()) {
			foreach(var itm in DS.GetManager<DriverHrs>().OnChange.Where(f=> f.Key == "DrvHHrs")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DriverHrs>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/DriverHrs/List/");
	}

}

public partial class DriverHrsRepository : DSRepository<DriverHrs> {
	public DriverHrsRepository() : base(22, "DriverHrs", "Driver Hours") {
	}
}
public partial class DriverHrs 
: DatasetBase<DriverHrs>, IDSBase

  {
	  public int KeyValue => DrvHDriverValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "DrvHDriver":
			return DrvHDriverField;
				case "DrvHWk":
			return DrvHWkField;
				case "DrvHHrs":
			return DrvHHrsField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(DrvHDriver,DrvHDriverField);
				action(DrvHWk,DrvHWkField);
				action(DrvHHrs,DrvHHrsField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				DrvHDriver.Visible=false;DrvHWk.Visible=false;DrvHHrs.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (DrvHDriver.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Driver where DrvId=@Key", new {Key= DrvHDriver.Value});
                return 0;
            }
            set
            {
                if (DrvHDriver.Value == null)
                    DrvHDriver.Value = IQApp.DB.GetInt("SELECT DrvId FROM Driver whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Driver _Parent;

        public Driver Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId", new { RecId = ParentRecID}).First();
                }
                return _Parent;
            }
            set
            {
                _Parent = value;
            }
        }
		
				public IDSBase IParent { get {
		return (IDSBase)Parent;}
		set { Parent = (Driver)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update DriverHrs set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (DrvHDriver.HasChanged && DrvHDriver.HasValue) {
					SQL += ", DrvHDriver=@DrvHDriverValue";

				}
								if (DrvHWk.HasChanged && DrvHWk.HasValue) {
					SQL += ", DrvHWk=@DrvHWkValue";

				}
								if (DrvHHrs.HasChanged && DrvHHrs.HasValue) {
					SQL += ", DrvHHrs=@DrvHHrsValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									DrvHDriver.HasChanged = false;
									DrvHWk.HasChanged = false;
									DrvHHrs.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into DriverHrs(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (DrvHDriver.HasValue) {
					SQL += ", DrvHDriver";
					Values += ", @DrvHDriverValue";
				}
				
				if (DrvHWk.HasValue) {
					SQL += ", DrvHWk";
					Values += ", @DrvHWkValue";
				}
				
				if (DrvHHrs.HasValue) {
					SQL += ", DrvHHrs";
					Values += ", @DrvHHrsValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from DriverHrs");
					 IQApp.DB.Execute(SQL, this);
				                    					DrvHDriver.HasChanged = false;
									DrvHWk.HasChanged = false;
									DrvHHrs.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "DrvHDriver":
					return (IDSFieldBase)DrvHDriver;
								case "DrvHWk":
					return (IDSFieldBase)DrvHWk;
								case "DrvHHrs":
					return (IDSFieldBase)DrvHHrs;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "DrvHDriver":
					return DrvHDriver.DisplayValue;
								case "DrvHWk":
					return DrvHWk.DisplayValue;
								case "DrvHHrs":
					return DrvHHrs.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "DrvHDriver":
					return DrvHDriver.Value.ToString();
								case "DrvHWk":
					return DrvHWk.Value.ToString();
								case "DrvHHrs":
					return DrvHHrs.Value.ToString();
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
					foreach(var itm in DS.GetManager<DriverHrs>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public DriverHrs () : base("DriverHrs") {
		base.obj = this;
	
					DrvHDriver = new DriverHrs_DrvHDriver(this);
					DrvHWk = new DriverHrs_DrvHWk(this);
					DrvHHrs = new DriverHrs_DrvHHrs(this);
			}

	static DriverHrs () {
					DrvHDriverField = new DriverHrs_DrvHDriverFieldDef();
					DrvHWkField = new DriverHrs_DrvHWkFieldDef();
					DrvHHrsField = new DriverHrs_DrvHHrsFieldDef();
			}

	public string RecordTitle { 
		get { return DrvHDriverValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Driver Hours"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/DriverHrs/Load/?RecId=" + RecordID.Value;
			}
			return "/DriverHrs/Add";
			}
	}

			
		
		[Ignore()]
		public DriverHrs_DrvHDriver DrvHDriver { get; set; }
		public static DriverHrs_DrvHDriverFieldDef DrvHDriverField { get; private set; }
        
			
			[Column("DrvHDriver")]
			public  int PopulateDrvHDriver  {
				get { return DrvHDriverValue ;}
				set { DrvHDriver.DataValue = value; }
			}

	
			public int DrvHDriverValue 
			{ 
				get 
				{
				   if(DrvHDriver.Value != null) {
				   					int i = 0;
					if (DrvHDriver != null)
					{
						if (DrvHDriver.Value != null)
						{
							if (Int32.TryParse(DrvHDriver.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DrvHDriver.Value = value;  }
			}
			
		
		[Ignore()]
		public DriverHrs_DrvHWk DrvHWk { get; set; }
		public static DriverHrs_DrvHWkFieldDef DrvHWkField { get; private set; }
        
			
			[Column("DrvHWk")]
			public  int PopulateDrvHWk  {
				get { return DrvHWkValue ;}
				set { DrvHWk.DataValue = value; }
			}

	
			public int DrvHWkValue 
			{ 
				get 
				{
				   if(DrvHWk.Value != null) {
				   					int i = 0;
					if (DrvHWk != null)
					{
						if (DrvHWk.Value != null)
						{
							if (Int32.TryParse(DrvHWk.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DrvHWk.Value = value;  }
			}
			
		
		[Ignore()]
		public DriverHrs_DrvHHrs DrvHHrs { get; set; }
		public static DriverHrs_DrvHHrsFieldDef DrvHHrsField { get; private set; }
        
			
			[Column("DrvHHrs")]
			public  double PopulateDrvHHrs  {
				get { return DrvHHrsValue ;}
				set { DrvHHrs.DataValue = value; }
			}

	
			public double DrvHHrsValue 
			{ 
				get 
				{
				   if(DrvHHrs.Value != null) {
				   					double i = 0.0;
					if (DrvHHrs != null)
					{
						if (DrvHHrs.Value != null)
						{
							if (Double.TryParse(DrvHHrs.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { DrvHHrs.Value = value;  }
			}
	}


public class DriverHrs_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 22;
    public int PixelHeight => 0;
	public string Title => "Driver Hours";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
