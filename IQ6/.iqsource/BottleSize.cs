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


public partial class BottleSizeController : DSBaseController<BottleSize/*,BottleSizeSearch*/> {
	public BottleSizeController() : base ((IDatabase)IQApp.DB, new BottleSizeRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select BSzId from BottleSize where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<BottleSize>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(BottleSize data) {
						IQApp.DB.Execute("Delete from BottleSize where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.BSzSizeValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from BottleSize " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from BottleSize " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from BottleSize " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/BottleSize_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<BottleSize>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<BottleSize>("select * from BottleSize  ").ToList();
		string urlpath = "/temp/Bottle Sizes Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Bottle Sizes");
				
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
							
					worksheet.Column(1).Width = 28;
					worksheet.Cells[1, 1].Value = "Size ID";
						
								
					worksheet.Column(2).Width = 55;
					worksheet.Cells[1, 2].Value = "Bottle Size";
						
								
					worksheet.Column(3).Width = 17;
					worksheet.Cells[1, 3].Value = "Sort Order";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].BSzId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].BSzSize.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].BSzOrder.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveBSzId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<BottleSize>("select * from BottleSize where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.BSzIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzId" ).Any()) {
			foreach(var itm in DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<BottleSize>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackBSzId(BottleSize obj) {
			
		if(DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzId" ).Any()) {
			foreach(var itm in DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<BottleSize>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveBSzSize(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<BottleSize>("select * from BottleSize where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.BSzSizeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzSize" ).Any()) {
			foreach(var itm in DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzSize")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<BottleSize>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackBSzSize(BottleSize obj) {
			
		if(DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzSize" ).Any()) {
			foreach(var itm in DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzSize")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<BottleSize>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveBSzOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<BottleSize>("select * from BottleSize where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.BSzOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzOrder" ).Any()) {
			foreach(var itm in DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<BottleSize>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackBSzOrder(BottleSize obj) {
			
		if(DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzOrder" ).Any()) {
			foreach(var itm in DS.GetManager<BottleSize>().OnChange.Where(f=> f.Key == "BSzOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<BottleSize>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/BottleSize/List/");
	}

}

public partial class BottleSizeRepository : DSRepository<BottleSize> {
	public BottleSizeRepository() : base(27, "BottleSize", "Bottle Sizes") {
	}
}
public partial class BottleSize 
: DatasetBase<BottleSize>, IDSBase

  {
	  public int KeyValue => BSzIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "BSzId":
			return BSzIdField;
				case "BSzSize":
			return BSzSizeField;
				case "BSzOrder":
			return BSzOrderField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(BSzId,BSzIdField);
				action(BSzSize,BSzSizeField);
				action(BSzOrder,BSzOrderField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				BSzId.Visible=false;BSzSize.Visible=false;BSzOrder.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update BottleSize set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (BSzId.HasChanged && BSzId.HasValue) {
					SQL += ", BSzId=@BSzIdValue";

				}
								if (BSzSize.HasChanged && BSzSize.HasValue) {
					SQL += ", BSzSize=@BSzSizeValue";

				}
								if (BSzOrder.HasChanged && BSzOrder.HasValue) {
					SQL += ", BSzOrder=@BSzOrderValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									BSzId.HasChanged = false;
									BSzSize.HasChanged = false;
									BSzOrder.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into BottleSize(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (BSzId.HasValue) {
					SQL += ", BSzId";
					Values += ", @BSzIdValue";
				}
				
				if (BSzSize.HasValue) {
					SQL += ", BSzSize";
					Values += ", @BSzSizeValue";
				}
				
				if (BSzOrder.HasValue) {
					SQL += ", BSzOrder";
					Values += ", @BSzOrderValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from BottleSize");
					 IQApp.DB.Execute(SQL, this);
				                    					BSzId.HasChanged = false;
									BSzSize.HasChanged = false;
									BSzOrder.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "BSzId":
					return (IDSFieldBase)BSzId;
								case "BSzSize":
					return (IDSFieldBase)BSzSize;
								case "BSzOrder":
					return (IDSFieldBase)BSzOrder;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "BSzId":
					return BSzId.DisplayValue;
								case "BSzSize":
					return BSzSize.DisplayValue;
								case "BSzOrder":
					return BSzOrder.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "BSzId":
					return BSzId.Value.ToString();
								case "BSzSize":
					return BSzSize.Value.ToString();
								case "BSzOrder":
					return BSzOrder.Value.ToString();
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
					foreach(var itm in DS.GetManager<BottleSize>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public BottleSize () : base("BottleSize") {
		base.obj = this;
	
					BSzId = new BottleSize_BSzId(this);
					BSzSize = new BottleSize_BSzSize(this);
					BSzOrder = new BottleSize_BSzOrder(this);
			}

	static BottleSize () {
					BSzIdField = new BottleSize_BSzIdFieldDef();
					BSzSizeField = new BottleSize_BSzSizeFieldDef();
					BSzOrderField = new BottleSize_BSzOrderFieldDef();
			}

	public string RecordTitle { 
		get { return BSzSizeValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Bottle Sizes"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/BottleSize/Load/?RecId=" + RecordID.Value;
			}
			return "/BottleSize/Add";
			}
	}

			
		
		[Ignore()]
		public BottleSize_BSzId BSzId { get; set; }
		public static BottleSize_BSzIdFieldDef BSzIdField { get; private set; }
        
			
			[Column("BSzId")]
			public  int PopulateBSzId  {
				get { return BSzIdValue ;}
				set { BSzId.DataValue = value; }
			}

	
			public int BSzIdValue 
			{ 
				get 
				{
				   if(BSzId.Value != null) {
				   					int i = 0;
					if (BSzId != null)
					{
						if (BSzId.Value != null)
						{
							if (Int32.TryParse(BSzId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { BSzId.Value = value;  }
			}
			
		
		[Ignore()]
		public BottleSize_BSzSize BSzSize { get; set; }
		public static BottleSize_BSzSizeFieldDef BSzSizeField { get; private set; }
        
			
			[Column("BSzSize")]
			public  string PopulateBSzSize  {
				get { return BSzSizeValue ;}
				set { BSzSize.DataValue = value; }
			}

	
			public string BSzSizeValue 
			{ 
				get 
				{
				   if(BSzSize.Value != null) {
				   return BSzSize.Value.ToString(); 					}
					return "";
                
				}
				set { BSzSize.Value = value;  }
			}
			
		
		[Ignore()]
		public BottleSize_BSzOrder BSzOrder { get; set; }
		public static BottleSize_BSzOrderFieldDef BSzOrderField { get; private set; }
        
			
			[Column("BSzOrder")]
			public  int PopulateBSzOrder  {
				get { return BSzOrderValue ;}
				set { BSzOrder.DataValue = value; }
			}

	
			public int BSzOrderValue 
			{ 
				get 
				{
				   if(BSzOrder.Value != null) {
				   					int i = 0;
					if (BSzOrder != null)
					{
						if (BSzOrder.Value != null)
						{
							if (Int32.TryParse(BSzOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { BSzOrder.Value = value;  }
			}
	}


public class BottleSize_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 27;
    public int PixelHeight => 0;
	public string Title => "Bottle Sizes";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
