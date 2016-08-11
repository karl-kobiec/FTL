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


public partial class InvCommentController : DSBaseController<InvComment/*,InvCommentSearch*/> {
	public InvCommentController() : base ((IDatabase)IQApp.DB, new InvCommentRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select InvCId from InvComment where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<InvComment>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(InvComment data) {
						IQApp.DB.Execute("Delete from InvComment where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.InvCIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from InvComment " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from InvComment " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from InvComment " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/InvComment_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<InvComment>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<InvComment>("select * from InvComment  ").ToList();
		string urlpath = "/temp/Invoice Comments Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Invoice Comments");
				
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
							
					worksheet.Column(1).Width = 17;
					worksheet.Cells[1, 1].Value = "Inv Comment ID";
						
								
					worksheet.Column(2).Width = 83;
					worksheet.Cells[1, 2].Value = "Inv Comment";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].InvCId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].InvCName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvCId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvComment>("select * from InvComment where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvCIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCId" ).Any()) {
			foreach(var itm in DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvComment>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvCId(InvComment obj) {
			
		if(DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCId" ).Any()) {
			foreach(var itm in DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvComment>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvCName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvComment>("select * from InvComment where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvCNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCName" ).Any()) {
			foreach(var itm in DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvComment>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvCName(InvComment obj) {
			
		if(DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCName" ).Any()) {
			foreach(var itm in DS.GetManager<InvComment>().OnChange.Where(f=> f.Key == "InvCName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvComment>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/InvComment/List/");
	}

}

public partial class InvCommentRepository : DSRepository<InvComment> {
	public InvCommentRepository() : base(11, "InvComment", "Invoice Comments") {
	}
}
public partial class InvComment 
: DatasetBase<InvComment>, IDSBase

  {
	  public int KeyValue => InvCIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "InvCId":
			return InvCIdField;
				case "InvCName":
			return InvCNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(InvCId,InvCIdField);
				action(InvCName,InvCNameField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				InvCId.Visible=false;InvCName.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update InvComment set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (InvCId.HasChanged && InvCId.HasValue) {
					SQL += ", InvCId=@InvCIdValue";

				}
								if (InvCName.HasChanged && InvCName.HasValue) {
					SQL += ", InvCName=@InvCNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									InvCId.HasChanged = false;
									InvCName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into InvComment(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				InvCId.Value = IQApp.DB.GetInt("select isnull(max(InvCId),0)+1 from InvComment");
				if (InvCId.HasValue) {
					SQL += ", InvCId";
					Values += ", @InvCIdValue";
				}
				
				if (InvCName.HasValue) {
					SQL += ", InvCName";
					Values += ", @InvCNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from InvComment");
					 IQApp.DB.Execute(SQL, this);
				                    					InvCId.HasChanged = false;
									InvCName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "InvCId":
					return (IDSFieldBase)InvCId;
								case "InvCName":
					return (IDSFieldBase)InvCName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "InvCId":
					return InvCId.DisplayValue;
								case "InvCName":
					return InvCName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "InvCId":
					return InvCId.Value.ToString();
								case "InvCName":
					return InvCName.Value.ToString();
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
					foreach(var itm in DS.GetManager<InvComment>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public InvComment () : base("InvComment") {
		base.obj = this;
	
					InvCId = new InvComment_InvCId(this);
					InvCName = new InvComment_InvCName(this);
			}

	static InvComment () {
					InvCIdField = new InvComment_InvCIdFieldDef();
					InvCNameField = new InvComment_InvCNameFieldDef();
			}

	public string RecordTitle { 
		get { return InvCIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Invoice Comments"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/InvComment/Load/?RecId=" + RecordID.Value;
			}
			return "/InvComment/Add";
			}
	}

			
		
		[Ignore()]
		public InvComment_InvCId InvCId { get; set; }
		public static InvComment_InvCIdFieldDef InvCIdField { get; private set; }
        
			
			[Column("InvCId")]
			public  int PopulateInvCId  {
				get { return InvCIdValue ;}
				set { InvCId.DataValue = value; }
			}

	
			public int InvCIdValue 
			{ 
				get 
				{
				   if(InvCId.Value != null) {
				   					int i = 0;
					if (InvCId != null)
					{
						if (InvCId.Value != null)
						{
							if (Int32.TryParse(InvCId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvCId.Value = value;  }
			}
			
		
		[Ignore()]
		public InvComment_InvCName InvCName { get; set; }
		public static InvComment_InvCNameFieldDef InvCNameField { get; private set; }
        
			
			[Column("InvCName")]
			public  string PopulateInvCName  {
				get { return InvCNameValue ;}
				set { InvCName.DataValue = value; }
			}

	
			public string InvCNameValue 
			{ 
				get 
				{
				   if(InvCName.Value != null) {
				   return InvCName.Value.ToString(); 					}
					return "";
                
				}
				set { InvCName.Value = value;  }
			}
	}


public class InvComment_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 11;
    public int PixelHeight => 0;
	public string Title => "Invoice Comments";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
