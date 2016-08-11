
	
public partial class Inv_InvFreightDuty : 
	DataFieldSelectBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Freight or Duty";}
		set { } 
	}

	public string DFName=> "InvFreightDuty";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFreightDuty").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFreightDuty").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.InvFreightDutyAsQuery();		}
		return _DataSource;

	}
    
	public Inv_InvFreightDuty(Inv Parent) : 
		base(Parent, "InvFreightDuty"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvFreightDutyFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFreightDuty").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFreightDuty").First().Value(new Inv());
		
		
			return DSUtil.InvFreightDutyAsQuery();	}

	public int GetFieldUniqueId() {
		return 95;
	}
	public string GetControlName() {
		return "InvFreightDutyValue";
	}
	public string GetDFName() {
		return "InvFreightDuty";
	}
	public string GetTitle() {
		return "Freight or Duty";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvFreightDuty.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Inv/SaveInvFreightDuty/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvFreightDuty'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvFreightDuty.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvFreightDuty";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvFreightDuty")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvFreightDuty", "@InvFreightDuty", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvFreightDuty", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvFreightDuty", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

