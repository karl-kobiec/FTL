
	
public partial class Inv_InvImpExp : 
	DataFieldSelectBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Import or Export";}
		set { } 
	}

	public string DFName=> "InvImpExp";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvImpExp").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvImpExp").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.InvImpExpAsQuery();		}
		return _DataSource;

	}
    
	public Inv_InvImpExp(Inv Parent) : 
		base(Parent, "InvImpExp"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvImpExpFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvImpExp").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvImpExp").First().Value(new Inv());
		
		
			return DSUtil.InvImpExpAsQuery();	}

	public int GetFieldUniqueId() {
		return 199;
	}
	public string GetControlName() {
		return "InvImpExpValue";
	}
	public string GetDFName() {
		return "InvImpExp";
	}
	public string GetTitle() {
		return "Import or Export";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvImpExp.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Inv/SaveInvImpExp/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvImpExp'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvImpExp.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvImpExp";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvImpExp")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvImpExp", "@InvImpExp", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvImpExp", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvImpExp", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

