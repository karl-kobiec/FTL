
	
public partial class Alerts_AlrtUserID : 
	DataFieldSelectBase<int,Alerts>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "User";}
		set { } 
	}

	public string DFName=> "AlrtUserID";

		public string GetDataSource() {
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtUserID").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtUserID").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "";		}
		return _DataSource;

	}
    
	public Alerts_AlrtUserID(Alerts Parent) : 
		base(Parent, "AlrtUserID"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Alerts_AlrtUserIDFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtUserID").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtUserID").First().Value(new Alerts());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 778;
	}
	public string GetControlName() {
		return "AlrtUserIDValue";
	}
	public string GetDFName() {
		return "AlrtUserID";
	}
	public string GetTitle() {
		return "User";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Alerts ds;
					ds = (Alerts)dsI;
		 
		
		return ds.AlrtUserID.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Alerts ds;
				ds = (Alerts)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Alerts/SaveAlrtUserID/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='AlrtUserID'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.AlrtUserID.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "AlrtUserID";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "AlrtUserID")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "AlrtUserID", "@AlrtUserID", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "AlrtUserID", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Alerts").GetFieldOperators("AlrtUserID", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

