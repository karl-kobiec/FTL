
	
public partial class CNLine_CNLChargeType : 
	DataFieldSelectBase<string,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Charge Type";}
		set { } 
	}

	public string DFName=> "CNLChargeType";

		public string GetDataSource() {
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLChargeType").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLChargeType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return "select 0 as KeyValue, '' as [Description]";		}
		return _DataSource;

	}
    
	public CNLine_CNLChargeType(CNLine Parent) : 
		base(Parent, "CNLChargeType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CNLine_CNLChargeTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLChargeType").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLChargeType").First().Value(new CNLine());
		
		
			return "select 0 as KeyValue, '' as [Description]";	}

	public int GetFieldUniqueId() {
		return 231;
	}
	public string GetControlName() {
		return "CNLChargeTypeValue";
	}
	public string GetDFName() {
		return "CNLChargeType";
	}
	public string GetTitle() {
		return "Charge Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLChargeType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLChargeType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CNLChargeType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLChargeType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLChargeType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CNLChargeType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLChargeType", "@CNLChargeType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLChargeType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLChargeType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

