
	
public partial class IStatRec_IStConsignCtry : 
	DataFieldSelectBase<string,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Country (Consign)";}
		set { } 
	}

	public string DFName=> "IStConsignCtry";

		public string GetDataSource() {
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStConsignCtry").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStConsignCtry").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CtryId AS KeyValue, CtryName AS Description FROM Country UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public IStatRec_IStConsignCtry(IStatRec Parent) : 
		base(Parent, "IStConsignCtry"
			
		)
    {
				Enabled = true; 
		
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class IStatRec_IStConsignCtryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStConsignCtry").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStConsignCtry").First().Value(new IStatRec());
		
		
			return  "SELECT CtryId AS KeyValue, CtryName AS Description FROM Country UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 646;
	}
	public string GetControlName() {
		return "IStConsignCtryValue";
	}
	public string GetDFName() {
		return "IStConsignCtry";
	}
	public string GetTitle() {
		return "Country (Consign)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStConsignCtry.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStConsignCtry/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='IStConsignCtry'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStConsignCtry.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStConsignCtry";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "IStConsignCtry")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStConsignCtry", "@IStConsignCtry", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStConsignCtry", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStConsignCtry", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

