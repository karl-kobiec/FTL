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


public partial class REDSOrdLineController : DSBaseController<REDSOrdLine/*,REDSOrdLineSearch*/> {
	public REDSOrdLineController() : base ((IDatabase)IQApp.DB, new REDSOrdLineRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select RDOLRDId from REDSOrdLine where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<REDSOrdLine>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(REDSOrdLine data) {
						IQApp.DB.Execute("Delete from REDSOrdLine where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.RDOLRDIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from REDSOrdLine " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from REDSOrdLine " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from REDSOrdLine " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/REDSOrdLine_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<REDSOrdLine>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine  ").ToList();
		string urlpath = "/temp/REDS Order Lines Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("REDS Order Lines");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 9])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 13;
					worksheet.Cells[1, 1].Value = "Line Number";
						
								
					worksheet.Column(2).Width = 13;
					worksheet.Cells[1, 2].Value = "Cases";
						
								
					worksheet.Column(3).Width = 8;
					worksheet.Cells[1, 3].Value = "Bottles per Case";
						
								
					worksheet.Column(4).Width = 13;
					worksheet.Cells[1, 4].Value = "Bottle Size (cl)";
						
								
					worksheet.Column(5).Width = 17;
					worksheet.Cells[1, 5].Value = "Tax Code";
						
								
					worksheet.Column(6).Width = 13;
					worksheet.Cells[1, 6].Value = "Alcohol Percentage";
						
								
					worksheet.Column(7).Width = 13;
					worksheet.Cells[1, 7].Value = "Duty Due";
						
								
					worksheet.Column(8).Width = 8;
					worksheet.Cells[1, 8].Value = "Locked";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].RDOLLineNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].RDOLCases.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].RDOLBottleCase.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].RDOLBottleSize.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].RDOLTaxCode.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].RDOLAlcPct.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].RDOLDutyDue.DisplayValue;
								worksheet.Cells[j+2,8].Value = res[j].RDOLLocked.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLRDId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDOLRDIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLRDId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLRDId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLRDId(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLRDId" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLRDId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLLineNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDOLLineNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLineNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLLineNo(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLineNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLCases(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDOLCasesValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLCases" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLCases")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLCases(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLCases" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLCases")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLBottleCase(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDOLBottleCaseValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleCase" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleCase")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLBottleCase(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleCase" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleCase")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLBottleSize(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOLBottleSizeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleSize" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleSize")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLBottleSize(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleSize" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLBottleSize")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLTaxCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.RDOLTaxCodeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLTaxCode" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLTaxCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteRDOLTaxCode(REDSOrdLine m, int? id, string q) {

		
		string s = m.RDOLTaxCode.DataSource;
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
	public ActionResult CallbackRDOLTaxCode(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLTaxCode" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLTaxCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLAlcPct(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOLAlcPctValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLAlcPct" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLAlcPct")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLAlcPct(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLAlcPct" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLAlcPct")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLLitres(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOLLitresValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLitres" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLitres")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLLitres(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLitres" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLitres")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLDutyDue(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOLDutyDueValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLDutyDue" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLDutyDue")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLDutyDue(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLDutyDue" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLDutyDue")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveRDOLLocked(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<REDSOrdLine>("select * from REDSOrdLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.RDOLLockedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLocked" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLocked")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackRDOLLocked(REDSOrdLine obj) {
			
		if(DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLocked" ).Any()) {
			foreach(var itm in DS.GetManager<REDSOrdLine>().OnChange.Where(f=> f.Key == "RDOLLocked")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<REDSOrdLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/REDSOrdLine/List/");
	}

}

public partial class REDSOrdLineRepository : DSRepository<REDSOrdLine> {
	public REDSOrdLineRepository() : base(36, "REDSOrdLine", "REDS Order Lines") {
	}
}
public partial class REDSOrdLine 
: DatasetBase<REDSOrdLine>, IDSBase

  {
	  public int KeyValue => RDOLRDIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "RDOLRDId":
			return RDOLRDIdField;
				case "RDOLLineNo":
			return RDOLLineNoField;
				case "RDOLCases":
			return RDOLCasesField;
				case "RDOLBottleCase":
			return RDOLBottleCaseField;
				case "RDOLBottleSize":
			return RDOLBottleSizeField;
				case "RDOLTaxCode":
			return RDOLTaxCodeField;
				case "RDOLAlcPct":
			return RDOLAlcPctField;
				case "RDOLLitres":
			return RDOLLitresField;
				case "RDOLDutyDue":
			return RDOLDutyDueField;
				case "RDOLLocked":
			return RDOLLockedField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(RDOLRDId,RDOLRDIdField);
				action(RDOLLineNo,RDOLLineNoField);
				action(RDOLCases,RDOLCasesField);
				action(RDOLBottleCase,RDOLBottleCaseField);
				action(RDOLBottleSize,RDOLBottleSizeField);
				action(RDOLTaxCode,RDOLTaxCodeField);
				action(RDOLAlcPct,RDOLAlcPctField);
				action(RDOLLitres,RDOLLitresField);
				action(RDOLDutyDue,RDOLDutyDueField);
				action(RDOLLocked,RDOLLockedField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
				RDOLRDId.Visible=false;RDOLLineNo.Visible=false;RDOLCases.Visible=false;RDOLBottleCase.Visible=false;RDOLBottleSize.Visible=false;RDOLTaxCode.Visible=false;RDOLAlcPct.Visible=false;RDOLLitres.Visible=false;RDOLDutyDue.Visible=false;RDOLLocked.Visible=false;			break;
					case 3:
				RDOLRDId.Visible=false;RDOLLineNo.Visible=false;RDOLCases.Visible=false;RDOLBottleCase.Visible=false;RDOLBottleSize.Visible=false;RDOLTaxCode.Visible=false;RDOLAlcPct.Visible=false;RDOLLitres.Visible=false;RDOLDutyDue.Visible=false;RDOLLocked.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (RDOLRDId.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM REDSOrder where RDOrdId=@Key", new {Key= RDOLRDId.Value});
                return 0;
            }
            set
            {
                if (RDOLRDId.Value == null)
                    RDOLRDId.Value = IQApp.DB.GetInt("SELECT RDOrdId FROM REDSOrder whereRecordID=@RecId", new { RecId = value});
            }
        }
        private REDSOrder _Parent;

        public REDSOrder Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<REDSOrder>("select * from REDSOrder where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (REDSOrder)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update REDSOrdLine set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (RDOLRDId.HasChanged && RDOLRDId.HasValue) {
					SQL += ", RDOLRDId=@RDOLRDIdValue";

				}
								if (RDOLLineNo.HasChanged && RDOLLineNo.HasValue) {
					SQL += ", RDOLLineNo=@RDOLLineNoValue";

				}
								if (RDOLCases.HasChanged && RDOLCases.HasValue) {
					SQL += ", RDOLCases=@RDOLCasesValue";

				}
								if (RDOLBottleCase.HasChanged && RDOLBottleCase.HasValue) {
					SQL += ", RDOLBottleCase=@RDOLBottleCaseValue";

				}
								if (RDOLBottleSize.HasChanged && RDOLBottleSize.HasValue) {
					SQL += ", RDOLBottleSize=@RDOLBottleSizeValue";

				}
								if (RDOLTaxCode.HasChanged && RDOLTaxCode.HasValue) {
					SQL += ", RDOLTaxCode=@RDOLTaxCodeValue";

				}
								if (RDOLAlcPct.HasChanged && RDOLAlcPct.HasValue) {
					SQL += ", RDOLAlcPct=@RDOLAlcPctValue";

				}
								if (RDOLLitres.HasChanged && RDOLLitres.HasValue) {
					SQL += ", RDOLLitres=@RDOLLitresValue";

				}
								if (RDOLDutyDue.HasChanged && RDOLDutyDue.HasValue) {
					SQL += ", RDOLDutyDue=@RDOLDutyDueValue";

				}
								if (RDOLLocked.HasChanged && RDOLLocked.HasValue) {
					SQL += ", RDOLLocked=@RDOLLockedValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									RDOLRDId.HasChanged = false;
									RDOLLineNo.HasChanged = false;
									RDOLCases.HasChanged = false;
									RDOLBottleCase.HasChanged = false;
									RDOLBottleSize.HasChanged = false;
									RDOLTaxCode.HasChanged = false;
									RDOLAlcPct.HasChanged = false;
									RDOLLitres.HasChanged = false;
									RDOLDutyDue.HasChanged = false;
									RDOLLocked.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into REDSOrdLine(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (RDOLRDId.HasValue) {
					SQL += ", RDOLRDId";
					Values += ", @RDOLRDIdValue";
				}
				
				if (RDOLLineNo.HasValue) {
					SQL += ", RDOLLineNo";
					Values += ", @RDOLLineNoValue";
				}
				
				if (RDOLCases.HasValue) {
					SQL += ", RDOLCases";
					Values += ", @RDOLCasesValue";
				}
				
				if (RDOLBottleCase.HasValue) {
					SQL += ", RDOLBottleCase";
					Values += ", @RDOLBottleCaseValue";
				}
				
				if (RDOLBottleSize.HasValue) {
					SQL += ", RDOLBottleSize";
					Values += ", @RDOLBottleSizeValue";
				}
				
				if (RDOLTaxCode.HasValue) {
					SQL += ", RDOLTaxCode";
					Values += ", @RDOLTaxCodeValue";
				}
				
				if (RDOLAlcPct.HasValue) {
					SQL += ", RDOLAlcPct";
					Values += ", @RDOLAlcPctValue";
				}
				
				if (RDOLLitres.HasValue) {
					SQL += ", RDOLLitres";
					Values += ", @RDOLLitresValue";
				}
				
				if (RDOLDutyDue.HasValue) {
					SQL += ", RDOLDutyDue";
					Values += ", @RDOLDutyDueValue";
				}
				
				if (RDOLLocked.HasValue) {
					SQL += ", RDOLLocked";
					Values += ", @RDOLLockedValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from REDSOrdLine");
					 IQApp.DB.Execute(SQL, this);
				                    					RDOLRDId.HasChanged = false;
									RDOLLineNo.HasChanged = false;
									RDOLCases.HasChanged = false;
									RDOLBottleCase.HasChanged = false;
									RDOLBottleSize.HasChanged = false;
									RDOLTaxCode.HasChanged = false;
									RDOLAlcPct.HasChanged = false;
									RDOLLitres.HasChanged = false;
									RDOLDutyDue.HasChanged = false;
									RDOLLocked.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "RDOLRDId":
					return (IDSFieldBase)RDOLRDId;
								case "RDOLLineNo":
					return (IDSFieldBase)RDOLLineNo;
								case "RDOLCases":
					return (IDSFieldBase)RDOLCases;
								case "RDOLBottleCase":
					return (IDSFieldBase)RDOLBottleCase;
								case "RDOLBottleSize":
					return (IDSFieldBase)RDOLBottleSize;
								case "RDOLTaxCode":
					return (IDSFieldBase)RDOLTaxCode;
								case "RDOLAlcPct":
					return (IDSFieldBase)RDOLAlcPct;
								case "RDOLLitres":
					return (IDSFieldBase)RDOLLitres;
								case "RDOLDutyDue":
					return (IDSFieldBase)RDOLDutyDue;
								case "RDOLLocked":
					return (IDSFieldBase)RDOLLocked;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "RDOLRDId":
					return RDOLRDId.DisplayValue;
								case "RDOLLineNo":
					return RDOLLineNo.DisplayValue;
								case "RDOLCases":
					return RDOLCases.DisplayValue;
								case "RDOLBottleCase":
					return RDOLBottleCase.DisplayValue;
								case "RDOLBottleSize":
					return RDOLBottleSize.DisplayValue;
								case "RDOLTaxCode":
					return RDOLTaxCode.DisplayValue;
								case "RDOLAlcPct":
					return RDOLAlcPct.DisplayValue;
								case "RDOLLitres":
					return RDOLLitres.DisplayValue;
								case "RDOLDutyDue":
					return RDOLDutyDue.DisplayValue;
								case "RDOLLocked":
					return RDOLLocked.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "RDOLRDId":
					return RDOLRDId.Value.ToString();
								case "RDOLLineNo":
					return RDOLLineNo.Value.ToString();
								case "RDOLCases":
					return RDOLCases.Value.ToString();
								case "RDOLBottleCase":
					return RDOLBottleCase.Value.ToString();
								case "RDOLBottleSize":
					return RDOLBottleSize.Value.ToString();
								case "RDOLTaxCode":
					return RDOLTaxCode.Value.ToString();
								case "RDOLAlcPct":
					return RDOLAlcPct.Value.ToString();
								case "RDOLLitres":
					return RDOLLitres.Value.ToString();
								case "RDOLDutyDue":
					return RDOLDutyDue.Value.ToString();
								case "RDOLLocked":
					return RDOLLocked.Value.ToString();
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
					foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public REDSOrdLine () : base("REDSOrdLine") {
		base.obj = this;
	
					RDOLRDId = new REDSOrdLine_RDOLRDId(this);
					RDOLLineNo = new REDSOrdLine_RDOLLineNo(this);
					RDOLCases = new REDSOrdLine_RDOLCases(this);
					RDOLBottleCase = new REDSOrdLine_RDOLBottleCase(this);
					RDOLBottleSize = new REDSOrdLine_RDOLBottleSize(this);
					RDOLTaxCode = new REDSOrdLine_RDOLTaxCode(this);
					RDOLAlcPct = new REDSOrdLine_RDOLAlcPct(this);
					RDOLLitres = new REDSOrdLine_RDOLLitres(this);
					RDOLDutyDue = new REDSOrdLine_RDOLDutyDue(this);
					RDOLLocked = new REDSOrdLine_RDOLLocked(this);
			}

	static REDSOrdLine () {
					RDOLRDIdField = new REDSOrdLine_RDOLRDIdFieldDef();
					RDOLLineNoField = new REDSOrdLine_RDOLLineNoFieldDef();
					RDOLCasesField = new REDSOrdLine_RDOLCasesFieldDef();
					RDOLBottleCaseField = new REDSOrdLine_RDOLBottleCaseFieldDef();
					RDOLBottleSizeField = new REDSOrdLine_RDOLBottleSizeFieldDef();
					RDOLTaxCodeField = new REDSOrdLine_RDOLTaxCodeFieldDef();
					RDOLAlcPctField = new REDSOrdLine_RDOLAlcPctFieldDef();
					RDOLLitresField = new REDSOrdLine_RDOLLitresFieldDef();
					RDOLDutyDueField = new REDSOrdLine_RDOLDutyDueFieldDef();
					RDOLLockedField = new REDSOrdLine_RDOLLockedFieldDef();
			}

	public string RecordTitle { 
		get { return RDOLRDIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "REDS Order Lines"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/REDSOrdLine/Load/?RecId=" + RecordID.Value;
			}
			return "/REDSOrdLine/Add";
			}
	}

			
		
		[Ignore()]
		public REDSOrdLine_RDOLRDId RDOLRDId { get; set; }
		public static REDSOrdLine_RDOLRDIdFieldDef RDOLRDIdField { get; private set; }
        
			
			[Column("RDOLRDId")]
			public  int PopulateRDOLRDId  {
				get { return RDOLRDIdValue ;}
				set { RDOLRDId.DataValue = value; }
			}

	
			public int RDOLRDIdValue 
			{ 
				get 
				{
				   if(RDOLRDId.Value != null) {
				   					int i = 0;
					if (RDOLRDId != null)
					{
						if (RDOLRDId.Value != null)
						{
							if (Int32.TryParse(RDOLRDId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOLRDId.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLLineNo RDOLLineNo { get; set; }
		public static REDSOrdLine_RDOLLineNoFieldDef RDOLLineNoField { get; private set; }
        
			
			[Column("RDOLLineNo")]
			public  int PopulateRDOLLineNo  {
				get { return RDOLLineNoValue ;}
				set { RDOLLineNo.DataValue = value; }
			}

	
			public int RDOLLineNoValue 
			{ 
				get 
				{
				   if(RDOLLineNo.Value != null) {
				   					int i = 0;
					if (RDOLLineNo != null)
					{
						if (RDOLLineNo.Value != null)
						{
							if (Int32.TryParse(RDOLLineNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOLLineNo.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLCases RDOLCases { get; set; }
		public static REDSOrdLine_RDOLCasesFieldDef RDOLCasesField { get; private set; }
        
			
			[Column("RDOLCases")]
			public  int PopulateRDOLCases  {
				get { return RDOLCasesValue ;}
				set { RDOLCases.DataValue = value; }
			}

	
			public int RDOLCasesValue 
			{ 
				get 
				{
				   if(RDOLCases.Value != null) {
				   					int i = 0;
					if (RDOLCases != null)
					{
						if (RDOLCases.Value != null)
						{
							if (Int32.TryParse(RDOLCases.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOLCases.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLBottleCase RDOLBottleCase { get; set; }
		public static REDSOrdLine_RDOLBottleCaseFieldDef RDOLBottleCaseField { get; private set; }
        
			
			[Column("RDOLBottleCase")]
			public  int PopulateRDOLBottleCase  {
				get { return RDOLBottleCaseValue ;}
				set { RDOLBottleCase.DataValue = value; }
			}

	
			public int RDOLBottleCaseValue 
			{ 
				get 
				{
				   if(RDOLBottleCase.Value != null) {
				   					int i = 0;
					if (RDOLBottleCase != null)
					{
						if (RDOLBottleCase.Value != null)
						{
							if (Int32.TryParse(RDOLBottleCase.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOLBottleCase.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLBottleSize RDOLBottleSize { get; set; }
		public static REDSOrdLine_RDOLBottleSizeFieldDef RDOLBottleSizeField { get; private set; }
        
			
			[Column("RDOLBottleSize")]
			public  double PopulateRDOLBottleSize  {
				get { return RDOLBottleSizeValue ;}
				set { RDOLBottleSize.DataValue = value; }
			}

	
			public double RDOLBottleSizeValue 
			{ 
				get 
				{
				   if(RDOLBottleSize.Value != null) {
				   					double i = 0.0;
					if (RDOLBottleSize != null)
					{
						if (RDOLBottleSize.Value != null)
						{
							if (Double.TryParse(RDOLBottleSize.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { RDOLBottleSize.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLTaxCode RDOLTaxCode { get; set; }
		public static REDSOrdLine_RDOLTaxCodeFieldDef RDOLTaxCodeField { get; private set; }
        
			
			[Column("RDOLTaxCode")]
			public  int PopulateRDOLTaxCode  {
				get { return RDOLTaxCodeValue ;}
				set { RDOLTaxCode.DataValue = value; }
			}

	
			public int RDOLTaxCodeValue 
			{ 
				get 
				{
				   if(RDOLTaxCode.Value != null) {
				   					int i = 0;
					if (RDOLTaxCode != null)
					{
						if (RDOLTaxCode.Value != null)
						{
							if (Int32.TryParse(RDOLTaxCode.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { RDOLTaxCode.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLAlcPct RDOLAlcPct { get; set; }
		public static REDSOrdLine_RDOLAlcPctFieldDef RDOLAlcPctField { get; private set; }
        
			
			[Column("RDOLAlcPct")]
			public  double PopulateRDOLAlcPct  {
				get { return RDOLAlcPctValue ;}
				set { RDOLAlcPct.DataValue = value; }
			}

	
			public double RDOLAlcPctValue 
			{ 
				get 
				{
				   if(RDOLAlcPct.Value != null) {
				   					double i = 0.0;
					if (RDOLAlcPct != null)
					{
						if (RDOLAlcPct.Value != null)
						{
							if (Double.TryParse(RDOLAlcPct.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { RDOLAlcPct.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLLitres RDOLLitres { get; set; }
		public static REDSOrdLine_RDOLLitresFieldDef RDOLLitresField { get; private set; }
        
			
			[Column("RDOLLitres")]
			public  double PopulateRDOLLitres  {
				get { return RDOLLitresValue ;}
				set { RDOLLitres.DataValue = value; }
			}

	
			public double RDOLLitresValue 
			{ 
				get 
				{
				   if(RDOLLitres.Value != null) {
				   					double i = 0.0;
					if (RDOLLitres != null)
					{
						if (RDOLLitres.Value != null)
						{
							if (Double.TryParse(RDOLLitres.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { RDOLLitres.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLDutyDue RDOLDutyDue { get; set; }
		public static REDSOrdLine_RDOLDutyDueFieldDef RDOLDutyDueField { get; private set; }
        
			
			[Column("RDOLDutyDue")]
			public  double PopulateRDOLDutyDue  {
				get { return RDOLDutyDueValue ;}
				set { RDOLDutyDue.DataValue = value; }
			}

	
			public double RDOLDutyDueValue 
			{ 
				get 
				{
				   if(RDOLDutyDue.Value != null) {
				   					double i = 0.0;
					if (RDOLDutyDue != null)
					{
						if (RDOLDutyDue.Value != null)
						{
							if (Double.TryParse(RDOLDutyDue.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { RDOLDutyDue.Value = value;  }
			}
			
		
		[Ignore()]
		public REDSOrdLine_RDOLLocked RDOLLocked { get; set; }
		public static REDSOrdLine_RDOLLockedFieldDef RDOLLockedField { get; private set; }
        
			
			[Column("RDOLLocked")]
			public  bool PopulateRDOLLocked  {
				get { return RDOLLockedValue ;}
				set { RDOLLocked.DataValue = value; }
			}

	
			public bool RDOLLockedValue 
			{ 
				get 
				{
				   if(RDOLLocked.Value != null) {
				   					bool i = false;
					if (RDOLLocked != null)
					{
						if (RDOLLocked.Value != null)
						{
							if (Boolean.TryParse(RDOLLocked.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { RDOLLocked.Value = value;  }
			}
	}


public class REDSOrdLine_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 36;
    public int PixelHeight => 0;
	public string Title => "REDS Order Lines";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
