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


public partial class EmailTemplatessController : DSBaseController<EmailTemplatess/*,EmailTemplatessSearch*/> {
	public EmailTemplatessController() : base ((IDatabase)IQApp.DB, new EmailTemplatessRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select EMTId from EmailTemplatess where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<EmailTemplatess>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(EmailTemplatess data) {
						IQApp.DB.Execute("Delete from EmailTemplatess where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.EMTNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from EmailTemplatess " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from EmailTemplatess " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from EmailTemplatess " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/EmailTemplatess_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<EmailTemplatess>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess  ").ToList();
		string urlpath = "/temp/Email Templates Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Email Templates");
				
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
							
					worksheet.Column(1).Width = 29;
					worksheet.Cells[1, 1].Value = "Name";
						
								
					worksheet.Column(2).Width = 71;
					worksheet.Cells[1, 2].Value = "Subject";
						
								
					worksheet.Column(3).Width = 100;
					worksheet.Cells[1, 3].Value = "Query";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].EMTName.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].EMTSubject.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].EMTQuery.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.EMTIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTId" || f.Key == "Id" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTId(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTId" || f.Key == "Id" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTName"  || f.Key == "Name" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTName" || f.Key == "Name" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTName(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTName"  || f.Key == "Name" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTName" || f.Key == "Name" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTBody(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTBodyValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBody"  || f.Key == "Body" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBody" || f.Key == "Body" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTBody(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBody"  || f.Key == "Body" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBody" || f.Key == "Body" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTSubject(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTSubjectValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTSubject"  || f.Key == "Subject" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTSubject" || f.Key == "Subject" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTSubject(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTSubject"  || f.Key == "Subject" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTSubject" || f.Key == "Subject" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTFromAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTFromAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTFromAddr"  || f.Key == "FromAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTFromAddr" || f.Key == "FromAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTFromAddr(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTFromAddr"  || f.Key == "FromAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTFromAddr" || f.Key == "FromAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTToAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTToAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTToAddr"  || f.Key == "ToAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTToAddr" || f.Key == "ToAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTToAddr(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTToAddr"  || f.Key == "ToAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTToAddr" || f.Key == "ToAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTCCAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTCCAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTCCAddr"  || f.Key == "CCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTCCAddr" || f.Key == "CCAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTCCAddr(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTCCAddr"  || f.Key == "CCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTCCAddr" || f.Key == "CCAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTBCCAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTBCCAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBCCAddr"  || f.Key == "BCCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBCCAddr" || f.Key == "BCCAddress" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackEMTBCCAddr(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBCCAddr"  || f.Key == "BCCAddress" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTBCCAddr" || f.Key == "BCCAddress" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveEMTQuery(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<EmailTemplatess>("select * from EmailTemplatess where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.EMTQueryValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTQuery"  || f.Key == "Query" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTQuery" || f.Key == "Query" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteEMTQuery(EmailTemplatess m, int? id, string q) {

		
		string s = m.EMTQuery.DataSource;
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
	public ActionResult CallbackEMTQuery(EmailTemplatess obj) {
			
		if(DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTQuery"  || f.Key == "Query" ).Any()) {
			foreach(var itm in DS.GetManager<EmailTemplatess>().OnChange.Where(f=> f.Key == "EMTQuery" || f.Key == "Query" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<EmailTemplatess>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/EmailTemplatess/List/");
	}

}

public partial class EmailTemplatessRepository : DSRepository<EmailTemplatess> {
	public EmailTemplatessRepository() : base(50, "EmailTemplatess", "Email Templates") {
	}
}
public partial class EmailTemplatess 
: DatasetBase<EmailTemplatess>, IDSBase
, Intrinsiq.Email.IEmailTemplate
  {
	  public int KeyValue => EMTIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "EMTId":
			return EMTIdField;
				case "EMTName":
			return EMTNameField;
				case "EMTBody":
			return EMTBodyField;
				case "EMTSubject":
			return EMTSubjectField;
				case "EMTFromAddr":
			return EMTFromAddrField;
				case "EMTToAddr":
			return EMTToAddrField;
				case "EMTCCAddr":
			return EMTCCAddrField;
				case "EMTBCCAddr":
			return EMTBCCAddrField;
				case "EMTQuery":
			return EMTQueryField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(EMTId,EMTIdField);
				action(EMTName,EMTNameField);
				action(EMTBody,EMTBodyField);
				action(EMTSubject,EMTSubjectField);
				action(EMTFromAddr,EMTFromAddrField);
				action(EMTToAddr,EMTToAddrField);
				action(EMTCCAddr,EMTCCAddrField);
				action(EMTBCCAddr,EMTBCCAddrField);
				action(EMTQuery,EMTQueryField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				EMTId.Visible=false;EMTName.Visible=false;EMTBody.Visible=false;EMTSubject.Visible=false;EMTFromAddr.Visible=false;EMTToAddr.Visible=false;EMTCCAddr.Visible=false;EMTBCCAddr.Visible=false;EMTQuery.Visible=false;			break;
					case 3:
				EMTId.Visible=false;EMTName.Visible=false;EMTBody.Visible=false;EMTSubject.Visible=false;EMTFromAddr.Visible=false;EMTToAddr.Visible=false;EMTCCAddr.Visible=false;EMTBCCAddr.Visible=false;EMTQuery.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update EmailTemplatess set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (EMTId.HasChanged && EMTId.HasValue) {
					SQL += ", EMTId=@EMTIdValue";

				}
								if (EMTName.HasChanged && EMTName.HasValue) {
					SQL += ", EMTName=@EMTNameValue";

				}
								if (EMTBody.HasChanged && EMTBody.HasValue) {
					SQL += ", EMTBody=@EMTBodyValue";

				}
								if (EMTSubject.HasChanged && EMTSubject.HasValue) {
					SQL += ", EMTSubject=@EMTSubjectValue";

				}
								if (EMTFromAddr.HasChanged && EMTFromAddr.HasValue) {
					SQL += ", EMTFromAddr=@EMTFromAddrValue";

				}
								if (EMTToAddr.HasChanged && EMTToAddr.HasValue) {
					SQL += ", EMTToAddr=@EMTToAddrValue";

				}
								if (EMTCCAddr.HasChanged && EMTCCAddr.HasValue) {
					SQL += ", EMTCCAddr=@EMTCCAddrValue";

				}
								if (EMTBCCAddr.HasChanged && EMTBCCAddr.HasValue) {
					SQL += ", EMTBCCAddr=@EMTBCCAddrValue";

				}
								if (EMTQuery.HasChanged && EMTQuery.HasValue) {
					SQL += ", EMTQuery=@EMTQueryValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									EMTId.HasChanged = false;
									EMTName.HasChanged = false;
									EMTBody.HasChanged = false;
									EMTSubject.HasChanged = false;
									EMTFromAddr.HasChanged = false;
									EMTToAddr.HasChanged = false;
									EMTCCAddr.HasChanged = false;
									EMTBCCAddr.HasChanged = false;
									EMTQuery.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into EmailTemplatess(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (EMTId.HasValue) {
					SQL += ", EMTId";
					Values += ", @EMTIdValue";
				}
				
				if (EMTName.HasValue) {
					SQL += ", EMTName";
					Values += ", @EMTNameValue";
				}
				
				if (EMTBody.HasValue) {
					SQL += ", EMTBody";
					Values += ", @EMTBodyValue";
				}
				
				if (EMTSubject.HasValue) {
					SQL += ", EMTSubject";
					Values += ", @EMTSubjectValue";
				}
				
				if (EMTFromAddr.HasValue) {
					SQL += ", EMTFromAddr";
					Values += ", @EMTFromAddrValue";
				}
				
				if (EMTToAddr.HasValue) {
					SQL += ", EMTToAddr";
					Values += ", @EMTToAddrValue";
				}
				
				if (EMTCCAddr.HasValue) {
					SQL += ", EMTCCAddr";
					Values += ", @EMTCCAddrValue";
				}
				
				if (EMTBCCAddr.HasValue) {
					SQL += ", EMTBCCAddr";
					Values += ", @EMTBCCAddrValue";
				}
				
				if (EMTQuery.HasValue) {
					SQL += ", EMTQuery";
					Values += ", @EMTQueryValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from EmailTemplatess");
					 IQApp.DB.Execute(SQL, this);
				                    					EMTId.HasChanged = false;
									EMTName.HasChanged = false;
									EMTBody.HasChanged = false;
									EMTSubject.HasChanged = false;
									EMTFromAddr.HasChanged = false;
									EMTToAddr.HasChanged = false;
									EMTCCAddr.HasChanged = false;
									EMTBCCAddr.HasChanged = false;
									EMTQuery.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "EMTId":
					return (IDSFieldBase)EMTId;
								case "EMTName":
					return (IDSFieldBase)EMTName;
								case "EMTBody":
					return (IDSFieldBase)EMTBody;
								case "EMTSubject":
					return (IDSFieldBase)EMTSubject;
								case "EMTFromAddr":
					return (IDSFieldBase)EMTFromAddr;
								case "EMTToAddr":
					return (IDSFieldBase)EMTToAddr;
								case "EMTCCAddr":
					return (IDSFieldBase)EMTCCAddr;
								case "EMTBCCAddr":
					return (IDSFieldBase)EMTBCCAddr;
								case "EMTQuery":
					return (IDSFieldBase)EMTQuery;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "EMTId":
					return EMTId.DisplayValue;
								case "EMTName":
					return EMTName.DisplayValue;
								case "EMTBody":
					return EMTBody.DisplayValue;
								case "EMTSubject":
					return EMTSubject.DisplayValue;
								case "EMTFromAddr":
					return EMTFromAddr.DisplayValue;
								case "EMTToAddr":
					return EMTToAddr.DisplayValue;
								case "EMTCCAddr":
					return EMTCCAddr.DisplayValue;
								case "EMTBCCAddr":
					return EMTBCCAddr.DisplayValue;
								case "EMTQuery":
					return EMTQuery.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "EMTId":
					return EMTId.Value.ToString();
								case "EMTName":
					return EMTName.Value.ToString();
								case "EMTBody":
					return EMTBody.Value.ToString();
								case "EMTSubject":
					return EMTSubject.Value.ToString();
								case "EMTFromAddr":
					return EMTFromAddr.Value.ToString();
								case "EMTToAddr":
					return EMTToAddr.Value.ToString();
								case "EMTCCAddr":
					return EMTCCAddr.Value.ToString();
								case "EMTBCCAddr":
					return EMTBCCAddr.Value.ToString();
								case "EMTQuery":
					return EMTQuery.Value.ToString();
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
					foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public EmailTemplatess () : base("EmailTemplatess") {
		base.obj = this;
	
					EMTId = new EmailTemplatess_EMTId(this);
					EMTName = new EmailTemplatess_EMTName(this);
					EMTBody = new EmailTemplatess_EMTBody(this);
					EMTSubject = new EmailTemplatess_EMTSubject(this);
					EMTFromAddr = new EmailTemplatess_EMTFromAddr(this);
					EMTToAddr = new EmailTemplatess_EMTToAddr(this);
					EMTCCAddr = new EmailTemplatess_EMTCCAddr(this);
					EMTBCCAddr = new EmailTemplatess_EMTBCCAddr(this);
					EMTQuery = new EmailTemplatess_EMTQuery(this);
			}

	static EmailTemplatess () {
					EMTIdField = new EmailTemplatess_EMTIdFieldDef();
					EMTNameField = new EmailTemplatess_EMTNameFieldDef();
					EMTBodyField = new EmailTemplatess_EMTBodyFieldDef();
					EMTSubjectField = new EmailTemplatess_EMTSubjectFieldDef();
					EMTFromAddrField = new EmailTemplatess_EMTFromAddrFieldDef();
					EMTToAddrField = new EmailTemplatess_EMTToAddrFieldDef();
					EMTCCAddrField = new EmailTemplatess_EMTCCAddrFieldDef();
					EMTBCCAddrField = new EmailTemplatess_EMTBCCAddrFieldDef();
					EMTQueryField = new EmailTemplatess_EMTQueryFieldDef();
			}

	public string RecordTitle { 
		get { return EMTNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Email Templates"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/EmailTemplatess/Load/?RecId=" + RecordID.Value;
			}
			return "/EmailTemplatess/Add";
			}
	}

			
		
		[Ignore()]
		public EmailTemplatess_EMTId EMTId { get; set; }
		public static EmailTemplatess_EMTIdFieldDef EMTIdField { get; private set; }
        
			
			[Column("EMTId")]
			public  int PopulateEMTId  {
				get { return EMTIdValue ;}
				set { EMTId.DataValue = value; }
			}

			public int Id {
			get { return EMTIdValue ; }
			set { EMTIdValue  = value; } 
		}
		[IQFieldName("EMTId")]
		public IDSFieldBase  IdField { 
			get { return (IDSFieldBase)EMTId; } 
			set { EMTId = (EmailTemplatess_EMTId)value; }
		}
	
			public int EMTIdValue 
			{ 
				get 
				{
				   if(EMTId.Value != null) {
				   					int i = 0;
					if (EMTId != null)
					{
						if (EMTId.Value != null)
						{
							if (Int32.TryParse(EMTId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { EMTId.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTName EMTName { get; set; }
		public static EmailTemplatess_EMTNameFieldDef EMTNameField { get; private set; }
        
			
			[Column("EMTName")]
			public  string PopulateEMTName  {
				get { return EMTNameValue ;}
				set { EMTName.DataValue = value; }
			}

			public string Name {
			get { return EMTNameValue ; }
			set { EMTNameValue  = value; } 
		}
		[IQFieldName("EMTName")]
		public IDSFieldBase  NameField { 
			get { return (IDSFieldBase)EMTName; } 
			set { EMTName = (EmailTemplatess_EMTName)value; }
		}
	
			public string EMTNameValue 
			{ 
				get 
				{
				   if(EMTName.Value != null) {
				   return EMTName.Value.ToString(); 					}
					return "";
                
				}
				set { EMTName.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTBody EMTBody { get; set; }
		public static EmailTemplatess_EMTBodyFieldDef EMTBodyField { get; private set; }
        
			
			[Column("EMTBody")]
			public  string PopulateEMTBody  {
				get { return EMTBodyValue ;}
				set { EMTBody.DataValue = value; }
			}

			public string Body {
			get { return EMTBodyValue ; }
			set { EMTBodyValue  = value; } 
		}
		[IQFieldName("EMTBody")]
		public IDSFieldBase  BodyField { 
			get { return (IDSFieldBase)EMTBody; } 
			set { EMTBody = (EmailTemplatess_EMTBody)value; }
		}
	
			public string EMTBodyValue 
			{ 
				get 
				{
				   if(EMTBody.Value != null) {
				   return EMTBody.Value.ToString(); 					}
					return "";
                
				}
				set { EMTBody.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTSubject EMTSubject { get; set; }
		public static EmailTemplatess_EMTSubjectFieldDef EMTSubjectField { get; private set; }
        
			
			[Column("EMTSubject")]
			public  string PopulateEMTSubject  {
				get { return EMTSubjectValue ;}
				set { EMTSubject.DataValue = value; }
			}

			public string Subject {
			get { return EMTSubjectValue ; }
			set { EMTSubjectValue  = value; } 
		}
		[IQFieldName("EMTSubject")]
		public IDSFieldBase  SubjectField { 
			get { return (IDSFieldBase)EMTSubject; } 
			set { EMTSubject = (EmailTemplatess_EMTSubject)value; }
		}
	
			public string EMTSubjectValue 
			{ 
				get 
				{
				   if(EMTSubject.Value != null) {
				   return EMTSubject.Value.ToString(); 					}
					return "";
                
				}
				set { EMTSubject.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTFromAddr EMTFromAddr { get; set; }
		public static EmailTemplatess_EMTFromAddrFieldDef EMTFromAddrField { get; private set; }
        
			
			[Column("EMTFromAddr")]
			public  string PopulateEMTFromAddr  {
				get { return EMTFromAddrValue ;}
				set { EMTFromAddr.DataValue = value; }
			}

			public string FromAddress {
			get { return EMTFromAddrValue ; }
			set { EMTFromAddrValue  = value; } 
		}
		[IQFieldName("EMTFromAddr")]
		public IDSFieldBase  FromAddressField { 
			get { return (IDSFieldBase)EMTFromAddr; } 
			set { EMTFromAddr = (EmailTemplatess_EMTFromAddr)value; }
		}
	
			public string EMTFromAddrValue 
			{ 
				get 
				{
				   if(EMTFromAddr.Value != null) {
				   return EMTFromAddr.Value.ToString(); 					}
					return "";
                
				}
				set { EMTFromAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTToAddr EMTToAddr { get; set; }
		public static EmailTemplatess_EMTToAddrFieldDef EMTToAddrField { get; private set; }
        
			
			[Column("EMTToAddr")]
			public  string PopulateEMTToAddr  {
				get { return EMTToAddrValue ;}
				set { EMTToAddr.DataValue = value; }
			}

			public string ToAddress {
			get { return EMTToAddrValue ; }
			set { EMTToAddrValue  = value; } 
		}
		[IQFieldName("EMTToAddr")]
		public IDSFieldBase  ToAddressField { 
			get { return (IDSFieldBase)EMTToAddr; } 
			set { EMTToAddr = (EmailTemplatess_EMTToAddr)value; }
		}
	
			public string EMTToAddrValue 
			{ 
				get 
				{
				   if(EMTToAddr.Value != null) {
				   return EMTToAddr.Value.ToString(); 					}
					return "";
                
				}
				set { EMTToAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTCCAddr EMTCCAddr { get; set; }
		public static EmailTemplatess_EMTCCAddrFieldDef EMTCCAddrField { get; private set; }
        
			
			[Column("EMTCCAddr")]
			public  string PopulateEMTCCAddr  {
				get { return EMTCCAddrValue ;}
				set { EMTCCAddr.DataValue = value; }
			}

			public string CCAddress {
			get { return EMTCCAddrValue ; }
			set { EMTCCAddrValue  = value; } 
		}
		[IQFieldName("EMTCCAddr")]
		public IDSFieldBase  CCAddressField { 
			get { return (IDSFieldBase)EMTCCAddr; } 
			set { EMTCCAddr = (EmailTemplatess_EMTCCAddr)value; }
		}
	
			public string EMTCCAddrValue 
			{ 
				get 
				{
				   if(EMTCCAddr.Value != null) {
				   return EMTCCAddr.Value.ToString(); 					}
					return "";
                
				}
				set { EMTCCAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTBCCAddr EMTBCCAddr { get; set; }
		public static EmailTemplatess_EMTBCCAddrFieldDef EMTBCCAddrField { get; private set; }
        
			
			[Column("EMTBCCAddr")]
			public  string PopulateEMTBCCAddr  {
				get { return EMTBCCAddrValue ;}
				set { EMTBCCAddr.DataValue = value; }
			}

			public string BCCAddress {
			get { return EMTBCCAddrValue ; }
			set { EMTBCCAddrValue  = value; } 
		}
		[IQFieldName("EMTBCCAddr")]
		public IDSFieldBase  BCCAddressField { 
			get { return (IDSFieldBase)EMTBCCAddr; } 
			set { EMTBCCAddr = (EmailTemplatess_EMTBCCAddr)value; }
		}
	
			public string EMTBCCAddrValue 
			{ 
				get 
				{
				   if(EMTBCCAddr.Value != null) {
				   return EMTBCCAddr.Value.ToString(); 					}
					return "";
                
				}
				set { EMTBCCAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public EmailTemplatess_EMTQuery EMTQuery { get; set; }
		public static EmailTemplatess_EMTQueryFieldDef EMTQueryField { get; private set; }
        
			
			[Column("EMTQuery")]
			public  string PopulateEMTQuery  {
				get { return EMTQueryValue ;}
				set { EMTQuery.DataValue = value; }
			}

			public string Query {
			get { return EMTQueryValue ; }
			set { EMTQueryValue  = value; } 
		}
		[IQFieldName("EMTQuery")]
		public IDSFieldBase  QueryField { 
			get { return (IDSFieldBase)EMTQuery; } 
			set { EMTQuery = (EmailTemplatess_EMTQuery)value; }
		}
	
			public string EMTQueryValue 
			{ 
				get 
				{
				   if(EMTQuery.Value != null) {
				   return EMTQuery.Value.ToString(); 					}
					return "";
                
				}
				set { EMTQuery.Value = value;  }
			}
	}


public class EmailTemplatess_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 50;
    public int PixelHeight => 0;
	public string Title => "Email Templates";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
