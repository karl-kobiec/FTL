
	
public partial class IStatRec_IStOriginCtry : 
	DataFieldSelectBase<string,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Country (Origin)";}
		set { } 
	}

	public string DFName=> "IStOriginCtry";

		public string GetDataSource() {
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStOriginCtry").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStOriginCtry").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CtryId AS KeyValue, CtryName AS Description FROM Country UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public IStatRec_IStOriginCtry(IStatRec Parent) : 
		base(Parent, "IStOriginCtry"
			
		)
    {
				Enabled = true; 
		
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class IStatRec_IStOriginCtryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStOriginCtry").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStOriginCtry").First().Value(new IStatRec());
		
		
			return  "SELECT CtryId AS KeyValue, CtryName AS Description FROM Country UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 649;
	}
	public string GetControlName() {
		return "IStOriginCtryValue";
	}
	public string GetDFName() {
		return "IStOriginCtry";
	}
	public string GetTitle() {
		return "Country (Origin)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStOriginCtry.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStOriginCtry/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='IStOriginCtry'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStOriginCtry.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStOriginCtry";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "IStOriginCtry")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStOriginCtry", "@IStOriginCtry", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStOriginCtry", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStOriginCtry", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

