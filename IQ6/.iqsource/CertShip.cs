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


public partial class CertShipController : DSBaseController<CertShip/*,CertShipSearch*/> {
	public CertShipController() : base ((IDatabase)IQApp.DB, new CertShipRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select CSId from CertShip where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<CertShip>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(CertShip data) {
						IQApp.DB.Execute("Delete from CertShip where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.CSIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from CertShip " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from CertShip " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from CertShip " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/CertShip_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<CertShip>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<CertShip>("select * from CertShip  ").ToList();
		string urlpath = "/temp/Certificates of Shipment Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Certificates of Shipment");
				
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
					worksheet.Cells[1, 1].Value = "Certificate Number";
						
								
					worksheet.Column(2).Width = 17;
					worksheet.Cells[1, 2].Value = "Job Number";
						
								
					worksheet.Column(3).Width = 12;
					worksheet.Cells[1, 3].Value = "Job Letter";
						
								
					worksheet.Column(4).Width = 17;
					worksheet.Cells[1, 4].Value = "Order Number";
						
								
					worksheet.Column(5).Width = 38;
					worksheet.Cells[1, 5].Value = "Client";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].CSId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].CSJobNo.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].CSJobLetter.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].CSOrder.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].CSCust.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CSIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSId" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSId(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSId" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CSJobNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCSJobNo(CertShip m, int? id, string q) {

		
		string s = m.CSJobNo.DataSource;
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
	public ActionResult CallbackCSJobNo(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSJobLetter(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSJobLetterValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobLetter")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSJobLetter(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSJobLetter")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CSOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSOrder" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCSOrder(CertShip m, int? id, string q) {

		
		string s = m.CSOrder.DataSource;
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
	public ActionResult CallbackCSOrder(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSOrder" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CSCustValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCust" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCSCust(CertShip m, int? id, string q) {

		
		string s = m.CSCust.DataSource;
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
	public ActionResult CallbackCSCust(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCust" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSCustOrd(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSCustOrdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCustOrd")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSCustOrd(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSCustOrd")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSDelPoint(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CSDelPointValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDelPoint" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDelPoint")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCSDelPoint(CertShip m, int? id, string q) {

		
		string s = m.CSDelPoint.DataSource;
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
	public ActionResult CallbackCSDelPoint(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDelPoint" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDelPoint")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSGoodsDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSGoodsDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSGoodsDesc" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSGoodsDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSGoodsDesc(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSGoodsDesc" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSGoodsDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSWeight(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSWeightValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSWeight" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSWeight")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSWeight(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSWeight" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSWeight")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSVehicle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSVehicleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSVehicle")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSVehicle(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSVehicle")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSRoute(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSRouteValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSRoute" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSRoute")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSRoute(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSRoute" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSRoute")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSShip(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CSShipValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSShip" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSShip")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSShip(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSShip" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSShip")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CSDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDate" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSDate(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDate" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCSTime(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CertShip>("select * from CertShip where RecordID=@RecId ", new { RecId = RecId}).First();
	
					TimeSpan i = TimeSpan.MinValue;
		
			bool UnableToContinue = false;

			if(!TimeSpan.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CSTimeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSTime" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSTime")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCSTime(CertShip obj) {
			
		if(DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSTime" ).Any()) {
			foreach(var itm in DS.GetManager<CertShip>().OnChange.Where(f=> f.Key == "CSTime")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CertShip>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=15 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/CertShip/Search/" + FirstSearch);
		
		return Redirect("/CertShip/List/");
	}

}

public partial class CertShipRepository : DSRepository<CertShip> {
	public CertShipRepository() : base(15, "CertShip", "Certificates of Shipment") {
	}
}
public partial class CertShip 
: DatasetBase<CertShip>, IDSBase

  {
	  public int KeyValue => CSIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "CSId":
			return CSIdField;
				case "CSJobNo":
			return CSJobNoField;
				case "CSJobLetter":
			return CSJobLetterField;
				case "CSOrder":
			return CSOrderField;
				case "CSCust":
			return CSCustField;
				case "CSCustOrd":
			return CSCustOrdField;
				case "CSDelPoint":
			return CSDelPointField;
				case "CSGoodsDesc":
			return CSGoodsDescField;
				case "CSWeight":
			return CSWeightField;
				case "CSVehicle":
			return CSVehicleField;
				case "CSRoute":
			return CSRouteField;
				case "CSShip":
			return CSShipField;
				case "CSDate":
			return CSDateField;
				case "CSTime":
			return CSTimeField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(CSId,CSIdField);
				action(CSJobNo,CSJobNoField);
				action(CSJobLetter,CSJobLetterField);
				action(CSOrder,CSOrderField);
				action(CSCust,CSCustField);
				action(CSCustOrd,CSCustOrdField);
				action(CSDelPoint,CSDelPointField);
				action(CSGoodsDesc,CSGoodsDescField);
				action(CSWeight,CSWeightField);
				action(CSVehicle,CSVehicleField);
				action(CSRoute,CSRouteField);
				action(CSShip,CSShipField);
				action(CSDate,CSDateField);
				action(CSTime,CSTimeField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				CSId.Visible=false;CSJobNo.Visible=false;CSJobLetter.Visible=false;CSOrder.Visible=false;CSCust.Visible=false;CSCustOrd.Visible=false;CSDelPoint.Visible=false;CSGoodsDesc.Visible=false;CSWeight.Visible=false;CSVehicle.Visible=false;CSRoute.Visible=false;CSShip.Visible=false;CSDate.Visible=false;CSTime.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update CertShip set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (CSId.HasChanged && CSId.HasValue) {
					SQL += ", CSId=@CSIdValue";

				}
								if (CSJobNo.HasChanged && CSJobNo.HasValue) {
					SQL += ", CSJobNo=@CSJobNoValue";

				}
								if (CSJobLetter.HasChanged && CSJobLetter.HasValue) {
					SQL += ", CSJobLetter=@CSJobLetterValue";

				}
								if (CSOrder.HasChanged && CSOrder.HasValue) {
					SQL += ", CSOrder=@CSOrderValue";

				}
								if (CSCust.HasChanged && CSCust.HasValue) {
					SQL += ", CSCust=@CSCustValue";

				}
								if (CSCustOrd.HasChanged && CSCustOrd.HasValue) {
					SQL += ", CSCustOrd=@CSCustOrdValue";

				}
								if (CSDelPoint.HasChanged && CSDelPoint.HasValue) {
					SQL += ", CSDelPoint=@CSDelPointValue";

				}
								if (CSGoodsDesc.HasChanged && CSGoodsDesc.HasValue) {
					SQL += ", CSGoodsDesc=@CSGoodsDescValue";

				}
								if (CSWeight.HasChanged && CSWeight.HasValue) {
					SQL += ", CSWeight=@CSWeightValue";

				}
								if (CSVehicle.HasChanged && CSVehicle.HasValue) {
					SQL += ", CSVehicle=@CSVehicleValue";

				}
								if (CSRoute.HasChanged && CSRoute.HasValue) {
					SQL += ", CSRoute=@CSRouteValue";

				}
								if (CSShip.HasChanged && CSShip.HasValue) {
					SQL += ", CSShip=@CSShipValue";

				}
								if (CSDate.HasChanged && CSDate.HasValue) {
					SQL += ", CSDate=@CSDateValue";

				}
								if (CSTime.HasChanged && CSTime.HasValue) {
					SQL += ", CSTime=@CSTimeValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									CSId.HasChanged = false;
									CSJobNo.HasChanged = false;
									CSJobLetter.HasChanged = false;
									CSOrder.HasChanged = false;
									CSCust.HasChanged = false;
									CSCustOrd.HasChanged = false;
									CSDelPoint.HasChanged = false;
									CSGoodsDesc.HasChanged = false;
									CSWeight.HasChanged = false;
									CSVehicle.HasChanged = false;
									CSRoute.HasChanged = false;
									CSShip.HasChanged = false;
									CSDate.HasChanged = false;
									CSTime.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into CertShip(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				CSId.Value = IQApp.DB.GetInt("select isnull(max(CSId),0)+1 from CertShip");
				if (CSId.HasValue) {
					SQL += ", CSId";
					Values += ", @CSIdValue";
				}
				
				if (CSJobNo.HasValue) {
					SQL += ", CSJobNo";
					Values += ", @CSJobNoValue";
				}
				
				if (CSJobLetter.HasValue) {
					SQL += ", CSJobLetter";
					Values += ", @CSJobLetterValue";
				}
				
				if (CSOrder.HasValue) {
					SQL += ", CSOrder";
					Values += ", @CSOrderValue";
				}
				
				if (CSCust.HasValue) {
					SQL += ", CSCust";
					Values += ", @CSCustValue";
				}
				
				if (CSCustOrd.HasValue) {
					SQL += ", CSCustOrd";
					Values += ", @CSCustOrdValue";
				}
				
				if (CSDelPoint.HasValue) {
					SQL += ", CSDelPoint";
					Values += ", @CSDelPointValue";
				}
				
				if (CSGoodsDesc.HasValue) {
					SQL += ", CSGoodsDesc";
					Values += ", @CSGoodsDescValue";
				}
				
				if (CSWeight.HasValue) {
					SQL += ", CSWeight";
					Values += ", @CSWeightValue";
				}
				
				if (CSVehicle.HasValue) {
					SQL += ", CSVehicle";
					Values += ", @CSVehicleValue";
				}
				
				if (CSRoute.HasValue) {
					SQL += ", CSRoute";
					Values += ", @CSRouteValue";
				}
				
				if (CSShip.HasValue) {
					SQL += ", CSShip";
					Values += ", @CSShipValue";
				}
				
				if (CSDate.HasValue) {
					SQL += ", CSDate";
					Values += ", @CSDateValue";
				}
				
				if (CSTime.HasValue) {
					SQL += ", CSTime";
					Values += ", @CSTimeValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from CertShip");
					 IQApp.DB.Execute(SQL, this);
				                    					CSId.HasChanged = false;
									CSJobNo.HasChanged = false;
									CSJobLetter.HasChanged = false;
									CSOrder.HasChanged = false;
									CSCust.HasChanged = false;
									CSCustOrd.HasChanged = false;
									CSDelPoint.HasChanged = false;
									CSGoodsDesc.HasChanged = false;
									CSWeight.HasChanged = false;
									CSVehicle.HasChanged = false;
									CSRoute.HasChanged = false;
									CSShip.HasChanged = false;
									CSDate.HasChanged = false;
									CSTime.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "CSId":
					return (IDSFieldBase)CSId;
								case "CSJobNo":
					return (IDSFieldBase)CSJobNo;
								case "CSJobLetter":
					return (IDSFieldBase)CSJobLetter;
								case "CSOrder":
					return (IDSFieldBase)CSOrder;
								case "CSCust":
					return (IDSFieldBase)CSCust;
								case "CSCustOrd":
					return (IDSFieldBase)CSCustOrd;
								case "CSDelPoint":
					return (IDSFieldBase)CSDelPoint;
								case "CSGoodsDesc":
					return (IDSFieldBase)CSGoodsDesc;
								case "CSWeight":
					return (IDSFieldBase)CSWeight;
								case "CSVehicle":
					return (IDSFieldBase)CSVehicle;
								case "CSRoute":
					return (IDSFieldBase)CSRoute;
								case "CSShip":
					return (IDSFieldBase)CSShip;
								case "CSDate":
					return (IDSFieldBase)CSDate;
								case "CSTime":
					return (IDSFieldBase)CSTime;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "CSId":
					return CSId.DisplayValue;
								case "CSJobNo":
					return CSJobNo.DisplayValue;
								case "CSJobLetter":
					return CSJobLetter.DisplayValue;
								case "CSOrder":
					return CSOrder.DisplayValue;
								case "CSCust":
					return CSCust.DisplayValue;
								case "CSCustOrd":
					return CSCustOrd.DisplayValue;
								case "CSDelPoint":
					return CSDelPoint.DisplayValue;
								case "CSGoodsDesc":
					return CSGoodsDesc.DisplayValue;
								case "CSWeight":
					return CSWeight.DisplayValue;
								case "CSVehicle":
					return CSVehicle.DisplayValue;
								case "CSRoute":
					return CSRoute.DisplayValue;
								case "CSShip":
					return CSShip.DisplayValue;
								case "CSDate":
					return CSDate.DisplayValue;
								case "CSTime":
					return CSTime.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "CSId":
					return CSId.Value.ToString();
								case "CSJobNo":
					return CSJobNo.Value.ToString();
								case "CSJobLetter":
					return CSJobLetter.Value.ToString();
								case "CSOrder":
					return CSOrder.Value.ToString();
								case "CSCust":
					return CSCust.Value.ToString();
								case "CSCustOrd":
					return CSCustOrd.Value.ToString();
								case "CSDelPoint":
					return CSDelPoint.Value.ToString();
								case "CSGoodsDesc":
					return CSGoodsDesc.Value.ToString();
								case "CSWeight":
					return CSWeight.Value.ToString();
								case "CSVehicle":
					return CSVehicle.Value.ToString();
								case "CSRoute":
					return CSRoute.Value.ToString();
								case "CSShip":
					return CSShip.Value.ToString();
								case "CSDate":
					return CSDate.Value.ToString();
								case "CSTime":
					return CSTime.Value.ToString();
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
					foreach(var itm in DS.GetManager<CertShip>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public CertShip () : base("CertShip") {
		base.obj = this;
	
					CSId = new CertShip_CSId(this);
					CSJobNo = new CertShip_CSJobNo(this);
					CSJobLetter = new CertShip_CSJobLetter(this);
					CSOrder = new CertShip_CSOrder(this);
					CSCust = new CertShip_CSCust(this);
					CSCustOrd = new CertShip_CSCustOrd(this);
					CSDelPoint = new CertShip_CSDelPoint(this);
					CSGoodsDesc = new CertShip_CSGoodsDesc(this);
					CSWeight = new CertShip_CSWeight(this);
					CSVehicle = new CertShip_CSVehicle(this);
					CSRoute = new CertShip_CSRoute(this);
					CSShip = new CertShip_CSShip(this);
					CSDate = new CertShip_CSDate(this);
					CSTime = new CertShip_CSTime(this);
			}

	static CertShip () {
					CSIdField = new CertShip_CSIdFieldDef();
					CSJobNoField = new CertShip_CSJobNoFieldDef();
					CSJobLetterField = new CertShip_CSJobLetterFieldDef();
					CSOrderField = new CertShip_CSOrderFieldDef();
					CSCustField = new CertShip_CSCustFieldDef();
					CSCustOrdField = new CertShip_CSCustOrdFieldDef();
					CSDelPointField = new CertShip_CSDelPointFieldDef();
					CSGoodsDescField = new CertShip_CSGoodsDescFieldDef();
					CSWeightField = new CertShip_CSWeightFieldDef();
					CSVehicleField = new CertShip_CSVehicleFieldDef();
					CSRouteField = new CertShip_CSRouteFieldDef();
					CSShipField = new CertShip_CSShipFieldDef();
					CSDateField = new CertShip_CSDateFieldDef();
					CSTimeField = new CertShip_CSTimeFieldDef();
			}

	public string RecordTitle { 
		get { return CSIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Certificates of Shipment"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/CertShip/Load/?RecId=" + RecordID.Value;
			}
			return "/CertShip/Add";
			}
	}

			
		
		[Ignore()]
		public CertShip_CSId CSId { get; set; }
		public static CertShip_CSIdFieldDef CSIdField { get; private set; }
        
			
			[Column("CSId")]
			public  int PopulateCSId  {
				get { return CSIdValue ;}
				set { CSId.DataValue = value; }
			}

	
			public int CSIdValue 
			{ 
				get 
				{
				   if(CSId.Value != null) {
				   					int i = 0;
					if (CSId != null)
					{
						if (CSId.Value != null)
						{
							if (Int32.TryParse(CSId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CSId.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSJobNo CSJobNo { get; set; }
		public static CertShip_CSJobNoFieldDef CSJobNoField { get; private set; }
        
			
			[Column("CSJobNo")]
			public  int PopulateCSJobNo  {
				get { return CSJobNoValue ;}
				set { CSJobNo.DataValue = value; }
			}

	
			public int CSJobNoValue 
			{ 
				get 
				{
				   if(CSJobNo.Value != null) {
				   					int i = 0;
					if (CSJobNo != null)
					{
						if (CSJobNo.Value != null)
						{
							if (Int32.TryParse(CSJobNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CSJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSJobLetter CSJobLetter { get; set; }
		public static CertShip_CSJobLetterFieldDef CSJobLetterField { get; private set; }
        
			
			[Column("CSJobLetter")]
			public  string PopulateCSJobLetter  {
				get { return CSJobLetterValue ;}
				set { CSJobLetter.DataValue = value; }
			}

	
			public string CSJobLetterValue 
			{ 
				get 
				{
				   if(CSJobLetter.Value != null) {
				   return CSJobLetter.Value.ToString(); 					}
					return "";
                
				}
				set { CSJobLetter.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSOrder CSOrder { get; set; }
		public static CertShip_CSOrderFieldDef CSOrderField { get; private set; }
        
			
			[Column("CSOrder")]
			public  int PopulateCSOrder  {
				get { return CSOrderValue ;}
				set { CSOrder.DataValue = value; }
			}

	
			public int CSOrderValue 
			{ 
				get 
				{
				   if(CSOrder.Value != null) {
				   					int i = 0;
					if (CSOrder != null)
					{
						if (CSOrder.Value != null)
						{
							if (Int32.TryParse(CSOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CSOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSCust CSCust { get; set; }
		public static CertShip_CSCustFieldDef CSCustField { get; private set; }
        
			
			[Column("CSCust")]
			public  int PopulateCSCust  {
				get { return CSCustValue ;}
				set { CSCust.DataValue = value; }
			}

	
			public int CSCustValue 
			{ 
				get 
				{
				   if(CSCust.Value != null) {
				   					int i = 0;
					if (CSCust != null)
					{
						if (CSCust.Value != null)
						{
							if (Int32.TryParse(CSCust.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CSCust.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSCustOrd CSCustOrd { get; set; }
		public static CertShip_CSCustOrdFieldDef CSCustOrdField { get; private set; }
        
			
			[Column("CSCustOrd")]
			public  string PopulateCSCustOrd  {
				get { return CSCustOrdValue ;}
				set { CSCustOrd.DataValue = value; }
			}

	
			public string CSCustOrdValue 
			{ 
				get 
				{
				   if(CSCustOrd.Value != null) {
				   return CSCustOrd.Value.ToString(); 					}
					return "";
                
				}
				set { CSCustOrd.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSDelPoint CSDelPoint { get; set; }
		public static CertShip_CSDelPointFieldDef CSDelPointField { get; private set; }
        
			
			[Column("CSDelPoint")]
			public  int PopulateCSDelPoint  {
				get { return CSDelPointValue ;}
				set { CSDelPoint.DataValue = value; }
			}

	
			public int CSDelPointValue 
			{ 
				get 
				{
				   if(CSDelPoint.Value != null) {
				   					int i = 0;
					if (CSDelPoint != null)
					{
						if (CSDelPoint.Value != null)
						{
							if (Int32.TryParse(CSDelPoint.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CSDelPoint.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSGoodsDesc CSGoodsDesc { get; set; }
		public static CertShip_CSGoodsDescFieldDef CSGoodsDescField { get; private set; }
        
			
			[Column("CSGoodsDesc")]
			public  string PopulateCSGoodsDesc  {
				get { return CSGoodsDescValue ;}
				set { CSGoodsDesc.DataValue = value; }
			}

	
			public string CSGoodsDescValue 
			{ 
				get 
				{
				   if(CSGoodsDesc.Value != null) {
				   return CSGoodsDesc.Value.ToString(); 					}
					return "";
                
				}
				set { CSGoodsDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSWeight CSWeight { get; set; }
		public static CertShip_CSWeightFieldDef CSWeightField { get; private set; }
        
			
			[Column("CSWeight")]
			public  string PopulateCSWeight  {
				get { return CSWeightValue ;}
				set { CSWeight.DataValue = value; }
			}

	
			public string CSWeightValue 
			{ 
				get 
				{
				   if(CSWeight.Value != null) {
				   return CSWeight.Value.ToString(); 					}
					return "";
                
				}
				set { CSWeight.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSVehicle CSVehicle { get; set; }
		public static CertShip_CSVehicleFieldDef CSVehicleField { get; private set; }
        
			
			[Column("CSVehicle")]
			public  string PopulateCSVehicle  {
				get { return CSVehicleValue ;}
				set { CSVehicle.DataValue = value; }
			}

	
			public string CSVehicleValue 
			{ 
				get 
				{
				   if(CSVehicle.Value != null) {
				   return CSVehicle.Value.ToString(); 					}
					return "";
                
				}
				set { CSVehicle.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSRoute CSRoute { get; set; }
		public static CertShip_CSRouteFieldDef CSRouteField { get; private set; }
        
			
			[Column("CSRoute")]
			public  string PopulateCSRoute  {
				get { return CSRouteValue ;}
				set { CSRoute.DataValue = value; }
			}

	
			public string CSRouteValue 
			{ 
				get 
				{
				   if(CSRoute.Value != null) {
				   return CSRoute.Value.ToString(); 					}
					return "";
                
				}
				set { CSRoute.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSShip CSShip { get; set; }
		public static CertShip_CSShipFieldDef CSShipField { get; private set; }
        
			
			[Column("CSShip")]
			public  string PopulateCSShip  {
				get { return CSShipValue ;}
				set { CSShip.DataValue = value; }
			}

	
			public string CSShipValue 
			{ 
				get 
				{
				   if(CSShip.Value != null) {
				   return CSShip.Value.ToString(); 					}
					return "";
                
				}
				set { CSShip.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSDate CSDate { get; set; }
		public static CertShip_CSDateFieldDef CSDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("CSDate")]
			public  DateTime PopulateCSDate  {
				get { return CSDateValue ;}
				set { CSDate.DataValue = value; }
			}

	
			public DateTime CSDateValue 
			{ 
				get 
				{
				   if(CSDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (CSDate != null)
					{
						if (CSDate.Value != null)
						{
							if (DateTime.TryParse(CSDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { CSDate.Value = value;  }
			}
			
		
		[Ignore()]
		public CertShip_CSTime CSTime { get; set; }
		public static CertShip_CSTimeFieldDef CSTimeField { get; private set; }
        
			
			[Column("CSTime")]
			public  TimeSpan PopulateCSTime  {
				get { return CSTimeValue ;}
				set { CSTime.DataValue = value; }
			}

	
			public TimeSpan CSTimeValue 
			{ 
				get 
				{
				   if(CSTime.Value != null) {
				   					TimeSpan i = TimeSpan.MinValue;
					if (CSTime != null)
					{
						if (CSTime.Value != null)
						{
							if (TimeSpan.TryParse(CSTime.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return TimeSpan.MinValue;
                
				}
				set { CSTime.Value = value;  }
			}
	}


public class CertShip_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 15;
    public int PixelHeight => 0;
	public string Title => "Certificates of Shipment";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
