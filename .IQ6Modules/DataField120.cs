
	
public partial class InvLine_InvLVATCode : 
	DataFieldSelectBase<int,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Code";}
		set { } 
	}

	public string DFName=> "InvLVATCode";

		public string GetDataSource() {
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATCode").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATCode").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT VATId AS KeyValue, VATName AS Description FROM VATCodes UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public InvLine_InvLVATCode(InvLine Parent) : 
		base(Parent, "InvLVATCode"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class InvLine_InvLVATCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATCode").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATCode").First().Value(new InvLine());
		
		
			return  "SELECT VATId AS KeyValue, VATName AS Description FROM VATCodes UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 120;
	}
	public string GetControlName() {
		return "InvLVATCodeValue";
	}
	public string GetDFName() {
		return "InvLVATCode";
	}
	public string GetTitle() {
		return "VAT Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLVATCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLVATCode/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvLVATCode'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLVATCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLVATCode";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvLVATCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLVATCode", "@InvLVATCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLVATCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLVATCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

