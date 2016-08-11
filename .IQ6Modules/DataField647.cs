
	
public partial class IStatRec_IStTranspMode : 
	DataFieldSelectBase<int,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Mode of Transport";}
		set { } 
	}

	public string DFName=> "IStTranspMode";

		public string GetDataSource() {
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStTranspMode").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStTranspMode").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.IStTranspModeAsQuery();		}
		return _DataSource;

	}
    
	public IStatRec_IStTranspMode(IStatRec Parent) : 
		base(Parent, "IStTranspMode"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class IStatRec_IStTranspModeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStTranspMode").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStTranspMode").First().Value(new IStatRec());
		
		
			return DSUtil.IStTranspModeAsQuery();	}

	public int GetFieldUniqueId() {
		return 647;
	}
	public string GetControlName() {
		return "IStTranspModeValue";
	}
	public string GetDFName() {
		return "IStTranspMode";
	}
	public string GetTitle() {
		return "Mode of Transport";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStTranspMode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStTranspMode/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='IStTranspMode'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStTranspMode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStTranspMode";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "IStTranspMode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStTranspMode", "@IStTranspMode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStTranspMode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStTranspMode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

