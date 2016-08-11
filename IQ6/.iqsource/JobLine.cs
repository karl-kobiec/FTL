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


public partial class JobLineController : DSBaseController<JobLine/*,JobLineSearch*/> {
	public JobLineController() : base ((IDatabase)IQApp.DB, new JobLineRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select JobLJobNo from JobLine where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<JobLine>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(JobLine data) {
						IQApp.DB.Execute("Delete from JobLine where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.JobLJobNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from JobLine " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from JobLine " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from JobLine " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/JobLine_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<JobLine>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<JobLine>("select * from JobLine  ").ToList();
		string urlpath = "/temp/Job Lines Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Job Lines");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 11])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 100;
					worksheet.Cells[1, 1].Value = "Job Number";
						
								
					worksheet.Column(2).Width = 4;
					worksheet.Cells[1, 2].Value = "Line Letter";
						
								
					worksheet.Column(3).Width = 9;
					worksheet.Cells[1, 3].Value = "Order Number";
						
								
					worksheet.Column(4).Width = 18;
					worksheet.Cells[1, 4].Value = "Customer";
						
								
					worksheet.Column(5).Width = 12;
					worksheet.Cells[1, 5].Value = "Collection Date";
						
								
					worksheet.Column(6).Width = 12;
					worksheet.Cells[1, 6].Value = "Collection Date 2";
						
								
					worksheet.Column(7).Width = 9;
					worksheet.Cells[1, 7].Value = "Delivery Point";
						
								
					worksheet.Column(8).Width = 12;
					worksheet.Cells[1, 8].Value = "Delivery Date";
						
								
					worksheet.Column(9).Width = 7;
					worksheet.Cells[1, 9].Value = "Delivery Time";
						
								
					worksheet.Column(10).Width = 18;
					worksheet.Cells[1, 10].Value = "Delivery Ref";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].JobLJobNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].JobLLineLetter.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].JobLOrder.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].JobLCust.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].JobLCollDate.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].JobLCollDate2.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].JobLDelPoint.DisplayValue;
								worksheet.Cells[j+2,8].Value = res[j].JobLDelDate.DisplayValue;
								worksheet.Cells[j+2,9].Value = res[j].JobLDelTime.DisplayValue;
								worksheet.Cells[j+2,10].Value = res[j].JobLDelRef.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobLJobNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobLJobNo(JobLine m, int? id, string q) {

		
		string s = m.JobLJobNo.DataSource;
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
	public ActionResult CallbackJobLJobNo(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLLineLetter(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobLLineLetterValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLLineLetter" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLLineLetter")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLLineLetter(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLLineLetter" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLLineLetter")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobLOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLOrder" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLOrder(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLOrder" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobLCustValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCust" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLCust(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCust" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLCollDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobLCollDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLCollDate(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLCollDate2(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobLCollDate2Value =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate2" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate2")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLCollDate2(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate2" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLCollDate2")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLDelPoint(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobLDelPointValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelPoint" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelPoint")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobLDelPoint(JobLine m, int? id, string q) {

		
		string s = m.JobLDelPoint.DataSource;
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
	public ActionResult CallbackJobLDelPoint(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelPoint" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelPoint")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLDelDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobLDelDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelDate" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLDelDate(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelDate" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLDelTime(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					TimeSpan i = TimeSpan.MinValue;
		
			bool UnableToContinue = false;

			if(!TimeSpan.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobLDelTimeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelTime" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelTime")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLDelTime(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelTime" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelTime")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobLDelRef(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobLine>("select * from JobLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobLDelRefValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelRef" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelRef")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobLDelRef(JobLine obj) {
			
		if(DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelRef" ).Any()) {
			foreach(var itm in DS.GetManager<JobLine>().OnChange.Where(f=> f.Key == "JobLDelRef")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/JobLine/List/");
	}

}

public partial class JobLineRepository : DSRepository<JobLine> {
	public JobLineRepository() : base(5, "JobLine", "Job Lines") {
	}
}
public partial class JobLine 
: DatasetBase<JobLine>, IDSBase

  {
	  public int KeyValue => JobLJobNoValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "JobLJobNo":
			return JobLJobNoField;
				case "JobLLineLetter":
			return JobLLineLetterField;
				case "JobLOrder":
			return JobLOrderField;
				case "JobLCust":
			return JobLCustField;
				case "JobLCollDate":
			return JobLCollDateField;
				case "JobLCollDate2":
			return JobLCollDate2Field;
				case "JobLDelPoint":
			return JobLDelPointField;
				case "JobLDelDate":
			return JobLDelDateField;
				case "JobLDelTime":
			return JobLDelTimeField;
				case "JobLDelRef":
			return JobLDelRefField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(JobLJobNo,JobLJobNoField);
				action(JobLLineLetter,JobLLineLetterField);
				action(JobLOrder,JobLOrderField);
				action(JobLCust,JobLCustField);
				action(JobLCollDate,JobLCollDateField);
				action(JobLCollDate2,JobLCollDate2Field);
				action(JobLDelPoint,JobLDelPointField);
				action(JobLDelDate,JobLDelDateField);
				action(JobLDelTime,JobLDelTimeField);
				action(JobLDelRef,JobLDelRefField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				JobLJobNo.Visible=false;JobLLineLetter.Visible=false;JobLOrder.Visible=false;JobLCust.Visible=false;JobLCollDate.Visible=false;JobLCollDate2.Visible=false;JobLDelPoint.Visible=false;JobLDelDate.Visible=false;JobLDelTime.Visible=false;JobLDelRef.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (JobLJobNo.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Job where JobId=@Key", new {Key= JobLJobNo.Value});
                return 0;
            }
            set
            {
                if (JobLJobNo.Value == null)
                    JobLJobNo.Value = IQApp.DB.GetInt("SELECT JobId FROM Job whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Job _Parent;

        public Job Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Job>("select * from Job where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (Job)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update JobLine set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (JobLJobNo.HasChanged && JobLJobNo.HasValue) {
					SQL += ", JobLJobNo=@JobLJobNoValue";

				}
								if (JobLLineLetter.HasChanged && JobLLineLetter.HasValue) {
					SQL += ", JobLLineLetter=@JobLLineLetterValue";

				}
								if (JobLOrder.HasChanged && JobLOrder.HasValue) {
					SQL += ", JobLOrder=@JobLOrderValue";

				}
								if (JobLCust.HasChanged && JobLCust.HasValue) {
					SQL += ", JobLCust=@JobLCustValue";

				}
								if (JobLCollDate.HasChanged && JobLCollDate.HasValue) {
					SQL += ", JobLCollDate=@JobLCollDateValue";

				}
								if (JobLCollDate2.HasChanged && JobLCollDate2.HasValue) {
					SQL += ", JobLCollDate2=@JobLCollDate2Value";

				}
								if (JobLDelPoint.HasChanged && JobLDelPoint.HasValue) {
					SQL += ", JobLDelPoint=@JobLDelPointValue";

				}
								if (JobLDelDate.HasChanged && JobLDelDate.HasValue) {
					SQL += ", JobLDelDate=@JobLDelDateValue";

				}
								if (JobLDelTime.HasChanged && JobLDelTime.HasValue) {
					SQL += ", JobLDelTime=@JobLDelTimeValue";

				}
								if (JobLDelRef.HasChanged && JobLDelRef.HasValue) {
					SQL += ", JobLDelRef=@JobLDelRefValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									JobLJobNo.HasChanged = false;
									JobLLineLetter.HasChanged = false;
									JobLOrder.HasChanged = false;
									JobLCust.HasChanged = false;
									JobLCollDate.HasChanged = false;
									JobLCollDate2.HasChanged = false;
									JobLDelPoint.HasChanged = false;
									JobLDelDate.HasChanged = false;
									JobLDelTime.HasChanged = false;
									JobLDelRef.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into JobLine(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (JobLJobNo.HasValue) {
					SQL += ", JobLJobNo";
					Values += ", @JobLJobNoValue";
				}
				
				if (JobLLineLetter.HasValue) {
					SQL += ", JobLLineLetter";
					Values += ", @JobLLineLetterValue";
				}
				
				if (JobLOrder.HasValue) {
					SQL += ", JobLOrder";
					Values += ", @JobLOrderValue";
				}
				
				if (JobLCust.HasValue) {
					SQL += ", JobLCust";
					Values += ", @JobLCustValue";
				}
				
				if (JobLCollDate.HasValue) {
					SQL += ", JobLCollDate";
					Values += ", @JobLCollDateValue";
				}
				
				if (JobLCollDate2.HasValue) {
					SQL += ", JobLCollDate2";
					Values += ", @JobLCollDate2Value";
				}
				
				if (JobLDelPoint.HasValue) {
					SQL += ", JobLDelPoint";
					Values += ", @JobLDelPointValue";
				}
				
				if (JobLDelDate.HasValue) {
					SQL += ", JobLDelDate";
					Values += ", @JobLDelDateValue";
				}
				
				if (JobLDelTime.HasValue) {
					SQL += ", JobLDelTime";
					Values += ", @JobLDelTimeValue";
				}
				
				if (JobLDelRef.HasValue) {
					SQL += ", JobLDelRef";
					Values += ", @JobLDelRefValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from JobLine");
					 IQApp.DB.Execute(SQL, this);
				                    					JobLJobNo.HasChanged = false;
									JobLLineLetter.HasChanged = false;
									JobLOrder.HasChanged = false;
									JobLCust.HasChanged = false;
									JobLCollDate.HasChanged = false;
									JobLCollDate2.HasChanged = false;
									JobLDelPoint.HasChanged = false;
									JobLDelDate.HasChanged = false;
									JobLDelTime.HasChanged = false;
									JobLDelRef.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "JobLJobNo":
					return (IDSFieldBase)JobLJobNo;
								case "JobLLineLetter":
					return (IDSFieldBase)JobLLineLetter;
								case "JobLOrder":
					return (IDSFieldBase)JobLOrder;
								case "JobLCust":
					return (IDSFieldBase)JobLCust;
								case "JobLCollDate":
					return (IDSFieldBase)JobLCollDate;
								case "JobLCollDate2":
					return (IDSFieldBase)JobLCollDate2;
								case "JobLDelPoint":
					return (IDSFieldBase)JobLDelPoint;
								case "JobLDelDate":
					return (IDSFieldBase)JobLDelDate;
								case "JobLDelTime":
					return (IDSFieldBase)JobLDelTime;
								case "JobLDelRef":
					return (IDSFieldBase)JobLDelRef;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "JobLJobNo":
					return JobLJobNo.DisplayValue;
								case "JobLLineLetter":
					return JobLLineLetter.DisplayValue;
								case "JobLOrder":
					return JobLOrder.DisplayValue;
								case "JobLCust":
					return JobLCust.DisplayValue;
								case "JobLCollDate":
					return JobLCollDate.DisplayValue;
								case "JobLCollDate2":
					return JobLCollDate2.DisplayValue;
								case "JobLDelPoint":
					return JobLDelPoint.DisplayValue;
								case "JobLDelDate":
					return JobLDelDate.DisplayValue;
								case "JobLDelTime":
					return JobLDelTime.DisplayValue;
								case "JobLDelRef":
					return JobLDelRef.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "JobLJobNo":
					return JobLJobNo.Value.ToString();
								case "JobLLineLetter":
					return JobLLineLetter.Value.ToString();
								case "JobLOrder":
					return JobLOrder.Value.ToString();
								case "JobLCust":
					return JobLCust.Value.ToString();
								case "JobLCollDate":
					return JobLCollDate.Value.ToString();
								case "JobLCollDate2":
					return JobLCollDate2.Value.ToString();
								case "JobLDelPoint":
					return JobLDelPoint.Value.ToString();
								case "JobLDelDate":
					return JobLDelDate.Value.ToString();
								case "JobLDelTime":
					return JobLDelTime.Value.ToString();
								case "JobLDelRef":
					return JobLDelRef.Value.ToString();
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
					foreach(var itm in DS.GetManager<JobLine>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public JobLine () : base("JobLine") {
		base.obj = this;
	
					JobLJobNo = new JobLine_JobLJobNo(this);
					JobLLineLetter = new JobLine_JobLLineLetter(this);
					JobLOrder = new JobLine_JobLOrder(this);
					JobLCust = new JobLine_JobLCust(this);
					JobLCollDate = new JobLine_JobLCollDate(this);
					JobLCollDate2 = new JobLine_JobLCollDate2(this);
					JobLDelPoint = new JobLine_JobLDelPoint(this);
					JobLDelDate = new JobLine_JobLDelDate(this);
					JobLDelTime = new JobLine_JobLDelTime(this);
					JobLDelRef = new JobLine_JobLDelRef(this);
			}

	static JobLine () {
					JobLJobNoField = new JobLine_JobLJobNoFieldDef();
					JobLLineLetterField = new JobLine_JobLLineLetterFieldDef();
					JobLOrderField = new JobLine_JobLOrderFieldDef();
					JobLCustField = new JobLine_JobLCustFieldDef();
					JobLCollDateField = new JobLine_JobLCollDateFieldDef();
					JobLCollDate2Field = new JobLine_JobLCollDate2FieldDef();
					JobLDelPointField = new JobLine_JobLDelPointFieldDef();
					JobLDelDateField = new JobLine_JobLDelDateFieldDef();
					JobLDelTimeField = new JobLine_JobLDelTimeFieldDef();
					JobLDelRefField = new JobLine_JobLDelRefFieldDef();
			}

	public string RecordTitle { 
		get { return JobLJobNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Job Lines"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/JobLine/Load/?RecId=" + RecordID.Value;
			}
			return "/JobLine/Add";
			}
	}

			
		
		[Ignore()]
		public JobLine_JobLJobNo JobLJobNo { get; set; }
		public static JobLine_JobLJobNoFieldDef JobLJobNoField { get; private set; }
        
			
			[Column("JobLJobNo")]
			public  int PopulateJobLJobNo  {
				get { return JobLJobNoValue ;}
				set { JobLJobNo.DataValue = value; }
			}

	
			public int JobLJobNoValue 
			{ 
				get 
				{
				   if(JobLJobNo.Value != null) {
				   					int i = 0;
					if (JobLJobNo != null)
					{
						if (JobLJobNo.Value != null)
						{
							if (Int32.TryParse(JobLJobNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobLJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLLineLetter JobLLineLetter { get; set; }
		public static JobLine_JobLLineLetterFieldDef JobLLineLetterField { get; private set; }
        
			
			[Column("JobLLineLetter")]
			public  string PopulateJobLLineLetter  {
				get { return JobLLineLetterValue ;}
				set { JobLLineLetter.DataValue = value; }
			}

	
			public string JobLLineLetterValue 
			{ 
				get 
				{
				   if(JobLLineLetter.Value != null) {
				   return JobLLineLetter.Value.ToString(); 					}
					return "";
                
				}
				set { JobLLineLetter.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLOrder JobLOrder { get; set; }
		public static JobLine_JobLOrderFieldDef JobLOrderField { get; private set; }
        
			
			[Column("JobLOrder")]
			public  int PopulateJobLOrder  {
				get { return JobLOrderValue ;}
				set { JobLOrder.DataValue = value; }
			}

	
			public int JobLOrderValue 
			{ 
				get 
				{
				   if(JobLOrder.Value != null) {
				   					int i = 0;
					if (JobLOrder != null)
					{
						if (JobLOrder.Value != null)
						{
							if (Int32.TryParse(JobLOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobLOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLCust JobLCust { get; set; }
		public static JobLine_JobLCustFieldDef JobLCustField { get; private set; }
        
			
			[Column("JobLCust")]
			public  string PopulateJobLCust  {
				get { return JobLCustValue ;}
				set { JobLCust.DataValue = value; }
			}

	
			public string JobLCustValue 
			{ 
				get 
				{
				   if(JobLCust.Value != null) {
				   return JobLCust.Value.ToString(); 					}
					return "";
                
				}
				set { JobLCust.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLCollDate JobLCollDate { get; set; }
		public static JobLine_JobLCollDateFieldDef JobLCollDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("JobLCollDate")]
			public  DateTime PopulateJobLCollDate  {
				get { return JobLCollDateValue ;}
				set { JobLCollDate.DataValue = value; }
			}

	
			public DateTime JobLCollDateValue 
			{ 
				get 
				{
				   if(JobLCollDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (JobLCollDate != null)
					{
						if (JobLCollDate.Value != null)
						{
							if (DateTime.TryParse(JobLCollDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { JobLCollDate.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLCollDate2 JobLCollDate2 { get; set; }
		public static JobLine_JobLCollDate2FieldDef JobLCollDate2Field { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("JobLCollDate2")]
			public  DateTime PopulateJobLCollDate2  {
				get { return JobLCollDate2Value ;}
				set { JobLCollDate2.DataValue = value; }
			}

	
			public DateTime JobLCollDate2Value 
			{ 
				get 
				{
				   if(JobLCollDate2.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (JobLCollDate2 != null)
					{
						if (JobLCollDate2.Value != null)
						{
							if (DateTime.TryParse(JobLCollDate2.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { JobLCollDate2.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLDelPoint JobLDelPoint { get; set; }
		public static JobLine_JobLDelPointFieldDef JobLDelPointField { get; private set; }
        
			
			[Column("JobLDelPoint")]
			public  int PopulateJobLDelPoint  {
				get { return JobLDelPointValue ;}
				set { JobLDelPoint.DataValue = value; }
			}

	
			public int JobLDelPointValue 
			{ 
				get 
				{
				   if(JobLDelPoint.Value != null) {
				   					int i = 0;
					if (JobLDelPoint != null)
					{
						if (JobLDelPoint.Value != null)
						{
							if (Int32.TryParse(JobLDelPoint.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobLDelPoint.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLDelDate JobLDelDate { get; set; }
		public static JobLine_JobLDelDateFieldDef JobLDelDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("JobLDelDate")]
			public  DateTime PopulateJobLDelDate  {
				get { return JobLDelDateValue ;}
				set { JobLDelDate.DataValue = value; }
			}

	
			public DateTime JobLDelDateValue 
			{ 
				get 
				{
				   if(JobLDelDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (JobLDelDate != null)
					{
						if (JobLDelDate.Value != null)
						{
							if (DateTime.TryParse(JobLDelDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { JobLDelDate.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLDelTime JobLDelTime { get; set; }
		public static JobLine_JobLDelTimeFieldDef JobLDelTimeField { get; private set; }
        
			
			[Column("JobLDelTime")]
			public  TimeSpan PopulateJobLDelTime  {
				get { return JobLDelTimeValue ;}
				set { JobLDelTime.DataValue = value; }
			}

	
			public TimeSpan JobLDelTimeValue 
			{ 
				get 
				{
				   if(JobLDelTime.Value != null) {
				   					TimeSpan i = TimeSpan.MinValue;
					if (JobLDelTime != null)
					{
						if (JobLDelTime.Value != null)
						{
							if (TimeSpan.TryParse(JobLDelTime.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return TimeSpan.MinValue;
                
				}
				set { JobLDelTime.Value = value;  }
			}
			
		
		[Ignore()]
		public JobLine_JobLDelRef JobLDelRef { get; set; }
		public static JobLine_JobLDelRefFieldDef JobLDelRefField { get; private set; }
        
			
			[Column("JobLDelRef")]
			public  string PopulateJobLDelRef  {
				get { return JobLDelRefValue ;}
				set { JobLDelRef.DataValue = value; }
			}

	
			public string JobLDelRefValue 
			{ 
				get 
				{
				   if(JobLDelRef.Value != null) {
				   return JobLDelRef.Value.ToString(); 					}
					return "";
                
				}
				set { JobLDelRef.Value = value;  }
			}
	}


public class JobLine_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 5;
    public int PixelHeight => 0;
	public string Title => "Job Lines";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
