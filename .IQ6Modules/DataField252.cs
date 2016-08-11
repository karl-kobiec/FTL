
	
public partial class Inv_InvCurr : 
	DataFieldSelectBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Currency";}
		set { } 
	}

	public string DFName=> "InvCurr";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvCurr").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvCurr").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return "select 0 as KeyValue, '' as [Description]";		}
		return _DataSource;

	}
    
	public Inv_InvCurr(Inv Parent) : 
		base(Parent, "InvCurr"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("1");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvCurrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvCurr").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvCurr").First().Value(new Inv());
		
		
			return "select 0 as KeyValue, '' as [Description]";	}

	public int GetFieldUniqueId() {
		return 252;
	}
	public string GetControlName() {
		return "InvCurrValue";
	}
	public string GetDFName() {
		return "InvCurr";
	}
	public string GetTitle() {
		return "Currency";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvCurr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Inv/SaveInvCurr/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvCurr'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvCurr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvCurr";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvCurr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvCurr", "@InvCurr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvCurr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvCurr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

