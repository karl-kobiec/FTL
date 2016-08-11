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


public partial class MonthsController : DSBaseController<Months/*,MonthsSearch*/> {
	public MonthsController() : base ((IDatabase)IQApp.DB, new MonthsRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select MthId from Months where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Months>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Months data) {
						IQApp.DB.Execute("Delete from Months where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.MthNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Months " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Months " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Months " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Months_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Months>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Months>("select * from Months  ").ToList();
		string urlpath = "/temp/Months Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Months");
				
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
							
					worksheet.Column(1).Width = 67;
					worksheet.Cells[1, 1].Value = "Month Name";
						
								
					worksheet.Column(2).Width = 33;
					worksheet.Cells[1, 2].Value = "From";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].MthName.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].MthSDate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveMthId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Months>("select * from Months where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.MthIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthId" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackMthId(Months obj) {
			
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthId" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveMthName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Months>("select * from Months where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.MthNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthName" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackMthName(Months obj) {
			
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthName" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveMthSDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Months>("select * from Months where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.MthSDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthSDate" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthSDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackMthSDate(Months obj) {
			
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthSDate" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthSDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveMthEDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Months>("select * from Months where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.MthEDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthEDate" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthEDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackMthEDate(Months obj) {
			
		if(DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthEDate" ).Any()) {
			foreach(var itm in DS.GetManager<Months>().OnChange.Where(f=> f.Key == "MthEDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Months>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=42 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/Months/Search/" + FirstSearch);
		
		return Redirect("/Months/List/");
	}

}

public partial class MonthsRepository : DSRepository<Months> {
	public MonthsRepository() : base(42, "Months", "Months") {
	}
}
public partial class Months 
: DatasetBase<Months>, IDSBase

  {
	  public int KeyValue => MthIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "MthId":
			return MthIdField;
				case "MthName":
			return MthNameField;
				case "MthSDate":
			return MthSDateField;
				case "MthEDate":
			return MthEDateField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(MthId,MthIdField);
				action(MthName,MthNameField);
				action(MthSDate,MthSDateField);
				action(MthEDate,MthEDateField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				MthId.Visible=false;MthName.Visible=false;MthSDate.Visible=false;MthEDate.Visible=false;			break;
					case 3:
				MthId.Visible=false;MthName.Visible=false;MthSDate.Visible=false;MthEDate.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Months set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (MthId.HasChanged && MthId.HasValue) {
					SQL += ", MthId=@MthIdValue";

				}
								if (MthName.HasChanged && MthName.HasValue) {
					SQL += ", MthName=@MthNameValue";

				}
								if (MthSDate.HasChanged && MthSDate.HasValue) {
					SQL += ", MthSDate=@MthSDateValue";

				}
								if (MthEDate.HasChanged && MthEDate.HasValue) {
					SQL += ", MthEDate=@MthEDateValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									MthId.HasChanged = false;
									MthName.HasChanged = false;
									MthSDate.HasChanged = false;
									MthEDate.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Months(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (MthId.HasValue) {
					SQL += ", MthId";
					Values += ", @MthIdValue";
				}
				
				if (MthName.HasValue) {
					SQL += ", MthName";
					Values += ", @MthNameValue";
				}
				
				if (MthSDate.HasValue) {
					SQL += ", MthSDate";
					Values += ", @MthSDateValue";
				}
				
				if (MthEDate.HasValue) {
					SQL += ", MthEDate";
					Values += ", @MthEDateValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Months");
					 IQApp.DB.Execute(SQL, this);
				                    					MthId.HasChanged = false;
									MthName.HasChanged = false;
									MthSDate.HasChanged = false;
									MthEDate.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "MthId":
					return (IDSFieldBase)MthId;
								case "MthName":
					return (IDSFieldBase)MthName;
								case "MthSDate":
					return (IDSFieldBase)MthSDate;
								case "MthEDate":
					return (IDSFieldBase)MthEDate;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "MthId":
					return MthId.DisplayValue;
								case "MthName":
					return MthName.DisplayValue;
								case "MthSDate":
					return MthSDate.DisplayValue;
								case "MthEDate":
					return MthEDate.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "MthId":
					return MthId.Value.ToString();
								case "MthName":
					return MthName.Value.ToString();
								case "MthSDate":
					return MthSDate.Value.ToString();
								case "MthEDate":
					return MthEDate.Value.ToString();
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
					foreach(var itm in DS.GetManager<Months>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Months () : base("Months") {
		base.obj = this;
	
					MthId = new Months_MthId(this);
					MthName = new Months_MthName(this);
					MthSDate = new Months_MthSDate(this);
					MthEDate = new Months_MthEDate(this);
			}

	static Months () {
					MthIdField = new Months_MthIdFieldDef();
					MthNameField = new Months_MthNameFieldDef();
					MthSDateField = new Months_MthSDateFieldDef();
					MthEDateField = new Months_MthEDateFieldDef();
			}

	public string RecordTitle { 
		get { return MthNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Months"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Months/Load/?RecId=" + RecordID.Value;
			}
			return "/Months/Add";
			}
	}

			
		
		[Ignore()]
		public Months_MthId MthId { get; set; }
		public static Months_MthIdFieldDef MthIdField { get; private set; }
        
			
			[Column("MthId")]
			public  int PopulateMthId  {
				get { return MthIdValue ;}
				set { MthId.DataValue = value; }
			}

	
			public int MthIdValue 
			{ 
				get 
				{
				   if(MthId.Value != null) {
				   					int i = 0;
					if (MthId != null)
					{
						if (MthId.Value != null)
						{
							if (Int32.TryParse(MthId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { MthId.Value = value;  }
			}
			
		
		[Ignore()]
		public Months_MthName MthName { get; set; }
		public static Months_MthNameFieldDef MthNameField { get; private set; }
        
			
			[Column("MthName")]
			public  string PopulateMthName  {
				get { return MthNameValue ;}
				set { MthName.DataValue = value; }
			}

	
			public string MthNameValue 
			{ 
				get 
				{
				   if(MthName.Value != null) {
				   return MthName.Value.ToString(); 					}
					return "";
                
				}
				set { MthName.Value = value;  }
			}
			
		
		[Ignore()]
		public Months_MthSDate MthSDate { get; set; }
		public static Months_MthSDateFieldDef MthSDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("MthSDate")]
			public  DateTime PopulateMthSDate  {
				get { return MthSDateValue ;}
				set { MthSDate.DataValue = value; }
			}

	
			public DateTime MthSDateValue 
			{ 
				get 
				{
				   if(MthSDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (MthSDate != null)
					{
						if (MthSDate.Value != null)
						{
							if (DateTime.TryParse(MthSDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { MthSDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Months_MthEDate MthEDate { get; set; }
		public static Months_MthEDateFieldDef MthEDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("MthEDate")]
			public  DateTime PopulateMthEDate  {
				get { return MthEDateValue ;}
				set { MthEDate.DataValue = value; }
			}

	
			public DateTime MthEDateValue 
			{ 
				get 
				{
				   if(MthEDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (MthEDate != null)
					{
						if (MthEDate.Value != null)
						{
							if (DateTime.TryParse(MthEDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { MthEDate.Value = value;  }
			}
	}


public class Months_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 42;
    public int PixelHeight => 0;
	public string Title => "Months";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
