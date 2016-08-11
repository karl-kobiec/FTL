
	
public partial class OrderLine_OrdLPalletType : 
	DataFieldSelectBase<int,OrderLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Pallet Type";}
		set { } 
	}

	public string DFName=> "OrdLPalletType";

		public string GetDataSource() {
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPalletType").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPalletType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT PallId AS KeyValue, PallName AS Description FROM PalletType UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public OrderLine_OrdLPalletType(OrderLine Parent) : 
		base(Parent, "OrdLPalletType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class OrderLine_OrdLPalletTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPalletType").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPalletType").First().Value(new OrderLine());
		
		
			return  "SELECT PallId AS KeyValue, PallName AS Description FROM PalletType UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 75;
	}
	public string GetControlName() {
		return "OrdLPalletTypeValue";
	}
	public string GetDFName() {
		return "OrdLPalletType";
	}
	public string GetTitle() {
		return "Pallet Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		OrderLine ds;
					ds = (OrderLine)dsI;
		 
		
		return ds.OrdLPalletType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		OrderLine ds;
				ds = (OrderLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLPalletType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdLPalletType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdLPalletType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdLPalletType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdLPalletType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdLPalletType", "@OrdLPalletType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdLPalletType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("OrderLine").GetFieldOperators("OrdLPalletType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

