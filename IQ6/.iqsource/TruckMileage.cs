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


public partial class TruckMileageController : DSBaseController<TruckMileage/*,TruckMileageSearch*/> {
	public TruckMileageController() : base ((IDatabase)IQApp.DB, new TruckMileageRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select TrkMTruck from TruckMileage where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<TruckMileage>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(TruckMileage data) {
						IQApp.DB.Execute("Delete from TruckMileage where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.TrkMTruckValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from TruckMileage " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from TruckMileage " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from TruckMileage " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/TruckMileage_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<TruckMileage>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<TruckMileage>("select * from TruckMileage  ").ToList();
		string urlpath = "/temp/Truck Fuel / Mileage Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Truck Fuel / Mileage");
				
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
							
					worksheet.Column(1).Width = 13;
					worksheet.Cells[1, 1].Value = "Truck";
						
								
					worksheet.Column(2).Width = 9;
					worksheet.Cells[1, 2].Value = "Date of Purchase";
						
								
					worksheet.Column(3).Width = 9;
					worksheet.Cells[1, 3].Value = "Litres purchased";
						
								
					worksheet.Column(4).Width = 9;
					worksheet.Cells[1, 4].Value = "Odometer (km)";
						
								
					worksheet.Column(5).Width = 43;
					worksheet.Cells[1, 5].Value = "Notes";
						
								
					worksheet.Column(6).Width = 9;
					worksheet.Cells[1, 6].Value = "Next reading (km)";
						
								
					worksheet.Column(7).Width = 9;
					worksheet.Cells[1, 7].Value = "Mpg";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].TrkMTruck.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].TrkMPurchDate.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].TrkMPurchLitre.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].TrkMOdometer.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].TrkMNotes.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].TrkMNextReading.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].TrkMMpg.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMTruck(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrkMTruckValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMTruck" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMTruck")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteTrkMTruck(TruckMileage m, int? id, string q) {

		
		string s = m.TrkMTruck.DataSource;
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
	public ActionResult CallbackTrkMTruck(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMTruck" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMTruck")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMPurchDate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrkMPurchDateValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchDate" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchDate")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMPurchDate(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchDate" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchDate")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMPurchLitre(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrkMPurchLitreValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchLitre" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchLitre")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMPurchLitre(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchLitre" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMPurchLitre")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMOdometer(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrkMOdometerValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMOdometer" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMOdometer")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMOdometer(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMOdometer" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMOdometer")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrkMNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNotes" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMNotes(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNotes" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMNextReading(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrkMNextReadingValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNextReading" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNextReading")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMNextReading(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNextReading" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMNextReading")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrkMMpg(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<TruckMileage>("select * from TruckMileage where RecordID=@RecId ", new { RecId = RecId}).First();
	
					double i = 0.0;
		
			bool UnableToContinue = false;

			if(!Double.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrkMMpgValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMMpg" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMMpg")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrkMMpg(TruckMileage obj) {
			
		if(DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMMpg" ).Any()) {
			foreach(var itm in DS.GetManager<TruckMileage>().OnChange.Where(f=> f.Key == "TrkMMpg")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<TruckMileage>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
					int FirstSearch = IQApp.DB.GetInt("select top 1 Id from DatasetSearch where MainDataset=32 and UserId=0");
			if(FirstSearch > 0) 
				return Redirect("/TruckMileage/Search/" + FirstSearch);
		
		return Redirect("/TruckMileage/List/");
	}

}

public partial class TruckMileageRepository : DSRepository<TruckMileage> {
	public TruckMileageRepository() : base(32, "TruckMileage", "Truck Fuel / Mileage") {
	}
}
public partial class TruckMileage 
: DatasetBase<TruckMileage>, IDSBase

  {
	  public int KeyValue => TrkMTruckValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "TrkMTruck":
			return TrkMTruckField;
				case "TrkMPurchDate":
			return TrkMPurchDateField;
				case "TrkMPurchLitre":
			return TrkMPurchLitreField;
				case "TrkMOdometer":
			return TrkMOdometerField;
				case "TrkMNotes":
			return TrkMNotesField;
				case "TrkMNextReading":
			return TrkMNextReadingField;
				case "TrkMMpg":
			return TrkMMpgField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(TrkMTruck,TrkMTruckField);
				action(TrkMPurchDate,TrkMPurchDateField);
				action(TrkMPurchLitre,TrkMPurchLitreField);
				action(TrkMOdometer,TrkMOdometerField);
				action(TrkMNotes,TrkMNotesField);
				action(TrkMNextReading,TrkMNextReadingField);
				action(TrkMMpg,TrkMMpgField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				TrkMTruck.Visible=false;TrkMPurchDate.Visible=false;TrkMPurchLitre.Visible=false;TrkMOdometer.Visible=false;TrkMNotes.Visible=false;TrkMNextReading.Visible=false;TrkMMpg.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update TruckMileage set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (TrkMTruck.HasChanged && TrkMTruck.HasValue) {
					SQL += ", TrkMTruck=@TrkMTruckValue";

				}
								if (TrkMPurchDate.HasChanged && TrkMPurchDate.HasValue) {
					SQL += ", TrkMPurchDate=@TrkMPurchDateValue";

				}
								if (TrkMPurchLitre.HasChanged && TrkMPurchLitre.HasValue) {
					SQL += ", TrkMPurchLitre=@TrkMPurchLitreValue";

				}
								if (TrkMOdometer.HasChanged && TrkMOdometer.HasValue) {
					SQL += ", TrkMOdometer=@TrkMOdometerValue";

				}
								if (TrkMNotes.HasChanged && TrkMNotes.HasValue) {
					SQL += ", TrkMNotes=@TrkMNotesValue";

				}
								if (TrkMNextReading.HasChanged && TrkMNextReading.HasValue) {
					SQL += ", TrkMNextReading=@TrkMNextReadingValue";

				}
								if (TrkMMpg.HasChanged && TrkMMpg.HasValue) {
					SQL += ", TrkMMpg=@TrkMMpgValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									TrkMTruck.HasChanged = false;
									TrkMPurchDate.HasChanged = false;
									TrkMPurchLitre.HasChanged = false;
									TrkMOdometer.HasChanged = false;
									TrkMNotes.HasChanged = false;
									TrkMNextReading.HasChanged = false;
									TrkMMpg.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into TruckMileage(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (TrkMTruck.HasValue) {
					SQL += ", TrkMTruck";
					Values += ", @TrkMTruckValue";
				}
				
				if (TrkMPurchDate.HasValue) {
					SQL += ", TrkMPurchDate";
					Values += ", @TrkMPurchDateValue";
				}
				
				if (TrkMPurchLitre.HasValue) {
					SQL += ", TrkMPurchLitre";
					Values += ", @TrkMPurchLitreValue";
				}
				
				if (TrkMOdometer.HasValue) {
					SQL += ", TrkMOdometer";
					Values += ", @TrkMOdometerValue";
				}
				
				if (TrkMNotes.HasValue) {
					SQL += ", TrkMNotes";
					Values += ", @TrkMNotesValue";
				}
				
				if (TrkMNextReading.HasValue) {
					SQL += ", TrkMNextReading";
					Values += ", @TrkMNextReadingValue";
				}
				
				if (TrkMMpg.HasValue) {
					SQL += ", TrkMMpg";
					Values += ", @TrkMMpgValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from TruckMileage");
					 IQApp.DB.Execute(SQL, this);
				                    					TrkMTruck.HasChanged = false;
									TrkMPurchDate.HasChanged = false;
									TrkMPurchLitre.HasChanged = false;
									TrkMOdometer.HasChanged = false;
									TrkMNotes.HasChanged = false;
									TrkMNextReading.HasChanged = false;
									TrkMMpg.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "TrkMTruck":
					return (IDSFieldBase)TrkMTruck;
								case "TrkMPurchDate":
					return (IDSFieldBase)TrkMPurchDate;
								case "TrkMPurchLitre":
					return (IDSFieldBase)TrkMPurchLitre;
								case "TrkMOdometer":
					return (IDSFieldBase)TrkMOdometer;
								case "TrkMNotes":
					return (IDSFieldBase)TrkMNotes;
								case "TrkMNextReading":
					return (IDSFieldBase)TrkMNextReading;
								case "TrkMMpg":
					return (IDSFieldBase)TrkMMpg;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "TrkMTruck":
					return TrkMTruck.DisplayValue;
								case "TrkMPurchDate":
					return TrkMPurchDate.DisplayValue;
								case "TrkMPurchLitre":
					return TrkMPurchLitre.DisplayValue;
								case "TrkMOdometer":
					return TrkMOdometer.DisplayValue;
								case "TrkMNotes":
					return TrkMNotes.DisplayValue;
								case "TrkMNextReading":
					return TrkMNextReading.DisplayValue;
								case "TrkMMpg":
					return TrkMMpg.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "TrkMTruck":
					return TrkMTruck.Value.ToString();
								case "TrkMPurchDate":
					return TrkMPurchDate.Value.ToString();
								case "TrkMPurchLitre":
					return TrkMPurchLitre.Value.ToString();
								case "TrkMOdometer":
					return TrkMOdometer.Value.ToString();
								case "TrkMNotes":
					return TrkMNotes.Value.ToString();
								case "TrkMNextReading":
					return TrkMNextReading.Value.ToString();
								case "TrkMMpg":
					return TrkMMpg.Value.ToString();
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
					foreach(var itm in DS.GetManager<TruckMileage>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public TruckMileage () : base("TruckMileage") {
		base.obj = this;
	
					TrkMTruck = new TruckMileage_TrkMTruck(this);
					TrkMPurchDate = new TruckMileage_TrkMPurchDate(this);
					TrkMPurchLitre = new TruckMileage_TrkMPurchLitre(this);
					TrkMOdometer = new TruckMileage_TrkMOdometer(this);
					TrkMNotes = new TruckMileage_TrkMNotes(this);
					TrkMNextReading = new TruckMileage_TrkMNextReading(this);
					TrkMMpg = new TruckMileage_TrkMMpg(this);
			}

	static TruckMileage () {
					TrkMTruckField = new TruckMileage_TrkMTruckFieldDef();
					TrkMPurchDateField = new TruckMileage_TrkMPurchDateFieldDef();
					TrkMPurchLitreField = new TruckMileage_TrkMPurchLitreFieldDef();
					TrkMOdometerField = new TruckMileage_TrkMOdometerFieldDef();
					TrkMNotesField = new TruckMileage_TrkMNotesFieldDef();
					TrkMNextReadingField = new TruckMileage_TrkMNextReadingFieldDef();
					TrkMMpgField = new TruckMileage_TrkMMpgFieldDef();
			}

	public string RecordTitle { 
		get { return TrkMTruckValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Truck Fuel / Mileage"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/TruckMileage/Load/?RecId=" + RecordID.Value;
			}
			return "/TruckMileage/Add";
			}
	}

			
		
		[Ignore()]
		public TruckMileage_TrkMTruck TrkMTruck { get; set; }
		public static TruckMileage_TrkMTruckFieldDef TrkMTruckField { get; private set; }
        
			
			[Column("TrkMTruck")]
			public  int PopulateTrkMTruck  {
				get { return TrkMTruckValue ;}
				set { TrkMTruck.DataValue = value; }
			}

	
			public int TrkMTruckValue 
			{ 
				get 
				{
				   if(TrkMTruck.Value != null) {
				   					int i = 0;
					if (TrkMTruck != null)
					{
						if (TrkMTruck.Value != null)
						{
							if (Int32.TryParse(TrkMTruck.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrkMTruck.Value = value;  }
			}
			
		
		[Ignore()]
		public TruckMileage_TrkMPurchDate TrkMPurchDate { get; set; }
		public static TruckMileage_TrkMPurchDateFieldDef TrkMPurchDateField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrkMPurchDate")]
			public  DateTime PopulateTrkMPurchDate  {
				get { return TrkMPurchDateValue ;}
				set { TrkMPurchDate.DataValue = value; }
			}

	
			public DateTime TrkMPurchDateValue 
			{ 
				get 
				{
				   if(TrkMPurchDate.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrkMPurchDate != null)
					{
						if (TrkMPurchDate.Value != null)
						{
							if (DateTime.TryParse(TrkMPurchDate.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrkMPurchDate.Value = value;  }
			}
			
		
		[Ignore()]
		public TruckMileage_TrkMPurchLitre TrkMPurchLitre { get; set; }
		public static TruckMileage_TrkMPurchLitreFieldDef TrkMPurchLitreField { get; private set; }
        
			
			[Column("TrkMPurchLitre")]
			public  double PopulateTrkMPurchLitre  {
				get { return TrkMPurchLitreValue ;}
				set { TrkMPurchLitre.DataValue = value; }
			}

	
			public double TrkMPurchLitreValue 
			{ 
				get 
				{
				   if(TrkMPurchLitre.Value != null) {
				   					double i = 0.0;
					if (TrkMPurchLitre != null)
					{
						if (TrkMPurchLitre.Value != null)
						{
							if (Double.TryParse(TrkMPurchLitre.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { TrkMPurchLitre.Value = value;  }
			}
			
		
		[Ignore()]
		public TruckMileage_TrkMOdometer TrkMOdometer { get; set; }
		public static TruckMileage_TrkMOdometerFieldDef TrkMOdometerField { get; private set; }
        
			
			[Column("TrkMOdometer")]
			public  int PopulateTrkMOdometer  {
				get { return TrkMOdometerValue ;}
				set { TrkMOdometer.DataValue = value; }
			}

	
			public int TrkMOdometerValue 
			{ 
				get 
				{
				   if(TrkMOdometer.Value != null) {
				   					int i = 0;
					if (TrkMOdometer != null)
					{
						if (TrkMOdometer.Value != null)
						{
							if (Int32.TryParse(TrkMOdometer.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrkMOdometer.Value = value;  }
			}
			
		
		[Ignore()]
		public TruckMileage_TrkMNotes TrkMNotes { get; set; }
		public static TruckMileage_TrkMNotesFieldDef TrkMNotesField { get; private set; }
        
			
			[Column("TrkMNotes")]
			public  string PopulateTrkMNotes  {
				get { return TrkMNotesValue ;}
				set { TrkMNotes.DataValue = value; }
			}

	
			public string TrkMNotesValue 
			{ 
				get 
				{
				   if(TrkMNotes.Value != null) {
				   return TrkMNotes.Value.ToString(); 					}
					return "";
                
				}
				set { TrkMNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public TruckMileage_TrkMNextReading TrkMNextReading { get; set; }
		public static TruckMileage_TrkMNextReadingFieldDef TrkMNextReadingField { get; private set; }
        
			
			[Column("TrkMNextReading")]
			public  int PopulateTrkMNextReading  {
				get { return TrkMNextReadingValue ;}
				set { TrkMNextReading.DataValue = value; }
			}

	
			public int TrkMNextReadingValue 
			{ 
				get 
				{
				   if(TrkMNextReading.Value != null) {
				   					int i = 0;
					if (TrkMNextReading != null)
					{
						if (TrkMNextReading.Value != null)
						{
							if (Int32.TryParse(TrkMNextReading.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrkMNextReading.Value = value;  }
			}
			
		
		[Ignore()]
		public TruckMileage_TrkMMpg TrkMMpg { get; set; }
		public static TruckMileage_TrkMMpgFieldDef TrkMMpgField { get; private set; }
        
			
			[Column("TrkMMpg")]
			public  double PopulateTrkMMpg  {
				get { return TrkMMpgValue ;}
				set { TrkMMpg.DataValue = value; }
			}

	
			public double TrkMMpgValue 
			{ 
				get 
				{
				   if(TrkMMpg.Value != null) {
				   					double i = 0.0;
					if (TrkMMpg != null)
					{
						if (TrkMMpg.Value != null)
						{
							if (Double.TryParse(TrkMMpg.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0.0;
                
				}
				set { TrkMMpg.Value = value;  }
			}
	}


public class TruckMileage_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 32;
    public int PixelHeight => 0;
	public string Title => "Truck Fuel / Mileage";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
