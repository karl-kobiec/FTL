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


public partial class JobCostController : DSBaseController<JobCost/*,JobCostSearch*/> {
	public JobCostController() : base ((IDatabase)IQApp.DB, new JobCostRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select JobCJobNo from JobCost where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<JobCost>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(JobCost data) {
						IQApp.DB.Execute("Delete from JobCost where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.JobCJobNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from JobCost " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from JobCost " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from JobCost " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/JobCost_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<JobCost>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<JobCost>("select * from JobCost  ").ToList();
		string urlpath = "/temp/Job Costs Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Job Costs");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 8])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 11;
					worksheet.Cells[1, 1].Value = "Job Number";
						
								
					worksheet.Column(2).Width = 11;
					worksheet.Cells[1, 2].Value = "Service Provider Id";
						
								
					worksheet.Column(3).Width = 22;
					worksheet.Cells[1, 3].Value = "Service Provider";
						
								
					worksheet.Column(4).Width = 24;
					worksheet.Cells[1, 4].Value = "Description";
						
								
					worksheet.Column(5).Width = 11;
					worksheet.Cells[1, 5].Value = "Invoice Amount";
						
								
					worksheet.Column(6).Width = 11;
					worksheet.Cells[1, 6].Value = "Invoice Number";
						
								
					worksheet.Column(7).Width = 11;
					worksheet.Cells[1, 7].Value = "Invoice Date";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].JobCJobNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].JobCServProvId.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].JobCServProv.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].JobCDesc.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].JobCInvAmt.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].JobCInvNo.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].JobCInvDate.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobCJobNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobCJobNo(JobCost m, int? id, string q) {

		
		string s = m.JobCJobNo.DataSource;
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
	public ActionResult CallbackJobCJobNo(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCServProvId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobCServProvIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProvId" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProvId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobCServProvId(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProvId" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProvId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCServProv(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.JobCServProvValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProv" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProv")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteJobCServProv(JobCost m, int? id, string q) {

		
		string s = m.JobCServProv.DataSource;
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
	public ActionResult CallbackJobCServProv(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProv" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCServProv")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobCDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCDesc" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobCDesc(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCDesc" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCInvAmt(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobCInvAmtValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvAmt" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvAmt")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobCInvAmt(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvAmt" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvAmt")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCInvNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.JobCInvNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvNo" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobCInvNo(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvNo" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveJobCInvDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<JobCost>("select * from JobCost where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.JobCInvDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvDate" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackJobCInvDate(JobCost obj) {
			
		if(DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvDate" ).Any()) {
			foreach(var itm in DS.GetManager<JobCost>().OnChange.Where(f=> f.Key == "JobCInvDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<JobCost>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/JobCost/List/");
	}

}

public partial class JobCostRepository : DSRepository<JobCost> {
	public JobCostRepository() : base(14, "JobCost", "Job Costs") {
	}
}
public partial class JobCost 
: DatasetBase<JobCost>, IDSBase

  {
	  public int KeyValue => JobCJobNoValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "JobCJobNo":
			return JobCJobNoField;
				case "JobCServProvId":
			return JobCServProvIdField;
				case "JobCServProv":
			return JobCServProvField;
				case "JobCDesc":
			return JobCDescField;
				case "JobCInvAmt":
			return JobCInvAmtField;
				case "JobCInvNo":
			return JobCInvNoField;
				case "JobCInvDate":
			return JobCInvDateField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(JobCJobNo,JobCJobNoField);
				action(JobCServProvId,JobCServProvIdField);
				action(JobCServProv,JobCServProvField);
				action(JobCDesc,JobCDescField);
				action(JobCInvAmt,JobCInvAmtField);
				action(JobCInvNo,JobCInvNoField);
				action(JobCInvDate,JobCInvDateField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				JobCJobNo.Visible=false;JobCServProvId.Visible=false;JobCServProv.Visible=false;JobCDesc.Visible=false;JobCInvAmt.Visible=false;JobCInvNo.Visible=false;JobCInvDate.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (JobCJobNo.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Job where JobId=@Key", new {Key= JobCJobNo.Value});
                return 0;
            }
            set
            {
                if (JobCJobNo.Value == null)
                    JobCJobNo.Value = IQApp.DB.GetInt("SELECT JobId FROM Job whereRecordID=@RecId", new { RecId = value});
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
                string SQL = "update JobCost set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (JobCJobNo.HasChanged && JobCJobNo.HasValue) {
					SQL += ", JobCJobNo=@JobCJobNoValue";

				}
								if (JobCServProvId.HasChanged && JobCServProvId.HasValue) {
					SQL += ", JobCServProvId=@JobCServProvIdValue";

				}
								if (JobCServProv.HasChanged && JobCServProv.HasValue) {
					SQL += ", JobCServProv=@JobCServProvValue";

				}
								if (JobCDesc.HasChanged && JobCDesc.HasValue) {
					SQL += ", JobCDesc=@JobCDescValue";

				}
								if (JobCInvAmt.HasChanged && JobCInvAmt.HasValue) {
					SQL += ", JobCInvAmt=@JobCInvAmtValue";

				}
								if (JobCInvNo.HasChanged && JobCInvNo.HasValue) {
					SQL += ", JobCInvNo=@JobCInvNoValue";

				}
								if (JobCInvDate.HasChanged && JobCInvDate.HasValue) {
					SQL += ", JobCInvDate=@JobCInvDateValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									JobCJobNo.HasChanged = false;
									JobCServProvId.HasChanged = false;
									JobCServProv.HasChanged = false;
									JobCDesc.HasChanged = false;
									JobCInvAmt.HasChanged = false;
									JobCInvNo.HasChanged = false;
									JobCInvDate.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into JobCost(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (JobCJobNo.HasValue) {
					SQL += ", JobCJobNo";
					Values += ", @JobCJobNoValue";
				}
				
				if (JobCServProvId.HasValue) {
					SQL += ", JobCServProvId";
					Values += ", @JobCServProvIdValue";
				}
				
				if (JobCServProv.HasValue) {
					SQL += ", JobCServProv";
					Values += ", @JobCServProvValue";
				}
				
				if (JobCDesc.HasValue) {
					SQL += ", JobCDesc";
					Values += ", @JobCDescValue";
				}
				
				if (JobCInvAmt.HasValue) {
					SQL += ", JobCInvAmt";
					Values += ", @JobCInvAmtValue";
				}
				
				if (JobCInvNo.HasValue) {
					SQL += ", JobCInvNo";
					Values += ", @JobCInvNoValue";
				}
				
				if (JobCInvDate.HasValue) {
					SQL += ", JobCInvDate";
					Values += ", @JobCInvDateValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from JobCost");
					 IQApp.DB.Execute(SQL, this);
				                    					JobCJobNo.HasChanged = false;
									JobCServProvId.HasChanged = false;
									JobCServProv.HasChanged = false;
									JobCDesc.HasChanged = false;
									JobCInvAmt.HasChanged = false;
									JobCInvNo.HasChanged = false;
									JobCInvDate.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "JobCJobNo":
					return (IDSFieldBase)JobCJobNo;
								case "JobCServProvId":
					return (IDSFieldBase)JobCServProvId;
								case "JobCServProv":
					return (IDSFieldBase)JobCServProv;
								case "JobCDesc":
					return (IDSFieldBase)JobCDesc;
								case "JobCInvAmt":
					return (IDSFieldBase)JobCInvAmt;
								case "JobCInvNo":
					return (IDSFieldBase)JobCInvNo;
								case "JobCInvDate":
					return (IDSFieldBase)JobCInvDate;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "JobCJobNo":
					return JobCJobNo.DisplayValue;
								case "JobCServProvId":
					return JobCServProvId.DisplayValue;
								case "JobCServProv":
					return JobCServProv.DisplayValue;
								case "JobCDesc":
					return JobCDesc.DisplayValue;
								case "JobCInvAmt":
					return JobCInvAmt.DisplayValue;
								case "JobCInvNo":
					return JobCInvNo.DisplayValue;
								case "JobCInvDate":
					return JobCInvDate.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "JobCJobNo":
					return JobCJobNo.Value.ToString();
								case "JobCServProvId":
					return JobCServProvId.Value.ToString();
								case "JobCServProv":
					return JobCServProv.Value.ToString();
								case "JobCDesc":
					return JobCDesc.Value.ToString();
								case "JobCInvAmt":
					return JobCInvAmt.Value.ToString();
								case "JobCInvNo":
					return JobCInvNo.Value.ToString();
								case "JobCInvDate":
					return JobCInvDate.Value.ToString();
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
					foreach(var itm in DS.GetManager<JobCost>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public JobCost () : base("JobCost") {
		base.obj = this;
	
					JobCJobNo = new JobCost_JobCJobNo(this);
					JobCServProvId = new JobCost_JobCServProvId(this);
					JobCServProv = new JobCost_JobCServProv(this);
					JobCDesc = new JobCost_JobCDesc(this);
					JobCInvAmt = new JobCost_JobCInvAmt(this);
					JobCInvNo = new JobCost_JobCInvNo(this);
					JobCInvDate = new JobCost_JobCInvDate(this);
			}

	static JobCost () {
					JobCJobNoField = new JobCost_JobCJobNoFieldDef();
					JobCServProvIdField = new JobCost_JobCServProvIdFieldDef();
					JobCServProvField = new JobCost_JobCServProvFieldDef();
					JobCDescField = new JobCost_JobCDescFieldDef();
					JobCInvAmtField = new JobCost_JobCInvAmtFieldDef();
					JobCInvNoField = new JobCost_JobCInvNoFieldDef();
					JobCInvDateField = new JobCost_JobCInvDateFieldDef();
			}

	public string RecordTitle { 
		get { return JobCJobNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Job Costs"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/JobCost/Load/?RecId=" + RecordID.Value;
			}
			return "/JobCost/Add";
			}
	}

			
		
		[Ignore()]
		public JobCost_JobCJobNo JobCJobNo { get; set; }
		public static JobCost_JobCJobNoFieldDef JobCJobNoField { get; private set; }
        
			
			[Column("JobCJobNo")]
			public  int PopulateJobCJobNo  {
				get { return JobCJobNoValue ;}
				set { JobCJobNo.DataValue = value; }
			}

	
			public int JobCJobNoValue 
			{ 
				get 
				{
				   if(JobCJobNo.Value != null) {
				   					int i = 0;
					if (JobCJobNo != null)
					{
						if (JobCJobNo.Value != null)
						{
							if (Int32.TryParse(JobCJobNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobCJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public JobCost_JobCServProvId JobCServProvId { get; set; }
		public static JobCost_JobCServProvIdFieldDef JobCServProvIdField { get; private set; }
        
			
			[Column("JobCServProvId")]
			public  int PopulateJobCServProvId  {
				get { return JobCServProvIdValue ;}
				set { JobCServProvId.DataValue = value; }
			}

	
			public int JobCServProvIdValue 
			{ 
				get 
				{
				   if(JobCServProvId.Value != null) {
				   					int i = 0;
					if (JobCServProvId != null)
					{
						if (JobCServProvId.Value != null)
						{
							if (Int32.TryParse(JobCServProvId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobCServProvId.Value = value;  }
			}
			
		
		[Ignore()]
		public JobCost_JobCServProv JobCServProv { get; set; }
		public static JobCost_JobCServProvFieldDef JobCServProvField { get; private set; }
        
			
			[Column("JobCServProv")]
			public  int PopulateJobCServProv  {
				get { return JobCServProvValue ;}
				set { JobCServProv.DataValue = value; }
			}

	
			public int JobCServProvValue 
			{ 
				get 
				{
				   if(JobCServProv.Value != null) {
				   					int i = 0;
					if (JobCServProv != null)
					{
						if (JobCServProv.Value != null)
						{
							if (Int32.TryParse(JobCServProv.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { JobCServProv.Value = value;  }
			}
			
		
		[Ignore()]
		public JobCost_JobCDesc JobCDesc { get; set; }
		public static JobCost_JobCDescFieldDef JobCDescField { get; private set; }
        
			
			[Column("JobCDesc")]
			public  string PopulateJobCDesc  {
				get { return JobCDescValue ;}
				set { JobCDesc.DataValue = value; }
			}

	
			public string JobCDescValue 
			{ 
				get 
				{
				   if(JobCDesc.Value != null) {
				   return JobCDesc.Value.ToString(); 					}
					return "";
                
				}
				set { JobCDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public JobCost_JobCInvAmt JobCInvAmt { get; set; }
		public static JobCost_JobCInvAmtFieldDef JobCInvAmtField { get; private set; }
        
			
			[Column("JobCInvAmt")]
			public  double PopulateJobCInvAmt  {
				get { return JobCInvAmtValue ;}
				set { JobCInvAmt.DataValue = value; }
			}

	
			public double JobCInvAmtValue 
			{ 
				get 
				{
				   if(JobCInvAmt.Value != null) {
				   					double i = 0.0;
					if (JobCInvAmt != null)
					{
						if (JobCInvAmt.Value != null)
						{
							if (Double.TryParse(JobCInvAmt.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { JobCInvAmt.Value = value;  }
			}
			
		
		[Ignore()]
		public JobCost_JobCInvNo JobCInvNo { get; set; }
		public static JobCost_JobCInvNoFieldDef JobCInvNoField { get; private set; }
        
			
			[Column("JobCInvNo")]
			public  string PopulateJobCInvNo  {
				get { return JobCInvNoValue ;}
				set { JobCInvNo.DataValue = value; }
			}

	
			public string JobCInvNoValue 
			{ 
				get 
				{
				   if(JobCInvNo.Value != null) {
				   return JobCInvNo.Value.ToString(); 					}
					return "";
                
				}
				set { JobCInvNo.Value = value;  }
			}
			
		
		[Ignore()]
		public JobCost_JobCInvDate JobCInvDate { get; set; }
		public static JobCost_JobCInvDateFieldDef JobCInvDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("JobCInvDate")]
			public  DateTime PopulateJobCInvDate  {
				get { return JobCInvDateValue ;}
				set { JobCInvDate.DataValue = value; }
			}

	
			public DateTime JobCInvDateValue 
			{ 
				get 
				{
				   if(JobCInvDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (JobCInvDate != null)
					{
						if (JobCInvDate.Value != null)
						{
							if (DateTime.TryParse(JobCInvDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { JobCInvDate.Value = value;  }
			}
	}


public class JobCost_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 14;
    public int PixelHeight => 0;
	public string Title => "Job Costs";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
