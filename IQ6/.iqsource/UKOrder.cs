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


public partial class UKOrderController : DSBaseController<UKOrder/*,UKOrderSearch*/> {
	public UKOrderController() : base ((IDatabase)IQApp.DB, new UKOrderRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select UKOId from UKOrder where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<UKOrder>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(UKOrder data) {
						IQApp.DB.Execute("Delete from UKOrder where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.UKOIdValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from UKOrder " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from UKOrder " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from UKOrder " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/UKOrder_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<UKOrder>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<UKOrder>("select * from UKOrder  ").ToList();
		string urlpath = "/temp/UK Orders Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("UK Orders");
				
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
							
					worksheet.Column(1).Width = 12;
					worksheet.Cells[1, 1].Value = "UK Order ID";
						
								
					worksheet.Column(2).Width = 16;
					worksheet.Cells[1, 2].Value = "Collection Date";
						
								
					worksheet.Column(3).Width = 18;
					worksheet.Cells[1, 3].Value = "Customer Name";
						
								
					worksheet.Column(4).Width = 18;
					worksheet.Cells[1, 4].Value = "Collection From";
						
								
					worksheet.Column(5).Width = 18;
					worksheet.Cells[1, 5].Value = "Delivery To";
						
								
					worksheet.Column(6).Width = 18;
					worksheet.Cells[1, 6].Value = "Haulier Name";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].UKOId.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].UKOCollDate.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].UKOCust.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].UKOCollFrom.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].UKODelTo.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].UKOTransp.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.UKOIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOId" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOId(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOId" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOCollDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.UKOCollDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollDate" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOCollDate(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollDate" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOCustRef(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKOCustRefValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCustRef" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCustRef")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOCustRef(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCustRef" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCustRef")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.UKOCustValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCust" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteUKOCust(UKOrder m, int? id, string q) {

		
		string s = m.UKOCust.DataSource;
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
	public ActionResult CallbackUKOCust(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCust" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOCollFrom(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKOCollFromValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollFrom" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollFrom")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOCollFrom(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollFrom" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCollFrom")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKODelTo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKODelToValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelTo" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelTo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKODelTo(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelTo" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelTo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKODesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKODescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODesc" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKODesc(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODesc" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOQty(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKOQtyValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOQty" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOQty")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOQty(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOQty" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOQty")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOTransp(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.UKOTranspValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOTransp" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOTransp")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteUKOTransp(UKOrder m, int? id, string q) {

		
		string s = m.UKOTransp.DataSource;
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
	public ActionResult CallbackUKOTransp(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOTransp" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOTransp")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOChargeCust(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.UKOChargeCustValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOChargeCust" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOChargeCust")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOChargeCust(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOChargeCust" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOChargeCust")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOFTLCost(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.UKOFTLCostValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOFTLCost" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOFTLCost")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOFTLCost(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOFTLCost" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOFTLCost")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKODelProof(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.UKODelProofValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelProof" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelProof")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKODelProof(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelProof" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKODelProof")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOJobNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKOJobNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOJobNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOJobNo(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOJobNo" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOJobNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKONotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKONotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKONotes" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKONotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKONotes(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKONotes" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKONotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOWeight(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.UKOWeightValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOWeight" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOWeight")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOWeight(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOWeight" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOWeight")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOInvoiced(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.UKOInvoicedValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOInvoiced" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOInvoiced")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackUKOInvoiced(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOInvoiced" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOInvoiced")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveUKOCreatedBy(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<UKOrder>("select * from UKOrder where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.UKOCreatedByValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCreatedBy" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCreatedBy")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteUKOCreatedBy(UKOrder m, int? id, string q) {

		
		string s = m.UKOCreatedBy.DataSource;
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
	public ActionResult CallbackUKOCreatedBy(UKOrder obj) {
			
		if(DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCreatedBy" ).Any()) {
			foreach(var itm in DS.GetManager<UKOrder>().OnChange.Where(f=> f.Key == "UKOCreatedBy")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<UKOrder>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=9 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/UKOrder/Search/" + FirstSearch);
		
		return Redirect("/UKOrder/List/");
	}

}

public partial class UKOrderRepository : DSRepository<UKOrder> {
	public UKOrderRepository() : base(9, "UKOrder", "UK Orders") {
	}
}
public partial class UKOrder 
: DatasetBase<UKOrder>, IDSBase

  {
	  public int KeyValue => UKOIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "UKOId":
			return UKOIdField;
				case "UKOCollDate":
			return UKOCollDateField;
				case "UKOCustRef":
			return UKOCustRefField;
				case "UKOCust":
			return UKOCustField;
				case "UKOCollFrom":
			return UKOCollFromField;
				case "UKODelTo":
			return UKODelToField;
				case "UKODesc":
			return UKODescField;
				case "UKOQty":
			return UKOQtyField;
				case "UKOTransp":
			return UKOTranspField;
				case "UKOChargeCust":
			return UKOChargeCustField;
				case "UKOFTLCost":
			return UKOFTLCostField;
				case "UKODelProof":
			return UKODelProofField;
				case "UKOJobNo":
			return UKOJobNoField;
				case "UKONotes":
			return UKONotesField;
				case "UKOWeight":
			return UKOWeightField;
				case "UKOInvoiced":
			return UKOInvoicedField;
				case "UKOCreatedBy":
			return UKOCreatedByField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(UKOId,UKOIdField);
				action(UKOCollDate,UKOCollDateField);
				action(UKOCustRef,UKOCustRefField);
				action(UKOCust,UKOCustField);
				action(UKOCollFrom,UKOCollFromField);
				action(UKODelTo,UKODelToField);
				action(UKODesc,UKODescField);
				action(UKOQty,UKOQtyField);
				action(UKOTransp,UKOTranspField);
				action(UKOChargeCust,UKOChargeCustField);
				action(UKOFTLCost,UKOFTLCostField);
				action(UKODelProof,UKODelProofField);
				action(UKOJobNo,UKOJobNoField);
				action(UKONotes,UKONotesField);
				action(UKOWeight,UKOWeightField);
				action(UKOInvoiced,UKOInvoicedField);
				action(UKOCreatedBy,UKOCreatedByField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				UKOId.Visible=false;UKOCollDate.Visible=false;UKOCustRef.Visible=false;UKOCust.Visible=false;UKOCollFrom.Visible=false;UKODelTo.Visible=false;UKODesc.Visible=false;UKOQty.Visible=false;UKOTransp.Visible=false;UKOChargeCust.Visible=false;UKOFTLCost.Visible=false;UKODelProof.Visible=false;UKOJobNo.Visible=false;UKONotes.Visible=false;UKOWeight.Visible=false;UKOInvoiced.Visible=false;UKOCreatedBy.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update UKOrder set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (UKOId.HasChanged && UKOId.HasValue) {
					SQL += ", UKOId=@UKOIdValue";

				}
								if (UKOCollDate.HasChanged && UKOCollDate.HasValue) {
					SQL += ", UKOCollDate=@UKOCollDateValue";

				}
								if (UKOCustRef.HasChanged && UKOCustRef.HasValue) {
					SQL += ", UKOCustRef=@UKOCustRefValue";

				}
								if (UKOCust.HasChanged && UKOCust.HasValue) {
					SQL += ", UKOCust=@UKOCustValue";

				}
								if (UKOCollFrom.HasChanged && UKOCollFrom.HasValue) {
					SQL += ", UKOCollFrom=@UKOCollFromValue";

				}
								if (UKODelTo.HasChanged && UKODelTo.HasValue) {
					SQL += ", UKODelTo=@UKODelToValue";

				}
								if (UKODesc.HasChanged && UKODesc.HasValue) {
					SQL += ", UKODesc=@UKODescValue";

				}
								if (UKOQty.HasChanged && UKOQty.HasValue) {
					SQL += ", UKOQty=@UKOQtyValue";

				}
								if (UKOTransp.HasChanged && UKOTransp.HasValue) {
					SQL += ", UKOTransp=@UKOTranspValue";

				}
								if (UKOChargeCust.HasChanged && UKOChargeCust.HasValue) {
					SQL += ", UKOChargeCust=@UKOChargeCustValue";

				}
								if (UKOFTLCost.HasChanged && UKOFTLCost.HasValue) {
					SQL += ", UKOFTLCost=@UKOFTLCostValue";

				}
								if (UKODelProof.HasChanged && UKODelProof.HasValue) {
					SQL += ", UKODelProof=@UKODelProofValue";

				}
								if (UKOJobNo.HasChanged && UKOJobNo.HasValue) {
					SQL += ", UKOJobNo=@UKOJobNoValue";

				}
								if (UKONotes.HasChanged && UKONotes.HasValue) {
					SQL += ", UKONotes=@UKONotesValue";

				}
								if (UKOWeight.HasChanged && UKOWeight.HasValue) {
					SQL += ", UKOWeight=@UKOWeightValue";

				}
								if (UKOInvoiced.HasChanged && UKOInvoiced.HasValue) {
					SQL += ", UKOInvoiced=@UKOInvoicedValue";

				}
								if (UKOCreatedBy.HasChanged && UKOCreatedBy.HasValue) {
					SQL += ", UKOCreatedBy=@UKOCreatedByValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									UKOId.HasChanged = false;
									UKOCollDate.HasChanged = false;
									UKOCustRef.HasChanged = false;
									UKOCust.HasChanged = false;
									UKOCollFrom.HasChanged = false;
									UKODelTo.HasChanged = false;
									UKODesc.HasChanged = false;
									UKOQty.HasChanged = false;
									UKOTransp.HasChanged = false;
									UKOChargeCust.HasChanged = false;
									UKOFTLCost.HasChanged = false;
									UKODelProof.HasChanged = false;
									UKOJobNo.HasChanged = false;
									UKONotes.HasChanged = false;
									UKOWeight.HasChanged = false;
									UKOInvoiced.HasChanged = false;
									UKOCreatedBy.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into UKOrder(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				UKOId.Value = IQApp.DB.GetInt("select isnull(max(UKOId),0)+1 from UKOrder");
				if (UKOId.HasValue) {
					SQL += ", UKOId";
					Values += ", @UKOIdValue";
				}
				
				if (UKOCollDate.HasValue) {
					SQL += ", UKOCollDate";
					Values += ", @UKOCollDateValue";
				}
				
				if (UKOCustRef.HasValue) {
					SQL += ", UKOCustRef";
					Values += ", @UKOCustRefValue";
				}
				
				if (UKOCust.HasValue) {
					SQL += ", UKOCust";
					Values += ", @UKOCustValue";
				}
				
				if (UKOCollFrom.HasValue) {
					SQL += ", UKOCollFrom";
					Values += ", @UKOCollFromValue";
				}
				
				if (UKODelTo.HasValue) {
					SQL += ", UKODelTo";
					Values += ", @UKODelToValue";
				}
				
				if (UKODesc.HasValue) {
					SQL += ", UKODesc";
					Values += ", @UKODescValue";
				}
				
				if (UKOQty.HasValue) {
					SQL += ", UKOQty";
					Values += ", @UKOQtyValue";
				}
				
				if (UKOTransp.HasValue) {
					SQL += ", UKOTransp";
					Values += ", @UKOTranspValue";
				}
				
				if (UKOChargeCust.HasValue) {
					SQL += ", UKOChargeCust";
					Values += ", @UKOChargeCustValue";
				}
				
				if (UKOFTLCost.HasValue) {
					SQL += ", UKOFTLCost";
					Values += ", @UKOFTLCostValue";
				}
				
				if (UKODelProof.HasValue) {
					SQL += ", UKODelProof";
					Values += ", @UKODelProofValue";
				}
				
				if (UKOJobNo.HasValue) {
					SQL += ", UKOJobNo";
					Values += ", @UKOJobNoValue";
				}
				
				if (UKONotes.HasValue) {
					SQL += ", UKONotes";
					Values += ", @UKONotesValue";
				}
				
				if (UKOWeight.HasValue) {
					SQL += ", UKOWeight";
					Values += ", @UKOWeightValue";
				}
				
				if (UKOInvoiced.HasValue) {
					SQL += ", UKOInvoiced";
					Values += ", @UKOInvoicedValue";
				}
				
				if (UKOCreatedBy.HasValue) {
					SQL += ", UKOCreatedBy";
					Values += ", @UKOCreatedByValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from UKOrder");
					 IQApp.DB.Execute(SQL, this);
				                    					UKOId.HasChanged = false;
									UKOCollDate.HasChanged = false;
									UKOCustRef.HasChanged = false;
									UKOCust.HasChanged = false;
									UKOCollFrom.HasChanged = false;
									UKODelTo.HasChanged = false;
									UKODesc.HasChanged = false;
									UKOQty.HasChanged = false;
									UKOTransp.HasChanged = false;
									UKOChargeCust.HasChanged = false;
									UKOFTLCost.HasChanged = false;
									UKODelProof.HasChanged = false;
									UKOJobNo.HasChanged = false;
									UKONotes.HasChanged = false;
									UKOWeight.HasChanged = false;
									UKOInvoiced.HasChanged = false;
									UKOCreatedBy.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "UKOId":
					return (IDSFieldBase)UKOId;
								case "UKOCollDate":
					return (IDSFieldBase)UKOCollDate;
								case "UKOCustRef":
					return (IDSFieldBase)UKOCustRef;
								case "UKOCust":
					return (IDSFieldBase)UKOCust;
								case "UKOCollFrom":
					return (IDSFieldBase)UKOCollFrom;
								case "UKODelTo":
					return (IDSFieldBase)UKODelTo;
								case "UKODesc":
					return (IDSFieldBase)UKODesc;
								case "UKOQty":
					return (IDSFieldBase)UKOQty;
								case "UKOTransp":
					return (IDSFieldBase)UKOTransp;
								case "UKOChargeCust":
					return (IDSFieldBase)UKOChargeCust;
								case "UKOFTLCost":
					return (IDSFieldBase)UKOFTLCost;
								case "UKODelProof":
					return (IDSFieldBase)UKODelProof;
								case "UKOJobNo":
					return (IDSFieldBase)UKOJobNo;
								case "UKONotes":
					return (IDSFieldBase)UKONotes;
								case "UKOWeight":
					return (IDSFieldBase)UKOWeight;
								case "UKOInvoiced":
					return (IDSFieldBase)UKOInvoiced;
								case "UKOCreatedBy":
					return (IDSFieldBase)UKOCreatedBy;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "UKOId":
					return UKOId.DisplayValue;
								case "UKOCollDate":
					return UKOCollDate.DisplayValue;
								case "UKOCustRef":
					return UKOCustRef.DisplayValue;
								case "UKOCust":
					return UKOCust.DisplayValue;
								case "UKOCollFrom":
					return UKOCollFrom.DisplayValue;
								case "UKODelTo":
					return UKODelTo.DisplayValue;
								case "UKODesc":
					return UKODesc.DisplayValue;
								case "UKOQty":
					return UKOQty.DisplayValue;
								case "UKOTransp":
					return UKOTransp.DisplayValue;
								case "UKOChargeCust":
					return UKOChargeCust.DisplayValue;
								case "UKOFTLCost":
					return UKOFTLCost.DisplayValue;
								case "UKODelProof":
					return UKODelProof.DisplayValue;
								case "UKOJobNo":
					return UKOJobNo.DisplayValue;
								case "UKONotes":
					return UKONotes.DisplayValue;
								case "UKOWeight":
					return UKOWeight.DisplayValue;
								case "UKOInvoiced":
					return UKOInvoiced.DisplayValue;
								case "UKOCreatedBy":
					return UKOCreatedBy.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "UKOId":
					return UKOId.Value.ToString();
								case "UKOCollDate":
					return UKOCollDate.Value.ToString();
								case "UKOCustRef":
					return UKOCustRef.Value.ToString();
								case "UKOCust":
					return UKOCust.Value.ToString();
								case "UKOCollFrom":
					return UKOCollFrom.Value.ToString();
								case "UKODelTo":
					return UKODelTo.Value.ToString();
								case "UKODesc":
					return UKODesc.Value.ToString();
								case "UKOQty":
					return UKOQty.Value.ToString();
								case "UKOTransp":
					return UKOTransp.Value.ToString();
								case "UKOChargeCust":
					return UKOChargeCust.Value.ToString();
								case "UKOFTLCost":
					return UKOFTLCost.Value.ToString();
								case "UKODelProof":
					return UKODelProof.Value.ToString();
								case "UKOJobNo":
					return UKOJobNo.Value.ToString();
								case "UKONotes":
					return UKONotes.Value.ToString();
								case "UKOWeight":
					return UKOWeight.Value.ToString();
								case "UKOInvoiced":
					return UKOInvoiced.Value.ToString();
								case "UKOCreatedBy":
					return UKOCreatedBy.Value.ToString();
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
					foreach(var itm in DS.GetManager<UKOrder>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public UKOrder () : base("UKOrder") {
		base.obj = this;
	
					UKOId = new UKOrder_UKOId(this);
					UKOCollDate = new UKOrder_UKOCollDate(this);
					UKOCustRef = new UKOrder_UKOCustRef(this);
					UKOCust = new UKOrder_UKOCust(this);
					UKOCollFrom = new UKOrder_UKOCollFrom(this);
					UKODelTo = new UKOrder_UKODelTo(this);
					UKODesc = new UKOrder_UKODesc(this);
					UKOQty = new UKOrder_UKOQty(this);
					UKOTransp = new UKOrder_UKOTransp(this);
					UKOChargeCust = new UKOrder_UKOChargeCust(this);
					UKOFTLCost = new UKOrder_UKOFTLCost(this);
					UKODelProof = new UKOrder_UKODelProof(this);
					UKOJobNo = new UKOrder_UKOJobNo(this);
					UKONotes = new UKOrder_UKONotes(this);
					UKOWeight = new UKOrder_UKOWeight(this);
					UKOInvoiced = new UKOrder_UKOInvoiced(this);
					UKOCreatedBy = new UKOrder_UKOCreatedBy(this);
			}

	static UKOrder () {
					UKOIdField = new UKOrder_UKOIdFieldDef();
					UKOCollDateField = new UKOrder_UKOCollDateFieldDef();
					UKOCustRefField = new UKOrder_UKOCustRefFieldDef();
					UKOCustField = new UKOrder_UKOCustFieldDef();
					UKOCollFromField = new UKOrder_UKOCollFromFieldDef();
					UKODelToField = new UKOrder_UKODelToFieldDef();
					UKODescField = new UKOrder_UKODescFieldDef();
					UKOQtyField = new UKOrder_UKOQtyFieldDef();
					UKOTranspField = new UKOrder_UKOTranspFieldDef();
					UKOChargeCustField = new UKOrder_UKOChargeCustFieldDef();
					UKOFTLCostField = new UKOrder_UKOFTLCostFieldDef();
					UKODelProofField = new UKOrder_UKODelProofFieldDef();
					UKOJobNoField = new UKOrder_UKOJobNoFieldDef();
					UKONotesField = new UKOrder_UKONotesFieldDef();
					UKOWeightField = new UKOrder_UKOWeightFieldDef();
					UKOInvoicedField = new UKOrder_UKOInvoicedFieldDef();
					UKOCreatedByField = new UKOrder_UKOCreatedByFieldDef();
			}

	public string RecordTitle { 
		get { return UKOIdValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "UK Orders"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/UKOrder/Load/?RecId=" + RecordID.Value;
			}
			return "/UKOrder/Add";
			}
	}

			
		
		[Ignore()]
		public UKOrder_UKOId UKOId { get; set; }
		public static UKOrder_UKOIdFieldDef UKOIdField { get; private set; }
        
			
			[Column("UKOId")]
			public  int PopulateUKOId  {
				get { return UKOIdValue ;}
				set { UKOId.DataValue = value; }
			}

	
			public int UKOIdValue 
			{ 
				get 
				{
				   if(UKOId.Value != null) {
				   					int i = 0;
					if (UKOId != null)
					{
						if (UKOId.Value != null)
						{
							if (Int32.TryParse(UKOId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { UKOId.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOCollDate UKOCollDate { get; set; }
		public static UKOrder_UKOCollDateFieldDef UKOCollDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("UKOCollDate")]
			public  DateTime PopulateUKOCollDate  {
				get { return UKOCollDateValue ;}
				set { UKOCollDate.DataValue = value; }
			}

	
			public DateTime UKOCollDateValue 
			{ 
				get 
				{
				   if(UKOCollDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (UKOCollDate != null)
					{
						if (UKOCollDate.Value != null)
						{
							if (DateTime.TryParse(UKOCollDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { UKOCollDate.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOCustRef UKOCustRef { get; set; }
		public static UKOrder_UKOCustRefFieldDef UKOCustRefField { get; private set; }
        
			
			[Column("UKOCustRef")]
			public  string PopulateUKOCustRef  {
				get { return UKOCustRefValue ;}
				set { UKOCustRef.DataValue = value; }
			}

	
			public string UKOCustRefValue 
			{ 
				get 
				{
				   if(UKOCustRef.Value != null) {
				   return UKOCustRef.Value.ToString(); 					}
					return "";
                
				}
				set { UKOCustRef.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOCust UKOCust { get; set; }
		public static UKOrder_UKOCustFieldDef UKOCustField { get; private set; }
        
			
			[Column("UKOCust")]
			public  int PopulateUKOCust  {
				get { return UKOCustValue ;}
				set { UKOCust.DataValue = value; }
			}

	
			public int UKOCustValue 
			{ 
				get 
				{
				   if(UKOCust.Value != null) {
				   					int i = 0;
					if (UKOCust != null)
					{
						if (UKOCust.Value != null)
						{
							if (Int32.TryParse(UKOCust.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { UKOCust.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOCollFrom UKOCollFrom { get; set; }
		public static UKOrder_UKOCollFromFieldDef UKOCollFromField { get; private set; }
        
			
			[Column("UKOCollFrom")]
			public  string PopulateUKOCollFrom  {
				get { return UKOCollFromValue ;}
				set { UKOCollFrom.DataValue = value; }
			}

	
			public string UKOCollFromValue 
			{ 
				get 
				{
				   if(UKOCollFrom.Value != null) {
				   return UKOCollFrom.Value.ToString(); 					}
					return "";
                
				}
				set { UKOCollFrom.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKODelTo UKODelTo { get; set; }
		public static UKOrder_UKODelToFieldDef UKODelToField { get; private set; }
        
			
			[Column("UKODelTo")]
			public  string PopulateUKODelTo  {
				get { return UKODelToValue ;}
				set { UKODelTo.DataValue = value; }
			}

	
			public string UKODelToValue 
			{ 
				get 
				{
				   if(UKODelTo.Value != null) {
				   return UKODelTo.Value.ToString(); 					}
					return "";
                
				}
				set { UKODelTo.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKODesc UKODesc { get; set; }
		public static UKOrder_UKODescFieldDef UKODescField { get; private set; }
        
			
			[Column("UKODesc")]
			public  string PopulateUKODesc  {
				get { return UKODescValue ;}
				set { UKODesc.DataValue = value; }
			}

	
			public string UKODescValue 
			{ 
				get 
				{
				   if(UKODesc.Value != null) {
				   return UKODesc.Value.ToString(); 					}
					return "";
                
				}
				set { UKODesc.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOQty UKOQty { get; set; }
		public static UKOrder_UKOQtyFieldDef UKOQtyField { get; private set; }
        
			
			[Column("UKOQty")]
			public  string PopulateUKOQty  {
				get { return UKOQtyValue ;}
				set { UKOQty.DataValue = value; }
			}

	
			public string UKOQtyValue 
			{ 
				get 
				{
				   if(UKOQty.Value != null) {
				   return UKOQty.Value.ToString(); 					}
					return "";
                
				}
				set { UKOQty.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOTransp UKOTransp { get; set; }
		public static UKOrder_UKOTranspFieldDef UKOTranspField { get; private set; }
        
			
			[Column("UKOTransp")]
			public  int PopulateUKOTransp  {
				get { return UKOTranspValue ;}
				set { UKOTransp.DataValue = value; }
			}

	
			public int UKOTranspValue 
			{ 
				get 
				{
				   if(UKOTransp.Value != null) {
				   					int i = 0;
					if (UKOTransp != null)
					{
						if (UKOTransp.Value != null)
						{
							if (Int32.TryParse(UKOTransp.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { UKOTransp.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOChargeCust UKOChargeCust { get; set; }
		public static UKOrder_UKOChargeCustFieldDef UKOChargeCustField { get; private set; }
        
			
			[Column("UKOChargeCust")]
			public  double PopulateUKOChargeCust  {
				get { return UKOChargeCustValue ;}
				set { UKOChargeCust.DataValue = value; }
			}

	
			public double UKOChargeCustValue 
			{ 
				get 
				{
				   if(UKOChargeCust.Value != null) {
				   					double i = 0.0;
					if (UKOChargeCust != null)
					{
						if (UKOChargeCust.Value != null)
						{
							if (Double.TryParse(UKOChargeCust.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { UKOChargeCust.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOFTLCost UKOFTLCost { get; set; }
		public static UKOrder_UKOFTLCostFieldDef UKOFTLCostField { get; private set; }
        
			
			[Column("UKOFTLCost")]
			public  double PopulateUKOFTLCost  {
				get { return UKOFTLCostValue ;}
				set { UKOFTLCost.DataValue = value; }
			}

	
			public double UKOFTLCostValue 
			{ 
				get 
				{
				   if(UKOFTLCost.Value != null) {
				   					double i = 0.0;
					if (UKOFTLCost != null)
					{
						if (UKOFTLCost.Value != null)
						{
							if (Double.TryParse(UKOFTLCost.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { UKOFTLCost.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKODelProof UKODelProof { get; set; }
		public static UKOrder_UKODelProofFieldDef UKODelProofField { get; private set; }
        
			
			[Column("UKODelProof")]
			public  bool PopulateUKODelProof  {
				get { return UKODelProofValue ;}
				set { UKODelProof.DataValue = value; }
			}

	
			public bool UKODelProofValue 
			{ 
				get 
				{
				   if(UKODelProof.Value != null) {
				   					bool i = false;
					if (UKODelProof != null)
					{
						if (UKODelProof.Value != null)
						{
							if (Boolean.TryParse(UKODelProof.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { UKODelProof.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOJobNo UKOJobNo { get; set; }
		public static UKOrder_UKOJobNoFieldDef UKOJobNoField { get; private set; }
        
			
			[Column("UKOJobNo")]
			public  string PopulateUKOJobNo  {
				get { return UKOJobNoValue ;}
				set { UKOJobNo.DataValue = value; }
			}

	
			public string UKOJobNoValue 
			{ 
				get 
				{
				   if(UKOJobNo.Value != null) {
				   return UKOJobNo.Value.ToString(); 					}
					return "";
                
				}
				set { UKOJobNo.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKONotes UKONotes { get; set; }
		public static UKOrder_UKONotesFieldDef UKONotesField { get; private set; }
        
			
			[Column("UKONotes")]
			public  string PopulateUKONotes  {
				get { return UKONotesValue ;}
				set { UKONotes.DataValue = value; }
			}

	
			public string UKONotesValue 
			{ 
				get 
				{
				   if(UKONotes.Value != null) {
				   return UKONotes.Value.ToString(); 					}
					return "";
                
				}
				set { UKONotes.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOWeight UKOWeight { get; set; }
		public static UKOrder_UKOWeightFieldDef UKOWeightField { get; private set; }
        
			
			[Column("UKOWeight")]
			public  string PopulateUKOWeight  {
				get { return UKOWeightValue ;}
				set { UKOWeight.DataValue = value; }
			}

	
			public string UKOWeightValue 
			{ 
				get 
				{
				   if(UKOWeight.Value != null) {
				   return UKOWeight.Value.ToString(); 					}
					return "";
                
				}
				set { UKOWeight.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOInvoiced UKOInvoiced { get; set; }
		public static UKOrder_UKOInvoicedFieldDef UKOInvoicedField { get; private set; }
        
			
			[Column("UKOInvoiced")]
			public  bool PopulateUKOInvoiced  {
				get { return UKOInvoicedValue ;}
				set { UKOInvoiced.DataValue = value; }
			}

	
			public bool UKOInvoicedValue 
			{ 
				get 
				{
				   if(UKOInvoiced.Value != null) {
				   					bool i = false;
					if (UKOInvoiced != null)
					{
						if (UKOInvoiced.Value != null)
						{
							if (Boolean.TryParse(UKOInvoiced.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { UKOInvoiced.Value = value;  }
			}
			
		
		[Ignore()]
		public UKOrder_UKOCreatedBy UKOCreatedBy { get; set; }
		public static UKOrder_UKOCreatedByFieldDef UKOCreatedByField { get; private set; }
        
			
			[Column("UKOCreatedBy")]
			public  int PopulateUKOCreatedBy  {
				get { return UKOCreatedByValue ;}
				set { UKOCreatedBy.DataValue = value; }
			}

	
			public int UKOCreatedByValue 
			{ 
				get 
				{
				   if(UKOCreatedBy.Value != null) {
				   					int i = 0;
					if (UKOCreatedBy != null)
					{
						if (UKOCreatedBy.Value != null)
						{
							if (Int32.TryParse(UKOCreatedBy.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { UKOCreatedBy.Value = value;  }
			}
	}


public class UKOrder_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 9;
    public int PixelHeight => 0;
	public string Title => "UK Orders";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
