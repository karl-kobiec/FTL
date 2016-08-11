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


public partial class PalletTypeController : DSBaseController<PalletType/*,PalletTypeSearch*/> {
	public PalletTypeController() : base ((IDatabase)IQApp.DB, new PalletTypeRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select PallId from PalletType where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<PalletType>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(PalletType data) {
						IQApp.DB.Execute("Delete from PalletType where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.PallNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from PalletType " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from PalletType " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from PalletType " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/PalletType_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<PalletType>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<PalletType>("select * from PalletType  ").ToList();
		string urlpath = "/temp/Pallet Types Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Pallet Types");
				
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
					worksheet.Cells[1, 1].Value = "Pallet Type ID";
						
								
					worksheet.Column(2).Width = 67;
					worksheet.Cells[1, 2].Value = "Pallet Type";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].PallId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].PallName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SavePallId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<PalletType>("select * from PalletType where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.PallIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallId" ).Any()) {
			foreach(var itm in DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<PalletType>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackPallId(PalletType obj) {
			
		if(DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallId" ).Any()) {
			foreach(var itm in DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<PalletType>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SavePallName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<PalletType>("select * from PalletType where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.PallNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallName" ).Any()) {
			foreach(var itm in DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<PalletType>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackPallName(PalletType obj) {
			
		if(DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallName" ).Any()) {
			foreach(var itm in DS.GetManager<PalletType>().OnChange.Where(f=> f.Key == "PallName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<PalletType>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/PalletType/List/");
	}

}

public partial class PalletTypeRepository : DSRepository<PalletType> {
	public PalletTypeRepository() : base(28, "PalletType", "Pallet Types") {
	}
}
public partial class PalletType 
: DatasetBase<PalletType>, IDSBase

  {
	  public int KeyValue => PallIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "PallId":
			return PallIdField;
				case "PallName":
			return PallNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(PallId,PallIdField);
				action(PallName,PallNameField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				PallId.Visible=false;PallName.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update PalletType set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (PallId.HasChanged && PallId.HasValue) {
					SQL += ", PallId=@PallIdValue";

				}
								if (PallName.HasChanged && PallName.HasValue) {
					SQL += ", PallName=@PallNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									PallId.HasChanged = false;
									PallName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into PalletType(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				PallId.Value = IQApp.DB.GetInt("select isnull(max(PallId),0)+1 from PalletType");
				if (PallId.HasValue) {
					SQL += ", PallId";
					Values += ", @PallIdValue";
				}
				
				if (PallName.HasValue) {
					SQL += ", PallName";
					Values += ", @PallNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from PalletType");
					 IQApp.DB.Execute(SQL, this);
				                    					PallId.HasChanged = false;
									PallName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "PallId":
					return (IDSFieldBase)PallId;
								case "PallName":
					return (IDSFieldBase)PallName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "PallId":
					return PallId.DisplayValue;
								case "PallName":
					return PallName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "PallId":
					return PallId.Value.ToString();
								case "PallName":
					return PallName.Value.ToString();
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
					foreach(var itm in DS.GetManager<PalletType>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public PalletType () : base("PalletType") {
		base.obj = this;
	
					PallId = new PalletType_PallId(this);
					PallName = new PalletType_PallName(this);
			}

	static PalletType () {
					PallIdField = new PalletType_PallIdFieldDef();
					PallNameField = new PalletType_PallNameFieldDef();
			}

	public string RecordTitle { 
		get { return PallNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Pallet Types"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/PalletType/Load/?RecId=" + RecordID.Value;
			}
			return "/PalletType/Add";
			}
	}

			
		
		[Ignore()]
		public PalletType_PallId PallId { get; set; }
		public static PalletType_PallIdFieldDef PallIdField { get; private set; }
        
			
			[Column("PallId")]
			public  int PopulatePallId  {
				get { return PallIdValue ;}
				set { PallId.DataValue = value; }
			}

	
			public int PallIdValue 
			{ 
				get 
				{
				   if(PallId.Value != null) {
				   					int i = 0;
					if (PallId != null)
					{
						if (PallId.Value != null)
						{
							if (Int32.TryParse(PallId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { PallId.Value = value;  }
			}
			
		
		[Ignore()]
		public PalletType_PallName PallName { get; set; }
		public static PalletType_PallNameFieldDef PallNameField { get; private set; }
        
			
			[Column("PallName")]
			public  string PopulatePallName  {
				get { return PallNameValue ;}
				set { PallName.DataValue = value; }
			}

	
			public string PallNameValue 
			{ 
				get 
				{
				   if(PallName.Value != null) {
				   return PallName.Value.ToString(); 					}
					return "";
                
				}
				set { PallName.Value = value;  }
			}
	}


public class PalletType_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 28;
    public int PixelHeight => 0;
	public string Title => "Pallet Types";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
