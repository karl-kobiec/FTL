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


public partial class DelZoneController : DSBaseController<DelZone/*,DelZoneSearch*/> {
	public DelZoneController() : base ((IDatabase)IQApp.DB, new DelZoneRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select DelZId from DelZone where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<DelZone>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(DelZone data) {
						IQApp.DB.Execute("Delete from DelZone where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.DelZNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from DelZone " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from DelZone " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from DelZone " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/DelZone_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<DelZone>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<DelZone>("select * from DelZone  ").ToList();
		string urlpath = "/temp/Delivery Zones Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Delivery Zones");
				
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
					worksheet.Cells[1, 1].Value = "Id";
						
								
					worksheet.Column(2).Width = 67;
					worksheet.Cells[1, 2].Value = "Name";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].DelZId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].DelZName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDelZId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DelZone>("select * from DelZone where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DelZIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZId" ).Any()) {
			foreach(var itm in DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DelZone>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDelZId(DelZone obj) {
			
		if(DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZId" ).Any()) {
			foreach(var itm in DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DelZone>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDelZName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<DelZone>("select * from DelZone where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DelZNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZName" ).Any()) {
			foreach(var itm in DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<DelZone>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDelZName(DelZone obj) {
			
		if(DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZName" ).Any()) {
			foreach(var itm in DS.GetManager<DelZone>().OnChange.Where(f=> f.Key == "DelZName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<DelZone>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/DelZone/List/");
	}

}

public partial class DelZoneRepository : DSRepository<DelZone> {
	public DelZoneRepository() : base(57, "DelZone", "Delivery Zones") {
	}
}
public partial class DelZone 
: DatasetBase<DelZone>, IDSBase

  {
	  public int KeyValue => DelZIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "DelZId":
			return DelZIdField;
				case "DelZName":
			return DelZNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(DelZId,DelZIdField);
				action(DelZName,DelZNameField);
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
                string SQL = "update DelZone set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (DelZId.HasChanged && DelZId.HasValue) {
					SQL += ", DelZId=@DelZIdValue";

				}
								if (DelZName.HasChanged && DelZName.HasValue) {
					SQL += ", DelZName=@DelZNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									DelZId.HasChanged = false;
									DelZName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into DelZone(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				DelZId.Value = IQApp.DB.GetInt("select isnull(max(DelZId),0)+1 from DelZone");
				if (DelZId.HasValue) {
					SQL += ", DelZId";
					Values += ", @DelZIdValue";
				}
				
				if (DelZName.HasValue) {
					SQL += ", DelZName";
					Values += ", @DelZNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from DelZone");
					 IQApp.DB.Execute(SQL, this);
				                    					DelZId.HasChanged = false;
									DelZName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "DelZId":
					return (IDSFieldBase)DelZId;
								case "DelZName":
					return (IDSFieldBase)DelZName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "DelZId":
					return DelZId.DisplayValue;
								case "DelZName":
					return DelZName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "DelZId":
					return DelZId.Value.ToString();
								case "DelZName":
					return DelZName.Value.ToString();
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
					foreach(var itm in DS.GetManager<DelZone>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public DelZone () : base("DelZone") {
		base.obj = this;
	
					DelZId = new DelZone_DelZId(this);
					DelZName = new DelZone_DelZName(this);
			}

	static DelZone () {
					DelZIdField = new DelZone_DelZIdFieldDef();
					DelZNameField = new DelZone_DelZNameFieldDef();
			}

	public string RecordTitle { 
		get { return DelZNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Delivery Zones"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/DelZone/Load/?RecId=" + RecordID.Value;
			}
			return "/DelZone/Add";
			}
	}

			
		
		[Ignore()]
		public DelZone_DelZId DelZId { get; set; }
		public static DelZone_DelZIdFieldDef DelZIdField { get; private set; }
        
			
			[Column("DelZId")]
			public  int PopulateDelZId  {
				get { return DelZIdValue ;}
				set { DelZId.DataValue = value; }
			}

	
			public int DelZIdValue 
			{ 
				get 
				{
				   if(DelZId.Value != null) {
				   					int i = 0;
					if (DelZId != null)
					{
						if (DelZId.Value != null)
						{
							if (Int32.TryParse(DelZId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DelZId.Value = value;  }
			}
			
		
		[Ignore()]
		public DelZone_DelZName DelZName { get; set; }
		public static DelZone_DelZNameFieldDef DelZNameField { get; private set; }
        
			
			[Column("DelZName")]
			public  string PopulateDelZName  {
				get { return DelZNameValue ;}
				set { DelZName.DataValue = value; }
			}

	
			public string DelZNameValue 
			{ 
				get 
				{
				   if(DelZName.Value != null) {
				   return DelZName.Value.ToString(); 					}
					return "";
                
				}
				set { DelZName.Value = value;  }
			}
	}


public class DelZone_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 57;
    public int PixelHeight => 0;
	public string Title => "Delivery Zones";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
