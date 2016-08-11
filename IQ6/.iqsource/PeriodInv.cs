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


public partial class PeriodInvController : DSBaseController<PeriodInv/*,PeriodInvSearch*/> {
	public PeriodInvController() : base ((IDatabase)IQApp.DB, new PeriodInvRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select PInvId from PeriodInv where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<PeriodInv>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(PeriodInv data) {
						IQApp.DB.Execute("Delete from PeriodInv where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.PInvIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from PeriodInv " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from PeriodInv " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from PeriodInv " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/PeriodInv_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<PeriodInv>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<PeriodInv>("select * from PeriodInv  ").ToList();
		string urlpath = "/temp/Period Inv Includes Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Period Inv Includes");
				
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
							
					worksheet.Column(1).Width = 50;
					worksheet.Cells[1, 1].Value = "Period Inv No";
						
								
					worksheet.Column(2).Width = 50;
					worksheet.Cells[1, 2].Value = "Include Invoice";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].PInvId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].PInvName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SavePInvId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<PeriodInv>("select * from PeriodInv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.PInvIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvId" ).Any()) {
			foreach(var itm in DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<PeriodInv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackPInvId(PeriodInv obj) {
			
		if(DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvId" ).Any()) {
			foreach(var itm in DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<PeriodInv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SavePInvName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<PeriodInv>("select * from PeriodInv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.PInvNameValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvName" ).Any()) {
			foreach(var itm in DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<PeriodInv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackPInvName(PeriodInv obj) {
			
		if(DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvName" ).Any()) {
			foreach(var itm in DS.GetManager<PeriodInv>().OnChange.Where(f=> f.Key == "PInvName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<PeriodInv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/PeriodInv/List/");
	}

}

public partial class PeriodInvRepository : DSRepository<PeriodInv> {
	public PeriodInvRepository() : base(20, "PeriodInv", "Period Inv Includes") {
	}
}
public partial class PeriodInv 
: DatasetBase<PeriodInv>, IDSBase

  {
	  public int KeyValue => PInvIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "PInvId":
			return PInvIdField;
				case "PInvName":
			return PInvNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(PInvId,PInvIdField);
				action(PInvName,PInvNameField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				PInvId.Visible=false;PInvName.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (PInvId.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Inv where InvId=@Key", new {Key= PInvId.Value});
                return 0;
            }
            set
            {
                if (PInvId.Value == null)
                    PInvId.Value = IQApp.DB.GetInt("SELECT InvId FROM Inv whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Inv _Parent;

        public Inv Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (Inv)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update PeriodInv set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (PInvId.HasChanged && PInvId.HasValue) {
					SQL += ", PInvId=@PInvIdValue";

				}
								if (PInvName.HasChanged && PInvName.HasValue) {
					SQL += ", PInvName=@PInvNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									PInvId.HasChanged = false;
									PInvName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into PeriodInv(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (PInvId.HasValue) {
					SQL += ", PInvId";
					Values += ", @PInvIdValue";
				}
				
				if (PInvName.HasValue) {
					SQL += ", PInvName";
					Values += ", @PInvNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from PeriodInv");
					 IQApp.DB.Execute(SQL, this);
				                    					PInvId.HasChanged = false;
									PInvName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "PInvId":
					return (IDSFieldBase)PInvId;
								case "PInvName":
					return (IDSFieldBase)PInvName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "PInvId":
					return PInvId.DisplayValue;
								case "PInvName":
					return PInvName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "PInvId":
					return PInvId.Value.ToString();
								case "PInvName":
					return PInvName.Value.ToString();
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
					foreach(var itm in DS.GetManager<PeriodInv>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public PeriodInv () : base("PeriodInv") {
		base.obj = this;
	
					PInvId = new PeriodInv_PInvId(this);
					PInvName = new PeriodInv_PInvName(this);
			}

	static PeriodInv () {
					PInvIdField = new PeriodInv_PInvIdFieldDef();
					PInvNameField = new PeriodInv_PInvNameFieldDef();
			}

	public string RecordTitle { 
		get { return PInvIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Period Inv Includes"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/PeriodInv/Load/?RecId=" + RecordID.Value;
			}
			return "/PeriodInv/Add";
			}
	}

			
		
		[Ignore()]
		public PeriodInv_PInvId PInvId { get; set; }
		public static PeriodInv_PInvIdFieldDef PInvIdField { get; private set; }
        
			
			[Column("PInvId")]
			public  int PopulatePInvId  {
				get { return PInvIdValue ;}
				set { PInvId.DataValue = value; }
			}

	
			public int PInvIdValue 
			{ 
				get 
				{
				   if(PInvId.Value != null) {
				   					int i = 0;
					if (PInvId != null)
					{
						if (PInvId.Value != null)
						{
							if (Int32.TryParse(PInvId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { PInvId.Value = value;  }
			}
			
		
		[Ignore()]
		public PeriodInv_PInvName PInvName { get; set; }
		public static PeriodInv_PInvNameFieldDef PInvNameField { get; private set; }
        
			
			[Column("PInvName")]
			public  int PopulatePInvName  {
				get { return PInvNameValue ;}
				set { PInvName.DataValue = value; }
			}

	
			public int PInvNameValue 
			{ 
				get 
				{
				   if(PInvName.Value != null) {
				   					int i = 0;
					if (PInvName != null)
					{
						if (PInvName.Value != null)
						{
							if (Int32.TryParse(PInvName.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { PInvName.Value = value;  }
			}
	}


public class PeriodInv_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 20;
    public int PixelHeight => 0;
	public string Title => "Period Inv Includes";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
