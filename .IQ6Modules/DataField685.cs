
	
public partial class EMail_EMName : 
	DataFieldSelectBase<int,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "E-mail";}
		set { } 
	}

	public string DFName=> "EMName";

		public string GetDataSource() {
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMName").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMName").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT EMTId AS KeyValue, EMTName AS Description FROM EMType UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public EMail_EMName(EMail Parent) : 
		base(Parent, "EMName"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class EMail_EMNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMName").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMName").First().Value(new EMail());
		
		
			return  "SELECT EMTId AS KeyValue, EMTName AS Description FROM EMType UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 685;
	}
	public string GetControlName() {
		return "EMNameValue";
	}
	public string GetDFName() {
		return "EMName";
	}
	public string GetTitle() {
		return "E-mail";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMName/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='EMName'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMName";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "EMName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMName", "@EMName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

