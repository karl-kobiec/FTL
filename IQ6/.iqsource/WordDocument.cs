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


public partial class WordDocumentController : DSBaseController<WordDocument/*,WordDocumentSearch*/> {
	public WordDocumentController() : base ((IDatabase)IQApp.DB, new WordDocumentRepository()) {

	}

	[ValidateInput(false)]
	public ActionResult Delete(int RecId) {
		var Key = IQApp.DB.GetInt("select WrDocId from WordDocument where RecordID=@RecId", new { RecId = RecId});

		
		string Msg = "Are you sure you want to delete this record?";
				
					
		return IQJS(IQApp.CR.Popup("Delete", Msg, new List<WebButton>() {
			WebButton.CallbackButton<WordDocument>("Delete", DeleteClick),
				WebButton.ClosePopupButton("Close", "btn-info", "float:left")
		}));
    }
			
	public void DeleteClick(WordDocument data) {
						IQApp.DB.Execute("Delete from WordDocument where RecordID=@RecId", new { RecId = data.RecordID});
			IQApp.CR.UrlToLoad("/?message=" + data.WrDocTitleValue + " has been removed.");
		}
			
	

	public ActionResult ListFromQuery(string Clause, string Ord, int? Limit) {
			
		Clause  = string.IsNullOrEmpty(Clause) ? " " : " WHERE " + Clause + " ";
		Ord = string.IsNullOrEmpty(Ord) ? "" : " ORDER BY " + Ord;

		string Query = "select * from WordDocument " + Clause + Ord;
		ViewBag.MoreResults = false;
		ViewBag.Clause = Clause;
		ViewBag.Ord = Ord;
		if(Limit.HasValue) {
			int ResultCount = IQApp.DB.GetInt("select count(*) from WordDocument " + Clause);
			if(ResultCount > Limit) {
				Query = "select top " + Limit.Value + " * from WordDocument " + Clause + Ord;
				ViewBag.MoreResults = true;
				ViewBag.Limit = Limit.Value;
				ViewBag.ResultCount = ResultCount;
			}
		}
		return IQView("~/Views/WordDocument_List_" + IQApp.User.GetSecurityGroup() + ".cshtml", 
				IQApp.DB.Load<WordDocument>(Query).ToList());
				
	}
	
	
	public ActionResult ExportAll() {
			
		var res = IQApp.DB.Load<WordDocument>("select * from WordDocument  ").ToList();
		string urlpath = "/temp/Word Document Export-" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
		string path = Server.MapPath(urlpath);
		if(System.IO.File.Exists(path)) 
			System.IO.File.Delete(path);

		using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
        {
			ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Word Document");
				
            worksheet.Cells.Style.Font.Size = 9;
            worksheet.Cells.Style.Font.Name = "Calibri";
            worksheet.Cells.Style.WrapText = true;

			using (var range = worksheet.Cells[1, 1, 1, 4])
			{
				range.Style.Font.Bold = true;
                range.Style.Font.Size = 11;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
			}
							
					worksheet.Column(1).Width = 25;
					worksheet.Cells[1, 1].Value = "Title";
						
								
					worksheet.Column(2).Width = 12;
					worksheet.Cells[1, 2].Value = "Category";
						
								
					worksheet.Column(3).Width = 62;
					worksheet.Cells[1, 3].Value = "Query";
						
				
				for(int j = 0; j < res.Count(); j++) {
					
									worksheet.Cells[j+2,1].Value = res[j].WrDocTitle.DisplayValue;
								worksheet.Cells[j+2,2].Value = res[j].WrDocCategory.DisplayValue;
								worksheet.Cells[j+2,3].Value = res[j].WrDocQuery.DisplayValue;
								
			}

			package.Save();
				 
        return Redirect(urlpath);

		}
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocId(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.WrDocIdValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocId" || f.Key == "Id" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWrDocId(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocId"  || f.Key == "Id" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocId" || f.Key == "Id" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocTemplate(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WrDocTemplateValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTemplate"  || f.Key == "TemplateFile" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTemplate" || f.Key == "TemplateFile" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
					CR.AddJS("$('#FilesFor-WrDocTemplateValue').load('/WordDocument/Update" + Request["ScreenInfo"] + "/?RecId=" + RecId + "');");
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWrDocTemplate(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTemplate"  || f.Key == "TemplateFile" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTemplate" || f.Key == "TemplateFile" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocTitle(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WrDocTitleValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTitle"  || f.Key == "Name" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTitle" || f.Key == "Name" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWrDocTitle(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTitle"  || f.Key == "Name" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocTitle" || f.Key == "Name" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocDataset(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WrDocDatasetValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocDataset"  || f.Key == "Dataset" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocDataset" || f.Key == "Dataset" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteWrDocDataset(WordDocument m, int? id, string q) {

		
		string s = m.WrDocDataset.DataSource;
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
	public ActionResult CallbackWrDocDataset(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocDataset"  || f.Key == "Dataset" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocDataset" || f.Key == "Dataset" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocQuery(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WrDocQueryValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQuery"  || f.Key == "Query" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQuery" || f.Key == "Query" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteWrDocQuery(WordDocument m, int? id, string q) {

		
		string s = m.WrDocQuery.DataSource;
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
	public ActionResult CallbackWrDocQuery(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQuery"  || f.Key == "Query" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQuery" || f.Key == "Query" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocCategory(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WrDocCategoryValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocCategory"  || f.Key == "Category" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocCategory" || f.Key == "Category" )) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWrDocCategory(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocCategory"  || f.Key == "Category" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocCategory" || f.Key == "Category" )) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocQueryType(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
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
			ds.WrDocQueryTypeValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQueryType" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQueryType")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

		
		[ValidateInput(false)]
		public ActionResult AutoCompleteWrDocQueryType(WordDocument m, int? id, string q) {

		
		string s = m.WrDocQueryType.DataSource;
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
	public ActionResult CallbackWrDocQueryType(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQueryType" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocQueryType")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocBuiltInQuery(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					if(Request["NewValue[]"] != null) {
				NewValue = Request["NewValue[]"].ToString();
			}
			ds.WrDocBuiltInQueryValue =NewValue;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocBuiltInQuery" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocBuiltInQuery")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWrDocBuiltInQuery(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocBuiltInQuery" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocBuiltInQuery")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult SaveWrDocUseSimple(string NewValue, int RecId) {
		var ds = IQApp.DB.Load<WordDocument>("select * from WordDocument where RecordID=@RecId ", new { RecId = RecId}).First();
	
					bool i = false;
		
			bool UnableToContinue = false;

			if(!Boolean.TryParse(NewValue.ToString(), out i)) {
									UnableToContinue=true;
							}
			if(UnableToContinue) {
				return IQJS(IQApp.CR.InfoMessage("Unable to save changes, invalid value"));
			}
			ds.WrDocUseSimpleValue =i;
		
		var CR = IQApp.CR;
		
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocUseSimple" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocUseSimple")) {
					itm.Value(ds);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(ds);

		ds.Save();
			
		
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult CallbackWrDocUseSimple(WordDocument obj) {
			
		if(DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocUseSimple" ).Any()) {
			foreach(var itm in DS.GetManager<WordDocument>().OnChange.Where(f=> f.Key == "WrDocUseSimple")) {
				itm.Value(obj);
			}
		}

		IQApp.CR.TransferToWebAction<WordDocument>(obj);
		return IQJS(IQApp.CR);
	}

	
	[ValidateInput(false)]
	public ActionResult ListOrSearch() {
		
		return Redirect("/WordDocument/List/");
	}

}

public partial class WordDocumentRepository : DSRepository<WordDocument> {
	public WordDocumentRepository() : base(46, "WordDocument", "Word Document") {
	}
}
public partial class WordDocument 
: DatasetBase<WordDocument>, IDSBase
, Intrinsiq.WordDocument.IWordDocument
  {
	  public int KeyValue => WrDocIdValue;
  public IFieldDefinition GetFieldDef(string DF) {
	switch(DF) {
	
				case "WrDocId":
			return WrDocIdField;
				case "WrDocTemplate":
			return WrDocTemplateField;
				case "WrDocTitle":
			return WrDocTitleField;
				case "WrDocDataset":
			return WrDocDatasetField;
				case "WrDocQuery":
			return WrDocQueryField;
				case "WrDocCategory":
			return WrDocCategoryField;
				case "WrDocQueryType":
			return WrDocQueryTypeField;
				case "WrDocBuiltInQuery":
			return WrDocBuiltInQueryField;
				case "WrDocUseSimple":
			return WrDocUseSimpleField;
			}
	return null;
  }

  public override void ForEachDataField(Action<IDSFieldBase, IFieldDefinition> action) {
				action(WrDocId,WrDocIdField);
				action(WrDocTemplate,WrDocTemplateField);
				action(WrDocTitle,WrDocTitleField);
				action(WrDocDataset,WrDocDatasetField);
				action(WrDocQuery,WrDocQueryField);
				action(WrDocCategory,WrDocCategoryField);
				action(WrDocQueryType,WrDocQueryTypeField);
				action(WrDocBuiltInQuery,WrDocBuiltInQueryField);
				action(WrDocUseSimple,WrDocUseSimpleField);
			}
	public void PrepareForSecGroup(int id) {
		switch(id) {
					case 1:
							break;
					case 2:
							break;
					case 3:
				WrDocId.Visible=false;WrDocTemplate.Visible=false;WrDocTitle.Visible=false;WrDocDataset.Visible=false;WrDocQuery.Visible=false;WrDocCategory.Visible=false;WrDocQueryType.Visible=false;WrDocBuiltInQuery.Visible=false;WrDocUseSimple.Visible=false;			break;
				}
	}

		

	
		public override int Save() {
			if (RecordID.HasValue)
            {
                string SQL = "update WordDocument set RecordLocked="
                        + (RecordLocked ? "1" : "0") + ", CreatedBy = CreatedBy, Updated=getdate(), UpdatedBy=" + IQApp.User.GetUserId() + "";
								if (WrDocId.HasChanged && WrDocId.HasValue) {
					SQL += ", WrDocId=@WrDocIdValue";

				}
								if (WrDocTemplate.HasChanged && WrDocTemplate.HasValue) {
					SQL += ", WrDocTemplate=@WrDocTemplateValue";

				}
								if (WrDocTitle.HasChanged && WrDocTitle.HasValue) {
					SQL += ", WrDocTitle=@WrDocTitleValue";

				}
								if (WrDocDataset.HasChanged && WrDocDataset.HasValue) {
					SQL += ", WrDocDataset=@WrDocDatasetValue";

				}
								if (WrDocQuery.HasChanged && WrDocQuery.HasValue) {
					SQL += ", WrDocQuery=@WrDocQueryValue";

				}
								if (WrDocCategory.HasChanged && WrDocCategory.HasValue) {
					SQL += ", WrDocCategory=@WrDocCategoryValue";

				}
								if (WrDocQueryType.HasChanged && WrDocQueryType.HasValue) {
					SQL += ", WrDocQueryType=@WrDocQueryTypeValue";

				}
								if (WrDocBuiltInQuery.HasChanged && WrDocBuiltInQuery.HasValue) {
					SQL += ", WrDocBuiltInQuery=@WrDocBuiltInQueryValue";

				}
								if (WrDocUseSimple.HasChanged && WrDocUseSimple.HasValue) {
					SQL += ", WrDocUseSimple=@WrDocUseSimpleValue";

				}
									
				SQL += " where RecordID=" + RecordID.Value;
                IQApp.DB.Execute(SQL, this);
									WrDocId.HasChanged = false;
									WrDocTemplate.HasChanged = false;
									WrDocTitle.HasChanged = false;
									WrDocDataset.HasChanged = false;
									WrDocQuery.HasChanged = false;
									WrDocCategory.HasChanged = false;
									WrDocQueryType.HasChanged = false;
									WrDocBuiltInQuery.HasChanged = false;
									WrDocUseSimple.HasChanged = false;
				
                return RecordID.Value;
            }
            else
            {
                Created = DateTime.Now;
                Updated = DateTime.Now;
				if(!CreatedBy.HasValue) CreatedBy = IQApp.User.GetUserId();
				if(!UpdatedBy.HasValue) UpdatedBy = IQApp.User.GetUserId();
				
                string SQL = "insert into WordDocument(RecordID,Created,CreatedBy,Updated,UpdatedBy,RecordLocked";
                string Values = "@RecordID,@Created,@CreatedBy,@Updated,@UpdatedBy,@RecordLocked";
                
				WrDocId.Value = IQApp.DB.GetInt("select isnull(max(WrDocId),0)+1 from WordDocument");
				if (WrDocId.HasValue) {
					SQL += ", WrDocId";
					Values += ", @WrDocIdValue";
				}
				
				if (WrDocTemplate.HasValue) {
					SQL += ", WrDocTemplate";
					Values += ", @WrDocTemplateValue";
				}
				
				if (WrDocTitle.HasValue) {
					SQL += ", WrDocTitle";
					Values += ", @WrDocTitleValue";
				}
				
				if (WrDocDataset.HasValue) {
					SQL += ", WrDocDataset";
					Values += ", @WrDocDatasetValue";
				}
				
				if (WrDocQuery.HasValue) {
					SQL += ", WrDocQuery";
					Values += ", @WrDocQueryValue";
				}
				
				if (WrDocCategory.HasValue) {
					SQL += ", WrDocCategory";
					Values += ", @WrDocCategoryValue";
				}
				
				if (WrDocQueryType.HasValue) {
					SQL += ", WrDocQueryType";
					Values += ", @WrDocQueryTypeValue";
				}
				
				if (WrDocBuiltInQuery.HasValue) {
					SQL += ", WrDocBuiltInQuery";
					Values += ", @WrDocBuiltInQueryValue";
				}
				
				if (WrDocUseSimple.HasValue) {
					SQL += ", WrDocUseSimple";
					Values += ", @WrDocUseSimpleValue";
				}
				 
                    SQL += ") values (" + Values + ")";
                                    RecordID = IQApp.DB.GetInt("select isnull(max(RecordID),0)+1 from WordDocument");
					 IQApp.DB.Execute(SQL, this);
				                    					WrDocId.HasChanged = false;
									WrDocTemplate.HasChanged = false;
									WrDocTitle.HasChanged = false;
									WrDocDataset.HasChanged = false;
									WrDocQuery.HasChanged = false;
									WrDocCategory.HasChanged = false;
									WrDocQueryType.HasChanged = false;
									WrDocBuiltInQuery.HasChanged = false;
									WrDocUseSimple.HasChanged = false;
				                    return RecordID.Value;
                }
       

		}

		public IDSFieldBase GetField(string DFName) {
			switch(DFName){ 
								case "WrDocId":
					return (IDSFieldBase)WrDocId;
								case "WrDocTemplate":
					return (IDSFieldBase)WrDocTemplate;
								case "WrDocTitle":
					return (IDSFieldBase)WrDocTitle;
								case "WrDocDataset":
					return (IDSFieldBase)WrDocDataset;
								case "WrDocQuery":
					return (IDSFieldBase)WrDocQuery;
								case "WrDocCategory":
					return (IDSFieldBase)WrDocCategory;
								case "WrDocQueryType":
					return (IDSFieldBase)WrDocQueryType;
								case "WrDocBuiltInQuery":
					return (IDSFieldBase)WrDocBuiltInQuery;
								case "WrDocUseSimple":
					return (IDSFieldBase)WrDocUseSimple;
							}
			return null;
		}

		public string GetDisplayValue(string DFName) {
			switch(DFName){ 
								case "WrDocId":
					return WrDocId.DisplayValue;
								case "WrDocTemplate":
					return WrDocTemplate.DisplayValue;
								case "WrDocTitle":
					return WrDocTitle.DisplayValue;
								case "WrDocDataset":
					return WrDocDataset.DisplayValue;
								case "WrDocQuery":
					return WrDocQuery.DisplayValue;
								case "WrDocCategory":
					return WrDocCategory.DisplayValue;
								case "WrDocQueryType":
					return WrDocQueryType.DisplayValue;
								case "WrDocBuiltInQuery":
					return WrDocBuiltInQuery.DisplayValue;
								case "WrDocUseSimple":
					return WrDocUseSimple.DisplayValue;
							}
			return "";
		}

		public string GetValue(string DFName) {
			switch(DFName){ 
								case "WrDocId":
					return WrDocId.Value.ToString();
								case "WrDocTemplate":
					return WrDocTemplate.Value.ToString();
								case "WrDocTitle":
					return WrDocTitle.Value.ToString();
								case "WrDocDataset":
					return WrDocDataset.Value.ToString();
								case "WrDocQuery":
					return WrDocQuery.Value.ToString();
								case "WrDocCategory":
					return WrDocCategory.Value.ToString();
								case "WrDocQueryType":
					return WrDocQueryType.Value.ToString();
								case "WrDocBuiltInQuery":
					return WrDocBuiltInQuery.Value.ToString();
								case "WrDocUseSimple":
					return WrDocUseSimple.Value.ToString();
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
					foreach(var itm in DS.GetManager<WordDocument>().OnDrawScreens) {
						_CachedSubForms = itm(this,_CachedSubForms);
					}
				}
				return _CachedSubForms;
			}
		}

		
	public WordDocument () : base("WordDocument") {
		base.obj = this;
	
					WrDocId = new WordDocument_WrDocId(this);
					WrDocTemplate = new WordDocument_WrDocTemplate(this);
					WrDocTitle = new WordDocument_WrDocTitle(this);
					WrDocDataset = new WordDocument_WrDocDataset(this);
					WrDocQuery = new WordDocument_WrDocQuery(this);
					WrDocCategory = new WordDocument_WrDocCategory(this);
					WrDocQueryType = new WordDocument_WrDocQueryType(this);
					WrDocBuiltInQuery = new WordDocument_WrDocBuiltInQuery(this);
					WrDocUseSimple = new WordDocument_WrDocUseSimple(this);
			}

	static WordDocument () {
					WrDocIdField = new WordDocument_WrDocIdFieldDef();
					WrDocTemplateField = new WordDocument_WrDocTemplateFieldDef();
					WrDocTitleField = new WordDocument_WrDocTitleFieldDef();
					WrDocDatasetField = new WordDocument_WrDocDatasetFieldDef();
					WrDocQueryField = new WordDocument_WrDocQueryFieldDef();
					WrDocCategoryField = new WordDocument_WrDocCategoryFieldDef();
					WrDocQueryTypeField = new WordDocument_WrDocQueryTypeFieldDef();
					WrDocBuiltInQueryField = new WordDocument_WrDocBuiltInQueryFieldDef();
					WrDocUseSimpleField = new WordDocument_WrDocUseSimpleFieldDef();
			}

	public string RecordTitle { 
		get { return WrDocTitleValue.ToString(); }
	}
	
	public string DSNiceName { 
		get { return "Word Document"; }
		}
	

	public string DataUrl {
		get{
			if(RecordID.HasValue) {
				return "/WordDocument/Load/?RecId=" + RecordID.Value;
			}
			return "/WordDocument/Add";
			}
	}

			
		
		[Ignore()]
		public WordDocument_WrDocId WrDocId { get; set; }
		public static WordDocument_WrDocIdFieldDef WrDocIdField { get; private set; }
        
			
			[Column("WrDocId")]
			public  int PopulateWrDocId  {
				get { return WrDocIdValue ;}
				set { WrDocId.DataValue = value; }
			}

			public int Id {
			get { return WrDocIdValue ; }
			set { WrDocIdValue  = value; } 
		}
		[IQFieldName("WrDocId")]
		public IDSFieldBase  IdField { 
			get { return (IDSFieldBase)WrDocId; } 
			set { WrDocId = (WordDocument_WrDocId)value; }
		}
	
			public int WrDocIdValue 
			{ 
				get 
				{
				   if(WrDocId.Value != null) {
				   					int i = 0;
					if (WrDocId != null)
					{
						if (WrDocId.Value != null)
						{
							if (Int32.TryParse(WrDocId.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { WrDocId.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocTemplate WrDocTemplate { get; set; }
		public static WordDocument_WrDocTemplateFieldDef WrDocTemplateField { get; private set; }
        
			
			[Column("WrDocTemplate")]
			public  string PopulateWrDocTemplate  {
				get { return WrDocTemplateValue ;}
				set { WrDocTemplate.DataValue = value; }
			}

			public string TemplateFile {
			get { return WrDocTemplateValue ; }
			set { WrDocTemplateValue  = value; } 
		}
		[IQFieldName("WrDocTemplate")]
		public IDSFieldBase  TemplateFileField { 
			get { return (IDSFieldBase)WrDocTemplate; } 
			set { WrDocTemplate = (WordDocument_WrDocTemplate)value; }
		}
	
			public string WrDocTemplateValue 
			{ 
				get 
				{
				   if(WrDocTemplate.Value != null) {
				   return WrDocTemplate.Value.ToString(); 					}
					return "";
                
				}
				set { WrDocTemplate.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocTitle WrDocTitle { get; set; }
		public static WordDocument_WrDocTitleFieldDef WrDocTitleField { get; private set; }
        
			
			[Column("WrDocTitle")]
			public  string PopulateWrDocTitle  {
				get { return WrDocTitleValue ;}
				set { WrDocTitle.DataValue = value; }
			}

			public string Name {
			get { return WrDocTitleValue ; }
			set { WrDocTitleValue  = value; } 
		}
		[IQFieldName("WrDocTitle")]
		public IDSFieldBase  NameField { 
			get { return (IDSFieldBase)WrDocTitle; } 
			set { WrDocTitle = (WordDocument_WrDocTitle)value; }
		}
	
			public string WrDocTitleValue 
			{ 
				get 
				{
				   if(WrDocTitle.Value != null) {
				   return WrDocTitle.Value.ToString(); 					}
					return "";
                
				}
				set { WrDocTitle.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocDataset WrDocDataset { get; set; }
		public static WordDocument_WrDocDatasetFieldDef WrDocDatasetField { get; private set; }
        
			
			[Column("WrDocDataset")]
			public  string PopulateWrDocDataset  {
				get { return WrDocDatasetValue ;}
				set { WrDocDataset.DataValue = value; }
			}

			public string Dataset {
			get { return WrDocDatasetValue ; }
			set { WrDocDatasetValue  = value; } 
		}
		[IQFieldName("WrDocDataset")]
		public IDSFieldBase  DatasetField { 
			get { return (IDSFieldBase)WrDocDataset; } 
			set { WrDocDataset = (WordDocument_WrDocDataset)value; }
		}
	
			public string WrDocDatasetValue 
			{ 
				get 
				{
				   if(WrDocDataset.Value != null) {
				   return WrDocDataset.Value.ToString(); 					}
					return "";
                
				}
				set { WrDocDataset.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocQuery WrDocQuery { get; set; }
		public static WordDocument_WrDocQueryFieldDef WrDocQueryField { get; private set; }
        
			
			[Column("WrDocQuery")]
			public  string PopulateWrDocQuery  {
				get { return WrDocQueryValue ;}
				set { WrDocQuery.DataValue = value; }
			}

			public string Query {
			get { return WrDocQueryValue ; }
			set { WrDocQueryValue  = value; } 
		}
		[IQFieldName("WrDocQuery")]
		public IDSFieldBase  QueryField { 
			get { return (IDSFieldBase)WrDocQuery; } 
			set { WrDocQuery = (WordDocument_WrDocQuery)value; }
		}
	
			public string WrDocQueryValue 
			{ 
				get 
				{
				   if(WrDocQuery.Value != null) {
				   return WrDocQuery.Value.ToString(); 					}
					return "";
                
				}
				set { WrDocQuery.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocCategory WrDocCategory { get; set; }
		public static WordDocument_WrDocCategoryFieldDef WrDocCategoryField { get; private set; }
        
			
			[Column("WrDocCategory")]
			public  string PopulateWrDocCategory  {
				get { return WrDocCategoryValue ;}
				set { WrDocCategory.DataValue = value; }
			}

			public string Category {
			get { return WrDocCategoryValue ; }
			set { WrDocCategoryValue  = value; } 
		}
		[IQFieldName("WrDocCategory")]
		public IDSFieldBase  CategoryField { 
			get { return (IDSFieldBase)WrDocCategory; } 
			set { WrDocCategory = (WordDocument_WrDocCategory)value; }
		}
	
			public string WrDocCategoryValue 
			{ 
				get 
				{
				   if(WrDocCategory.Value != null) {
				   return WrDocCategory.Value.ToString(); 					}
					return "";
                
				}
				set { WrDocCategory.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocQueryType WrDocQueryType { get; set; }
		public static WordDocument_WrDocQueryTypeFieldDef WrDocQueryTypeField { get; private set; }
        
			
			[Column("WrDocQueryType")]
			public  int PopulateWrDocQueryType  {
				get { return WrDocQueryTypeValue ;}
				set { WrDocQueryType.DataValue = value; }
			}

	
			public int WrDocQueryTypeValue 
			{ 
				get 
				{
				   if(WrDocQueryType.Value != null) {
				   					int i = 0;
					if (WrDocQueryType != null)
					{
						if (WrDocQueryType.Value != null)
						{
							if (Int32.TryParse(WrDocQueryType.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return 0;
                
				}
				set { WrDocQueryType.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocBuiltInQuery WrDocBuiltInQuery { get; set; }
		public static WordDocument_WrDocBuiltInQueryFieldDef WrDocBuiltInQueryField { get; private set; }
        
			
			[Column("WrDocBuiltInQuery")]
			public  string PopulateWrDocBuiltInQuery  {
				get { return WrDocBuiltInQueryValue ;}
				set { WrDocBuiltInQuery.DataValue = value; }
			}

	
			public string WrDocBuiltInQueryValue 
			{ 
				get 
				{
				   if(WrDocBuiltInQuery.Value != null) {
				   return WrDocBuiltInQuery.Value.ToString(); 					}
					return "";
                
				}
				set { WrDocBuiltInQuery.Value = value;  }
			}
			
		
		[Ignore()]
		public WordDocument_WrDocUseSimple WrDocUseSimple { get; set; }
		public static WordDocument_WrDocUseSimpleFieldDef WrDocUseSimpleField { get; private set; }
        
			
			[Column("WrDocUseSimple")]
			public  bool PopulateWrDocUseSimple  {
				get { return WrDocUseSimpleValue ;}
				set { WrDocUseSimple.DataValue = value; }
			}

	
			public bool WrDocUseSimpleValue 
			{ 
				get 
				{
				   if(WrDocUseSimple.Value != null) {
				   					bool i = false;
					if (WrDocUseSimple != null)
					{
						if (WrDocUseSimple.Value != null)
						{
							if (Boolean.TryParse(WrDocUseSimple.Value.ToString(), out i))
								return i;
						}
					}
					return i;
										}
					return false;
                
				}
				set { WrDocUseSimple.Value = value;  }
			}
	}


public class WordDocument_ListScreen : IScreen
{
	public bool CustomScreen => false;
    public bool AllowedToDraw => true;
    public int Id => 46;
    public int PixelHeight => 0;
	public string Title => "Word Document";
     
    public string DrawContents(IDSBase dataset, string FormID)
    {
        throw new NotImplementedException();
    }
}

}
