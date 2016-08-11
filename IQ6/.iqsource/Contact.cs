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


public partial class ContactController : DSBaseController<Contact/*,ContactSearch*/> {
	public ContactController() : base ((IDatabase)IQApp.DB, new ContactRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select ContId from Contact where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Contact>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Contact data) {
						IQApp.DB.Execute("Delete from Contact where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.ContNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Contact " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Contact " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Contact " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Contact_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Contact>(Query).ToList());
				
	}
	
			public ActionResult SearchSendEmail() {
		
			EMail model = new EMail ();
			model.EMDSValue = "Contact";

			string field = "ContEM  (E-Mail)";
			if(!string.IsNullOrEmpty(IQApp.WD.GetString("FieldToEmail"))) {
				field = IQApp.WD.GetString("FieldToEmail");
			} 
			model.EMDFValue = field;
			model.EMToRecordsValue = IQApp.DB.GetString("select cast(ContId as varchar) + ',' from Contact where RecordID in (" + IQApp.WD.GetString("RecordIDs") + ") for xml path ('')");
			model.Save();
			return Redirect("/EMail/Load/?RecId=" +model.RecordID.Value);
		}
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Contact>("select * from Contact  ").ToList();
		string urlpath = "/temp/Customer Contacts Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Customer Contacts");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 10])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 6;
					worksheet.Cells[1, 1].Value = "Contact ID";
						
								
					worksheet.Column(2).Width = 10;
					worksheet.Cells[1, 2].Value = "Forename";
						
								
					worksheet.Column(3).Width = 12;
					worksheet.Cells[1, 3].Value = "Job Title";
						
								
					worksheet.Column(4).Width = 10;
					worksheet.Cells[1, 4].Value = "Surname";
						
								
					worksheet.Column(5).Width = 12;
					worksheet.Cells[1, 5].Value = "Phone";
						
								
					worksheet.Column(6).Width = 12;
					worksheet.Cells[1, 6].Value = "Fax";
						
								
					worksheet.Column(7).Width = 12;
					worksheet.Cells[1, 7].Value = "E-Mail";
						
								
					worksheet.Column(8).Width = 5;
					worksheet.Cells[1, 8].Value = "Main Contact";
						
								
					worksheet.Column(9).Width = 20;
					worksheet.Cells[1, 9].Value = "Notes";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].ContId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].ContFN.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].ContJobTitle.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].ContSN.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].ContPhone.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].ContFax.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].ContEM.DisplayValue;
								worksheet.Cells[j+2,8].Value = res[j].ContMainContact.DisplayValue;
								worksheet.Cells[j+2,9].Value = res[j].ContNotes.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.ContIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContId" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContId(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContId" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContFN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContFNValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFN" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContFN(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFN" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContSN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContSNValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContSN" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContSN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContSN(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContSN" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContSN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContPhone(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContPhoneValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContPhone" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContPhone")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContPhone(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContPhone" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContPhone")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContFax(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContFaxValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFax" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFax")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContFax(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFax" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContFax")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContEM(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContEMValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContEM" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContEM")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContEM(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContEM" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContEM")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContJobTitle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContJobTitleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContJobTitle" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContJobTitle")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContJobTitle(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContJobTitle" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContJobTitle")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContNotes(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContMainContact(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.ContMainContactValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContMainContact" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContMainContact")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContMainContact(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContMainContact" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContMainContact")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.ContCustValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContCust" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteContCust(Contact m, int? id, string q) {

		
		string s = m.ContCust.DataSource;
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
	public ActionResult CallbackContCust(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContCust" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveContName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Contact>("select * from Contact where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.ContNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContName" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackContName(Contact obj) {
			
		if(DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContName" ).Any()) {
			foreach(var itm in DS.GetManager<Contact>().OnChange.Where(f=> f.Key == "ContName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Contact>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=1 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/Contact/Search/" + FirstSearch);
		
		return Redirect("/Contact/List/");
	}

}

public partial class ContactRepository : DSRepository<Contact> {
	public ContactRepository() : base(1, "Contact", "Customer Contacts") {
	}
}
public partial class Contact 
: DatasetBase<Contact>, IDSBase

  {
	  public int KeyValue => ContIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "ContId":
			return ContIdField;
				case "ContFN":
			return ContFNField;
				case "ContSN":
			return ContSNField;
				case "ContPhone":
			return ContPhoneField;
				case "ContFax":
			return ContFaxField;
				case "ContEM":
			return ContEMField;
				case "ContJobTitle":
			return ContJobTitleField;
				case "ContNotes":
			return ContNotesField;
				case "ContMainContact":
			return ContMainContactField;
				case "ContCust":
			return ContCustField;
				case "ContName":
			return ContNameField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(ContId,ContIdField);
				action(ContFN,ContFNField);
				action(ContSN,ContSNField);
				action(ContPhone,ContPhoneField);
				action(ContFax,ContFaxField);
				action(ContEM,ContEMField);
				action(ContJobTitle,ContJobTitleField);
				action(ContNotes,ContNotesField);
				action(ContMainContact,ContMainContactField);
				action(ContCust,ContCustField);
				action(ContName,ContNameField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				ContId.Visible=false;ContFN.Visible=false;ContSN.Visible=false;ContPhone.Visible=false;ContFax.Visible=false;ContEM.Visible=false;ContJobTitle.Visible=false;ContNotes.Visible=false;ContMainContact.Visible=false;ContCust.Visible=false;ContName.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (ContCust.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Customer where CustId=@Key", new {Key= ContCust.Value});
                return 0;
            }
            set
            {
                if (ContCust.Value == null)
                    ContCust.Value = IQApp.DB.GetInt("SELECT CustId FROM Customer whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Customer _Parent;

        public Customer Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Customer>("select * from Customer where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (Customer)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Contact set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (ContId.HasChanged && ContId.HasValue) {
					SQL += ", ContId=@ContIdValue";

				}
								if (ContFN.HasChanged && ContFN.HasValue) {
					SQL += ", ContFN=@ContFNValue";

				}
								if (ContSN.HasChanged && ContSN.HasValue) {
					SQL += ", ContSN=@ContSNValue";

				}
								if (ContPhone.HasChanged && ContPhone.HasValue) {
					SQL += ", ContPhone=@ContPhoneValue";

				}
								if (ContFax.HasChanged && ContFax.HasValue) {
					SQL += ", ContFax=@ContFaxValue";

				}
								if (ContEM.HasChanged && ContEM.HasValue) {
					SQL += ", ContEM=@ContEMValue";

				}
								if (ContJobTitle.HasChanged && ContJobTitle.HasValue) {
					SQL += ", ContJobTitle=@ContJobTitleValue";

				}
								if (ContNotes.HasChanged && ContNotes.HasValue) {
					SQL += ", ContNotes=@ContNotesValue";

				}
								if (ContMainContact.HasChanged && ContMainContact.HasValue) {
					SQL += ", ContMainContact=@ContMainContactValue";

				}
								if (ContCust.HasChanged && ContCust.HasValue) {
					SQL += ", ContCust=@ContCustValue";

				}
								if (ContName.HasChanged && ContName.HasValue) {
					SQL += ", ContName=@ContNameValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									ContId.HasChanged = false;
									ContFN.HasChanged = false;
									ContSN.HasChanged = false;
									ContPhone.HasChanged = false;
									ContFax.HasChanged = false;
									ContEM.HasChanged = false;
									ContJobTitle.HasChanged = false;
									ContNotes.HasChanged = false;
									ContMainContact.HasChanged = false;
									ContCust.HasChanged = false;
									ContName.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Contact(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				ContId.Value = IQApp.DB.GetInt("select isnull(max(ContId),0)+1 from Contact");
				if (ContId.HasValue) {
					SQL += ", ContId";
					Values += ", @ContIdValue";
				}
				
				if (ContFN.HasValue) {
					SQL += ", ContFN";
					Values += ", @ContFNValue";
				}
				
				if (ContSN.HasValue) {
					SQL += ", ContSN";
					Values += ", @ContSNValue";
				}
				
				if (ContPhone.HasValue) {
					SQL += ", ContPhone";
					Values += ", @ContPhoneValue";
				}
				
				if (ContFax.HasValue) {
					SQL += ", ContFax";
					Values += ", @ContFaxValue";
				}
				
				if (ContEM.HasValue) {
					SQL += ", ContEM";
					Values += ", @ContEMValue";
				}
				
				if (ContJobTitle.HasValue) {
					SQL += ", ContJobTitle";
					Values += ", @ContJobTitleValue";
				}
				
				if (ContNotes.HasValue) {
					SQL += ", ContNotes";
					Values += ", @ContNotesValue";
				}
				
				if (ContMainContact.HasValue) {
					SQL += ", ContMainContact";
					Values += ", @ContMainContactValue";
				}
				
				if (ContCust.HasValue) {
					SQL += ", ContCust";
					Values += ", @ContCustValue";
				}
				
				if (ContName.HasValue) {
					SQL += ", ContName";
					Values += ", @ContNameValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Contact");
					 IQApp.DB.Execute(SQL, this);
				                    					ContId.HasChanged = false;
									ContFN.HasChanged = false;
									ContSN.HasChanged = false;
									ContPhone.HasChanged = false;
									ContFax.HasChanged = false;
									ContEM.HasChanged = false;
									ContJobTitle.HasChanged = false;
									ContNotes.HasChanged = false;
									ContMainContact.HasChanged = false;
									ContCust.HasChanged = false;
									ContName.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "ContId":
					return (IDSFieldBase)ContId;
								case "ContFN":
					return (IDSFieldBase)ContFN;
								case "ContSN":
					return (IDSFieldBase)ContSN;
								case "ContPhone":
					return (IDSFieldBase)ContPhone;
								case "ContFax":
					return (IDSFieldBase)ContFax;
								case "ContEM":
					return (IDSFieldBase)ContEM;
								case "ContJobTitle":
					return (IDSFieldBase)ContJobTitle;
								case "ContNotes":
					return (IDSFieldBase)ContNotes;
								case "ContMainContact":
					return (IDSFieldBase)ContMainContact;
								case "ContCust":
					return (IDSFieldBase)ContCust;
								case "ContName":
					return (IDSFieldBase)ContName;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "ContId":
					return ContId.DisplayValue;
								case "ContFN":
					return ContFN.DisplayValue;
								case "ContSN":
					return ContSN.DisplayValue;
								case "ContPhone":
					return ContPhone.DisplayValue;
								case "ContFax":
					return ContFax.DisplayValue;
								case "ContEM":
					return ContEM.DisplayValue;
								case "ContJobTitle":
					return ContJobTitle.DisplayValue;
								case "ContNotes":
					return ContNotes.DisplayValue;
								case "ContMainContact":
					return ContMainContact.DisplayValue;
								case "ContCust":
					return ContCust.DisplayValue;
								case "ContName":
					return ContName.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "ContId":
					return ContId.Value.ToString();
								case "ContFN":
					return ContFN.Value.ToString();
								case "ContSN":
					return ContSN.Value.ToString();
								case "ContPhone":
					return ContPhone.Value.ToString();
								case "ContFax":
					return ContFax.Value.ToString();
								case "ContEM":
					return ContEM.Value.ToString();
								case "ContJobTitle":
					return ContJobTitle.Value.ToString();
								case "ContNotes":
					return ContNotes.Value.ToString();
								case "ContMainContact":
					return ContMainContact.Value.ToString();
								case "ContCust":
					return ContCust.Value.ToString();
								case "ContName":
					return ContName.Value.ToString();
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
					foreach(var itm in DS.GetManager<Contact>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Contact () : base("Contact") {
		base.obj = this;
	
					ContId = new Contact_ContId(this);
					ContFN = new Contact_ContFN(this);
					ContSN = new Contact_ContSN(this);
					ContPhone = new Contact_ContPhone(this);
					ContFax = new Contact_ContFax(this);
					ContEM = new Contact_ContEM(this);
					ContJobTitle = new Contact_ContJobTitle(this);
					ContNotes = new Contact_ContNotes(this);
					ContMainContact = new Contact_ContMainContact(this);
					ContCust = new Contact_ContCust(this);
					ContName = new Contact_ContName(this);
			}

	static Contact () {
					ContIdField = new Contact_ContIdFieldDef();
					ContFNField = new Contact_ContFNFieldDef();
					ContSNField = new Contact_ContSNFieldDef();
					ContPhoneField = new Contact_ContPhoneFieldDef();
					ContFaxField = new Contact_ContFaxFieldDef();
					ContEMField = new Contact_ContEMFieldDef();
					ContJobTitleField = new Contact_ContJobTitleFieldDef();
					ContNotesField = new Contact_ContNotesFieldDef();
					ContMainContactField = new Contact_ContMainContactFieldDef();
					ContCustField = new Contact_ContCustFieldDef();
					ContNameField = new Contact_ContNameFieldDef();
			}

	public string RecordTitle { 
		get { return ContNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Customer Contacts"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Contact/Load/?RecId=" + RecordID.Value;
			}
			return "/Contact/Add";
			}
	}

			
		
		[Ignore()]
		public Contact_ContId ContId { get; set; }
		public static Contact_ContIdFieldDef ContIdField { get; private set; }
        
			
			[Column("ContId")]
			public  int PopulateContId  {
				get { return ContIdValue ;}
				set { ContId.DataValue = value; }
			}

	
			public int ContIdValue 
			{ 
				get 
				{
				   if(ContId.Value != null) {
				   					int i = 0;
					if (ContId != null)
					{
						if (ContId.Value != null)
						{
							if (Int32.TryParse(ContId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { ContId.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContFN ContFN { get; set; }
		public static Contact_ContFNFieldDef ContFNField { get; private set; }
        
			
			[Column("ContFN")]
			public  string PopulateContFN  {
				get { return ContFNValue ;}
				set { ContFN.DataValue = value; }
			}

	
			public string ContFNValue 
			{ 
				get 
				{
				   if(ContFN.Value != null) {
				   return ContFN.Value.ToString(); 					}
					return "";
                
				}
				set { ContFN.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContSN ContSN { get; set; }
		public static Contact_ContSNFieldDef ContSNField { get; private set; }
        
			
			[Column("ContSN")]
			public  string PopulateContSN  {
				get { return ContSNValue ;}
				set { ContSN.DataValue = value; }
			}

	
			public string ContSNValue 
			{ 
				get 
				{
				   if(ContSN.Value != null) {
				   return ContSN.Value.ToString(); 					}
					return "";
                
				}
				set { ContSN.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContPhone ContPhone { get; set; }
		public static Contact_ContPhoneFieldDef ContPhoneField { get; private set; }
        
			
			[Column("ContPhone")]
			public  string PopulateContPhone  {
				get { return ContPhoneValue ;}
				set { ContPhone.DataValue = value; }
			}

	
			public string ContPhoneValue 
			{ 
				get 
				{
				   if(ContPhone.Value != null) {
				   return ContPhone.Value.ToString(); 					}
					return "";
                
				}
				set { ContPhone.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContFax ContFax { get; set; }
		public static Contact_ContFaxFieldDef ContFaxField { get; private set; }
        
			
			[Column("ContFax")]
			public  string PopulateContFax  {
				get { return ContFaxValue ;}
				set { ContFax.DataValue = value; }
			}

	
			public string ContFaxValue 
			{ 
				get 
				{
				   if(ContFax.Value != null) {
				   return ContFax.Value.ToString(); 					}
					return "";
                
				}
				set { ContFax.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContEM ContEM { get; set; }
		public static Contact_ContEMFieldDef ContEMField { get; private set; }
        
			
			[Column("ContEM")]
			public  string PopulateContEM  {
				get { return ContEMValue ;}
				set { ContEM.DataValue = value; }
			}

	
			public string ContEMValue 
			{ 
				get 
				{
				   if(ContEM.Value != null) {
				   return ContEM.Value.ToString(); 					}
					return "";
                
				}
				set { ContEM.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContJobTitle ContJobTitle { get; set; }
		public static Contact_ContJobTitleFieldDef ContJobTitleField { get; private set; }
        
			
			[Column("ContJobTitle")]
			public  string PopulateContJobTitle  {
				get { return ContJobTitleValue ;}
				set { ContJobTitle.DataValue = value; }
			}

	
			public string ContJobTitleValue 
			{ 
				get 
				{
				   if(ContJobTitle.Value != null) {
				   return ContJobTitle.Value.ToString(); 					}
					return "";
                
				}
				set { ContJobTitle.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContNotes ContNotes { get; set; }
		public static Contact_ContNotesFieldDef ContNotesField { get; private set; }
        
			
			[Column("ContNotes")]
			public  string PopulateContNotes  {
				get { return ContNotesValue ;}
				set { ContNotes.DataValue = value; }
			}

	
			public string ContNotesValue 
			{ 
				get 
				{
				   if(ContNotes.Value != null) {
				   return ContNotes.Value.ToString(); 					}
					return "";
                
				}
				set { ContNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContMainContact ContMainContact { get; set; }
		public static Contact_ContMainContactFieldDef ContMainContactField { get; private set; }
        
			
			[Column("ContMainContact")]
			public  bool PopulateContMainContact  {
				get { return ContMainContactValue ;}
				set { ContMainContact.DataValue = value; }
			}

	
			public bool ContMainContactValue 
			{ 
				get 
				{
				   if(ContMainContact.Value != null) {
				   					bool i = false;
					if (ContMainContact != null)
					{
						if (ContMainContact.Value != null)
						{
							if (Boolean.TryParse(ContMainContact.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { ContMainContact.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContCust ContCust { get; set; }
		public static Contact_ContCustFieldDef ContCustField { get; private set; }
        
			
			[Column("ContCust")]
			public  int PopulateContCust  {
				get { return ContCustValue ;}
				set { ContCust.DataValue = value; }
			}

	
			public int ContCustValue 
			{ 
				get 
				{
				   if(ContCust.Value != null) {
				   					int i = 0;
					if (ContCust != null)
					{
						if (ContCust.Value != null)
						{
							if (Int32.TryParse(ContCust.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { ContCust.Value = value;  }
			}
			
		
		[Ignore()]
		public Contact_ContName ContName { get; set; }
		public static Contact_ContNameFieldDef ContNameField { get; private set; }
        
			
			[Column("ContName")]
			public  string PopulateContName  {
				get { return ContNameValue ;}
				set { ContName.DataValue = value; }
			}

	
			public string ContNameValue 
			{ 
				get 
				{
				   if(ContName.Value != null) {
				   return ContName.Value.ToString(); 					}
					return "";
                
				}
				set { ContName.Value = value;  }
			}
	}


public class Contact_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 1;
    public int PixelHeight => 0;
	public string Title => "Customer Contacts";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
