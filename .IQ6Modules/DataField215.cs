
	
public partial class CN_CNNote1 : 
	DataFieldSelectBase<int,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Comment 1";}
		set { } 
	}

	public string DFName=> "CNNote1";

		public string GetDataSource() {
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote1").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote1").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT InvCId AS KeyValue, InvCName AS Description FROM InvComment UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CN_CNNote1(CN Parent) : 
		base(Parent, "CNNote1"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CN_CNNote1FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote1").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote1").First().Value(new CN());
		
		
			return  "SELECT InvCId AS KeyValue, InvCName AS Description FROM InvComment UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 215;
	}
	public string GetControlName() {
		return "CNNote1Value";
	}
	public string GetDFName() {
		return "CNNote1";
	}
	public string GetTitle() {
		return "Comment 1";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNNote1.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CN/SaveCNNote1/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CNNote1'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNNote1.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNNote1";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CNNote1")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNNote1", "@CNNote1", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNNote1", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNNote1", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

