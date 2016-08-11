
	
public partial class Orders_OrdVATPaidBy : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Paid By";}
		set { } 
	}

	public string DFName=> "OrdVATPaidBy";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdVATPaidBy").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdVATPaidBy").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.OrdVATPaidByAsQuery();		}
		return _DataSource;

	}
    
	public Orders_OrdVATPaidBy(Orders Parent) : 
		base(Parent, "OrdVATPaidBy"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdVATPaidByFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdVATPaidBy").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdVATPaidBy").First().Value(new Orders());
		
		
			return DSUtil.OrdVATPaidByAsQuery();	}

	public int GetFieldUniqueId() {
		return 53;
	}
	public string GetControlName() {
		return "OrdVATPaidByValue";
	}
	public string GetDFName() {
		return "OrdVATPaidBy";
	}
	public string GetTitle() {
		return "VAT Paid By";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdVATPaidBy.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdVATPaidBy/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdVATPaidBy'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdVATPaidBy.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdVATPaidBy";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdVATPaidBy")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdVATPaidBy", "@OrdVATPaidBy", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdVATPaidBy", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdVATPaidBy", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

