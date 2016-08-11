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


public partial class IStatRecController : DSBaseController<IStatRec/*,IStatRecSearch*/> {
	public IStatRecController() : base ((IDatabase)IQApp.DB, new IStatRecRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select IStId from IStatRec where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<IStatRec>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(IStatRec data) {
						IQApp.DB.Execute("Delete from IStatRec where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.IStIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from IStatRec " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from IStatRec " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from IStatRec " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/IStatRec_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<IStatRec>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<IStatRec>("select * from IStatRec  ").ToList();
		string urlpath = "/temp/Intrastat Records Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Intrastat Records");
				
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
							
					worksheet.Column(1).Width = 17;
					worksheet.Cells[1, 1].Value = "Intrastat ID";
						
								
					worksheet.Column(2).Width = 17;
					worksheet.Cells[1, 2].Value = "Order Number";
						
								
					worksheet.Column(3).Width = 17;
					worksheet.Cells[1, 3].Value = "Client ID";
						
								
					worksheet.Column(4).Width = 33;
					worksheet.Cells[1, 4].Value = "Client Order No";
						
								
					worksheet.Column(5).Width = 17;
					worksheet.Cells[1, 5].Value = "Job Number";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].IStId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].IStOrder.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].IStCustId.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].IStCustOrd.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].IStJobNo.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStId" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStId(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStId" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOrder" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStOrder(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOrder" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStCustId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStCustIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustId" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStCustId(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustId" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStCustValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCust" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStCust(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCust" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStSuppId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStSuppIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppId" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStSuppId(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppId" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStSupp(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStSuppValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSupp" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSupp")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStSupp(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSupp" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSupp")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStCustOrd(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStCustOrdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustOrd")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStCustOrd(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCustOrd")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStJobNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStJobNo(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.IStDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDate" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStDate(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDate" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStCommCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStCommCodeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCommCode" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCommCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStCommCode(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCommCode" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStCommCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStInvVal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.IStInvValValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvVal" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvVal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStInvVal(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvVal" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvVal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStInvCurr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStInvCurrValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvCurr" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvCurr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStInvCurr(IStatRec m, int? id, string q) {

		
		string s = m.IStInvCurr.DataSource;
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
	public ActionResult CallbackIStInvCurr(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvCurr" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvCurr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStSterlingVal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.IStSterlingValValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSterlingVal" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSterlingVal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStSterlingVal(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSterlingVal" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSterlingVal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStProcessed(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.IStProcessedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStProcessed" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStProcessed")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStProcessed(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStProcessed" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStProcessed")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStDelTerms(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStDelTermsValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDelTerms" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDelTerms")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStDelTerms(IStatRec m, int? id, string q) {

		
		string s = m.IStDelTerms.DataSource;
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
	public ActionResult CallbackIStDelTerms(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDelTerms" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStDelTerms")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStNAT1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStNAT1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT1" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStNAT1(IStatRec m, int? id, string q) {

		
		string s = m.IStNAT1.DataSource;
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
	public ActionResult CallbackIStNAT1(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT1" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStNAT2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStNAT2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT2" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStNAT2(IStatRec m, int? id, string q) {

		
		string s = m.IStNAT2.DataSource;
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
	public ActionResult CallbackIStNAT2(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT2" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStNAT2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStMass(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.IStMassValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMass" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMass")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStMass(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMass" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMass")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStSuppUnitVal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.IStSuppUnitValValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitVal" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitVal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStSuppUnitVal(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitVal" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitVal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStSuppUnitType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStSuppUnitTypeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitType" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStSuppUnitType(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitType" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStSuppUnitType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStConsignCtry(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStConsignCtryValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStConsignCtry" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStConsignCtry")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStConsignCtry(IStatRec m, int? id, string q) {

		
		string s = m.IStConsignCtry.DataSource;
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
	public ActionResult CallbackIStConsignCtry(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStConsignCtry" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStConsignCtry")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStTranspMode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStTranspModeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStTranspMode" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStTranspMode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStTranspMode(IStatRec m, int? id, string q) {

		
		string s = m.IStTranspMode.DataSource;
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
	public ActionResult CallbackIStTranspMode(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStTranspMode" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStTranspMode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStInvNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStInvNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvNo" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackIStInvNo(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvNo" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStInvNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStOriginCtry(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.IStOriginCtryValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOriginCtry" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOriginCtry")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStOriginCtry(IStatRec m, int? id, string q) {

		
		string s = m.IStOriginCtry.DataSource;
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
	public ActionResult CallbackIStOriginCtry(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOriginCtry" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStOriginCtry")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStMonth(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStMonthValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonth" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonth")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStMonth(IStatRec m, int? id, string q) {

		
		string s = m.IStMonth.DataSource;
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
	public ActionResult CallbackIStMonth(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonth" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonth")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStMonthDec(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStMonthDecValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonthDec" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonthDec")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStMonthDec(IStatRec m, int? id, string q) {

		
		string s = m.IStMonthDec.DataSource;
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
	public ActionResult CallbackIStMonthDec(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonthDec" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStMonthDec")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveIStRatePeriod(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<IStatRec>("select * from IStatRec where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.IStRatePeriodValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStRatePeriod" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStRatePeriod")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteIStRatePeriod(IStatRec m, int? id, string q) {

		
		string s = m.IStRatePeriod.DataSource;
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
	public ActionResult CallbackIStRatePeriod(IStatRec obj) {
			
		if(DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStRatePeriod" ).Any()) {
			foreach(var itm in DS.GetManager<IStatRec>().OnChange.Where(f=> f.Key == "IStRatePeriod")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<IStatRec>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=40 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/IStatRec/Search/" + FirstSearch);
		
		return Redirect("/IStatRec/List/");
	}

}

public partial class IStatRecRepository : DSRepository<IStatRec> {
	public IStatRecRepository() : base(40, "IStatRec", "Intrastat Records") {
	}
}
public partial class IStatRec 
: DatasetBase<IStatRec>, IDSBase

  {
	  public int KeyValue => IStIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "IStId":
			return IStIdField;
				case "IStOrder":
			return IStOrderField;
				case "IStCustId":
			return IStCustIdField;
				case "IStCust":
			return IStCustField;
				case "IStSuppId":
			return IStSuppIdField;
				case "IStSupp":
			return IStSuppField;
				case "IStCustOrd":
			return IStCustOrdField;
				case "IStJobNo":
			return IStJobNoField;
				case "IStDate":
			return IStDateField;
				case "IStCommCode":
			return IStCommCodeField;
				case "IStInvVal":
			return IStInvValField;
				case "IStInvCurr":
			return IStInvCurrField;
				case "IStSterlingVal":
			return IStSterlingValField;
				case "IStProcessed":
			return IStProcessedField;
				case "IStDelTerms":
			return IStDelTermsField;
				case "IStNAT1":
			return IStNAT1Field;
				case "IStNAT2":
			return IStNAT2Field;
				case "IStMass":
			return IStMassField;
				case "IStSuppUnitVal":
			return IStSuppUnitValField;
				case "IStSuppUnitType":
			return IStSuppUnitTypeField;
				case "IStConsignCtry":
			return IStConsignCtryField;
				case "IStTranspMode":
			return IStTranspModeField;
				case "IStInvNo":
			return IStInvNoField;
				case "IStOriginCtry":
			return IStOriginCtryField;
				case "IStMonth":
			return IStMonthField;
				case "IStMonthDec":
			return IStMonthDecField;
				case "IStRatePeriod":
			return IStRatePeriodField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(IStId,IStIdField);
				action(IStOrder,IStOrderField);
				action(IStCustId,IStCustIdField);
				action(IStCust,IStCustField);
				action(IStSuppId,IStSuppIdField);
				action(IStSupp,IStSuppField);
				action(IStCustOrd,IStCustOrdField);
				action(IStJobNo,IStJobNoField);
				action(IStDate,IStDateField);
				action(IStCommCode,IStCommCodeField);
				action(IStInvVal,IStInvValField);
				action(IStInvCurr,IStInvCurrField);
				action(IStSterlingVal,IStSterlingValField);
				action(IStProcessed,IStProcessedField);
				action(IStDelTerms,IStDelTermsField);
				action(IStNAT1,IStNAT1Field);
				action(IStNAT2,IStNAT2Field);
				action(IStMass,IStMassField);
				action(IStSuppUnitVal,IStSuppUnitValField);
				action(IStSuppUnitType,IStSuppUnitTypeField);
				action(IStConsignCtry,IStConsignCtryField);
				action(IStTranspMode,IStTranspModeField);
				action(IStInvNo,IStInvNoField);
				action(IStOriginCtry,IStOriginCtryField);
				action(IStMonth,IStMonthField);
				action(IStMonthDec,IStMonthDecField);
				action(IStRatePeriod,IStRatePeriodField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				IStId.Visible=false;IStOrder.Visible=false;IStCustId.Visible=false;IStCust.Visible=false;IStSuppId.Visible=false;IStSupp.Visible=false;IStCustOrd.Visible=false;IStJobNo.Visible=false;IStDate.Visible=false;IStCommCode.Visible=false;IStInvVal.Visible=false;IStInvCurr.Visible=false;IStSterlingVal.Visible=false;IStProcessed.Visible=false;IStDelTerms.Visible=false;IStNAT1.Visible=false;IStNAT2.Visible=false;IStMass.Visible=false;IStSuppUnitVal.Visible=false;IStSuppUnitType.Visible=false;IStConsignCtry.Visible=false;IStTranspMode.Visible=false;IStInvNo.Visible=false;IStOriginCtry.Visible=false;IStMonth.Visible=false;IStMonthDec.Visible=false;IStRatePeriod.Visible=false;			break;
					case 3:
				IStId.Visible=false;IStOrder.Visible=false;IStCustId.Visible=false;IStCust.Visible=false;IStSuppId.Visible=false;IStSupp.Visible=false;IStCustOrd.Visible=false;IStJobNo.Visible=false;IStDate.Visible=false;IStCommCode.Visible=false;IStInvVal.Visible=false;IStInvCurr.Visible=false;IStSterlingVal.Visible=false;IStProcessed.Visible=false;IStDelTerms.Visible=false;IStNAT1.Visible=false;IStNAT2.Visible=false;IStMass.Visible=false;IStSuppUnitVal.Visible=false;IStSuppUnitType.Visible=false;IStConsignCtry.Visible=false;IStTranspMode.Visible=false;IStInvNo.Visible=false;IStOriginCtry.Visible=false;IStMonth.Visible=false;IStMonthDec.Visible=false;IStRatePeriod.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update IStatRec set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (IStId.HasChanged && IStId.HasValue) {
					SQL += ", IStId=@IStIdValue";

				}
								if (IStOrder.HasChanged && IStOrder.HasValue) {
					SQL += ", IStOrder=@IStOrderValue";

				}
								if (IStCustId.HasChanged && IStCustId.HasValue) {
					SQL += ", IStCustId=@IStCustIdValue";

				}
								if (IStCust.HasChanged && IStCust.HasValue) {
					SQL += ", IStCust=@IStCustValue";

				}
								if (IStSuppId.HasChanged && IStSuppId.HasValue) {
					SQL += ", IStSuppId=@IStSuppIdValue";

				}
								if (IStSupp.HasChanged && IStSupp.HasValue) {
					SQL += ", IStSupp=@IStSuppValue";

				}
								if (IStCustOrd.HasChanged && IStCustOrd.HasValue) {
					SQL += ", IStCustOrd=@IStCustOrdValue";

				}
								if (IStJobNo.HasChanged && IStJobNo.HasValue) {
					SQL += ", IStJobNo=@IStJobNoValue";

				}
								if (IStDate.HasChanged && IStDate.HasValue) {
					SQL += ", IStDate=@IStDateValue";

				}
								if (IStCommCode.HasChanged && IStCommCode.HasValue) {
					SQL += ", IStCommCode=@IStCommCodeValue";

				}
								if (IStInvVal.HasChanged && IStInvVal.HasValue) {
					SQL += ", IStInvVal=@IStInvValValue";

				}
								if (IStInvCurr.HasChanged && IStInvCurr.HasValue) {
					SQL += ", IStInvCurr=@IStInvCurrValue";

				}
								if (IStSterlingVal.HasChanged && IStSterlingVal.HasValue) {
					SQL += ", IStSterlingVal=@IStSterlingValValue";

				}
								if (IStProcessed.HasChanged && IStProcessed.HasValue) {
					SQL += ", IStProcessed=@IStProcessedValue";

				}
								if (IStDelTerms.HasChanged && IStDelTerms.HasValue) {
					SQL += ", IStDelTerms=@IStDelTermsValue";

				}
								if (IStNAT1.HasChanged && IStNAT1.HasValue) {
					SQL += ", IStNAT1=@IStNAT1Value";

				}
								if (IStNAT2.HasChanged && IStNAT2.HasValue) {
					SQL += ", IStNAT2=@IStNAT2Value";

				}
								if (IStMass.HasChanged && IStMass.HasValue) {
					SQL += ", IStMass=@IStMassValue";

				}
								if (IStSuppUnitVal.HasChanged && IStSuppUnitVal.HasValue) {
					SQL += ", IStSuppUnitVal=@IStSuppUnitValValue";

				}
								if (IStSuppUnitType.HasChanged && IStSuppUnitType.HasValue) {
					SQL += ", IStSuppUnitType=@IStSuppUnitTypeValue";

				}
								if (IStConsignCtry.HasChanged && IStConsignCtry.HasValue) {
					SQL += ", IStConsignCtry=@IStConsignCtryValue";

				}
								if (IStTranspMode.HasChanged && IStTranspMode.HasValue) {
					SQL += ", IStTranspMode=@IStTranspModeValue";

				}
								if (IStInvNo.HasChanged && IStInvNo.HasValue) {
					SQL += ", IStInvNo=@IStInvNoValue";

				}
								if (IStOriginCtry.HasChanged && IStOriginCtry.HasValue) {
					SQL += ", IStOriginCtry=@IStOriginCtryValue";

				}
								if (IStMonth.HasChanged && IStMonth.HasValue) {
					SQL += ", IStMonth=@IStMonthValue";

				}
								if (IStMonthDec.HasChanged && IStMonthDec.HasValue) {
					SQL += ", IStMonthDec=@IStMonthDecValue";

				}
								if (IStRatePeriod.HasChanged && IStRatePeriod.HasValue) {
					SQL += ", IStRatePeriod=@IStRatePeriodValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									IStId.HasChanged = false;
									IStOrder.HasChanged = false;
									IStCustId.HasChanged = false;
									IStCust.HasChanged = false;
									IStSuppId.HasChanged = false;
									IStSupp.HasChanged = false;
									IStCustOrd.HasChanged = false;
									IStJobNo.HasChanged = false;
									IStDate.HasChanged = false;
									IStCommCode.HasChanged = false;
									IStInvVal.HasChanged = false;
									IStInvCurr.HasChanged = false;
									IStSterlingVal.HasChanged = false;
									IStProcessed.HasChanged = false;
									IStDelTerms.HasChanged = false;
									IStNAT1.HasChanged = false;
									IStNAT2.HasChanged = false;
									IStMass.HasChanged = false;
									IStSuppUnitVal.HasChanged = false;
									IStSuppUnitType.HasChanged = false;
									IStConsignCtry.HasChanged = false;
									IStTranspMode.HasChanged = false;
									IStInvNo.HasChanged = false;
									IStOriginCtry.HasChanged = false;
									IStMonth.HasChanged = false;
									IStMonthDec.HasChanged = false;
									IStRatePeriod.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into IStatRec(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				IStId.Value = IQApp.DB.GetInt("select isnull(max(IStId),0)+1 from IStatRec");
				if (IStId.HasValue) {
					SQL += ", IStId";
					Values += ", @IStIdValue";
				}
				
				if (IStOrder.HasValue) {
					SQL += ", IStOrder";
					Values += ", @IStOrderValue";
				}
				
				if (IStCustId.HasValue) {
					SQL += ", IStCustId";
					Values += ", @IStCustIdValue";
				}
				
				if (IStCust.HasValue) {
					SQL += ", IStCust";
					Values += ", @IStCustValue";
				}
				
				if (IStSuppId.HasValue) {
					SQL += ", IStSuppId";
					Values += ", @IStSuppIdValue";
				}
				
				if (IStSupp.HasValue) {
					SQL += ", IStSupp";
					Values += ", @IStSuppValue";
				}
				
				if (IStCustOrd.HasValue) {
					SQL += ", IStCustOrd";
					Values += ", @IStCustOrdValue";
				}
				
				if (IStJobNo.HasValue) {
					SQL += ", IStJobNo";
					Values += ", @IStJobNoValue";
				}
				
				if (IStDate.HasValue) {
					SQL += ", IStDate";
					Values += ", @IStDateValue";
				}
				
				if (IStCommCode.HasValue) {
					SQL += ", IStCommCode";
					Values += ", @IStCommCodeValue";
				}
				
				if (IStInvVal.HasValue) {
					SQL += ", IStInvVal";
					Values += ", @IStInvValValue";
				}
				
				if (IStInvCurr.HasValue) {
					SQL += ", IStInvCurr";
					Values += ", @IStInvCurrValue";
				}
				
				if (IStSterlingVal.HasValue) {
					SQL += ", IStSterlingVal";
					Values += ", @IStSterlingValValue";
				}
				
				if (IStProcessed.HasValue) {
					SQL += ", IStProcessed";
					Values += ", @IStProcessedValue";
				}
				
				if (IStDelTerms.HasValue) {
					SQL += ", IStDelTerms";
					Values += ", @IStDelTermsValue";
				}
				
				if (IStNAT1.HasValue) {
					SQL += ", IStNAT1";
					Values += ", @IStNAT1Value";
				}
				
				if (IStNAT2.HasValue) {
					SQL += ", IStNAT2";
					Values += ", @IStNAT2Value";
				}
				
				if (IStMass.HasValue) {
					SQL += ", IStMass";
					Values += ", @IStMassValue";
				}
				
				if (IStSuppUnitVal.HasValue) {
					SQL += ", IStSuppUnitVal";
					Values += ", @IStSuppUnitValValue";
				}
				
				if (IStSuppUnitType.HasValue) {
					SQL += ", IStSuppUnitType";
					Values += ", @IStSuppUnitTypeValue";
				}
				
				if (IStConsignCtry.HasValue) {
					SQL += ", IStConsignCtry";
					Values += ", @IStConsignCtryValue";
				}
				
				if (IStTranspMode.HasValue) {
					SQL += ", IStTranspMode";
					Values += ", @IStTranspModeValue";
				}
				
				if (IStInvNo.HasValue) {
					SQL += ", IStInvNo";
					Values += ", @IStInvNoValue";
				}
				
				if (IStOriginCtry.HasValue) {
					SQL += ", IStOriginCtry";
					Values += ", @IStOriginCtryValue";
				}
				
				if (IStMonth.HasValue) {
					SQL += ", IStMonth";
					Values += ", @IStMonthValue";
				}
				
				if (IStMonthDec.HasValue) {
					SQL += ", IStMonthDec";
					Values += ", @IStMonthDecValue";
				}
				
				if (IStRatePeriod.HasValue) {
					SQL += ", IStRatePeriod";
					Values += ", @IStRatePeriodValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from IStatRec");
					 IQApp.DB.Execute(SQL, this);
				                    					IStId.HasChanged = false;
									IStOrder.HasChanged = false;
									IStCustId.HasChanged = false;
									IStCust.HasChanged = false;
									IStSuppId.HasChanged = false;
									IStSupp.HasChanged = false;
									IStCustOrd.HasChanged = false;
									IStJobNo.HasChanged = false;
									IStDate.HasChanged = false;
									IStCommCode.HasChanged = false;
									IStInvVal.HasChanged = false;
									IStInvCurr.HasChanged = false;
									IStSterlingVal.HasChanged = false;
									IStProcessed.HasChanged = false;
									IStDelTerms.HasChanged = false;
									IStNAT1.HasChanged = false;
									IStNAT2.HasChanged = false;
									IStMass.HasChanged = false;
									IStSuppUnitVal.HasChanged = false;
									IStSuppUnitType.HasChanged = false;
									IStConsignCtry.HasChanged = false;
									IStTranspMode.HasChanged = false;
									IStInvNo.HasChanged = false;
									IStOriginCtry.HasChanged = false;
									IStMonth.HasChanged = false;
									IStMonthDec.HasChanged = false;
									IStRatePeriod.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "IStId":
					return (IDSFieldBase)IStId;
								case "IStOrder":
					return (IDSFieldBase)IStOrder;
								case "IStCustId":
					return (IDSFieldBase)IStCustId;
								case "IStCust":
					return (IDSFieldBase)IStCust;
								case "IStSuppId":
					return (IDSFieldBase)IStSuppId;
								case "IStSupp":
					return (IDSFieldBase)IStSupp;
								case "IStCustOrd":
					return (IDSFieldBase)IStCustOrd;
								case "IStJobNo":
					return (IDSFieldBase)IStJobNo;
								case "IStDate":
					return (IDSFieldBase)IStDate;
								case "IStCommCode":
					return (IDSFieldBase)IStCommCode;
								case "IStInvVal":
					return (IDSFieldBase)IStInvVal;
								case "IStInvCurr":
					return (IDSFieldBase)IStInvCurr;
								case "IStSterlingVal":
					return (IDSFieldBase)IStSterlingVal;
								case "IStProcessed":
					return (IDSFieldBase)IStProcessed;
								case "IStDelTerms":
					return (IDSFieldBase)IStDelTerms;
								case "IStNAT1":
					return (IDSFieldBase)IStNAT1;
								case "IStNAT2":
					return (IDSFieldBase)IStNAT2;
								case "IStMass":
					return (IDSFieldBase)IStMass;
								case "IStSuppUnitVal":
					return (IDSFieldBase)IStSuppUnitVal;
								case "IStSuppUnitType":
					return (IDSFieldBase)IStSuppUnitType;
								case "IStConsignCtry":
					return (IDSFieldBase)IStConsignCtry;
								case "IStTranspMode":
					return (IDSFieldBase)IStTranspMode;
								case "IStInvNo":
					return (IDSFieldBase)IStInvNo;
								case "IStOriginCtry":
					return (IDSFieldBase)IStOriginCtry;
								case "IStMonth":
					return (IDSFieldBase)IStMonth;
								case "IStMonthDec":
					return (IDSFieldBase)IStMonthDec;
								case "IStRatePeriod":
					return (IDSFieldBase)IStRatePeriod;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "IStId":
					return IStId.DisplayValue;
								case "IStOrder":
					return IStOrder.DisplayValue;
								case "IStCustId":
					return IStCustId.DisplayValue;
								case "IStCust":
					return IStCust.DisplayValue;
								case "IStSuppId":
					return IStSuppId.DisplayValue;
								case "IStSupp":
					return IStSupp.DisplayValue;
								case "IStCustOrd":
					return IStCustOrd.DisplayValue;
								case "IStJobNo":
					return IStJobNo.DisplayValue;
								case "IStDate":
					return IStDate.DisplayValue;
								case "IStCommCode":
					return IStCommCode.DisplayValue;
								case "IStInvVal":
					return IStInvVal.DisplayValue;
								case "IStInvCurr":
					return IStInvCurr.DisplayValue;
								case "IStSterlingVal":
					return IStSterlingVal.DisplayValue;
								case "IStProcessed":
					return IStProcessed.DisplayValue;
								case "IStDelTerms":
					return IStDelTerms.DisplayValue;
								case "IStNAT1":
					return IStNAT1.DisplayValue;
								case "IStNAT2":
					return IStNAT2.DisplayValue;
								case "IStMass":
					return IStMass.DisplayValue;
								case "IStSuppUnitVal":
					return IStSuppUnitVal.DisplayValue;
								case "IStSuppUnitType":
					return IStSuppUnitType.DisplayValue;
								case "IStConsignCtry":
					return IStConsignCtry.DisplayValue;
								case "IStTranspMode":
					return IStTranspMode.DisplayValue;
								case "IStInvNo":
					return IStInvNo.DisplayValue;
								case "IStOriginCtry":
					return IStOriginCtry.DisplayValue;
								case "IStMonth":
					return IStMonth.DisplayValue;
								case "IStMonthDec":
					return IStMonthDec.DisplayValue;
								case "IStRatePeriod":
					return IStRatePeriod.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "IStId":
					return IStId.Value.ToString();
								case "IStOrder":
					return IStOrder.Value.ToString();
								case "IStCustId":
					return IStCustId.Value.ToString();
								case "IStCust":
					return IStCust.Value.ToString();
								case "IStSuppId":
					return IStSuppId.Value.ToString();
								case "IStSupp":
					return IStSupp.Value.ToString();
								case "IStCustOrd":
					return IStCustOrd.Value.ToString();
								case "IStJobNo":
					return IStJobNo.Value.ToString();
								case "IStDate":
					return IStDate.Value.ToString();
								case "IStCommCode":
					return IStCommCode.Value.ToString();
								case "IStInvVal":
					return IStInvVal.Value.ToString();
								case "IStInvCurr":
					return IStInvCurr.Value.ToString();
								case "IStSterlingVal":
					return IStSterlingVal.Value.ToString();
								case "IStProcessed":
					return IStProcessed.Value.ToString();
								case "IStDelTerms":
					return IStDelTerms.Value.ToString();
								case "IStNAT1":
					return IStNAT1.Value.ToString();
								case "IStNAT2":
					return IStNAT2.Value.ToString();
								case "IStMass":
					return IStMass.Value.ToString();
								case "IStSuppUnitVal":
					return IStSuppUnitVal.Value.ToString();
								case "IStSuppUnitType":
					return IStSuppUnitType.Value.ToString();
								case "IStConsignCtry":
					return IStConsignCtry.Value.ToString();
								case "IStTranspMode":
					return IStTranspMode.Value.ToString();
								case "IStInvNo":
					return IStInvNo.Value.ToString();
								case "IStOriginCtry":
					return IStOriginCtry.Value.ToString();
								case "IStMonth":
					return IStMonth.Value.ToString();
								case "IStMonthDec":
					return IStMonthDec.Value.ToString();
								case "IStRatePeriod":
					return IStRatePeriod.Value.ToString();
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
					foreach(var itm in DS.GetManager<IStatRec>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public IStatRec () : base("IStatRec") {
		base.obj = this;
	
					IStId = new IStatRec_IStId(this);
					IStOrder = new IStatRec_IStOrder(this);
					IStCustId = new IStatRec_IStCustId(this);
					IStCust = new IStatRec_IStCust(this);
					IStSuppId = new IStatRec_IStSuppId(this);
					IStSupp = new IStatRec_IStSupp(this);
					IStCustOrd = new IStatRec_IStCustOrd(this);
					IStJobNo = new IStatRec_IStJobNo(this);
					IStDate = new IStatRec_IStDate(this);
					IStCommCode = new IStatRec_IStCommCode(this);
					IStInvVal = new IStatRec_IStInvVal(this);
					IStInvCurr = new IStatRec_IStInvCurr(this);
					IStSterlingVal = new IStatRec_IStSterlingVal(this);
					IStProcessed = new IStatRec_IStProcessed(this);
					IStDelTerms = new IStatRec_IStDelTerms(this);
					IStNAT1 = new IStatRec_IStNAT1(this);
					IStNAT2 = new IStatRec_IStNAT2(this);
					IStMass = new IStatRec_IStMass(this);
					IStSuppUnitVal = new IStatRec_IStSuppUnitVal(this);
					IStSuppUnitType = new IStatRec_IStSuppUnitType(this);
					IStConsignCtry = new IStatRec_IStConsignCtry(this);
					IStTranspMode = new IStatRec_IStTranspMode(this);
					IStInvNo = new IStatRec_IStInvNo(this);
					IStOriginCtry = new IStatRec_IStOriginCtry(this);
					IStMonth = new IStatRec_IStMonth(this);
					IStMonthDec = new IStatRec_IStMonthDec(this);
					IStRatePeriod = new IStatRec_IStRatePeriod(this);
			}

	static IStatRec () {
					IStIdField = new IStatRec_IStIdFieldDef();
					IStOrderField = new IStatRec_IStOrderFieldDef();
					IStCustIdField = new IStatRec_IStCustIdFieldDef();
					IStCustField = new IStatRec_IStCustFieldDef();
					IStSuppIdField = new IStatRec_IStSuppIdFieldDef();
					IStSuppField = new IStatRec_IStSuppFieldDef();
					IStCustOrdField = new IStatRec_IStCustOrdFieldDef();
					IStJobNoField = new IStatRec_IStJobNoFieldDef();
					IStDateField = new IStatRec_IStDateFieldDef();
					IStCommCodeField = new IStatRec_IStCommCodeFieldDef();
					IStInvValField = new IStatRec_IStInvValFieldDef();
					IStInvCurrField = new IStatRec_IStInvCurrFieldDef();
					IStSterlingValField = new IStatRec_IStSterlingValFieldDef();
					IStProcessedField = new IStatRec_IStProcessedFieldDef();
					IStDelTermsField = new IStatRec_IStDelTermsFieldDef();
					IStNAT1Field = new IStatRec_IStNAT1FieldDef();
					IStNAT2Field = new IStatRec_IStNAT2FieldDef();
					IStMassField = new IStatRec_IStMassFieldDef();
					IStSuppUnitValField = new IStatRec_IStSuppUnitValFieldDef();
					IStSuppUnitTypeField = new IStatRec_IStSuppUnitTypeFieldDef();
					IStConsignCtryField = new IStatRec_IStConsignCtryFieldDef();
					IStTranspModeField = new IStatRec_IStTranspModeFieldDef();
					IStInvNoField = new IStatRec_IStInvNoFieldDef();
					IStOriginCtryField = new IStatRec_IStOriginCtryFieldDef();
					IStMonthField = new IStatRec_IStMonthFieldDef();
					IStMonthDecField = new IStatRec_IStMonthDecFieldDef();
					IStRatePeriodField = new IStatRec_IStRatePeriodFieldDef();
			}

	public string RecordTitle { 
		get { return IStIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Intrastat Records"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/IStatRec/Load/?RecId=" + RecordID.Value;
			}
			return "/IStatRec/Add";
			}
	}

			
		
		[Ignore()]
		public IStatRec_IStId IStId { get; set; }
		public static IStatRec_IStIdFieldDef IStIdField { get; private set; }
        
			
			[Column("IStId")]
			public  int PopulateIStId  {
				get { return IStIdValue ;}
				set { IStId.DataValue = value; }
			}

	
			public int IStIdValue 
			{ 
				get 
				{
				   if(IStId.Value != null) {
				   					int i = 0;
					if (IStId != null)
					{
						if (IStId.Value != null)
						{
							if (Int32.TryParse(IStId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStId.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStOrder IStOrder { get; set; }
		public static IStatRec_IStOrderFieldDef IStOrderField { get; private set; }
        
			
			[Column("IStOrder")]
			public  int PopulateIStOrder  {
				get { return IStOrderValue ;}
				set { IStOrder.DataValue = value; }
			}

	
			public int IStOrderValue 
			{ 
				get 
				{
				   if(IStOrder.Value != null) {
				   					int i = 0;
					if (IStOrder != null)
					{
						if (IStOrder.Value != null)
						{
							if (Int32.TryParse(IStOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStCustId IStCustId { get; set; }
		public static IStatRec_IStCustIdFieldDef IStCustIdField { get; private set; }
        
			
			[Column("IStCustId")]
			public  int PopulateIStCustId  {
				get { return IStCustIdValue ;}
				set { IStCustId.DataValue = value; }
			}

	
			public int IStCustIdValue 
			{ 
				get 
				{
				   if(IStCustId.Value != null) {
				   					int i = 0;
					if (IStCustId != null)
					{
						if (IStCustId.Value != null)
						{
							if (Int32.TryParse(IStCustId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStCustId.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStCust IStCust { get; set; }
		public static IStatRec_IStCustFieldDef IStCustField { get; private set; }
        
			
			[Column("IStCust")]
			public  string PopulateIStCust  {
				get { return IStCustValue ;}
				set { IStCust.DataValue = value; }
			}

	
			public string IStCustValue 
			{ 
				get 
				{
				   if(IStCust.Value != null) {
				   return IStCust.Value.ToString(); 					}
					return "";
                
				}
				set { IStCust.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStSuppId IStSuppId { get; set; }
		public static IStatRec_IStSuppIdFieldDef IStSuppIdField { get; private set; }
        
			
			[Column("IStSuppId")]
			public  int PopulateIStSuppId  {
				get { return IStSuppIdValue ;}
				set { IStSuppId.DataValue = value; }
			}

	
			public int IStSuppIdValue 
			{ 
				get 
				{
				   if(IStSuppId.Value != null) {
				   					int i = 0;
					if (IStSuppId != null)
					{
						if (IStSuppId.Value != null)
						{
							if (Int32.TryParse(IStSuppId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStSuppId.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStSupp IStSupp { get; set; }
		public static IStatRec_IStSuppFieldDef IStSuppField { get; private set; }
        
			
			[Column("IStSupp")]
			public  string PopulateIStSupp  {
				get { return IStSuppValue ;}
				set { IStSupp.DataValue = value; }
			}

	
			public string IStSuppValue 
			{ 
				get 
				{
				   if(IStSupp.Value != null) {
				   return IStSupp.Value.ToString(); 					}
					return "";
                
				}
				set { IStSupp.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStCustOrd IStCustOrd { get; set; }
		public static IStatRec_IStCustOrdFieldDef IStCustOrdField { get; private set; }
        
			
			[Column("IStCustOrd")]
			public  string PopulateIStCustOrd  {
				get { return IStCustOrdValue ;}
				set { IStCustOrd.DataValue = value; }
			}

	
			public string IStCustOrdValue 
			{ 
				get 
				{
				   if(IStCustOrd.Value != null) {
				   return IStCustOrd.Value.ToString(); 					}
					return "";
                
				}
				set { IStCustOrd.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStJobNo IStJobNo { get; set; }
		public static IStatRec_IStJobNoFieldDef IStJobNoField { get; private set; }
        
			
			[Column("IStJobNo")]
			public  string PopulateIStJobNo  {
				get { return IStJobNoValue ;}
				set { IStJobNo.DataValue = value; }
			}

	
			public string IStJobNoValue 
			{ 
				get 
				{
				   if(IStJobNo.Value != null) {
				   return IStJobNo.Value.ToString(); 					}
					return "";
                
				}
				set { IStJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStDate IStDate { get; set; }
		public static IStatRec_IStDateFieldDef IStDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("IStDate")]
			public  DateTime PopulateIStDate  {
				get { return IStDateValue ;}
				set { IStDate.DataValue = value; }
			}

	
			public DateTime IStDateValue 
			{ 
				get 
				{
				   if(IStDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (IStDate != null)
					{
						if (IStDate.Value != null)
						{
							if (DateTime.TryParse(IStDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { IStDate.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStCommCode IStCommCode { get; set; }
		public static IStatRec_IStCommCodeFieldDef IStCommCodeField { get; private set; }
        
			
			[Column("IStCommCode")]
			public  int PopulateIStCommCode  {
				get { return IStCommCodeValue ;}
				set { IStCommCode.DataValue = value; }
			}

	
			public int IStCommCodeValue 
			{ 
				get 
				{
				   if(IStCommCode.Value != null) {
				   					int i = 0;
					if (IStCommCode != null)
					{
						if (IStCommCode.Value != null)
						{
							if (Int32.TryParse(IStCommCode.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStCommCode.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStInvVal IStInvVal { get; set; }
		public static IStatRec_IStInvValFieldDef IStInvValField { get; private set; }
        
			
			[Column("IStInvVal")]
			public  double PopulateIStInvVal  {
				get { return IStInvValValue ;}
				set { IStInvVal.DataValue = value; }
			}

	
			public double IStInvValValue 
			{ 
				get 
				{
				   if(IStInvVal.Value != null) {
				   					double i = 0.0;
					if (IStInvVal != null)
					{
						if (IStInvVal.Value != null)
						{
							if (Double.TryParse(IStInvVal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { IStInvVal.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStInvCurr IStInvCurr { get; set; }
		public static IStatRec_IStInvCurrFieldDef IStInvCurrField { get; private set; }
        
			
			[Column("IStInvCurr")]
			public  int PopulateIStInvCurr  {
				get { return IStInvCurrValue ;}
				set { IStInvCurr.DataValue = value; }
			}

	
			public int IStInvCurrValue 
			{ 
				get 
				{
				   if(IStInvCurr.Value != null) {
				   					int i = 0;
					if (IStInvCurr != null)
					{
						if (IStInvCurr.Value != null)
						{
							if (Int32.TryParse(IStInvCurr.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStInvCurr.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStSterlingVal IStSterlingVal { get; set; }
		public static IStatRec_IStSterlingValFieldDef IStSterlingValField { get; private set; }
        
			
			[Column("IStSterlingVal")]
			public  double PopulateIStSterlingVal  {
				get { return IStSterlingValValue ;}
				set { IStSterlingVal.DataValue = value; }
			}

	
			public double IStSterlingValValue 
			{ 
				get 
				{
				   if(IStSterlingVal.Value != null) {
				   					double i = 0.0;
					if (IStSterlingVal != null)
					{
						if (IStSterlingVal.Value != null)
						{
							if (Double.TryParse(IStSterlingVal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { IStSterlingVal.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStProcessed IStProcessed { get; set; }
		public static IStatRec_IStProcessedFieldDef IStProcessedField { get; private set; }
        
			
			[Column("IStProcessed")]
			public  bool PopulateIStProcessed  {
				get { return IStProcessedValue ;}
				set { IStProcessed.DataValue = value; }
			}

	
			public bool IStProcessedValue 
			{ 
				get 
				{
				   if(IStProcessed.Value != null) {
				   					bool i = false;
					if (IStProcessed != null)
					{
						if (IStProcessed.Value != null)
						{
							if (Boolean.TryParse(IStProcessed.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { IStProcessed.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStDelTerms IStDelTerms { get; set; }
		public static IStatRec_IStDelTermsFieldDef IStDelTermsField { get; private set; }
        
			
			[Column("IStDelTerms")]
			public  string PopulateIStDelTerms  {
				get { return IStDelTermsValue ;}
				set { IStDelTerms.DataValue = value; }
			}

	
			public string IStDelTermsValue 
			{ 
				get 
				{
				   if(IStDelTerms.Value != null) {
				   return IStDelTerms.Value.ToString(); 					}
					return "";
                
				}
				set { IStDelTerms.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStNAT1 IStNAT1 { get; set; }
		public static IStatRec_IStNAT1FieldDef IStNAT1Field { get; private set; }
        
			
			[Column("IStNAT1")]
			public  int PopulateIStNAT1  {
				get { return IStNAT1Value ;}
				set { IStNAT1.DataValue = value; }
			}

	
			public int IStNAT1Value 
			{ 
				get 
				{
				   if(IStNAT1.Value != null) {
				   					int i = 0;
					if (IStNAT1 != null)
					{
						if (IStNAT1.Value != null)
						{
							if (Int32.TryParse(IStNAT1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStNAT1.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStNAT2 IStNAT2 { get; set; }
		public static IStatRec_IStNAT2FieldDef IStNAT2Field { get; private set; }
        
			
			[Column("IStNAT2")]
			public  int PopulateIStNAT2  {
				get { return IStNAT2Value ;}
				set { IStNAT2.DataValue = value; }
			}

	
			public int IStNAT2Value 
			{ 
				get 
				{
				   if(IStNAT2.Value != null) {
				   					int i = 0;
					if (IStNAT2 != null)
					{
						if (IStNAT2.Value != null)
						{
							if (Int32.TryParse(IStNAT2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStNAT2.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStMass IStMass { get; set; }
		public static IStatRec_IStMassFieldDef IStMassField { get; private set; }
        
			
			[Column("IStMass")]
			public  double PopulateIStMass  {
				get { return IStMassValue ;}
				set { IStMass.DataValue = value; }
			}

	
			public double IStMassValue 
			{ 
				get 
				{
				   if(IStMass.Value != null) {
				   					double i = 0.0;
					if (IStMass != null)
					{
						if (IStMass.Value != null)
						{
							if (Double.TryParse(IStMass.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { IStMass.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStSuppUnitVal IStSuppUnitVal { get; set; }
		public static IStatRec_IStSuppUnitValFieldDef IStSuppUnitValField { get; private set; }
        
			
			[Column("IStSuppUnitVal")]
			public  double PopulateIStSuppUnitVal  {
				get { return IStSuppUnitValValue ;}
				set { IStSuppUnitVal.DataValue = value; }
			}

	
			public double IStSuppUnitValValue 
			{ 
				get 
				{
				   if(IStSuppUnitVal.Value != null) {
				   					double i = 0.0;
					if (IStSuppUnitVal != null)
					{
						if (IStSuppUnitVal.Value != null)
						{
							if (Double.TryParse(IStSuppUnitVal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { IStSuppUnitVal.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStSuppUnitType IStSuppUnitType { get; set; }
		public static IStatRec_IStSuppUnitTypeFieldDef IStSuppUnitTypeField { get; private set; }
        
			
			[Column("IStSuppUnitType")]
			public  string PopulateIStSuppUnitType  {
				get { return IStSuppUnitTypeValue ;}
				set { IStSuppUnitType.DataValue = value; }
			}

	
			public string IStSuppUnitTypeValue 
			{ 
				get 
				{
				   if(IStSuppUnitType.Value != null) {
				   return IStSuppUnitType.Value.ToString(); 					}
					return "";
                
				}
				set { IStSuppUnitType.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStConsignCtry IStConsignCtry { get; set; }
		public static IStatRec_IStConsignCtryFieldDef IStConsignCtryField { get; private set; }
        
			
			[Column("IStConsignCtry")]
			public  string PopulateIStConsignCtry  {
				get { return IStConsignCtryValue ;}
				set { IStConsignCtry.DataValue = value; }
			}

	
			public string IStConsignCtryValue 
			{ 
				get 
				{
				   if(IStConsignCtry.Value != null) {
				   return IStConsignCtry.Value.ToString(); 					}
					return "";
                
				}
				set { IStConsignCtry.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStTranspMode IStTranspMode { get; set; }
		public static IStatRec_IStTranspModeFieldDef IStTranspModeField { get; private set; }
        
			
			[Column("IStTranspMode")]
			public  int PopulateIStTranspMode  {
				get { return IStTranspModeValue ;}
				set { IStTranspMode.DataValue = value; }
			}

	
			public int IStTranspModeValue 
			{ 
				get 
				{
				   if(IStTranspMode.Value != null) {
				   					int i = 0;
					if (IStTranspMode != null)
					{
						if (IStTranspMode.Value != null)
						{
							if (Int32.TryParse(IStTranspMode.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStTranspMode.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStInvNo IStInvNo { get; set; }
		public static IStatRec_IStInvNoFieldDef IStInvNoField { get; private set; }
        
			
			[Column("IStInvNo")]
			public  string PopulateIStInvNo  {
				get { return IStInvNoValue ;}
				set { IStInvNo.DataValue = value; }
			}

	
			public string IStInvNoValue 
			{ 
				get 
				{
				   if(IStInvNo.Value != null) {
				   return IStInvNo.Value.ToString(); 					}
					return "";
                
				}
				set { IStInvNo.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStOriginCtry IStOriginCtry { get; set; }
		public static IStatRec_IStOriginCtryFieldDef IStOriginCtryField { get; private set; }
        
			
			[Column("IStOriginCtry")]
			public  string PopulateIStOriginCtry  {
				get { return IStOriginCtryValue ;}
				set { IStOriginCtry.DataValue = value; }
			}

	
			public string IStOriginCtryValue 
			{ 
				get 
				{
				   if(IStOriginCtry.Value != null) {
				   return IStOriginCtry.Value.ToString(); 					}
					return "";
                
				}
				set { IStOriginCtry.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStMonth IStMonth { get; set; }
		public static IStatRec_IStMonthFieldDef IStMonthField { get; private set; }
        
			
			[Column("IStMonth")]
			public  int PopulateIStMonth  {
				get { return IStMonthValue ;}
				set { IStMonth.DataValue = value; }
			}

	
			public int IStMonthValue 
			{ 
				get 
				{
				   if(IStMonth.Value != null) {
				   					int i = 0;
					if (IStMonth != null)
					{
						if (IStMonth.Value != null)
						{
							if (Int32.TryParse(IStMonth.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStMonth.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStMonthDec IStMonthDec { get; set; }
		public static IStatRec_IStMonthDecFieldDef IStMonthDecField { get; private set; }
        
			
			[Column("IStMonthDec")]
			public  int PopulateIStMonthDec  {
				get { return IStMonthDecValue ;}
				set { IStMonthDec.DataValue = value; }
			}

	
			public int IStMonthDecValue 
			{ 
				get 
				{
				   if(IStMonthDec.Value != null) {
				   					int i = 0;
					if (IStMonthDec != null)
					{
						if (IStMonthDec.Value != null)
						{
							if (Int32.TryParse(IStMonthDec.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStMonthDec.Value = value;  }
			}
			
		
		[Ignore()]
		public IStatRec_IStRatePeriod IStRatePeriod { get; set; }
		public static IStatRec_IStRatePeriodFieldDef IStRatePeriodField { get; private set; }
        
			
			[Column("IStRatePeriod")]
			public  int PopulateIStRatePeriod  {
				get { return IStRatePeriodValue ;}
				set { IStRatePeriod.DataValue = value; }
			}

	
			public int IStRatePeriodValue 
			{ 
				get 
				{
				   if(IStRatePeriod.Value != null) {
				   					int i = 0;
					if (IStRatePeriod != null)
					{
						if (IStRatePeriod.Value != null)
						{
							if (Int32.TryParse(IStRatePeriod.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { IStRatePeriod.Value = value;  }
			}
	}


public class IStatRec_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 40;
    public int PixelHeight => 0;
	public string Title => "Intrastat Records";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
