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


public partial class InvLineController : DSBaseController<InvLine/*,InvLineSearch*/> {
	public InvLineController() : base ((IDatabase)IQApp.DB, new InvLineRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select InvLInvNo from InvLine where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<InvLine>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(InvLine data) {
						IQApp.DB.Execute("Delete from InvLine where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.InvLInvNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from InvLine " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from InvLine " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from InvLine " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/InvLine_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<InvLine>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<InvLine>("select * from InvLine  ").ToList();
		string urlpath = "/temp/Invoice Lines Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Invoice Lines");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 10])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 7;
					worksheet.Cells[1, 1].Value = "Invoice Number";
						
								
					worksheet.Column(2).Width = 7;
					worksheet.Cells[1, 2].Value = "Line Number";
						
								
					worksheet.Column(3).Width = 29;
					worksheet.Cells[1, 3].Value = "Description";
						
								
					worksheet.Column(4).Width = 15;
					worksheet.Cells[1, 4].Value = "VAT Code";
						
								
					worksheet.Column(5).Width = 5;
					worksheet.Cells[1, 5].Value = "VAT Rate";
						
								
					worksheet.Column(6).Width = 7;
					worksheet.Cells[1, 6].Value = "Line Amount";
						
								
					worksheet.Column(7).Width = 7;
					worksheet.Cells[1, 7].Value = "VAT Amount";
						
								
					worksheet.Column(8).Width = 7;
					worksheet.Cells[1, 8].Value = "Line Total";
						
								
					worksheet.Column(9).Width = 15;
					worksheet.Cells[1, 9].Value = "Charge Type";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].InvLInvNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].InvLLineNo.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].InvLDesc.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].InvLVATCode.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].InvLVATRate.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].InvLAmt.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].InvLVATAmt.DisplayValue;
								worksheet.Cells[j+2,8].Value = res[j].InvLTotal.DisplayValue;
								worksheet.Cells[j+2,9].Value = res[j].InvLChargeType.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLInvNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvLInvNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLInvNo" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLInvNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLInvNo(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLInvNo" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLInvNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLLineNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvLLineNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLLineNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLLineNo(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLLineNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvLDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLDesc" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLDesc(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLDesc" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLVATCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.InvLVATCodeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATCode" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvLVATCode(InvLine m, int? id, string q) {

		
		string s = m.InvLVATCode.DataSource;
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
	public ActionResult CallbackInvLVATCode(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATCode" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLVATRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvLVATRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATRate" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLVATRate(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATRate" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLAmt(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvLAmtValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLAmt" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLAmt")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLAmt(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLAmt" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLAmt")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLVATAmt(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvLVATAmtValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATAmt" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATAmt")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLVATAmt(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATAmt" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLVATAmt")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLTotal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.InvLTotalValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLTotal" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLTotal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackInvLTotal(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLTotal" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLTotal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveInvLChargeType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<InvLine>("select * from InvLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.InvLChargeTypeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLChargeType" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLChargeType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteInvLChargeType(InvLine m, int? id, string q) {

		
		string s = m.InvLChargeType.DataSource;
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
	public ActionResult CallbackInvLChargeType(InvLine obj) {
			
		if(DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLChargeType" ).Any()) {
			foreach(var itm in DS.GetManager<InvLine>().OnChange.Where(f=> f.Key == "InvLChargeType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<InvLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/InvLine/List/");
	}

}

public partial class InvLineRepository : DSRepository<InvLine> {
	public InvLineRepository() : base(7, "InvLine", "Invoice Lines") {
	}
}
public partial class InvLine 
: DatasetBase<InvLine>, IDSBase

  {
	  public int KeyValue => InvLInvNoValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "InvLInvNo":
			return InvLInvNoField;
				case "InvLLineNo":
			return InvLLineNoField;
				case "InvLDesc":
			return InvLDescField;
				case "InvLVATCode":
			return InvLVATCodeField;
				case "InvLVATRate":
			return InvLVATRateField;
				case "InvLAmt":
			return InvLAmtField;
				case "InvLVATAmt":
			return InvLVATAmtField;
				case "InvLTotal":
			return InvLTotalField;
				case "InvLChargeType":
			return InvLChargeTypeField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(InvLInvNo,InvLInvNoField);
				action(InvLLineNo,InvLLineNoField);
				action(InvLDesc,InvLDescField);
				action(InvLVATCode,InvLVATCodeField);
				action(InvLVATRate,InvLVATRateField);
				action(InvLAmt,InvLAmtField);
				action(InvLVATAmt,InvLVATAmtField);
				action(InvLTotal,InvLTotalField);
				action(InvLChargeType,InvLChargeTypeField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				InvLInvNo.Visible=false;InvLLineNo.Visible=false;InvLDesc.Visible=false;InvLVATCode.Visible=false;InvLVATRate.Visible=false;InvLAmt.Visible=false;InvLVATAmt.Visible=false;InvLTotal.Visible=false;InvLChargeType.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (InvLInvNo.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM Inv where InvId=@Key", new {Key= InvLInvNo.Value});
                return 0;
            }
            set
            {
                if (InvLInvNo.Value == null)
                    InvLInvNo.Value = IQApp.DB.GetInt("SELECT InvId FROM Inv whereRecordID=@RecId", new { RecId = value});
            }
        }
        private Inv _Parent;

        public Inv Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<Inv>("select * from Inv where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (Inv)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update InvLine set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (InvLInvNo.HasChanged && InvLInvNo.HasValue) {
					SQL += ", InvLInvNo=@InvLInvNoValue";

				}
								if (InvLLineNo.HasChanged && InvLLineNo.HasValue) {
					SQL += ", InvLLineNo=@InvLLineNoValue";

				}
								if (InvLDesc.HasChanged && InvLDesc.HasValue) {
					SQL += ", InvLDesc=@InvLDescValue";

				}
								if (InvLVATCode.HasChanged && InvLVATCode.HasValue) {
					SQL += ", InvLVATCode=@InvLVATCodeValue";

				}
								if (InvLVATRate.HasChanged && InvLVATRate.HasValue) {
					SQL += ", InvLVATRate=@InvLVATRateValue";

				}
								if (InvLAmt.HasChanged && InvLAmt.HasValue) {
					SQL += ", InvLAmt=@InvLAmtValue";

				}
								if (InvLVATAmt.HasChanged && InvLVATAmt.HasValue) {
					SQL += ", InvLVATAmt=@InvLVATAmtValue";

				}
								if (InvLTotal.HasChanged && InvLTotal.HasValue) {
					SQL += ", InvLTotal=@InvLTotalValue";

				}
								if (InvLChargeType.HasChanged && InvLChargeType.HasValue) {
					SQL += ", InvLChargeType=@InvLChargeTypeValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									InvLInvNo.HasChanged = false;
									InvLLineNo.HasChanged = false;
									InvLDesc.HasChanged = false;
									InvLVATCode.HasChanged = false;
									InvLVATRate.HasChanged = false;
									InvLAmt.HasChanged = false;
									InvLVATAmt.HasChanged = false;
									InvLTotal.HasChanged = false;
									InvLChargeType.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into InvLine(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (InvLInvNo.HasValue) {
					SQL += ", InvLInvNo";
					Values += ", @InvLInvNoValue";
				}
				
				if (InvLLineNo.HasValue) {
					SQL += ", InvLLineNo";
					Values += ", @InvLLineNoValue";
				}
				
				if (InvLDesc.HasValue) {
					SQL += ", InvLDesc";
					Values += ", @InvLDescValue";
				}
				
				if (InvLVATCode.HasValue) {
					SQL += ", InvLVATCode";
					Values += ", @InvLVATCodeValue";
				}
				
				if (InvLVATRate.HasValue) {
					SQL += ", InvLVATRate";
					Values += ", @InvLVATRateValue";
				}
				
				if (InvLAmt.HasValue) {
					SQL += ", InvLAmt";
					Values += ", @InvLAmtValue";
				}
				
				if (InvLVATAmt.HasValue) {
					SQL += ", InvLVATAmt";
					Values += ", @InvLVATAmtValue";
				}
				
				if (InvLTotal.HasValue) {
					SQL += ", InvLTotal";
					Values += ", @InvLTotalValue";
				}
				
				if (InvLChargeType.HasValue) {
					SQL += ", InvLChargeType";
					Values += ", @InvLChargeTypeValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from InvLine");
					 IQApp.DB.Execute(SQL, this);
				                    					InvLInvNo.HasChanged = false;
									InvLLineNo.HasChanged = false;
									InvLDesc.HasChanged = false;
									InvLVATCode.HasChanged = false;
									InvLVATRate.HasChanged = false;
									InvLAmt.HasChanged = false;
									InvLVATAmt.HasChanged = false;
									InvLTotal.HasChanged = false;
									InvLChargeType.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "InvLInvNo":
					return (IDSFieldBase)InvLInvNo;
								case "InvLLineNo":
					return (IDSFieldBase)InvLLineNo;
								case "InvLDesc":
					return (IDSFieldBase)InvLDesc;
								case "InvLVATCode":
					return (IDSFieldBase)InvLVATCode;
								case "InvLVATRate":
					return (IDSFieldBase)InvLVATRate;
								case "InvLAmt":
					return (IDSFieldBase)InvLAmt;
								case "InvLVATAmt":
					return (IDSFieldBase)InvLVATAmt;
								case "InvLTotal":
					return (IDSFieldBase)InvLTotal;
								case "InvLChargeType":
					return (IDSFieldBase)InvLChargeType;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "InvLInvNo":
					return InvLInvNo.DisplayValue;
								case "InvLLineNo":
					return InvLLineNo.DisplayValue;
								case "InvLDesc":
					return InvLDesc.DisplayValue;
								case "InvLVATCode":
					return InvLVATCode.DisplayValue;
								case "InvLVATRate":
					return InvLVATRate.DisplayValue;
								case "InvLAmt":
					return InvLAmt.DisplayValue;
								case "InvLVATAmt":
					return InvLVATAmt.DisplayValue;
								case "InvLTotal":
					return InvLTotal.DisplayValue;
								case "InvLChargeType":
					return InvLChargeType.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "InvLInvNo":
					return InvLInvNo.Value.ToString();
								case "InvLLineNo":
					return InvLLineNo.Value.ToString();
								case "InvLDesc":
					return InvLDesc.Value.ToString();
								case "InvLVATCode":
					return InvLVATCode.Value.ToString();
								case "InvLVATRate":
					return InvLVATRate.Value.ToString();
								case "InvLAmt":
					return InvLAmt.Value.ToString();
								case "InvLVATAmt":
					return InvLVATAmt.Value.ToString();
								case "InvLTotal":
					return InvLTotal.Value.ToString();
								case "InvLChargeType":
					return InvLChargeType.Value.ToString();
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
					foreach(var itm in DS.GetManager<InvLine>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public InvLine () : base("InvLine") {
		base.obj = this;
	
					InvLInvNo = new InvLine_InvLInvNo(this);
					InvLLineNo = new InvLine_InvLLineNo(this);
					InvLDesc = new InvLine_InvLDesc(this);
					InvLVATCode = new InvLine_InvLVATCode(this);
					InvLVATRate = new InvLine_InvLVATRate(this);
					InvLAmt = new InvLine_InvLAmt(this);
					InvLVATAmt = new InvLine_InvLVATAmt(this);
					InvLTotal = new InvLine_InvLTotal(this);
					InvLChargeType = new InvLine_InvLChargeType(this);
			}

	static InvLine () {
					InvLInvNoField = new InvLine_InvLInvNoFieldDef();
					InvLLineNoField = new InvLine_InvLLineNoFieldDef();
					InvLDescField = new InvLine_InvLDescFieldDef();
					InvLVATCodeField = new InvLine_InvLVATCodeFieldDef();
					InvLVATRateField = new InvLine_InvLVATRateFieldDef();
					InvLAmtField = new InvLine_InvLAmtFieldDef();
					InvLVATAmtField = new InvLine_InvLVATAmtFieldDef();
					InvLTotalField = new InvLine_InvLTotalFieldDef();
					InvLChargeTypeField = new InvLine_InvLChargeTypeFieldDef();
			}

	public string RecordTitle { 
		get { return InvLInvNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Invoice Lines"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/InvLine/Load/?RecId=" + RecordID.Value;
			}
			return "/InvLine/Add";
			}
	}

			
		
		[Ignore()]
		public InvLine_InvLInvNo InvLInvNo { get; set; }
		public static InvLine_InvLInvNoFieldDef InvLInvNoField { get; private set; }
        
			
			[Column("InvLInvNo")]
			public  int PopulateInvLInvNo  {
				get { return InvLInvNoValue ;}
				set { InvLInvNo.DataValue = value; }
			}

	
			public int InvLInvNoValue 
			{ 
				get 
				{
				   if(InvLInvNo.Value != null) {
				   					int i = 0;
					if (InvLInvNo != null)
					{
						if (InvLInvNo.Value != null)
						{
							if (Int32.TryParse(InvLInvNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvLInvNo.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLLineNo InvLLineNo { get; set; }
		public static InvLine_InvLLineNoFieldDef InvLLineNoField { get; private set; }
        
			
			[Column("InvLLineNo")]
			public  int PopulateInvLLineNo  {
				get { return InvLLineNoValue ;}
				set { InvLLineNo.DataValue = value; }
			}

	
			public int InvLLineNoValue 
			{ 
				get 
				{
				   if(InvLLineNo.Value != null) {
				   					int i = 0;
					if (InvLLineNo != null)
					{
						if (InvLLineNo.Value != null)
						{
							if (Int32.TryParse(InvLLineNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvLLineNo.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLDesc InvLDesc { get; set; }
		public static InvLine_InvLDescFieldDef InvLDescField { get; private set; }
        
			
			[Column("InvLDesc")]
			public  string PopulateInvLDesc  {
				get { return InvLDescValue ;}
				set { InvLDesc.DataValue = value; }
			}

	
			public string InvLDescValue 
			{ 
				get 
				{
				   if(InvLDesc.Value != null) {
				   return InvLDesc.Value.ToString(); 					}
					return "";
                
				}
				set { InvLDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLVATCode InvLVATCode { get; set; }
		public static InvLine_InvLVATCodeFieldDef InvLVATCodeField { get; private set; }
        
			
			[Column("InvLVATCode")]
			public  int PopulateInvLVATCode  {
				get { return InvLVATCodeValue ;}
				set { InvLVATCode.DataValue = value; }
			}

	
			public int InvLVATCodeValue 
			{ 
				get 
				{
				   if(InvLVATCode.Value != null) {
				   					int i = 0;
					if (InvLVATCode != null)
					{
						if (InvLVATCode.Value != null)
						{
							if (Int32.TryParse(InvLVATCode.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { InvLVATCode.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLVATRate InvLVATRate { get; set; }
		public static InvLine_InvLVATRateFieldDef InvLVATRateField { get; private set; }
        
			
			[Column("InvLVATRate")]
			public  double PopulateInvLVATRate  {
				get { return InvLVATRateValue ;}
				set { InvLVATRate.DataValue = value; }
			}

	
			public double InvLVATRateValue 
			{ 
				get 
				{
				   if(InvLVATRate.Value != null) {
				   					double i = 0.0;
					if (InvLVATRate != null)
					{
						if (InvLVATRate.Value != null)
						{
							if (Double.TryParse(InvLVATRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvLVATRate.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLAmt InvLAmt { get; set; }
		public static InvLine_InvLAmtFieldDef InvLAmtField { get; private set; }
        
			
			[Column("InvLAmt")]
			public  double PopulateInvLAmt  {
				get { return InvLAmtValue ;}
				set { InvLAmt.DataValue = value; }
			}

	
			public double InvLAmtValue 
			{ 
				get 
				{
				   if(InvLAmt.Value != null) {
				   					double i = 0.0;
					if (InvLAmt != null)
					{
						if (InvLAmt.Value != null)
						{
							if (Double.TryParse(InvLAmt.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvLAmt.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLVATAmt InvLVATAmt { get; set; }
		public static InvLine_InvLVATAmtFieldDef InvLVATAmtField { get; private set; }
        
			
			[Column("InvLVATAmt")]
			public  double PopulateInvLVATAmt  {
				get { return InvLVATAmtValue ;}
				set { InvLVATAmt.DataValue = value; }
			}

	
			public double InvLVATAmtValue 
			{ 
				get 
				{
				   if(InvLVATAmt.Value != null) {
				   					double i = 0.0;
					if (InvLVATAmt != null)
					{
						if (InvLVATAmt.Value != null)
						{
							if (Double.TryParse(InvLVATAmt.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvLVATAmt.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLTotal InvLTotal { get; set; }
		public static InvLine_InvLTotalFieldDef InvLTotalField { get; private set; }
        
			
			[Column("InvLTotal")]
			public  double PopulateInvLTotal  {
				get { return InvLTotalValue ;}
				set { InvLTotal.DataValue = value; }
			}

	
			public double InvLTotalValue 
			{ 
				get 
				{
				   if(InvLTotal.Value != null) {
				   					double i = 0.0;
					if (InvLTotal != null)
					{
						if (InvLTotal.Value != null)
						{
							if (Double.TryParse(InvLTotal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { InvLTotal.Value = value;  }
			}
			
		
		[Ignore()]
		public InvLine_InvLChargeType InvLChargeType { get; set; }
		public static InvLine_InvLChargeTypeFieldDef InvLChargeTypeField { get; private set; }
        
			
			[Column("InvLChargeType")]
			public  string PopulateInvLChargeType  {
				get { return InvLChargeTypeValue ;}
				set { InvLChargeType.DataValue = value; }
			}

	
			public string InvLChargeTypeValue 
			{ 
				get 
				{
				   if(InvLChargeType.Value != null) {
				   return InvLChargeType.Value.ToString(); 					}
					return "";
                
				}
				set { InvLChargeType.Value = value;  }
			}
	}


public class InvLine_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 7;
    public int PixelHeight => 0;
	public string Title => "Invoice Lines";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
