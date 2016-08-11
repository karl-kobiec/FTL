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


public partial class TruckController : DSBaseController<Truck/*,TruckSearch*/> {
	public TruckController() : base ((IDatabase)IQApp.DB, new TruckRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select TrkId from Truck where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Truck>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Truck data) {
						IQApp.DB.Execute("Delete from Truck where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.TrkNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Truck " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Truck " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Truck " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Truck_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Truck>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Truck>("select * from Truck  ").ToList();
		string urlpath = "/temp/Trucks Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Trucks");
				
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
							
					worksheet.Column(1).Width = 40;
					worksheet.Cells[1, 1].Value = "Truck ID";
						
								
					worksheet.Column(2).Width = 60;
					worksheet.Cells[1, 2].Value = "Registration No";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].TrkId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].TrkName.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrkIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkId" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkId(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkId" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkName" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkName(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkName" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkNotes(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMOTDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrkMOTDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkMOTDate" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkMOTDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMOTDate(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkMOTDate" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkMOTDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkTAXDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrkTAXDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTAXDate" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTAXDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkTAXDate(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTAXDate" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTAXDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkDriver(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrkDriverValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDriver" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDriver")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteTrkDriver(Truck m, int? id, string q) {

		
		string s = m.TrkDriver.DataSource;
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
	public ActionResult CallbackTrkDriver(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDriver" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDriver")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkServiceDue(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrkServiceDueValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkServiceDue" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkServiceDue")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkServiceDue(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkServiceDue" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkServiceDue")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkAS24No(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkAS24NoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24No" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24No")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkAS24No(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24No" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24No")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkAS24PIN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkAS24PINValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24PIN" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24PIN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkAS24PIN(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24PIN" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkAS24PIN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkDKVNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkDKVNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVNo" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkDKVNo(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVNo" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkDKVPIN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkDKVPINValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVPIN" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVPIN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkDKVPIN(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVPIN" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkDKVPIN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkShellNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkShellNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellNo" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkShellNo(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellNo" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkShellPIN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkShellPINValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellPIN" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellPIN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkShellPIN(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellPIN" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkShellPIN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkPermitNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkPermitNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkPermitNo" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkPermitNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkPermitNo(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkPermitNo" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkPermitNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkTruckMob(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Truck>("select * from Truck where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkTruckMobValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTruckMob" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTruckMob")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkTruckMob(Truck obj) {
			
		if(DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTruckMob" ).Any()) {
			foreach(var itm in DS.GetManager<Truck>().OnChange.Where(f=> f.Key == "TrkTruckMob")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Truck>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Truck/List/");
	}

}

public partial class TruckRepository : DSRepository<Truck> {
	public TruckRepository() : base(31, "Truck", "Trucks") {
	}
}
public partial class Truck 
: DatasetBase<Truck>, IDSBase

  {
	  public int KeyValue => TrkIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "TrkId":
			return TrkIdField;
				case "TrkName":
			return TrkNameField;
				case "TrkNotes":
			return TrkNotesField;
				case "TrkMOTDate":
			return TrkMOTDateField;
				case "TrkTAXDate":
			return TrkTAXDateField;
				case "TrkDriver":
			return TrkDriverField;
				case "TrkServiceDue":
			return TrkServiceDueField;
				case "TrkAS24No":
			return TrkAS24NoField;
				case "TrkAS24PIN":
			return TrkAS24PINField;
				case "TrkDKVNo":
			return TrkDKVNoField;
				case "TrkDKVPIN":
			return TrkDKVPINField;
				case "TrkShellNo":
			return TrkShellNoField;
				case "TrkShellPIN":
			return TrkShellPINField;
				case "TrkPermitNo":
			return TrkPermitNoField;
				case "TrkTruckMob":
			return TrkTruckMobField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(TrkId,TrkIdField);
				action(TrkName,TrkNameField);
				action(TrkNotes,TrkNotesField);
				action(TrkMOTDate,TrkMOTDateField);
				action(TrkTAXDate,TrkTAXDateField);
				action(TrkDriver,TrkDriverField);
				action(TrkServiceDue,TrkServiceDueField);
				action(TrkAS24No,TrkAS24NoField);
				action(TrkAS24PIN,TrkAS24PINField);
				action(TrkDKVNo,TrkDKVNoField);
				action(TrkDKVPIN,TrkDKVPINField);
				action(TrkShellNo,TrkShellNoField);
				action(TrkShellPIN,TrkShellPINField);
				action(TrkPermitNo,TrkPermitNoField);
				action(TrkTruckMob,TrkTruckMobField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				TrkId.Visible=false;TrkName.Visible=false;TrkNotes.Visible=false;TrkMOTDate.Visible=false;TrkTAXDate.Visible=false;TrkDriver.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Truck set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (TrkId.HasChanged && TrkId.HasValue) {
					SQL += ", TrkId=@TrkIdValue";

				}
								if (TrkName.HasChanged && TrkName.HasValue) {
					SQL += ", TrkName=@TrkNameValue";

				}
								if (TrkNotes.HasChanged && TrkNotes.HasValue) {
					SQL += ", TrkNotes=@TrkNotesValue";

				}
								if (TrkMOTDate.HasChanged && TrkMOTDate.HasValue) {
					SQL += ", TrkMOTDate=@TrkMOTDateValue";

				}
								if (TrkTAXDate.HasChanged && TrkTAXDate.HasValue) {
					SQL += ", TrkTAXDate=@TrkTAXDateValue";

				}
								if (TrkDriver.HasChanged && TrkDriver.HasValue) {
					SQL += ", TrkDriver=@TrkDriverValue";

				}
								if (TrkServiceDue.HasChanged && TrkServiceDue.HasValue) {
					SQL += ", TrkServiceDue=@TrkServiceDueValue";

				}
								if (TrkAS24No.HasChanged && TrkAS24No.HasValue) {
					SQL += ", TrkAS24No=@TrkAS24NoValue";

				}
								if (TrkAS24PIN.HasChanged && TrkAS24PIN.HasValue) {
					SQL += ", TrkAS24PIN=@TrkAS24PINValue";

				}
								if (TrkDKVNo.HasChanged && TrkDKVNo.HasValue) {
					SQL += ", TrkDKVNo=@TrkDKVNoValue";

				}
								if (TrkDKVPIN.HasChanged && TrkDKVPIN.HasValue) {
					SQL += ", TrkDKVPIN=@TrkDKVPINValue";

				}
								if (TrkShellNo.HasChanged && TrkShellNo.HasValue) {
					SQL += ", TrkShellNo=@TrkShellNoValue";

				}
								if (TrkShellPIN.HasChanged && TrkShellPIN.HasValue) {
					SQL += ", TrkShellPIN=@TrkShellPINValue";

				}
								if (TrkPermitNo.HasChanged && TrkPermitNo.HasValue) {
					SQL += ", TrkPermitNo=@TrkPermitNoValue";

				}
								if (TrkTruckMob.HasChanged && TrkTruckMob.HasValue) {
					SQL += ", TrkTruckMob=@TrkTruckMobValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									TrkId.HasChanged = false;
									TrkName.HasChanged = false;
									TrkNotes.HasChanged = false;
									TrkMOTDate.HasChanged = false;
									TrkTAXDate.HasChanged = false;
									TrkDriver.HasChanged = false;
									TrkServiceDue.HasChanged = false;
									TrkAS24No.HasChanged = false;
									TrkAS24PIN.HasChanged = false;
									TrkDKVNo.HasChanged = false;
									TrkDKVPIN.HasChanged = false;
									TrkShellNo.HasChanged = false;
									TrkShellPIN.HasChanged = false;
									TrkPermitNo.HasChanged = false;
									TrkTruckMob.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Truck(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				TrkId.Value = IQApp.DB.GetInt("select isnull(max(TrkId),0)+1 from Truck");
				if (TrkId.HasValue) {
					SQL += ", TrkId";
					Values += ", @TrkIdValue";
				}
				
				if (TrkName.HasValue) {
					SQL += ", TrkName";
					Values += ", @TrkNameValue";
				}
				
				if (TrkNotes.HasValue) {
					SQL += ", TrkNotes";
					Values += ", @TrkNotesValue";
				}
				
				if (TrkMOTDate.HasValue) {
					SQL += ", TrkMOTDate";
					Values += ", @TrkMOTDateValue";
				}
				
				if (TrkTAXDate.HasValue) {
					SQL += ", TrkTAXDate";
					Values += ", @TrkTAXDateValue";
				}
				
				if (TrkDriver.HasValue) {
					SQL += ", TrkDriver";
					Values += ", @TrkDriverValue";
				}
				
				if (TrkServiceDue.HasValue) {
					SQL += ", TrkServiceDue";
					Values += ", @TrkServiceDueValue";
				}
				
				if (TrkAS24No.HasValue) {
					SQL += ", TrkAS24No";
					Values += ", @TrkAS24NoValue";
				}
				
				if (TrkAS24PIN.HasValue) {
					SQL += ", TrkAS24PIN";
					Values += ", @TrkAS24PINValue";
				}
				
				if (TrkDKVNo.HasValue) {
					SQL += ", TrkDKVNo";
					Values += ", @TrkDKVNoValue";
				}
				
				if (TrkDKVPIN.HasValue) {
					SQL += ", TrkDKVPIN";
					Values += ", @TrkDKVPINValue";
				}
				
				if (TrkShellNo.HasValue) {
					SQL += ", TrkShellNo";
					Values += ", @TrkShellNoValue";
				}
				
				if (TrkShellPIN.HasValue) {
					SQL += ", TrkShellPIN";
					Values += ", @TrkShellPINValue";
				}
				
				if (TrkPermitNo.HasValue) {
					SQL += ", TrkPermitNo";
					Values += ", @TrkPermitNoValue";
				}
				
				if (TrkTruckMob.HasValue) {
					SQL += ", TrkTruckMob";
					Values += ", @TrkTruckMobValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Truck");
					 IQApp.DB.Execute(SQL, this);
				                    					TrkId.HasChanged = false;
									TrkName.HasChanged = false;
									TrkNotes.HasChanged = false;
									TrkMOTDate.HasChanged = false;
									TrkTAXDate.HasChanged = false;
									TrkDriver.HasChanged = false;
									TrkServiceDue.HasChanged = false;
									TrkAS24No.HasChanged = false;
									TrkAS24PIN.HasChanged = false;
									TrkDKVNo.HasChanged = false;
									TrkDKVPIN.HasChanged = false;
									TrkShellNo.HasChanged = false;
									TrkShellPIN.HasChanged = false;
									TrkPermitNo.HasChanged = false;
									TrkTruckMob.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "TrkId":
					return (IDSFieldBase)TrkId;
								case "TrkName":
					return (IDSFieldBase)TrkName;
								case "TrkNotes":
					return (IDSFieldBase)TrkNotes;
								case "TrkMOTDate":
					return (IDSFieldBase)TrkMOTDate;
								case "TrkTAXDate":
					return (IDSFieldBase)TrkTAXDate;
								case "TrkDriver":
					return (IDSFieldBase)TrkDriver;
								case "TrkServiceDue":
					return (IDSFieldBase)TrkServiceDue;
								case "TrkAS24No":
					return (IDSFieldBase)TrkAS24No;
								case "TrkAS24PIN":
					return (IDSFieldBase)TrkAS24PIN;
								case "TrkDKVNo":
					return (IDSFieldBase)TrkDKVNo;
								case "TrkDKVPIN":
					return (IDSFieldBase)TrkDKVPIN;
								case "TrkShellNo":
					return (IDSFieldBase)TrkShellNo;
								case "TrkShellPIN":
					return (IDSFieldBase)TrkShellPIN;
								case "TrkPermitNo":
					return (IDSFieldBase)TrkPermitNo;
								case "TrkTruckMob":
					return (IDSFieldBase)TrkTruckMob;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "TrkId":
					return TrkId.DisplayValue;
								case "TrkName":
					return TrkName.DisplayValue;
								case "TrkNotes":
					return TrkNotes.DisplayValue;
								case "TrkMOTDate":
					return TrkMOTDate.DisplayValue;
								case "TrkTAXDate":
					return TrkTAXDate.DisplayValue;
								case "TrkDriver":
					return TrkDriver.DisplayValue;
								case "TrkServiceDue":
					return TrkServiceDue.DisplayValue;
								case "TrkAS24No":
					return TrkAS24No.DisplayValue;
								case "TrkAS24PIN":
					return TrkAS24PIN.DisplayValue;
								case "TrkDKVNo":
					return TrkDKVNo.DisplayValue;
								case "TrkDKVPIN":
					return TrkDKVPIN.DisplayValue;
								case "TrkShellNo":
					return TrkShellNo.DisplayValue;
								case "TrkShellPIN":
					return TrkShellPIN.DisplayValue;
								case "TrkPermitNo":
					return TrkPermitNo.DisplayValue;
								case "TrkTruckMob":
					return TrkTruckMob.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "TrkId":
					return TrkId.Value.ToString();
								case "TrkName":
					return TrkName.Value.ToString();
								case "TrkNotes":
					return TrkNotes.Value.ToString();
								case "TrkMOTDate":
					return TrkMOTDate.Value.ToString();
								case "TrkTAXDate":
					return TrkTAXDate.Value.ToString();
								case "TrkDriver":
					return TrkDriver.Value.ToString();
								case "TrkServiceDue":
					return TrkServiceDue.Value.ToString();
								case "TrkAS24No":
					return TrkAS24No.Value.ToString();
								case "TrkAS24PIN":
					return TrkAS24PIN.Value.ToString();
								case "TrkDKVNo":
					return TrkDKVNo.Value.ToString();
								case "TrkDKVPIN":
					return TrkDKVPIN.Value.ToString();
								case "TrkShellNo":
					return TrkShellNo.Value.ToString();
								case "TrkShellPIN":
					return TrkShellPIN.Value.ToString();
								case "TrkPermitNo":
					return TrkPermitNo.Value.ToString();
								case "TrkTruckMob":
					return TrkTruckMob.Value.ToString();
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
					foreach(var itm in DS.GetManager<Truck>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Truck () : base("Truck") {
		base.obj = this;
	
					TrkId = new Truck_TrkId(this);
					TrkName = new Truck_TrkName(this);
					TrkNotes = new Truck_TrkNotes(this);
					TrkMOTDate = new Truck_TrkMOTDate(this);
					TrkTAXDate = new Truck_TrkTAXDate(this);
					TrkDriver = new Truck_TrkDriver(this);
					TrkServiceDue = new Truck_TrkServiceDue(this);
					TrkAS24No = new Truck_TrkAS24No(this);
					TrkAS24PIN = new Truck_TrkAS24PIN(this);
					TrkDKVNo = new Truck_TrkDKVNo(this);
					TrkDKVPIN = new Truck_TrkDKVPIN(this);
					TrkShellNo = new Truck_TrkShellNo(this);
					TrkShellPIN = new Truck_TrkShellPIN(this);
					TrkPermitNo = new Truck_TrkPermitNo(this);
					TrkTruckMob = new Truck_TrkTruckMob(this);
			}

	static Truck () {
					TrkIdField = new Truck_TrkIdFieldDef();
					TrkNameField = new Truck_TrkNameFieldDef();
					TrkNotesField = new Truck_TrkNotesFieldDef();
					TrkMOTDateField = new Truck_TrkMOTDateFieldDef();
					TrkTAXDateField = new Truck_TrkTAXDateFieldDef();
					TrkDriverField = new Truck_TrkDriverFieldDef();
					TrkServiceDueField = new Truck_TrkServiceDueFieldDef();
					TrkAS24NoField = new Truck_TrkAS24NoFieldDef();
					TrkAS24PINField = new Truck_TrkAS24PINFieldDef();
					TrkDKVNoField = new Truck_TrkDKVNoFieldDef();
					TrkDKVPINField = new Truck_TrkDKVPINFieldDef();
					TrkShellNoField = new Truck_TrkShellNoFieldDef();
					TrkShellPINField = new Truck_TrkShellPINFieldDef();
					TrkPermitNoField = new Truck_TrkPermitNoFieldDef();
					TrkTruckMobField = new Truck_TrkTruckMobFieldDef();
			}

	public string RecordTitle { 
		get { return TrkNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Trucks"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Truck/Load/?RecId=" + RecordID.Value;
			}
			return "/Truck/Add";
			}
	}

			
		
		[Ignore()]
		public Truck_TrkId TrkId { get; set; }
		public static Truck_TrkIdFieldDef TrkIdField { get; private set; }
        
			
			[Column("TrkId")]
			public  int PopulateTrkId  {
				get { return TrkIdValue ;}
				set { TrkId.DataValue = value; }
			}

	
			public int TrkIdValue 
			{ 
				get 
				{
				   if(TrkId.Value != null) {
				   					int i = 0;
					if (TrkId != null)
					{
						if (TrkId.Value != null)
						{
							if (Int32.TryParse(TrkId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrkId.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkName TrkName { get; set; }
		public static Truck_TrkNameFieldDef TrkNameField { get; private set; }
        
			
			[Column("TrkName")]
			public  string PopulateTrkName  {
				get { return TrkNameValue ;}
				set { TrkName.DataValue = value; }
			}

	
			public string TrkNameValue 
			{ 
				get 
				{
				   if(TrkName.Value != null) {
				   return TrkName.Value.ToString(); 					}
					return "";
                
				}
				set { TrkName.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkNotes TrkNotes { get; set; }
		public static Truck_TrkNotesFieldDef TrkNotesField { get; private set; }
        
			
			[Column("TrkNotes")]
			public  string PopulateTrkNotes  {
				get { return TrkNotesValue ;}
				set { TrkNotes.DataValue = value; }
			}

	
			public string TrkNotesValue 
			{ 
				get 
				{
				   if(TrkNotes.Value != null) {
				   return TrkNotes.Value.ToString(); 					}
					return "";
                
				}
				set { TrkNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkMOTDate TrkMOTDate { get; set; }
		public static Truck_TrkMOTDateFieldDef TrkMOTDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrkMOTDate")]
			public  DateTime PopulateTrkMOTDate  {
				get { return TrkMOTDateValue ;}
				set { TrkMOTDate.DataValue = value; }
			}

	
			public DateTime TrkMOTDateValue 
			{ 
				get 
				{
				   if(TrkMOTDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrkMOTDate != null)
					{
						if (TrkMOTDate.Value != null)
						{
							if (DateTime.TryParse(TrkMOTDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrkMOTDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkTAXDate TrkTAXDate { get; set; }
		public static Truck_TrkTAXDateFieldDef TrkTAXDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrkTAXDate")]
			public  DateTime PopulateTrkTAXDate  {
				get { return TrkTAXDateValue ;}
				set { TrkTAXDate.DataValue = value; }
			}

	
			public DateTime TrkTAXDateValue 
			{ 
				get 
				{
				   if(TrkTAXDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrkTAXDate != null)
					{
						if (TrkTAXDate.Value != null)
						{
							if (DateTime.TryParse(TrkTAXDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrkTAXDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkDriver TrkDriver { get; set; }
		public static Truck_TrkDriverFieldDef TrkDriverField { get; private set; }
        
			
			[Column("TrkDriver")]
			public  int PopulateTrkDriver  {
				get { return TrkDriverValue ;}
				set { TrkDriver.DataValue = value; }
			}

	
			public int TrkDriverValue 
			{ 
				get 
				{
				   if(TrkDriver.Value != null) {
				   					int i = 0;
					if (TrkDriver != null)
					{
						if (TrkDriver.Value != null)
						{
							if (Int32.TryParse(TrkDriver.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrkDriver.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkServiceDue TrkServiceDue { get; set; }
		public static Truck_TrkServiceDueFieldDef TrkServiceDueField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrkServiceDue")]
			public  DateTime PopulateTrkServiceDue  {
				get { return TrkServiceDueValue ;}
				set { TrkServiceDue.DataValue = value; }
			}

	
			public DateTime TrkServiceDueValue 
			{ 
				get 
				{
				   if(TrkServiceDue.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrkServiceDue != null)
					{
						if (TrkServiceDue.Value != null)
						{
							if (DateTime.TryParse(TrkServiceDue.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrkServiceDue.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkAS24No TrkAS24No { get; set; }
		public static Truck_TrkAS24NoFieldDef TrkAS24NoField { get; private set; }
        
			
			[Column("TrkAS24No")]
			public  string PopulateTrkAS24No  {
				get { return TrkAS24NoValue ;}
				set { TrkAS24No.DataValue = value; }
			}

	
			public string TrkAS24NoValue 
			{ 
				get 
				{
				   if(TrkAS24No.Value != null) {
				   return TrkAS24No.Value.ToString(); 					}
					return "";
                
				}
				set { TrkAS24No.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkAS24PIN TrkAS24PIN { get; set; }
		public static Truck_TrkAS24PINFieldDef TrkAS24PINField { get; private set; }
        
			
			[Column("TrkAS24PIN")]
			public  string PopulateTrkAS24PIN  {
				get { return TrkAS24PINValue ;}
				set { TrkAS24PIN.DataValue = value; }
			}

	
			public string TrkAS24PINValue 
			{ 
				get 
				{
				   if(TrkAS24PIN.Value != null) {
				   return TrkAS24PIN.Value.ToString(); 					}
					return "";
                
				}
				set { TrkAS24PIN.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkDKVNo TrkDKVNo { get; set; }
		public static Truck_TrkDKVNoFieldDef TrkDKVNoField { get; private set; }
        
			
			[Column("TrkDKVNo")]
			public  string PopulateTrkDKVNo  {
				get { return TrkDKVNoValue ;}
				set { TrkDKVNo.DataValue = value; }
			}

	
			public string TrkDKVNoValue 
			{ 
				get 
				{
				   if(TrkDKVNo.Value != null) {
				   return TrkDKVNo.Value.ToString(); 					}
					return "";
                
				}
				set { TrkDKVNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkDKVPIN TrkDKVPIN { get; set; }
		public static Truck_TrkDKVPINFieldDef TrkDKVPINField { get; private set; }
        
			
			[Column("TrkDKVPIN")]
			public  string PopulateTrkDKVPIN  {
				get { return TrkDKVPINValue ;}
				set { TrkDKVPIN.DataValue = value; }
			}

	
			public string TrkDKVPINValue 
			{ 
				get 
				{
				   if(TrkDKVPIN.Value != null) {
				   return TrkDKVPIN.Value.ToString(); 					}
					return "";
                
				}
				set { TrkDKVPIN.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkShellNo TrkShellNo { get; set; }
		public static Truck_TrkShellNoFieldDef TrkShellNoField { get; private set; }
        
			
			[Column("TrkShellNo")]
			public  string PopulateTrkShellNo  {
				get { return TrkShellNoValue ;}
				set { TrkShellNo.DataValue = value; }
			}

	
			public string TrkShellNoValue 
			{ 
				get 
				{
				   if(TrkShellNo.Value != null) {
				   return TrkShellNo.Value.ToString(); 					}
					return "";
                
				}
				set { TrkShellNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkShellPIN TrkShellPIN { get; set; }
		public static Truck_TrkShellPINFieldDef TrkShellPINField { get; private set; }
        
			
			[Column("TrkShellPIN")]
			public  string PopulateTrkShellPIN  {
				get { return TrkShellPINValue ;}
				set { TrkShellPIN.DataValue = value; }
			}

	
			public string TrkShellPINValue 
			{ 
				get 
				{
				   if(TrkShellPIN.Value != null) {
				   return TrkShellPIN.Value.ToString(); 					}
					return "";
                
				}
				set { TrkShellPIN.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkPermitNo TrkPermitNo { get; set; }
		public static Truck_TrkPermitNoFieldDef TrkPermitNoField { get; private set; }
        
			
			[Column("TrkPermitNo")]
			public  string PopulateTrkPermitNo  {
				get { return TrkPermitNoValue ;}
				set { TrkPermitNo.DataValue = value; }
			}

	
			public string TrkPermitNoValue 
			{ 
				get 
				{
				   if(TrkPermitNo.Value != null) {
				   return TrkPermitNo.Value.ToString(); 					}
					return "";
                
				}
				set { TrkPermitNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Truck_TrkTruckMob TrkTruckMob { get; set; }
		public static Truck_TrkTruckMobFieldDef TrkTruckMobField { get; private set; }
        
			
			[Column("TrkTruckMob")]
			public  string PopulateTrkTruckMob  {
				get { return TrkTruckMobValue ;}
				set { TrkTruckMob.DataValue = value; }
			}

	
			public string TrkTruckMobValue 
			{ 
				get 
				{
				   if(TrkTruckMob.Value != null) {
				   return TrkTruckMob.Value.ToString(); 					}
					return "";
                
				}
				set { TrkTruckMob.Value = value;  }
			}
	}


public class Truck_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 31;
    public int PixelHeight => 0;
	public string Title => "Trucks";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
