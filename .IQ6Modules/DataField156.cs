
	
public partial class Orders_OrdJobLetter : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Letter";}
		set { } 
	}

	public string DFName=> "OrdJobLetter";

	
	public Orders_OrdJobLetter(Orders Parent) : 
		base(Parent, "OrdJobLetter"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdJobLetterFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJobLetter").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJobLetter").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 156;
	}
	public string GetControlName() {
		return "OrdJobLetterValue";
	}
	public string GetDFName() {
		return "OrdJobLetter";
	}
	public string GetTitle() {
		return "Job Letter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdJobLetter.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdJobLetter/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdJobLetter' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdJobLetter.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdJobLetter";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdJobLetter")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdJobLetter", "@OrdJobLetter", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdJobLetter", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdJobLetter", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

