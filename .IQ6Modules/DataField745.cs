
	
public partial class Staff_StfSG : 
	DataFieldSelectBase<int,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Security Groups";}
		set { } 
	}

	public string DFName=> "StfSG";

		public string GetDataSource() {
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfSG").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfSG").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.StfSGAsQuery();		}
		return _DataSource;

	}
    
	public Staff_StfSG(Staff Parent) : 
		base(Parent, "StfSG"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Staff_StfSGFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfSG").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfSG").First().Value(new Staff());
		
		
			return DSUtil.StfSGAsQuery();	}

	public int GetFieldUniqueId() {
		return 745;
	}
	public string GetControlName() {
		return "StfSGValue";
	}
	public string GetDFName() {
		return "StfSG";
	}
	public string GetTitle() {
		return "Security Groups";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfSG.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Staff/SaveStfSG/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='StfSG'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfSG.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfSG";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "StfSG")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfSG", "@StfSG", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfSG", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfSG", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

