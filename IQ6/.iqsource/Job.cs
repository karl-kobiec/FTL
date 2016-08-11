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


public partial class JobController : DSBaseController<Job/*,JobSearch*/> {
	public JobController() : base ((IDatabase)IQApp.DB, new JobRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select JobId from Job where RecordID=@RecId", new { RecId = RecId});

					int count = 0;
						count += IQApp.DB.GetInt("select count(*) from JobLine where JobLJobNo=@Val", new { Val = Key});
						count += IQApp.DB.GetInt("select count(*) from JobCost where JobCJobNo=@Val", new { Val = Key});
						if(count > 0) {
				return IQJS(IQApp.CR.MessageBoxOK("You cannot delete this record since it has sub records associated with it. Delete all sub records first to be able to delete the main record."));
			}
		
		string Msg = "Are you sure you want to delete this record?";
				
				Msg += " This will also delete any existing sub records.";
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Job>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Job data) {
											IQApp.DB.Execute("delete from JobLine where JobLJobNo=@Val", new { Val = data.JobIdValue});
								IQApp.DB.Execute("delete from JobCost where JobCJobNo=@Val", new { Val = data.JobIdValue});
										IQApp.DB.Execute("Delete from Job where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.JobNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Job " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Job " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Job " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Job_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Job>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Job>("select * from Job  ").ToList();
		string urlpath = "/temp/Jobs Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Jobs");
				
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
							
					worksheet.Column(1).Width = 13;
					worksheet.Cells[1, 1].Value = "Job Number";
						
								
					worksheet.Column(2).Width = 20;
					worksheet.Cells[1, 2].Value = "Transporter";
						
								
					worksheet.Column(3).Width = 13;
					worksheet.Cells[1, 3].Value = "Vehicle Number";
						
								
					worksheet.Column(4).Width = 13;
					worksheet.Cells[1, 4].Value = "Trailer Number";
						
								
					worksheet.Column(5).Width = 20;
					worksheet.Cells[1, 5].Value = "Route From";
						
								
					worksheet.Column(6).Width = 20;
					worksheet.Cells[1, 6].Value = "Route To";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].JobNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].JobTransp.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].JobVehNo.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].JobTrailerNo.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].JobRouteFrom.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].JobRouteTo.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobNo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobNo(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobNo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobTransp(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobTranspValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTransp" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTransp")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobTransp(Job m, int? id, string q) {

		
		string s = m.JobTransp.DataSource;
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
	public ActionResult CallbackJobTransp(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTransp" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTransp")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobTranspRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobTranspRateValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTranspRate" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTranspRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobTranspRate(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTranspRate" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTranspRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobVehNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobVehNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobVehNo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobVehNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobVehNo(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobVehNo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobVehNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobTrailerNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobTrailerNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTrailerNo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTrailerNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobTrailerNo(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTrailerNo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobTrailerNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobFerryName(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobFerryNameValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryName" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryName")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobFerryName(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryName" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryName")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobFerryDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobFerryDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryDate" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobFerryDate(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryDate" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobFerryTime(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					TimeSpan i = TimeSpan.MinValue;
		
			bool UnableToContinue = false;

			if(!TimeSpan.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobFerryTimeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryTime" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryTime")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobFerryTime(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryTime" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobFerryTime")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobRouteFrom(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobRouteFromValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteFrom" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteFrom")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobRouteFrom(Job m, int? id, string q) {

		
		string s = m.JobRouteFrom.DataSource;
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
	public ActionResult CallbackJobRouteFrom(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteFrom" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteFrom")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobRouteTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobRouteToValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteTo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobRouteTo(Job m, int? id, string q) {

		
		string s = m.JobRouteTo.DataSource;
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
	public ActionResult CallbackJobRouteTo(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteTo" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobRouteTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobAccMonth(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobAccMonthValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobAccMonth" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobAccMonth")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobAccMonth(Job m, int? id, string q) {

		
		string s = m.JobAccMonth.DataSource;
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
	public ActionResult CallbackJobAccMonth(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobAccMonth" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobAccMonth")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobChecked(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobCheckedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobChecked" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobChecked")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobChecked(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobChecked" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobChecked")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCreatedBy(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobCreatedByValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobCreatedBy" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobCreatedBy")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobCreatedBy(Job m, int? id, string q) {

		
		string s = m.JobCreatedBy.DataSource;
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
	public ActionResult CallbackJobCreatedBy(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobCreatedBy" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobCreatedBy")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobId" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobId(Job obj) {
			
		if(DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobId" ).Any()) {
			foreach(var itm in DS.GetManager<Job>().OnChange.Where(f=> f.Key == "JobId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Job>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=4 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/Job/Search/" + FirstSearch);
		
		return Redirect("/Job/List/");
	}

}

public partial class JobRepository : DSRepository<Job> {
	public JobRepository() : base(4, "Job", "Jobs") {
	}
}
public partial class Job 
: DatasetBase<Job>, IDSBase

  {
	  public int KeyValue => JobIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "JobNo":
			return JobNoField;
				case "JobTransp":
			return JobTranspField;
				case "JobTranspRate":
			return JobTranspRateField;
				case "JobVehNo":
			return JobVehNoField;
				case "JobTrailerNo":
			return JobTrailerNoField;
				case "JobFerryName":
			return JobFerryNameField;
				case "JobFerryDate":
			return JobFerryDateField;
				case "JobFerryTime":
			return JobFerryTimeField;
				case "JobRouteFrom":
			return JobRouteFromField;
				case "JobRouteTo":
			return JobRouteToField;
				case "JobAccMonth":
			return JobAccMonthField;
				case "JobChecked":
			return JobCheckedField;
				case "JobCreatedBy":
			return JobCreatedByField;
				case "JobId":
			return JobIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(JobNo,JobNoField);
				action(JobTransp,JobTranspField);
				action(JobTranspRate,JobTranspRateField);
				action(JobVehNo,JobVehNoField);
				action(JobTrailerNo,JobTrailerNoField);
				action(JobFerryName,JobFerryNameField);
				action(JobFerryDate,JobFerryDateField);
				action(JobFerryTime,JobFerryTimeField);
				action(JobRouteFrom,JobRouteFromField);
				action(JobRouteTo,JobRouteToField);
				action(JobAccMonth,JobAccMonthField);
				action(JobChecked,JobCheckedField);
				action(JobCreatedBy,JobCreatedByField);
				action(JobId,JobIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				JobNo.Visible=false;JobTransp.Visible=false;JobTranspRate.Visible=false;JobVehNo.Visible=false;JobTrailerNo.Visible=false;JobFerryName.Visible=false;JobFerryDate.Visible=false;JobFerryTime.Visible=false;JobRouteFrom.Visible=false;JobRouteTo.Visible=false;JobAccMonth.Visible=false;JobChecked.Visible=false;JobCreatedBy.Visible=false;JobId.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Job set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (JobNo.HasChanged && JobNo.HasValue) {
					SQL += ", JobNo=@JobNoValue";

				}
								if (JobTransp.HasChanged && JobTransp.HasValue) {
					SQL += ", JobTransp=@JobTranspValue";

				}
								if (JobTranspRate.HasChanged && JobTranspRate.HasValue) {
					SQL += ", JobTranspRate=@JobTranspRateValue";

				}
								if (JobVehNo.HasChanged && JobVehNo.HasValue) {
					SQL += ", JobVehNo=@JobVehNoValue";

				}
								if (JobTrailerNo.HasChanged && JobTrailerNo.HasValue) {
					SQL += ", JobTrailerNo=@JobTrailerNoValue";

				}
								if (JobFerryName.HasChanged && JobFerryName.HasValue) {
					SQL += ", JobFerryName=@JobFerryNameValue";

				}
								if (JobFerryDate.HasChanged && JobFerryDate.HasValue) {
					SQL += ", JobFerryDate=@JobFerryDateValue";

				}
								if (JobFerryTime.HasChanged && JobFerryTime.HasValue) {
					SQL += ", JobFerryTime=@JobFerryTimeValue";

				}
								if (JobRouteFrom.HasChanged && JobRouteFrom.HasValue) {
					SQL += ", JobRouteFrom=@JobRouteFromValue";

				}
								if (JobRouteTo.HasChanged && JobRouteTo.HasValue) {
					SQL += ", JobRouteTo=@JobRouteToValue";

				}
								if (JobAccMonth.HasChanged && JobAccMonth.HasValue) {
					SQL += ", JobAccMonth=@JobAccMonthValue";

				}
								if (JobChecked.HasChanged && JobChecked.HasValue) {
					SQL += ", JobChecked=@JobCheckedValue";

				}
								if (JobCreatedBy.HasChanged && JobCreatedBy.HasValue) {
					SQL += ", JobCreatedBy=@JobCreatedByValue";

				}
								if (JobId.HasChanged && JobId.HasValue) {
					SQL += ", JobId=@JobIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									JobNo.HasChanged = false;
									JobTransp.HasChanged = false;
									JobTranspRate.HasChanged = false;
									JobVehNo.HasChanged = false;
									JobTrailerNo.HasChanged = false;
									JobFerryName.HasChanged = false;
									JobFerryDate.HasChanged = false;
									JobFerryTime.HasChanged = false;
									JobRouteFrom.HasChanged = false;
									JobRouteTo.HasChanged = false;
									JobAccMonth.HasChanged = false;
									JobChecked.HasChanged = false;
									JobCreatedBy.HasChanged = false;
									JobId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Job(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (JobNo.HasValue) {
					SQL += ", JobNo";
					Values += ", @JobNoValue";
				}
				
				if (JobTransp.HasValue) {
					SQL += ", JobTransp";
					Values += ", @JobTranspValue";
				}
				
				if (JobTranspRate.HasValue) {
					SQL += ", JobTranspRate";
					Values += ", @JobTranspRateValue";
				}
				
				if (JobVehNo.HasValue) {
					SQL += ", JobVehNo";
					Values += ", @JobVehNoValue";
				}
				
				if (JobTrailerNo.HasValue) {
					SQL += ", JobTrailerNo";
					Values += ", @JobTrailerNoValue";
				}
				
				if (JobFerryName.HasValue) {
					SQL += ", JobFerryName";
					Values += ", @JobFerryNameValue";
				}
				
				if (JobFerryDate.HasValue) {
					SQL += ", JobFerryDate";
					Values += ", @JobFerryDateValue";
				}
				
				if (JobFerryTime.HasValue) {
					SQL += ", JobFerryTime";
					Values += ", @JobFerryTimeValue";
				}
				
				if (JobRouteFrom.HasValue) {
					SQL += ", JobRouteFrom";
					Values += ", @JobRouteFromValue";
				}
				
				if (JobRouteTo.HasValue) {
					SQL += ", JobRouteTo";
					Values += ", @JobRouteToValue";
				}
				
				if (JobAccMonth.HasValue) {
					SQL += ", JobAccMonth";
					Values += ", @JobAccMonthValue";
				}
				
				if (JobChecked.HasValue) {
					SQL += ", JobChecked";
					Values += ", @JobCheckedValue";
				}
				
				if (JobCreatedBy.HasValue) {
					SQL += ", JobCreatedBy";
					Values += ", @JobCreatedByValue";
				}
				JobId.Value = IQApp.DB.GetInt("select isnull(max(JobId),0)+1 from Job");
				if (JobId.HasValue) {
					SQL += ", JobId";
					Values += ", @JobIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Job");
					 IQApp.DB.Execute(SQL, this);
				                    					JobNo.HasChanged = false;
									JobTransp.HasChanged = false;
									JobTranspRate.HasChanged = false;
									JobVehNo.HasChanged = false;
									JobTrailerNo.HasChanged = false;
									JobFerryName.HasChanged = false;
									JobFerryDate.HasChanged = false;
									JobFerryTime.HasChanged = false;
									JobRouteFrom.HasChanged = false;
									JobRouteTo.HasChanged = false;
									JobAccMonth.HasChanged = false;
									JobChecked.HasChanged = false;
									JobCreatedBy.HasChanged = false;
									JobId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "JobNo":
					return (IDSFieldBase)JobNo;
								case "JobTransp":
					return (IDSFieldBase)JobTransp;
								case "JobTranspRate":
					return (IDSFieldBase)JobTranspRate;
								case "JobVehNo":
					return (IDSFieldBase)JobVehNo;
								case "JobTrailerNo":
					return (IDSFieldBase)JobTrailerNo;
								case "JobFerryName":
					return (IDSFieldBase)JobFerryName;
								case "JobFerryDate":
					return (IDSFieldBase)JobFerryDate;
								case "JobFerryTime":
					return (IDSFieldBase)JobFerryTime;
								case "JobRouteFrom":
					return (IDSFieldBase)JobRouteFrom;
								case "JobRouteTo":
					return (IDSFieldBase)JobRouteTo;
								case "JobAccMonth":
					return (IDSFieldBase)JobAccMonth;
								case "JobChecked":
					return (IDSFieldBase)JobChecked;
								case "JobCreatedBy":
					return (IDSFieldBase)JobCreatedBy;
								case "JobId":
					return (IDSFieldBase)JobId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "JobNo":
					return JobNo.DisplayValue;
								case "JobTransp":
					return JobTransp.DisplayValue;
								case "JobTranspRate":
					return JobTranspRate.DisplayValue;
								case "JobVehNo":
					return JobVehNo.DisplayValue;
								case "JobTrailerNo":
					return JobTrailerNo.DisplayValue;
								case "JobFerryName":
					return JobFerryName.DisplayValue;
								case "JobFerryDate":
					return JobFerryDate.DisplayValue;
								case "JobFerryTime":
					return JobFerryTime.DisplayValue;
								case "JobRouteFrom":
					return JobRouteFrom.DisplayValue;
								case "JobRouteTo":
					return JobRouteTo.DisplayValue;
								case "JobAccMonth":
					return JobAccMonth.DisplayValue;
								case "JobChecked":
					return JobChecked.DisplayValue;
								case "JobCreatedBy":
					return JobCreatedBy.DisplayValue;
								case "JobId":
					return JobId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "JobNo":
					return JobNo.Value.ToString();
								case "JobTransp":
					return JobTransp.Value.ToString();
								case "JobTranspRate":
					return JobTranspRate.Value.ToString();
								case "JobVehNo":
					return JobVehNo.Value.ToString();
								case "JobTrailerNo":
					return JobTrailerNo.Value.ToString();
								case "JobFerryName":
					return JobFerryName.Value.ToString();
								case "JobFerryDate":
					return JobFerryDate.Value.ToString();
								case "JobFerryTime":
					return JobFerryTime.Value.ToString();
								case "JobRouteFrom":
					return JobRouteFrom.Value.ToString();
								case "JobRouteTo":
					return JobRouteTo.Value.ToString();
								case "JobAccMonth":
					return JobAccMonth.Value.ToString();
								case "JobChecked":
					return JobChecked.Value.ToString();
								case "JobCreatedBy":
					return JobCreatedBy.Value.ToString();
								case "JobId":
					return JobId.Value.ToString();
							}
			return "";
		}
		
		
		public static List<IScreen> DefaultSubForms {
			get {
				List<IScreen> scrns = new List<IScreen>();

								scrns.Add(new JobLine_ListScreen());
								scrns.Add(new JobCost_ListScreen());
								scrns.Add(new CertShip_ListScreen());
								scrns.Add(new CN_ListScreen());
								scrns.Add(new Inv_ListScreen());
								scrns.Add(new Orders_ListScreen());
								scrns.Add(new REDSOrder_ListScreen());
								return scrns;
			}
		}
		private List<IScreen> _CachedSubForms;
		public List<IScreen> CachedSubForms {
			get {
				if(_CachedSubForms == null) {
					_CachedSubForms = DefaultSubForms;
					foreach(var itm in DS.GetManager<Job>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		        private List<JobLine> _ChildJobLine;
        public List<JobLine> JobLines
        {
            get
            {
                if (_ChildJobLine == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildJobLine = IQApp.DB.Load<JobLine>("select * from JobLine where JobLJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildJobLine;
            }set {}
        }
        public int JobLineCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from JobLine where JobLJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	        private List<JobCost> _ChildJobCost;
        public List<JobCost> JobCosts
        {
            get
            {
                if (_ChildJobCost == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildJobCost = IQApp.DB.Load<JobCost>("select * from JobCost where JobCJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildJobCost;
            }set {}
        }
        public int JobCostCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from JobCost where JobCJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	        private List<CertShip> _ChildCertShip;
        public List<CertShip> CertShips
        {
            get
            {
                if (_ChildCertShip == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildCertShip = IQApp.DB.Load<CertShip>("select * from CertShip where CSJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildCertShip;
            }set {}
        }
        public int CertShipCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CertShip where CSJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	        private List<CN> _ChildCN;
        public List<CN> CNs
        {
            get
            {
                if (_ChildCN == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildCN = IQApp.DB.Load<CN>("select * from CN where CNJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildCN;
            }set {}
        }
        public int CNCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from CN where CNJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	        private List<Inv> _ChildInv;
        public List<Inv> Invs
        {
            get
            {
                if (_ChildInv == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildInv = IQApp.DB.Load<Inv>("select * from Inv where InvJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildInv;
            }set {}
        }
        public int InvCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Inv where InvJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	        private List<Orders> _ChildOrders;
        public List<Orders> Orderss
        {
            get
            {
                if (_ChildOrders == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildOrders = IQApp.DB.Load<Orders>("select * from Orders where OrdJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildOrders;
            }set {}
        }
        public int OrdersCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from Orders where OrdJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	        private List<REDSOrder> _ChildREDSOrder;
        public List<REDSOrder> REDSOrders
        {
            get
            {
                if (_ChildREDSOrder == null)
                {
				//MM: Check for User Filter here, maybe needed?
					_ChildREDSOrder = IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RDOrdJobNo=@itm",new { itm= this.JobId.Value}).ToList();
				
                }
                return _ChildREDSOrder;
            }set {}
        }
        public int REDSOrderCount
        {
            get
            {
                return (IQApp.DB.GetInt("select count(*) from REDSOrder where RDOrdJobNo=@itm", new { itm= this.JobId.Value}));
            }
			set {}
        }
     
	
	public Job () : base("Job") {
		base.obj = this;
	
					JobNo = new Job_JobNo(this);
					JobTransp = new Job_JobTransp(this);
					JobTranspRate = new Job_JobTranspRate(this);
					JobVehNo = new Job_JobVehNo(this);
					JobTrailerNo = new Job_JobTrailerNo(this);
					JobFerryName = new Job_JobFerryName(this);
					JobFerryDate = new Job_JobFerryDate(this);
					JobFerryTime = new Job_JobFerryTime(this);
					JobRouteFrom = new Job_JobRouteFrom(this);
					JobRouteTo = new Job_JobRouteTo(this);
					JobAccMonth = new Job_JobAccMonth(this);
					JobChecked = new Job_JobChecked(this);
					JobCreatedBy = new Job_JobCreatedBy(this);
					JobId = new Job_JobId(this);
			}

	static Job () {
					JobNoField = new Job_JobNoFieldDef();
					JobTranspField = new Job_JobTranspFieldDef();
					JobTranspRateField = new Job_JobTranspRateFieldDef();
					JobVehNoField = new Job_JobVehNoFieldDef();
					JobTrailerNoField = new Job_JobTrailerNoFieldDef();
					JobFerryNameField = new Job_JobFerryNameFieldDef();
					JobFerryDateField = new Job_JobFerryDateFieldDef();
					JobFerryTimeField = new Job_JobFerryTimeFieldDef();
					JobRouteFromField = new Job_JobRouteFromFieldDef();
					JobRouteToField = new Job_JobRouteToFieldDef();
					JobAccMonthField = new Job_JobAccMonthFieldDef();
					JobCheckedField = new Job_JobCheckedFieldDef();
					JobCreatedByField = new Job_JobCreatedByFieldDef();
					JobIdField = new Job_JobIdFieldDef();
			}

	public string RecordTitle { 
		get { return JobNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Jobs"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Job/Load/?RecId=" + RecordID.Value;
			}
			return "/Job/Add";
			}
	}

			
		
		[Ignore()]
		public Job_JobNo JobNo { get; set; }
		public static Job_JobNoFieldDef JobNoField { get; private set; }
        
			
			[Column("JobNo")]
			public  string PopulateJobNo  {
				get { return JobNoValue ;}
				set { JobNo.DataValue = value; }
			}

	
			public string JobNoValue 
			{ 
				get 
				{
				   if(JobNo.Value != null) {
				   return JobNo.Value.ToString(); 					}
					return "";
                
				}
				set { JobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobTransp JobTransp { get; set; }
		public static Job_JobTranspFieldDef JobTranspField { get; private set; }
        
			
			[Column("JobTransp")]
			public  int PopulateJobTransp  {
				get { return JobTranspValue ;}
				set { JobTransp.DataValue = value; }
			}

	
			public int JobTranspValue 
			{ 
				get 
				{
				   if(JobTransp.Value != null) {
				   					int i = 0;
					if (JobTransp != null)
					{
						if (JobTransp.Value != null)
						{
							if (Int32.TryParse(JobTransp.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobTransp.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobTranspRate JobTranspRate { get; set; }
		public static Job_JobTranspRateFieldDef JobTranspRateField { get; private set; }
        
			
			[Column("JobTranspRate")]
			public  string PopulateJobTranspRate  {
				get { return JobTranspRateValue ;}
				set { JobTranspRate.DataValue = value; }
			}

	
			public string JobTranspRateValue 
			{ 
				get 
				{
				   if(JobTranspRate.Value != null) {
				   return JobTranspRate.Value.ToString(); 					}
					return "";
                
				}
				set { JobTranspRate.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobVehNo JobVehNo { get; set; }
		public static Job_JobVehNoFieldDef JobVehNoField { get; private set; }
        
			
			[Column("JobVehNo")]
			public  string PopulateJobVehNo  {
				get { return JobVehNoValue ;}
				set { JobVehNo.DataValue = value; }
			}

	
			public string JobVehNoValue 
			{ 
				get 
				{
				   if(JobVehNo.Value != null) {
				   return JobVehNo.Value.ToString(); 					}
					return "";
                
				}
				set { JobVehNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobTrailerNo JobTrailerNo { get; set; }
		public static Job_JobTrailerNoFieldDef JobTrailerNoField { get; private set; }
        
			
			[Column("JobTrailerNo")]
			public  string PopulateJobTrailerNo  {
				get { return JobTrailerNoValue ;}
				set { JobTrailerNo.DataValue = value; }
			}

	
			public string JobTrailerNoValue 
			{ 
				get 
				{
				   if(JobTrailerNo.Value != null) {
				   return JobTrailerNo.Value.ToString(); 					}
					return "";
                
				}
				set { JobTrailerNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobFerryName JobFerryName { get; set; }
		public static Job_JobFerryNameFieldDef JobFerryNameField { get; private set; }
        
			
			[Column("JobFerryName")]
			public  string PopulateJobFerryName  {
				get { return JobFerryNameValue ;}
				set { JobFerryName.DataValue = value; }
			}

	
			public string JobFerryNameValue 
			{ 
				get 
				{
				   if(JobFerryName.Value != null) {
				   return JobFerryName.Value.ToString(); 					}
					return "";
                
				}
				set { JobFerryName.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobFerryDate JobFerryDate { get; set; }
		public static Job_JobFerryDateFieldDef JobFerryDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("JobFerryDate")]
			public  DateTime PopulateJobFerryDate  {
				get { return JobFerryDateValue ;}
				set { JobFerryDate.DataValue = value; }
			}

	
			public DateTime JobFerryDateValue 
			{ 
				get 
				{
				   if(JobFerryDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (JobFerryDate != null)
					{
						if (JobFerryDate.Value != null)
						{
							if (DateTime.TryParse(JobFerryDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { JobFerryDate.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobFerryTime JobFerryTime { get; set; }
		public static Job_JobFerryTimeFieldDef JobFerryTimeField { get; private set; }
        
			
			[Column("JobFerryTime")]
			public  TimeSpan PopulateJobFerryTime  {
				get { return JobFerryTimeValue ;}
				set { JobFerryTime.DataValue = value; }
			}

	
			public TimeSpan JobFerryTimeValue 
			{ 
				get 
				{
				   if(JobFerryTime.Value != null) {
				   					TimeSpan i = TimeSpan.MinValue;
					if (JobFerryTime != null)
					{
						if (JobFerryTime.Value != null)
						{
							if (TimeSpan.TryParse(JobFerryTime.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return TimeSpan.MinValue;
                
				}
				set { JobFerryTime.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobRouteFrom JobRouteFrom { get; set; }
		public static Job_JobRouteFromFieldDef JobRouteFromField { get; private set; }
        
			
			[Column("JobRouteFrom")]
			public  int PopulateJobRouteFrom  {
				get { return JobRouteFromValue ;}
				set { JobRouteFrom.DataValue = value; }
			}

	
			public int JobRouteFromValue 
			{ 
				get 
				{
				   if(JobRouteFrom.Value != null) {
				   					int i = 0;
					if (JobRouteFrom != null)
					{
						if (JobRouteFrom.Value != null)
						{
							if (Int32.TryParse(JobRouteFrom.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobRouteFrom.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobRouteTo JobRouteTo { get; set; }
		public static Job_JobRouteToFieldDef JobRouteToField { get; private set; }
        
			
			[Column("JobRouteTo")]
			public  int PopulateJobRouteTo  {
				get { return JobRouteToValue ;}
				set { JobRouteTo.DataValue = value; }
			}

	
			public int JobRouteToValue 
			{ 
				get 
				{
				   if(JobRouteTo.Value != null) {
				   					int i = 0;
					if (JobRouteTo != null)
					{
						if (JobRouteTo.Value != null)
						{
							if (Int32.TryParse(JobRouteTo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobRouteTo.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobAccMonth JobAccMonth { get; set; }
		public static Job_JobAccMonthFieldDef JobAccMonthField { get; private set; }
        
			
			[Column("JobAccMonth")]
			public  int PopulateJobAccMonth  {
				get { return JobAccMonthValue ;}
				set { JobAccMonth.DataValue = value; }
			}

	
			public int JobAccMonthValue 
			{ 
				get 
				{
				   if(JobAccMonth.Value != null) {
				   					int i = 0;
					if (JobAccMonth != null)
					{
						if (JobAccMonth.Value != null)
						{
							if (Int32.TryParse(JobAccMonth.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobAccMonth.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobChecked JobChecked { get; set; }
		public static Job_JobCheckedFieldDef JobCheckedField { get; private set; }
        
			
			[Column("JobChecked")]
			public  bool PopulateJobChecked  {
				get { return JobCheckedValue ;}
				set { JobChecked.DataValue = value; }
			}

	
			public bool JobCheckedValue 
			{ 
				get 
				{
				   if(JobChecked.Value != null) {
				   					bool i = false;
					if (JobChecked != null)
					{
						if (JobChecked.Value != null)
						{
							if (Boolean.TryParse(JobChecked.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { JobChecked.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobCreatedBy JobCreatedBy { get; set; }
		public static Job_JobCreatedByFieldDef JobCreatedByField { get; private set; }
        
			
			[Column("JobCreatedBy")]
			public  int PopulateJobCreatedBy  {
				get { return JobCreatedByValue ;}
				set { JobCreatedBy.DataValue = value; }
			}

	
			public int JobCreatedByValue 
			{ 
				get 
				{
				   if(JobCreatedBy.Value != null) {
				   					int i = 0;
					if (JobCreatedBy != null)
					{
						if (JobCreatedBy.Value != null)
						{
							if (Int32.TryParse(JobCreatedBy.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobCreatedBy.Value = value;  }
			}
			
		
		[Ignore()]
		public Job_JobId JobId { get; set; }
		public static Job_JobIdFieldDef JobIdField { get; private set; }
        
			
			[Column("JobId")]
			public  int PopulateJobId  {
				get { return JobIdValue ;}
				set { JobId.DataValue = value; }
			}

	
			public int JobIdValue 
			{ 
				get 
				{
				   if(JobId.Value != null) {
				   					int i = 0;
					if (JobId != null)
					{
						if (JobId.Value != null)
						{
							if (Int32.TryParse(JobId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobId.Value = value;  }
			}
	}


public class Job_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 4;
    public int PixelHeight => 0;
	public string Title => "Jobs";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
