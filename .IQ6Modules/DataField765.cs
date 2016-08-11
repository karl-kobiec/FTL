
	
public partial class SMS_SMSTemplate : 
	DataFieldSelectBase<int,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Template";}
		set { } 
	}

	public string DFName=> "SMSTemplate";

		public string GetDataSource() {
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSTemplate").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSTemplate").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT SMSTId AS KeyValue, SMSTName AS Description FROM SMSTemplate UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public SMS_SMSTemplate(SMS Parent) : 
		base(Parent, "SMSTemplate"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class SMS_SMSTemplateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSTemplate").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSTemplate").First().Value(new SMS());
		
		
			return  "SELECT SMSTId AS KeyValue, SMSTName AS Description FROM SMSTemplate UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 765;
	}
	public string GetControlName() {
		return "SMSTemplateValue";
	}
	public string GetDFName() {
		return "SMSTemplate";
	}
	public string GetTitle() {
		return "Template";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSTemplate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSTemplate/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='SMSTemplate'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTemplate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTemplate";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "SMSTemplate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTemplate", "@SMSTemplate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTemplate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSTemplate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

