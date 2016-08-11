
	
public partial class InvLine_InvLChargeType : 
	DataFieldSelectBase<string,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Charge Type";}
		set { } 
	}

	public string DFName=> "InvLChargeType";

		public string GetDataSource() {
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLChargeType").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLChargeType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.InvLChargeTypeAsQuery();		}
		return _DataSource;

	}
    
	public InvLine_InvLChargeType(InvLine Parent) : 
		base(Parent, "InvLChargeType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class InvLine_InvLChargeTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLChargeType").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLChargeType").First().Value(new InvLine());
		
		
			return DSUtil.InvLChargeTypeAsQuery();	}

	public int GetFieldUniqueId() {
		return 170;
	}
	public string GetControlName() {
		return "InvLChargeTypeValue";
	}
	public string GetDFName() {
		return "InvLChargeType";
	}
	public string GetTitle() {
		return "Charge Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLChargeType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLChargeType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvLChargeType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLChargeType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLChargeType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvLChargeType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLChargeType", "@InvLChargeType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLChargeType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLChargeType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

