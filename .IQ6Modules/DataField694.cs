
	
public partial class EMail_EMStatus : 
	DataFieldSelectBase<int,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Status";}
		set { } 
	}

	public string DFName=> "EMStatus";

		public string GetDataSource() {
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMStatus").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMStatus").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.EMStatusAsQuery();		}
		return _DataSource;

	}
    
	public EMail_EMStatus(EMail Parent) : 
		base(Parent, "EMStatus"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class EMail_EMStatusFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMStatus").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMStatus").First().Value(new EMail());
		
		
			return DSUtil.EMStatusAsQuery();	}

	public int GetFieldUniqueId() {
		return 694;
	}
	public string GetControlName() {
		return "EMStatusValue";
	}
	public string GetDFName() {
		return "EMStatus";
	}
	public string GetTitle() {
		return "Status";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMStatus.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMStatus/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='EMStatus'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMStatus.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMStatus";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "EMStatus")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMStatus", "@EMStatus", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMStatus", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMStatus", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

