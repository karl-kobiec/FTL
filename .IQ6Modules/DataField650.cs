
	
public partial class IStatRec_IStMonth : 
	DataFieldAutoCompleteSingleBase<int,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Month";}
		set { } 
	}

	public string DFName=> "IStMonth";

		public string GetDataSource() {
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStMonth").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStMonth").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT MthId AS KeyValue, MthName AS Description FROM Months UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public IStatRec_IStMonth(IStatRec Parent) : 
		base(Parent, "IStMonth"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class IStatRec_IStMonthFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStMonth").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStMonth").First().Value(new IStatRec());
		
		
			return  "SELECT MthId AS KeyValue, MthName AS Description FROM Months UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 650;
	}
	public string GetControlName() {
		return "IStMonthValue";
	}
	public string GetDFName() {
		return "IStMonth";
	}
	public string GetTitle() {
		return "Month";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStMonth.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/IStatRec/AutoCompleteIStMonth/' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStMonth/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='IStMonth'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStMonth.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStMonth";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/IStatRec/AutoCompleteIStMonth/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStMonth")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStMonth", "@IStMonth", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStMonth", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStMonth", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

