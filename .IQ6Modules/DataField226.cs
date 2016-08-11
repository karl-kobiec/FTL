
	
public partial class CNLine_CNLVATCode : 
	DataFieldSelectBase<int,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Code";}
		set { } 
	}

	public string DFName=> "CNLVATCode";

		public string GetDataSource() {
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATCode").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATCode").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT VATId AS KeyValue, VATName AS Description FROM VATCodes UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CNLine_CNLVATCode(CNLine Parent) : 
		base(Parent, "CNLVATCode"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CNLine_CNLVATCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATCode").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATCode").First().Value(new CNLine());
		
		
			return  "SELECT VATId AS KeyValue, VATName AS Description FROM VATCodes UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 226;
	}
	public string GetControlName() {
		return "CNLVATCodeValue";
	}
	public string GetDFName() {
		return "CNLVATCode";
	}
	public string GetTitle() {
		return "VAT Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLVATCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLVATCode/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CNLVATCode'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLVATCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLVATCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								foreach(var itm in IQApp.DB.Load<Pair<string, string>>(GetDataSource())) {
					ret += "<option value='" + itm.KeyValue + "'" + (filterValue == itm.KeyValue ? "selected=selected" : "") + ">" + itm.Description + "</option>";
				}
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLVATCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLVATCode", "@CNLVATCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLVATCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLVATCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

