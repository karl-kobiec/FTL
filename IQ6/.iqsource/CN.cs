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


public partial class CNController : DSBaseController<CN/*,CNSearch*/> {
	public CNController() : base ((IDatabase)IQApp.DB, new CNRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select CNId from CN where RecordID=@RecId", new { RecId = RecId});

					int count = 0;
						count += IQApp.DB.GetInt("select count(*) from CNLine where CNLNo=@Val", new { Val = Key});
						if(count > 0) {
				return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
			}
		
		string Msg = "Are you sure you want to delete this record?";
				
				Msg += " This will also delete any existing sub records.";
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<CN>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(CN data) {
											IQApp.DB.Execute("delete from CNLine where CNLNo=@Val", new { Val = data.CNIdValue});
										IQApp.DB.Execute("Delete from CN where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.CNIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from CN " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from CN " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from CN " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/CN_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<CN>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<CN>("select * from CN  ").ToList();
		string urlpath = "/temp/Credit Notes Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Credit Notes");
				
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
					worksheet.Cells[1, 1].Value = "Credit Number";
						
								
					worksheet.Column(2).Width = 26;
					worksheet.Cells[1, 2].Value = "Import or Export";
						
								
					worksheet.Column(3).Width = 22;
					worksheet.Cells[1, 3].Value = "Job Number";
						
								
					worksheet.Column(4).Width = 17;
					worksheet.Cells[1, 4].Value = "Order Number";
						
								
					worksheet.Column(5).Width = 17;
					worksheet.Cells[1, 5].Value = "Credit Date";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].CNId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].CNImpExp.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].CNJobNo.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].CNOrder.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].CNDate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNId" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNId(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNId" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNImpExp(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNImpExpValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNImpExp" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNImpExp")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNImpExp(CN m, int? id, string q) {

		
		string s = m.CNImpExp.DataSource;
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
	public ActionResult CallbackCNImpExp(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNImpExp" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNImpExp")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNJobNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNJobNo(CN m, int? id, string q) {

		
		string s = m.CNJobNo.DataSource;
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
	public ActionResult CallbackCNJobNo(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNOrder" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNOrder(CN m, int? id, string q) {

		
		string s = m.CNOrder.DataSource;
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
	public ActionResult CallbackCNOrder(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNOrder" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNVehicle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNVehicleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVehicle")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNVehicle(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVehicle" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVehicle")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNTrailer(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNTrailerValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTrailer" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTrailer")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNTrailer(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTrailer" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTrailer")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNRouteFrom(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNRouteFromValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteFrom" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteFrom")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNRouteFrom(CN m, int? id, string q) {

		
		string s = m.CNRouteFrom.DataSource;
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
	public ActionResult CallbackCNRouteFrom(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteFrom" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteFrom")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNRouteTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNRouteToValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteTo" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNRouteTo(CN m, int? id, string q) {

		
		string s = m.CNRouteTo.DataSource;
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
	public ActionResult CallbackCNRouteTo(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteTo" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNRouteTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNToValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTo" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNTo(CN m, int? id, string q) {

		
		string s = m.CNTo.DataSource;
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
	public ActionResult CallbackCNTo(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTo" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNToId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNToIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToId" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNToId(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToId" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDesc" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNDesc(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDesc" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNNet(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNNetValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNet" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNet")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNNet(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNet" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNet")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNVAT(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNVATValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVAT" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVAT")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNVAT(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVAT" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNVAT")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNTotal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNTotalValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTotal" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTotal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNTotal(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTotal" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNTotal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNNote1(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNNote1Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote1" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote1")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNNote1(CN m, int? id, string q) {

		
		string s = m.CNNote1.DataSource;
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
	public ActionResult CallbackCNNote1(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote1" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote1")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNNote2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNNote2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote2" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNNote2(CN m, int? id, string q) {

		
		string s = m.CNNote2.DataSource;
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
	public ActionResult CallbackCNNote2(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote2" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNNote2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDate" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNDate(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDate" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNPrintBatch(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNPrintBatchValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNPrintBatch" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNPrintBatch")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNPrintBatch(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNPrintBatch" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNPrintBatch")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNJobLetter(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNJobLetterValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobLetter")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNJobLetter(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobLetter" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNJobLetter")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNToExport(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNToExportValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToExport" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToExport")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNToExport(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToExport" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNToExport")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNExported(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNExportedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExported" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExported")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNExported(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExported" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExported")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNCustOrd(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNCustOrdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCustOrd")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNCustOrd(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCustOrd")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNDutyCN(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNDutyCNValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDutyCN" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDutyCN")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNDutyCN(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDutyCN" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNDutyCN")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNCurr(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNCurrValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCurr" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCurr")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNCurr(CN m, int? id, string q) {

		
		string s = m.CNCurr.DataSource;
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
	public ActionResult CallbackCNCurr(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCurr" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNCurr")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNExchRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNExchRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExchRate" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExchRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNExchRate(CN obj) {
			
		if(DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExchRate" ).Any()) {
			foreach(var itm in DS.GetManager<CN>().OnChange.Where(f=> f.Key == "CNExchRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CN>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=8 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/CN/Search/" + FirstSearch);
		
		return Redirect("/CN/List/");
	}

}

public partial class CNRepository : DSRepository<CN> {
	public CNRepository() : base(8, "CN", "Credit Notes") {
	}
}
public partial class CN 
: DatasetBase<CN>, IDSBase

  {
	  public int KeyValue => CNIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "CNId":
			return CNIdField;
				case "CNImpExp":
			return CNImpExpField;
				case "CNJobNo":
			return CNJobNoField;
				case "CNOrder":
			return CNOrderField;
				case "CNVehicle":
			return CNVehicleField;
				case "CNTrailer":
			return CNTrailerField;
				case "CNRouteFrom":
			return CNRouteFromField;
				case "CNRouteTo":
			return CNRouteToField;
				case "CNTo":
			return CNToField;
				case "CNToId":
			return CNToIdField;
				case "CNDesc":
			return CNDescField;
				case "CNNet":
			return CNNetField;
				case "CNVAT":
			return CNVATField;
				case "CNTotal":
			return CNTotalField;
				case "CNNote1":
			return CNNote1Field;
				case "CNNote2":
			return CNNote2Field;
				case "CNDate":
			return CNDateField;
				case "CNPrintBatch":
			return CNPrintBatchField;
				case "CNJobLetter":
			return CNJobLetterField;
				case "CNToExport":
			return CNToExportField;
				case "CNExported":
			return CNExportedField;
				case "CNCustOrd":
			return CNCustOrdField;
				case "CNDutyCN":
			return CNDutyCNField;
				case "CNCurr":
			return CNCurrField;
				case "CNExchRate":
			return CNExchRateField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(CNId,CNIdField);
				action(CNImpExp,CNImpExpField);
				action(CNJobNo,CNJobNoField);
				action(CNOrder,CNOrderField);
				action(CNVehicle,CNVehicleField);
				action(CNTrailer,CNTrailerField);
				action(CNRouteFrom,CNRouteFromField);
				action(CNRouteTo,CNRouteToField);
				action(CNTo,CNToField);
				action(CNToId,CNToIdField);
				action(CNDesc,CNDescField);
				action(CNNet,CNNetField);
				action(CNVAT,CNVATField);
				action(CNTotal,CNTotalField);
				action(CNNote1,CNNote1Field);
				action(CNNote2,CNNote2Field);
				action(CNDate,CNDateField);
				action(CNPrintBatch,CNPrintBatchField);
				action(CNJobLetter,CNJobLetterField);
				action(CNToExport,CNToExportField);
				action(CNExported,CNExportedField);
				action(CNCustOrd,CNCustOrdField);
				action(CNDutyCN,CNDutyCNField);
				action(CNCurr,CNCurrField);
				action(CNExchRate,CNExchRateField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				CNId.Visible=false;CNImpExp.Visible=false;CNJobNo.Visible=false;CNOrder.Visible=false;CNVehicle.Visible=false;CNTrailer.Visible=false;CNRouteFrom.Visible=false;CNRouteTo.Visible=false;CNTo.Visible=false;CNToId.Visible=false;CNDesc.Visible=false;CNNet.Visible=false;CNVAT.Visible=false;CNTotal.Visible=false;CNNote1.Visible=false;CNNote2.Visible=false;CNDate.Visible=false;CNPrintBatch.Visible=false;CNJobLetter.Visible=false;CNToExport.Visible=false;CNExported.Visible=false;CNCustOrd.Visible=false;CNDutyCN.Visible=false;CNCurr.Visible=false;CNExchRate.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update CN set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (CNId.HasChanged && CNId.HasValue) {
					SQL += ", CNId=@CNIdValue";

				}
								if (CNImpExp.HasChanged && CNImpExp.HasValue) {
					SQL += ", CNImpExp=@CNImpExpValue";

				}
								if (CNJobNo.HasChanged && CNJobNo.HasValue) {
					SQL += ", CNJobNo=@CNJobNoValue";

				}
								if (CNOrder.HasChanged && CNOrder.HasValue) {
					SQL += ", CNOrder=@CNOrderValue";

				}
								if (CNVehicle.HasChanged && CNVehicle.HasValue) {
					SQL += ", CNVehicle=@CNVehicleValue";

				}
								if (CNTrailer.HasChanged && CNTrailer.HasValue) {
					SQL += ", CNTrailer=@CNTrailerValue";

				}
								if (CNRouteFrom.HasChanged && CNRouteFrom.HasValue) {
					SQL += ", CNRouteFrom=@CNRouteFromValue";

				}
								if (CNRouteTo.HasChanged && CNRouteTo.HasValue) {
					SQL += ", CNRouteTo=@CNRouteToValue";

				}
								if (CNTo.HasChanged && CNTo.HasValue) {
					SQL += ", CNTo=@CNToValue";

				}
								if (CNToId.HasChanged && CNToId.HasValue) {
					SQL += ", CNToId=@CNToIdValue";

				}
								if (CNDesc.HasChanged && CNDesc.HasValue) {
					SQL += ", CNDesc=@CNDescValue";

				}
								if (CNNet.HasChanged && CNNet.HasValue) {
					SQL += ", CNNet=@CNNetValue";

				}
								if (CNVAT.HasChanged && CNVAT.HasValue) {
					SQL += ", CNVAT=@CNVATValue";

				}
								if (CNTotal.HasChanged && CNTotal.HasValue) {
					SQL += ", CNTotal=@CNTotalValue";

				}
								if (CNNote1.HasChanged && CNNote1.HasValue) {
					SQL += ", CNNote1=@CNNote1Value";

				}
								if (CNNote2.HasChanged && CNNote2.HasValue) {
					SQL += ", CNNote2=@CNNote2Value";

				}
								if (CNDate.HasChanged && CNDate.HasValue) {
					SQL += ", CNDate=@CNDateValue";

				}
								if (CNPrintBatch.HasChanged && CNPrintBatch.HasValue) {
					SQL += ", CNPrintBatch=@CNPrintBatchValue";

				}
								if (CNJobLetter.HasChanged && CNJobLetter.HasValue) {
					SQL += ", CNJobLetter=@CNJobLetterValue";

				}
								if (CNToExport.HasChanged && CNToExport.HasValue) {
					SQL += ", CNToExport=@CNToExportValue";

				}
								if (CNExported.HasChanged && CNExported.HasValue) {
					SQL += ", CNExported=@CNExportedValue";

				}
								if (CNCustOrd.HasChanged && CNCustOrd.HasValue) {
					SQL += ", CNCustOrd=@CNCustOrdValue";

				}
								if (CNDutyCN.HasChanged && CNDutyCN.HasValue) {
					SQL += ", CNDutyCN=@CNDutyCNValue";

				}
								if (CNCurr.HasChanged && CNCurr.HasValue) {
					SQL += ", CNCurr=@CNCurrValue";

				}
								if (CNExchRate.HasChanged && CNExchRate.HasValue) {
					SQL += ", CNExchRate=@CNExchRateValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									CNId.HasChanged = false;
									CNImpExp.HasChanged = false;
									CNJobNo.HasChanged = false;
									CNOrder.HasChanged = false;
									CNVehicle.HasChanged = false;
									CNTrailer.HasChanged = false;
									CNRouteFrom.HasChanged = false;
									CNRouteTo.HasChanged = false;
									CNTo.HasChanged = false;
									CNToId.HasChanged = false;
									CNDesc.HasChanged = false;
									CNNet.HasChanged = false;
									CNVAT.HasChanged = false;
									CNTotal.HasChanged = false;
									CNNote1.HasChanged = false;
									CNNote2.HasChanged = false;
									CNDate.HasChanged = false;
									CNPrintBatch.HasChanged = false;
									CNJobLetter.HasChanged = false;
									CNToExport.HasChanged = false;
									CNExported.HasChanged = false;
									CNCustOrd.HasChanged = false;
									CNDutyCN.HasChanged = false;
									CNCurr.HasChanged = false;
									CNExchRate.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into CN(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (CNId.HasValue) {
					SQL += ", CNId";
					Values += ", @CNIdValue";
				}
				
				if (CNImpExp.HasValue) {
					SQL += ", CNImpExp";
					Values += ", @CNImpExpValue";
				}
				
				if (CNJobNo.HasValue) {
					SQL += ", CNJobNo";
					Values += ", @CNJobNoValue";
				}
				
				if (CNOrder.HasValue) {
					SQL += ", CNOrder";
					Values += ", @CNOrderValue";
				}
				
				if (CNVehicle.HasValue) {
					SQL += ", CNVehicle";
					Values += ", @CNVehicleValue";
				}
				
				if (CNTrailer.HasValue) {
					SQL += ", CNTrailer";
					Values += ", @CNTrailerValue";
				}
				
				if (CNRouteFrom.HasValue) {
					SQL += ", CNRouteFrom";
					Values += ", @CNRouteFromValue";
				}
				
				if (CNRouteTo.HasValue) {
					SQL += ", CNRouteTo";
					Values += ", @CNRouteToValue";
				}
				
				if (CNTo.HasValue) {
					SQL += ", CNTo";
					Values += ", @CNToValue";
				}
				
				if (CNToId.HasValue) {
					SQL += ", CNToId";
					Values += ", @CNToIdValue";
				}
				
				if (CNDesc.HasValue) {
					SQL += ", CNDesc";
					Values += ", @CNDescValue";
				}
				
				if (CNNet.HasValue) {
					SQL += ", CNNet";
					Values += ", @CNNetValue";
				}
				
				if (CNVAT.HasValue) {
					SQL += ", CNVAT";
					Values += ", @CNVATValue";
				}
				
				if (CNTotal.HasValue) {
					SQL += ", CNTotal";
					Values += ", @CNTotalValue";
				}
				
				if (CNNote1.HasValue) {
					SQL += ", CNNote1";
					Values += ", @CNNote1Value";
				}
				
				if (CNNote2.HasValue) {
					SQL += ", CNNote2";
					Values += ", @CNNote2Value";
				}
				
				if (CNDate.HasValue) {
					SQL += ", CNDate";
					Values += ", @CNDateValue";
				}
				
				if (CNPrintBatch.HasValue) {
					SQL += ", CNPrintBatch";
					Values += ", @CNPrintBatchValue";
				}
				
				if (CNJobLetter.HasValue) {
					SQL += ", CNJobLetter";
					Values += ", @CNJobLetterValue";
				}
				
				if (CNToExport.HasValue) {
					SQL += ", CNToExport";
					Values += ", @CNToExportValue";
				}
				
				if (CNExported.HasValue) {
					SQL += ", CNExported";
					Values += ", @CNExportedValue";
				}
				
				if (CNCustOrd.HasValue) {
					SQL += ", CNCustOrd";
					Values += ", @CNCustOrdValue";
				}
				
				if (CNDutyCN.HasValue) {
					SQL += ", CNDutyCN";
					Values += ", @CNDutyCNValue";
				}
				
				if (CNCurr.HasValue) {
					SQL += ", CNCurr";
					Values += ", @CNCurrValue";
				}
				
				if (CNExchRate.HasValue) {
					SQL += ", CNExchRate";
					Values += ", @CNExchRateValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from CN");
					 IQApp.DB.Execute(SQL, this);
				                    					CNId.HasChanged = false;
									CNImpExp.HasChanged = false;
									CNJobNo.HasChanged = false;
									CNOrder.HasChanged = false;
									CNVehicle.HasChanged = false;
									CNTrailer.HasChanged = false;
									CNRouteFrom.HasChanged = false;
									CNRouteTo.HasChanged = false;
									CNTo.HasChanged = false;
									CNToId.HasChanged = false;
									CNDesc.HasChanged = false;
									CNNet.HasChanged = false;
									CNVAT.HasChanged = false;
									CNTotal.HasChanged = false;
									CNNote1.HasChanged = false;
									CNNote2.HasChanged = false;
									CNDate.HasChanged = false;
									CNPrintBatch.HasChanged = false;
									CNJobLetter.HasChanged = false;
									CNToExport.HasChanged = false;
									CNExported.HasChanged = false;
									CNCustOrd.HasChanged = false;
									CNDutyCN.HasChanged = false;
									CNCurr.HasChanged = false;
									CNExchRate.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "CNId":
					return (IDSFieldBase)CNId;
								case "CNImpExp":
					return (IDSFieldBase)CNImpExp;
								case "CNJobNo":
					return (IDSFieldBase)CNJobNo;
								case "CNOrder":
					return (IDSFieldBase)CNOrder;
								case "CNVehicle":
					return (IDSFieldBase)CNVehicle;
								case "CNTrailer":
					return (IDSFieldBase)CNTrailer;
								case "CNRouteFrom":
					return (IDSFieldBase)CNRouteFrom;
								case "CNRouteTo":
					return (IDSFieldBase)CNRouteTo;
								case "CNTo":
					return (IDSFieldBase)CNTo;
								case "CNToId":
					return (IDSFieldBase)CNToId;
								case "CNDesc":
					return (IDSFieldBase)CNDesc;
								case "CNNet":
					return (IDSFieldBase)CNNet;
								case "CNVAT":
					return (IDSFieldBase)CNVAT;
								case "CNTotal":
					return (IDSFieldBase)CNTotal;
								case "CNNote1":
					return (IDSFieldBase)CNNote1;
								case "CNNote2":
					return (IDSFieldBase)CNNote2;
								case "CNDate":
					return (IDSFieldBase)CNDate;
								case "CNPrintBatch":
					return (IDSFieldBase)CNPrintBatch;
								case "CNJobLetter":
					return (IDSFieldBase)CNJobLetter;
								case "CNToExport":
					return (IDSFieldBase)CNToExport;
								case "CNExported":
					return (IDSFieldBase)CNExported;
								case "CNCustOrd":
					return (IDSFieldBase)CNCustOrd;
								case "CNDutyCN":
					return (IDSFieldBase)CNDutyCN;
								case "CNCurr":
					return (IDSFieldBase)CNCurr;
								case "CNExchRate":
					return (IDSFieldBase)CNExchRate;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "CNId":
					return CNId.DisplayValue;
								case "CNImpExp":
					return CNImpExp.DisplayValue;
								case "CNJobNo":
					return CNJobNo.DisplayValue;
								case "CNOrder":
					return CNOrder.DisplayValue;
								case "CNVehicle":
					return CNVehicle.DisplayValue;
								case "CNTrailer":
					return CNTrailer.DisplayValue;
								case "CNRouteFrom":
					return CNRouteFrom.DisplayValue;
								case "CNRouteTo":
					return CNRouteTo.DisplayValue;
								case "CNTo":
					return CNTo.DisplayValue;
								case "CNToId":
					return CNToId.DisplayValue;
								case "CNDesc":
					return CNDesc.DisplayValue;
								case "CNNet":
					return CNNet.DisplayValue;
								case "CNVAT":
					return CNVAT.DisplayValue;
								case "CNTotal":
					return CNTotal.DisplayValue;
								case "CNNote1":
					return CNNote1.DisplayValue;
								case "CNNote2":
					return CNNote2.DisplayValue;
								case "CNDate":
					return CNDate.DisplayValue;
								case "CNPrintBatch":
					return CNPrintBatch.DisplayValue;
								case "CNJobLetter":
					return CNJobLetter.DisplayValue;
								case "CNToExport":
					return CNToExport.DisplayValue;
								case "CNExported":
					return CNExported.DisplayValue;
								case "CNCustOrd":
					return CNCustOrd.DisplayValue;
								case "CNDutyCN":
					return CNDutyCN.DisplayValue;
								case "CNCurr":
					return CNCurr.DisplayValue;
								case "CNExchRate":
					return CNExchRate.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "CNId":
					return CNId.Value.ToString();
								case "CNImpExp":
					return CNImpExp.Value.ToString();
								case "CNJobNo":
					return CNJobNo.Value.ToString();
								case "CNOrder":
					return CNOrder.Value.ToString();
								case "CNVehicle":
					return CNVehicle.Value.ToString();
								case "CNTrailer":
					return CNTrailer.Value.ToString();
								case "CNRouteFrom":
					return CNRouteFrom.Value.ToString();
								case "CNRouteTo":
					return CNRouteTo.Value.ToString();
								case "CNTo":
					return CNTo.Value.ToString();
								case "CNToId":
					return CNToId.Value.ToString();
								case "CNDesc":
					return CNDesc.Value.ToString();
								case "CNNet":
					return CNNet.Value.ToString();
								case "CNVAT":
					return CNVAT.Value.ToString();
								case "CNTotal":
					return CNTotal.Value.ToString();
								case "CNNote1":
					return CNNote1.Value.ToString();
								case "CNNote2":
					return CNNote2.Value.ToString();
								case "CNDate":
					return CNDate.Value.ToString();
								case "CNPrintBatch":
					return CNPrintBatch.Value.ToString();
								case "CNJobLetter":
					return CNJobLetter.Value.ToString();
								case "CNToExport":
					return CNToExport.Value.ToString();
								case "CNExported":
					return CNExported.Value.ToString();
								case "CNCustOrd":
					return CNCustOrd.Value.ToString();
								case "CNDutyCN":
					return CNDutyCN.Value.ToString();
								case "CNCurr":
					return CNCurr.Value.ToString();
								case "CNExchRate":
					return CNExchRate.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								scrns.Add(new CNLine_ListScreen());
								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<CN>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		        private List<CNLine> _ChildCNLine;
        public List<CNLine> CNLines
        {
            get
            {
                if (_ChildCNLine == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildCNLine = IQApp.DB.Load<CNLine>("select * from CNLine where CNLNo=@itm",new { itm= this.CNId.Value}).ToList();
				
                }
                return _ChildCNLine;
            }set {}
        }
        public int CNLineCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CNLine where CNLNo=@itm", new { itm= this.CNId.Value}));
            }
			set {}
        }
     
	
	public CN () : base("CN") {
		base.obj = this;
	
					CNId = new CN_CNId(this);
					CNImpExp = new CN_CNImpExp(this);
					CNJobNo = new CN_CNJobNo(this);
					CNOrder = new CN_CNOrder(this);
					CNVehicle = new CN_CNVehicle(this);
					CNTrailer = new CN_CNTrailer(this);
					CNRouteFrom = new CN_CNRouteFrom(this);
					CNRouteTo = new CN_CNRouteTo(this);
					CNTo = new CN_CNTo(this);
					CNToId = new CN_CNToId(this);
					CNDesc = new CN_CNDesc(this);
					CNNet = new CN_CNNet(this);
					CNVAT = new CN_CNVAT(this);
					CNTotal = new CN_CNTotal(this);
					CNNote1 = new CN_CNNote1(this);
					CNNote2 = new CN_CNNote2(this);
					CNDate = new CN_CNDate(this);
					CNPrintBatch = new CN_CNPrintBatch(this);
					CNJobLetter = new CN_CNJobLetter(this);
					CNToExport = new CN_CNToExport(this);
					CNExported = new CN_CNExported(this);
					CNCustOrd = new CN_CNCustOrd(this);
					CNDutyCN = new CN_CNDutyCN(this);
					CNCurr = new CN_CNCurr(this);
					CNExchRate = new CN_CNExchRate(this);
			}

	static CN () {
					CNIdField = new CN_CNIdFieldDef();
					CNImpExpField = new CN_CNImpExpFieldDef();
					CNJobNoField = new CN_CNJobNoFieldDef();
					CNOrderField = new CN_CNOrderFieldDef();
					CNVehicleField = new CN_CNVehicleFieldDef();
					CNTrailerField = new CN_CNTrailerFieldDef();
					CNRouteFromField = new CN_CNRouteFromFieldDef();
					CNRouteToField = new CN_CNRouteToFieldDef();
					CNToField = new CN_CNToFieldDef();
					CNToIdField = new CN_CNToIdFieldDef();
					CNDescField = new CN_CNDescFieldDef();
					CNNetField = new CN_CNNetFieldDef();
					CNVATField = new CN_CNVATFieldDef();
					CNTotalField = new CN_CNTotalFieldDef();
					CNNote1Field = new CN_CNNote1FieldDef();
					CNNote2Field = new CN_CNNote2FieldDef();
					CNDateField = new CN_CNDateFieldDef();
					CNPrintBatchField = new CN_CNPrintBatchFieldDef();
					CNJobLetterField = new CN_CNJobLetterFieldDef();
					CNToExportField = new CN_CNToExportFieldDef();
					CNExportedField = new CN_CNExportedFieldDef();
					CNCustOrdField = new CN_CNCustOrdFieldDef();
					CNDutyCNField = new CN_CNDutyCNFieldDef();
					CNCurrField = new CN_CNCurrFieldDef();
					CNExchRateField = new CN_CNExchRateFieldDef();
			}

	public string RecordTitle { 
		get { return CNIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Credit Notes"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/CN/Load/?RecId=" + RecordID.Value;
			}
			return "/CN/Add";
			}
	}

			
		
		[Ignore()]
		public CN_CNId CNId { get; set; }
		public static CN_CNIdFieldDef CNIdField { get; private set; }
        
			
			[Column("CNId")]
			public  int PopulateCNId  {
				get { return CNIdValue ;}
				set { CNId.DataValue = value; }
			}

	
			public int CNIdValue 
			{ 
				get 
				{
				   if(CNId.Value != null) {
				   					int i = 0;
					if (CNId != null)
					{
						if (CNId.Value != null)
						{
							if (Int32.TryParse(CNId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNId.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNImpExp CNImpExp { get; set; }
		public static CN_CNImpExpFieldDef CNImpExpField { get; private set; }
        
			
			[Column("CNImpExp")]
			public  string PopulateCNImpExp  {
				get { return CNImpExpValue ;}
				set { CNImpExp.DataValue = value; }
			}

	
			public string CNImpExpValue 
			{ 
				get 
				{
				   if(CNImpExp.Value != null) {
				   return CNImpExp.Value.ToString(); 					}
					return "";
                
				}
				set { CNImpExp.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNJobNo CNJobNo { get; set; }
		public static CN_CNJobNoFieldDef CNJobNoField { get; private set; }
        
			
			[Column("CNJobNo")]
			public  int PopulateCNJobNo  {
				get { return CNJobNoValue ;}
				set { CNJobNo.DataValue = value; }
			}

	
			public int CNJobNoValue 
			{ 
				get 
				{
				   if(CNJobNo.Value != null) {
				   					int i = 0;
					if (CNJobNo != null)
					{
						if (CNJobNo.Value != null)
						{
							if (Int32.TryParse(CNJobNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNOrder CNOrder { get; set; }
		public static CN_CNOrderFieldDef CNOrderField { get; private set; }
        
			
			[Column("CNOrder")]
			public  int PopulateCNOrder  {
				get { return CNOrderValue ;}
				set { CNOrder.DataValue = value; }
			}

	
			public int CNOrderValue 
			{ 
				get 
				{
				   if(CNOrder.Value != null) {
				   					int i = 0;
					if (CNOrder != null)
					{
						if (CNOrder.Value != null)
						{
							if (Int32.TryParse(CNOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNVehicle CNVehicle { get; set; }
		public static CN_CNVehicleFieldDef CNVehicleField { get; private set; }
        
			
			[Column("CNVehicle")]
			public  string PopulateCNVehicle  {
				get { return CNVehicleValue ;}
				set { CNVehicle.DataValue = value; }
			}

	
			public string CNVehicleValue 
			{ 
				get 
				{
				   if(CNVehicle.Value != null) {
				   return CNVehicle.Value.ToString(); 					}
					return "";
                
				}
				set { CNVehicle.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNTrailer CNTrailer { get; set; }
		public static CN_CNTrailerFieldDef CNTrailerField { get; private set; }
        
			
			[Column("CNTrailer")]
			public  string PopulateCNTrailer  {
				get { return CNTrailerValue ;}
				set { CNTrailer.DataValue = value; }
			}

	
			public string CNTrailerValue 
			{ 
				get 
				{
				   if(CNTrailer.Value != null) {
				   return CNTrailer.Value.ToString(); 					}
					return "";
                
				}
				set { CNTrailer.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNRouteFrom CNRouteFrom { get; set; }
		public static CN_CNRouteFromFieldDef CNRouteFromField { get; private set; }
        
			
			[Column("CNRouteFrom")]
			public  int PopulateCNRouteFrom  {
				get { return CNRouteFromValue ;}
				set { CNRouteFrom.DataValue = value; }
			}

	
			public int CNRouteFromValue 
			{ 
				get 
				{
				   if(CNRouteFrom.Value != null) {
				   					int i = 0;
					if (CNRouteFrom != null)
					{
						if (CNRouteFrom.Value != null)
						{
							if (Int32.TryParse(CNRouteFrom.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNRouteFrom.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNRouteTo CNRouteTo { get; set; }
		public static CN_CNRouteToFieldDef CNRouteToField { get; private set; }
        
			
			[Column("CNRouteTo")]
			public  int PopulateCNRouteTo  {
				get { return CNRouteToValue ;}
				set { CNRouteTo.DataValue = value; }
			}

	
			public int CNRouteToValue 
			{ 
				get 
				{
				   if(CNRouteTo.Value != null) {
				   					int i = 0;
					if (CNRouteTo != null)
					{
						if (CNRouteTo.Value != null)
						{
							if (Int32.TryParse(CNRouteTo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNRouteTo.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNTo CNTo { get; set; }
		public static CN_CNToFieldDef CNToField { get; private set; }
        
			
			[Column("CNTo")]
			public  int PopulateCNTo  {
				get { return CNToValue ;}
				set { CNTo.DataValue = value; }
			}

	
			public int CNToValue 
			{ 
				get 
				{
				   if(CNTo.Value != null) {
				   					int i = 0;
					if (CNTo != null)
					{
						if (CNTo.Value != null)
						{
							if (Int32.TryParse(CNTo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNTo.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNToId CNToId { get; set; }
		public static CN_CNToIdFieldDef CNToIdField { get; private set; }
        
			
			[Column("CNToId")]
			public  int PopulateCNToId  {
				get { return CNToIdValue ;}
				set { CNToId.DataValue = value; }
			}

	
			public int CNToIdValue 
			{ 
				get 
				{
				   if(CNToId.Value != null) {
				   					int i = 0;
					if (CNToId != null)
					{
						if (CNToId.Value != null)
						{
							if (Int32.TryParse(CNToId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNToId.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNDesc CNDesc { get; set; }
		public static CN_CNDescFieldDef CNDescField { get; private set; }
        
			
			[Column("CNDesc")]
			public  string PopulateCNDesc  {
				get { return CNDescValue ;}
				set { CNDesc.DataValue = value; }
			}

	
			public string CNDescValue 
			{ 
				get 
				{
				   if(CNDesc.Value != null) {
				   return CNDesc.Value.ToString(); 					}
					return "";
                
				}
				set { CNDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNNet CNNet { get; set; }
		public static CN_CNNetFieldDef CNNetField { get; private set; }
        
			
			[Column("CNNet")]
			public  double PopulateCNNet  {
				get { return CNNetValue ;}
				set { CNNet.DataValue = value; }
			}

	
			public double CNNetValue 
			{ 
				get 
				{
				   if(CNNet.Value != null) {
				   					double i = 0.0;
					if (CNNet != null)
					{
						if (CNNet.Value != null)
						{
							if (Double.TryParse(CNNet.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNNet.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNVAT CNVAT { get; set; }
		public static CN_CNVATFieldDef CNVATField { get; private set; }
        
			
			[Column("CNVAT")]
			public  double PopulateCNVAT  {
				get { return CNVATValue ;}
				set { CNVAT.DataValue = value; }
			}

	
			public double CNVATValue 
			{ 
				get 
				{
				   if(CNVAT.Value != null) {
				   					double i = 0.0;
					if (CNVAT != null)
					{
						if (CNVAT.Value != null)
						{
							if (Double.TryParse(CNVAT.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNVAT.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNTotal CNTotal { get; set; }
		public static CN_CNTotalFieldDef CNTotalField { get; private set; }
        
			
			[Column("CNTotal")]
			public  double PopulateCNTotal  {
				get { return CNTotalValue ;}
				set { CNTotal.DataValue = value; }
			}

	
			public double CNTotalValue 
			{ 
				get 
				{
				   if(CNTotal.Value != null) {
				   					double i = 0.0;
					if (CNTotal != null)
					{
						if (CNTotal.Value != null)
						{
							if (Double.TryParse(CNTotal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNTotal.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNNote1 CNNote1 { get; set; }
		public static CN_CNNote1FieldDef CNNote1Field { get; private set; }
        
			
			[Column("CNNote1")]
			public  int PopulateCNNote1  {
				get { return CNNote1Value ;}
				set { CNNote1.DataValue = value; }
			}

	
			public int CNNote1Value 
			{ 
				get 
				{
				   if(CNNote1.Value != null) {
				   					int i = 0;
					if (CNNote1 != null)
					{
						if (CNNote1.Value != null)
						{
							if (Int32.TryParse(CNNote1.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNNote1.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNNote2 CNNote2 { get; set; }
		public static CN_CNNote2FieldDef CNNote2Field { get; private set; }
        
			
			[Column("CNNote2")]
			public  int PopulateCNNote2  {
				get { return CNNote2Value ;}
				set { CNNote2.DataValue = value; }
			}

	
			public int CNNote2Value 
			{ 
				get 
				{
				   if(CNNote2.Value != null) {
				   					int i = 0;
					if (CNNote2 != null)
					{
						if (CNNote2.Value != null)
						{
							if (Int32.TryParse(CNNote2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNNote2.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNDate CNDate { get; set; }
		public static CN_CNDateFieldDef CNDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("CNDate")]
			public  DateTime PopulateCNDate  {
				get { return CNDateValue ;}
				set { CNDate.DataValue = value; }
			}

	
			public DateTime CNDateValue 
			{ 
				get 
				{
				   if(CNDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (CNDate != null)
					{
						if (CNDate.Value != null)
						{
							if (DateTime.TryParse(CNDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { CNDate.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNPrintBatch CNPrintBatch { get; set; }
		public static CN_CNPrintBatchFieldDef CNPrintBatchField { get; private set; }
        
			
			[Column("CNPrintBatch")]
			public  int PopulateCNPrintBatch  {
				get { return CNPrintBatchValue ;}
				set { CNPrintBatch.DataValue = value; }
			}

	
			public int CNPrintBatchValue 
			{ 
				get 
				{
				   if(CNPrintBatch.Value != null) {
				   					int i = 0;
					if (CNPrintBatch != null)
					{
						if (CNPrintBatch.Value != null)
						{
							if (Int32.TryParse(CNPrintBatch.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNPrintBatch.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNJobLetter CNJobLetter { get; set; }
		public static CN_CNJobLetterFieldDef CNJobLetterField { get; private set; }
        
			
			[Column("CNJobLetter")]
			public  string PopulateCNJobLetter  {
				get { return CNJobLetterValue ;}
				set { CNJobLetter.DataValue = value; }
			}

	
			public string CNJobLetterValue 
			{ 
				get 
				{
				   if(CNJobLetter.Value != null) {
				   return CNJobLetter.Value.ToString(); 					}
					return "";
                
				}
				set { CNJobLetter.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNToExport CNToExport { get; set; }
		public static CN_CNToExportFieldDef CNToExportField { get; private set; }
        
			
			[Column("CNToExport")]
			public  bool PopulateCNToExport  {
				get { return CNToExportValue ;}
				set { CNToExport.DataValue = value; }
			}

	
			public bool CNToExportValue 
			{ 
				get 
				{
				   if(CNToExport.Value != null) {
				   					bool i = false;
					if (CNToExport != null)
					{
						if (CNToExport.Value != null)
						{
							if (Boolean.TryParse(CNToExport.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CNToExport.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNExported CNExported { get; set; }
		public static CN_CNExportedFieldDef CNExportedField { get; private set; }
        
			
			[Column("CNExported")]
			public  bool PopulateCNExported  {
				get { return CNExportedValue ;}
				set { CNExported.DataValue = value; }
			}

	
			public bool CNExportedValue 
			{ 
				get 
				{
				   if(CNExported.Value != null) {
				   					bool i = false;
					if (CNExported != null)
					{
						if (CNExported.Value != null)
						{
							if (Boolean.TryParse(CNExported.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CNExported.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNCustOrd CNCustOrd { get; set; }
		public static CN_CNCustOrdFieldDef CNCustOrdField { get; private set; }
        
			
			[Column("CNCustOrd")]
			public  string PopulateCNCustOrd  {
				get { return CNCustOrdValue ;}
				set { CNCustOrd.DataValue = value; }
			}

	
			public string CNCustOrdValue 
			{ 
				get 
				{
				   if(CNCustOrd.Value != null) {
				   return CNCustOrd.Value.ToString(); 					}
					return "";
                
				}
				set { CNCustOrd.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNDutyCN CNDutyCN { get; set; }
		public static CN_CNDutyCNFieldDef CNDutyCNField { get; private set; }
        
			
			[Column("CNDutyCN")]
			public  bool PopulateCNDutyCN  {
				get { return CNDutyCNValue ;}
				set { CNDutyCN.DataValue = value; }
			}

	
			public bool CNDutyCNValue 
			{ 
				get 
				{
				   if(CNDutyCN.Value != null) {
				   					bool i = false;
					if (CNDutyCN != null)
					{
						if (CNDutyCN.Value != null)
						{
							if (Boolean.TryParse(CNDutyCN.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { CNDutyCN.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNCurr CNCurr { get; set; }
		public static CN_CNCurrFieldDef CNCurrField { get; private set; }
        
			
			[Column("CNCurr")]
			public  int PopulateCNCurr  {
				get { return CNCurrValue ;}
				set { CNCurr.DataValue = value; }
			}

	
			public int CNCurrValue 
			{ 
				get 
				{
				   if(CNCurr.Value != null) {
				   					int i = 0;
					if (CNCurr != null)
					{
						if (CNCurr.Value != null)
						{
							if (Int32.TryParse(CNCurr.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNCurr.Value = value;  }
			}
			
		
		[Ignore()]
		public CN_CNExchRate CNExchRate { get; set; }
		public static CN_CNExchRateFieldDef CNExchRateField { get; private set; }
        
			
			[Column("CNExchRate")]
			public  double PopulateCNExchRate  {
				get { return CNExchRateValue ;}
				set { CNExchRate.DataValue = value; }
			}

	
			public double CNExchRateValue 
			{ 
				get 
				{
				   if(CNExchRate.Value != null) {
				   					double i = 0.0;
					if (CNExchRate != null)
					{
						if (CNExchRate.Value != null)
						{
							if (Double.TryParse(CNExchRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNExchRate.Value = value;  }
			}
	}


public class CN_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 8;
    public int PixelHeight => 0;
	public string Title => "Credit Notes";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
