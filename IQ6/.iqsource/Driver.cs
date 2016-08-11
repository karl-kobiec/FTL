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


public partial class DriverController : DSBaseController<Driver/*,DriverSearch*/> {
	public DriverController() : base ((IDatabase)IQApp.DB, new DriverRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select DrvId from Driver where RecordID=@RecId", new { RecId = RecId});

					int count = 0;
						count += IQApp.DB.GetInt("select count(*) from DriverHrs where DrvHDriver=@Val", new { Val = Key});
						if(count > 0) {
				return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
			}
		
		string Msg = "Are you sure you want to delete this record?";
				
				Msg += " This will also delete any existing sub records.";
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Driver>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Driver data) {
											IQApp.DB.Execute("delete from DriverHrs where DrvHDriver=@Val", new { Val = data.DrvIdValue});
										IQApp.DB.Execute("Delete from Driver where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.DrvNameValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Driver " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Driver " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Driver " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Driver_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Driver>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Driver>("select * from Driver  ").ToList();
		string urlpath = "/temp/Drivers Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Drivers");
				
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
							
					worksheet.Column(1).Width = 11;
					worksheet.Cells[1, 1].Value = "Driver ID";
						
								
					worksheet.Column(2).Width = 29;
					worksheet.Cells[1, 2].Value = "Driver Name";
						
								
					worksheet.Column(3).Width = 18;
					worksheet.Cells[1, 3].Value = "Start Date";
						
								
					worksheet.Column(4).Width = 14;
					worksheet.Cells[1, 4].Value = "Mobile Number";
						
								
					worksheet.Column(5).Width = 14;
					worksheet.Cells[1, 5].Value = "Vehicle Assigned To";
						
								
					worksheet.Column(6).Width = 14;
					worksheet.Cells[1, 6].Value = "Active";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].DrvId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].DrvName.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].DrvSDate.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].DrvMobile.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].DrvVehicle.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].DrvActive.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DrvIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvId" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvId(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvId" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvName" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvName(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvName" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvVehicle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvVehicleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvVehicle")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvVehicle(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvVehicle")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvSDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.DrvSDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvSDate" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvSDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteDrvSDate(Driver m, int? id, string q) {

		
		string s = m.DrvSDate.DataSource;
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
	public ActionResult CallbackDrvSDate(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvSDate" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvSDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvActive(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DrvActiveValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvActive" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvActive")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvActive(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvActive" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvActive")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvPspExpiry(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DrvPspExpiryValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPspExpiry" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPspExpiry")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvPspExpiry(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPspExpiry" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPspExpiry")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvMobile(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvMobileValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvMobile" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvMobile")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvMobile(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvMobile" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvMobile")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvAddress(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvAddressValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvAddress" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvAddress")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvAddress(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvAddress" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvAddress")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvDoB(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DrvDoBValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvDoB" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvDoB")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvDoB(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvDoB" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvDoB")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvEmpStart(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.DrvEmpStartValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvEmpStart" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvEmpStart")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvEmpStart(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvEmpStart" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvEmpStart")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvLicense(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvLicenseValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvLicense" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvLicense")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvLicense(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvLicense" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvLicense")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvTacho(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvTachoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvTacho" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvTacho")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvTacho(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvTacho" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvTacho")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvCPC(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvCPCValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvCPC" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvCPC")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvCPC(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvCPC" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvCPC")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvPpNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvPpNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPpNo" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPpNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvPpNo(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPpNo" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvPpNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveDrvNextOfKin(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Driver>("select * from Driver where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.DrvNextOfKinValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvNextOfKin" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvNextOfKin")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackDrvNextOfKin(Driver obj) {
			
		if(DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvNextOfKin" ).Any()) {
			foreach(var itm in DS.GetManager<Driver>().OnChange.Where(f=> f.Key == "DrvNextOfKin")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Driver>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=17 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/Driver/Search/" + FirstSearch);
		
		return Redirect("/Driver/List/");
	}

}

public partial class DriverRepository : DSRepository<Driver> {
	public DriverRepository() : base(17, "Driver", "Drivers") {
	}
}
public partial class Driver 
: DatasetBase<Driver>, IDSBase

  {
	  public int KeyValue => DrvIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "DrvId":
			return DrvIdField;
				case "DrvName":
			return DrvNameField;
				case "DrvVehicle":
			return DrvVehicleField;
				case "DrvSDate":
			return DrvSDateField;
				case "DrvActive":
			return DrvActiveField;
				case "DrvPspExpiry":
			return DrvPspExpiryField;
				case "DrvMobile":
			return DrvMobileField;
				case "DrvAddress":
			return DrvAddressField;
				case "DrvDoB":
			return DrvDoBField;
				case "DrvEmpStart":
			return DrvEmpStartField;
				case "DrvLicense":
			return DrvLicenseField;
				case "DrvTacho":
			return DrvTachoField;
				case "DrvCPC":
			return DrvCPCField;
				case "DrvPpNo":
			return DrvPpNoField;
				case "DrvNextOfKin":
			return DrvNextOfKinField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(DrvId,DrvIdField);
				action(DrvName,DrvNameField);
				action(DrvVehicle,DrvVehicleField);
				action(DrvSDate,DrvSDateField);
				action(DrvActive,DrvActiveField);
				action(DrvPspExpiry,DrvPspExpiryField);
				action(DrvMobile,DrvMobileField);
				action(DrvAddress,DrvAddressField);
				action(DrvDoB,DrvDoBField);
				action(DrvEmpStart,DrvEmpStartField);
				action(DrvLicense,DrvLicenseField);
				action(DrvTacho,DrvTachoField);
				action(DrvCPC,DrvCPCField);
				action(DrvPpNo,DrvPpNoField);
				action(DrvNextOfKin,DrvNextOfKinField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				DrvId.Visible=false;DrvName.Visible=false;DrvVehicle.Visible=false;DrvSDate.Visible=false;DrvActive.Visible=false;DrvPspExpiry.Visible=false;DrvMobile.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Driver set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (DrvId.HasChanged && DrvId.HasValue) {
					SQL += ", DrvId=@DrvIdValue";

				}
								if (DrvName.HasChanged && DrvName.HasValue) {
					SQL += ", DrvName=@DrvNameValue";

				}
								if (DrvVehicle.HasChanged && DrvVehicle.HasValue) {
					SQL += ", DrvVehicle=@DrvVehicleValue";

				}
								if (DrvSDate.HasChanged && DrvSDate.HasValue) {
					SQL += ", DrvSDate=@DrvSDateValue";

				}
								if (DrvActive.HasChanged && DrvActive.HasValue) {
					SQL += ", DrvActive=@DrvActiveValue";

				}
								if (DrvPspExpiry.HasChanged && DrvPspExpiry.HasValue) {
					SQL += ", DrvPspExpiry=@DrvPspExpiryValue";

				}
								if (DrvMobile.HasChanged && DrvMobile.HasValue) {
					SQL += ", DrvMobile=@DrvMobileValue";

				}
								if (DrvAddress.HasChanged && DrvAddress.HasValue) {
					SQL += ", DrvAddress=@DrvAddressValue";

				}
								if (DrvDoB.HasChanged && DrvDoB.HasValue) {
					SQL += ", DrvDoB=@DrvDoBValue";

				}
								if (DrvEmpStart.HasChanged && DrvEmpStart.HasValue) {
					SQL += ", DrvEmpStart=@DrvEmpStartValue";

				}
								if (DrvLicense.HasChanged && DrvLicense.HasValue) {
					SQL += ", DrvLicense=@DrvLicenseValue";

				}
								if (DrvTacho.HasChanged && DrvTacho.HasValue) {
					SQL += ", DrvTacho=@DrvTachoValue";

				}
								if (DrvCPC.HasChanged && DrvCPC.HasValue) {
					SQL += ", DrvCPC=@DrvCPCValue";

				}
								if (DrvPpNo.HasChanged && DrvPpNo.HasValue) {
					SQL += ", DrvPpNo=@DrvPpNoValue";

				}
								if (DrvNextOfKin.HasChanged && DrvNextOfKin.HasValue) {
					SQL += ", DrvNextOfKin=@DrvNextOfKinValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									DrvId.HasChanged = false;
									DrvName.HasChanged = false;
									DrvVehicle.HasChanged = false;
									DrvSDate.HasChanged = false;
									DrvActive.HasChanged = false;
									DrvPspExpiry.HasChanged = false;
									DrvMobile.HasChanged = false;
									DrvAddress.HasChanged = false;
									DrvDoB.HasChanged = false;
									DrvEmpStart.HasChanged = false;
									DrvLicense.HasChanged = false;
									DrvTacho.HasChanged = false;
									DrvCPC.HasChanged = false;
									DrvPpNo.HasChanged = false;
									DrvNextOfKin.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Driver(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				DrvId.Value = IQApp.DB.GetInt("select isnull(max(DrvId),0)+1 from Driver");
				if (DrvId.HasValue) {
					SQL += ", DrvId";
					Values += ", @DrvIdValue";
				}
				
				if (DrvName.HasValue) {
					SQL += ", DrvName";
					Values += ", @DrvNameValue";
				}
				
				if (DrvVehicle.HasValue) {
					SQL += ", DrvVehicle";
					Values += ", @DrvVehicleValue";
				}
				
				if (DrvSDate.HasValue) {
					SQL += ", DrvSDate";
					Values += ", @DrvSDateValue";
				}
				
				if (DrvActive.HasValue) {
					SQL += ", DrvActive";
					Values += ", @DrvActiveValue";
				}
				
				if (DrvPspExpiry.HasValue) {
					SQL += ", DrvPspExpiry";
					Values += ", @DrvPspExpiryValue";
				}
				
				if (DrvMobile.HasValue) {
					SQL += ", DrvMobile";
					Values += ", @DrvMobileValue";
				}
				
				if (DrvAddress.HasValue) {
					SQL += ", DrvAddress";
					Values += ", @DrvAddressValue";
				}
				
				if (DrvDoB.HasValue) {
					SQL += ", DrvDoB";
					Values += ", @DrvDoBValue";
				}
				
				if (DrvEmpStart.HasValue) {
					SQL += ", DrvEmpStart";
					Values += ", @DrvEmpStartValue";
				}
				
				if (DrvLicense.HasValue) {
					SQL += ", DrvLicense";
					Values += ", @DrvLicenseValue";
				}
				
				if (DrvTacho.HasValue) {
					SQL += ", DrvTacho";
					Values += ", @DrvTachoValue";
				}
				
				if (DrvCPC.HasValue) {
					SQL += ", DrvCPC";
					Values += ", @DrvCPCValue";
				}
				
				if (DrvPpNo.HasValue) {
					SQL += ", DrvPpNo";
					Values += ", @DrvPpNoValue";
				}
				
				if (DrvNextOfKin.HasValue) {
					SQL += ", DrvNextOfKin";
					Values += ", @DrvNextOfKinValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Driver");
					 IQApp.DB.Execute(SQL, this);
				                    					DrvId.HasChanged = false;
									DrvName.HasChanged = false;
									DrvVehicle.HasChanged = false;
									DrvSDate.HasChanged = false;
									DrvActive.HasChanged = false;
									DrvPspExpiry.HasChanged = false;
									DrvMobile.HasChanged = false;
									DrvAddress.HasChanged = false;
									DrvDoB.HasChanged = false;
									DrvEmpStart.HasChanged = false;
									DrvLicense.HasChanged = false;
									DrvTacho.HasChanged = false;
									DrvCPC.HasChanged = false;
									DrvPpNo.HasChanged = false;
									DrvNextOfKin.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "DrvId":
					return (IDSFieldBase)DrvId;
								case "DrvName":
					return (IDSFieldBase)DrvName;
								case "DrvVehicle":
					return (IDSFieldBase)DrvVehicle;
								case "DrvSDate":
					return (IDSFieldBase)DrvSDate;
								case "DrvActive":
					return (IDSFieldBase)DrvActive;
								case "DrvPspExpiry":
					return (IDSFieldBase)DrvPspExpiry;
								case "DrvMobile":
					return (IDSFieldBase)DrvMobile;
								case "DrvAddress":
					return (IDSFieldBase)DrvAddress;
								case "DrvDoB":
					return (IDSFieldBase)DrvDoB;
								case "DrvEmpStart":
					return (IDSFieldBase)DrvEmpStart;
								case "DrvLicense":
					return (IDSFieldBase)DrvLicense;
								case "DrvTacho":
					return (IDSFieldBase)DrvTacho;
								case "DrvCPC":
					return (IDSFieldBase)DrvCPC;
								case "DrvPpNo":
					return (IDSFieldBase)DrvPpNo;
								case "DrvNextOfKin":
					return (IDSFieldBase)DrvNextOfKin;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "DrvId":
					return DrvId.DisplayValue;
								case "DrvName":
					return DrvName.DisplayValue;
								case "DrvVehicle":
					return DrvVehicle.DisplayValue;
								case "DrvSDate":
					return DrvSDate.DisplayValue;
								case "DrvActive":
					return DrvActive.DisplayValue;
								case "DrvPspExpiry":
					return DrvPspExpiry.DisplayValue;
								case "DrvMobile":
					return DrvMobile.DisplayValue;
								case "DrvAddress":
					return DrvAddress.DisplayValue;
								case "DrvDoB":
					return DrvDoB.DisplayValue;
								case "DrvEmpStart":
					return DrvEmpStart.DisplayValue;
								case "DrvLicense":
					return DrvLicense.DisplayValue;
								case "DrvTacho":
					return DrvTacho.DisplayValue;
								case "DrvCPC":
					return DrvCPC.DisplayValue;
								case "DrvPpNo":
					return DrvPpNo.DisplayValue;
								case "DrvNextOfKin":
					return DrvNextOfKin.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "DrvId":
					return DrvId.Value.ToString();
								case "DrvName":
					return DrvName.Value.ToString();
								case "DrvVehicle":
					return DrvVehicle.Value.ToString();
								case "DrvSDate":
					return DrvSDate.Value.ToString();
								case "DrvActive":
					return DrvActive.Value.ToString();
								case "DrvPspExpiry":
					return DrvPspExpiry.Value.ToString();
								case "DrvMobile":
					return DrvMobile.Value.ToString();
								case "DrvAddress":
					return DrvAddress.Value.ToString();
								case "DrvDoB":
					return DrvDoB.Value.ToString();
								case "DrvEmpStart":
					return DrvEmpStart.Value.ToString();
								case "DrvLicense":
					return DrvLicense.Value.ToString();
								case "DrvTacho":
					return DrvTacho.Value.ToString();
								case "DrvCPC":
					return DrvCPC.Value.ToString();
								case "DrvPpNo":
					return DrvPpNo.Value.ToString();
								case "DrvNextOfKin":
					return DrvNextOfKin.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								scrns.Add(new DriverHrs_ListScreen());
								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<Driver>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		        private List<DriverHrs> _ChildDriverHrs;
        public List<DriverHrs> DriverHrss
        {
            get
            {
                if (_ChildDriverHrs == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildDriverHrs = IQApp.DB.Load<DriverHrs>("select * from DriverHrs where DrvHDriver=@itm",new { itm= this.DrvId.Value}).ToList();
				
                }
                return _ChildDriverHrs;
            }set {}
        }
        public int DriverHrsCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from DriverHrs where DrvHDriver=@itm", new { itm= this.DrvId.Value}));
            }
			set {}
        }
     
	
	public Driver () : base("Driver") {
		base.obj = this;
	
					DrvId = new Driver_DrvId(this);
					DrvName = new Driver_DrvName(this);
					DrvVehicle = new Driver_DrvVehicle(this);
					DrvSDate = new Driver_DrvSDate(this);
					DrvActive = new Driver_DrvActive(this);
					DrvPspExpiry = new Driver_DrvPspExpiry(this);
					DrvMobile = new Driver_DrvMobile(this);
					DrvAddress = new Driver_DrvAddress(this);
					DrvDoB = new Driver_DrvDoB(this);
					DrvEmpStart = new Driver_DrvEmpStart(this);
					DrvLicense = new Driver_DrvLicense(this);
					DrvTacho = new Driver_DrvTacho(this);
					DrvCPC = new Driver_DrvCPC(this);
					DrvPpNo = new Driver_DrvPpNo(this);
					DrvNextOfKin = new Driver_DrvNextOfKin(this);
			}

	static Driver () {
					DrvIdField = new Driver_DrvIdFieldDef();
					DrvNameField = new Driver_DrvNameFieldDef();
					DrvVehicleField = new Driver_DrvVehicleFieldDef();
					DrvSDateField = new Driver_DrvSDateFieldDef();
					DrvActiveField = new Driver_DrvActiveFieldDef();
					DrvPspExpiryField = new Driver_DrvPspExpiryFieldDef();
					DrvMobileField = new Driver_DrvMobileFieldDef();
					DrvAddressField = new Driver_DrvAddressFieldDef();
					DrvDoBField = new Driver_DrvDoBFieldDef();
					DrvEmpStartField = new Driver_DrvEmpStartFieldDef();
					DrvLicenseField = new Driver_DrvLicenseFieldDef();
					DrvTachoField = new Driver_DrvTachoFieldDef();
					DrvCPCField = new Driver_DrvCPCFieldDef();
					DrvPpNoField = new Driver_DrvPpNoFieldDef();
					DrvNextOfKinField = new Driver_DrvNextOfKinFieldDef();
			}

	public string RecordTitle { 
		get { return DrvNameValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Drivers"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Driver/Load/?RecId=" + RecordID.Value;
			}
			return "/Driver/Add";
			}
	}

			
		
		[Ignore()]
		public Driver_DrvId DrvId { get; set; }
		public static Driver_DrvIdFieldDef DrvIdField { get; private set; }
        
			
			[Column("DrvId")]
			public  int PopulateDrvId  {
				get { return DrvIdValue ;}
				set { DrvId.DataValue = value; }
			}

	
			public int DrvIdValue 
			{ 
				get 
				{
				   if(DrvId.Value != null) {
				   					int i = 0;
					if (DrvId != null)
					{
						if (DrvId.Value != null)
						{
							if (Int32.TryParse(DrvId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DrvId.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvName DrvName { get; set; }
		public static Driver_DrvNameFieldDef DrvNameField { get; private set; }
        
			
			[Column("DrvName")]
			public  string PopulateDrvName  {
				get { return DrvNameValue ;}
				set { DrvName.DataValue = value; }
			}

	
			public string DrvNameValue 
			{ 
				get 
				{
				   if(DrvName.Value != null) {
				   return DrvName.Value.ToString(); 					}
					return "";
                
				}
				set { DrvName.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvVehicle DrvVehicle { get; set; }
		public static Driver_DrvVehicleFieldDef DrvVehicleField { get; private set; }
        
			
			[Column("DrvVehicle")]
			public  string PopulateDrvVehicle  {
				get { return DrvVehicleValue ;}
				set { DrvVehicle.DataValue = value; }
			}

	
			public string DrvVehicleValue 
			{ 
				get 
				{
				   if(DrvVehicle.Value != null) {
				   return DrvVehicle.Value.ToString(); 					}
					return "";
                
				}
				set { DrvVehicle.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvSDate DrvSDate { get; set; }
		public static Driver_DrvSDateFieldDef DrvSDateField { get; private set; }
        
			
			[Column("DrvSDate")]
			public  int PopulateDrvSDate  {
				get { return DrvSDateValue ;}
				set { DrvSDate.DataValue = value; }
			}

	
			public int DrvSDateValue 
			{ 
				get 
				{
				   if(DrvSDate.Value != null) {
				   					int i = 0;
					if (DrvSDate != null)
					{
						if (DrvSDate.Value != null)
						{
							if (Int32.TryParse(DrvSDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { DrvSDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvActive DrvActive { get; set; }
		public static Driver_DrvActiveFieldDef DrvActiveField { get; private set; }
        
			
			[Column("DrvActive")]
			public  bool PopulateDrvActive  {
				get { return DrvActiveValue ;}
				set { DrvActive.DataValue = value; }
			}

	
			public bool DrvActiveValue 
			{ 
				get 
				{
				   if(DrvActive.Value != null) {
				   					bool i = false;
					if (DrvActive != null)
					{
						if (DrvActive.Value != null)
						{
							if (Boolean.TryParse(DrvActive.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { DrvActive.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvPspExpiry DrvPspExpiry { get; set; }
		public static Driver_DrvPspExpiryFieldDef DrvPspExpiryField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("DrvPspExpiry")]
			public  DateTime PopulateDrvPspExpiry  {
				get { return DrvPspExpiryValue ;}
				set { DrvPspExpiry.DataValue = value; }
			}

	
			public DateTime DrvPspExpiryValue 
			{ 
				get 
				{
				   if(DrvPspExpiry.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (DrvPspExpiry != null)
					{
						if (DrvPspExpiry.Value != null)
						{
							if (DateTime.TryParse(DrvPspExpiry.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { DrvPspExpiry.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvMobile DrvMobile { get; set; }
		public static Driver_DrvMobileFieldDef DrvMobileField { get; private set; }
        
			
			[Column("DrvMobile")]
			public  string PopulateDrvMobile  {
				get { return DrvMobileValue ;}
				set { DrvMobile.DataValue = value; }
			}

	
			public string DrvMobileValue 
			{ 
				get 
				{
				   if(DrvMobile.Value != null) {
				   return DrvMobile.Value.ToString(); 					}
					return "";
                
				}
				set { DrvMobile.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvAddress DrvAddress { get; set; }
		public static Driver_DrvAddressFieldDef DrvAddressField { get; private set; }
        
			
			[Column("DrvAddress")]
			public  string PopulateDrvAddress  {
				get { return DrvAddressValue ;}
				set { DrvAddress.DataValue = value; }
			}

	
			public string DrvAddressValue 
			{ 
				get 
				{
				   if(DrvAddress.Value != null) {
				   return DrvAddress.Value.ToString(); 					}
					return "";
                
				}
				set { DrvAddress.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvDoB DrvDoB { get; set; }
		public static Driver_DrvDoBFieldDef DrvDoBField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("DrvDoB")]
			public  DateTime PopulateDrvDoB  {
				get { return DrvDoBValue ;}
				set { DrvDoB.DataValue = value; }
			}

	
			public DateTime DrvDoBValue 
			{ 
				get 
				{
				   if(DrvDoB.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (DrvDoB != null)
					{
						if (DrvDoB.Value != null)
						{
							if (DateTime.TryParse(DrvDoB.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { DrvDoB.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvEmpStart DrvEmpStart { get; set; }
		public static Driver_DrvEmpStartFieldDef DrvEmpStartField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("DrvEmpStart")]
			public  DateTime PopulateDrvEmpStart  {
				get { return DrvEmpStartValue ;}
				set { DrvEmpStart.DataValue = value; }
			}

	
			public DateTime DrvEmpStartValue 
			{ 
				get 
				{
				   if(DrvEmpStart.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (DrvEmpStart != null)
					{
						if (DrvEmpStart.Value != null)
						{
							if (DateTime.TryParse(DrvEmpStart.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { DrvEmpStart.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvLicense DrvLicense { get; set; }
		public static Driver_DrvLicenseFieldDef DrvLicenseField { get; private set; }
        
			
			[Column("DrvLicense")]
			public  string PopulateDrvLicense  {
				get { return DrvLicenseValue ;}
				set { DrvLicense.DataValue = value; }
			}

	
			public string DrvLicenseValue 
			{ 
				get 
				{
				   if(DrvLicense.Value != null) {
				   return DrvLicense.Value.ToString(); 					}
					return "";
                
				}
				set { DrvLicense.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvTacho DrvTacho { get; set; }
		public static Driver_DrvTachoFieldDef DrvTachoField { get; private set; }
        
			
			[Column("DrvTacho")]
			public  string PopulateDrvTacho  {
				get { return DrvTachoValue ;}
				set { DrvTacho.DataValue = value; }
			}

	
			public string DrvTachoValue 
			{ 
				get 
				{
				   if(DrvTacho.Value != null) {
				   return DrvTacho.Value.ToString(); 					}
					return "";
                
				}
				set { DrvTacho.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvCPC DrvCPC { get; set; }
		public static Driver_DrvCPCFieldDef DrvCPCField { get; private set; }
        
			
			[Column("DrvCPC")]
			public  string PopulateDrvCPC  {
				get { return DrvCPCValue ;}
				set { DrvCPC.DataValue = value; }
			}

	
			public string DrvCPCValue 
			{ 
				get 
				{
				   if(DrvCPC.Value != null) {
				   return DrvCPC.Value.ToString(); 					}
					return "";
                
				}
				set { DrvCPC.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvPpNo DrvPpNo { get; set; }
		public static Driver_DrvPpNoFieldDef DrvPpNoField { get; private set; }
        
			
			[Column("DrvPpNo")]
			public  string PopulateDrvPpNo  {
				get { return DrvPpNoValue ;}
				set { DrvPpNo.DataValue = value; }
			}

	
			public string DrvPpNoValue 
			{ 
				get 
				{
				   if(DrvPpNo.Value != null) {
				   return DrvPpNo.Value.ToString(); 					}
					return "";
                
				}
				set { DrvPpNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Driver_DrvNextOfKin DrvNextOfKin { get; set; }
		public static Driver_DrvNextOfKinFieldDef DrvNextOfKinField { get; private set; }
        
			
			[Column("DrvNextOfKin")]
			public  string PopulateDrvNextOfKin  {
				get { return DrvNextOfKinValue ;}
				set { DrvNextOfKin.DataValue = value; }
			}

	
			public string DrvNextOfKinValue 
			{ 
				get 
				{
				   if(DrvNextOfKin.Value != null) {
				   return DrvNextOfKin.Value.ToString(); 					}
					return "";
                
				}
				set { DrvNextOfKin.Value = value;  }
			}
	}


public class Driver_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 17;
    public int PixelHeight => 0;
	public string Title => "Drivers";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
