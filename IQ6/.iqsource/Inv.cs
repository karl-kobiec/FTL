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


public partial class InvController : DSBaseController<Inv/*,InvSearch*/> {
	public InvController() : base ((IDatabase)IQApp.DB, new InvRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select InvId from Inv where RecordID=@RecId", new { RecId = RecId});

					int count = 0;
						count += IQApp.DB.GetInt("select count(*) from InvLine where InvLInvNo=@Val", new { Val = Key});
						count += IQApp.DB.GetInt("select count(*) from PeriodInv where PInvId=@Val", new { Val = Key});
						if(count > 0) {
				return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
			}
		
		string Msg = "Are you sure you want to delete this record?";
				
				Msg += " This will also delete any existing sub records.";
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Inv>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Inv data) {
											IQApp.DB.Execute("delete from InvLine where InvLInvNo=@Val", new { Val = data.InvIdValue});
								IQApp.DB.Execute("delete from PeriodInv where PInvId=@Val", new { Val = data.InvIdValue});
										IQApp.DB.Execute("Delete from Inv where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.InvIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Inv " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Inv " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Inv " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Inv_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Inv>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Inv>("select * from Inv  ").ToList();
		string urlpath = "/temp/Invoices Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Invoices");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 7])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 17;
					worksheet.Cells[1, 1].Value = "Invoice Number";
						
								
					worksheet.Column(2).Width = 17;
					worksheet.Cells[1, 2].Value = "Freight or Duty";
						
								
					worksheet.Column(3).Width = 17;
					worksheet.Cells[1, 3].Value = "Job No";
						
								
					worksheet.Column(4).Width = 17;
					worksheet.Cells[1, 4].Value = "Order Number";
						
								
					worksheet.Column(5).Width = 17;
					worksheet.Cells[1, 5].Value = "Invoice Date";
						
								
					worksheet.Column(6).Width = 17;
					worksheet.Cells[1, 6].Value = "Import or Export";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].InvId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].InvFreightDuty.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].InvJobNo.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].InvOrder.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].InvDate.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].InvImpExp.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvId" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvId(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvId" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvFreightDuty(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvFreightDutyValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFreightDuty" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFreightDuty")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvFreightDuty(Inv m, int? id, string q) {

		
		string s = m.InvFreightDuty.DataSource;
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
	public ActionResult CallbackInvFreightDuty(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFreightDuty" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFreightDuty")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvJobNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvJobNo(Inv m, int? id, string q) {

		
		string s = m.InvJobNo.DataSource;
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
	public ActionResult CallbackInvJobNo(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvOrder" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvOrder(Inv m, int? id, string q) {

		
		string s = m.InvOrder.DataSource;
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
	public ActionResult CallbackInvOrder(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvOrder" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvVehicle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvVehicleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVehicle")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvVehicle(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVehicle")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvTrailer(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvTrailerValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTrailer" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTrailer")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvTrailer(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTrailer" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTrailer")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvRouteFrom(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvRouteFromValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteFrom" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteFrom")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvRouteFrom(Inv m, int? id, string q) {

		
		string s = m.InvRouteFrom.DataSource;
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
	public ActionResult CallbackInvRouteFrom(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteFrom" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteFrom")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvRouteTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvRouteToValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteTo" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvRouteTo(Inv m, int? id, string q) {

		
		string s = m.InvRouteTo.DataSource;
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
	public ActionResult CallbackInvRouteTo(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteTo" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvRouteTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvFerryName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvFerryNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryName" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvFerryName(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryName" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvFerryDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvFerryDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryDate" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvFerryDate(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryDate" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvFerryTime(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					TimeSpan i = TimeSpan.MinValue;
		
			bool UnableToContinue = false;

			if(!TimeSpan.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvFerryTimeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryTime" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryTime")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvFerryTime(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryTime" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvFerryTime")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvToValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTo" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvTo(Inv m, int? id, string q) {

		
		string s = m.InvTo.DataSource;
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
	public ActionResult CallbackInvTo(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTo" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDesc" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvDesc(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDesc" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvNet(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvNetValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNet" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNet")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvNet(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNet" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNet")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvVAT(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvVATValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVAT" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVAT")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvVAT(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVAT" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvVAT")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvTotal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvTotalValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTotal" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTotal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvTotal(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTotal" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTotal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvNote1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvNote1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote1" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvNote1(Inv m, int? id, string q) {

		
		string s = m.InvNote1.DataSource;
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
	public ActionResult CallbackInvNote1(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote1" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvNote2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvNote2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote2" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvNote2(Inv m, int? id, string q) {

		
		string s = m.InvNote2.DataSource;
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
	public ActionResult CallbackInvNote2(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote2" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvNote3(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvNote3Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote3" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote3")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvNote3(Inv m, int? id, string q) {

		
		string s = m.InvNote3.DataSource;
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
	public ActionResult CallbackInvNote3(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote3" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvNote3")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDate" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvDate(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDate" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvPrintBatch(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvPrintBatchValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPrintBatch" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPrintBatch")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvPrintBatch(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPrintBatch" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPrintBatch")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvJobLetter(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvJobLetterValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobLetter")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvJobLetter(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvJobLetter")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvToExport(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvToExportValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToExport" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToExport")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvToExport(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToExport" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToExport")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvExported(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvExportedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExported" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExported")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvExported(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExported" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExported")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvCustOrd(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvCustOrdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCustOrd")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvCustOrd(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCustOrd")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvToId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvToIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToId" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvToId(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToId" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvToId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvImpExp(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvImpExpValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvImpExp" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvImpExp")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvImpExp(Inv m, int? id, string q) {

		
		string s = m.InvImpExp.DataSource;
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
	public ActionResult CallbackInvImpExp(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvImpExp" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvImpExp")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvAddr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvAddrValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvAddr" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvAddr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvAddr(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvAddr" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvAddr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvTown(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvTownValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTown" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTown")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvTown(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTown" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTown")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvPC(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvPCValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPC" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPC")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvPC(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPC" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvPC")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvCurr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvCurrValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCurr" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCurr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvCurr(Inv m, int? id, string q) {

		
		string s = m.InvCurr.DataSource;
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
	public ActionResult CallbackInvCurr(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCurr" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvCurr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvExchRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvExchRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExchRate" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExchRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvExchRate(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExchRate" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvExchRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvTescoRef(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvTescoRefValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTescoRef" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTescoRef")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvTescoRef(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTescoRef" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvTescoRef")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvBelongsPInv(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvBelongsPInvValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvBelongsPInv" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvBelongsPInv")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvBelongsPInv(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvBelongsPInv" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvBelongsPInv")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvISPInv(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvISPInvValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvISPInv" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvISPInv")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvISPInv(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvISPInv" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvISPInv")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvProforma(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvProformaValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvProforma" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvProforma")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvProforma(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvProforma" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvProforma")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvSentTradeshift(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvSentTradeshiftValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentTradeshift" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentTradeshift")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvSentTradeshift(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentTradeshift" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentTradeshift")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvSentToClient(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvSentToClientValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentToClient" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentToClient")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvSentToClient(Inv obj) {
			
		if(DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentToClient" ).Any()) {
			foreach(var itm in DS.GetManager<Inv>().OnChange.Where(f=> f.Key == "InvSentToClient")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Inv>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=6 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/Inv/Search/" + FirstSearch);
		
		return Redirect("/Inv/List/");
	}

}

public partial class InvRepository : DSRepository<Inv> {
	public InvRepository() : base(6, "Inv", "Invoices") {
	}
}
public partial class Inv 
: DatasetBase<Inv>, IDSBase

  {
	  public int KeyValue => InvIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "InvId":
			return InvIdField;
				case "InvFreightDuty":
			return InvFreightDutyField;
				case "InvJobNo":
			return InvJobNoField;
				case "InvOrder":
			return InvOrderField;
				case "InvVehicle":
			return InvVehicleField;
				case "InvTrailer":
			return InvTrailerField;
				case "InvRouteFrom":
			return InvRouteFromField;
				case "InvRouteTo":
			return InvRouteToField;
				case "InvFerryName":
			return InvFerryNameField;
				case "InvFerryDate":
			return InvFerryDateField;
				case "InvFerryTime":
			return InvFerryTimeField;
				case "InvTo":
			return InvToField;
				case "InvDesc":
			return InvDescField;
				case "InvNet":
			return InvNetField;
				case "InvVAT":
			return InvVATField;
				case "InvTotal":
			return InvTotalField;
				case "InvNote1":
			return InvNote1Field;
				case "InvNote2":
			return InvNote2Field;
				case "InvNote3":
			return InvNote3Field;
				case "InvDate":
			return InvDateField;
				case "InvPrintBatch":
			return InvPrintBatchField;
				case "InvJobLetter":
			return InvJobLetterField;
				case "InvToExport":
			return InvToExportField;
				case "InvExported":
			return InvExportedField;
				case "InvCustOrd":
			return InvCustOrdField;
				case "InvToId":
			return InvToIdField;
				case "InvImpExp":
			return InvImpExpField;
				case "InvAddr":
			return InvAddrField;
				case "InvTown":
			return InvTownField;
				case "InvPC":
			return InvPCField;
				case "InvCurr":
			return InvCurrField;
				case "InvExchRate":
			return InvExchRateField;
				case "InvTescoRef":
			return InvTescoRefField;
				case "InvBelongsPInv":
			return InvBelongsPInvField;
				case "InvISPInv":
			return InvISPInvField;
				case "InvProforma":
			return InvProformaField;
				case "InvSentTradeshift":
			return InvSentTradeshiftField;
				case "InvSentToClient":
			return InvSentToClientField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(InvId,InvIdField);
				action(InvFreightDuty,InvFreightDutyField);
				action(InvJobNo,InvJobNoField);
				action(InvOrder,InvOrderField);
				action(InvVehicle,InvVehicleField);
				action(InvTrailer,InvTrailerField);
				action(InvRouteFrom,InvRouteFromField);
				action(InvRouteTo,InvRouteToField);
				action(InvFerryName,InvFerryNameField);
				action(InvFerryDate,InvFerryDateField);
				action(InvFerryTime,InvFerryTimeField);
				action(InvTo,InvToField);
				action(InvDesc,InvDescField);
				action(InvNet,InvNetField);
				action(InvVAT,InvVATField);
				action(InvTotal,InvTotalField);
				action(InvNote1,InvNote1Field);
				action(InvNote2,InvNote2Field);
				action(InvNote3,InvNote3Field);
				action(InvDate,InvDateField);
				action(InvPrintBatch,InvPrintBatchField);
				action(InvJobLetter,InvJobLetterField);
				action(InvToExport,InvToExportField);
				action(InvExported,InvExportedField);
				action(InvCustOrd,InvCustOrdField);
				action(InvToId,InvToIdField);
				action(InvImpExp,InvImpExpField);
				action(InvAddr,InvAddrField);
				action(InvTown,InvTownField);
				action(InvPC,InvPCField);
				action(InvCurr,InvCurrField);
				action(InvExchRate,InvExchRateField);
				action(InvTescoRef,InvTescoRefField);
				action(InvBelongsPInv,InvBelongsPInvField);
				action(InvISPInv,InvISPInvField);
				action(InvProforma,InvProformaField);
				action(InvSentTradeshift,InvSentTradeshiftField);
				action(InvSentToClient,InvSentToClientField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				InvId.Visible=false;InvFreightDuty.Visible=false;InvJobNo.Visible=false;InvOrder.Visible=false;InvVehicle.Visible=false;InvTrailer.Visible=false;InvRouteFrom.Visible=false;InvRouteTo.Visible=false;InvFerryName.Visible=false;InvFerryDate.Visible=false;InvFerryTime.Visible=false;InvTo.Visible=false;InvDesc.Visible=false;InvNet.Visible=false;InvVAT.Visible=false;InvTotal.Visible=false;InvNote1.Visible=false;InvNote2.Visible=false;InvNote3.Visible=false;InvDate.Visible=false;InvPrintBatch.Visible=false;InvJobLetter.Visible=false;InvToExport.Visible=false;InvExported.Visible=false;InvCustOrd.Visible=false;InvToId.Visible=false;InvImpExp.Visible=false;InvAddr.Visible=false;InvTown.Visible=false;InvPC.Visible=false;InvCurr.Visible=false;InvExchRate.Visible=false;InvTescoRef.Visible=false;InvBelongsPInv.Visible=false;InvISPInv.Visible=false;InvProforma.Visible=false;InvSentTradeshift.Visible=false;InvSentToClient.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Inv set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (InvId.HasChanged && InvId.HasValue) {
					SQL += ", InvId=@InvIdValue";

				}
								if (InvFreightDuty.HasChanged && InvFreightDuty.HasValue) {
					SQL += ", InvFreightDuty=@InvFreightDutyValue";

				}
								if (InvJobNo.HasChanged && InvJobNo.HasValue) {
					SQL += ", InvJobNo=@InvJobNoValue";

				}
								if (InvOrder.HasChanged && InvOrder.HasValue) {
					SQL += ", InvOrder=@InvOrderValue";

				}
								if (InvVehicle.HasChanged && InvVehicle.HasValue) {
					SQL += ", InvVehicle=@InvVehicleValue";

				}
								if (InvTrailer.HasChanged && InvTrailer.HasValue) {
					SQL += ", InvTrailer=@InvTrailerValue";

				}
								if (InvRouteFrom.HasChanged && InvRouteFrom.HasValue) {
					SQL += ", InvRouteFrom=@InvRouteFromValue";

				}
								if (InvRouteTo.HasChanged && InvRouteTo.HasValue) {
					SQL += ", InvRouteTo=@InvRouteToValue";

				}
								if (InvFerryName.HasChanged && InvFerryName.HasValue) {
					SQL += ", InvFerryName=@InvFerryNameValue";

				}
								if (InvFerryDate.HasChanged && InvFerryDate.HasValue) {
					SQL += ", InvFerryDate=@InvFerryDateValue";

				}
								if (InvFerryTime.HasChanged && InvFerryTime.HasValue) {
					SQL += ", InvFerryTime=@InvFerryTimeValue";

				}
								if (InvTo.HasChanged && InvTo.HasValue) {
					SQL += ", InvTo=@InvToValue";

				}
								if (InvDesc.HasChanged && InvDesc.HasValue) {
					SQL += ", InvDesc=@InvDescValue";

				}
								if (InvNet.HasChanged && InvNet.HasValue) {
					SQL += ", InvNet=@InvNetValue";

				}
								if (InvVAT.HasChanged && InvVAT.HasValue) {
					SQL += ", InvVAT=@InvVATValue";

				}
								if (InvTotal.HasChanged && InvTotal.HasValue) {
					SQL += ", InvTotal=@InvTotalValue";

				}
								if (InvNote1.HasChanged && InvNote1.HasValue) {
					SQL += ", InvNote1=@InvNote1Value";

				}
								if (InvNote2.HasChanged && InvNote2.HasValue) {
					SQL += ", InvNote2=@InvNote2Value";

				}
								if (InvNote3.HasChanged && InvNote3.HasValue) {
					SQL += ", InvNote3=@InvNote3Value";

				}
								if (InvDate.HasChanged && InvDate.HasValue) {
					SQL += ", InvDate=@InvDateValue";

				}
								if (InvPrintBatch.HasChanged && InvPrintBatch.HasValue) {
					SQL += ", InvPrintBatch=@InvPrintBatchValue";

				}
								if (InvJobLetter.HasChanged && InvJobLetter.HasValue) {
					SQL += ", InvJobLetter=@InvJobLetterValue";

				}
								if (InvToExport.HasChanged && InvToExport.HasValue) {
					SQL += ", InvToExport=@InvToExportValue";

				}
								if (InvExported.HasChanged && InvExported.HasValue) {
					SQL += ", InvExported=@InvExportedValue";

				}
								if (InvCustOrd.HasChanged && InvCustOrd.HasValue) {
					SQL += ", InvCustOrd=@InvCustOrdValue";

				}
								if (InvToId.HasChanged && InvToId.HasValue) {
					SQL += ", InvToId=@InvToIdValue";

				}
								if (InvImpExp.HasChanged && InvImpExp.HasValue) {
					SQL += ", InvImpExp=@InvImpExpValue";

				}
								if (InvAddr.HasChanged && InvAddr.HasValue) {
					SQL += ", InvAddr=@InvAddrValue";

				}
								if (InvTown.HasChanged && InvTown.HasValue) {
					SQL += ", InvTown=@InvTownValue";

				}
								if (InvPC.HasChanged && InvPC.HasValue) {
					SQL += ", InvPC=@InvPCValue";

				}
								if (InvCurr.HasChanged && InvCurr.HasValue) {
					SQL += ", InvCurr=@InvCurrValue";

				}
								if (InvExchRate.HasChanged && InvExchRate.HasValue) {
					SQL += ", InvExchRate=@InvExchRateValue";

				}
								if (InvTescoRef.HasChanged && InvTescoRef.HasValue) {
					SQL += ", InvTescoRef=@InvTescoRefValue";

				}
								if (InvBelongsPInv.HasChanged && InvBelongsPInv.HasValue) {
					SQL += ", InvBelongsPInv=@InvBelongsPInvValue";

				}
								if (InvISPInv.HasChanged && InvISPInv.HasValue) {
					SQL += ", InvISPInv=@InvISPInvValue";

				}
								if (InvProforma.HasChanged && InvProforma.HasValue) {
					SQL += ", InvProforma=@InvProformaValue";

				}
								if (InvSentTradeshift.HasChanged && InvSentTradeshift.HasValue) {
					SQL += ", InvSentTradeshift=@InvSentTradeshiftValue";

				}
								if (InvSentToClient.HasChanged && InvSentToClient.HasValue) {
					SQL += ", InvSentToClient=@InvSentToClientValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									InvId.HasChanged = false;
									InvFreightDuty.HasChanged = false;
									InvJobNo.HasChanged = false;
									InvOrder.HasChanged = false;
									InvVehicle.HasChanged = false;
									InvTrailer.HasChanged = false;
									InvRouteFrom.HasChanged = false;
									InvRouteTo.HasChanged = false;
									InvFerryName.HasChanged = false;
									InvFerryDate.HasChanged = false;
									InvFerryTime.HasChanged = false;
									InvTo.HasChanged = false;
									InvDesc.HasChanged = false;
									InvNet.HasChanged = false;
									InvVAT.HasChanged = false;
									InvTotal.HasChanged = false;
									InvNote1.HasChanged = false;
									InvNote2.HasChanged = false;
									InvNote3.HasChanged = false;
									InvDate.HasChanged = false;
									InvPrintBatch.HasChanged = false;
									InvJobLetter.HasChanged = false;
									InvToExport.HasChanged = false;
									InvExported.HasChanged = false;
									InvCustOrd.HasChanged = false;
									InvToId.HasChanged = false;
									InvImpExp.HasChanged = false;
									InvAddr.HasChanged = false;
									InvTown.HasChanged = false;
									InvPC.HasChanged = false;
									InvCurr.HasChanged = false;
									InvExchRate.HasChanged = false;
									InvTescoRef.HasChanged = false;
									InvBelongsPInv.HasChanged = false;
									InvISPInv.HasChanged = false;
									InvProforma.HasChanged = false;
									InvSentTradeshift.HasChanged = false;
									InvSentToClient.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Inv(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				InvId.Value = IQApp.DB.GetInt("select isnull(max(InvId),0)+1 from Inv");
				if (InvId.HasValue) {
					SQL += ", InvId";
					Values += ", @InvIdValue";
				}
				
				if (InvFreightDuty.HasValue) {
					SQL += ", InvFreightDuty";
					Values += ", @InvFreightDutyValue";
				}
				
				if (InvJobNo.HasValue) {
					SQL += ", InvJobNo";
					Values += ", @InvJobNoValue";
				}
				
				if (InvOrder.HasValue) {
					SQL += ", InvOrder";
					Values += ", @InvOrderValue";
				}
				
				if (InvVehicle.HasValue) {
					SQL += ", InvVehicle";
					Values += ", @InvVehicleValue";
				}
				
				if (InvTrailer.HasValue) {
					SQL += ", InvTrailer";
					Values += ", @InvTrailerValue";
				}
				
				if (InvRouteFrom.HasValue) {
					SQL += ", InvRouteFrom";
					Values += ", @InvRouteFromValue";
				}
				
				if (InvRouteTo.HasValue) {
					SQL += ", InvRouteTo";
					Values += ", @InvRouteToValue";
				}
				
				if (InvFerryName.HasValue) {
					SQL += ", InvFerryName";
					Values += ", @InvFerryNameValue";
				}
				
				if (InvFerryDate.HasValue) {
					SQL += ", InvFerryDate";
					Values += ", @InvFerryDateValue";
				}
				
				if (InvFerryTime.HasValue) {
					SQL += ", InvFerryTime";
					Values += ", @InvFerryTimeValue";
				}
				
				if (InvTo.HasValue) {
					SQL += ", InvTo";
					Values += ", @InvToValue";
				}
				
				if (InvDesc.HasValue) {
					SQL += ", InvDesc";
					Values += ", @InvDescValue";
				}
				
				if (InvNet.HasValue) {
					SQL += ", InvNet";
					Values += ", @InvNetValue";
				}
				
				if (InvVAT.HasValue) {
					SQL += ", InvVAT";
					Values += ", @InvVATValue";
				}
				
				if (InvTotal.HasValue) {
					SQL += ", InvTotal";
					Values += ", @InvTotalValue";
				}
				
				if (InvNote1.HasValue) {
					SQL += ", InvNote1";
					Values += ", @InvNote1Value";
				}
				
				if (InvNote2.HasValue) {
					SQL += ", InvNote2";
					Values += ", @InvNote2Value";
				}
				
				if (InvNote3.HasValue) {
					SQL += ", InvNote3";
					Values += ", @InvNote3Value";
				}
				
				if (InvDate.HasValue) {
					SQL += ", InvDate";
					Values += ", @InvDateValue";
				}
				
				if (InvPrintBatch.HasValue) {
					SQL += ", InvPrintBatch";
					Values += ", @InvPrintBatchValue";
				}
				
				if (InvJobLetter.HasValue) {
					SQL += ", InvJobLetter";
					Values += ", @InvJobLetterValue";
				}
				
				if (InvToExport.HasValue) {
					SQL += ", InvToExport";
					Values += ", @InvToExportValue";
				}
				
				if (InvExported.HasValue) {
					SQL += ", InvExported";
					Values += ", @InvExportedValue";
				}
				
				if (InvCustOrd.HasValue) {
					SQL += ", InvCustOrd";
					Values += ", @InvCustOrdValue";
				}
				
				if (InvToId.HasValue) {
					SQL += ", InvToId";
					Values += ", @InvToIdValue";
				}
				
				if (InvImpExp.HasValue) {
					SQL += ", InvImpExp";
					Values += ", @InvImpExpValue";
				}
				
				if (InvAddr.HasValue) {
					SQL += ", InvAddr";
					Values += ", @InvAddrValue";
				}
				
				if (InvTown.HasValue) {
					SQL += ", InvTown";
					Values += ", @InvTownValue";
				}
				
				if (InvPC.HasValue) {
					SQL += ", InvPC";
					Values += ", @InvPCValue";
				}
				
				if (InvCurr.HasValue) {
					SQL += ", InvCurr";
					Values += ", @InvCurrValue";
				}
				
				if (InvExchRate.HasValue) {
					SQL += ", InvExchRate";
					Values += ", @InvExchRateValue";
				}
				
				if (InvTescoRef.HasValue) {
					SQL += ", InvTescoRef";
					Values += ", @InvTescoRefValue";
				}
				
				if (InvBelongsPInv.HasValue) {
					SQL += ", InvBelongsPInv";
					Values += ", @InvBelongsPInvValue";
				}
				
				if (InvISPInv.HasValue) {
					SQL += ", InvISPInv";
					Values += ", @InvISPInvValue";
				}
				
				if (InvProforma.HasValue) {
					SQL += ", InvProforma";
					Values += ", @InvProformaValue";
				}
				
				if (InvSentTradeshift.HasValue) {
					SQL += ", InvSentTradeshift";
					Values += ", @InvSentTradeshiftValue";
				}
				
				if (InvSentToClient.HasValue) {
					SQL += ", InvSentToClient";
					Values += ", @InvSentToClientValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Inv");
					 IQApp.DB.Execute(SQL, this);
				                    					InvId.HasChanged = false;
									InvFreightDuty.HasChanged = false;
									InvJobNo.HasChanged = false;
									InvOrder.HasChanged = false;
									InvVehicle.HasChanged = false;
									InvTrailer.HasChanged = false;
									InvRouteFrom.HasChanged = false;
									InvRouteTo.HasChanged = false;
									InvFerryName.HasChanged = false;
									InvFerryDate.HasChanged = false;
									InvFerryTime.HasChanged = false;
									InvTo.HasChanged = false;
									InvDesc.HasChanged = false;
									InvNet.HasChanged = false;
									InvVAT.HasChanged = false;
									InvTotal.HasChanged = false;
									InvNote1.HasChanged = false;
									InvNote2.HasChanged = false;
									InvNote3.HasChanged = false;
									InvDate.HasChanged = false;
									InvPrintBatch.HasChanged = false;
									InvJobLetter.HasChanged = false;
									InvToExport.HasChanged = false;
									InvExported.HasChanged = false;
									InvCustOrd.HasChanged = false;
									InvToId.HasChanged = false;
									InvImpExp.HasChanged = false;
									InvAddr.HasChanged = false;
									InvTown.HasChanged = false;
									InvPC.HasChanged = false;
									InvCurr.HasChanged = false;
									InvExchRate.HasChanged = false;
									InvTescoRef.HasChanged = false;
									InvBelongsPInv.HasChanged = false;
									InvISPInv.HasChanged = false;
									InvProforma.HasChanged = false;
									InvSentTradeshift.HasChanged = false;
									InvSentToClient.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "InvId":
					return (IDSFieldBase)InvId;
								case "InvFreightDuty":
					return (IDSFieldBase)InvFreightDuty;
								case "InvJobNo":
					return (IDSFieldBase)InvJobNo;
								case "InvOrder":
					return (IDSFieldBase)InvOrder;
								case "InvVehicle":
					return (IDSFieldBase)InvVehicle;
								case "InvTrailer":
					return (IDSFieldBase)InvTrailer;
								case "InvRouteFrom":
					return (IDSFieldBase)InvRouteFrom;
								case "InvRouteTo":
					return (IDSFieldBase)InvRouteTo;
								case "InvFerryName":
					return (IDSFieldBase)InvFerryName;
								case "InvFerryDate":
					return (IDSFieldBase)InvFerryDate;
								case "InvFerryTime":
					return (IDSFieldBase)InvFerryTime;
								case "InvTo":
					return (IDSFieldBase)InvTo;
								case "InvDesc":
					return (IDSFieldBase)InvDesc;
								case "InvNet":
					return (IDSFieldBase)InvNet;
								case "InvVAT":
					return (IDSFieldBase)InvVAT;
								case "InvTotal":
					return (IDSFieldBase)InvTotal;
								case "InvNote1":
					return (IDSFieldBase)InvNote1;
								case "InvNote2":
					return (IDSFieldBase)InvNote2;
								case "InvNote3":
					return (IDSFieldBase)InvNote3;
								case "InvDate":
					return (IDSFieldBase)InvDate;
								case "InvPrintBatch":
					return (IDSFieldBase)InvPrintBatch;
								case "InvJobLetter":
					return (IDSFieldBase)InvJobLetter;
								case "InvToExport":
					return (IDSFieldBase)InvToExport;
								case "InvExported":
					return (IDSFieldBase)InvExported;
								case "InvCustOrd":
					return (IDSFieldBase)InvCustOrd;
								case "InvToId":
					return (IDSFieldBase)InvToId;
								case "InvImpExp":
					return (IDSFieldBase)InvImpExp;
								case "InvAddr":
					return (IDSFieldBase)InvAddr;
								case "InvTown":
					return (IDSFieldBase)InvTown;
								case "InvPC":
					return (IDSFieldBase)InvPC;
								case "InvCurr":
					return (IDSFieldBase)InvCurr;
								case "InvExchRate":
					return (IDSFieldBase)InvExchRate;
								case "InvTescoRef":
					return (IDSFieldBase)InvTescoRef;
								case "InvBelongsPInv":
					return (IDSFieldBase)InvBelongsPInv;
								case "InvISPInv":
					return (IDSFieldBase)InvISPInv;
								case "InvProforma":
					return (IDSFieldBase)InvProforma;
								case "InvSentTradeshift":
					return (IDSFieldBase)InvSentTradeshift;
								case "InvSentToClient":
					return (IDSFieldBase)InvSentToClient;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "InvId":
					return InvId.DisplayValue;
								case "InvFreightDuty":
					return InvFreightDuty.DisplayValue;
								case "InvJobNo":
					return InvJobNo.DisplayValue;
								case "InvOrder":
					return InvOrder.DisplayValue;
								case "InvVehicle":
					return InvVehicle.DisplayValue;
								case "InvTrailer":
					return InvTrailer.DisplayValue;
								case "InvRouteFrom":
					return InvRouteFrom.DisplayValue;
								case "InvRouteTo":
					return InvRouteTo.DisplayValue;
								case "InvFerryName":
					return InvFerryName.DisplayValue;
								case "InvFerryDate":
					return InvFerryDate.DisplayValue;
								case "InvFerryTime":
					return InvFerryTime.DisplayValue;
								case "InvTo":
					return InvTo.DisplayValue;
								case "InvDesc":
					return InvDesc.DisplayValue;
								case "InvNet":
					return InvNet.DisplayValue;
								case "InvVAT":
					return InvVAT.DisplayValue;
								case "InvTotal":
					return InvTotal.DisplayValue;
								case "InvNote1":
					return InvNote1.DisplayValue;
								case "InvNote2":
					return InvNote2.DisplayValue;
								case "InvNote3":
					return InvNote3.DisplayValue;
								case "InvDate":
					return InvDate.DisplayValue;
								case "InvPrintBatch":
					return InvPrintBatch.DisplayValue;
								case "InvJobLetter":
					return InvJobLetter.DisplayValue;
								case "InvToExport":
					return InvToExport.DisplayValue;
								case "InvExported":
					return InvExported.DisplayValue;
								case "InvCustOrd":
					return InvCustOrd.DisplayValue;
								case "InvToId":
					return InvToId.DisplayValue;
								case "InvImpExp":
					return InvImpExp.DisplayValue;
								case "InvAddr":
					return InvAddr.DisplayValue;
								case "InvTown":
					return InvTown.DisplayValue;
								case "InvPC":
					return InvPC.DisplayValue;
								case "InvCurr":
					return InvCurr.DisplayValue;
								case "InvExchRate":
					return InvExchRate.DisplayValue;
								case "InvTescoRef":
					return InvTescoRef.DisplayValue;
								case "InvBelongsPInv":
					return InvBelongsPInv.DisplayValue;
								case "InvISPInv":
					return InvISPInv.DisplayValue;
								case "InvProforma":
					return InvProforma.DisplayValue;
								case "InvSentTradeshift":
					return InvSentTradeshift.DisplayValue;
								case "InvSentToClient":
					return InvSentToClient.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "InvId":
					return InvId.Value.ToString();
								case "InvFreightDuty":
					return InvFreightDuty.Value.ToString();
								case "InvJobNo":
					return InvJobNo.Value.ToString();
								case "InvOrder":
					return InvOrder.Value.ToString();
								case "InvVehicle":
					return InvVehicle.Value.ToString();
								case "InvTrailer":
					return InvTrailer.Value.ToString();
								case "InvRouteFrom":
					return InvRouteFrom.Value.ToString();
								case "InvRouteTo":
					return InvRouteTo.Value.ToString();
								case "InvFerryName":
					return InvFerryName.Value.ToString();
								case "InvFerryDate":
					return InvFerryDate.Value.ToString();
								case "InvFerryTime":
					return InvFerryTime.Value.ToString();
								case "InvTo":
					return InvTo.Value.ToString();
								case "InvDesc":
					return InvDesc.Value.ToString();
								case "InvNet":
					return InvNet.Value.ToString();
								case "InvVAT":
					return InvVAT.Value.ToString();
								case "InvTotal":
					return InvTotal.Value.ToString();
								case "InvNote1":
					return InvNote1.Value.ToString();
								case "InvNote2":
					return InvNote2.Value.ToString();
								case "InvNote3":
					return InvNote3.Value.ToString();
								case "InvDate":
					return InvDate.Value.ToString();
								case "InvPrintBatch":
					return InvPrintBatch.Value.ToString();
								case "InvJobLetter":
					return InvJobLetter.Value.ToString();
								case "InvToExport":
					return InvToExport.Value.ToString();
								case "InvExported":
					return InvExported.Value.ToString();
								case "InvCustOrd":
					return InvCustOrd.Value.ToString();
								case "InvToId":
					return InvToId.Value.ToString();
								case "InvImpExp":
					return InvImpExp.Value.ToString();
								case "InvAddr":
					return InvAddr.Value.ToString();
								case "InvTown":
					return InvTown.Value.ToString();
								case "InvPC":
					return InvPC.Value.ToString();
								case "InvCurr":
					return InvCurr.Value.ToString();
								case "InvExchRate":
					return InvExchRate.Value.ToString();
								case "InvTescoRef":
					return InvTescoRef.Value.ToString();
								case "InvBelongsPInv":
					return InvBelongsPInv.Value.ToString();
								case "InvISPInv":
					return InvISPInv.Value.ToString();
								case "InvProforma":
					return InvProforma.Value.ToString();
								case "InvSentTradeshift":
					return InvSentTradeshift.Value.ToString();
								case "InvSentToClient":
					return InvSentToClient.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								scrns.Add(new InvLine_ListScreen());
								scrns.Add(new PeriodInv_ListScreen());
								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<Inv>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		        private List<InvLine> _ChildInvLine;
        public List<InvLine> InvLines
        {
            get
            {
                if (_ChildInvLine == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildInvLine = IQApp.DB.Load<InvLine>("select * from InvLine where InvLInvNo=@itm",new { itm= this.InvId.Value}).ToList();
				
                }
                return _ChildInvLine;
            }set {}
        }
        public int InvLineCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from InvLine where InvLInvNo=@itm", new { itm= this.InvId.Value}));
            }
			set {}
        }
     
	        private List<PeriodInv> _ChildPeriodInv;
        public List<PeriodInv> PeriodInvs
        {
            get
            {
                if (_ChildPeriodInv == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildPeriodInv = IQApp.DB.Load<PeriodInv>("select * from PeriodInv where PInvId=@itm",new { itm= this.InvId.Value}).ToList();
				
                }
                return _ChildPeriodInv;
            }set {}
        }
        public int PeriodInvCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from PeriodInv where PInvId=@itm", new { itm= this.InvId.Value}));
            }
			set {}
        }
     
	
	public Inv () : base("Inv") {
		base.obj = this;
	
					InvId = new Inv_InvId(this);
					InvFreightDuty = new Inv_InvFreightDuty(this);
					InvJobNo = new Inv_InvJobNo(this);
					InvOrder = new Inv_InvOrder(this);
					InvVehicle = new Inv_InvVehicle(this);
					InvTrailer = new Inv_InvTrailer(this);
					InvRouteFrom = new Inv_InvRouteFrom(this);
					InvRouteTo = new Inv_InvRouteTo(this);
					InvFerryName = new Inv_InvFerryName(this);
					InvFerryDate = new Inv_InvFerryDate(this);
					InvFerryTime = new Inv_InvFerryTime(this);
					InvTo = new Inv_InvTo(this);
					InvDesc = new Inv_InvDesc(this);
					InvNet = new Inv_InvNet(this);
					InvVAT = new Inv_InvVAT(this);
					InvTotal = new Inv_InvTotal(this);
					InvNote1 = new Inv_InvNote1(this);
					InvNote2 = new Inv_InvNote2(this);
					InvNote3 = new Inv_InvNote3(this);
					InvDate = new Inv_InvDate(this);
					InvPrintBatch = new Inv_InvPrintBatch(this);
					InvJobLetter = new Inv_InvJobLetter(this);
					InvToExport = new Inv_InvToExport(this);
					InvExported = new Inv_InvExported(this);
					InvCustOrd = new Inv_InvCustOrd(this);
					InvToId = new Inv_InvToId(this);
					InvImpExp = new Inv_InvImpExp(this);
					InvAddr = new Inv_InvAddr(this);
					InvTown = new Inv_InvTown(this);
					InvPC = new Inv_InvPC(this);
					InvCurr = new Inv_InvCurr(this);
					InvExchRate = new Inv_InvExchRate(this);
					InvTescoRef = new Inv_InvTescoRef(this);
					InvBelongsPInv = new Inv_InvBelongsPInv(this);
					InvISPInv = new Inv_InvISPInv(this);
					InvProforma = new Inv_InvProforma(this);
					InvSentTradeshift = new Inv_InvSentTradeshift(this);
					InvSentToClient = new Inv_InvSentToClient(this);
			}

	static Inv () {
					InvIdField = new Inv_InvIdFieldDef();
					InvFreightDutyField = new Inv_InvFreightDutyFieldDef();
					InvJobNoField = new Inv_InvJobNoFieldDef();
					InvOrderField = new Inv_InvOrderFieldDef();
					InvVehicleField = new Inv_InvVehicleFieldDef();
					InvTrailerField = new Inv_InvTrailerFieldDef();
					InvRouteFromField = new Inv_InvRouteFromFieldDef();
					InvRouteToField = new Inv_InvRouteToFieldDef();
					InvFerryNameField = new Inv_InvFerryNameFieldDef();
					InvFerryDateField = new Inv_InvFerryDateFieldDef();
					InvFerryTimeField = new Inv_InvFerryTimeFieldDef();
					InvToField = new Inv_InvToFieldDef();
					InvDescField = new Inv_InvDescFieldDef();
					InvNetField = new Inv_InvNetFieldDef();
					InvVATField = new Inv_InvVATFieldDef();
					InvTotalField = new Inv_InvTotalFieldDef();
					InvNote1Field = new Inv_InvNote1FieldDef();
					InvNote2Field = new Inv_InvNote2FieldDef();
					InvNote3Field = new Inv_InvNote3FieldDef();
					InvDateField = new Inv_InvDateFieldDef();
					InvPrintBatchField = new Inv_InvPrintBatchFieldDef();
					InvJobLetterField = new Inv_InvJobLetterFieldDef();
					InvToExportField = new Inv_InvToExportFieldDef();
					InvExportedField = new Inv_InvExportedFieldDef();
					InvCustOrdField = new Inv_InvCustOrdFieldDef();
					InvToIdField = new Inv_InvToIdFieldDef();
					InvImpExpField = new Inv_InvImpExpFieldDef();
					InvAddrField = new Inv_InvAddrFieldDef();
					InvTownField = new Inv_InvTownFieldDef();
					InvPCField = new Inv_InvPCFieldDef();
					InvCurrField = new Inv_InvCurrFieldDef();
					InvExchRateField = new Inv_InvExchRateFieldDef();
					InvTescoRefField = new Inv_InvTescoRefFieldDef();
					InvBelongsPInvField = new Inv_InvBelongsPInvFieldDef();
					InvISPInvField = new Inv_InvISPInvFieldDef();
					InvProformaField = new Inv_InvProformaFieldDef();
					InvSentTradeshiftField = new Inv_InvSentTradeshiftFieldDef();
					InvSentToClientField = new Inv_InvSentToClientFieldDef();
			}

	public string RecordTitle { 
		get { return InvIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Invoices"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Inv/Load/?RecId=" + RecordID.Value;
			}
			return "/Inv/Add";
			}
	}

			
		
		[Ignore()]
		public Inv_InvId InvId { get; set; }
		public static Inv_InvIdFieldDef InvIdField { get; private set; }
        
			
			[Column("InvId")]
			public  int PopulateInvId  {
				get { return InvIdValue ;}
				set { InvId.DataValue = value; }
			}

	
			public int InvIdValue 
			{ 
				get 
				{
				   if(InvId.Value != null) {
				   					int i = 0;
					if (InvId != null)
					{
						if (InvId.Value != null)
						{
							if (Int32.TryParse(InvId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvId.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvFreightDuty InvFreightDuty { get; set; }
		public static Inv_InvFreightDutyFieldDef InvFreightDutyField { get; private set; }
        
			
			[Column("InvFreightDuty")]
			public  string PopulateInvFreightDuty  {
				get { return InvFreightDutyValue ;}
				set { InvFreightDuty.DataValue = value; }
			}

	
			public string InvFreightDutyValue 
			{ 
				get 
				{
				   if(InvFreightDuty.Value != null) {
				   return InvFreightDuty.Value.ToString(); 					}
					return "";
                
				}
				set { InvFreightDuty.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvJobNo InvJobNo { get; set; }
		public static Inv_InvJobNoFieldDef InvJobNoField { get; private set; }
        
			
			[Column("InvJobNo")]
			public  int PopulateInvJobNo  {
				get { return InvJobNoValue ;}
				set { InvJobNo.DataValue = value; }
			}

	
			public int InvJobNoValue 
			{ 
				get 
				{
				   if(InvJobNo.Value != null) {
				   					int i = 0;
					if (InvJobNo != null)
					{
						if (InvJobNo.Value != null)
						{
							if (Int32.TryParse(InvJobNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvOrder InvOrder { get; set; }
		public static Inv_InvOrderFieldDef InvOrderField { get; private set; }
        
			
			[Column("InvOrder")]
			public  int PopulateInvOrder  {
				get { return InvOrderValue ;}
				set { InvOrder.DataValue = value; }
			}

	
			public int InvOrderValue 
			{ 
				get 
				{
				   if(InvOrder.Value != null) {
				   					int i = 0;
					if (InvOrder != null)
					{
						if (InvOrder.Value != null)
						{
							if (Int32.TryParse(InvOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvVehicle InvVehicle { get; set; }
		public static Inv_InvVehicleFieldDef InvVehicleField { get; private set; }
        
			
			[Column("InvVehicle")]
			public  string PopulateInvVehicle  {
				get { return InvVehicleValue ;}
				set { InvVehicle.DataValue = value; }
			}

	
			public string InvVehicleValue 
			{ 
				get 
				{
				   if(InvVehicle.Value != null) {
				   return InvVehicle.Value.ToString(); 					}
					return "";
                
				}
				set { InvVehicle.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvTrailer InvTrailer { get; set; }
		public static Inv_InvTrailerFieldDef InvTrailerField { get; private set; }
        
			
			[Column("InvTrailer")]
			public  string PopulateInvTrailer  {
				get { return InvTrailerValue ;}
				set { InvTrailer.DataValue = value; }
			}

	
			public string InvTrailerValue 
			{ 
				get 
				{
				   if(InvTrailer.Value != null) {
				   return InvTrailer.Value.ToString(); 					}
					return "";
                
				}
				set { InvTrailer.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvRouteFrom InvRouteFrom { get; set; }
		public static Inv_InvRouteFromFieldDef InvRouteFromField { get; private set; }
        
			
			[Column("InvRouteFrom")]
			public  int PopulateInvRouteFrom  {
				get { return InvRouteFromValue ;}
				set { InvRouteFrom.DataValue = value; }
			}

	
			public int InvRouteFromValue 
			{ 
				get 
				{
				   if(InvRouteFrom.Value != null) {
				   					int i = 0;
					if (InvRouteFrom != null)
					{
						if (InvRouteFrom.Value != null)
						{
							if (Int32.TryParse(InvRouteFrom.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvRouteFrom.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvRouteTo InvRouteTo { get; set; }
		public static Inv_InvRouteToFieldDef InvRouteToField { get; private set; }
        
			
			[Column("InvRouteTo")]
			public  int PopulateInvRouteTo  {
				get { return InvRouteToValue ;}
				set { InvRouteTo.DataValue = value; }
			}

	
			public int InvRouteToValue 
			{ 
				get 
				{
				   if(InvRouteTo.Value != null) {
				   					int i = 0;
					if (InvRouteTo != null)
					{
						if (InvRouteTo.Value != null)
						{
							if (Int32.TryParse(InvRouteTo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvRouteTo.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvFerryName InvFerryName { get; set; }
		public static Inv_InvFerryNameFieldDef InvFerryNameField { get; private set; }
        
			
			[Column("InvFerryName")]
			public  string PopulateInvFerryName  {
				get { return InvFerryNameValue ;}
				set { InvFerryName.DataValue = value; }
			}

	
			public string InvFerryNameValue 
			{ 
				get 
				{
				   if(InvFerryName.Value != null) {
				   return InvFerryName.Value.ToString(); 					}
					return "";
                
				}
				set { InvFerryName.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvFerryDate InvFerryDate { get; set; }
		public static Inv_InvFerryDateFieldDef InvFerryDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("InvFerryDate")]
			public  DateTime PopulateInvFerryDate  {
				get { return InvFerryDateValue ;}
				set { InvFerryDate.DataValue = value; }
			}

	
			public DateTime InvFerryDateValue 
			{ 
				get 
				{
				   if(InvFerryDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (InvFerryDate != null)
					{
						if (InvFerryDate.Value != null)
						{
							if (DateTime.TryParse(InvFerryDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { InvFerryDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvFerryTime InvFerryTime { get; set; }
		public static Inv_InvFerryTimeFieldDef InvFerryTimeField { get; private set; }
        
			
			[Column("InvFerryTime")]
			public  TimeSpan PopulateInvFerryTime  {
				get { return InvFerryTimeValue ;}
				set { InvFerryTime.DataValue = value; }
			}

	
			public TimeSpan InvFerryTimeValue 
			{ 
				get 
				{
				   if(InvFerryTime.Value != null) {
				   					TimeSpan i = TimeSpan.MinValue;
					if (InvFerryTime != null)
					{
						if (InvFerryTime.Value != null)
						{
							if (TimeSpan.TryParse(InvFerryTime.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return TimeSpan.MinValue;
                
				}
				set { InvFerryTime.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvTo InvTo { get; set; }
		public static Inv_InvToFieldDef InvToField { get; private set; }
        
			
			[Column("InvTo")]
			public  int PopulateInvTo  {
				get { return InvToValue ;}
				set { InvTo.DataValue = value; }
			}

	
			public int InvToValue 
			{ 
				get 
				{
				   if(InvTo.Value != null) {
				   					int i = 0;
					if (InvTo != null)
					{
						if (InvTo.Value != null)
						{
							if (Int32.TryParse(InvTo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvTo.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvDesc InvDesc { get; set; }
		public static Inv_InvDescFieldDef InvDescField { get; private set; }
        
			
			[Column("InvDesc")]
			public  string PopulateInvDesc  {
				get { return InvDescValue ;}
				set { InvDesc.DataValue = value; }
			}

	
			public string InvDescValue 
			{ 
				get 
				{
				   if(InvDesc.Value != null) {
				   return InvDesc.Value.ToString(); 					}
					return "";
                
				}
				set { InvDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvNet InvNet { get; set; }
		public static Inv_InvNetFieldDef InvNetField { get; private set; }
        
			
			[Column("InvNet")]
			public  double PopulateInvNet  {
				get { return InvNetValue ;}
				set { InvNet.DataValue = value; }
			}

	
			public double InvNetValue 
			{ 
				get 
				{
				   if(InvNet.Value != null) {
				   					double i = 0.0;
					if (InvNet != null)
					{
						if (InvNet.Value != null)
						{
							if (Double.TryParse(InvNet.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvNet.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvVAT InvVAT { get; set; }
		public static Inv_InvVATFieldDef InvVATField { get; private set; }
        
			
			[Column("InvVAT")]
			public  double PopulateInvVAT  {
				get { return InvVATValue ;}
				set { InvVAT.DataValue = value; }
			}

	
			public double InvVATValue 
			{ 
				get 
				{
				   if(InvVAT.Value != null) {
				   					double i = 0.0;
					if (InvVAT != null)
					{
						if (InvVAT.Value != null)
						{
							if (Double.TryParse(InvVAT.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvVAT.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvTotal InvTotal { get; set; }
		public static Inv_InvTotalFieldDef InvTotalField { get; private set; }
        
			
			[Column("InvTotal")]
			public  double PopulateInvTotal  {
				get { return InvTotalValue ;}
				set { InvTotal.DataValue = value; }
			}

	
			public double InvTotalValue 
			{ 
				get 
				{
				   if(InvTotal.Value != null) {
				   					double i = 0.0;
					if (InvTotal != null)
					{
						if (InvTotal.Value != null)
						{
							if (Double.TryParse(InvTotal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvTotal.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvNote1 InvNote1 { get; set; }
		public static Inv_InvNote1FieldDef InvNote1Field { get; private set; }
        
			
			[Column("InvNote1")]
			public  int PopulateInvNote1  {
				get { return InvNote1Value ;}
				set { InvNote1.DataValue = value; }
			}

	
			public int InvNote1Value 
			{ 
				get 
				{
				   if(InvNote1.Value != null) {
				   					int i = 0;
					if (InvNote1 != null)
					{
						if (InvNote1.Value != null)
						{
							if (Int32.TryParse(InvNote1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvNote1.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvNote2 InvNote2 { get; set; }
		public static Inv_InvNote2FieldDef InvNote2Field { get; private set; }
        
			
			[Column("InvNote2")]
			public  int PopulateInvNote2  {
				get { return InvNote2Value ;}
				set { InvNote2.DataValue = value; }
			}

	
			public int InvNote2Value 
			{ 
				get 
				{
				   if(InvNote2.Value != null) {
				   					int i = 0;
					if (InvNote2 != null)
					{
						if (InvNote2.Value != null)
						{
							if (Int32.TryParse(InvNote2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvNote2.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvNote3 InvNote3 { get; set; }
		public static Inv_InvNote3FieldDef InvNote3Field { get; private set; }
        
			
			[Column("InvNote3")]
			public  int PopulateInvNote3  {
				get { return InvNote3Value ;}
				set { InvNote3.DataValue = value; }
			}

	
			public int InvNote3Value 
			{ 
				get 
				{
				   if(InvNote3.Value != null) {
				   					int i = 0;
					if (InvNote3 != null)
					{
						if (InvNote3.Value != null)
						{
							if (Int32.TryParse(InvNote3.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvNote3.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvDate InvDate { get; set; }
		public static Inv_InvDateFieldDef InvDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("InvDate")]
			public  DateTime PopulateInvDate  {
				get { return InvDateValue ;}
				set { InvDate.DataValue = value; }
			}

	
			public DateTime InvDateValue 
			{ 
				get 
				{
				   if(InvDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (InvDate != null)
					{
						if (InvDate.Value != null)
						{
							if (DateTime.TryParse(InvDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { InvDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvPrintBatch InvPrintBatch { get; set; }
		public static Inv_InvPrintBatchFieldDef InvPrintBatchField { get; private set; }
        
			
			[Column("InvPrintBatch")]
			public  int PopulateInvPrintBatch  {
				get { return InvPrintBatchValue ;}
				set { InvPrintBatch.DataValue = value; }
			}

	
			public int InvPrintBatchValue 
			{ 
				get 
				{
				   if(InvPrintBatch.Value != null) {
				   					int i = 0;
					if (InvPrintBatch != null)
					{
						if (InvPrintBatch.Value != null)
						{
							if (Int32.TryParse(InvPrintBatch.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvPrintBatch.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvJobLetter InvJobLetter { get; set; }
		public static Inv_InvJobLetterFieldDef InvJobLetterField { get; private set; }
        
			
			[Column("InvJobLetter")]
			public  string PopulateInvJobLetter  {
				get { return InvJobLetterValue ;}
				set { InvJobLetter.DataValue = value; }
			}

	
			public string InvJobLetterValue 
			{ 
				get 
				{
				   if(InvJobLetter.Value != null) {
				   return InvJobLetter.Value.ToString(); 					}
					return "";
                
				}
				set { InvJobLetter.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvToExport InvToExport { get; set; }
		public static Inv_InvToExportFieldDef InvToExportField { get; private set; }
        
			
			[Column("InvToExport")]
			public  bool PopulateInvToExport  {
				get { return InvToExportValue ;}
				set { InvToExport.DataValue = value; }
			}

	
			public bool InvToExportValue 
			{ 
				get 
				{
				   if(InvToExport.Value != null) {
				   					bool i = false;
					if (InvToExport != null)
					{
						if (InvToExport.Value != null)
						{
							if (Boolean.TryParse(InvToExport.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvToExport.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvExported InvExported { get; set; }
		public static Inv_InvExportedFieldDef InvExportedField { get; private set; }
        
			
			[Column("InvExported")]
			public  bool PopulateInvExported  {
				get { return InvExportedValue ;}
				set { InvExported.DataValue = value; }
			}

	
			public bool InvExportedValue 
			{ 
				get 
				{
				   if(InvExported.Value != null) {
				   					bool i = false;
					if (InvExported != null)
					{
						if (InvExported.Value != null)
						{
							if (Boolean.TryParse(InvExported.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvExported.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvCustOrd InvCustOrd { get; set; }
		public static Inv_InvCustOrdFieldDef InvCustOrdField { get; private set; }
        
			
			[Column("InvCustOrd")]
			public  string PopulateInvCustOrd  {
				get { return InvCustOrdValue ;}
				set { InvCustOrd.DataValue = value; }
			}

	
			public string InvCustOrdValue 
			{ 
				get 
				{
				   if(InvCustOrd.Value != null) {
				   return InvCustOrd.Value.ToString(); 					}
					return "";
                
				}
				set { InvCustOrd.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvToId InvToId { get; set; }
		public static Inv_InvToIdFieldDef InvToIdField { get; private set; }
        
			
			[Column("InvToId")]
			public  int PopulateInvToId  {
				get { return InvToIdValue ;}
				set { InvToId.DataValue = value; }
			}

	
			public int InvToIdValue 
			{ 
				get 
				{
				   if(InvToId.Value != null) {
				   					int i = 0;
					if (InvToId != null)
					{
						if (InvToId.Value != null)
						{
							if (Int32.TryParse(InvToId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvToId.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvImpExp InvImpExp { get; set; }
		public static Inv_InvImpExpFieldDef InvImpExpField { get; private set; }
        
			
			[Column("InvImpExp")]
			public  string PopulateInvImpExp  {
				get { return InvImpExpValue ;}
				set { InvImpExp.DataValue = value; }
			}

	
			public string InvImpExpValue 
			{ 
				get 
				{
				   if(InvImpExp.Value != null) {
				   return InvImpExp.Value.ToString(); 					}
					return "";
                
				}
				set { InvImpExp.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvAddr InvAddr { get; set; }
		public static Inv_InvAddrFieldDef InvAddrField { get; private set; }
        
			
			[Column("InvAddr")]
			public  string PopulateInvAddr  {
				get { return InvAddrValue ;}
				set { InvAddr.DataValue = value; }
			}

	
			public string InvAddrValue 
			{ 
				get 
				{
				   if(InvAddr.Value != null) {
				   return InvAddr.Value.ToString(); 					}
					return "";
                
				}
				set { InvAddr.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvTown InvTown { get; set; }
		public static Inv_InvTownFieldDef InvTownField { get; private set; }
        
			
			[Column("InvTown")]
			public  string PopulateInvTown  {
				get { return InvTownValue ;}
				set { InvTown.DataValue = value; }
			}

	
			public string InvTownValue 
			{ 
				get 
				{
				   if(InvTown.Value != null) {
				   return InvTown.Value.ToString(); 					}
					return "";
                
				}
				set { InvTown.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvPC InvPC { get; set; }
		public static Inv_InvPCFieldDef InvPCField { get; private set; }
        
			
			[Column("InvPC")]
			public  string PopulateInvPC  {
				get { return InvPCValue ;}
				set { InvPC.DataValue = value; }
			}

	
			public string InvPCValue 
			{ 
				get 
				{
				   if(InvPC.Value != null) {
				   return InvPC.Value.ToString(); 					}
					return "";
                
				}
				set { InvPC.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvCurr InvCurr { get; set; }
		public static Inv_InvCurrFieldDef InvCurrField { get; private set; }
        
			
			[Column("InvCurr")]
			public  int PopulateInvCurr  {
				get { return InvCurrValue ;}
				set { InvCurr.DataValue = value; }
			}

	
			public int InvCurrValue 
			{ 
				get 
				{
				   if(InvCurr.Value != null) {
				   					int i = 0;
					if (InvCurr != null)
					{
						if (InvCurr.Value != null)
						{
							if (Int32.TryParse(InvCurr.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvCurr.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvExchRate InvExchRate { get; set; }
		public static Inv_InvExchRateFieldDef InvExchRateField { get; private set; }
        
			
			[Column("InvExchRate")]
			public  double PopulateInvExchRate  {
				get { return InvExchRateValue ;}
				set { InvExchRate.DataValue = value; }
			}

	
			public double InvExchRateValue 
			{ 
				get 
				{
				   if(InvExchRate.Value != null) {
				   					double i = 0.0;
					if (InvExchRate != null)
					{
						if (InvExchRate.Value != null)
						{
							if (Double.TryParse(InvExchRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvExchRate.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvTescoRef InvTescoRef { get; set; }
		public static Inv_InvTescoRefFieldDef InvTescoRefField { get; private set; }
        
			
			[Column("InvTescoRef")]
			public  string PopulateInvTescoRef  {
				get { return InvTescoRefValue ;}
				set { InvTescoRef.DataValue = value; }
			}

	
			public string InvTescoRefValue 
			{ 
				get 
				{
				   if(InvTescoRef.Value != null) {
				   return InvTescoRef.Value.ToString(); 					}
					return "";
                
				}
				set { InvTescoRef.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvBelongsPInv InvBelongsPInv { get; set; }
		public static Inv_InvBelongsPInvFieldDef InvBelongsPInvField { get; private set; }
        
			
			[Column("InvBelongsPInv")]
			public  int PopulateInvBelongsPInv  {
				get { return InvBelongsPInvValue ;}
				set { InvBelongsPInv.DataValue = value; }
			}

	
			public int InvBelongsPInvValue 
			{ 
				get 
				{
				   if(InvBelongsPInv.Value != null) {
				   					int i = 0;
					if (InvBelongsPInv != null)
					{
						if (InvBelongsPInv.Value != null)
						{
							if (Int32.TryParse(InvBelongsPInv.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvBelongsPInv.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvISPInv InvISPInv { get; set; }
		public static Inv_InvISPInvFieldDef InvISPInvField { get; private set; }
        
			
			[Column("InvISPInv")]
			public  bool PopulateInvISPInv  {
				get { return InvISPInvValue ;}
				set { InvISPInv.DataValue = value; }
			}

	
			public bool InvISPInvValue 
			{ 
				get 
				{
				   if(InvISPInv.Value != null) {
				   					bool i = false;
					if (InvISPInv != null)
					{
						if (InvISPInv.Value != null)
						{
							if (Boolean.TryParse(InvISPInv.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvISPInv.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvProforma InvProforma { get; set; }
		public static Inv_InvProformaFieldDef InvProformaField { get; private set; }
        
			
			[Column("InvProforma")]
			public  bool PopulateInvProforma  {
				get { return InvProformaValue ;}
				set { InvProforma.DataValue = value; }
			}

	
			public bool InvProformaValue 
			{ 
				get 
				{
				   if(InvProforma.Value != null) {
				   					bool i = false;
					if (InvProforma != null)
					{
						if (InvProforma.Value != null)
						{
							if (Boolean.TryParse(InvProforma.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvProforma.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvSentTradeshift InvSentTradeshift { get; set; }
		public static Inv_InvSentTradeshiftFieldDef InvSentTradeshiftField { get; private set; }
        
			
			[Column("InvSentTradeshift")]
			public  bool PopulateInvSentTradeshift  {
				get { return InvSentTradeshiftValue ;}
				set { InvSentTradeshift.DataValue = value; }
			}

	
			public bool InvSentTradeshiftValue 
			{ 
				get 
				{
				   if(InvSentTradeshift.Value != null) {
				   					bool i = false;
					if (InvSentTradeshift != null)
					{
						if (InvSentTradeshift.Value != null)
						{
							if (Boolean.TryParse(InvSentTradeshift.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvSentTradeshift.Value = value;  }
			}
			
		
		[Ignore()]
		public Inv_InvSentToClient InvSentToClient { get; set; }
		public static Inv_InvSentToClientFieldDef InvSentToClientField { get; private set; }
        
			
			[Column("InvSentToClient")]
			public  bool PopulateInvSentToClient  {
				get { return InvSentToClientValue ;}
				set { InvSentToClient.DataValue = value; }
			}

	
			public bool InvSentToClientValue 
			{ 
				get 
				{
				   if(InvSentToClient.Value != null) {
				   					bool i = false;
					if (InvSentToClient != null)
					{
						if (InvSentToClient.Value != null)
						{
							if (Boolean.TryParse(InvSentToClient.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { InvSentToClient.Value = value;  }
			}
	}


public class Inv_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 6;
    public int PixelHeight => 0;
	public string Title => "Invoices";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
