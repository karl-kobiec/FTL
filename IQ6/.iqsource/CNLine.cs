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


public partial class CNLineController : DSBaseController<CNLine/*,CNLineSearch*/> {
	public CNLineController() : base ((IDatabase)IQApp.DB, new CNLineRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select CNLNo from CNLine where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<CNLine>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(CNLine data) {
						IQApp.DB.Execute("Delete from CNLine where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.CNLNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from CNLine " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from CNLine " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from CNLine " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/CNLine_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<CNLine>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<CNLine>("select * from CNLine  ").ToList();
		string urlpath = "/temp/Credit Note Lines Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Credit Note Lines");
				
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
							
					worksheet.Column(1).Width = 10;
					worksheet.Cells[1, 1].Value = "Credit Number";
						
								
					worksheet.Column(2).Width = 7;
					worksheet.Cells[1, 2].Value = "Line Number";
						
								
					worksheet.Column(3).Width = 19;
					worksheet.Cells[1, 3].Value = "Description";
						
								
					worksheet.Column(4).Width = 14;
					worksheet.Cells[1, 4].Value = "VAT Code";
						
								
					worksheet.Column(5).Width = 7;
					worksheet.Cells[1, 5].Value = "VAT Rate";
						
								
					worksheet.Column(6).Width = 10;
					worksheet.Cells[1, 6].Value = "Line Amount";
						
								
					worksheet.Column(7).Width = 10;
					worksheet.Cells[1, 7].Value = "VAT Amount";
						
								
					worksheet.Column(8).Width = 10;
					worksheet.Cells[1, 8].Value = "Line Total";
						
								
					worksheet.Column(9).Width = 14;
					worksheet.Cells[1, 9].Value = "Charge Type";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].CNLNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].CNLLineNo.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].CNLDesc.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].CNLVATCode.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].CNLVATRate.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].CNLAmt.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].CNLVATAmt.DisplayValue;
								worksheet.Cells[j+2,8].Value = res[j].CNLTotal.DisplayValue;
								worksheet.Cells[j+2,9].Value = res[j].CNLChargeType.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNLNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLNo" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLNo(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLNo" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLLineNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNLLineNoValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLLineNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLLineNo(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLLineNo" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLLineNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLDesc(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNLDescValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLDesc" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLDesc")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLDesc(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLDesc" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLDesc")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLVATCode(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.CNLVATCodeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATCode" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATCode")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNLVATCode(CNLine m, int? id, string q) {

		
		string s = m.CNLVATCode.DataSource;
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
	public ActionResult CallbackCNLVATCode(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATCode" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATCode")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLVATRate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNLVATRateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATRate" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATRate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLVATRate(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATRate" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATRate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLAmt(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNLAmtValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLAmt" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLAmt")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLAmt(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLAmt" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLAmt")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLVATAmt(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNLVATAmtValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATAmt" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATAmt")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLVATAmt(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATAmt" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLVATAmt")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLTotal(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.CNLTotalValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLTotal" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLTotal")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackCNLTotal(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLTotal" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLTotal")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveCNLChargeType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<CNLine>("select * from CNLine where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.CNLChargeTypeValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLChargeType" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLChargeType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteCNLChargeType(CNLine m, int? id, string q) {

		
		string s = m.CNLChargeType.DataSource;
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
	public ActionResult CallbackCNLChargeType(CNLine obj) {
			
		if(DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLChargeType" ).Any()) {
			foreach(var itm in DS.GetManager<CNLine>().OnChange.Where(f=> f.Key == "CNLChargeType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<CNLine>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/CNLine/List/");
	}

}

public partial class CNLineRepository : DSRepository<CNLine> {
	public CNLineRepository() : base(16, "CNLine", "Credit Note Lines") {
	}
}
public partial class CNLine 
: DatasetBase<CNLine>, IDSBase

  {
	  public int KeyValue => CNLNoValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "CNLNo":
			return CNLNoField;
				case "CNLLineNo":
			return CNLLineNoField;
				case "CNLDesc":
			return CNLDescField;
				case "CNLVATCode":
			return CNLVATCodeField;
				case "CNLVATRate":
			return CNLVATRateField;
				case "CNLAmt":
			return CNLAmtField;
				case "CNLVATAmt":
			return CNLVATAmtField;
				case "CNLTotal":
			return CNLTotalField;
				case "CNLChargeType":
			return CNLChargeTypeField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(CNLNo,CNLNoField);
				action(CNLLineNo,CNLLineNoField);
				action(CNLDesc,CNLDescField);
				action(CNLVATCode,CNLVATCodeField);
				action(CNLVATRate,CNLVATRateField);
				action(CNLAmt,CNLAmtField);
				action(CNLVATAmt,CNLVATAmtField);
				action(CNLTotal,CNLTotalField);
				action(CNLChargeType,CNLChargeTypeField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				CNLNo.Visible=false;CNLLineNo.Visible=false;CNLDesc.Visible=false;CNLVATCode.Visible=false;CNLVATRate.Visible=false;CNLAmt.Visible=false;CNLVATAmt.Visible=false;CNLTotal.Visible=false;CNLChargeType.Visible=false;			break;
				}
	}

		

		#region Parent
        public int ParentRecID
        {
            get
            {
                if (CNLNo.Value != null)
                    return IQApp.DB.GetInt("SELECT RecordID FROM CN where CNId=@Key", new {Key= CNLNo.Value});
                return 0;
            }
            set
            {
                if (CNLNo.Value == null)
                    CNLNo.Value = IQApp.DB.GetInt("SELECT CNId FROM CN whereRecordID=@RecId", new { RecId = value});
            }
        }
        private CN _Parent;

        public CN Parent
        {
            get
            {
                if (_Parent == null)
                {
                    if (ParentRecID > 0)
                        _Parent= IQApp.DB.Load<CN>("select * from CN where RecordID=@RecId", new { RecId = ParentRecID}).First();
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
		set { Parent = (CN)value;}
		}
		#endregion
		
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update CNLine set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (CNLNo.HasChanged && CNLNo.HasValue) {
					SQL += ", CNLNo=@CNLNoValue";

				}
								if (CNLLineNo.HasChanged && CNLLineNo.HasValue) {
					SQL += ", CNLLineNo=@CNLLineNoValue";

				}
								if (CNLDesc.HasChanged && CNLDesc.HasValue) {
					SQL += ", CNLDesc=@CNLDescValue";

				}
								if (CNLVATCode.HasChanged && CNLVATCode.HasValue) {
					SQL += ", CNLVATCode=@CNLVATCodeValue";

				}
								if (CNLVATRate.HasChanged && CNLVATRate.HasValue) {
					SQL += ", CNLVATRate=@CNLVATRateValue";

				}
								if (CNLAmt.HasChanged && CNLAmt.HasValue) {
					SQL += ", CNLAmt=@CNLAmtValue";

				}
								if (CNLVATAmt.HasChanged && CNLVATAmt.HasValue) {
					SQL += ", CNLVATAmt=@CNLVATAmtValue";

				}
								if (CNLTotal.HasChanged && CNLTotal.HasValue) {
					SQL += ", CNLTotal=@CNLTotalValue";

				}
								if (CNLChargeType.HasChanged && CNLChargeType.HasValue) {
					SQL += ", CNLChargeType=@CNLChargeTypeValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									CNLNo.HasChanged = false;
									CNLLineNo.HasChanged = false;
									CNLDesc.HasChanged = false;
									CNLVATCode.HasChanged = false;
									CNLVATRate.HasChanged = false;
									CNLAmt.HasChanged = false;
									CNLVATAmt.HasChanged = false;
									CNLTotal.HasChanged = false;
									CNLChargeType.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into CNLine(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (CNLNo.HasValue) {
					SQL += ", CNLNo";
					Values += ", @CNLNoValue";
				}
				
				if (CNLLineNo.HasValue) {
					SQL += ", CNLLineNo";
					Values += ", @CNLLineNoValue";
				}
				
				if (CNLDesc.HasValue) {
					SQL += ", CNLDesc";
					Values += ", @CNLDescValue";
				}
				
				if (CNLVATCode.HasValue) {
					SQL += ", CNLVATCode";
					Values += ", @CNLVATCodeValue";
				}
				
				if (CNLVATRate.HasValue) {
					SQL += ", CNLVATRate";
					Values += ", @CNLVATRateValue";
				}
				
				if (CNLAmt.HasValue) {
					SQL += ", CNLAmt";
					Values += ", @CNLAmtValue";
				}
				
				if (CNLVATAmt.HasValue) {
					SQL += ", CNLVATAmt";
					Values += ", @CNLVATAmtValue";
				}
				
				if (CNLTotal.HasValue) {
					SQL += ", CNLTotal";
					Values += ", @CNLTotalValue";
				}
				
				if (CNLChargeType.HasValue) {
					SQL += ", CNLChargeType";
					Values += ", @CNLChargeTypeValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from CNLine");
					 IQApp.DB.Execute(SQL, this);
				                    					CNLNo.HasChanged = false;
									CNLLineNo.HasChanged = false;
									CNLDesc.HasChanged = false;
									CNLVATCode.HasChanged = false;
									CNLVATRate.HasChanged = false;
									CNLAmt.HasChanged = false;
									CNLVATAmt.HasChanged = false;
									CNLTotal.HasChanged = false;
									CNLChargeType.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "CNLNo":
					return (IDSFieldBase)CNLNo;
								case "CNLLineNo":
					return (IDSFieldBase)CNLLineNo;
								case "CNLDesc":
					return (IDSFieldBase)CNLDesc;
								case "CNLVATCode":
					return (IDSFieldBase)CNLVATCode;
								case "CNLVATRate":
					return (IDSFieldBase)CNLVATRate;
								case "CNLAmt":
					return (IDSFieldBase)CNLAmt;
								case "CNLVATAmt":
					return (IDSFieldBase)CNLVATAmt;
								case "CNLTotal":
					return (IDSFieldBase)CNLTotal;
								case "CNLChargeType":
					return (IDSFieldBase)CNLChargeType;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "CNLNo":
					return CNLNo.DisplayValue;
								case "CNLLineNo":
					return CNLLineNo.DisplayValue;
								case "CNLDesc":
					return CNLDesc.DisplayValue;
								case "CNLVATCode":
					return CNLVATCode.DisplayValue;
								case "CNLVATRate":
					return CNLVATRate.DisplayValue;
								case "CNLAmt":
					return CNLAmt.DisplayValue;
								case "CNLVATAmt":
					return CNLVATAmt.DisplayValue;
								case "CNLTotal":
					return CNLTotal.DisplayValue;
								case "CNLChargeType":
					return CNLChargeType.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "CNLNo":
					return CNLNo.Value.ToString();
								case "CNLLineNo":
					return CNLLineNo.Value.ToString();
								case "CNLDesc":
					return CNLDesc.Value.ToString();
								case "CNLVATCode":
					return CNLVATCode.Value.ToString();
								case "CNLVATRate":
					return CNLVATRate.Value.ToString();
								case "CNLAmt":
					return CNLAmt.Value.ToString();
								case "CNLVATAmt":
					return CNLVATAmt.Value.ToString();
								case "CNLTotal":
					return CNLTotal.Value.ToString();
								case "CNLChargeType":
					return CNLChargeType.Value.ToString();
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
					foreach(var itm in DS.GetManager<CNLine>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public CNLine () : base("CNLine") {
		base.obj = this;
	
					CNLNo = new CNLine_CNLNo(this);
					CNLLineNo = new CNLine_CNLLineNo(this);
					CNLDesc = new CNLine_CNLDesc(this);
					CNLVATCode = new CNLine_CNLVATCode(this);
					CNLVATRate = new CNLine_CNLVATRate(this);
					CNLAmt = new CNLine_CNLAmt(this);
					CNLVATAmt = new CNLine_CNLVATAmt(this);
					CNLTotal = new CNLine_CNLTotal(this);
					CNLChargeType = new CNLine_CNLChargeType(this);
			}

	static CNLine () {
					CNLNoField = new CNLine_CNLNoFieldDef();
					CNLLineNoField = new CNLine_CNLLineNoFieldDef();
					CNLDescField = new CNLine_CNLDescFieldDef();
					CNLVATCodeField = new CNLine_CNLVATCodeFieldDef();
					CNLVATRateField = new CNLine_CNLVATRateFieldDef();
					CNLAmtField = new CNLine_CNLAmtFieldDef();
					CNLVATAmtField = new CNLine_CNLVATAmtFieldDef();
					CNLTotalField = new CNLine_CNLTotalFieldDef();
					CNLChargeTypeField = new CNLine_CNLChargeTypeFieldDef();
			}

	public string RecordTitle { 
		get { return CNLNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Credit Note Lines"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/CNLine/Load/?RecId=" + RecordID.Value;
			}
			return "/CNLine/Add";
			}
	}

			
		
		[Ignore()]
		public CNLine_CNLNo CNLNo { get; set; }
		public static CNLine_CNLNoFieldDef CNLNoField { get; private set; }
        
			
			[Column("CNLNo")]
			public  int PopulateCNLNo  {
				get { return CNLNoValue ;}
				set { CNLNo.DataValue = value; }
			}

	
			public int CNLNoValue 
			{ 
				get 
				{
				   if(CNLNo.Value != null) {
				   					int i = 0;
					if (CNLNo != null)
					{
						if (CNLNo.Value != null)
						{
							if (Int32.TryParse(CNLNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNLNo.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLLineNo CNLLineNo { get; set; }
		public static CNLine_CNLLineNoFieldDef CNLLineNoField { get; private set; }
        
			
			[Column("CNLLineNo")]
			public  int PopulateCNLLineNo  {
				get { return CNLLineNoValue ;}
				set { CNLLineNo.DataValue = value; }
			}

	
			public int CNLLineNoValue 
			{ 
				get 
				{
				   if(CNLLineNo.Value != null) {
				   					int i = 0;
					if (CNLLineNo != null)
					{
						if (CNLLineNo.Value != null)
						{
							if (Int32.TryParse(CNLLineNo.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNLLineNo.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLDesc CNLDesc { get; set; }
		public static CNLine_CNLDescFieldDef CNLDescField { get; private set; }
        
			
			[Column("CNLDesc")]
			public  string PopulateCNLDesc  {
				get { return CNLDescValue ;}
				set { CNLDesc.DataValue = value; }
			}

	
			public string CNLDescValue 
			{ 
				get 
				{
				   if(CNLDesc.Value != null) {
				   return CNLDesc.Value.ToString(); 					}
					return "";
                
				}
				set { CNLDesc.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLVATCode CNLVATCode { get; set; }
		public static CNLine_CNLVATCodeFieldDef CNLVATCodeField { get; private set; }
        
			
			[Column("CNLVATCode")]
			public  int PopulateCNLVATCode  {
				get { return CNLVATCodeValue ;}
				set { CNLVATCode.DataValue = value; }
			}

	
			public int CNLVATCodeValue 
			{ 
				get 
				{
				   if(CNLVATCode.Value != null) {
				   					int i = 0;
					if (CNLVATCode != null)
					{
						if (CNLVATCode.Value != null)
						{
							if (Int32.TryParse(CNLVATCode.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { CNLVATCode.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLVATRate CNLVATRate { get; set; }
		public static CNLine_CNLVATRateFieldDef CNLVATRateField { get; private set; }
        
			
			[Column("CNLVATRate")]
			public  double PopulateCNLVATRate  {
				get { return CNLVATRateValue ;}
				set { CNLVATRate.DataValue = value; }
			}

	
			public double CNLVATRateValue 
			{ 
				get 
				{
				   if(CNLVATRate.Value != null) {
				   					double i = 0.0;
					if (CNLVATRate != null)
					{
						if (CNLVATRate.Value != null)
						{
							if (Double.TryParse(CNLVATRate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNLVATRate.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLAmt CNLAmt { get; set; }
		public static CNLine_CNLAmtFieldDef CNLAmtField { get; private set; }
        
			
			[Column("CNLAmt")]
			public  double PopulateCNLAmt  {
				get { return CNLAmtValue ;}
				set { CNLAmt.DataValue = value; }
			}

	
			public double CNLAmtValue 
			{ 
				get 
				{
				   if(CNLAmt.Value != null) {
				   					double i = 0.0;
					if (CNLAmt != null)
					{
						if (CNLAmt.Value != null)
						{
							if (Double.TryParse(CNLAmt.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNLAmt.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLVATAmt CNLVATAmt { get; set; }
		public static CNLine_CNLVATAmtFieldDef CNLVATAmtField { get; private set; }
        
			
			[Column("CNLVATAmt")]
			public  double PopulateCNLVATAmt  {
				get { return CNLVATAmtValue ;}
				set { CNLVATAmt.DataValue = value; }
			}

	
			public double CNLVATAmtValue 
			{ 
				get 
				{
				   if(CNLVATAmt.Value != null) {
				   					double i = 0.0;
					if (CNLVATAmt != null)
					{
						if (CNLVATAmt.Value != null)
						{
							if (Double.TryParse(CNLVATAmt.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNLVATAmt.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLTotal CNLTotal { get; set; }
		public static CNLine_CNLTotalFieldDef CNLTotalField { get; private set; }
        
			
			[Column("CNLTotal")]
			public  double PopulateCNLTotal  {
				get { return CNLTotalValue ;}
				set { CNLTotal.DataValue = value; }
			}

	
			public double CNLTotalValue 
			{ 
				get 
				{
				   if(CNLTotal.Value != null) {
				   					double i = 0.0;
					if (CNLTotal != null)
					{
						if (CNLTotal.Value != null)
						{
							if (Double.TryParse(CNLTotal.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { CNLTotal.Value = value;  }
			}
			
		
		[Ignore()]
		public CNLine_CNLChargeType CNLChargeType { get; set; }
		public static CNLine_CNLChargeTypeFieldDef CNLChargeTypeField { get; private set; }
        
			
			[Column("CNLChargeType")]
			public  string PopulateCNLChargeType  {
				get { return CNLChargeTypeValue ;}
				set { CNLChargeType.DataValue = value; }
			}

	
			public string CNLChargeTypeValue 
			{ 
				get 
				{
				   if(CNLChargeType.Value != null) {
				   return CNLChargeType.Value.ToString(); 					}
					return "";
                
				}
				set { CNLChargeType.Value = value;  }
			}
	}


public class CNLine_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 16;
    public int PixelHeight => 0;
	public string Title => "Credit Note Lines";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
