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


public partial class REDSEADController : DSBaseController<REDSEAD/*,REDSEADSearch*/> {
	public REDSEADController() : base ((IDatabase)IQApp.DB, new REDSEADRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select RDEADRDId from REDSEAD where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<REDSEAD>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(REDSEAD data) {
						IQApp.DB.Execute("Delete from REDSEAD where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.RDEADIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from REDSEAD " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from REDSEAD " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from REDSEAD " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/REDSEAD_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<REDSEAD>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<REDSEAD>("select * from REDSEAD  ").ToList();
		string urlpath = "/temp/REDS eAD Numbers Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("REDS eAD Numbers");
				
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
							
					worksheet.Column(1).Width = 33;
					worksheet.Cells[1, 1].Value = "REDS ID";
						
								
					worksheet.Column(2).Width = 67;
					worksheet.Cells[1, 2].Value = "eAD Number";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].RDEADRDId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].RDEADId.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDEADId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSEAD>("select * from REDSEAD where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.RDEADIdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSEAD>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDEADId(REDSEAD obj) {
			
		if(DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSEAD>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDEADRDId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSEAD>("select * from REDSEAD where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDEADRDIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADRDId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADRDId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSEAD>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDEADRDId(REDSEAD obj) {
			
		if(DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADRDId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSEAD>().OnChange.Where(f=> f.Key == "RDEADRDId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSEAD>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=39 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/REDSEAD/Search/" + FirstSearch);
		
		return Redirect("/REDSEAD/List/");
	}

}

public partial class REDSEADRepository : DSRepository<REDSEAD> {
	public REDSEADRepository() : base(39, "REDSEAD", "REDS eAD Numbers") {
	}
}
public partial class REDSEAD 
: DatasetBase<REDSEAD>, IDSBase

  {
	  public int KeyValue => RDEADRDIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "RDEADId":
			return RDEADIdField;
				case "RDEADRDId":
			return RDEADRDIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(RDEADId,RDEADIdField);
				action(RDEADRDId,RDEADRDIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				RDEADId.Visible=false;RDEADRDId.Visible=false;			break;
					case 3:
				RDEADId.Visible=false;RDEADRDId.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (RDEADRDId.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM REDSOrder where RDOrdId=@Key", new {Key= RDEADRDId.Value});
                return 0;
            }
            set
            {
                if (RDEADRDId.Value == null)
                    RDEADRDId.Value = IQApp.DB.GetInt("SELECT RDOrdId FROM REDSOrder whereRecordID=@RecId", new { RecId = value});
            }
        }
        private REDSOrder _Parent;

        public REDSOrder Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (REDSOrder)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update REDSEAD set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (RDEADId.HasChanged && RDEADId.HasValue) {
					SQL += ", RDEADId=@RDEADIdValue";

				}
								if (RDEADRDId.HasChanged && RDEADRDId.HasValue) {
					SQL += ", RDEADRDId=@RDEADRDIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									RDEADId.HasChanged = false;
									RDEADRDId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into REDSEAD(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (RDEADId.HasValue) {
					SQL += ", RDEADId";
					Values += ", @RDEADIdValue";
				}
				
				if (RDEADRDId.HasValue) {
					SQL += ", RDEADRDId";
					Values += ", @RDEADRDIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from REDSEAD");
					 IQApp.DB.Execute(SQL, this);
				                    					RDEADId.HasChanged = false;
									RDEADRDId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "RDEADId":
					return (IDSFieldBase)RDEADId;
								case "RDEADRDId":
					return (IDSFieldBase)RDEADRDId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "RDEADId":
					return RDEADId.DisplayValue;
								case "RDEADRDId":
					return RDEADRDId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "RDEADId":
					return RDEADId.Value.ToString();
								case "RDEADRDId":
					return RDEADRDId.Value.ToString();
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
					foreach(var itm in DS.GetManager<REDSEAD>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public REDSEAD () : base("REDSEAD") {
		base.obj = this;
	
					RDEADId = new REDSEAD_RDEADId(this);
					RDEADRDId = new REDSEAD_RDEADRDId(this);
			}

	static REDSEAD () {
					RDEADIdField = new REDSEAD_RDEADIdFieldDef();
					RDEADRDIdField = new REDSEAD_RDEADRDIdFieldDef();
			}

	public string RecordTitle { 
		get { return RDEADIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "REDS eAD Numbers"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/REDSEAD/Load/?RecId=" + RecordID.Value;
			}
			return "/REDSEAD/Add";
			}
	}

			
		
		[Ignore()]
		public REDSEAD_RDEADId RDEADId { get; set; }
		public static REDSEAD_RDEADIdFieldDef RDEADIdField { get; private set; }
        
			
			[Column("RDEADId")]
			public  string PopulateRDEADId  {
				get { return RDEADIdValue ;}
				set { RDEADId.DataValue = value; }
			}

	
			public string RDEADIdValue 
			{ 
				get 
				{
				   if(RDEADId.Value != null) {
				   return RDEADId.Value.ToString(); 					}
					return "";
                
				}
				set { RDEADId.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSEAD_RDEADRDId RDEADRDId { get; set; }
		public static REDSEAD_RDEADRDIdFieldDef RDEADRDIdField { get; private set; }
        
			
			[Column("RDEADRDId")]
			public  int PopulateRDEADRDId  {
				get { return RDEADRDIdValue ;}
				set { RDEADRDId.DataValue = value; }
			}

	
			public int RDEADRDIdValue 
			{ 
				get 
				{
				   if(RDEADRDId.Value != null) {
				   					int i = 0;
					if (RDEADRDId != null)
					{
						if (RDEADRDId.Value != null)
						{
							if (Int32.TryParse(RDEADRDId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDEADRDId.Value = value;  }
			}
	}


public class REDSEAD_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 39;
    public int PixelHeight => 0;
	public string Title => "REDS eAD Numbers";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
