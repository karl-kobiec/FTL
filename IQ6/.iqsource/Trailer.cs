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


public partial class TrailerController : DSBaseController<Trailer/*,TrailerSearch*/> {
	public TrailerController() : base ((IDatabase)IQApp.DB, new TrailerRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select TrlId from Trailer where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<Trailer>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(Trailer data) {
						IQApp.DB.Execute("Delete from Trailer where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.TrlFleetNoValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from Trailer " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from Trailer " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from Trailer " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/Trailer_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<Trailer>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<Trailer>("select * from Trailer  ").ToList();
		string urlpath = "/temp/Trailers Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Trailers");
				
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
							
					worksheet.Column(1).Width = 20;
					worksheet.Cells[1, 1].Value = "Fleet Number";
						
								
					worksheet.Column(2).Width = 13;
					worksheet.Cells[1, 2].Value = "Last Service";
						
								
					worksheet.Column(3).Width = 13;
					worksheet.Cells[1, 3].Value = "Next Service Due";
						
								
					worksheet.Column(4).Width = 13;
					worksheet.Cells[1, 4].Value = "Days Remaining";
						
								
					worksheet.Column(5).Width = 13;
					worksheet.Cells[1, 5].Value = "Last MOT";
						
								
					worksheet.Column(6).Width = 13;
					worksheet.Cells[1, 6].Value = "Next MOT Due";
						
								
					worksheet.Column(7).Width = 13;
					worksheet.Cells[1, 7].Value = "Status";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].TrlFleetNo.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].TrlLastServ.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].TrlNextServDue.DisplayValue;
								worksheet.Cells[j+2,4].Value = res[j].TrlDaysRem.DisplayValue;
								worksheet.Cells[j+2,5].Value = res[j].TrlLastMOT.DisplayValue;
								worksheet.Cells[j+2,6].Value = res[j].TrlNextMOTDue.DisplayValue;
								worksheet.Cells[j+2,7].Value = res[j].TrlStatus.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlFleetNo(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrlFleetNoValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlFleetNo" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlFleetNo")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlFleetNo(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlFleetNo" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlFleetNo")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlLastServ(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrlLastServValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastServ" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastServ")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlLastServ(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastServ" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastServ")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlNextServDue(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrlNextServDueValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextServDue" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextServDue")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlNextServDue(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextServDue" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextServDue")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlDaysRem(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrlDaysRemValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlDaysRem" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlDaysRem")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlDaysRem(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlDaysRem" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlDaysRem")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlLastMOT(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrlLastMOTValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastMOT" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastMOT")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlLastMOT(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastMOT" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlLastMOT")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlNextMOTDue(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					DateTime i = DateTime.MinValue;
		
			bool UnableToContinue = false;

			if(!DateTime.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.TrlNextMOTDueValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextMOTDue" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextMOTDue")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlNextMOTDue(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextMOTDue" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNextMOTDue")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlStatus(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrlStatusValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlStatus" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlStatus")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlStatus(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlStatus" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlStatus")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlNotes(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.TrlNotesValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNotes")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlNotes(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNotes" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlNotes")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveTrlId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<Trailer>("select * from Trailer where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.TrlIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlId" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlId")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackTrlId(Trailer obj) {
			
		if(DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlId" ).Any()) {
			foreach(var itm in DS.GetManager<Trailer>().OnChange.Where(f=> f.Key == "TrlId")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<Trailer>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/Trailer/List/");
	}

}

public partial class TrailerRepository : DSRepository<Trailer> {
	public TrailerRepository() : base(19, "Trailer", "Trailers") {
	}
}
public partial class Trailer 
: DatasetBase<Trailer>, IDSBase

  {
	  public int KeyValue => TrlIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "TrlFleetNo":
			return TrlFleetNoField;
				case "TrlLastServ":
			return TrlLastServField;
				case "TrlNextServDue":
			return TrlNextServDueField;
				case "TrlDaysRem":
			return TrlDaysRemField;
				case "TrlLastMOT":
			return TrlLastMOTField;
				case "TrlNextMOTDue":
			return TrlNextMOTDueField;
				case "TrlStatus":
			return TrlStatusField;
				case "TrlNotes":
			return TrlNotesField;
				case "TrlId":
			return TrlIdField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(TrlFleetNo,TrlFleetNoField);
				action(TrlLastServ,TrlLastServField);
				action(TrlNextServDue,TrlNextServDueField);
				action(TrlDaysRem,TrlDaysRemField);
				action(TrlLastMOT,TrlLastMOTField);
				action(TrlNextMOTDue,TrlNextMOTDueField);
				action(TrlStatus,TrlStatusField);
				action(TrlNotes,TrlNotesField);
				action(TrlId,TrlIdField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				TrlFleetNo.Visible=false;TrlLastServ.Visible=false;TrlNextServDue.Visible=false;TrlDaysRem.Visible=false;TrlLastMOT.Visible=false;TrlNextMOTDue.Visible=false;TrlStatus.Visible=false;TrlNotes.Visible=false;TrlId.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update Trailer set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (TrlFleetNo.HasChanged && TrlFleetNo.HasValue) {
					SQL += ", TrlFleetNo=@TrlFleetNoValue";

				}
								if (TrlLastServ.HasChanged && TrlLastServ.HasValue) {
					SQL += ", TrlLastServ=@TrlLastServValue";

				}
								if (TrlNextServDue.HasChanged && TrlNextServDue.HasValue) {
					SQL += ", TrlNextServDue=@TrlNextServDueValue";

				}
								if (TrlDaysRem.HasChanged && TrlDaysRem.HasValue) {
					SQL += ", TrlDaysRem=@TrlDaysRemValue";

				}
								if (TrlLastMOT.HasChanged && TrlLastMOT.HasValue) {
					SQL += ", TrlLastMOT=@TrlLastMOTValue";

				}
								if (TrlNextMOTDue.HasChanged && TrlNextMOTDue.HasValue) {
					SQL += ", TrlNextMOTDue=@TrlNextMOTDueValue";

				}
								if (TrlStatus.HasChanged && TrlStatus.HasValue) {
					SQL += ", TrlStatus=@TrlStatusValue";

				}
								if (TrlNotes.HasChanged && TrlNotes.HasValue) {
					SQL += ", TrlNotes=@TrlNotesValue";

				}
								if (TrlId.HasChanged && TrlId.HasValue) {
					SQL += ", TrlId=@TrlIdValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									TrlFleetNo.HasChanged = false;
									TrlLastServ.HasChanged = false;
									TrlNextServDue.HasChanged = false;
									TrlDaysRem.HasChanged = false;
									TrlLastMOT.HasChanged = false;
									TrlNextMOTDue.HasChanged = false;
									TrlStatus.HasChanged = false;
									TrlNotes.HasChanged = false;
									TrlId.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into Trailer(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				
				if (TrlFleetNo.HasValue) {
					SQL += ", TrlFleetNo";
					Values += ", @TrlFleetNoValue";
				}
				
				if (TrlLastServ.HasValue) {
					SQL += ", TrlLastServ";
					Values += ", @TrlLastServValue";
				}
				
				if (TrlNextServDue.HasValue) {
					SQL += ", TrlNextServDue";
					Values += ", @TrlNextServDueValue";
				}
				
				if (TrlDaysRem.HasValue) {
					SQL += ", TrlDaysRem";
					Values += ", @TrlDaysRemValue";
				}
				
				if (TrlLastMOT.HasValue) {
					SQL += ", TrlLastMOT";
					Values += ", @TrlLastMOTValue";
				}
				
				if (TrlNextMOTDue.HasValue) {
					SQL += ", TrlNextMOTDue";
					Values += ", @TrlNextMOTDueValue";
				}
				
				if (TrlStatus.HasValue) {
					SQL += ", TrlStatus";
					Values += ", @TrlStatusValue";
				}
				
				if (TrlNotes.HasValue) {
					SQL += ", TrlNotes";
					Values += ", @TrlNotesValue";
				}
				TrlId.Value = IQApp.DB.GetInt("select isnull(max(TrlId),0)+1 from Trailer");
				if (TrlId.HasValue) {
					SQL += ", TrlId";
					Values += ", @TrlIdValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from Trailer");
					 IQApp.DB.Execute(SQL, this);
				                    					TrlFleetNo.HasChanged = false;
									TrlLastServ.HasChanged = false;
									TrlNextServDue.HasChanged = false;
									TrlDaysRem.HasChanged = false;
									TrlLastMOT.HasChanged = false;
									TrlNextMOTDue.HasChanged = false;
									TrlStatus.HasChanged = false;
									TrlNotes.HasChanged = false;
									TrlId.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "TrlFleetNo":
					return (IDSFieldBase)TrlFleetNo;
								case "TrlLastServ":
					return (IDSFieldBase)TrlLastServ;
								case "TrlNextServDue":
					return (IDSFieldBase)TrlNextServDue;
								case "TrlDaysRem":
					return (IDSFieldBase)TrlDaysRem;
								case "TrlLastMOT":
					return (IDSFieldBase)TrlLastMOT;
								case "TrlNextMOTDue":
					return (IDSFieldBase)TrlNextMOTDue;
								case "TrlStatus":
					return (IDSFieldBase)TrlStatus;
								case "TrlNotes":
					return (IDSFieldBase)TrlNotes;
								case "TrlId":
					return (IDSFieldBase)TrlId;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "TrlFleetNo":
					return TrlFleetNo.DisplayValue;
								case "TrlLastServ":
					return TrlLastServ.DisplayValue;
								case "TrlNextServDue":
					return TrlNextServDue.DisplayValue;
								case "TrlDaysRem":
					return TrlDaysRem.DisplayValue;
								case "TrlLastMOT":
					return TrlLastMOT.DisplayValue;
								case "TrlNextMOTDue":
					return TrlNextMOTDue.DisplayValue;
								case "TrlStatus":
					return TrlStatus.DisplayValue;
								case "TrlNotes":
					return TrlNotes.DisplayValue;
								case "TrlId":
					return TrlId.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "TrlFleetNo":
					return TrlFleetNo.Value.ToString();
								case "TrlLastServ":
					return TrlLastServ.Value.ToString();
								case "TrlNextServDue":
					return TrlNextServDue.Value.ToString();
								case "TrlDaysRem":
					return TrlDaysRem.Value.ToString();
								case "TrlLastMOT":
					return TrlLastMOT.Value.ToString();
								case "TrlNextMOTDue":
					return TrlNextMOTDue.Value.ToString();
								case "TrlStatus":
					return TrlStatus.Value.ToString();
								case "TrlNotes":
					return TrlNotes.Value.ToString();
								case "TrlId":
					return TrlId.Value.ToString();
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
					foreach(var itm in DS.GetManager<Trailer>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public Trailer () : base("Trailer") {
		base.obj = this;
	
					TrlFleetNo = new Trailer_TrlFleetNo(this);
					TrlLastServ = new Trailer_TrlLastServ(this);
					TrlNextServDue = new Trailer_TrlNextServDue(this);
					TrlDaysRem = new Trailer_TrlDaysRem(this);
					TrlLastMOT = new Trailer_TrlLastMOT(this);
					TrlNextMOTDue = new Trailer_TrlNextMOTDue(this);
					TrlStatus = new Trailer_TrlStatus(this);
					TrlNotes = new Trailer_TrlNotes(this);
					TrlId = new Trailer_TrlId(this);
			}

	static Trailer () {
					TrlFleetNoField = new Trailer_TrlFleetNoFieldDef();
					TrlLastServField = new Trailer_TrlLastServFieldDef();
					TrlNextServDueField = new Trailer_TrlNextServDueFieldDef();
					TrlDaysRemField = new Trailer_TrlDaysRemFieldDef();
					TrlLastMOTField = new Trailer_TrlLastMOTFieldDef();
					TrlNextMOTDueField = new Trailer_TrlNextMOTDueFieldDef();
					TrlStatusField = new Trailer_TrlStatusFieldDef();
					TrlNotesField = new Trailer_TrlNotesFieldDef();
					TrlIdField = new Trailer_TrlIdFieldDef();
			}

	public string RecordTitle { 
		get { return TrlFleetNoValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Trailers"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/Trailer/Load/?RecId=" + RecordID.Value;
			}
			return "/Trailer/Add";
			}
	}

			
		
		[Ignore()]
		public Trailer_TrlFleetNo TrlFleetNo { get; set; }
		public static Trailer_TrlFleetNoFieldDef TrlFleetNoField { get; private set; }
        
			
			[Column("TrlFleetNo")]
			public  string PopulateTrlFleetNo  {
				get { return TrlFleetNoValue ;}
				set { TrlFleetNo.DataValue = value; }
			}

	
			public string TrlFleetNoValue 
			{ 
				get 
				{
				   if(TrlFleetNo.Value != null) {
				   return TrlFleetNo.Value.ToString(); 					}
					return "";
                
				}
				set { TrlFleetNo.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlLastServ TrlLastServ { get; set; }
		public static Trailer_TrlLastServFieldDef TrlLastServField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrlLastServ")]
			public  DateTime PopulateTrlLastServ  {
				get { return TrlLastServValue ;}
				set { TrlLastServ.DataValue = value; }
			}

	
			public DateTime TrlLastServValue 
			{ 
				get 
				{
				   if(TrlLastServ.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrlLastServ != null)
					{
						if (TrlLastServ.Value != null)
						{
							if (DateTime.TryParse(TrlLastServ.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrlLastServ.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlNextServDue TrlNextServDue { get; set; }
		public static Trailer_TrlNextServDueFieldDef TrlNextServDueField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrlNextServDue")]
			public  DateTime PopulateTrlNextServDue  {
				get { return TrlNextServDueValue ;}
				set { TrlNextServDue.DataValue = value; }
			}

	
			public DateTime TrlNextServDueValue 
			{ 
				get 
				{
				   if(TrlNextServDue.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrlNextServDue != null)
					{
						if (TrlNextServDue.Value != null)
						{
							if (DateTime.TryParse(TrlNextServDue.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrlNextServDue.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlDaysRem TrlDaysRem { get; set; }
		public static Trailer_TrlDaysRemFieldDef TrlDaysRemField { get; private set; }
        
			
			[Column("TrlDaysRem")]
			public  int PopulateTrlDaysRem  {
				get { return TrlDaysRemValue ;}
				set { TrlDaysRem.DataValue = value; }
			}

	
			public int TrlDaysRemValue 
			{ 
				get 
				{
				   if(TrlDaysRem.Value != null) {
				   					int i = 0;
					if (TrlDaysRem != null)
					{
						if (TrlDaysRem.Value != null)
						{
							if (Int32.TryParse(TrlDaysRem.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrlDaysRem.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlLastMOT TrlLastMOT { get; set; }
		public static Trailer_TrlLastMOTFieldDef TrlLastMOTField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrlLastMOT")]
			public  DateTime PopulateTrlLastMOT  {
				get { return TrlLastMOTValue ;}
				set { TrlLastMOT.DataValue = value; }
			}

	
			public DateTime TrlLastMOTValue 
			{ 
				get 
				{
				   if(TrlLastMOT.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrlLastMOT != null)
					{
						if (TrlLastMOT.Value != null)
						{
							if (DateTime.TryParse(TrlLastMOT.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrlLastMOT.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlNextMOTDue TrlNextMOTDue { get; set; }
		public static Trailer_TrlNextMOTDueFieldDef TrlNextMOTDueField { get; private set; }
        
						[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
			
			[Column("TrlNextMOTDue")]
			public  DateTime PopulateTrlNextMOTDue  {
				get { return TrlNextMOTDueValue ;}
				set { TrlNextMOTDue.DataValue = value; }
			}

	
			public DateTime TrlNextMOTDueValue 
			{ 
				get 
				{
				   if(TrlNextMOTDue.Value != null) {
				   					DateTime i = DateTime.MinValue;
					if (TrlNextMOTDue != null)
					{
						if (TrlNextMOTDue.Value != null)
						{
							if (DateTime.TryParse(TrlNextMOTDue.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return DateTime.MinValue;
                
				}
				set { TrlNextMOTDue.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlStatus TrlStatus { get; set; }
		public static Trailer_TrlStatusFieldDef TrlStatusField { get; private set; }
        
			
			[Column("TrlStatus")]
			public  string PopulateTrlStatus  {
				get { return TrlStatusValue ;}
				set { TrlStatus.DataValue = value; }
			}

	
			public string TrlStatusValue 
			{ 
				get 
				{
				   if(TrlStatus.Value != null) {
				   return TrlStatus.Value.ToString(); 					}
					return "";
                
				}
				set { TrlStatus.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlNotes TrlNotes { get; set; }
		public static Trailer_TrlNotesFieldDef TrlNotesField { get; private set; }
        
			
			[Column("TrlNotes")]
			public  string PopulateTrlNotes  {
				get { return TrlNotesValue ;}
				set { TrlNotes.DataValue = value; }
			}

	
			public string TrlNotesValue 
			{ 
				get 
				{
				   if(TrlNotes.Value != null) {
				   return TrlNotes.Value.ToString(); 					}
					return "";
                
				}
				set { TrlNotes.Value = value;  }
			}
			
		
		[Ignore()]
		public Trailer_TrlId TrlId { get; set; }
		public static Trailer_TrlIdFieldDef TrlIdField { get; private set; }
        
			
			[Column("TrlId")]
			public  int PopulateTrlId  {
				get { return TrlIdValue ;}
				set { TrlId.DataValue = value; }
			}

	
			public int TrlIdValue 
			{ 
				get 
				{
				   if(TrlId.Value != null) {
				   					int i = 0;
					if (TrlId != null)
					{
						if (TrlId.Value != null)
						{
							if (Int32.TryParse(TrlId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { TrlId.Value = value;  }
			}
	}


public class Trailer_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 19;
    public int PixelHeight => 0;
	public string Title => "Trailers";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
