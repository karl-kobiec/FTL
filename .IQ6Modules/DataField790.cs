
	
public partial class SMSTemplate_SMSTQuery : 
	DataFieldSelectBase<int,SMSTemplate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Query";}
		set { } 
	}

	public string DFName=> "SMSTQuery";

		public string GetDataSource() {
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTQuery").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTQuery").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT QryId AS KeyValue, QryName AS Description FROM Query UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public SMSTemplate_SMSTQuery(SMSTemplate Parent) : 
		base(Parent, "SMSTQuery"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class SMSTemplate_SMSTQueryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTQuery").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTQuery").First().Value(new SMSTemplate());
		
		
			return  "SELECT QryId AS KeyValue, QryName AS Description FROM Query UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 790;
	}
	public string GetControlName() {
		return "SMSTQueryValue";
	}
	public string GetDFName() {
		return "SMSTQuery";
	}
	public string GetTitle() {
		return "Query";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMSTemplate ds;
					ds = (SMSTemplate)dsI;
		 
		
		return ds.SMSTQuery.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMSTemplate ds;
				ds = (SMSTemplate)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTQuery/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='SMSTQuery'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTQuery.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTQuery";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "SMSTQuery")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTQuery", "@SMSTQuery", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTQuery", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMSTemplate").GetFieldOperators("SMSTQuery", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

