
	
public partial class SMSTemplate_SMSTDataset : 
	DataFieldSelectBase<string,SMSTemplate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Applies To";}
		set { } 
	}

	public string DFName=> "SMSTDataset";

		public string GetDataSource() {
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTDataset").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTDataset").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  IQApp.Datasets.DatasetsAsQuery();		}
		return _DataSource;

	}
    
	public SMSTemplate_SMSTDataset(SMSTemplate Parent) : 
		base(Parent, "SMSTDataset"
			
		)
    {
				Enabled = true; 
		
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class SMSTemplate_SMSTDatasetFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTDataset").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTDataset").First().Value(new SMSTemplate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 762;
	}
	public string GetControlName() {
		return "SMSTDatasetValue";
	}
	public string GetDFName() {
		return "SMSTDataset";
	}
	public string GetTitle() {
		return "Applies To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMSTemplate ds;
					ds = (SMSTemplate)dsI;
		 
		
		return ds.SMSTDataset.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMSTemplate ds;
				ds = (SMSTemplate)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTDataset/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='SMSTDataset'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTDataset.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTDataset";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSTDataset")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTDataset", "@SMSTDataset", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTDataset", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMSTemplate").GetFieldOperators("SMSTDataset", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

