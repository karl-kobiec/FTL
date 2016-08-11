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


public partial class StaffController : DSBaseController<Staff/*,StaffSearch*/> {
	public StaffController() : base ((IDatabase)IQApp.DB, new StaffRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select StfId from Staff where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Staff>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Staff data) {
						IQApp.DB.Execute("Delete from Staff where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.StfNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Staff " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Staff " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Staff " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Staff_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Staff>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Staff>("select * from Staff  ").ToList();
		string urlpath = "/temp/Staff Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Staff");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 6])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 22;
					worksheet.Cells[1, 1].Value = "Name";
						
								
					worksheet.Column(2).Width = 22;
					worksheet.Cells[1, 2].Value = "Username";
						
								
					worksheet.Column(3).Width = 22;
					worksheet.Cells[1, 3].Value = "Password";
						
								
					worksheet.Column(4).Width = 22;
					worksheet.Cells[1, 4].Value = "Email";
						
								
					worksheet.Column(5).Width = 11;
					worksheet.Cells[1, 5].Value = "Security Groups";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].StfName.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].StfUsername.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].StfPassword.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].StfEM.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].StfSG.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.StfIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfId" || f.Key == "Id" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfId(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfId" || f.Key == "Id" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfFN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.StfFNValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfFN" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfFN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfFN(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfFN" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfFN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfSN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.StfSNValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSN" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfSN(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSN" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.StfNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfName"  || f.Key == "FullName" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfName" || f.Key == "FullName" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfName(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfName"  || f.Key == "FullName" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfName" || f.Key == "FullName" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfUsername(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.StfUsernameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfUsername"  || f.Key == "Username" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfUsername" || f.Key == "Username" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfUsername(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfUsername"  || f.Key == "Username" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfUsername" || f.Key == "Username" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfPassword(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.StfPasswordValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfPassword"  || f.Key == "Password" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfPassword" || f.Key == "Password" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfPassword(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfPassword"  || f.Key == "Password" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfPassword" || f.Key == "Password" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfEM(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.StfEMValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfEM"  || f.Key == "Email" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfEM" || f.Key == "Email" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackStfEM(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfEM"  || f.Key == "Email" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfEM" || f.Key == "Email" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveStfSG(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Staff>("select * from Staff where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.StfSGValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSG"  || f.Key == "SecGroup" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSG" || f.Key == "SecGroup" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteStfSG(Staff m, int? id, string q) {

		
		string s = m.StfSG.DataSource;
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
	public ActionResult CallbackStfSG(Staff obj) {
			
		if(DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSG"  || f.Key == "SecGroup" ).Any()) {
			foreach(var itm in DS.GetManager<Staff>().OnChange.Where(f=> f.Key == "StfSG" || f.Key == "SecGroup" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Staff>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Staff/List/");
	}

}

public partial class StaffRepository : DSRepository<Staff> {
	public StaffRepository() : base(51, "Staff", "Staff") {
	}
}
public partial class Staff 
: DatasetBase<Staff>, IDSBase
, FTL.UserAuthentication.IUserObj
  {
	  public int KeyValue => StfIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "StfId":
			return StfIdField;
				case "StfFN":
			return StfFNField;
				case "StfSN":
			return StfSNField;
				case "StfName":
			return StfNameField;
				case "StfUsername":
			return StfUsernameField;
				case "StfPassword":
			return StfPasswordField;
				case "StfEM":
			return StfEMField;
				case "StfSG":
			return StfSGField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(StfId,StfIdField);
				action(StfFN,StfFNField);
				action(StfSN,StfSNField);
				action(StfName,StfNameField);
				action(StfUsername,StfUsernameField);
				action(StfPassword,StfPasswordField);
				action(StfEM,StfEMField);
				action(StfSG,StfSGField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				StfId.Visible=false;StfFN.Visible=false;StfSN.Visible=false;StfName.Visible=false;StfUsername.Visible=false;StfPassword.Visible=false;StfEM.Visible=false;StfSG.Visible=false;			break;
					case 3:
				StfId.Visible=false;StfFN.Visible=false;StfSN.Visible=false;StfName.Visible=false;StfUsername.Visible=false;StfPassword.Visible=false;StfEM.Visible=false;StfSG.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Staff set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (StfId.HasChanged && StfId.HasValue) {
					SQL += ", StfId=@StfIdValue";

				}
								if (StfFN.HasChanged && StfFN.HasValue) {
					SQL += ", StfFN=@StfFNValue";

				}
								if (StfSN.HasChanged && StfSN.HasValue) {
					SQL += ", StfSN=@StfSNValue";

				}
								if (StfName.HasChanged && StfName.HasValue) {
					SQL += ", StfName=@StfNameValue";

				}
								if (StfUsername.HasChanged && StfUsername.HasValue) {
					SQL += ", StfUsername=@StfUsernameValue";

				}
								if (StfPassword.HasChanged && StfPassword.HasValue) {
					SQL += ", StfPassword=@StfPasswordValue";

				}
								if (StfEM.HasChanged && StfEM.HasValue) {
					SQL += ", StfEM=@StfEMValue";

				}
								if (StfSG.HasChanged && StfSG.HasValue) {
					SQL += ", StfSG=@StfSGValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									StfId.HasChanged = false;
									StfFN.HasChanged = false;
									StfSN.HasChanged = false;
									StfName.HasChanged = false;
									StfUsername.HasChanged = false;
									StfPassword.HasChanged = false;
									StfEM.HasChanged = false;
									StfSG.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Staff(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				StfId.Value = IQApp.DB.GetInt("select isnull(max(StfId),0)+1 from Staff");
				if (StfId.HasValue) {
					SQL += ", StfId";
					Values += ", @StfIdValue";
				}
				
				if (StfFN.HasValue) {
					SQL += ", StfFN";
					Values += ", @StfFNValue";
				}
				
				if (StfSN.HasValue) {
					SQL += ", StfSN";
					Values += ", @StfSNValue";
				}
				
				if (StfName.HasValue) {
					SQL += ", StfName";
					Values += ", @StfNameValue";
				}
				
				if (StfUsername.HasValue) {
					SQL += ", StfUsername";
					Values += ", @StfUsernameValue";
				}
				
				if (StfPassword.HasValue) {
					SQL += ", StfPassword";
					Values += ", @StfPasswordValue";
				}
				
				if (StfEM.HasValue) {
					SQL += ", StfEM";
					Values += ", @StfEMValue";
				}
				
				if (StfSG.HasValue) {
					SQL += ", StfSG";
					Values += ", @StfSGValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Staff");
					 IQApp.DB.Execute(SQL, this);
				                    					StfId.HasChanged = false;
									StfFN.HasChanged = false;
									StfSN.HasChanged = false;
									StfName.HasChanged = false;
									StfUsername.HasChanged = false;
									StfPassword.HasChanged = false;
									StfEM.HasChanged = false;
									StfSG.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "StfId":
					return (IDSFieldBase)StfId;
								case "StfFN":
					return (IDSFieldBase)StfFN;
								case "StfSN":
					return (IDSFieldBase)StfSN;
								case "StfName":
					return (IDSFieldBase)StfName;
								case "StfUsername":
					return (IDSFieldBase)StfUsername;
								case "StfPassword":
					return (IDSFieldBase)StfPassword;
								case "StfEM":
					return (IDSFieldBase)StfEM;
								case "StfSG":
					return (IDSFieldBase)StfSG;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "StfId":
					return StfId.DisplayValue;
								case "StfFN":
					return StfFN.DisplayValue;
								case "StfSN":
					return StfSN.DisplayValue;
								case "StfName":
					return StfName.DisplayValue;
								case "StfUsername":
					return StfUsername.DisplayValue;
								case "StfPassword":
					return StfPassword.DisplayValue;
								case "StfEM":
					return StfEM.DisplayValue;
								case "StfSG":
					return StfSG.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "StfId":
					return StfId.Value.ToString();
								case "StfFN":
					return StfFN.Value.ToString();
								case "StfSN":
					return StfSN.Value.ToString();
								case "StfName":
					return StfName.Value.ToString();
								case "StfUsername":
					return StfUsername.Value.ToString();
								case "StfPassword":
					return StfPassword.Value.ToString();
								case "StfEM":
					return StfEM.Value.ToString();
								case "StfSG":
					return StfSG.Value.ToString();
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
					foreach(var itm in DS.GetManager<Staff>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Staff () : base("Staff") {
		base.obj = this;
	
					StfId = new Staff_StfId(this);
					StfFN = new Staff_StfFN(this);
					StfSN = new Staff_StfSN(this);
					StfName = new Staff_StfName(this);
					StfUsername = new Staff_StfUsername(this);
					StfPassword = new Staff_StfPassword(this);
					StfEM = new Staff_StfEM(this);
					StfSG = new Staff_StfSG(this);
			}

	static Staff () {
					StfIdField = new Staff_StfIdFieldDef();
					StfFNField = new Staff_StfFNFieldDef();
					StfSNField = new Staff_StfSNFieldDef();
					StfNameField = new Staff_StfNameFieldDef();
					StfUsernameField = new Staff_StfUsernameFieldDef();
					StfPasswordField = new Staff_StfPasswordFieldDef();
					StfEMField = new Staff_StfEMFieldDef();
					StfSGField = new Staff_StfSGFieldDef();
			}

	public string RecordTitle { 
		get { return StfNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Staff"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Staff/Load/?RecId=" + RecordID.Value;
			}
			return "/Staff/Add";
			}
	}

			
		
		[Ignore()]
		public Staff_StfId StfId { get; set; }
		public static Staff_StfIdFieldDef StfIdField { get; private set; }
        
			
			[Column("StfId")]
			public  int PopulateStfId  {
				get { return StfIdValue ;}
				set { StfId.DataValue = value; }
			}

			public int Id {
			get { return StfIdValue ; }
			set { StfIdValue  = value; } 
		}
		[IQFieldName("StfId")]
		public IDSFieldBase  IdField { 
			get { return (IDSFieldBase)StfId; } 
			set { StfId = (Staff_StfId)value; }
		}
	
			public int StfIdValue 
			{ 
				get 
				{
				   if(StfId.Value != null) {
				   					int i = 0;
					if (StfId != null)
					{
						if (StfId.Value != null)
						{
							if (Int32.TryParse(StfId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { StfId.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfFN StfFN { get; set; }
		public static Staff_StfFNFieldDef StfFNField { get; private set; }
        
			
			[Column("StfFN")]
			public  string PopulateStfFN  {
				get { return StfFNValue ;}
				set { StfFN.DataValue = value; }
			}

	
			public string StfFNValue 
			{ 
				get 
				{
				   if(StfFN.Value != null) {
				   return StfFN.Value.ToString(); 					}
					return "";
                
				}
				set { StfFN.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfSN StfSN { get; set; }
		public static Staff_StfSNFieldDef StfSNField { get; private set; }
        
			
			[Column("StfSN")]
			public  string PopulateStfSN  {
				get { return StfSNValue ;}
				set { StfSN.DataValue = value; }
			}

	
			public string StfSNValue 
			{ 
				get 
				{
				   if(StfSN.Value != null) {
				   return StfSN.Value.ToString(); 					}
					return "";
                
				}
				set { StfSN.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfName StfName { get; set; }
		public static Staff_StfNameFieldDef StfNameField { get; private set; }
        
			
			[Column("StfName")]
			public  string PopulateStfName  {
				get { return StfNameValue ;}
				set { StfName.DataValue = value; }
			}

			public string FullName {
			get { return StfNameValue ; }
			set { StfNameValue  = value; } 
		}
		[IQFieldName("StfName")]
		public IDSFieldBase  FullNameField { 
			get { return (IDSFieldBase)StfName; } 
			set { StfName = (Staff_StfName)value; }
		}
	
			public string StfNameValue 
			{ 
				get 
				{
				   if(StfName.Value != null) {
				   return StfName.Value.ToString(); 					}
					return "";
                
				}
				set { StfName.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfUsername StfUsername { get; set; }
		public static Staff_StfUsernameFieldDef StfUsernameField { get; private set; }
        
			
			[Column("StfUsername")]
			public  string PopulateStfUsername  {
				get { return StfUsernameValue ;}
				set { StfUsername.DataValue = value; }
			}

			public string Username {
			get { return StfUsernameValue ; }
			set { StfUsernameValue  = value; } 
		}
		[IQFieldName("StfUsername")]
		public IDSFieldBase  UsernameField { 
			get { return (IDSFieldBase)StfUsername; } 
			set { StfUsername = (Staff_StfUsername)value; }
		}
	
			public string StfUsernameValue 
			{ 
				get 
				{
				   if(StfUsername.Value != null) {
				   return StfUsername.Value.ToString(); 					}
					return "";
                
				}
				set { StfUsername.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfPassword StfPassword { get; set; }
		public static Staff_StfPasswordFieldDef StfPasswordField { get; private set; }
        
			
			[Column("StfPassword")]
			public  string PopulateStfPassword  {
				get { return StfPasswordValue ;}
				set { StfPassword.DataValue = value; }
			}

			public string Password {
			get { return StfPasswordValue ; }
			set { StfPasswordValue  = value; } 
		}
		[IQFieldName("StfPassword")]
		public IDSFieldBase  PasswordField { 
			get { return (IDSFieldBase)StfPassword; } 
			set { StfPassword = (Staff_StfPassword)value; }
		}
	
			public string StfPasswordValue 
			{ 
				get 
				{
				   if(StfPassword.Value != null) {
				   return StfPassword.Value.ToString(); 					}
					return "";
                
				}
				set { StfPassword.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfEM StfEM { get; set; }
		public static Staff_StfEMFieldDef StfEMField { get; private set; }
        
			
			[Column("StfEM")]
			public  string PopulateStfEM  {
				get { return StfEMValue ;}
				set { StfEM.DataValue = value; }
			}

			public string Email {
			get { return StfEMValue ; }
			set { StfEMValue  = value; } 
		}
		[IQFieldName("StfEM")]
		public IDSFieldBase  EmailField { 
			get { return (IDSFieldBase)StfEM; } 
			set { StfEM = (Staff_StfEM)value; }
		}
	
			public string StfEMValue 
			{ 
				get 
				{
				   if(StfEM.Value != null) {
				   return StfEM.Value.ToString(); 					}
					return "";
                
				}
				set { StfEM.Value = value;  }
			}
			
		
		[Ignore()]
		public Staff_StfSG StfSG { get; set; }
		public static Staff_StfSGFieldDef StfSGField { get; private set; }
        
			
			[Column("StfSG")]
			public  int PopulateStfSG  {
				get { return StfSGValue ;}
				set { StfSG.DataValue = value; }
			}

			public int SecGroup {
			get { return StfSGValue ; }
			set { StfSGValue  = value; } 
		}
		[IQFieldName("StfSG")]
		public IDSFieldBase  SecGroupField { 
			get { return (IDSFieldBase)StfSG; } 
			set { StfSG = (Staff_StfSG)value; }
		}
	
			public int StfSGValue 
			{ 
				get 
				{
				   if(StfSG.Value != null) {
				   					int i = 0;
					if (StfSG != null)
					{
						if (StfSG.Value != null)
						{
							if (Int32.TryParse(StfSG.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { StfSG.Value = value;  }
			}
	}


public class Staff_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 51;
    public int PixelHeight => 0;
	public string Title => "Staff";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
