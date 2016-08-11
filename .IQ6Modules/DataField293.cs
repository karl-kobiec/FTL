
	
public partial class InvBatch_InvBType : 
	DataFieldSelectBase<int,InvBatch>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Type";}
		set { } 
	}

	public string DFName=> "InvBType";

		public string GetDataSource() {
		if(DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBType").Any()) 
			return DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.InvBTypeAsQuery();		}
		return _DataSource;

	}
    
	public InvBatch_InvBType(InvBatch Parent) : 
		base(Parent, "InvBType"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class InvBatch_InvBTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBType").Any()) 
			return DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBType").First().Value(new InvBatch());
		
		
			return DSUtil.InvBTypeAsQuery();	}

	public int GetFieldUniqueId() {
		return 293;
	}
	public string GetControlName() {
		return "InvBTypeValue";
	}
	public string GetDFName() {
		return "InvBType";
	}
	public string GetTitle() {
		return "Invoice Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvBatch ds;
					ds = (InvBatch)dsI;
		 
		
		return ds.InvBType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvBatch ds;
				ds = (InvBatch)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvBType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvBType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvBType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvBType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvBType", "@InvBType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvBType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvBatch").GetFieldOperators("InvBType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

