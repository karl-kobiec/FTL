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


public partial class EADNumController : DSBaseController<EADNum/*,EADNumSearch*/> {
	public EADNumController() : base ((IDatabase)IQApp.DB, new EADNumRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select EADOrder from EADNum where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<EADNum>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(EADNum data) {
						IQApp.DB.Execute("Delete from EADNum where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.EADNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from EADNum " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from EADNum " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from EADNum " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/EADNum_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<EADNum>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<EADNum>("select * from EADNum  ").ToList();
		string urlpath = "/temp/eAD Numbers Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("eAD Numbers");
				
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
							
					worksheet.Column(1).Width = 71;
					worksheet.Cells[1, 1].Value = "eAD Number";
						
								
					worksheet.Column(2).Width = 29;
					worksheet.Cells[1, 2].Value = "Order Number";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].EADNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].EADOrder.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEADNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EADNum>("select * from EADNum where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EADNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADNo" ).Any()) {
			foreach(var itm in DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EADNum>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEADNo(EADNum obj) {
			
		if(DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADNo" ).Any()) {
			foreach(var itm in DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EADNum>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEADOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EADNum>("select * from EADNum where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.EADOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADOrder" ).Any()) {
			foreach(var itm in DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EADNum>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEADOrder(EADNum obj) {
			
		if(DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADOrder" ).Any()) {
			foreach(var itm in DS.GetManager<EADNum>().OnChange.Where(f=> f.Key == "EADOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EADNum>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/EADNum/List/");
	}

}

public partial class EADNumRepository : DSRepository<EADNum> {
	public EADNumRepository() : base(29, "EADNum", "eAD Numbers") {
	}
}
public partial class EADNum 
: DatasetBase<EADNum>, IDSBase

  {
	  public int KeyValue => EADOrderValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "EADNo":
			return EADNoField;
				case "EADOrder":
			return EADOrderField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(EADNo,EADNoField);
				action(EADOrder,EADOrderField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				EADNo.Visible=false;EADOrder.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (EADOrder.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Orders where OrdId=@Key", new {Key= EADOrder.Value});
                return 0;
            }
            set
            {
                if (EADOrder.Value == null)
                    EADOrder.Value = IQApp.DB.GetInt("SELECT OrdId FROM Orders whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Orders _Parent;

        public Orders Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (Orders)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update EADNum set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (EADNo.HasChanged && EADNo.HasValue) {
					SQL += ", EADNo=@EADNoValue";

				}
								if (EADOrder.HasChanged && EADOrder.HasValue) {
					SQL += ", EADOrder=@EADOrderValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									EADNo.HasChanged = false;
									EADOrder.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into EADNum(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (EADNo.HasValue) {
					SQL += ", EADNo";
					Values += ", @EADNoValue";
				}
				
				if (EADOrder.HasValue) {
					SQL += ", EADOrder";
					Values += ", @EADOrderValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from EADNum");
					 IQApp.DB.Execute(SQL, this);
				                    					EADNo.HasChanged = false;
									EADOrder.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "EADNo":
					return (IDSFieldBase)EADNo;
								case "EADOrder":
					return (IDSFieldBase)EADOrder;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "EADNo":
					return EADNo.DisplayValue;
								case "EADOrder":
					return EADOrder.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "EADNo":
					return EADNo.Value.ToString();
								case "EADOrder":
					return EADOrder.Value.ToString();
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
					foreach(var itm in DS.GetManager<EADNum>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public EADNum () : base("EADNum") {
		base.obj = this;
	
					EADNo = new EADNum_EADNo(this);
					EADOrder = new EADNum_EADOrder(this);
			}

	static EADNum () {
					EADNoField = new EADNum_EADNoFieldDef();
					EADOrderField = new EADNum_EADOrderFieldDef();
			}

	public string RecordTitle { 
		get { return EADNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "eAD Numbers"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/EADNum/Load/?RecId=" + RecordID.Value;
			}
			return "/EADNum/Add";
			}
	}

			
		
		[Ignore()]
		public EADNum_EADNo EADNo { get; set; }
		public static EADNum_EADNoFieldDef EADNoField { get; private set; }
        
			
			[Column("EADNo")]
			public  string PopulateEADNo  {
				get { return EADNoValue ;}
				set { EADNo.DataValue = value; }
			}

	
			public string EADNoValue 
			{ 
				get 
				{
				   if(EADNo.Value != null) {
				   return EADNo.Value.ToString(); 					}
					return "";
                
				}
				set { EADNo.Value = value;  }
			}
			
		
		[Ignore()]
		public EADNum_EADOrder EADOrder { get; set; }
		public static EADNum_EADOrderFieldDef EADOrderField { get; private set; }
        
			
			[Column("EADOrder")]
			public  int PopulateEADOrder  {
				get { return EADOrderValue ;}
				set { EADOrder.DataValue = value; }
			}

	
			public int EADOrderValue 
			{ 
				get 
				{
				   if(EADOrder.Value != null) {
				   					int i = 0;
					if (EADOrder != null)
					{
						if (EADOrder.Value != null)
						{
							if (Int32.TryParse(EADOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { EADOrder.Value = value;  }
			}
	}


public class EADNum_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 29;
    public int PixelHeight => 0;
	public string Title => "eAD Numbers";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
