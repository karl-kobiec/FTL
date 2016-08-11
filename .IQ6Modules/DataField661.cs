
	
public partial class ChangeReq_CRType : 
	DataFieldSelectBase<int,ChangeReq>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Type";}
		set { } 
	}

	public string DFName=> "CRType";

		public string GetDataSource() {
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRType").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.CRTypeAsQuery();		}
		return _DataSource;

	}
    
	public ChangeReq_CRType(ChangeReq Parent) : 
		base(Parent, "CRType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class ChangeReq_CRTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRType").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRType").First().Value(new ChangeReq());
		
		
			return DSUtil.CRTypeAsQuery();	}

	public int GetFieldUniqueId() {
		return 661;
	}
	public string GetControlName() {
		return "CRTypeValue";
	}
	public string GetDFName() {
		return "CRType";
	}
	public string GetTitle() {
		return "Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ChangeReq ds;
					ds = (ChangeReq)dsI;
		 
		
		return ds.CRType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ChangeReq ds;
				ds = (ChangeReq)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CRType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CRType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CRType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CRType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CRType", "@CRType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CRType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ChangeReq").GetFieldOperators("CRType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

