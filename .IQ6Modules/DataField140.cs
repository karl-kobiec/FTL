
	
public partial class UKOrder_UKODelProof : 
	BoolDataFieldBase<UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Proof of Delivery";}
		set { } 
	}

	public string DFName=> "UKODelProof";

	
	public UKOrder_UKODelProof(UKOrder Parent) : 
		base(Parent, "UKODelProof"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class UKOrder_UKODelProofFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKODelProof").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKODelProof").First().Value(new UKOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 140;
	}
	public string GetControlName() {
		return "UKODelProofValue";
	}
	public string GetDFName() {
		return "UKODelProof";
	}
	public string GetTitle() {
		return "Proof of Delivery";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKODelProof.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKODelProof/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='UKODelProof' [[Val]] /><input type = 'hidden' data-bound-name='UKODelProof' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKODelProof.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKODelProof";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "UKODelProof")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKODelProof", "@UKODelProof", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKODelProof", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKODelProof", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

