
	
public partial class ChangeReq_CRStatus : 
	DataFieldSelectBase<int,ChangeReq>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Status";}
		set { } 
	}

	public string DFName=> "CRStatus";

		public string GetDataSource() {
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRStatus").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRStatus").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.CRStatusAsQuery();		}
		return _DataSource;

	}
    
	public ChangeReq_CRStatus(ChangeReq Parent) : 
		base(Parent, "CRStatus"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class ChangeReq_CRStatusFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRStatus").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRStatus").First().Value(new ChangeReq());
		
		
			return DSUtil.CRStatusAsQuery();	}

	public int GetFieldUniqueId() {
		return 663;
	}
	public string GetControlName() {
		return "CRStatusValue";
	}
	public string GetDFName() {
		return "CRStatus";
	}
	public string GetTitle() {
		return "Status";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ChangeReq ds;
					ds = (ChangeReq)dsI;
		 
		
		return ds.CRStatus.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ChangeReq ds;
				ds = (ChangeReq)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRStatus/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CRStatus'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CRStatus.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CRStatus";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CRStatus")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CRStatus", "@CRStatus", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CRStatus", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ChangeReq").GetFieldOperators("CRStatus", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

