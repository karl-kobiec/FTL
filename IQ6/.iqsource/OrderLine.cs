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


public partial class OrderLineController : DSBaseController<OrderLine/*,OrderLineSearch*/> {
	public OrderLineController() : base ((IDatabase)IQApp.DB, new OrderLineRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select OrdLOrder from OrderLine where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<OrderLine>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(OrderLine data) {
						IQApp.DB.Execute("Delete from OrderLine where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.OrdLOrderValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from OrderLine " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from OrderLine " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from OrderLine " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/OrderLine_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<OrderLine>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<OrderLine>("select * from OrderLine  ").ToList();
		string urlpath = "/temp/Order Lines Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Order Lines");
				
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
							
					worksheet.Column(1).Width = 7;
					worksheet.Cells[1, 1].Value = "Order Number";
						
								
					worksheet.Column(2).Width = 7;
					worksheet.Cells[1, 2].Value = "Line Number";
						
								
					worksheet.Column(3).Width = 7;
					worksheet.Cells[1, 3].Value = "Quantity";
						
								
					worksheet.Column(4).Width = 9;
					worksheet.Cells[1, 4].Value = "Package Type";
						
								
					worksheet.Column(5).Width = 9;
					worksheet.Cells[1, 5].Value = "Size";
						
								
					worksheet.Column(6).Width = 27;
					worksheet.Cells[1, 6].Value = "Description";
						
								
					worksheet.Column(7).Width = 9;
					worksheet.Cells[1, 7].Value = "Weight";
						
								
					worksheet.Column(8).Width = 9;
					worksheet.Cells[1, 8].Value = "Number of Pallets";
						
								
					worksheet.Column(9).Width = 9;
					worksheet.Cells[1, 9].Value = "Pallet Type";
						
								
					worksheet.Column(10).Width = 9;
					worksheet.Cells[1, 10].Value = "Client Order No";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].OrdLOrder.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].OrdLLineNo.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].OrdLQty.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].OrdLPackageType.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].OrdLSize.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].OrdLDesc.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].OrdLWeight.DisplayValue;
								worksheet.Cells[j+2,8].Value = res[j].OrdLNumPallet.DisplayValue;
								worksheet.Cells[j+2,9].Value = res[j].OrdLPalletType.DisplayValue;
								worksheet.Cells[j+2,10].Value = res[j].OrdLCustOrd.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLOrder(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLOrderValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLOrder" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLOrder")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLOrder(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLOrder" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLOrder")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLLineNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLLineNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLLineNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLLineNo(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLLineNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLQty(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLQtyValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLQty" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLQty")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLQty(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLQty" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLQty")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLPackageType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLPackageTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPackageType" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPackageType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteOrdLPackageType(OrderLine m, int? id, string q) {

		
		string s = m.OrdLPackageType.DataSource;
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
	public ActionResult CallbackOrdLPackageType(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPackageType" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPackageType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLSize(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLSizeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLSize" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLSize")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteOrdLSize(OrderLine m, int? id, string q) {

		
		string s = m.OrdLSize.DataSource;
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
	public ActionResult CallbackOrdLSize(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLSize" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLSize")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.OrdLDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLDesc" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLDesc(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLDesc" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLWeight(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLWeightValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLWeight" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLWeight")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLWeight(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLWeight" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLWeight")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLNumPallet(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.OrdLNumPalletValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLNumPallet" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLNumPallet")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLNumPallet(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLNumPallet" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLNumPallet")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLPalletType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.OrdLPalletTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPalletType" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPalletType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteOrdLPalletType(OrderLine m, int? id, string q) {

		
		string s = m.OrdLPalletType.DataSource;
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
	public ActionResult CallbackOrdLPalletType(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPalletType" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLPalletType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveOrdLCustOrd(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<OrderLine>("select * from OrderLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.OrdLCustOrdValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLCustOrd")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackOrdLCustOrd(OrderLine obj) {
			
		if(DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLCustOrd" ).Any()) {
			foreach(var itm in DS.GetManager<OrderLine>().OnChange.Where(f=> f.Key == "OrdLCustOrd")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<OrderLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=3 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/OrderLine/Search/" + FirstSearch);
		
		return Redirect("/OrderLine/List/");
	}

}

public partial class OrderLineRepository : DSRepository<OrderLine> {
	public OrderLineRepository() : base(3, "OrderLine", "Order Lines") {
	}
}
public partial class OrderLine 
: DatasetBase<OrderLine>, IDSBase

  {
	  public int KeyValue => OrdLOrderValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "OrdLOrder":
			return OrdLOrderField;
				case "OrdLLineNo":
			return OrdLLineNoField;
				case "OrdLQty":
			return OrdLQtyField;
				case "OrdLPackageType":
			return OrdLPackageTypeField;
				case "OrdLSize":
			return OrdLSizeField;
				case "OrdLDesc":
			return OrdLDescField;
				case "OrdLWeight":
			return OrdLWeightField;
				case "OrdLNumPallet":
			return OrdLNumPalletField;
				case "OrdLPalletType":
			return OrdLPalletTypeField;
				case "OrdLCustOrd":
			return OrdLCustOrdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(OrdLOrder,OrdLOrderField);
				action(OrdLLineNo,OrdLLineNoField);
				action(OrdLQty,OrdLQtyField);
				action(OrdLPackageType,OrdLPackageTypeField);
				action(OrdLSize,OrdLSizeField);
				action(OrdLDesc,OrdLDescField);
				action(OrdLWeight,OrdLWeightField);
				action(OrdLNumPallet,OrdLNumPalletField);
				action(OrdLPalletType,OrdLPalletTypeField);
				action(OrdLCustOrd,OrdLCustOrdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				OrdLOrder.Visible=false;OrdLLineNo.Visible=false;OrdLQty.Visible=false;OrdLPackageType.Visible=false;OrdLSize.Visible=false;OrdLDesc.Visible=false;OrdLWeight.Visible=false;OrdLNumPallet.Visible=false;OrdLPalletType.Visible=false;OrdLCustOrd.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (OrdLOrder.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Orders where OrdId=@Key", new {Key= OrdLOrder.Value});
                return 0;
            }
            set
            {
                if (OrdLOrder.Value == null)
                    OrdLOrder.Value = IQApp.DB.GetInt("SELECT OrdId FROM Orders whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Orders _Parent;

        public Orders Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Orders>("select * from Orders where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (Orders)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update OrderLine set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (OrdLOrder.HasChanged && OrdLOrder.HasValue) {
					SQL += ", OrdLOrder=@OrdLOrderValue";

				}
								if (OrdLLineNo.HasChanged && OrdLLineNo.HasValue) {
					SQL += ", OrdLLineNo=@OrdLLineNoValue";

				}
								if (OrdLQty.HasChanged && OrdLQty.HasValue) {
					SQL += ", OrdLQty=@OrdLQtyValue";

				}
								if (OrdLPackageType.HasChanged && OrdLPackageType.HasValue) {
					SQL += ", OrdLPackageType=@OrdLPackageTypeValue";

				}
								if (OrdLSize.HasChanged && OrdLSize.HasValue) {
					SQL += ", OrdLSize=@OrdLSizeValue";

				}
								if (OrdLDesc.HasChanged && OrdLDesc.HasValue) {
					SQL += ", OrdLDesc=@OrdLDescValue";

				}
								if (OrdLWeight.HasChanged && OrdLWeight.HasValue) {
					SQL += ", OrdLWeight=@OrdLWeightValue";

				}
								if (OrdLNumPallet.HasChanged && OrdLNumPallet.HasValue) {
					SQL += ", OrdLNumPallet=@OrdLNumPalletValue";

				}
								if (OrdLPalletType.HasChanged && OrdLPalletType.HasValue) {
					SQL += ", OrdLPalletType=@OrdLPalletTypeValue";

				}
								if (OrdLCustOrd.HasChanged && OrdLCustOrd.HasValue) {
					SQL += ", OrdLCustOrd=@OrdLCustOrdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									OrdLOrder.HasChanged = false;
									OrdLLineNo.HasChanged = false;
									OrdLQty.HasChanged = false;
									OrdLPackageType.HasChanged = false;
									OrdLSize.HasChanged = false;
									OrdLDesc.HasChanged = false;
									OrdLWeight.HasChanged = false;
									OrdLNumPallet.HasChanged = false;
									OrdLPalletType.HasChanged = false;
									OrdLCustOrd.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into OrderLine(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (OrdLOrder.HasValue) {
					SQL += ", OrdLOrder";
					Values += ", @OrdLOrderValue";
				}
				
				if (OrdLLineNo.HasValue) {
					SQL += ", OrdLLineNo";
					Values += ", @OrdLLineNoValue";
				}
				
				if (OrdLQty.HasValue) {
					SQL += ", OrdLQty";
					Values += ", @OrdLQtyValue";
				}
				
				if (OrdLPackageType.HasValue) {
					SQL += ", OrdLPackageType";
					Values += ", @OrdLPackageTypeValue";
				}
				
				if (OrdLSize.HasValue) {
					SQL += ", OrdLSize";
					Values += ", @OrdLSizeValue";
				}
				
				if (OrdLDesc.HasValue) {
					SQL += ", OrdLDesc";
					Values += ", @OrdLDescValue";
				}
				
				if (OrdLWeight.HasValue) {
					SQL += ", OrdLWeight";
					Values += ", @OrdLWeightValue";
				}
				
				if (OrdLNumPallet.HasValue) {
					SQL += ", OrdLNumPallet";
					Values += ", @OrdLNumPalletValue";
				}
				
				if (OrdLPalletType.HasValue) {
					SQL += ", OrdLPalletType";
					Values += ", @OrdLPalletTypeValue";
				}
				
				if (OrdLCustOrd.HasValue) {
					SQL += ", OrdLCustOrd";
					Values += ", @OrdLCustOrdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from OrderLine");
					 IQApp.DB.Execute(SQL, this);
				                    					OrdLOrder.HasChanged = false;
									OrdLLineNo.HasChanged = false;
									OrdLQty.HasChanged = false;
									OrdLPackageType.HasChanged = false;
									OrdLSize.HasChanged = false;
									OrdLDesc.HasChanged = false;
									OrdLWeight.HasChanged = false;
									OrdLNumPallet.HasChanged = false;
									OrdLPalletType.HasChanged = false;
									OrdLCustOrd.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "OrdLOrder":
					return (IDSFieldBase)OrdLOrder;
								case "OrdLLineNo":
					return (IDSFieldBase)OrdLLineNo;
								case "OrdLQty":
					return (IDSFieldBase)OrdLQty;
								case "OrdLPackageType":
					return (IDSFieldBase)OrdLPackageType;
								case "OrdLSize":
					return (IDSFieldBase)OrdLSize;
								case "OrdLDesc":
					return (IDSFieldBase)OrdLDesc;
								case "OrdLWeight":
					return (IDSFieldBase)OrdLWeight;
								case "OrdLNumPallet":
					return (IDSFieldBase)OrdLNumPallet;
								case "OrdLPalletType":
					return (IDSFieldBase)OrdLPalletType;
								case "OrdLCustOrd":
					return (IDSFieldBase)OrdLCustOrd;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "OrdLOrder":
					return OrdLOrder.DisplayValue;
								case "OrdLLineNo":
					return OrdLLineNo.DisplayValue;
								case "OrdLQty":
					return OrdLQty.DisplayValue;
								case "OrdLPackageType":
					return OrdLPackageType.DisplayValue;
								case "OrdLSize":
					return OrdLSize.DisplayValue;
								case "OrdLDesc":
					return OrdLDesc.DisplayValue;
								case "OrdLWeight":
					return OrdLWeight.DisplayValue;
								case "OrdLNumPallet":
					return OrdLNumPallet.DisplayValue;
								case "OrdLPalletType":
					return OrdLPalletType.DisplayValue;
								case "OrdLCustOrd":
					return OrdLCustOrd.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "OrdLOrder":
					return OrdLOrder.Value.ToString();
								case "OrdLLineNo":
					return OrdLLineNo.Value.ToString();
								case "OrdLQty":
					return OrdLQty.Value.ToString();
								case "OrdLPackageType":
					return OrdLPackageType.Value.ToString();
								case "OrdLSize":
					return OrdLSize.Value.ToString();
								case "OrdLDesc":
					return OrdLDesc.Value.ToString();
								case "OrdLWeight":
					return OrdLWeight.Value.ToString();
								case "OrdLNumPallet":
					return OrdLNumPallet.Value.ToString();
								case "OrdLPalletType":
					return OrdLPalletType.Value.ToString();
								case "OrdLCustOrd":
					return OrdLCustOrd.Value.ToString();
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
					foreach(var itm in DS.GetManager<OrderLine>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public OrderLine () : base("OrderLine") {
		base.obj = this;
	
					OrdLOrder = new OrderLine_OrdLOrder(this);
					OrdLLineNo = new OrderLine_OrdLLineNo(this);
					OrdLQty = new OrderLine_OrdLQty(this);
					OrdLPackageType = new OrderLine_OrdLPackageType(this);
					OrdLSize = new OrderLine_OrdLSize(this);
					OrdLDesc = new OrderLine_OrdLDesc(this);
					OrdLWeight = new OrderLine_OrdLWeight(this);
					OrdLNumPallet = new OrderLine_OrdLNumPallet(this);
					OrdLPalletType = new OrderLine_OrdLPalletType(this);
					OrdLCustOrd = new OrderLine_OrdLCustOrd(this);
			}

	static OrderLine () {
					OrdLOrderField = new OrderLine_OrdLOrderFieldDef();
					OrdLLineNoField = new OrderLine_OrdLLineNoFieldDef();
					OrdLQtyField = new OrderLine_OrdLQtyFieldDef();
					OrdLPackageTypeField = new OrderLine_OrdLPackageTypeFieldDef();
					OrdLSizeField = new OrderLine_OrdLSizeFieldDef();
					OrdLDescField = new OrderLine_OrdLDescFieldDef();
					OrdLWeightField = new OrderLine_OrdLWeightFieldDef();
					OrdLNumPalletField = new OrderLine_OrdLNumPalletFieldDef();
					OrdLPalletTypeField = new OrderLine_OrdLPalletTypeFieldDef();
					OrdLCustOrdField = new OrderLine_OrdLCustOrdFieldDef();
			}

	public string RecordTitle { 
		get { return OrdLOrderValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Order Lines"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/OrderLine/Load/?RecId=" + RecordID.Value;
			}
			return "/OrderLine/Add";
			}
	}

			
		
		[Ignore()]
		public OrderLine_OrdLOrder OrdLOrder { get; set; }
		public static OrderLine_OrdLOrderFieldDef OrdLOrderField { get; private set; }
        
			
			[Column("OrdLOrder")]
			public  int PopulateOrdLOrder  {
				get { return OrdLOrderValue ;}
				set { OrdLOrder.DataValue = value; }
			}

	
			public int OrdLOrderValue 
			{ 
				get 
				{
				   if(OrdLOrder.Value != null) {
				   					int i = 0;
					if (OrdLOrder != null)
					{
						if (OrdLOrder.Value != null)
						{
							if (Int32.TryParse(OrdLOrder.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLOrder.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLLineNo OrdLLineNo { get; set; }
		public static OrderLine_OrdLLineNoFieldDef OrdLLineNoField { get; private set; }
        
			
			[Column("OrdLLineNo")]
			public  int PopulateOrdLLineNo  {
				get { return OrdLLineNoValue ;}
				set { OrdLLineNo.DataValue = value; }
			}

	
			public int OrdLLineNoValue 
			{ 
				get 
				{
				   if(OrdLLineNo.Value != null) {
				   					int i = 0;
					if (OrdLLineNo != null)
					{
						if (OrdLLineNo.Value != null)
						{
							if (Int32.TryParse(OrdLLineNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLLineNo.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLQty OrdLQty { get; set; }
		public static OrderLine_OrdLQtyFieldDef OrdLQtyField { get; private set; }
        
			
			[Column("OrdLQty")]
			public  int PopulateOrdLQty  {
				get { return OrdLQtyValue ;}
				set { OrdLQty.DataValue = value; }
			}

	
			public int OrdLQtyValue 
			{ 
				get 
				{
				   if(OrdLQty.Value != null) {
				   					int i = 0;
					if (OrdLQty != null)
					{
						if (OrdLQty.Value != null)
						{
							if (Int32.TryParse(OrdLQty.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLQty.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLPackageType OrdLPackageType { get; set; }
		public static OrderLine_OrdLPackageTypeFieldDef OrdLPackageTypeField { get; private set; }
        
			
			[Column("OrdLPackageType")]
			public  int PopulateOrdLPackageType  {
				get { return OrdLPackageTypeValue ;}
				set { OrdLPackageType.DataValue = value; }
			}

	
			public int OrdLPackageTypeValue 
			{ 
				get 
				{
				   if(OrdLPackageType.Value != null) {
				   					int i = 0;
					if (OrdLPackageType != null)
					{
						if (OrdLPackageType.Value != null)
						{
							if (Int32.TryParse(OrdLPackageType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLPackageType.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLSize OrdLSize { get; set; }
		public static OrderLine_OrdLSizeFieldDef OrdLSizeField { get; private set; }
        
			
			[Column("OrdLSize")]
			public  int PopulateOrdLSize  {
				get { return OrdLSizeValue ;}
				set { OrdLSize.DataValue = value; }
			}

	
			public int OrdLSizeValue 
			{ 
				get 
				{
				   if(OrdLSize.Value != null) {
				   					int i = 0;
					if (OrdLSize != null)
					{
						if (OrdLSize.Value != null)
						{
							if (Int32.TryParse(OrdLSize.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLSize.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLDesc OrdLDesc { get; set; }
		public static OrderLine_OrdLDescFieldDef OrdLDescField { get; private set; }
        
			
			[Column("OrdLDesc")]
			public  string PopulateOrdLDesc  {
				get { return OrdLDescValue ;}
				set { OrdLDesc.DataValue = value; }
			}

	
			public string OrdLDescValue 
			{ 
				get 
				{
				   if(OrdLDesc.Value != null) {
				   return OrdLDesc.Value.ToString(); 					}
					return "";
                
				}
				set { OrdLDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLWeight OrdLWeight { get; set; }
		public static OrderLine_OrdLWeightFieldDef OrdLWeightField { get; private set; }
        
			
			[Column("OrdLWeight")]
			public  int PopulateOrdLWeight  {
				get { return OrdLWeightValue ;}
				set { OrdLWeight.DataValue = value; }
			}

	
			public int OrdLWeightValue 
			{ 
				get 
				{
				   if(OrdLWeight.Value != null) {
				   					int i = 0;
					if (OrdLWeight != null)
					{
						if (OrdLWeight.Value != null)
						{
							if (Int32.TryParse(OrdLWeight.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLWeight.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLNumPallet OrdLNumPallet { get; set; }
		public static OrderLine_OrdLNumPalletFieldDef OrdLNumPalletField { get; private set; }
        
			
			[Column("OrdLNumPallet")]
			public  double PopulateOrdLNumPallet  {
				get { return OrdLNumPalletValue ;}
				set { OrdLNumPallet.DataValue = value; }
			}

	
			public double OrdLNumPalletValue 
			{ 
				get 
				{
				   if(OrdLNumPallet.Value != null) {
				   					double i = 0.0;
					if (OrdLNumPallet != null)
					{
						if (OrdLNumPallet.Value != null)
						{
							if (Double.TryParse(OrdLNumPallet.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { OrdLNumPallet.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLPalletType OrdLPalletType { get; set; }
		public static OrderLine_OrdLPalletTypeFieldDef OrdLPalletTypeField { get; private set; }
        
			
			[Column("OrdLPalletType")]
			public  int PopulateOrdLPalletType  {
				get { return OrdLPalletTypeValue ;}
				set { OrdLPalletType.DataValue = value; }
			}

	
			public int OrdLPalletTypeValue 
			{ 
				get 
				{
				   if(OrdLPalletType.Value != null) {
				   					int i = 0;
					if (OrdLPalletType != null)
					{
						if (OrdLPalletType.Value != null)
						{
							if (Int32.TryParse(OrdLPalletType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { OrdLPalletType.Value = value;  }
			}
			
		
		[Ignore()]
		public OrderLine_OrdLCustOrd OrdLCustOrd { get; set; }
		public static OrderLine_OrdLCustOrdFieldDef OrdLCustOrdField { get; private set; }
        
			
			[Column("OrdLCustOrd")]
			public  string PopulateOrdLCustOrd  {
				get { return OrdLCustOrdValue ;}
				set { OrdLCustOrd.DataValue = value; }
			}

	
			public string OrdLCustOrdValue 
			{ 
				get 
				{
				   if(OrdLCustOrd.Value != null) {
				   return OrdLCustOrd.Value.ToString(); 					}
					return "";
                
				}
				set { OrdLCustOrd.Value = value;  }
			}
	}


public class OrderLine_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 3;
    public int PixelHeight => 0;
	public string Title => "Order Lines";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
