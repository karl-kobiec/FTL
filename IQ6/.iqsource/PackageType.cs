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


public partial class PackageTypeController : DSBaseController<PackageType/*,PackageTypeSearch*/> {
	public PackageTypeController() : base ((IDatabase)IQApp.DB, new PackageTypeRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select PackId from PackageType where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<PackageType>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(PackageType data) {
						IQApp.DB.Execute("Delete from PackageType where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.PackNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from PackageType " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from PackageType " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from PackageType " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/PackageType_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<PackageType>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<PackageType>("select * from PackageType  ").ToList();
		string urlpath = "/temp/Package Types Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Package Types");
				
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
					worksheet.Cells[1, 1].Value = "Package Type ID";
						
								
					worksheet.Column(2).Width = 67;
					worksheet.Cells[1, 2].Value = "Package Type";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].PackId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].PackName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SavePackId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<PackageType>("select * from PackageType where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.PackIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackId" ).Any()) {
			foreach(var itm in DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<PackageType>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackPackId(PackageType obj) {
			
		if(DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackId" ).Any()) {
			foreach(var itm in DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<PackageType>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SavePackName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<PackageType>("select * from PackageType where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.PackNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackName" ).Any()) {
			foreach(var itm in DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<PackageType>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackPackName(PackageType obj) {
			
		if(DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackName" ).Any()) {
			foreach(var itm in DS.GetManager<PackageType>().OnChange.Where(f=> f.Key == "PackName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<PackageType>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/PackageType/List/");
	}

}

public partial class PackageTypeRepository : DSRepository<PackageType> {
	public PackageTypeRepository() : base(26, "PackageType", "Package Types") {
	}
}
public partial class PackageType 
: DatasetBase<PackageType>, IDSBase

  {
	  public int KeyValue => PackIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "PackId":
			return PackIdField;
				case "PackName":
			return PackNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(PackId,PackIdField);
				action(PackName,PackNameField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				PackId.Visible=false;PackName.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update PackageType set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (PackId.HasChanged && PackId.HasValue) {
					SQL += ", PackId=@PackIdValue";

				}
								if (PackName.HasChanged && PackName.HasValue) {
					SQL += ", PackName=@PackNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									PackId.HasChanged = false;
									PackName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into PackageType(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				PackId.Value = IQApp.DB.GetInt("select isnull(max(PackId),0)+1 from PackageType");
				if (PackId.HasValue) {
					SQL += ", PackId";
					Values += ", @PackIdValue";
				}
				
				if (PackName.HasValue) {
					SQL += ", PackName";
					Values += ", @PackNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from PackageType");
					 IQApp.DB.Execute(SQL, this);
				                    					PackId.HasChanged = false;
									PackName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "PackId":
					return (IDSFieldBase)PackId;
								case "PackName":
					return (IDSFieldBase)PackName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "PackId":
					return PackId.DisplayValue;
								case "PackName":
					return PackName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "PackId":
					return PackId.Value.ToString();
								case "PackName":
					return PackName.Value.ToString();
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
					foreach(var itm in DS.GetManager<PackageType>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public PackageType () : base("PackageType") {
		base.obj = this;
	
					PackId = new PackageType_PackId(this);
					PackName = new PackageType_PackName(this);
			}

	static PackageType () {
					PackIdField = new PackageType_PackIdFieldDef();
					PackNameField = new PackageType_PackNameFieldDef();
			}

	public string RecordTitle { 
		get { return PackNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Package Types"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/PackageType/Load/?RecId=" + RecordID.Value;
			}
			return "/PackageType/Add";
			}
	}

			
		
		[Ignore()]
		public PackageType_PackId PackId { get; set; }
		public static PackageType_PackIdFieldDef PackIdField { get; private set; }
        
			
			[Column("PackId")]
			public  int PopulatePackId  {
				get { return PackIdValue ;}
				set { PackId.DataValue = value; }
			}

	
			public int PackIdValue 
			{ 
				get 
				{
				   if(PackId.Value != null) {
				   					int i = 0;
					if (PackId != null)
					{
						if (PackId.Value != null)
						{
							if (Int32.TryParse(PackId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { PackId.Value = value;  }
			}
			
		
		[Ignore()]
		public PackageType_PackName PackName { get; set; }
		public static PackageType_PackNameFieldDef PackNameField { get; private set; }
        
			
			[Column("PackName")]
			public  string PopulatePackName  {
				get { return PackNameValue ;}
				set { PackName.DataValue = value; }
			}

	
			public string PackNameValue 
			{ 
				get 
				{
				   if(PackName.Value != null) {
				   return PackName.Value.ToString(); 					}
					return "";
                
				}
				set { PackName.Value = value;  }
			}
	}


public class PackageType_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 26;
    public int PixelHeight => 0;
	public string Title => "Package Types";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
