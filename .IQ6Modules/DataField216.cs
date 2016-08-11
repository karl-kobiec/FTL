
	
public partial class CN_CNNote2 : 
	DataFieldSelectBase<int,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Comment 2";}
		set { } 
	}

	public string DFName=> "CNNote2";

		public string GetDataSource() {
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote2").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote2").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT InvCId AS KeyValue, InvCName AS Description FROM InvComment UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CN_CNNote2(CN Parent) : 
		base(Parent, "CNNote2"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CN_CNNote2FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote2").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNote2").First().Value(new CN());
		
		
			return  "SELECT InvCId AS KeyValue, InvCName AS Description FROM InvComment UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 216;
	}
	public string GetControlName() {
		return "CNNote2Value";
	}
	public string GetDFName() {
		return "CNNote2";
	}
	public string GetTitle() {
		return "Comment 2";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNNote2.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CN/SaveCNNote2/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CNNote2'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNNote2.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNNote2";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CNNote2")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNNote2", "@CNNote2", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNNote2", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNNote2", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

