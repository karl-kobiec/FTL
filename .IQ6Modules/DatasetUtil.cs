

public class CustTypes {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Client'
										union select 2, 'Supplier'
										union select 3, 'Bonded Warehouse'
										union select 4, 'Duty Paid Delivery'
										union select 5, 'Transporter'
										union select 6, 'Collection Point'
										union select 7, 'Exporter'
										union select 8, 'Importer'
										union select 9, 'Clearing Agent'
					";
				}
			public const int Client = 1;public const int Supplier = 2;public const int BondedWarehouse = 3;public const int DutyPaid = 4;public const int Transporter = 5;public const int CollectionPoint = 6;public const int Exporter = 7;public const int Importer = 8;public const int ClearingAgent = 9;}public class CustCurrs {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Pound Sterling'
										union select 2, 'Euro'
										union select 3, 'US Dollar'
					";
				}
			public const int PoundSterling = 1;public const int Euro = 2;public const int USDollar = 3;}public class OrdExpImps {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Import'
										union select 2, 'Export'
					";
				}
			public const int Import = 1;public const int Export = 2;}public class OrdStatuss {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Duty Paid'
										union select 2, 'Under Bond'
					";
				}
			public const int DutyPaid = 1;public const int UnderBond = 2;}public class OrdVATPaidBys {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Client'
										union select 2, 'Consignee'
										union select 3, 'Supplier'
										union select 4, 'Delivery'
					";
				}
			public const int Client = 1;public const int Consignee = 2;public const int Supplier = 3;public const int Delivery = 4;}public class OrdBondFroms {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Client'
										union select 2, 'Consignee'
										union select 3, 'Supplier'
										union select 4, 'Delivery Point'
					";
				}
			public const int Client = 1;public const int Consignee = 2;public const int Supplier = 3;public const int DeliveryPoint = 4;}public class JobLDelPoints {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'As Order'
										union select 2, 'FTL'
					";
				}
			public const int AsOrder = 1;public const int FTL = 2;}public class JobAccMonths {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 101, 'JAN 2003'
										union select 102, 'FEB 2003'
										union select 103, 'MARCH 2003'
										union select 104, 'APRIL 2003'
										union select 105, 'MAY 2003'
										union select 106, 'JUNE 2003'
										union select 107, 'JULY  2003'
										union select 108, 'AUG 2003'
										union select 109, 'SEPT 2003'
										union select 110, 'OCT 2003'
										union select 111, 'NOV 2003'
										union select 112, 'DEC 2003'
										union select 113, 'JAN 2004'
										union select 114, 'FEB 2004'
										union select 115, 'MARCH 2004'
										union select 116, 'APRIL 2004'
										union select 117, 'MAY 2004'
										union select 118, 'JUNE 2004'
										union select 119, 'JULY  2004'
										union select 120, 'AUG 2004'
										union select 121, 'SEPT 2004'
										union select 122, 'OCT 2004'
										union select 123, 'NOV 2004'
										union select 124, 'DEC 2004'
										union select 125, 'JAN 2005'
										union select 126, 'FEB 2005'
										union select 127, 'MAR 2005'
										union select 128, 'APR 2005'
										union select 129, 'MAY 2005'
										union select 130, 'JUN 2005'
										union select 131, 'JUL 2005'
										union select 132, 'AUG 2005'
										union select 133, 'SEP 2005'
										union select 134, 'OCT 2005'
										union select 135, 'NOV 2005'
										union select 136, 'DEC 2005'
										union select 137, 'JAN 2006'
										union select 138, 'FEB 2006'
										union select 139, 'MAR 2006'
										union select 140, 'APR 2006'
										union select 141, 'MAY 2006'
										union select 142, 'JUN 2006'
										union select 143, 'JUL 2006'
										union select 144, 'AUG 2006'
										union select 145, 'SEP 2006'
										union select 146, 'OCT 2006'
										union select 147, 'NOV 2006'
										union select 148, 'DEC 2006'
										union select 149, 'JAN 2007'
										union select 150, 'FEB 2007'
										union select 255, 'DUMMY'
					";
				}
			public const int JAN2003 = 101;public const int FEB2003 = 102;public const int MARCH2003 = 103;public const int APRIL2003 = 104;public const int MAY2003 = 105;public const int JUNE2003 = 106;public const int JULY2003 = 107;public const int AUG2003 = 108;public const int SEPT2003 = 109;public const int OCT2003 = 110;public const int NOV2003 = 111;public const int DEC2003 = 112;public const int JAN2004 = 113;public const int FEB2004 = 114;public const int MARCH2004 = 115;public const int APRIL2004 = 116;public const int MAY2004 = 117;public const int JUNE2004 = 118;public const int JULY2004 = 119;public const int AUG2004 = 120;public const int SEPT2004 = 121;public const int OCT2004 = 122;public const int NOV2004 = 123;public const int DEC2004 = 124;public const int JAN2005 = 125;public const int FEB2005 = 126;public const int MAR2005 = 127;public const int APR2005 = 128;public const int MAY2005 = 129;public const int JUN2005 = 130;public const int JUL2005 = 131;public const int AUG2005 = 132;public const int SEP2005 = 133;public const int OCT2005 = 134;public const int NOV2005 = 135;public const int DEC2005 = 136;public const int JAN2006 = 137;public const int FEB2006 = 138;public const int MAR2006 = 139;public const int APR2006 = 140;public const int MAY2006 = 141;public const int JUN2006 = 142;public const int JUL2006 = 143;public const int AUG2006 = 144;public const int SEP2006 = 145;public const int OCT2006 = 146;public const int NOV2006 = 147;public const int DEC2006 = 148;public const int JAN2007 = 149;public const int FEB2007 = 150;public const int DUMMY = 255;}public class CustDelZones {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 11, 'Northampton (Tesco)'
										union select 12, 'Corsham'
										union select 13, 'Nailsea'
										union select 14, 'Burton-on-Trent'
										union select 15, 'Preston'
										union select 16, 'Rotherham'
										union select 17, 'London E16'
										union select 18, 'Hoddesdon'
										union select 19, 'Dorchester'
										union select 20, 'Barking'
										union select 21, 'Basildon (Schenker)'
										union select 22, 'Cirencester'
										union select 23, 'Tilbury'
										union select 24, 'Basildon (Eurobox)'
										union select 25, 'Coventry (Morrisons)'
										union select 26, 'Scotland'
										union select 27, 'Moulton (Tesco)'
										union select 28, 'Belvedere'
										union select 31, 'North WEST'
										union select 32, 'East Anglia'
										union select 33, 'Midlands'
										union select 34, 'Wales & Bristol'
										union select 35, 'London'
										union select 36, 'South-East'
										union select 37, 'South-West'
										union select 38, 'North EAST'
										union select 39, 'Home Counties'
										union select 40, 'Wakefield (Morrisons)'
										union select 41, 'Basingstoke'
										union select 42, 'West Hallam'
										union select 43, 'Theale (Nr Reading)'
										union select 44, 'Northampton (Morrisons)'
					";
				}
			public const int NorthamptonTesco = 11;public const int Corsham = 12;public const int Nailsea = 13;public const int BurtononTrent = 14;public const int Preston = 15;public const int Rotherham = 16;public const int LondonE16 = 17;public const int Hoddesdon = 18;public const int Dorchester = 19;public const int Barking = 20;public const int BasildonSchenker = 21;public const int Cirencester = 22;public const int Tilbury = 23;public const int BasildonEurobox = 24;public const int Coventry = 25;public const int Scotland = 26;public const int Moulton = 27;public const int Belvedere = 28;public const int NorthWEST = 31;public const int EastAnglia = 32;public const int Midlands = 33;public const int WalesBristol = 34;public const int London = 35;public const int SouthEast = 36;public const int SouthWest = 37;public const int NorthEAST = 38;public const int HomeCounties = 39;public const int Wakefield = 40;public const int Basingstoke = 41;public const int WestHallam = 42;public const int Theale = 43;public const int NorthamptonMorr = 44;}public class InvBTypes {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Import Inv'
										union select 2, 'Export Inv'
										union select 3, 'Duty Inv'
										union select 4, 'Import CN'
										union select 5, 'Export CN'
					";
				}
			public const int ImportInv = 1;public const int ExportInv = 2;public const int DutyInv = 3;public const int ImportCN = 4;public const int ExportCN = 5;}public class CustAADSyss {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Electronic'
										union select 2, 'Paper'
					";
				}
			public const int Electronic = 1;public const int Paper = 2;}public class OrdGBWKNoFroms {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 4, 'Delivery Point'
					";
				}
			public const int Delivery = 4;}public class IStNAT1s {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, '1'
										union select 2, '2'
										union select 3, '3'
										union select 4, '4'
										union select 5, '5'
										union select 6, '6'
										union select 7, '7'
										union select 8, '8'
										union select 9, '9'
					";
				}
			public const int One = 1;public const int Two = 2;public const int Three = 3;public const int Four = 4;public const int Five = 5;public const int Six = 6;public const int Seven = 7;public const int Eight = 8;public const int Nine = 9;}public class IStNAT2s {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 0, '0'
										union select 6, '6'
										union select 7, '7'
										union select 8, '8'
					";
				}
			public const int Zero = 0;public const int Six = 6;public const int Seven = 7;public const int Eight = 8;}public class IStTranspModes {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Sea'
										union select 2, 'Rail'
										union select 3, 'Road'
										union select 4, 'Air'
										union select 5, 'Post'
										union select 6, 'Not Allocated'
										union select 7, 'Fixed Installations'
										union select 8, 'Inland Waterway'
										union select 9, 'Own Propulsion'
					";
				}
			public const int Sea = 1;public const int Rail = 2;public const int Road = 3;public const int Air = 4;public const int Post = 5;public const int NotAllocated = 6;public const int FixedInstall = 7;public const int InlandWaterway = 8;public const int OwnPropulsion = 9;}public class CRTypes {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Fault / bug'
										union select 2, 'Change request'
										union select 3, 'Question'
					";
				}
			public const int FaultBug = 1;public const int Changerequest = 2;public const int Question = 3;}public class CRPrioritys {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Urgent'
										union select 2, 'High'
										union select 3, 'Medium'
										union select 4, 'Low'
					";
				}
			public const int Urgent = 1;public const int High = 2;public const int Medium = 3;public const int Low = 4;}public class CRStatuss {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Open - with Intrinsiq'
										union select 2, 'Open - with FTL'
										union select 3, 'On hold'
										union select 4, 'Closed'
					";
				}
			public const int OpenIntrinsiq = 1;public const int OpenwithFTL = 2;public const int Onhold = 3;public const int Closed = 4;}public class EMStatuss {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Unsent'
										union select 2, 'Sent'
										union select 3, 'Delete'
					";
				}
			public const int Unsent = 1;public const int Sent = 2;public const int Delete = 3;}public class StfSGs {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Full Rights'
										union select 2, 'Database User'
										union select 3, 'Customer'
					";
				}
			public const int FullRights = 1;public const int DatabaseUser = 2;public const int Customer = 3;}public class WrDocQueryTypes {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 0, 'User Written'
										union select 1, 'Built In'
					";
				}
			public const int UserWritten = 0;public const int BuiltIn = 1;}public class SMSStatuss {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'Pending'
										union select 2, 'Sent'
										union select 3, 'Delivered'
					";
				}
			public const int Pending = 1;public const int Sent = 2;public const int Delivered = 3;}public class QryTypes {
				public static string AsQuery() {
					return @"select 0 as KeyValue, '' as [Description]
										union select 1, 'SQL'
										union select 2, 'IronRuby'
										union select 3, 'Excel Report'
					";
				}
			public const int Sql = 1;public const int RUBY = 2;public const int ExcelReport = 3;}public class DSTypeContact : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "ContId":
					return "Contact ID";
							case "ContFN":
					return "Forename";
							case "ContSN":
					return "Surname";
							case "ContPhone":
					return "Phone";
							case "ContFax":
					return "Fax";
							case "ContEM":
					return "E-Mail";
							case "ContJobTitle":
					return "Job Title";
							case "ContNotes":
					return "Notes";
							case "ContMainContact":
					return "Main Contact";
							case "ContCust":
					return "Company";
							case "ContName":
					return "Full Name";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "ContId":
					return 30;
							case "ContFN":
					return 31;
							case "ContSN":
					return 32;
							case "ContPhone":
					return 33;
							case "ContFax":
					return 34;
							case "ContEM":
					return 35;
							case "ContJobTitle":
					return 36;
							case "ContNotes":
					return 37;
							case "ContMainContact":
					return 143;
							case "ContCust":
					return 424;
							case "ContName":
					return 425;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "ContId":
				return IQApp.Operators.GetNumberOperators(selected);							case "ContFN":
				return IQApp.Operators.GetTextOperators(selected);							case "ContSN":
				return IQApp.Operators.GetTextOperators(selected);							case "ContPhone":
				return IQApp.Operators.GetTextOperators(selected);							case "ContFax":
				return IQApp.Operators.GetTextOperators(selected);							case "ContEM":
				return IQApp.Operators.GetTextOperators(selected);							case "ContJobTitle":
				return IQApp.Operators.GetTextOperators(selected);							case "ContNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "ContMainContact":
				return IQApp.Operators.GetBooleanOperators(selected);							case "ContCust":
				return IQApp.Operators.GetComboOperators(selected);							case "ContName":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'ContId', 'Contact ID'
					union select 'ContFN', 'Forename'
					union select 'ContSN', 'Surname'
					union select 'ContPhone', 'Phone'
					union select 'ContFax', 'Fax'
					union select 'ContEM', 'E-Mail'
					union select 'ContJobTitle', 'Job Title'
					union select 'ContNotes', 'Notes'
					union select 'ContMainContact', 'Main Contact'
					union select 'ContCust', 'Company'
					union select 'ContName', 'Full Name'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "ContId":
					return new Contact_ContIdFieldDef();
							case "ContFN":
					return new Contact_ContFNFieldDef();
							case "ContSN":
					return new Contact_ContSNFieldDef();
							case "ContPhone":
					return new Contact_ContPhoneFieldDef();
							case "ContFax":
					return new Contact_ContFaxFieldDef();
							case "ContEM":
					return new Contact_ContEMFieldDef();
							case "ContJobTitle":
					return new Contact_ContJobTitleFieldDef();
							case "ContNotes":
					return new Contact_ContNotesFieldDef();
							case "ContMainContact":
					return new Contact_ContMainContactFieldDef();
							case "ContCust":
					return new Contact_ContCustFieldDef();
							case "ContName":
					return new Contact_ContNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, ContName as [Description] from Contact 
			where ContId like @q or ContName like @q";
	}
	
}
public class DSTypeOrders : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "OrdEMTo":
					return "E-Mail To";
							case "OrdFaxTo":
					return "Fax To";
							case "OrdAgentId":
					return "Agent ID";
							case "OrdAgent":
					return "Agent";
							case "OrdAADSys":
					return "AAD System";
							case "OrdARCRef":
					return "eAD ARC Ref";
							case "OrdCollectCtry":
					return "Collect Country";
							case "OrdSelEMTo":
					return "Select E-Mail To";
							case "OrdSelFaxTo":
					return "Select Fax To";
							case "OrdCustName":
					return "Client Name (Text)";
							case "OrdConsOrd":
					return "Consign Order No";
							case "OrdDelRef":
					return "Delivery Reference";
							case "OrdNotes":
					return "Order Notes";
							case "OrdJobNo":
					return "Job Number";
							case "OrdJobLetter":
					return "Job Letter";
							case "OrdInvoiced":
					return "Invoiced";
							case "OrdFreightInv":
					return "Freight Inv";
							case "OrdExpImp":
					return "Export or Import";
							case "OrdId":
					return "Order Number";
							case "OrdCustOrd":
					return "Client Order No";
							case "OrdDate":
					return "Order Date";
							case "OrdStatus":
					return "Status";
							case "OrdReqDate":
					return "Required Date";
							case "OrdSupp":
					return "Supplier Name";
							case "OrdSupPC":
					return "Supplier Postcode";
							case "OrdCollPoint":
					return "Collection Point";
							case "OrdCollPointPC":
					return "Collection Postcode";
							case "OrdSuppRef":
					return "Supplier Reference";
							case "OrdConsign":
					return "Consignee Name";
							case "OrdConsignPC":
					return "Consign Postcode";
							case "OrdDelPoint":
					return "Delivery Point";
							case "OrdDelPointPC":
					return "Delivery Postcode";
							case "OrdVATPaidBy":
					return "VAT Paid By";
							case "OrdVATNo":
					return "VAT Number";
							case "OrdDANNoFrom":
					return "DAN Number From";
							case "OrdDANNo":
					return "DAN Number";
							case "OrdBondFrom":
					return "REDS/Bond From";
							case "OrdBondCode":
					return "REDS/Bond Code";
							case "OrdCust":
					return "Client Name";
							case "OrdCustPC":
					return "Client Postcode";
							case "OrdDateAvail":
					return "Date Available";
							case "OrdJob":
					return "Order Job Number";
							case "OrdCollDate":
					return "Collection Date";
							case "OrdCollDate2":
					return "Collection Date 2";
							case "OrdDateDel":
					return "Date Delivered";
							case "OrdTimeAvail":
					return "Time Available";
							case "OrdDutyInv":
					return "Duty Inv";
							case "OrdPriceAllowed":
					return "Price Allowed";
							case "OrdReqdChanged":
					return "Reqd Changed";
							case "OrdAvailChanged":
					return "Available Changed";
							case "OrdCollChanged":
					return "Collected Changed";
							case "OrdDelChanged":
					return "Delivered Changed";
							case "OrdTescoRef":
					return "Tesco Ref";
							case "OrdCreatedBy":
					return "Created By";
							case "OrdGBWKNoFrom":
					return "GBWK No From";
							case "OrdGBWKNo":
					return "GBWK Number";
							case "OrdTescoPSWk":
					return "Tesco PS Wk";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "OrdEMTo":
					return 332;
							case "OrdFaxTo":
					return 333;
							case "OrdAgentId":
					return 334;
							case "OrdAgent":
					return 335;
							case "OrdAADSys":
					return 339;
							case "OrdARCRef":
					return 340;
							case "OrdCollectCtry":
					return 408;
							case "OrdSelEMTo":
					return 670;
							case "OrdSelFaxTo":
					return 671;
							case "OrdCustName":
					return 698;
							case "OrdConsOrd":
					return 696;
							case "OrdDelRef":
					return 766;
							case "OrdNotes":
					return 149;
							case "OrdJobNo":
					return 155;
							case "OrdJobLetter":
					return 156;
							case "OrdInvoiced":
					return 176;
							case "OrdFreightInv":
					return 177;
							case "OrdExpImp":
					return 38;
							case "OrdId":
					return 39;
							case "OrdCustOrd":
					return 40;
							case "OrdDate":
					return 41;
							case "OrdStatus":
					return 42;
							case "OrdReqDate":
					return 43;
							case "OrdSupp":
					return 44;
							case "OrdSupPC":
					return 45;
							case "OrdCollPoint":
					return 46;
							case "OrdCollPointPC":
					return 47;
							case "OrdSuppRef":
					return 48;
							case "OrdConsign":
					return 49;
							case "OrdConsignPC":
					return 50;
							case "OrdDelPoint":
					return 51;
							case "OrdDelPointPC":
					return 52;
							case "OrdVATPaidBy":
					return 53;
							case "OrdVATNo":
					return 54;
							case "OrdDANNoFrom":
					return 55;
							case "OrdDANNo":
					return 56;
							case "OrdBondFrom":
					return 57;
							case "OrdBondCode":
					return 58;
							case "OrdCust":
					return 59;
							case "OrdCustPC":
					return 60;
							case "OrdDateAvail":
					return 61;
							case "OrdJob":
					return 62;
							case "OrdCollDate":
					return 63;
							case "OrdCollDate2":
					return 64;
							case "OrdDateDel":
					return 66;
							case "OrdTimeAvail":
					return 192;
							case "OrdDutyInv":
					return 195;
							case "OrdPriceAllowed":
					return 245;
							case "OrdReqdChanged":
					return 246;
							case "OrdAvailChanged":
					return 247;
							case "OrdCollChanged":
					return 248;
							case "OrdDelChanged":
					return 249;
							case "OrdTescoRef":
					return 267;
							case "OrdCreatedBy":
					return 288;
							case "OrdGBWKNoFrom":
					return 344;
							case "OrdGBWKNo":
					return 345;
							case "OrdTescoPSWk":
					return 346;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "OrdEMTo":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdFaxTo":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdAgentId":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdAgent":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdAADSys":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdARCRef":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCollectCtry":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdSelEMTo":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdSelFaxTo":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdCustName":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdConsOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDelRef":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdJobLetter":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdInvoiced":
				return IQApp.Operators.GetBooleanOperators(selected);							case "OrdFreightInv":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdExpImp":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdId":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdStatus":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdReqDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdSupp":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdSupPC":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCollPoint":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdCollPointPC":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdSuppRef":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdConsign":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdConsignPC":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDelPoint":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdDelPointPC":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdVATPaidBy":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdVATNo":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDANNoFrom":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdDANNo":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdBondFrom":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdBondCode":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCust":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdCustPC":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDateAvail":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdJob":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCollDate":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCollDate2":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDateDel":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdTimeAvail":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDutyInv":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdPriceAllowed":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdReqdChanged":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdAvailChanged":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCollChanged":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdDelChanged":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdTescoRef":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdCreatedBy":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdGBWKNoFrom":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdGBWKNo":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdTescoPSWk":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'OrdEMTo', 'E-Mail To'
					union select 'OrdFaxTo', 'Fax To'
					union select 'OrdAgentId', 'Agent ID'
					union select 'OrdAgent', 'Agent'
					union select 'OrdAADSys', 'AAD System'
					union select 'OrdARCRef', 'eAD ARC Ref'
					union select 'OrdCollectCtry', 'Collect Country'
					union select 'OrdSelEMTo', 'Select E-Mail To'
					union select 'OrdSelFaxTo', 'Select Fax To'
					union select 'OrdCustName', 'Client Name (Text)'
					union select 'OrdConsOrd', 'Consign Order No'
					union select 'OrdDelRef', 'Delivery Reference'
					union select 'OrdNotes', 'Order Notes'
					union select 'OrdJobNo', 'Job Number'
					union select 'OrdJobLetter', 'Job Letter'
					union select 'OrdInvoiced', 'Invoiced'
					union select 'OrdFreightInv', 'Freight Inv'
					union select 'OrdExpImp', 'Export or Import'
					union select 'OrdId', 'Order Number'
					union select 'OrdCustOrd', 'Client Order No'
					union select 'OrdDate', 'Order Date'
					union select 'OrdStatus', 'Status'
					union select 'OrdReqDate', 'Required Date'
					union select 'OrdSupp', 'Supplier Name'
					union select 'OrdSupPC', 'Supplier Postcode'
					union select 'OrdCollPoint', 'Collection Point'
					union select 'OrdCollPointPC', 'Collection Postcode'
					union select 'OrdSuppRef', 'Supplier Reference'
					union select 'OrdConsign', 'Consignee Name'
					union select 'OrdConsignPC', 'Consign Postcode'
					union select 'OrdDelPoint', 'Delivery Point'
					union select 'OrdDelPointPC', 'Delivery Postcode'
					union select 'OrdVATPaidBy', 'VAT Paid By'
					union select 'OrdVATNo', 'VAT Number'
					union select 'OrdDANNoFrom', 'DAN Number From'
					union select 'OrdDANNo', 'DAN Number'
					union select 'OrdBondFrom', 'REDS/Bond From'
					union select 'OrdBondCode', 'REDS/Bond Code'
					union select 'OrdCust', 'Client Name'
					union select 'OrdCustPC', 'Client Postcode'
					union select 'OrdDateAvail', 'Date Available'
					union select 'OrdJob', 'Order Job Number'
					union select 'OrdCollDate', 'Collection Date'
					union select 'OrdCollDate2', 'Collection Date 2'
					union select 'OrdDateDel', 'Date Delivered'
					union select 'OrdTimeAvail', 'Time Available'
					union select 'OrdDutyInv', 'Duty Inv'
					union select 'OrdPriceAllowed', 'Price Allowed'
					union select 'OrdReqdChanged', 'Reqd Changed'
					union select 'OrdAvailChanged', 'Available Changed'
					union select 'OrdCollChanged', 'Collected Changed'
					union select 'OrdDelChanged', 'Delivered Changed'
					union select 'OrdTescoRef', 'Tesco Ref'
					union select 'OrdCreatedBy', 'Created By'
					union select 'OrdGBWKNoFrom', 'GBWK No From'
					union select 'OrdGBWKNo', 'GBWK Number'
					union select 'OrdTescoPSWk', 'Tesco PS Wk'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "OrdEMTo":
					return new Orders_OrdEMToFieldDef();
							case "OrdFaxTo":
					return new Orders_OrdFaxToFieldDef();
							case "OrdAgentId":
					return new Orders_OrdAgentIdFieldDef();
							case "OrdAgent":
					return new Orders_OrdAgentFieldDef();
							case "OrdAADSys":
					return new Orders_OrdAADSysFieldDef();
							case "OrdARCRef":
					return new Orders_OrdARCRefFieldDef();
							case "OrdCollectCtry":
					return new Orders_OrdCollectCtryFieldDef();
							case "OrdSelEMTo":
					return new Orders_OrdSelEMToFieldDef();
							case "OrdSelFaxTo":
					return new Orders_OrdSelFaxToFieldDef();
							case "OrdCustName":
					return new Orders_OrdCustNameFieldDef();
							case "OrdConsOrd":
					return new Orders_OrdConsOrdFieldDef();
							case "OrdDelRef":
					return new Orders_OrdDelRefFieldDef();
							case "OrdNotes":
					return new Orders_OrdNotesFieldDef();
							case "OrdJobNo":
					return new Orders_OrdJobNoFieldDef();
							case "OrdJobLetter":
					return new Orders_OrdJobLetterFieldDef();
							case "OrdInvoiced":
					return new Orders_OrdInvoicedFieldDef();
							case "OrdFreightInv":
					return new Orders_OrdFreightInvFieldDef();
							case "OrdExpImp":
					return new Orders_OrdExpImpFieldDef();
							case "OrdId":
					return new Orders_OrdIdFieldDef();
							case "OrdCustOrd":
					return new Orders_OrdCustOrdFieldDef();
							case "OrdDate":
					return new Orders_OrdDateFieldDef();
							case "OrdStatus":
					return new Orders_OrdStatusFieldDef();
							case "OrdReqDate":
					return new Orders_OrdReqDateFieldDef();
							case "OrdSupp":
					return new Orders_OrdSuppFieldDef();
							case "OrdSupPC":
					return new Orders_OrdSupPCFieldDef();
							case "OrdCollPoint":
					return new Orders_OrdCollPointFieldDef();
							case "OrdCollPointPC":
					return new Orders_OrdCollPointPCFieldDef();
							case "OrdSuppRef":
					return new Orders_OrdSuppRefFieldDef();
							case "OrdConsign":
					return new Orders_OrdConsignFieldDef();
							case "OrdConsignPC":
					return new Orders_OrdConsignPCFieldDef();
							case "OrdDelPoint":
					return new Orders_OrdDelPointFieldDef();
							case "OrdDelPointPC":
					return new Orders_OrdDelPointPCFieldDef();
							case "OrdVATPaidBy":
					return new Orders_OrdVATPaidByFieldDef();
							case "OrdVATNo":
					return new Orders_OrdVATNoFieldDef();
							case "OrdDANNoFrom":
					return new Orders_OrdDANNoFromFieldDef();
							case "OrdDANNo":
					return new Orders_OrdDANNoFieldDef();
							case "OrdBondFrom":
					return new Orders_OrdBondFromFieldDef();
							case "OrdBondCode":
					return new Orders_OrdBondCodeFieldDef();
							case "OrdCust":
					return new Orders_OrdCustFieldDef();
							case "OrdCustPC":
					return new Orders_OrdCustPCFieldDef();
							case "OrdDateAvail":
					return new Orders_OrdDateAvailFieldDef();
							case "OrdJob":
					return new Orders_OrdJobFieldDef();
							case "OrdCollDate":
					return new Orders_OrdCollDateFieldDef();
							case "OrdCollDate2":
					return new Orders_OrdCollDate2FieldDef();
							case "OrdDateDel":
					return new Orders_OrdDateDelFieldDef();
							case "OrdTimeAvail":
					return new Orders_OrdTimeAvailFieldDef();
							case "OrdDutyInv":
					return new Orders_OrdDutyInvFieldDef();
							case "OrdPriceAllowed":
					return new Orders_OrdPriceAllowedFieldDef();
							case "OrdReqdChanged":
					return new Orders_OrdReqdChangedFieldDef();
							case "OrdAvailChanged":
					return new Orders_OrdAvailChangedFieldDef();
							case "OrdCollChanged":
					return new Orders_OrdCollChangedFieldDef();
							case "OrdDelChanged":
					return new Orders_OrdDelChangedFieldDef();
							case "OrdTescoRef":
					return new Orders_OrdTescoRefFieldDef();
							case "OrdCreatedBy":
					return new Orders_OrdCreatedByFieldDef();
							case "OrdGBWKNoFrom":
					return new Orders_OrdGBWKNoFromFieldDef();
							case "OrdGBWKNo":
					return new Orders_OrdGBWKNoFieldDef();
							case "OrdTescoPSWk":
					return new Orders_OrdTescoPSWkFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, OrdId as [Description] from Orders 
			where OrdId like @q or OrdId like @q";
	}
	
}
public class DSTypeOrderLine : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "OrdLCustOrd":
					return "Client Order No";
							case "OrdLOrder":
					return "Order Number";
							case "OrdLLineNo":
					return "Line Number";
							case "OrdLQty":
					return "Quantity";
							case "OrdLPackageType":
					return "Package Type";
							case "OrdLSize":
					return "Size";
							case "OrdLDesc":
					return "Description";
							case "OrdLWeight":
					return "Weight";
							case "OrdLNumPallet":
					return "Number of Pallets";
							case "OrdLPalletType":
					return "Pallet Type";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "OrdLCustOrd":
					return 328;
							case "OrdLOrder":
					return 67;
							case "OrdLLineNo":
					return 68;
							case "OrdLQty":
					return 69;
							case "OrdLPackageType":
					return 70;
							case "OrdLSize":
					return 71;
							case "OrdLDesc":
					return 72;
							case "OrdLWeight":
					return 73;
							case "OrdLNumPallet":
					return 74;
							case "OrdLPalletType":
					return 75;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "OrdLCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdLOrder":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdLLineNo":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdLQty":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdLPackageType":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdLSize":
				return IQApp.Operators.GetComboOperators(selected);							case "OrdLDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "OrdLWeight":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdLNumPallet":
				return IQApp.Operators.GetNumberOperators(selected);							case "OrdLPalletType":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'OrdLCustOrd', 'Client Order No'
					union select 'OrdLOrder', 'Order Number'
					union select 'OrdLLineNo', 'Line Number'
					union select 'OrdLQty', 'Quantity'
					union select 'OrdLPackageType', 'Package Type'
					union select 'OrdLSize', 'Size'
					union select 'OrdLDesc', 'Description'
					union select 'OrdLWeight', 'Weight'
					union select 'OrdLNumPallet', 'Number of Pallets'
					union select 'OrdLPalletType', 'Pallet Type'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "OrdLCustOrd":
					return new OrderLine_OrdLCustOrdFieldDef();
							case "OrdLOrder":
					return new OrderLine_OrdLOrderFieldDef();
							case "OrdLLineNo":
					return new OrderLine_OrdLLineNoFieldDef();
							case "OrdLQty":
					return new OrderLine_OrdLQtyFieldDef();
							case "OrdLPackageType":
					return new OrderLine_OrdLPackageTypeFieldDef();
							case "OrdLSize":
					return new OrderLine_OrdLSizeFieldDef();
							case "OrdLDesc":
					return new OrderLine_OrdLDescFieldDef();
							case "OrdLWeight":
					return new OrderLine_OrdLWeightFieldDef();
							case "OrdLNumPallet":
					return new OrderLine_OrdLNumPalletFieldDef();
							case "OrdLPalletType":
					return new OrderLine_OrdLPalletTypeFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, OrdLOrder as [Description] from OrderLine 
			where OrdLOrder like @q or OrdLOrder like @q";
	}
	
}
public class DSTypeJob : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "JobNo":
					return "Job Number";
							case "JobTransp":
					return "Transporter";
							case "JobTranspRate":
					return "Transporter Rate";
							case "JobVehNo":
					return "Vehicle Number";
							case "JobTrailerNo":
					return "Trailer Number";
							case "JobFerryName":
					return "Ferry Name";
							case "JobFerryDate":
					return "Ferry Date";
							case "JobFerryTime":
					return "Ferry Time";
							case "JobRouteFrom":
					return "Route From";
							case "JobRouteTo":
					return "Route To";
							case "JobCreatedBy":
					return "Created By";
							case "JobAccMonth":
					return "Accounting Month";
							case "JobChecked":
					return "Checked";
							case "JobId":
					return "Job Id";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "JobNo":
					return 76;
							case "JobTransp":
					return 77;
							case "JobTranspRate":
					return 78;
							case "JobVehNo":
					return 79;
							case "JobTrailerNo":
					return 80;
							case "JobFerryName":
					return 81;
							case "JobFerryDate":
					return 82;
							case "JobFerryTime":
					return 83;
							case "JobRouteFrom":
					return 84;
							case "JobRouteTo":
					return 85;
							case "JobCreatedBy":
					return 289;
							case "JobAccMonth":
					return 196;
							case "JobChecked":
					return 241;
							case "JobId":
					return 428;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "JobNo":
				return IQApp.Operators.GetTextOperators(selected);							case "JobTransp":
				return IQApp.Operators.GetComboOperators(selected);							case "JobTranspRate":
				return IQApp.Operators.GetTextOperators(selected);							case "JobVehNo":
				return IQApp.Operators.GetTextOperators(selected);							case "JobTrailerNo":
				return IQApp.Operators.GetTextOperators(selected);							case "JobFerryName":
				return IQApp.Operators.GetTextOperators(selected);							case "JobFerryDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "JobFerryTime":
				return IQApp.Operators.GetTextOperators(selected);							case "JobRouteFrom":
				return IQApp.Operators.GetComboOperators(selected);							case "JobRouteTo":
				return IQApp.Operators.GetComboOperators(selected);							case "JobCreatedBy":
				return IQApp.Operators.GetComboOperators(selected);							case "JobAccMonth":
				return IQApp.Operators.GetComboOperators(selected);							case "JobChecked":
				return IQApp.Operators.GetBooleanOperators(selected);							case "JobId":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'JobNo', 'Job Number'
					union select 'JobTransp', 'Transporter'
					union select 'JobTranspRate', 'Transporter Rate'
					union select 'JobVehNo', 'Vehicle Number'
					union select 'JobTrailerNo', 'Trailer Number'
					union select 'JobFerryName', 'Ferry Name'
					union select 'JobFerryDate', 'Ferry Date'
					union select 'JobFerryTime', 'Ferry Time'
					union select 'JobRouteFrom', 'Route From'
					union select 'JobRouteTo', 'Route To'
					union select 'JobCreatedBy', 'Created By'
					union select 'JobAccMonth', 'Accounting Month'
					union select 'JobChecked', 'Checked'
					union select 'JobId', 'Job Id'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "JobNo":
					return new Job_JobNoFieldDef();
							case "JobTransp":
					return new Job_JobTranspFieldDef();
							case "JobTranspRate":
					return new Job_JobTranspRateFieldDef();
							case "JobVehNo":
					return new Job_JobVehNoFieldDef();
							case "JobTrailerNo":
					return new Job_JobTrailerNoFieldDef();
							case "JobFerryName":
					return new Job_JobFerryNameFieldDef();
							case "JobFerryDate":
					return new Job_JobFerryDateFieldDef();
							case "JobFerryTime":
					return new Job_JobFerryTimeFieldDef();
							case "JobRouteFrom":
					return new Job_JobRouteFromFieldDef();
							case "JobRouteTo":
					return new Job_JobRouteToFieldDef();
							case "JobCreatedBy":
					return new Job_JobCreatedByFieldDef();
							case "JobAccMonth":
					return new Job_JobAccMonthFieldDef();
							case "JobChecked":
					return new Job_JobCheckedFieldDef();
							case "JobId":
					return new Job_JobIdFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, JobNo as [Description] from Job 
			where JobId like @q or JobNo like @q";
	}
	
}
public class DSTypeJobLine : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "JobLDelPoint":
					return "Delivery Point";
							case "JobLDelDate":
					return "Delivery Date";
							case "JobLDelTime":
					return "Delivery Time";
							case "JobLDelRef":
					return "Delivery Ref";
							case "JobLJobNo":
					return "Job Number";
							case "JobLLineLetter":
					return "Line Letter";
							case "JobLOrder":
					return "Order Number";
							case "JobLCust":
					return "Customer";
							case "JobLCollDate":
					return "Collection Date";
							case "JobLCollDate2":
					return "Collection Date 2";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "JobLDelPoint":
					return 158;
							case "JobLDelDate":
					return 159;
							case "JobLDelTime":
					return 160;
							case "JobLDelRef":
					return 161;
							case "JobLJobNo":
					return 88;
							case "JobLLineLetter":
					return 89;
							case "JobLOrder":
					return 90;
							case "JobLCust":
					return 91;
							case "JobLCollDate":
					return 92;
							case "JobLCollDate2":
					return 93;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "JobLDelPoint":
				return IQApp.Operators.GetComboOperators(selected);							case "JobLDelDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "JobLDelTime":
				return IQApp.Operators.GetTextOperators(selected);							case "JobLDelRef":
				return IQApp.Operators.GetTextOperators(selected);							case "JobLJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "JobLLineLetter":
				return IQApp.Operators.GetTextOperators(selected);							case "JobLOrder":
				return IQApp.Operators.GetNumberOperators(selected);							case "JobLCust":
				return IQApp.Operators.GetTextOperators(selected);							case "JobLCollDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "JobLCollDate2":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'JobLDelPoint', 'Delivery Point'
					union select 'JobLDelDate', 'Delivery Date'
					union select 'JobLDelTime', 'Delivery Time'
					union select 'JobLDelRef', 'Delivery Ref'
					union select 'JobLJobNo', 'Job Number'
					union select 'JobLLineLetter', 'Line Letter'
					union select 'JobLOrder', 'Order Number'
					union select 'JobLCust', 'Customer'
					union select 'JobLCollDate', 'Collection Date'
					union select 'JobLCollDate2', 'Collection Date 2'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "JobLDelPoint":
					return new JobLine_JobLDelPointFieldDef();
							case "JobLDelDate":
					return new JobLine_JobLDelDateFieldDef();
							case "JobLDelTime":
					return new JobLine_JobLDelTimeFieldDef();
							case "JobLDelRef":
					return new JobLine_JobLDelRefFieldDef();
							case "JobLJobNo":
					return new JobLine_JobLJobNoFieldDef();
							case "JobLLineLetter":
					return new JobLine_JobLLineLetterFieldDef();
							case "JobLOrder":
					return new JobLine_JobLOrderFieldDef();
							case "JobLCust":
					return new JobLine_JobLCustFieldDef();
							case "JobLCollDate":
					return new JobLine_JobLCollDateFieldDef();
							case "JobLCollDate2":
					return new JobLine_JobLCollDate2FieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, JobLJobNo as [Description] from JobLine 
			where JobLJobNo like @q or JobLJobNo like @q";
	}
	
}
public class DSTypeInv : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "InvId":
					return "Invoice Number";
							case "InvFreightDuty":
					return "Freight or Duty";
							case "InvJobNo":
					return "Job No";
							case "InvOrder":
					return "Order Number";
							case "InvVehicle":
					return "Vehicle";
							case "InvTrailer":
					return "Trailer";
							case "InvRouteFrom":
					return "Route From";
							case "InvRouteTo":
					return "Route To";
							case "InvFerryName":
					return "Ferry Name";
							case "InvFerryDate":
					return "Ferry Date";
							case "InvFerryTime":
					return "Ferry Time";
							case "InvTo":
					return "Invoice To";
							case "InvDesc":
					return "Invoice Description";
							case "InvNet":
					return "Net Amount";
							case "InvVAT":
					return "VAT Amount";
							case "InvTotal":
					return "Invoice Total";
							case "InvNote1":
					return "Comment 1";
							case "InvNote2":
					return "Comment 2";
							case "InvNote3":
					return "Comment 3";
							case "InvPrintBatch":
					return "Print Batch No";
							case "InvDate":
					return "Invoice Date";
							case "InvJobLetter":
					return "Job Letter";
							case "InvToExport":
					return "Send to Dover";
							case "InvExported":
					return "Sent to Dover";
							case "InvCustOrd":
					return "Client Order No";
							case "InvToId":
					return "Invoice To ID";
							case "InvAddr":
					return "Inv Co Address1";
							case "InvTown":
					return "Inv Co Town";
							case "InvPC":
					return "Inv Co Postcode";
							case "InvImpExp":
					return "Import or Export";
							case "InvCurr":
					return "Currency";
							case "InvExchRate":
					return "Exchange Rate";
							case "InvTescoRef":
					return "Tesco Ref";
							case "InvBelongsPInv":
					return "Belongs to P Inv";
							case "InvISPInv":
					return "Is Period Invoice";
							case "InvProforma":
					return "Proforma";
							case "InvSentTradeshift":
					return "Sent to Tradeshift";
							case "InvSentToClient":
					return "Sent to Client";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "InvId":
					return 94;
							case "InvFreightDuty":
					return 95;
							case "InvJobNo":
					return 96;
							case "InvOrder":
					return 97;
							case "InvVehicle":
					return 98;
							case "InvTrailer":
					return 99;
							case "InvRouteFrom":
					return 100;
							case "InvRouteTo":
					return 101;
							case "InvFerryName":
					return 102;
							case "InvFerryDate":
					return 103;
							case "InvFerryTime":
					return 104;
							case "InvTo":
					return 105;
							case "InvDesc":
					return 106;
							case "InvNet":
					return 107;
							case "InvVAT":
					return 108;
							case "InvTotal":
					return 109;
							case "InvNote1":
					return 110;
							case "InvNote2":
					return 111;
							case "InvNote3":
					return 112;
							case "InvPrintBatch":
					return 157;
							case "InvDate":
					return 128;
							case "InvJobLetter":
					return 162;
							case "InvToExport":
					return 171;
							case "InvExported":
					return 172;
							case "InvCustOrd":
					return 174;
							case "InvToId":
					return 175;
							case "InvAddr":
					return 242;
							case "InvTown":
					return 243;
							case "InvPC":
					return 244;
							case "InvImpExp":
					return 199;
							case "InvCurr":
					return 252;
							case "InvExchRate":
					return 253;
							case "InvTescoRef":
					return 268;
							case "InvBelongsPInv":
					return 269;
							case "InvISPInv":
					return 270;
							case "InvProforma":
					return 326;
							case "InvSentTradeshift":
					return 407;
							case "InvSentToClient":
					return 787;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "InvId":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvFreightDuty":
				return IQApp.Operators.GetComboOperators(selected);							case "InvJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "InvOrder":
				return IQApp.Operators.GetComboOperators(selected);							case "InvVehicle":
				return IQApp.Operators.GetTextOperators(selected);							case "InvTrailer":
				return IQApp.Operators.GetTextOperators(selected);							case "InvRouteFrom":
				return IQApp.Operators.GetComboOperators(selected);							case "InvRouteTo":
				return IQApp.Operators.GetComboOperators(selected);							case "InvFerryName":
				return IQApp.Operators.GetTextOperators(selected);							case "InvFerryDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvFerryTime":
				return IQApp.Operators.GetTextOperators(selected);							case "InvTo":
				return IQApp.Operators.GetComboOperators(selected);							case "InvDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "InvNet":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvVAT":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvTotal":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvNote1":
				return IQApp.Operators.GetComboOperators(selected);							case "InvNote2":
				return IQApp.Operators.GetComboOperators(selected);							case "InvNote3":
				return IQApp.Operators.GetComboOperators(selected);							case "InvPrintBatch":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvJobLetter":
				return IQApp.Operators.GetTextOperators(selected);							case "InvToExport":
				return IQApp.Operators.GetBooleanOperators(selected);							case "InvExported":
				return IQApp.Operators.GetBooleanOperators(selected);							case "InvCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "InvToId":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "InvTown":
				return IQApp.Operators.GetTextOperators(selected);							case "InvPC":
				return IQApp.Operators.GetTextOperators(selected);							case "InvImpExp":
				return IQApp.Operators.GetComboOperators(selected);							case "InvCurr":
				return IQApp.Operators.GetComboOperators(selected);							case "InvExchRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvTescoRef":
				return IQApp.Operators.GetTextOperators(selected);							case "InvBelongsPInv":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvISPInv":
				return IQApp.Operators.GetBooleanOperators(selected);							case "InvProforma":
				return IQApp.Operators.GetBooleanOperators(selected);							case "InvSentTradeshift":
				return IQApp.Operators.GetBooleanOperators(selected);							case "InvSentToClient":
				return IQApp.Operators.GetBooleanOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'InvId', 'Invoice Number'
					union select 'InvFreightDuty', 'Freight or Duty'
					union select 'InvJobNo', 'Job No'
					union select 'InvOrder', 'Order Number'
					union select 'InvVehicle', 'Vehicle'
					union select 'InvTrailer', 'Trailer'
					union select 'InvRouteFrom', 'Route From'
					union select 'InvRouteTo', 'Route To'
					union select 'InvFerryName', 'Ferry Name'
					union select 'InvFerryDate', 'Ferry Date'
					union select 'InvFerryTime', 'Ferry Time'
					union select 'InvTo', 'Invoice To'
					union select 'InvDesc', 'Invoice Description'
					union select 'InvNet', 'Net Amount'
					union select 'InvVAT', 'VAT Amount'
					union select 'InvTotal', 'Invoice Total'
					union select 'InvNote1', 'Comment 1'
					union select 'InvNote2', 'Comment 2'
					union select 'InvNote3', 'Comment 3'
					union select 'InvPrintBatch', 'Print Batch No'
					union select 'InvDate', 'Invoice Date'
					union select 'InvJobLetter', 'Job Letter'
					union select 'InvToExport', 'Send to Dover'
					union select 'InvExported', 'Sent to Dover'
					union select 'InvCustOrd', 'Client Order No'
					union select 'InvToId', 'Invoice To ID'
					union select 'InvAddr', 'Inv Co Address1'
					union select 'InvTown', 'Inv Co Town'
					union select 'InvPC', 'Inv Co Postcode'
					union select 'InvImpExp', 'Import or Export'
					union select 'InvCurr', 'Currency'
					union select 'InvExchRate', 'Exchange Rate'
					union select 'InvTescoRef', 'Tesco Ref'
					union select 'InvBelongsPInv', 'Belongs to P Inv'
					union select 'InvISPInv', 'Is Period Invoice'
					union select 'InvProforma', 'Proforma'
					union select 'InvSentTradeshift', 'Sent to Tradeshift'
					union select 'InvSentToClient', 'Sent to Client'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "InvId":
					return new Inv_InvIdFieldDef();
							case "InvFreightDuty":
					return new Inv_InvFreightDutyFieldDef();
							case "InvJobNo":
					return new Inv_InvJobNoFieldDef();
							case "InvOrder":
					return new Inv_InvOrderFieldDef();
							case "InvVehicle":
					return new Inv_InvVehicleFieldDef();
							case "InvTrailer":
					return new Inv_InvTrailerFieldDef();
							case "InvRouteFrom":
					return new Inv_InvRouteFromFieldDef();
							case "InvRouteTo":
					return new Inv_InvRouteToFieldDef();
							case "InvFerryName":
					return new Inv_InvFerryNameFieldDef();
							case "InvFerryDate":
					return new Inv_InvFerryDateFieldDef();
							case "InvFerryTime":
					return new Inv_InvFerryTimeFieldDef();
							case "InvTo":
					return new Inv_InvToFieldDef();
							case "InvDesc":
					return new Inv_InvDescFieldDef();
							case "InvNet":
					return new Inv_InvNetFieldDef();
							case "InvVAT":
					return new Inv_InvVATFieldDef();
							case "InvTotal":
					return new Inv_InvTotalFieldDef();
							case "InvNote1":
					return new Inv_InvNote1FieldDef();
							case "InvNote2":
					return new Inv_InvNote2FieldDef();
							case "InvNote3":
					return new Inv_InvNote3FieldDef();
							case "InvPrintBatch":
					return new Inv_InvPrintBatchFieldDef();
							case "InvDate":
					return new Inv_InvDateFieldDef();
							case "InvJobLetter":
					return new Inv_InvJobLetterFieldDef();
							case "InvToExport":
					return new Inv_InvToExportFieldDef();
							case "InvExported":
					return new Inv_InvExportedFieldDef();
							case "InvCustOrd":
					return new Inv_InvCustOrdFieldDef();
							case "InvToId":
					return new Inv_InvToIdFieldDef();
							case "InvAddr":
					return new Inv_InvAddrFieldDef();
							case "InvTown":
					return new Inv_InvTownFieldDef();
							case "InvPC":
					return new Inv_InvPCFieldDef();
							case "InvImpExp":
					return new Inv_InvImpExpFieldDef();
							case "InvCurr":
					return new Inv_InvCurrFieldDef();
							case "InvExchRate":
					return new Inv_InvExchRateFieldDef();
							case "InvTescoRef":
					return new Inv_InvTescoRefFieldDef();
							case "InvBelongsPInv":
					return new Inv_InvBelongsPInvFieldDef();
							case "InvISPInv":
					return new Inv_InvISPInvFieldDef();
							case "InvProforma":
					return new Inv_InvProformaFieldDef();
							case "InvSentTradeshift":
					return new Inv_InvSentTradeshiftFieldDef();
							case "InvSentToClient":
					return new Inv_InvSentToClientFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, InvId as [Description] from Inv 
			where InvId like @q or InvId like @q";
	}
	
}
public class DSTypeInvLine : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "InvLChargeType":
					return "Charge Type";
							case "InvLInvNo":
					return "Invoice Number";
							case "InvLLineNo":
					return "Line Number";
							case "InvLDesc":
					return "Description";
							case "InvLVATCode":
					return "VAT Code";
							case "InvLVATRate":
					return "VAT Rate";
							case "InvLAmt":
					return "Line Amount";
							case "InvLVATAmt":
					return "VAT Amount";
							case "InvLTotal":
					return "Line Total";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "InvLChargeType":
					return 170;
							case "InvLInvNo":
					return 117;
							case "InvLLineNo":
					return 118;
							case "InvLDesc":
					return 119;
							case "InvLVATCode":
					return 120;
							case "InvLVATRate":
					return 121;
							case "InvLAmt":
					return 122;
							case "InvLVATAmt":
					return 123;
							case "InvLTotal":
					return 124;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "InvLChargeType":
				return IQApp.Operators.GetComboOperators(selected);							case "InvLInvNo":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvLLineNo":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvLDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "InvLVATCode":
				return IQApp.Operators.GetComboOperators(selected);							case "InvLVATRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvLAmt":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvLVATAmt":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvLTotal":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'InvLChargeType', 'Charge Type'
					union select 'InvLInvNo', 'Invoice Number'
					union select 'InvLLineNo', 'Line Number'
					union select 'InvLDesc', 'Description'
					union select 'InvLVATCode', 'VAT Code'
					union select 'InvLVATRate', 'VAT Rate'
					union select 'InvLAmt', 'Line Amount'
					union select 'InvLVATAmt', 'VAT Amount'
					union select 'InvLTotal', 'Line Total'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "InvLChargeType":
					return new InvLine_InvLChargeTypeFieldDef();
							case "InvLInvNo":
					return new InvLine_InvLInvNoFieldDef();
							case "InvLLineNo":
					return new InvLine_InvLLineNoFieldDef();
							case "InvLDesc":
					return new InvLine_InvLDescFieldDef();
							case "InvLVATCode":
					return new InvLine_InvLVATCodeFieldDef();
							case "InvLVATRate":
					return new InvLine_InvLVATRateFieldDef();
							case "InvLAmt":
					return new InvLine_InvLAmtFieldDef();
							case "InvLVATAmt":
					return new InvLine_InvLVATAmtFieldDef();
							case "InvLTotal":
					return new InvLine_InvLTotalFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, InvLInvNo as [Description] from InvLine 
			where InvLInvNo like @q or InvLInvNo like @q";
	}
	
}
public class DSTypeCN : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "CNId":
					return "Credit Number";
							case "CNImpExp":
					return "Import or Export";
							case "CNJobNo":
					return "Job Number";
							case "CNOrder":
					return "Order Number";
							case "CNVehicle":
					return "Vehicle";
							case "CNTrailer":
					return "Trailer";
							case "CNRouteFrom":
					return "Route From";
							case "CNRouteTo":
					return "Route To";
							case "CNTo":
					return "Credit To";
							case "CNToId":
					return "Credit To ID";
							case "CNDesc":
					return "Credit Description";
							case "CNNet":
					return "Net Amount";
							case "CNVAT":
					return "VAT Amount";
							case "CNTotal":
					return "Credit Total";
							case "CNNote1":
					return "Comment 1";
							case "CNNote2":
					return "Comment 2";
							case "CNDate":
					return "Credit Date";
							case "CNPrintBatch":
					return "Print Batch No";
							case "CNJobLetter":
					return "Job Letter";
							case "CNToExport":
					return "Send to Dover";
							case "CNExported":
					return "Sent to Dover";
							case "CNCustOrd":
					return "Client Order No";
							case "CNCurr":
					return "Currency";
							case "CNExchRate":
					return "Exchange Rate";
							case "CNDutyCN":
					return "Duty CN";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "CNId":
					return 201;
							case "CNImpExp":
					return 202;
							case "CNJobNo":
					return 203;
							case "CNOrder":
					return 204;
							case "CNVehicle":
					return 205;
							case "CNTrailer":
					return 206;
							case "CNRouteFrom":
					return 207;
							case "CNRouteTo":
					return 208;
							case "CNTo":
					return 209;
							case "CNToId":
					return 210;
							case "CNDesc":
					return 211;
							case "CNNet":
					return 212;
							case "CNVAT":
					return 213;
							case "CNTotal":
					return 214;
							case "CNNote1":
					return 215;
							case "CNNote2":
					return 216;
							case "CNDate":
					return 217;
							case "CNPrintBatch":
					return 218;
							case "CNJobLetter":
					return 219;
							case "CNToExport":
					return 220;
							case "CNExported":
					return 221;
							case "CNCustOrd":
					return 222;
							case "CNCurr":
					return 257;
							case "CNExchRate":
					return 258;
							case "CNDutyCN":
					return 251;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "CNId":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNImpExp":
				return IQApp.Operators.GetComboOperators(selected);							case "CNJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "CNOrder":
				return IQApp.Operators.GetComboOperators(selected);							case "CNVehicle":
				return IQApp.Operators.GetTextOperators(selected);							case "CNTrailer":
				return IQApp.Operators.GetTextOperators(selected);							case "CNRouteFrom":
				return IQApp.Operators.GetComboOperators(selected);							case "CNRouteTo":
				return IQApp.Operators.GetComboOperators(selected);							case "CNTo":
				return IQApp.Operators.GetComboOperators(selected);							case "CNToId":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "CNNet":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNVAT":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNTotal":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNNote1":
				return IQApp.Operators.GetComboOperators(selected);							case "CNNote2":
				return IQApp.Operators.GetComboOperators(selected);							case "CNDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNPrintBatch":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNJobLetter":
				return IQApp.Operators.GetTextOperators(selected);							case "CNToExport":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CNExported":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CNCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "CNCurr":
				return IQApp.Operators.GetComboOperators(selected);							case "CNExchRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNDutyCN":
				return IQApp.Operators.GetBooleanOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'CNId', 'Credit Number'
					union select 'CNImpExp', 'Import or Export'
					union select 'CNJobNo', 'Job Number'
					union select 'CNOrder', 'Order Number'
					union select 'CNVehicle', 'Vehicle'
					union select 'CNTrailer', 'Trailer'
					union select 'CNRouteFrom', 'Route From'
					union select 'CNRouteTo', 'Route To'
					union select 'CNTo', 'Credit To'
					union select 'CNToId', 'Credit To ID'
					union select 'CNDesc', 'Credit Description'
					union select 'CNNet', 'Net Amount'
					union select 'CNVAT', 'VAT Amount'
					union select 'CNTotal', 'Credit Total'
					union select 'CNNote1', 'Comment 1'
					union select 'CNNote2', 'Comment 2'
					union select 'CNDate', 'Credit Date'
					union select 'CNPrintBatch', 'Print Batch No'
					union select 'CNJobLetter', 'Job Letter'
					union select 'CNToExport', 'Send to Dover'
					union select 'CNExported', 'Sent to Dover'
					union select 'CNCustOrd', 'Client Order No'
					union select 'CNCurr', 'Currency'
					union select 'CNExchRate', 'Exchange Rate'
					union select 'CNDutyCN', 'Duty CN'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "CNId":
					return new CN_CNIdFieldDef();
							case "CNImpExp":
					return new CN_CNImpExpFieldDef();
							case "CNJobNo":
					return new CN_CNJobNoFieldDef();
							case "CNOrder":
					return new CN_CNOrderFieldDef();
							case "CNVehicle":
					return new CN_CNVehicleFieldDef();
							case "CNTrailer":
					return new CN_CNTrailerFieldDef();
							case "CNRouteFrom":
					return new CN_CNRouteFromFieldDef();
							case "CNRouteTo":
					return new CN_CNRouteToFieldDef();
							case "CNTo":
					return new CN_CNToFieldDef();
							case "CNToId":
					return new CN_CNToIdFieldDef();
							case "CNDesc":
					return new CN_CNDescFieldDef();
							case "CNNet":
					return new CN_CNNetFieldDef();
							case "CNVAT":
					return new CN_CNVATFieldDef();
							case "CNTotal":
					return new CN_CNTotalFieldDef();
							case "CNNote1":
					return new CN_CNNote1FieldDef();
							case "CNNote2":
					return new CN_CNNote2FieldDef();
							case "CNDate":
					return new CN_CNDateFieldDef();
							case "CNPrintBatch":
					return new CN_CNPrintBatchFieldDef();
							case "CNJobLetter":
					return new CN_CNJobLetterFieldDef();
							case "CNToExport":
					return new CN_CNToExportFieldDef();
							case "CNExported":
					return new CN_CNExportedFieldDef();
							case "CNCustOrd":
					return new CN_CNCustOrdFieldDef();
							case "CNCurr":
					return new CN_CNCurrFieldDef();
							case "CNExchRate":
					return new CN_CNExchRateFieldDef();
							case "CNDutyCN":
					return new CN_CNDutyCNFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, CNId as [Description] from CN 
			where CNId like @q or CNId like @q";
	}
	
}
public class DSTypeUKOrder : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "UKOInvoiced":
					return "Invoiced";
							case "UKOCreatedBy":
					return "Created By";
							case "UKOWeight":
					return "Weight";
							case "UKOId":
					return "UK Order ID";
							case "UKOCollDate":
					return "Collection Date";
							case "UKOCustRef":
					return "Customer Ref";
							case "UKOCust":
					return "Customer Name";
							case "UKOCollFrom":
					return "Collection From";
							case "UKODelTo":
					return "Delivery To";
							case "UKODesc":
					return "Description";
							case "UKOQty":
					return "Quantity";
							case "UKOTransp":
					return "Haulier Name";
							case "UKOChargeCust":
					return "Charge Customer";
							case "UKOFTLCost":
					return "Cost to FTL";
							case "UKODelProof":
					return "Proof of Delivery";
							case "UKOJobNo":
					return "Job Number";
							case "UKONotes":
					return "Comments";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "UKOInvoiced":
					return 240;
							case "UKOCreatedBy":
					return 290;
							case "UKOWeight":
					return 194;
							case "UKOId":
					return 129;
							case "UKOCollDate":
					return 130;
							case "UKOCustRef":
					return 131;
							case "UKOCust":
					return 132;
							case "UKOCollFrom":
					return 133;
							case "UKODelTo":
					return 134;
							case "UKODesc":
					return 135;
							case "UKOQty":
					return 136;
							case "UKOTransp":
					return 137;
							case "UKOChargeCust":
					return 138;
							case "UKOFTLCost":
					return 139;
							case "UKODelProof":
					return 140;
							case "UKOJobNo":
					return 141;
							case "UKONotes":
					return 142;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "UKOInvoiced":
				return IQApp.Operators.GetBooleanOperators(selected);							case "UKOCreatedBy":
				return IQApp.Operators.GetComboOperators(selected);							case "UKOWeight":
				return IQApp.Operators.GetTextOperators(selected);							case "UKOId":
				return IQApp.Operators.GetNumberOperators(selected);							case "UKOCollDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "UKOCustRef":
				return IQApp.Operators.GetTextOperators(selected);							case "UKOCust":
				return IQApp.Operators.GetComboOperators(selected);							case "UKOCollFrom":
				return IQApp.Operators.GetTextOperators(selected);							case "UKODelTo":
				return IQApp.Operators.GetTextOperators(selected);							case "UKODesc":
				return IQApp.Operators.GetTextOperators(selected);							case "UKOQty":
				return IQApp.Operators.GetTextOperators(selected);							case "UKOTransp":
				return IQApp.Operators.GetComboOperators(selected);							case "UKOChargeCust":
				return IQApp.Operators.GetNumberOperators(selected);							case "UKOFTLCost":
				return IQApp.Operators.GetNumberOperators(selected);							case "UKODelProof":
				return IQApp.Operators.GetBooleanOperators(selected);							case "UKOJobNo":
				return IQApp.Operators.GetTextOperators(selected);							case "UKONotes":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'UKOInvoiced', 'Invoiced'
					union select 'UKOCreatedBy', 'Created By'
					union select 'UKOWeight', 'Weight'
					union select 'UKOId', 'UK Order ID'
					union select 'UKOCollDate', 'Collection Date'
					union select 'UKOCustRef', 'Customer Ref'
					union select 'UKOCust', 'Customer Name'
					union select 'UKOCollFrom', 'Collection From'
					union select 'UKODelTo', 'Delivery To'
					union select 'UKODesc', 'Description'
					union select 'UKOQty', 'Quantity'
					union select 'UKOTransp', 'Haulier Name'
					union select 'UKOChargeCust', 'Charge Customer'
					union select 'UKOFTLCost', 'Cost to FTL'
					union select 'UKODelProof', 'Proof of Delivery'
					union select 'UKOJobNo', 'Job Number'
					union select 'UKONotes', 'Comments'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "UKOInvoiced":
					return new UKOrder_UKOInvoicedFieldDef();
							case "UKOCreatedBy":
					return new UKOrder_UKOCreatedByFieldDef();
							case "UKOWeight":
					return new UKOrder_UKOWeightFieldDef();
							case "UKOId":
					return new UKOrder_UKOIdFieldDef();
							case "UKOCollDate":
					return new UKOrder_UKOCollDateFieldDef();
							case "UKOCustRef":
					return new UKOrder_UKOCustRefFieldDef();
							case "UKOCust":
					return new UKOrder_UKOCustFieldDef();
							case "UKOCollFrom":
					return new UKOrder_UKOCollFromFieldDef();
							case "UKODelTo":
					return new UKOrder_UKODelToFieldDef();
							case "UKODesc":
					return new UKOrder_UKODescFieldDef();
							case "UKOQty":
					return new UKOrder_UKOQtyFieldDef();
							case "UKOTransp":
					return new UKOrder_UKOTranspFieldDef();
							case "UKOChargeCust":
					return new UKOrder_UKOChargeCustFieldDef();
							case "UKOFTLCost":
					return new UKOrder_UKOFTLCostFieldDef();
							case "UKODelProof":
					return new UKOrder_UKODelProofFieldDef();
							case "UKOJobNo":
					return new UKOrder_UKOJobNoFieldDef();
							case "UKONotes":
					return new UKOrder_UKONotesFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, UKOId as [Description] from UKOrder 
			where UKOId like @q or UKOId like @q";
	}
	
}
public class DSTypeFerryRoute : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "FRCode":
					return "Route Code";
							case "FRName":
					return "Route";
							case "FRId":
					return "Route Id";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "FRCode":
					return 86;
							case "FRName":
					return 87;
							case "FRId":
					return 429;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "FRCode":
				return IQApp.Operators.GetTextOperators(selected);							case "FRName":
				return IQApp.Operators.GetTextOperators(selected);							case "FRId":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'FRCode', 'Route Code'
					union select 'FRName', 'Route'
					union select 'FRId', 'Route Id'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "FRCode":
					return new FerryRoute_FRCodeFieldDef();
							case "FRName":
					return new FerryRoute_FRNameFieldDef();
							case "FRId":
					return new FerryRoute_FRIdFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, FRName as [Description] from FerryRoute 
			where FRId like @q or FRName like @q";
	}
	
}
public class DSTypeInvComment : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "InvCId":
					return "Inv Comment ID";
							case "InvCName":
					return "Inv Comment";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "InvCId":
					return 115;
							case "InvCName":
					return 116;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "InvCId":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvCName":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'InvCId', 'Inv Comment ID'
					union select 'InvCName', 'Inv Comment'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "InvCId":
					return new InvComment_InvCIdFieldDef();
							case "InvCName":
					return new InvComment_InvCNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, InvCId as [Description] from InvComment 
			where InvCId like @q or InvCId like @q";
	}
	
}
public class DSTypeVATCodes : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "VATCode":
					return "VAT Code";
							case "VATName":
					return "Description";
							case "VATRate":
					return "VAT Rate";
							case "VATId":
					return "VAT Id";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "VATCode":
					return 125;
							case "VATName":
					return 126;
							case "VATRate":
					return 127;
							case "VATId":
					return 430;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "VATCode":
				return IQApp.Operators.GetTextOperators(selected);							case "VATName":
				return IQApp.Operators.GetTextOperators(selected);							case "VATRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "VATId":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'VATCode', 'VAT Code'
					union select 'VATName', 'Description'
					union select 'VATRate', 'VAT Rate'
					union select 'VATId', 'VAT Id'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "VATCode":
					return new VATCodes_VATCodeFieldDef();
							case "VATName":
					return new VATCodes_VATNameFieldDef();
							case "VATRate":
					return new VATCodes_VATRateFieldDef();
							case "VATId":
					return new VATCodes_VATIdFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, VATCode as [Description] from VATCodes 
			where VATId like @q or VATCode like @q";
	}
	
}
public class DSTypeJobCost : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "JobCJobNo":
					return "Job Number";
							case "JobCServProvId":
					return "Service Provider Id";
							case "JobCServProv":
					return "Service Provider";
							case "JobCDesc":
					return "Description";
							case "JobCInvAmt":
					return "Invoice Amount";
							case "JobCInvNo":
					return "Invoice Number";
							case "JobCInvDate":
					return "Invoice Date";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "JobCJobNo":
					return 163;
							case "JobCServProvId":
					return 164;
							case "JobCServProv":
					return 165;
							case "JobCDesc":
					return 166;
							case "JobCInvAmt":
					return 167;
							case "JobCInvNo":
					return 168;
							case "JobCInvDate":
					return 169;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "JobCJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "JobCServProvId":
				return IQApp.Operators.GetNumberOperators(selected);							case "JobCServProv":
				return IQApp.Operators.GetComboOperators(selected);							case "JobCDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "JobCInvAmt":
				return IQApp.Operators.GetNumberOperators(selected);							case "JobCInvNo":
				return IQApp.Operators.GetTextOperators(selected);							case "JobCInvDate":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'JobCJobNo', 'Job Number'
					union select 'JobCServProvId', 'Service Provider Id'
					union select 'JobCServProv', 'Service Provider'
					union select 'JobCDesc', 'Description'
					union select 'JobCInvAmt', 'Invoice Amount'
					union select 'JobCInvNo', 'Invoice Number'
					union select 'JobCInvDate', 'Invoice Date'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "JobCJobNo":
					return new JobCost_JobCJobNoFieldDef();
							case "JobCServProvId":
					return new JobCost_JobCServProvIdFieldDef();
							case "JobCServProv":
					return new JobCost_JobCServProvFieldDef();
							case "JobCDesc":
					return new JobCost_JobCDescFieldDef();
							case "JobCInvAmt":
					return new JobCost_JobCInvAmtFieldDef();
							case "JobCInvNo":
					return new JobCost_JobCInvNoFieldDef();
							case "JobCInvDate":
					return new JobCost_JobCInvDateFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, JobCJobNo as [Description] from JobCost 
			where JobCJobNo like @q or JobCJobNo like @q";
	}
	
}
public class DSTypeCertShip : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "CSId":
					return "Certificate Number";
							case "CSJobNo":
					return "Job Number";
							case "CSJobLetter":
					return "Job Letter";
							case "CSOrder":
					return "Order Number";
							case "CSCust":
					return "Client";
							case "CSCustOrd":
					return "Client Order No";
							case "CSDelPoint":
					return "Delivery Point";
							case "CSGoodsDesc":
					return "Goods Desc";
							case "CSWeight":
					return "Weight";
							case "CSVehicle":
					return "Vehicle";
							case "CSRoute":
					return "Route";
							case "CSShip":
					return "Ship";
							case "CSDate":
					return "Date";
							case "CSTime":
					return "Time";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "CSId":
					return 178;
							case "CSJobNo":
					return 179;
							case "CSJobLetter":
					return 180;
							case "CSOrder":
					return 181;
							case "CSCust":
					return 182;
							case "CSCustOrd":
					return 183;
							case "CSDelPoint":
					return 184;
							case "CSGoodsDesc":
					return 185;
							case "CSWeight":
					return 186;
							case "CSVehicle":
					return 187;
							case "CSRoute":
					return 188;
							case "CSShip":
					return 189;
							case "CSDate":
					return 190;
							case "CSTime":
					return 191;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "CSId":
				return IQApp.Operators.GetNumberOperators(selected);							case "CSJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "CSJobLetter":
				return IQApp.Operators.GetTextOperators(selected);							case "CSOrder":
				return IQApp.Operators.GetComboOperators(selected);							case "CSCust":
				return IQApp.Operators.GetComboOperators(selected);							case "CSCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "CSDelPoint":
				return IQApp.Operators.GetComboOperators(selected);							case "CSGoodsDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "CSWeight":
				return IQApp.Operators.GetTextOperators(selected);							case "CSVehicle":
				return IQApp.Operators.GetTextOperators(selected);							case "CSRoute":
				return IQApp.Operators.GetTextOperators(selected);							case "CSShip":
				return IQApp.Operators.GetTextOperators(selected);							case "CSDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "CSTime":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'CSId', 'Certificate Number'
					union select 'CSJobNo', 'Job Number'
					union select 'CSJobLetter', 'Job Letter'
					union select 'CSOrder', 'Order Number'
					union select 'CSCust', 'Client'
					union select 'CSCustOrd', 'Client Order No'
					union select 'CSDelPoint', 'Delivery Point'
					union select 'CSGoodsDesc', 'Goods Desc'
					union select 'CSWeight', 'Weight'
					union select 'CSVehicle', 'Vehicle'
					union select 'CSRoute', 'Route'
					union select 'CSShip', 'Ship'
					union select 'CSDate', 'Date'
					union select 'CSTime', 'Time'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "CSId":
					return new CertShip_CSIdFieldDef();
							case "CSJobNo":
					return new CertShip_CSJobNoFieldDef();
							case "CSJobLetter":
					return new CertShip_CSJobLetterFieldDef();
							case "CSOrder":
					return new CertShip_CSOrderFieldDef();
							case "CSCust":
					return new CertShip_CSCustFieldDef();
							case "CSCustOrd":
					return new CertShip_CSCustOrdFieldDef();
							case "CSDelPoint":
					return new CertShip_CSDelPointFieldDef();
							case "CSGoodsDesc":
					return new CertShip_CSGoodsDescFieldDef();
							case "CSWeight":
					return new CertShip_CSWeightFieldDef();
							case "CSVehicle":
					return new CertShip_CSVehicleFieldDef();
							case "CSRoute":
					return new CertShip_CSRouteFieldDef();
							case "CSShip":
					return new CertShip_CSShipFieldDef();
							case "CSDate":
					return new CertShip_CSDateFieldDef();
							case "CSTime":
					return new CertShip_CSTimeFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, CSId as [Description] from CertShip 
			where CSId like @q or CSId like @q";
	}
	
}
public class DSTypeCNLine : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "CNLNo":
					return "Credit Number";
							case "CNLLineNo":
					return "Line Number";
							case "CNLDesc":
					return "Description";
							case "CNLVATCode":
					return "VAT Code";
							case "CNLVATRate":
					return "VAT Rate";
							case "CNLAmt":
					return "Line Amount";
							case "CNLVATAmt":
					return "VAT Amount";
							case "CNLTotal":
					return "Line Total";
							case "CNLChargeType":
					return "Charge Type";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "CNLNo":
					return 223;
							case "CNLLineNo":
					return 224;
							case "CNLDesc":
					return 225;
							case "CNLVATCode":
					return 226;
							case "CNLVATRate":
					return 227;
							case "CNLAmt":
					return 228;
							case "CNLVATAmt":
					return 229;
							case "CNLTotal":
					return 230;
							case "CNLChargeType":
					return 231;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "CNLNo":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNLLineNo":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNLDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "CNLVATCode":
				return IQApp.Operators.GetComboOperators(selected);							case "CNLVATRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNLAmt":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNLVATAmt":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNLTotal":
				return IQApp.Operators.GetNumberOperators(selected);							case "CNLChargeType":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'CNLNo', 'Credit Number'
					union select 'CNLLineNo', 'Line Number'
					union select 'CNLDesc', 'Description'
					union select 'CNLVATCode', 'VAT Code'
					union select 'CNLVATRate', 'VAT Rate'
					union select 'CNLAmt', 'Line Amount'
					union select 'CNLVATAmt', 'VAT Amount'
					union select 'CNLTotal', 'Line Total'
					union select 'CNLChargeType', 'Charge Type'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "CNLNo":
					return new CNLine_CNLNoFieldDef();
							case "CNLLineNo":
					return new CNLine_CNLLineNoFieldDef();
							case "CNLDesc":
					return new CNLine_CNLDescFieldDef();
							case "CNLVATCode":
					return new CNLine_CNLVATCodeFieldDef();
							case "CNLVATRate":
					return new CNLine_CNLVATRateFieldDef();
							case "CNLAmt":
					return new CNLine_CNLAmtFieldDef();
							case "CNLVATAmt":
					return new CNLine_CNLVATAmtFieldDef();
							case "CNLTotal":
					return new CNLine_CNLTotalFieldDef();
							case "CNLChargeType":
					return new CNLine_CNLChargeTypeFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, CNLNo as [Description] from CNLine 
			where CNLNo like @q or CNLNo like @q";
	}
	
}
public class DSTypeDriver : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "DrvId":
					return "Driver ID";
							case "DrvName":
					return "Driver Name";
							case "DrvVehicle":
					return "Vehicle Assigned To";
							case "DrvActive":
					return "Active";
							case "DrvSDate":
					return "Start Date";
							case "DrvPspExpiry":
					return "Passport Expiry";
							case "DrvAddress":
					return "Address";
							case "DrvDoB":
					return "Date Of Birth";
							case "DrvEmpStart":
					return "Emp Start Date";
							case "DrvLicense":
					return "Drivers License No";
							case "DrvTacho":
					return "Drivers Digital Tacho Card No";
							case "DrvCPC":
					return "Drivers CPC Card No";
							case "DrvPpNo":
					return "Passport No";
							case "DrvNextOfKin":
					return "Next of Kin";
							case "DrvMobile":
					return "Mobile Number";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "DrvId":
					return 232;
							case "DrvName":
					return 233;
							case "DrvVehicle":
					return 234;
							case "DrvActive":
					return 282;
							case "DrvSDate":
					return 273;
							case "DrvPspExpiry":
					return 772;
							case "DrvAddress":
					return 793;
							case "DrvDoB":
					return 794;
							case "DrvEmpStart":
					return 795;
							case "DrvLicense":
					return 796;
							case "DrvTacho":
					return 797;
							case "DrvCPC":
					return 798;
							case "DrvPpNo":
					return 799;
							case "DrvNextOfKin":
					return 800;
							case "DrvMobile":
					return 786;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "DrvId":
				return IQApp.Operators.GetNumberOperators(selected);							case "DrvName":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvVehicle":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvActive":
				return IQApp.Operators.GetBooleanOperators(selected);							case "DrvSDate":
				return IQApp.Operators.GetComboOperators(selected);							case "DrvPspExpiry":
				return IQApp.Operators.GetNumberOperators(selected);							case "DrvAddress":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvDoB":
				return IQApp.Operators.GetNumberOperators(selected);							case "DrvEmpStart":
				return IQApp.Operators.GetNumberOperators(selected);							case "DrvLicense":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvTacho":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvCPC":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvPpNo":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvNextOfKin":
				return IQApp.Operators.GetTextOperators(selected);							case "DrvMobile":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'DrvId', 'Driver ID'
					union select 'DrvName', 'Driver Name'
					union select 'DrvVehicle', 'Vehicle Assigned To'
					union select 'DrvActive', 'Active'
					union select 'DrvSDate', 'Start Date'
					union select 'DrvPspExpiry', 'Passport Expiry'
					union select 'DrvAddress', 'Address'
					union select 'DrvDoB', 'Date Of Birth'
					union select 'DrvEmpStart', 'Emp Start Date'
					union select 'DrvLicense', 'Drivers License No'
					union select 'DrvTacho', 'Drivers Digital Tacho Card No'
					union select 'DrvCPC', 'Drivers CPC Card No'
					union select 'DrvPpNo', 'Passport No'
					union select 'DrvNextOfKin', 'Next of Kin'
					union select 'DrvMobile', 'Mobile Number'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "DrvId":
					return new Driver_DrvIdFieldDef();
							case "DrvName":
					return new Driver_DrvNameFieldDef();
							case "DrvVehicle":
					return new Driver_DrvVehicleFieldDef();
							case "DrvActive":
					return new Driver_DrvActiveFieldDef();
							case "DrvSDate":
					return new Driver_DrvSDateFieldDef();
							case "DrvPspExpiry":
					return new Driver_DrvPspExpiryFieldDef();
							case "DrvAddress":
					return new Driver_DrvAddressFieldDef();
							case "DrvDoB":
					return new Driver_DrvDoBFieldDef();
							case "DrvEmpStart":
					return new Driver_DrvEmpStartFieldDef();
							case "DrvLicense":
					return new Driver_DrvLicenseFieldDef();
							case "DrvTacho":
					return new Driver_DrvTachoFieldDef();
							case "DrvCPC":
					return new Driver_DrvCPCFieldDef();
							case "DrvPpNo":
					return new Driver_DrvPpNoFieldDef();
							case "DrvNextOfKin":
					return new Driver_DrvNextOfKinFieldDef();
							case "DrvMobile":
					return new Driver_DrvMobileFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, DrvName as [Description] from Driver 
			where DrvId like @q or DrvName like @q";
	}
	
}
public class DSTypeExchRate : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "ExRSDate":
					return "From";
							case "ExREDate":
					return "To";
							case "ExRId":
					return "Period Rate ID";
							case "ExRName":
					return "Period Rate";
							case "ExRRate":
					return "Rate";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "ExRSDate":
					return 336;
							case "ExREDate":
					return 337;
							case "ExRId":
					return 254;
							case "ExRName":
					return 255;
							case "ExRRate":
					return 256;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "ExRSDate":
				return IQApp.Operators.GetTextOperators(selected);							case "ExREDate":
				return IQApp.Operators.GetTextOperators(selected);							case "ExRId":
				return IQApp.Operators.GetNumberOperators(selected);							case "ExRName":
				return IQApp.Operators.GetTextOperators(selected);							case "ExRRate":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'ExRSDate', 'From'
					union select 'ExREDate', 'To'
					union select 'ExRId', 'Period Rate ID'
					union select 'ExRName', 'Period Rate'
					union select 'ExRRate', 'Rate'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "ExRSDate":
					return new ExchRate_ExRSDateFieldDef();
							case "ExREDate":
					return new ExchRate_ExREDateFieldDef();
							case "ExRId":
					return new ExchRate_ExRIdFieldDef();
							case "ExRName":
					return new ExchRate_ExRNameFieldDef();
							case "ExRRate":
					return new ExchRate_ExRRateFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, ExRName as [Description] from ExchRate 
			where ExRId like @q or ExRName like @q";
	}
	
}
public class DSTypeTrailer : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "TrlFleetNo":
					return "Fleet Number";
							case "TrlLastServ":
					return "Last Service";
							case "TrlNextServDue":
					return "Next Service Due";
							case "TrlDaysRem":
					return "Days Remaining";
							case "TrlLastMOT":
					return "Last MOT";
							case "TrlNextMOTDue":
					return "Next MOT Due";
							case "TrlStatus":
					return "Status";
							case "TrlNotes":
					return "Comments";
							case "TrlId":
					return "Trailer Id";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "TrlFleetNo":
					return 259;
							case "TrlLastServ":
					return 260;
							case "TrlNextServDue":
					return 261;
							case "TrlDaysRem":
					return 262;
							case "TrlLastMOT":
					return 263;
							case "TrlNextMOTDue":
					return 264;
							case "TrlStatus":
					return 265;
							case "TrlNotes":
					return 266;
							case "TrlId":
					return 431;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "TrlFleetNo":
				return IQApp.Operators.GetTextOperators(selected);							case "TrlLastServ":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrlNextServDue":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrlDaysRem":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrlLastMOT":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrlNextMOTDue":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrlStatus":
				return IQApp.Operators.GetTextOperators(selected);							case "TrlNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "TrlId":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'TrlFleetNo', 'Fleet Number'
					union select 'TrlLastServ', 'Last Service'
					union select 'TrlNextServDue', 'Next Service Due'
					union select 'TrlDaysRem', 'Days Remaining'
					union select 'TrlLastMOT', 'Last MOT'
					union select 'TrlNextMOTDue', 'Next MOT Due'
					union select 'TrlStatus', 'Status'
					union select 'TrlNotes', 'Comments'
					union select 'TrlId', 'Trailer Id'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "TrlFleetNo":
					return new Trailer_TrlFleetNoFieldDef();
							case "TrlLastServ":
					return new Trailer_TrlLastServFieldDef();
							case "TrlNextServDue":
					return new Trailer_TrlNextServDueFieldDef();
							case "TrlDaysRem":
					return new Trailer_TrlDaysRemFieldDef();
							case "TrlLastMOT":
					return new Trailer_TrlLastMOTFieldDef();
							case "TrlNextMOTDue":
					return new Trailer_TrlNextMOTDueFieldDef();
							case "TrlStatus":
					return new Trailer_TrlStatusFieldDef();
							case "TrlNotes":
					return new Trailer_TrlNotesFieldDef();
							case "TrlId":
					return new Trailer_TrlIdFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, TrlFleetNo as [Description] from Trailer 
			where TrlId like @q or TrlFleetNo like @q";
	}
	
}
public class DSTypePeriodInv : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "PInvId":
					return "Period Inv No";
							case "PInvName":
					return "Include Invoice";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "PInvId":
					return 271;
							case "PInvName":
					return 272;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "PInvId":
				return IQApp.Operators.GetNumberOperators(selected);							case "PInvName":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'PInvId', 'Period Inv No'
					union select 'PInvName', 'Include Invoice'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "PInvId":
					return new PeriodInv_PInvIdFieldDef();
							case "PInvName":
					return new PeriodInv_PInvNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, PInvId as [Description] from PeriodInv 
			where PInvId like @q or PInvId like @q";
	}
	
}
public class DSTypeWeek : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "WkBelongsTo":
					return "Belongs to Period";
							case "WkId":
					return "Week ID";
							case "WkSDate":
					return "Week Start (Mon)";
							case "WkEDate":
					return "Week End (Sun)";
							case "WkSDateText":
					return "Monday Text";
							case "WkEDateText":
					return "Sunday Text";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "WkBelongsTo":
					return 284;
							case "WkId":
					return 279;
							case "WkSDate":
					return 280;
							case "WkEDate":
					return 281;
							case "WkSDateText":
					return 426;
							case "WkEDateText":
					return 427;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "WkBelongsTo":
				return IQApp.Operators.GetNumberOperators(selected);							case "WkId":
				return IQApp.Operators.GetNumberOperators(selected);							case "WkSDate":
				return IQApp.Operators.GetTextOperators(selected);							case "WkEDate":
				return IQApp.Operators.GetTextOperators(selected);							case "WkSDateText":
				return IQApp.Operators.GetTextOperators(selected);							case "WkEDateText":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'WkBelongsTo', 'Belongs to Period'
					union select 'WkId', 'Week ID'
					union select 'WkSDate', 'Week Start (Mon)'
					union select 'WkEDate', 'Week End (Sun)'
					union select 'WkSDateText', 'Monday Text'
					union select 'WkEDateText', 'Sunday Text'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "WkBelongsTo":
					return new Week_WkBelongsToFieldDef();
							case "WkId":
					return new Week_WkIdFieldDef();
							case "WkSDate":
					return new Week_WkSDateFieldDef();
							case "WkEDate":
					return new Week_WkEDateFieldDef();
							case "WkSDateText":
					return new Week_WkSDateTextFieldDef();
							case "WkEDateText":
					return new Week_WkEDateTextFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, WkId as [Description] from Week 
			where WkId like @q or WkId like @q";
	}
	
}
public class DSTypeDriverHrs : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "DrvHDriver":
					return "Driver";
							case "DrvHWk":
					return "Week";
							case "DrvHHrs":
					return "Hours";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "DrvHDriver":
					return 276;
							case "DrvHWk":
					return 277;
							case "DrvHHrs":
					return 278;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "DrvHDriver":
				return IQApp.Operators.GetComboOperators(selected);							case "DrvHWk":
				return IQApp.Operators.GetComboOperators(selected);							case "DrvHHrs":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'DrvHDriver', 'Driver'
					union select 'DrvHWk', 'Week'
					union select 'DrvHHrs', 'Hours'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "DrvHDriver":
					return new DriverHrs_DrvHDriverFieldDef();
							case "DrvHWk":
					return new DriverHrs_DrvHWkFieldDef();
							case "DrvHHrs":
					return new DriverHrs_DrvHHrsFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, DrvHDriver as [Description] from DriverHrs 
			where DrvHDriver like @q or DrvHDriver like @q";
	}
	
}
public class DSTypeInvBatch : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "InvBId":
					return "Batch Number";
							case "InvBType":
					return "Invoice Type";
							case "InvBPrintedOn":
					return "Printed On";
							case "InvBExportedDate":
					return "Sent to Dover On";
							case "InvBExported":
					return "Sent";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "InvBId":
					return 292;
							case "InvBType":
					return 293;
							case "InvBPrintedOn":
					return 294;
							case "InvBExportedDate":
					return 295;
							case "InvBExported":
					return 296;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "InvBId":
				return IQApp.Operators.GetNumberOperators(selected);							case "InvBType":
				return IQApp.Operators.GetComboOperators(selected);							case "InvBPrintedOn":
				return IQApp.Operators.GetTextOperators(selected);							case "InvBExportedDate":
				return IQApp.Operators.GetTextOperators(selected);							case "InvBExported":
				return IQApp.Operators.GetBooleanOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'InvBId', 'Batch Number'
					union select 'InvBType', 'Invoice Type'
					union select 'InvBPrintedOn', 'Printed On'
					union select 'InvBExportedDate', 'Sent to Dover On'
					union select 'InvBExported', 'Sent'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "InvBId":
					return new InvBatch_InvBIdFieldDef();
							case "InvBType":
					return new InvBatch_InvBTypeFieldDef();
							case "InvBPrintedOn":
					return new InvBatch_InvBPrintedOnFieldDef();
							case "InvBExportedDate":
					return new InvBatch_InvBExportedDateFieldDef();
							case "InvBExported":
					return new InvBatch_InvBExportedFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, InvBId as [Description] from InvBatch 
			where InvBId like @q or InvBId like @q";
	}
	
}
public class DSTypePackageType : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "PackId":
					return "Package Type ID";
							case "PackName":
					return "Package Type";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "PackId":
					return 318;
							case "PackName":
					return 319;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "PackId":
				return IQApp.Operators.GetNumberOperators(selected);							case "PackName":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'PackId', 'Package Type ID'
					union select 'PackName', 'Package Type'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "PackId":
					return new PackageType_PackIdFieldDef();
							case "PackName":
					return new PackageType_PackNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, PackName as [Description] from PackageType 
			where PackId like @q or PackName like @q";
	}
	
}
public class DSTypeBottleSize : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "BSzId":
					return "Size ID";
							case "BSzSize":
					return "Bottle Size";
							case "BSzOrder":
					return "Sort Order";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "BSzId":
					return 320;
							case "BSzSize":
					return 321;
							case "BSzOrder":
					return 324;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "BSzId":
				return IQApp.Operators.GetNumberOperators(selected);							case "BSzSize":
				return IQApp.Operators.GetTextOperators(selected);							case "BSzOrder":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'BSzId', 'Size ID'
					union select 'BSzSize', 'Bottle Size'
					union select 'BSzOrder', 'Sort Order'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "BSzId":
					return new BottleSize_BSzIdFieldDef();
							case "BSzSize":
					return new BottleSize_BSzSizeFieldDef();
							case "BSzOrder":
					return new BottleSize_BSzOrderFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, BSzSize as [Description] from BottleSize 
			where BSzId like @q or BSzSize like @q";
	}
	
}
public class DSTypePalletType : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "PallId":
					return "Pallet Type ID";
							case "PallName":
					return "Pallet Type";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "PallId":
					return 322;
							case "PallName":
					return 323;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "PallId":
				return IQApp.Operators.GetNumberOperators(selected);							case "PallName":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'PallId', 'Pallet Type ID'
					union select 'PallName', 'Pallet Type'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "PallId":
					return new PalletType_PallIdFieldDef();
							case "PallName":
					return new PalletType_PallNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, PallName as [Description] from PalletType 
			where PallId like @q or PallName like @q";
	}
	
}
public class DSTypeEADNum : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "EADNo":
					return "eAD Number";
							case "EADOrder":
					return "Order Number";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "EADNo":
					return 342;
							case "EADOrder":
					return 343;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "EADNo":
				return IQApp.Operators.GetTextOperators(selected);							case "EADOrder":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'EADNo', 'eAD Number'
					union select 'EADOrder', 'Order Number'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "EADNo":
					return new EADNum_EADNoFieldDef();
							case "EADOrder":
					return new EADNum_EADOrderFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, EADNo as [Description] from EADNum 
			where EADOrder like @q or EADNo like @q";
	}
	
}
public class DSTypeShipDoc : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "SDId":
					return "Document ID";
							case "SDSuppId":
					return "Supplier ID";
							case "SDSupp":
					return "Supplier Name";
							case "SDSuppAddr":
					return "Supplier Address";
							case "SDSuppVATNo":
					return "Supplier VAT No";
							case "SDTransRef":
					return "Transaction Ref";
							case "SDCompAuth":
					return "Competent Auth";
							case "SDRecipId":
					return "Recipient ID";
							case "SDRecip":
					return "Recipient Name";
							case "SDRecipAddr":
					return "Recipient Address";
							case "SDRecipVATNo":
					return "Recipient VAT No";
							case "SDRefNo":
					return "Reference Number";
							case "SDDeclareDate":
					return "Declaration Date";
							case "SDDelPlace":
					return "Place of delivery";
							case "SDDesc":
					return "Description (1)";
							case "SDCommCode1":
					return "Comm Code (1)";
							case "SDQty1":
					return "Quantity (1)";
							case "SDGWeight1":
					return "Gross weight (1)";
							case "SDNWeight1":
					return "Net weight (1)";
							case "SDValue1":
					return "Value (1)";
							case "SDDesc2":
					return "Description (2)";
							case "SDCommCode2":
					return "Comm Code (2)";
							case "SDQty2":
					return "Quantity (2)";
							case "SDGWeight2":
					return "Gross weight (2)";
							case "SDNWeight2":
					return "Net weight (2)";
							case "SDValue2":
					return "Value (2)";
							case "SDDesc3":
					return "Description (3)";
							case "SDCommCode3":
					return "Comm Code (3)";
							case "SDQty3":
					return "Quantity (3)";
							case "SDGWeight3":
					return "Gross weight (3)";
							case "SDNWeight3":
					return "Net weight (3)";
							case "SDValue3":
					return "Value (3)";
							case "SDDesc4":
					return "Description (4)";
							case "SDCommCode4":
					return "Comm Code (4)";
							case "SDQty4":
					return "Quantity (4)";
							case "SDGWeight4":
					return "Gross weight (4)";
							case "SDNWeight4":
					return "Net weight (4)";
							case "SDValue4":
					return "Value (4)";
							case "SDRecordControl":
					return "Record of Control";
							case "SDSignedBy":
					return "Signed by";
							case "SDSignedByText":
					return "Signed by text";
							case "SDVehNo":
					return "Vehicle / Trailer No";
							case "SDCurr":
					return "Currency";
							case "SDHMRCDets":
					return "Show HMRC details";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "SDId":
					return 347;
							case "SDSuppId":
					return 348;
							case "SDSupp":
					return 349;
							case "SDSuppAddr":
					return 350;
							case "SDSuppVATNo":
					return 351;
							case "SDTransRef":
					return 352;
							case "SDCompAuth":
					return 353;
							case "SDRecipId":
					return 354;
							case "SDRecip":
					return 355;
							case "SDRecipAddr":
					return 356;
							case "SDRecipVATNo":
					return 357;
							case "SDRefNo":
					return 358;
							case "SDDeclareDate":
					return 359;
							case "SDDelPlace":
					return 360;
							case "SDDesc":
					return 361;
							case "SDCommCode1":
					return 362;
							case "SDQty1":
					return 363;
							case "SDGWeight1":
					return 364;
							case "SDNWeight1":
					return 365;
							case "SDValue1":
					return 366;
							case "SDDesc2":
					return 367;
							case "SDCommCode2":
					return 368;
							case "SDQty2":
					return 369;
							case "SDGWeight2":
					return 370;
							case "SDNWeight2":
					return 371;
							case "SDValue2":
					return 372;
							case "SDDesc3":
					return 373;
							case "SDCommCode3":
					return 374;
							case "SDQty3":
					return 375;
							case "SDGWeight3":
					return 376;
							case "SDNWeight3":
					return 377;
							case "SDValue3":
					return 378;
							case "SDDesc4":
					return 379;
							case "SDCommCode4":
					return 380;
							case "SDQty4":
					return 381;
							case "SDGWeight4":
					return 382;
							case "SDNWeight4":
					return 383;
							case "SDValue4":
					return 384;
							case "SDRecordControl":
					return 391;
							case "SDSignedBy":
					return 392;
							case "SDSignedByText":
					return 393;
							case "SDVehNo":
					return 394;
							case "SDCurr":
					return 395;
							case "SDHMRCDets":
					return 396;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "SDId":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDSuppId":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDSupp":
				return IQApp.Operators.GetComboOperators(selected);							case "SDSuppAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "SDSuppVATNo":
				return IQApp.Operators.GetTextOperators(selected);							case "SDTransRef":
				return IQApp.Operators.GetTextOperators(selected);							case "SDCompAuth":
				return IQApp.Operators.GetTextOperators(selected);							case "SDRecipId":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDRecip":
				return IQApp.Operators.GetComboOperators(selected);							case "SDRecipAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "SDRecipVATNo":
				return IQApp.Operators.GetTextOperators(selected);							case "SDRefNo":
				return IQApp.Operators.GetTextOperators(selected);							case "SDDeclareDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDDelPlace":
				return IQApp.Operators.GetTextOperators(selected);							case "SDDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "SDCommCode1":
				return IQApp.Operators.GetTextOperators(selected);							case "SDQty1":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDGWeight1":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDNWeight1":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDValue1":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDDesc2":
				return IQApp.Operators.GetTextOperators(selected);							case "SDCommCode2":
				return IQApp.Operators.GetTextOperators(selected);							case "SDQty2":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDGWeight2":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDNWeight2":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDValue2":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDDesc3":
				return IQApp.Operators.GetTextOperators(selected);							case "SDCommCode3":
				return IQApp.Operators.GetTextOperators(selected);							case "SDQty3":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDGWeight3":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDNWeight3":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDValue3":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDDesc4":
				return IQApp.Operators.GetTextOperators(selected);							case "SDCommCode4":
				return IQApp.Operators.GetTextOperators(selected);							case "SDQty4":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDGWeight4":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDNWeight4":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDValue4":
				return IQApp.Operators.GetNumberOperators(selected);							case "SDRecordControl":
				return IQApp.Operators.GetTextOperators(selected);							case "SDSignedBy":
				return IQApp.Operators.GetComboOperators(selected);							case "SDSignedByText":
				return IQApp.Operators.GetTextOperators(selected);							case "SDVehNo":
				return IQApp.Operators.GetTextOperators(selected);							case "SDCurr":
				return IQApp.Operators.GetComboOperators(selected);							case "SDHMRCDets":
				return IQApp.Operators.GetBooleanOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'SDId', 'Document ID'
					union select 'SDSuppId', 'Supplier ID'
					union select 'SDSupp', 'Supplier Name'
					union select 'SDSuppAddr', 'Supplier Address'
					union select 'SDSuppVATNo', 'Supplier VAT No'
					union select 'SDTransRef', 'Transaction Ref'
					union select 'SDCompAuth', 'Competent Auth'
					union select 'SDRecipId', 'Recipient ID'
					union select 'SDRecip', 'Recipient Name'
					union select 'SDRecipAddr', 'Recipient Address'
					union select 'SDRecipVATNo', 'Recipient VAT No'
					union select 'SDRefNo', 'Reference Number'
					union select 'SDDeclareDate', 'Declaration Date'
					union select 'SDDelPlace', 'Place of delivery'
					union select 'SDDesc', 'Description (1)'
					union select 'SDCommCode1', 'Comm Code (1)'
					union select 'SDQty1', 'Quantity (1)'
					union select 'SDGWeight1', 'Gross weight (1)'
					union select 'SDNWeight1', 'Net weight (1)'
					union select 'SDValue1', 'Value (1)'
					union select 'SDDesc2', 'Description (2)'
					union select 'SDCommCode2', 'Comm Code (2)'
					union select 'SDQty2', 'Quantity (2)'
					union select 'SDGWeight2', 'Gross weight (2)'
					union select 'SDNWeight2', 'Net weight (2)'
					union select 'SDValue2', 'Value (2)'
					union select 'SDDesc3', 'Description (3)'
					union select 'SDCommCode3', 'Comm Code (3)'
					union select 'SDQty3', 'Quantity (3)'
					union select 'SDGWeight3', 'Gross weight (3)'
					union select 'SDNWeight3', 'Net weight (3)'
					union select 'SDValue3', 'Value (3)'
					union select 'SDDesc4', 'Description (4)'
					union select 'SDCommCode4', 'Comm Code (4)'
					union select 'SDQty4', 'Quantity (4)'
					union select 'SDGWeight4', 'Gross weight (4)'
					union select 'SDNWeight4', 'Net weight (4)'
					union select 'SDValue4', 'Value (4)'
					union select 'SDRecordControl', 'Record of Control'
					union select 'SDSignedBy', 'Signed by'
					union select 'SDSignedByText', 'Signed by text'
					union select 'SDVehNo', 'Vehicle / Trailer No'
					union select 'SDCurr', 'Currency'
					union select 'SDHMRCDets', 'Show HMRC details'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "SDId":
					return new ShipDoc_SDIdFieldDef();
							case "SDSuppId":
					return new ShipDoc_SDSuppIdFieldDef();
							case "SDSupp":
					return new ShipDoc_SDSuppFieldDef();
							case "SDSuppAddr":
					return new ShipDoc_SDSuppAddrFieldDef();
							case "SDSuppVATNo":
					return new ShipDoc_SDSuppVATNoFieldDef();
							case "SDTransRef":
					return new ShipDoc_SDTransRefFieldDef();
							case "SDCompAuth":
					return new ShipDoc_SDCompAuthFieldDef();
							case "SDRecipId":
					return new ShipDoc_SDRecipIdFieldDef();
							case "SDRecip":
					return new ShipDoc_SDRecipFieldDef();
							case "SDRecipAddr":
					return new ShipDoc_SDRecipAddrFieldDef();
							case "SDRecipVATNo":
					return new ShipDoc_SDRecipVATNoFieldDef();
							case "SDRefNo":
					return new ShipDoc_SDRefNoFieldDef();
							case "SDDeclareDate":
					return new ShipDoc_SDDeclareDateFieldDef();
							case "SDDelPlace":
					return new ShipDoc_SDDelPlaceFieldDef();
							case "SDDesc":
					return new ShipDoc_SDDescFieldDef();
							case "SDCommCode1":
					return new ShipDoc_SDCommCode1FieldDef();
							case "SDQty1":
					return new ShipDoc_SDQty1FieldDef();
							case "SDGWeight1":
					return new ShipDoc_SDGWeight1FieldDef();
							case "SDNWeight1":
					return new ShipDoc_SDNWeight1FieldDef();
							case "SDValue1":
					return new ShipDoc_SDValue1FieldDef();
							case "SDDesc2":
					return new ShipDoc_SDDesc2FieldDef();
							case "SDCommCode2":
					return new ShipDoc_SDCommCode2FieldDef();
							case "SDQty2":
					return new ShipDoc_SDQty2FieldDef();
							case "SDGWeight2":
					return new ShipDoc_SDGWeight2FieldDef();
							case "SDNWeight2":
					return new ShipDoc_SDNWeight2FieldDef();
							case "SDValue2":
					return new ShipDoc_SDValue2FieldDef();
							case "SDDesc3":
					return new ShipDoc_SDDesc3FieldDef();
							case "SDCommCode3":
					return new ShipDoc_SDCommCode3FieldDef();
							case "SDQty3":
					return new ShipDoc_SDQty3FieldDef();
							case "SDGWeight3":
					return new ShipDoc_SDGWeight3FieldDef();
							case "SDNWeight3":
					return new ShipDoc_SDNWeight3FieldDef();
							case "SDValue3":
					return new ShipDoc_SDValue3FieldDef();
							case "SDDesc4":
					return new ShipDoc_SDDesc4FieldDef();
							case "SDCommCode4":
					return new ShipDoc_SDCommCode4FieldDef();
							case "SDQty4":
					return new ShipDoc_SDQty4FieldDef();
							case "SDGWeight4":
					return new ShipDoc_SDGWeight4FieldDef();
							case "SDNWeight4":
					return new ShipDoc_SDNWeight4FieldDef();
							case "SDValue4":
					return new ShipDoc_SDValue4FieldDef();
							case "SDRecordControl":
					return new ShipDoc_SDRecordControlFieldDef();
							case "SDSignedBy":
					return new ShipDoc_SDSignedByFieldDef();
							case "SDSignedByText":
					return new ShipDoc_SDSignedByTextFieldDef();
							case "SDVehNo":
					return new ShipDoc_SDVehNoFieldDef();
							case "SDCurr":
					return new ShipDoc_SDCurrFieldDef();
							case "SDHMRCDets":
					return new ShipDoc_SDHMRCDetsFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, SDId as [Description] from ShipDoc 
			where SDId like @q or SDId like @q";
	}
	
}
public class DSTypeTruck : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "TrkId":
					return "Truck ID";
							case "TrkName":
					return "Registration No";
							case "TrkNotes":
					return "Notes";
							case "TrkMOTDate":
					return "MOT Date";
							case "TrkTAXDate":
					return "TAX Due Date";
							case "TrkDriver":
					return "Driver";
							case "TrkServiceDue":
					return "Service Due";
							case "TrkAS24No":
					return "AS24 Card No:";
							case "TrkAS24PIN":
					return "AS24 Pin No:";
							case "TrkDKVNo":
					return "DKV No:";
							case "TrkDKVPIN":
					return "DKV Pin No:";
							case "TrkShellNo":
					return "Shell No:";
							case "TrkShellPIN":
					return "Shell Pin No:";
							case "TrkPermitNo":
					return "Permit No:";
							case "TrkTruckMob":
					return "Truck Mobile:";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "TrkId":
					return 397;
							case "TrkName":
					return 398;
							case "TrkNotes":
					return 399;
							case "TrkMOTDate":
					return 767;
							case "TrkTAXDate":
					return 768;
							case "TrkDriver":
					return 769;
							case "TrkServiceDue":
					return 801;
							case "TrkAS24No":
					return 802;
							case "TrkAS24PIN":
					return 803;
							case "TrkDKVNo":
					return 804;
							case "TrkDKVPIN":
					return 805;
							case "TrkShellNo":
					return 806;
							case "TrkShellPIN":
					return 807;
							case "TrkPermitNo":
					return 808;
							case "TrkTruckMob":
					return 809;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "TrkId":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkName":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkMOTDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkTAXDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkDriver":
				return IQApp.Operators.GetComboOperators(selected);							case "TrkServiceDue":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkAS24No":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkAS24PIN":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkDKVNo":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkDKVPIN":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkShellNo":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkShellPIN":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkPermitNo":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkTruckMob":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'TrkId', 'Truck ID'
					union select 'TrkName', 'Registration No'
					union select 'TrkNotes', 'Notes'
					union select 'TrkMOTDate', 'MOT Date'
					union select 'TrkTAXDate', 'TAX Due Date'
					union select 'TrkDriver', 'Driver'
					union select 'TrkServiceDue', 'Service Due'
					union select 'TrkAS24No', 'AS24 Card No:'
					union select 'TrkAS24PIN', 'AS24 Pin No:'
					union select 'TrkDKVNo', 'DKV No:'
					union select 'TrkDKVPIN', 'DKV Pin No:'
					union select 'TrkShellNo', 'Shell No:'
					union select 'TrkShellPIN', 'Shell Pin No:'
					union select 'TrkPermitNo', 'Permit No:'
					union select 'TrkTruckMob', 'Truck Mobile:'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "TrkId":
					return new Truck_TrkIdFieldDef();
							case "TrkName":
					return new Truck_TrkNameFieldDef();
							case "TrkNotes":
					return new Truck_TrkNotesFieldDef();
							case "TrkMOTDate":
					return new Truck_TrkMOTDateFieldDef();
							case "TrkTAXDate":
					return new Truck_TrkTAXDateFieldDef();
							case "TrkDriver":
					return new Truck_TrkDriverFieldDef();
							case "TrkServiceDue":
					return new Truck_TrkServiceDueFieldDef();
							case "TrkAS24No":
					return new Truck_TrkAS24NoFieldDef();
							case "TrkAS24PIN":
					return new Truck_TrkAS24PINFieldDef();
							case "TrkDKVNo":
					return new Truck_TrkDKVNoFieldDef();
							case "TrkDKVPIN":
					return new Truck_TrkDKVPINFieldDef();
							case "TrkShellNo":
					return new Truck_TrkShellNoFieldDef();
							case "TrkShellPIN":
					return new Truck_TrkShellPINFieldDef();
							case "TrkPermitNo":
					return new Truck_TrkPermitNoFieldDef();
							case "TrkTruckMob":
					return new Truck_TrkTruckMobFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, TrkName as [Description] from Truck 
			where TrkId like @q or TrkName like @q";
	}
	
}
public class DSTypeTruckMileage : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "TrkMTruck":
					return "Truck";
							case "TrkMPurchDate":
					return "Date of Purchase";
							case "TrkMPurchLitre":
					return "Litres purchased";
							case "TrkMOdometer":
					return "Odometer (km)";
							case "TrkMNotes":
					return "Notes";
							case "TrkMNextReading":
					return "Next reading (km)";
							case "TrkMMpg":
					return "Mpg";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "TrkMTruck":
					return 400;
							case "TrkMPurchDate":
					return 401;
							case "TrkMPurchLitre":
					return 402;
							case "TrkMOdometer":
					return 403;
							case "TrkMNotes":
					return 404;
							case "TrkMNextReading":
					return 405;
							case "TrkMMpg":
					return 406;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "TrkMTruck":
				return IQApp.Operators.GetComboOperators(selected);							case "TrkMPurchDate":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkMPurchLitre":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkMOdometer":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkMNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "TrkMNextReading":
				return IQApp.Operators.GetNumberOperators(selected);							case "TrkMMpg":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'TrkMTruck', 'Truck'
					union select 'TrkMPurchDate', 'Date of Purchase'
					union select 'TrkMPurchLitre', 'Litres purchased'
					union select 'TrkMOdometer', 'Odometer (km)'
					union select 'TrkMNotes', 'Notes'
					union select 'TrkMNextReading', 'Next reading (km)'
					union select 'TrkMMpg', 'Mpg'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "TrkMTruck":
					return new TruckMileage_TrkMTruckFieldDef();
							case "TrkMPurchDate":
					return new TruckMileage_TrkMPurchDateFieldDef();
							case "TrkMPurchLitre":
					return new TruckMileage_TrkMPurchLitreFieldDef();
							case "TrkMOdometer":
					return new TruckMileage_TrkMOdometerFieldDef();
							case "TrkMNotes":
					return new TruckMileage_TrkMNotesFieldDef();
							case "TrkMNextReading":
					return new TruckMileage_TrkMNextReadingFieldDef();
							case "TrkMMpg":
					return new TruckMileage_TrkMMpgFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, TrkMTruck as [Description] from TruckMileage 
			where TrkMTruck like @q or TrkMTruck like @q";
	}
	
}
public class DSTypeCustomer : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "CustDelZone":
					return "Delivery Zone";
							case "CustEM2":
					return "E-Mail 2";
							case "CustEM3":
					return "E-Mail 3";
							case "CustEM4":
					return "E-Mail 4";
							case "CustCreatedBy":
					return "Created By";
							case "CustOnFTrack":
					return "On FreightTrack";
							case "CustFTLNotes":
					return "In House Notes";
							case "CustSendStatus":
					return "Send Status";
							case "CustLang":
					return "Language";
							case "CustSortCode":
					return "Sort Code";
							case "CustType":
					return "Client Type";
							case "CustVATNo":
					return "VAT Number";
							case "CustDANNo":
					return "DAN Number";
							case "CustBondCode":
					return "REDS / Bond Code";
							case "CustIntrastat":
					return "Intrastat";
							case "CustCurr":
					return "Currency";
							case "CustRates":
					return "Rates";
							case "CustGenNotes":
					return "General Notes";
							case "CustWebsite":
					return "Website";
							case "CustRecDueDil":
					return "Received Due Diligence";
							case "CustCrdChecked":
					return "Credit Score Checked";
							case "CustCrdScr":
					return "Credit Score";
							case "CustCrdRvDate":
					return "Credit Score Review Date";
							case "CustAccContact":
					return "Accounts Contact";
							case "CustAccEmail":
					return "Accounts Email";
							case "CustGBWK":
					return "GBWK";
							case "CustAADSys":
					return "AAD System";
							case "CustUserName":
					return "Portal UserName";
							case "CustPassword":
					return "Portal Password";
							case "CustId":
					return "Company ID";
							case "CustName":
					return "Company Name";
							case "CustAddr":
					return "Address1";
							case "CustAddr2":
					return "Address2";
							case "CustAddr3":
					return "Address3";
							case "CustTown":
					return "Town";
							case "CustCounty":
					return "County";
							case "CustPC":
					return "Postcode";
							case "CustCtry":
					return "Country";
							case "CustPhone":
					return "Telephone";
							case "CustFax":
					return "Fax";
							case "CustEM":
					return "EMail";
							case "CustDueDiligence":
					return "Due Diligence Received";
							case "CustCredScoreSearch":
					return "Credit Score Searched";
							case "CustCredScore":
					return "Credit Score Number";
							case "CustCredScoreReview":
					return "Credit Score Review date";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "CustDelZone":
					return 287;
							case "CustEM2":
					return 329;
							case "CustEM3":
					return 330;
							case "CustEM4":
					return 331;
							case "CustCreatedBy":
					return 291;
							case "CustOnFTrack":
					return 250;
							case "CustFTLNotes":
					return 200;
							case "CustSendStatus":
					return 193;
							case "CustLang":
					return 150;
							case "CustSortCode":
					return 21;
							case "CustType":
					return 22;
							case "CustVATNo":
					return 23;
							case "CustDANNo":
					return 24;
							case "CustBondCode":
					return 25;
							case "CustIntrastat":
					return 26;
							case "CustCurr":
					return 27;
							case "CustRates":
					return 28;
							case "CustGenNotes":
					return 29;
							case "CustWebsite":
					return 697;
							case "CustRecDueDil":
					return 773;
							case "CustCrdChecked":
					return 774;
							case "CustCrdScr":
					return 775;
							case "CustCrdRvDate":
					return 776;
							case "CustAccContact":
					return 788;
							case "CustAccEmail":
					return 789;
							case "CustGBWK":
					return 341;
							case "CustAADSys":
					return 338;
							case "CustUserName":
					return 432;
							case "CustPassword":
					return 433;
							case "CustId":
					return 409;
							case "CustName":
					return 410;
							case "CustAddr":
					return 411;
							case "CustAddr2":
					return 412;
							case "CustAddr3":
					return 413;
							case "CustTown":
					return 414;
							case "CustCounty":
					return 415;
							case "CustPC":
					return 416;
							case "CustCtry":
					return 417;
							case "CustPhone":
					return 418;
							case "CustFax":
					return 419;
							case "CustEM":
					return 420;
							case "CustDueDiligence":
					return 672;
							case "CustCredScoreSearch":
					return 673;
							case "CustCredScore":
					return 674;
							case "CustCredScoreReview":
					return 675;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "CustDelZone":
				return IQApp.Operators.GetComboOperators(selected);							case "CustEM2":
				return IQApp.Operators.GetTextOperators(selected);							case "CustEM3":
				return IQApp.Operators.GetTextOperators(selected);							case "CustEM4":
				return IQApp.Operators.GetTextOperators(selected);							case "CustCreatedBy":
				return IQApp.Operators.GetComboOperators(selected);							case "CustOnFTrack":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustFTLNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "CustSendStatus":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustLang":
				return IQApp.Operators.GetComboOperators(selected);							case "CustSortCode":
				return IQApp.Operators.GetTextOperators(selected);							case "CustType":
				return IQApp.Operators.GetComboOperators(selected);							case "CustVATNo":
				return IQApp.Operators.GetTextOperators(selected);							case "CustDANNo":
				return IQApp.Operators.GetTextOperators(selected);							case "CustBondCode":
				return IQApp.Operators.GetTextOperators(selected);							case "CustIntrastat":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustCurr":
				return IQApp.Operators.GetComboOperators(selected);							case "CustRates":
				return IQApp.Operators.GetTextOperators(selected);							case "CustGenNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "CustWebsite":
				return IQApp.Operators.GetTextOperators(selected);							case "CustRecDueDil":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustCrdChecked":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustCrdScr":
				return IQApp.Operators.GetTextOperators(selected);							case "CustCrdRvDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "CustAccContact":
				return IQApp.Operators.GetTextOperators(selected);							case "CustAccEmail":
				return IQApp.Operators.GetTextOperators(selected);							case "CustGBWK":
				return IQApp.Operators.GetTextOperators(selected);							case "CustAADSys":
				return IQApp.Operators.GetComboOperators(selected);							case "CustUserName":
				return IQApp.Operators.GetTextOperators(selected);							case "CustPassword":
				return IQApp.Operators.GetTextOperators(selected);							case "CustId":
				return IQApp.Operators.GetNumberOperators(selected);							case "CustName":
				return IQApp.Operators.GetTextOperators(selected);							case "CustAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "CustAddr2":
				return IQApp.Operators.GetTextOperators(selected);							case "CustAddr3":
				return IQApp.Operators.GetTextOperators(selected);							case "CustTown":
				return IQApp.Operators.GetTextOperators(selected);							case "CustCounty":
				return IQApp.Operators.GetTextOperators(selected);							case "CustPC":
				return IQApp.Operators.GetTextOperators(selected);							case "CustCtry":
				return IQApp.Operators.GetComboOperators(selected);							case "CustPhone":
				return IQApp.Operators.GetTextOperators(selected);							case "CustFax":
				return IQApp.Operators.GetTextOperators(selected);							case "CustEM":
				return IQApp.Operators.GetTextOperators(selected);							case "CustDueDiligence":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustCredScoreSearch":
				return IQApp.Operators.GetBooleanOperators(selected);							case "CustCredScore":
				return IQApp.Operators.GetNumberOperators(selected);							case "CustCredScoreReview":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'CustDelZone', 'Delivery Zone'
					union select 'CustEM2', 'E-Mail 2'
					union select 'CustEM3', 'E-Mail 3'
					union select 'CustEM4', 'E-Mail 4'
					union select 'CustCreatedBy', 'Created By'
					union select 'CustOnFTrack', 'On FreightTrack'
					union select 'CustFTLNotes', 'In House Notes'
					union select 'CustSendStatus', 'Send Status'
					union select 'CustLang', 'Language'
					union select 'CustSortCode', 'Sort Code'
					union select 'CustType', 'Client Type'
					union select 'CustVATNo', 'VAT Number'
					union select 'CustDANNo', 'DAN Number'
					union select 'CustBondCode', 'REDS / Bond Code'
					union select 'CustIntrastat', 'Intrastat'
					union select 'CustCurr', 'Currency'
					union select 'CustRates', 'Rates'
					union select 'CustGenNotes', 'General Notes'
					union select 'CustWebsite', 'Website'
					union select 'CustRecDueDil', 'Received Due Diligence'
					union select 'CustCrdChecked', 'Credit Score Checked'
					union select 'CustCrdScr', 'Credit Score'
					union select 'CustCrdRvDate', 'Credit Score Review Date'
					union select 'CustAccContact', 'Accounts Contact'
					union select 'CustAccEmail', 'Accounts Email'
					union select 'CustGBWK', 'GBWK'
					union select 'CustAADSys', 'AAD System'
					union select 'CustUserName', 'Portal UserName'
					union select 'CustPassword', 'Portal Password'
					union select 'CustId', 'Company ID'
					union select 'CustName', 'Company Name'
					union select 'CustAddr', 'Address1'
					union select 'CustAddr2', 'Address2'
					union select 'CustAddr3', 'Address3'
					union select 'CustTown', 'Town'
					union select 'CustCounty', 'County'
					union select 'CustPC', 'Postcode'
					union select 'CustCtry', 'Country'
					union select 'CustPhone', 'Telephone'
					union select 'CustFax', 'Fax'
					union select 'CustEM', 'EMail'
					union select 'CustDueDiligence', 'Due Diligence Received'
					union select 'CustCredScoreSearch', 'Credit Score Searched'
					union select 'CustCredScore', 'Credit Score Number'
					union select 'CustCredScoreReview', 'Credit Score Review date'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "CustDelZone":
					return new Customer_CustDelZoneFieldDef();
							case "CustEM2":
					return new Customer_CustEM2FieldDef();
							case "CustEM3":
					return new Customer_CustEM3FieldDef();
							case "CustEM4":
					return new Customer_CustEM4FieldDef();
							case "CustCreatedBy":
					return new Customer_CustCreatedByFieldDef();
							case "CustOnFTrack":
					return new Customer_CustOnFTrackFieldDef();
							case "CustFTLNotes":
					return new Customer_CustFTLNotesFieldDef();
							case "CustSendStatus":
					return new Customer_CustSendStatusFieldDef();
							case "CustLang":
					return new Customer_CustLangFieldDef();
							case "CustSortCode":
					return new Customer_CustSortCodeFieldDef();
							case "CustType":
					return new Customer_CustTypeFieldDef();
							case "CustVATNo":
					return new Customer_CustVATNoFieldDef();
							case "CustDANNo":
					return new Customer_CustDANNoFieldDef();
							case "CustBondCode":
					return new Customer_CustBondCodeFieldDef();
							case "CustIntrastat":
					return new Customer_CustIntrastatFieldDef();
							case "CustCurr":
					return new Customer_CustCurrFieldDef();
							case "CustRates":
					return new Customer_CustRatesFieldDef();
							case "CustGenNotes":
					return new Customer_CustGenNotesFieldDef();
							case "CustWebsite":
					return new Customer_CustWebsiteFieldDef();
							case "CustRecDueDil":
					return new Customer_CustRecDueDilFieldDef();
							case "CustCrdChecked":
					return new Customer_CustCrdCheckedFieldDef();
							case "CustCrdScr":
					return new Customer_CustCrdScrFieldDef();
							case "CustCrdRvDate":
					return new Customer_CustCrdRvDateFieldDef();
							case "CustAccContact":
					return new Customer_CustAccContactFieldDef();
							case "CustAccEmail":
					return new Customer_CustAccEmailFieldDef();
							case "CustGBWK":
					return new Customer_CustGBWKFieldDef();
							case "CustAADSys":
					return new Customer_CustAADSysFieldDef();
							case "CustUserName":
					return new Customer_CustUserNameFieldDef();
							case "CustPassword":
					return new Customer_CustPasswordFieldDef();
							case "CustId":
					return new Customer_CustIdFieldDef();
							case "CustName":
					return new Customer_CustNameFieldDef();
							case "CustAddr":
					return new Customer_CustAddrFieldDef();
							case "CustAddr2":
					return new Customer_CustAddr2FieldDef();
							case "CustAddr3":
					return new Customer_CustAddr3FieldDef();
							case "CustTown":
					return new Customer_CustTownFieldDef();
							case "CustCounty":
					return new Customer_CustCountyFieldDef();
							case "CustPC":
					return new Customer_CustPCFieldDef();
							case "CustCtry":
					return new Customer_CustCtryFieldDef();
							case "CustPhone":
					return new Customer_CustPhoneFieldDef();
							case "CustFax":
					return new Customer_CustFaxFieldDef();
							case "CustEM":
					return new Customer_CustEMFieldDef();
							case "CustDueDiligence":
					return new Customer_CustDueDiligenceFieldDef();
							case "CustCredScoreSearch":
					return new Customer_CustCredScoreSearchFieldDef();
							case "CustCredScore":
					return new Customer_CustCredScoreFieldDef();
							case "CustCredScoreReview":
					return new Customer_CustCredScoreReviewFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, CustName as [Description] from Customer 
			where CustId like @q or CustName like @q";
	}
	
}
public class DSTypeCountry : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "CtryId":
					return "Country ID";
							case "CtryCode":
					return "Country Code";
							case "CtryName":
					return "Country";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "CtryId":
					return 421;
							case "CtryCode":
					return 422;
							case "CtryName":
					return 423;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "CtryId":
				return IQApp.Operators.GetNumberOperators(selected);							case "CtryCode":
				return IQApp.Operators.GetTextOperators(selected);							case "CtryName":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'CtryId', 'Country ID'
					union select 'CtryCode', 'Country Code'
					union select 'CtryName', 'Country'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "CtryId":
					return new Country_CtryIdFieldDef();
							case "CtryCode":
					return new Country_CtryCodeFieldDef();
							case "CtryName":
					return new Country_CtryNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, CtryName as [Description] from Country 
			where CtryId like @q or CtryName like @q";
	}
	
}
public class DSTypeREDSOrder : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "RDOrdId":
					return "REDS ID";
							case "RDOrdCustId":
					return "Client ID";
							case "RDOrdDANNo":
					return "DAN Number";
							case "RDOrdJobNo":
					return "Job Number";
							case "RDOrdJobLetter":
					return "Job Letter";
							case "RDOrdCustOrd":
					return "Client Order No";
							case "RDOrdArrDate":
					return "Arrival Date";
							case "RDOrdDelDate":
					return "Delivery Date";
							case "RDOrdOrder":
					return "Order Number";
							case "RDOrdCust":
					return "Client Name";
							case "RDOrdInvCreated":
					return "Invoice Created";
							case "RDOrdDesc":
					return "Description";
							case "RDOrdLocked":
					return "Locked";
							case "RDOrdDutyPaid":
					return "Duty Paid";
							case "RDOrdARCNo":
					return "ARC Number";
							case "RDOrdHM10":
					return "HM10";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "RDOrdId":
					return 521;
							case "RDOrdCustId":
					return 522;
							case "RDOrdDANNo":
					return 523;
							case "RDOrdJobNo":
					return 524;
							case "RDOrdJobLetter":
					return 525;
							case "RDOrdCustOrd":
					return 526;
							case "RDOrdArrDate":
					return 527;
							case "RDOrdDelDate":
					return 528;
							case "RDOrdOrder":
					return 535;
							case "RDOrdCust":
					return 536;
							case "RDOrdInvCreated":
					return 545;
							case "RDOrdDesc":
					return 551;
							case "RDOrdLocked":
					return 552;
							case "RDOrdDutyPaid":
					return 553;
							case "RDOrdARCNo":
					return 554;
							case "RDOrdHM10":
					return 555;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "RDOrdId":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOrdCustId":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOrdDANNo":
				return IQApp.Operators.GetTextOperators(selected);							case "RDOrdJobNo":
				return IQApp.Operators.GetComboOperators(selected);							case "RDOrdJobLetter":
				return IQApp.Operators.GetTextOperators(selected);							case "RDOrdCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "RDOrdArrDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOrdDelDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOrdOrder":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOrdCust":
				return IQApp.Operators.GetTextOperators(selected);							case "RDOrdInvCreated":
				return IQApp.Operators.GetBooleanOperators(selected);							case "RDOrdDesc":
				return IQApp.Operators.GetTextOperators(selected);							case "RDOrdLocked":
				return IQApp.Operators.GetBooleanOperators(selected);							case "RDOrdDutyPaid":
				return IQApp.Operators.GetBooleanOperators(selected);							case "RDOrdARCNo":
				return IQApp.Operators.GetTextOperators(selected);							case "RDOrdHM10":
				return IQApp.Operators.GetBooleanOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'RDOrdId', 'REDS ID'
					union select 'RDOrdCustId', 'Client ID'
					union select 'RDOrdDANNo', 'DAN Number'
					union select 'RDOrdJobNo', 'Job Number'
					union select 'RDOrdJobLetter', 'Job Letter'
					union select 'RDOrdCustOrd', 'Client Order No'
					union select 'RDOrdArrDate', 'Arrival Date'
					union select 'RDOrdDelDate', 'Delivery Date'
					union select 'RDOrdOrder', 'Order Number'
					union select 'RDOrdCust', 'Client Name'
					union select 'RDOrdInvCreated', 'Invoice Created'
					union select 'RDOrdDesc', 'Description'
					union select 'RDOrdLocked', 'Locked'
					union select 'RDOrdDutyPaid', 'Duty Paid'
					union select 'RDOrdARCNo', 'ARC Number'
					union select 'RDOrdHM10', 'HM10'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "RDOrdId":
					return new REDSOrder_RDOrdIdFieldDef();
							case "RDOrdCustId":
					return new REDSOrder_RDOrdCustIdFieldDef();
							case "RDOrdDANNo":
					return new REDSOrder_RDOrdDANNoFieldDef();
							case "RDOrdJobNo":
					return new REDSOrder_RDOrdJobNoFieldDef();
							case "RDOrdJobLetter":
					return new REDSOrder_RDOrdJobLetterFieldDef();
							case "RDOrdCustOrd":
					return new REDSOrder_RDOrdCustOrdFieldDef();
							case "RDOrdArrDate":
					return new REDSOrder_RDOrdArrDateFieldDef();
							case "RDOrdDelDate":
					return new REDSOrder_RDOrdDelDateFieldDef();
							case "RDOrdOrder":
					return new REDSOrder_RDOrdOrderFieldDef();
							case "RDOrdCust":
					return new REDSOrder_RDOrdCustFieldDef();
							case "RDOrdInvCreated":
					return new REDSOrder_RDOrdInvCreatedFieldDef();
							case "RDOrdDesc":
					return new REDSOrder_RDOrdDescFieldDef();
							case "RDOrdLocked":
					return new REDSOrder_RDOrdLockedFieldDef();
							case "RDOrdDutyPaid":
					return new REDSOrder_RDOrdDutyPaidFieldDef();
							case "RDOrdARCNo":
					return new REDSOrder_RDOrdARCNoFieldDef();
							case "RDOrdHM10":
					return new REDSOrder_RDOrdHM10FieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, RDOrdId as [Description] from REDSOrder 
			where RDOrdId like @q or RDOrdId like @q";
	}
	
}
public class DSTypeREDSOrdLine : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "RDOLAlcPct":
					return "Alcohol Percentage";
							case "RDOLLitres":
					return "Litres";
							case "RDOLDutyDue":
					return "Duty Due";
							case "RDOLLocked":
					return "Locked";
							case "RDOLRDId":
					return "REDS ID";
							case "RDOLLineNo":
					return "Line Number";
							case "RDOLCases":
					return "Cases";
							case "RDOLBottleCase":
					return "Bottles per Case";
							case "RDOLBottleSize":
					return "Bottle Size (cl)";
							case "RDOLTaxCode":
					return "Tax Code";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "RDOLAlcPct":
					return 537;
							case "RDOLLitres":
					return 538;
							case "RDOLDutyDue":
					return 539;
							case "RDOLLocked":
					return 540;
							case "RDOLRDId":
					return 529;
							case "RDOLLineNo":
					return 530;
							case "RDOLCases":
					return 531;
							case "RDOLBottleCase":
					return 532;
							case "RDOLBottleSize":
					return 533;
							case "RDOLTaxCode":
					return 534;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "RDOLAlcPct":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLLitres":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLDutyDue":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLLocked":
				return IQApp.Operators.GetBooleanOperators(selected);							case "RDOLRDId":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLLineNo":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLCases":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLBottleCase":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLBottleSize":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDOLTaxCode":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'RDOLAlcPct', 'Alcohol Percentage'
					union select 'RDOLLitres', 'Litres'
					union select 'RDOLDutyDue', 'Duty Due'
					union select 'RDOLLocked', 'Locked'
					union select 'RDOLRDId', 'REDS ID'
					union select 'RDOLLineNo', 'Line Number'
					union select 'RDOLCases', 'Cases'
					union select 'RDOLBottleCase', 'Bottles per Case'
					union select 'RDOLBottleSize', 'Bottle Size (cl)'
					union select 'RDOLTaxCode', 'Tax Code'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "RDOLAlcPct":
					return new REDSOrdLine_RDOLAlcPctFieldDef();
							case "RDOLLitres":
					return new REDSOrdLine_RDOLLitresFieldDef();
							case "RDOLDutyDue":
					return new REDSOrdLine_RDOLDutyDueFieldDef();
							case "RDOLLocked":
					return new REDSOrdLine_RDOLLockedFieldDef();
							case "RDOLRDId":
					return new REDSOrdLine_RDOLRDIdFieldDef();
							case "RDOLLineNo":
					return new REDSOrdLine_RDOLLineNoFieldDef();
							case "RDOLCases":
					return new REDSOrdLine_RDOLCasesFieldDef();
							case "RDOLBottleCase":
					return new REDSOrdLine_RDOLBottleCaseFieldDef();
							case "RDOLBottleSize":
					return new REDSOrdLine_RDOLBottleSizeFieldDef();
							case "RDOLTaxCode":
					return new REDSOrdLine_RDOLTaxCodeFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, RDOLRDId as [Description] from REDSOrdLine 
			where RDOLRDId like @q or RDOLRDId like @q";
	}
	
}
public class DSTypeREDSTax : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "RDTaxCode":
					return "Tax Code";
							case "RDTaxAlcPct":
					return "Alcohol Percentage";
							case "RDTaxType":
					return "Type";
							case "RDTaxDutyRate":
					return "Duty Rate £ per ltr";
							case "RDTaxId":
					return "Tax Code Id";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "RDTaxCode":
					return 541;
							case "RDTaxAlcPct":
					return 542;
							case "RDTaxType":
					return 543;
							case "RDTaxDutyRate":
					return 544;
							case "RDTaxId":
					return 558;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "RDTaxCode":
				return IQApp.Operators.GetTextOperators(selected);							case "RDTaxAlcPct":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDTaxType":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDTaxDutyRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "RDTaxId":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'RDTaxCode', 'Tax Code'
					union select 'RDTaxAlcPct', 'Alcohol Percentage'
					union select 'RDTaxType', 'Type'
					union select 'RDTaxDutyRate', 'Duty Rate £ per ltr'
					union select 'RDTaxId', 'Tax Code Id'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "RDTaxCode":
					return new REDSTax_RDTaxCodeFieldDef();
							case "RDTaxAlcPct":
					return new REDSTax_RDTaxAlcPctFieldDef();
							case "RDTaxType":
					return new REDSTax_RDTaxTypeFieldDef();
							case "RDTaxDutyRate":
					return new REDSTax_RDTaxDutyRateFieldDef();
							case "RDTaxId":
					return new REDSTax_RDTaxIdFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, RDTaxCode as [Description] from REDSTax 
			where RDTaxId like @q or RDTaxCode like @q";
	}
	
}
public class DSTypeDutyRateHist : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "DRHId":
					return "History Id";
							case "DRHTaxCode":
					return "Tax Code";
							case "DRHChangeDate":
					return "Date of Change";
							case "DRHDutyRate":
					return "Duty Rate";
							case "DRHAlcPct":
					return "Alcohol %age";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "DRHId":
					return 559;
							case "DRHTaxCode":
					return 546;
							case "DRHChangeDate":
					return 547;
							case "DRHDutyRate":
					return 548;
							case "DRHAlcPct":
					return 549;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "DRHId":
				return IQApp.Operators.GetNumberOperators(selected);							case "DRHTaxCode":
				return IQApp.Operators.GetComboOperators(selected);							case "DRHChangeDate":
				return IQApp.Operators.GetTextOperators(selected);							case "DRHDutyRate":
				return IQApp.Operators.GetNumberOperators(selected);							case "DRHAlcPct":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'DRHId', 'History Id'
					union select 'DRHTaxCode', 'Tax Code'
					union select 'DRHChangeDate', 'Date of Change'
					union select 'DRHDutyRate', 'Duty Rate'
					union select 'DRHAlcPct', 'Alcohol %age'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "DRHId":
					return new DutyRateHist_DRHIdFieldDef();
							case "DRHTaxCode":
					return new DutyRateHist_DRHTaxCodeFieldDef();
							case "DRHChangeDate":
					return new DutyRateHist_DRHChangeDateFieldDef();
							case "DRHDutyRate":
					return new DutyRateHist_DRHDutyRateFieldDef();
							case "DRHAlcPct":
					return new DutyRateHist_DRHAlcPctFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, DRHTaxCode as [Description] from DutyRateHist 
			where DRHId like @q or DRHTaxCode like @q";
	}
	
}
public class DSTypeREDSEAD : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "RDEADId":
					return "eAD Number";
							case "RDEADRDId":
					return "REDS ID";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "RDEADId":
					return 556;
							case "RDEADRDId":
					return 557;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "RDEADId":
				return IQApp.Operators.GetTextOperators(selected);							case "RDEADRDId":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'RDEADId', 'eAD Number'
					union select 'RDEADRDId', 'REDS ID'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "RDEADId":
					return new REDSEAD_RDEADIdFieldDef();
							case "RDEADRDId":
					return new REDSEAD_RDEADRDIdFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, RDEADId as [Description] from REDSEAD 
			where RDEADRDId like @q or RDEADId like @q";
	}
	
}
public class DSTypeIStatRec : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "IStId":
					return "Intrastat ID";
							case "IStOrder":
					return "Order Number";
							case "IStCustId":
					return "Client ID";
							case "IStCust":
					return "Client Name";
							case "IStSuppId":
					return "Supplier ID";
							case "IStSupp":
					return "Supplier Name";
							case "IStCustOrd":
					return "Client Order No";
							case "IStJobNo":
					return "Job Number";
							case "IStDate":
					return "Intrastat Date";
							case "IStCommCode":
					return "Commodity Code";
							case "IStInvVal":
					return "Invoice Value";
							case "IStInvCurr":
					return "Invoice Currency";
							case "IStSterlingVal":
					return "Sterling Value";
							case "IStProcessed":
					return "Processed";
							case "IStDelTerms":
					return "Delivery Terms";
							case "IStNAT1":
					return "NAT 1";
							case "IStNAT2":
					return "NAT 2";
							case "IStMass":
					return "Mass";
							case "IStSuppUnitVal":
					return "Supp Unit Value";
							case "IStSuppUnitType":
					return "Supp Unit Type";
							case "IStConsignCtry":
					return "Country (Consign)";
							case "IStTranspMode":
					return "Mode of Transport";
							case "IStInvNo":
					return "Invoice Number";
							case "IStOriginCtry":
					return "Country (Origin)";
							case "IStMonth":
					return "Month";
							case "IStMonthDec":
					return "Month Declared";
							case "IStRatePeriod":
					return "Exch Rate Period";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "IStId":
					return 626;
							case "IStOrder":
					return 627;
							case "IStCustId":
					return 628;
							case "IStCust":
					return 629;
							case "IStSuppId":
					return 630;
							case "IStSupp":
					return 631;
							case "IStCustOrd":
					return 632;
							case "IStJobNo":
					return 633;
							case "IStDate":
					return 634;
							case "IStCommCode":
					return 635;
							case "IStInvVal":
					return 636;
							case "IStInvCurr":
					return 637;
							case "IStSterlingVal":
					return 638;
							case "IStProcessed":
					return 639;
							case "IStDelTerms":
					return 640;
							case "IStNAT1":
					return 641;
							case "IStNAT2":
					return 642;
							case "IStMass":
					return 643;
							case "IStSuppUnitVal":
					return 644;
							case "IStSuppUnitType":
					return 645;
							case "IStConsignCtry":
					return 646;
							case "IStTranspMode":
					return 647;
							case "IStInvNo":
					return 648;
							case "IStOriginCtry":
					return 649;
							case "IStMonth":
					return 650;
							case "IStMonthDec":
					return 651;
							case "IStRatePeriod":
					return 658;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "IStId":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStOrder":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStCustId":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStCust":
				return IQApp.Operators.GetTextOperators(selected);							case "IStSuppId":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStSupp":
				return IQApp.Operators.GetTextOperators(selected);							case "IStCustOrd":
				return IQApp.Operators.GetTextOperators(selected);							case "IStJobNo":
				return IQApp.Operators.GetTextOperators(selected);							case "IStDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStCommCode":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStInvVal":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStInvCurr":
				return IQApp.Operators.GetComboOperators(selected);							case "IStSterlingVal":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStProcessed":
				return IQApp.Operators.GetBooleanOperators(selected);							case "IStDelTerms":
				return IQApp.Operators.GetComboOperators(selected);							case "IStNAT1":
				return IQApp.Operators.GetComboOperators(selected);							case "IStNAT2":
				return IQApp.Operators.GetComboOperators(selected);							case "IStMass":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStSuppUnitVal":
				return IQApp.Operators.GetNumberOperators(selected);							case "IStSuppUnitType":
				return IQApp.Operators.GetTextOperators(selected);							case "IStConsignCtry":
				return IQApp.Operators.GetComboOperators(selected);							case "IStTranspMode":
				return IQApp.Operators.GetComboOperators(selected);							case "IStInvNo":
				return IQApp.Operators.GetTextOperators(selected);							case "IStOriginCtry":
				return IQApp.Operators.GetComboOperators(selected);							case "IStMonth":
				return IQApp.Operators.GetComboOperators(selected);							case "IStMonthDec":
				return IQApp.Operators.GetComboOperators(selected);							case "IStRatePeriod":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'IStId', 'Intrastat ID'
					union select 'IStOrder', 'Order Number'
					union select 'IStCustId', 'Client ID'
					union select 'IStCust', 'Client Name'
					union select 'IStSuppId', 'Supplier ID'
					union select 'IStSupp', 'Supplier Name'
					union select 'IStCustOrd', 'Client Order No'
					union select 'IStJobNo', 'Job Number'
					union select 'IStDate', 'Intrastat Date'
					union select 'IStCommCode', 'Commodity Code'
					union select 'IStInvVal', 'Invoice Value'
					union select 'IStInvCurr', 'Invoice Currency'
					union select 'IStSterlingVal', 'Sterling Value'
					union select 'IStProcessed', 'Processed'
					union select 'IStDelTerms', 'Delivery Terms'
					union select 'IStNAT1', 'NAT 1'
					union select 'IStNAT2', 'NAT 2'
					union select 'IStMass', 'Mass'
					union select 'IStSuppUnitVal', 'Supp Unit Value'
					union select 'IStSuppUnitType', 'Supp Unit Type'
					union select 'IStConsignCtry', 'Country (Consign)'
					union select 'IStTranspMode', 'Mode of Transport'
					union select 'IStInvNo', 'Invoice Number'
					union select 'IStOriginCtry', 'Country (Origin)'
					union select 'IStMonth', 'Month'
					union select 'IStMonthDec', 'Month Declared'
					union select 'IStRatePeriod', 'Exch Rate Period'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "IStId":
					return new IStatRec_IStIdFieldDef();
							case "IStOrder":
					return new IStatRec_IStOrderFieldDef();
							case "IStCustId":
					return new IStatRec_IStCustIdFieldDef();
							case "IStCust":
					return new IStatRec_IStCustFieldDef();
							case "IStSuppId":
					return new IStatRec_IStSuppIdFieldDef();
							case "IStSupp":
					return new IStatRec_IStSuppFieldDef();
							case "IStCustOrd":
					return new IStatRec_IStCustOrdFieldDef();
							case "IStJobNo":
					return new IStatRec_IStJobNoFieldDef();
							case "IStDate":
					return new IStatRec_IStDateFieldDef();
							case "IStCommCode":
					return new IStatRec_IStCommCodeFieldDef();
							case "IStInvVal":
					return new IStatRec_IStInvValFieldDef();
							case "IStInvCurr":
					return new IStatRec_IStInvCurrFieldDef();
							case "IStSterlingVal":
					return new IStatRec_IStSterlingValFieldDef();
							case "IStProcessed":
					return new IStatRec_IStProcessedFieldDef();
							case "IStDelTerms":
					return new IStatRec_IStDelTermsFieldDef();
							case "IStNAT1":
					return new IStatRec_IStNAT1FieldDef();
							case "IStNAT2":
					return new IStatRec_IStNAT2FieldDef();
							case "IStMass":
					return new IStatRec_IStMassFieldDef();
							case "IStSuppUnitVal":
					return new IStatRec_IStSuppUnitValFieldDef();
							case "IStSuppUnitType":
					return new IStatRec_IStSuppUnitTypeFieldDef();
							case "IStConsignCtry":
					return new IStatRec_IStConsignCtryFieldDef();
							case "IStTranspMode":
					return new IStatRec_IStTranspModeFieldDef();
							case "IStInvNo":
					return new IStatRec_IStInvNoFieldDef();
							case "IStOriginCtry":
					return new IStatRec_IStOriginCtryFieldDef();
							case "IStMonth":
					return new IStatRec_IStMonthFieldDef();
							case "IStMonthDec":
					return new IStatRec_IStMonthDecFieldDef();
							case "IStRatePeriod":
					return new IStatRec_IStRatePeriodFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, IStId as [Description] from IStatRec 
			where IStId like @q or IStId like @q";
	}
	
}
public class DSTypeMonths : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "MthId":
					return "Month ID";
							case "MthName":
					return "Month Name";
							case "MthSDate":
					return "From";
							case "MthEDate":
					return "To";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "MthId":
					return 654;
							case "MthName":
					return 655;
							case "MthSDate":
					return 656;
							case "MthEDate":
					return 657;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "MthId":
				return IQApp.Operators.GetNumberOperators(selected);							case "MthName":
				return IQApp.Operators.GetTextOperators(selected);							case "MthSDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "MthEDate":
				return IQApp.Operators.GetNumberOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'MthId', 'Month ID'
					union select 'MthName', 'Month Name'
					union select 'MthSDate', 'From'
					union select 'MthEDate', 'To'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "MthId":
					return new Months_MthIdFieldDef();
							case "MthName":
					return new Months_MthNameFieldDef();
							case "MthSDate":
					return new Months_MthSDateFieldDef();
							case "MthEDate":
					return new Months_MthEDateFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, MthName as [Description] from Months 
			where MthId like @q or MthName like @q";
	}
	
}
public class DSTypeChangeReq : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "CRId":
					return "Id";
							case "CRName":
					return "Title";
							case "CRType":
					return "Type";
							case "CRPriority":
					return "Priority";
							case "CRStatus":
					return "Status";
							case "CRDate":
					return "Date Added";
							case "CRClosed":
					return "Date Closed";
							case "CRIssues":
					return "Description";
							case "CRIqNotes":
					return "Intrinsiq Notes";
							case "CRResolved":
					return "Resolved";
							case "CRIqNotesArch":
					return "Intrinsiq Notes Archive";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "CRId":
					return 659;
							case "CRName":
					return 660;
							case "CRType":
					return 661;
							case "CRPriority":
					return 662;
							case "CRStatus":
					return 663;
							case "CRDate":
					return 664;
							case "CRClosed":
					return 665;
							case "CRIssues":
					return 666;
							case "CRIqNotes":
					return 667;
							case "CRResolved":
					return 668;
							case "CRIqNotesArch":
					return 669;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "CRId":
				return IQApp.Operators.GetNumberOperators(selected);							case "CRName":
				return IQApp.Operators.GetTextOperators(selected);							case "CRType":
				return IQApp.Operators.GetComboOperators(selected);							case "CRPriority":
				return IQApp.Operators.GetComboOperators(selected);							case "CRStatus":
				return IQApp.Operators.GetComboOperators(selected);							case "CRDate":
				return IQApp.Operators.GetTextOperators(selected);							case "CRClosed":
				return IQApp.Operators.GetTextOperators(selected);							case "CRIssues":
				return IQApp.Operators.GetTextOperators(selected);							case "CRIqNotes":
				return IQApp.Operators.GetTextOperators(selected);							case "CRResolved":
				return IQApp.Operators.GetTextOperators(selected);							case "CRIqNotesArch":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'CRId', 'Id'
					union select 'CRName', 'Title'
					union select 'CRType', 'Type'
					union select 'CRPriority', 'Priority'
					union select 'CRStatus', 'Status'
					union select 'CRDate', 'Date Added'
					union select 'CRClosed', 'Date Closed'
					union select 'CRIssues', 'Description'
					union select 'CRIqNotes', 'Intrinsiq Notes'
					union select 'CRResolved', 'Resolved'
					union select 'CRIqNotesArch', 'Intrinsiq Notes Archive'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "CRId":
					return new ChangeReq_CRIdFieldDef();
							case "CRName":
					return new ChangeReq_CRNameFieldDef();
							case "CRType":
					return new ChangeReq_CRTypeFieldDef();
							case "CRPriority":
					return new ChangeReq_CRPriorityFieldDef();
							case "CRStatus":
					return new ChangeReq_CRStatusFieldDef();
							case "CRDate":
					return new ChangeReq_CRDateFieldDef();
							case "CRClosed":
					return new ChangeReq_CRClosedFieldDef();
							case "CRIssues":
					return new ChangeReq_CRIssuesFieldDef();
							case "CRIqNotes":
					return new ChangeReq_CRIqNotesFieldDef();
							case "CRResolved":
					return new ChangeReq_CRResolvedFieldDef();
							case "CRIqNotesArch":
					return new ChangeReq_CRIqNotesArchFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, CRName as [Description] from ChangeReq 
			where CRId like @q or CRName like @q";
	}
	
}
public class DSTypeEMail : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "EMId":
					return "Id";
							case "EMName":
					return "E-mail";
							case "EMFrom":
					return "From";
							case "EMDS":
					return "Dataset";
							case "EMTo":
					return "To";
							case "EMCC":
					return "CC";
							case "EMSubject":
					return "Subject";
							case "EMBody":
					return "Body";
							case "EMAttach":
					return "Attachments";
							case "EMStatus":
					return "Status";
							case "EMDateSent":
					return "Date Sent";
							case "EMToRecords":
					return "To (Records)";
							case "EMDF":
					return "DataField";
							case "EMCCRecords":
					return "CC (Records)";
							case "EMBCC":
					return "BCC";
							case "EMBCCRecords":
					return "BCC (Records)";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "EMId":
					return 684;
							case "EMName":
					return 685;
							case "EMFrom":
					return 686;
							case "EMDS":
					return 687;
							case "EMTo":
					return 689;
							case "EMCC":
					return 690;
							case "EMSubject":
					return 691;
							case "EMBody":
					return 692;
							case "EMAttach":
					return 693;
							case "EMStatus":
					return 694;
							case "EMDateSent":
					return 695;
							case "EMToRecords":
					return 717;
							case "EMDF":
					return 718;
							case "EMCCRecords":
					return 719;
							case "EMBCC":
					return 720;
							case "EMBCCRecords":
					return 721;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "EMId":
				return IQApp.Operators.GetNumberOperators(selected);							case "EMName":
				return IQApp.Operators.GetComboOperators(selected);							case "EMFrom":
				return IQApp.Operators.GetTextOperators(selected);							case "EMDS":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTo":
				return IQApp.Operators.GetTextOperators(selected);							case "EMCC":
				return IQApp.Operators.GetTextOperators(selected);							case "EMSubject":
				return IQApp.Operators.GetTextOperators(selected);							case "EMBody":
				return IQApp.Operators.GetTextOperators(selected);							case "EMAttach":
				return IQApp.Operators.GetTextOperators(selected);							case "EMStatus":
				return IQApp.Operators.GetComboOperators(selected);							case "EMDateSent":
				return IQApp.Operators.GetNumberOperators(selected);							case "EMToRecords":
				return IQApp.Operators.GetComboOperators(selected);							case "EMDF":
				return IQApp.Operators.GetTextOperators(selected);							case "EMCCRecords":
				return IQApp.Operators.GetComboOperators(selected);							case "EMBCC":
				return IQApp.Operators.GetTextOperators(selected);							case "EMBCCRecords":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'EMId', 'Id'
					union select 'EMName', 'E-mail'
					union select 'EMFrom', 'From'
					union select 'EMDS', 'Dataset'
					union select 'EMTo', 'To'
					union select 'EMCC', 'CC'
					union select 'EMSubject', 'Subject'
					union select 'EMBody', 'Body'
					union select 'EMAttach', 'Attachments'
					union select 'EMStatus', 'Status'
					union select 'EMDateSent', 'Date Sent'
					union select 'EMToRecords', 'To (Records)'
					union select 'EMDF', 'DataField'
					union select 'EMCCRecords', 'CC (Records)'
					union select 'EMBCC', 'BCC'
					union select 'EMBCCRecords', 'BCC (Records)'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "EMId":
					return new EMail_EMIdFieldDef();
							case "EMName":
					return new EMail_EMNameFieldDef();
							case "EMFrom":
					return new EMail_EMFromFieldDef();
							case "EMDS":
					return new EMail_EMDSFieldDef();
							case "EMTo":
					return new EMail_EMToFieldDef();
							case "EMCC":
					return new EMail_EMCCFieldDef();
							case "EMSubject":
					return new EMail_EMSubjectFieldDef();
							case "EMBody":
					return new EMail_EMBodyFieldDef();
							case "EMAttach":
					return new EMail_EMAttachFieldDef();
							case "EMStatus":
					return new EMail_EMStatusFieldDef();
							case "EMDateSent":
					return new EMail_EMDateSentFieldDef();
							case "EMToRecords":
					return new EMail_EMToRecordsFieldDef();
							case "EMDF":
					return new EMail_EMDFFieldDef();
							case "EMCCRecords":
					return new EMail_EMCCRecordsFieldDef();
							case "EMBCC":
					return new EMail_EMBCCFieldDef();
							case "EMBCCRecords":
					return new EMail_EMBCCRecordsFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, EMSubject as [Description] from EMail 
			where EMId like @q or EMSubject like @q";
	}
	
}
public class DSTypeWordDocument : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "WrDocQuery":
					return "Query";
							case "WrDocCategory":
					return "Category";
							case "WrDocQueryType":
					return "Query Type";
							case "WrDocBuiltInQuery":
					return "Query";
							case "WrDocUseSimple":
					return "Simple Merge Fields";
							case "WrDocId":
					return "Id";
							case "WrDocTemplate":
					return "Template";
							case "WrDocTitle":
					return "Title";
							case "WrDocDataset":
					return "Applies To";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "WrDocQuery":
					return 722;
							case "WrDocCategory":
					return 746;
							case "WrDocQueryType":
					return 747;
							case "WrDocBuiltInQuery":
					return 748;
							case "WrDocUseSimple":
					return 785;
							case "WrDocId":
					return 699;
							case "WrDocTemplate":
					return 700;
							case "WrDocTitle":
					return 701;
							case "WrDocDataset":
					return 702;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "WrDocQuery":
				return IQApp.Operators.GetComboOperators(selected);							case "WrDocCategory":
				return IQApp.Operators.GetTextOperators(selected);							case "WrDocQueryType":
				return IQApp.Operators.GetComboOperators(selected);							case "WrDocBuiltInQuery":
				return IQApp.Operators.GetTextOperators(selected);							case "WrDocUseSimple":
				return IQApp.Operators.GetBooleanOperators(selected);							case "WrDocId":
				return IQApp.Operators.GetNumberOperators(selected);							case "WrDocTemplate":
				return IQApp.Operators.GetTextOperators(selected);							case "WrDocTitle":
				return IQApp.Operators.GetTextOperators(selected);							case "WrDocDataset":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'WrDocQuery', 'Query'
					union select 'WrDocCategory', 'Category'
					union select 'WrDocQueryType', 'Query Type'
					union select 'WrDocBuiltInQuery', 'Query'
					union select 'WrDocUseSimple', 'Simple Merge Fields'
					union select 'WrDocId', 'Id'
					union select 'WrDocTemplate', 'Template'
					union select 'WrDocTitle', 'Title'
					union select 'WrDocDataset', 'Applies To'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "WrDocQuery":
					return new WordDocument_WrDocQueryFieldDef();
							case "WrDocCategory":
					return new WordDocument_WrDocCategoryFieldDef();
							case "WrDocQueryType":
					return new WordDocument_WrDocQueryTypeFieldDef();
							case "WrDocBuiltInQuery":
					return new WordDocument_WrDocBuiltInQueryFieldDef();
							case "WrDocUseSimple":
					return new WordDocument_WrDocUseSimpleFieldDef();
							case "WrDocId":
					return new WordDocument_WrDocIdFieldDef();
							case "WrDocTemplate":
					return new WordDocument_WrDocTemplateFieldDef();
							case "WrDocTitle":
					return new WordDocument_WrDocTitleFieldDef();
							case "WrDocDataset":
					return new WordDocument_WrDocDatasetFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, WrDocTitle as [Description] from WordDocument 
			where WrDocId like @q or WrDocTitle like @q";
	}
	
}
public class DSTypeQuery : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "QryId":
					return "Id";
							case "QryName":
					return "Name";
							case "QrySysName":
					return "System Name";
							case "QryContent":
					return "Content";
							case "QryPrimaryDS":
					return "Primary Data Source";
							case "QryCategory":
					return "Category";
							case "QryRelationships":
					return "Relationships";
							case "QryScreen":
					return "Screen";
							case "QryType":
					return "Type";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "QryId":
					return 703;
							case "QryName":
					return 704;
							case "QrySysName":
					return 705;
							case "QryContent":
					return 706;
							case "QryPrimaryDS":
					return 707;
							case "QryCategory":
					return 791;
							case "QryRelationships":
					return 792;
							case "QryScreen":
					return 723;
							case "QryType":
					return 784;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "QryId":
				return IQApp.Operators.GetNumberOperators(selected);							case "QryName":
				return IQApp.Operators.GetTextOperators(selected);							case "QrySysName":
				return IQApp.Operators.GetTextOperators(selected);							case "QryContent":
				return IQApp.Operators.GetTextOperators(selected);							case "QryPrimaryDS":
				return IQApp.Operators.GetComboOperators(selected);							case "QryCategory":
				return IQApp.Operators.GetTextOperators(selected);							case "QryRelationships":
				return IQApp.Operators.GetTextOperators(selected);							case "QryScreen":
				return IQApp.Operators.GetComboOperators(selected);							case "QryType":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'QryId', 'Id'
					union select 'QryName', 'Name'
					union select 'QrySysName', 'System Name'
					union select 'QryContent', 'Content'
					union select 'QryPrimaryDS', 'Primary Data Source'
					union select 'QryCategory', 'Category'
					union select 'QryRelationships', 'Relationships'
					union select 'QryScreen', 'Screen'
					union select 'QryType', 'Type'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "QryId":
					return new Query_QryIdFieldDef();
							case "QryName":
					return new Query_QryNameFieldDef();
							case "QrySysName":
					return new Query_QrySysNameFieldDef();
							case "QryContent":
					return new Query_QryContentFieldDef();
							case "QryPrimaryDS":
					return new Query_QryPrimaryDSFieldDef();
							case "QryCategory":
					return new Query_QryCategoryFieldDef();
							case "QryRelationships":
					return new Query_QryRelationshipsFieldDef();
							case "QryScreen":
					return new Query_QryScreenFieldDef();
							case "QryType":
					return new Query_QryTypeFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, QryName as [Description] from Query 
			where QryId like @q or QryName like @q";
	}
	
}
public class DSTypeEmailTemplatess : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "EMTId":
					return "Id";
							case "EMTName":
					return "Name";
							case "EMTBody":
					return "Body";
							case "EMTSubject":
					return "Subject";
							case "EMTFromAddr":
					return "From Address";
							case "EMTToAddr":
					return "To Address";
							case "EMTCCAddr":
					return "CC Address";
							case "EMTBCCAddr":
					return "BCC Address";
							case "EMTQuery":
					return "Query";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "EMTId":
					return 724;
							case "EMTName":
					return 725;
							case "EMTBody":
					return 726;
							case "EMTSubject":
					return 727;
							case "EMTFromAddr":
					return 728;
							case "EMTToAddr":
					return 729;
							case "EMTCCAddr":
					return 730;
							case "EMTBCCAddr":
					return 731;
							case "EMTQuery":
					return 737;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "EMTId":
				return IQApp.Operators.GetNumberOperators(selected);							case "EMTName":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTBody":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTSubject":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTFromAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTToAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTCCAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTBCCAddr":
				return IQApp.Operators.GetTextOperators(selected);							case "EMTQuery":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'EMTId', 'Id'
					union select 'EMTName', 'Name'
					union select 'EMTBody', 'Body'
					union select 'EMTSubject', 'Subject'
					union select 'EMTFromAddr', 'From Address'
					union select 'EMTToAddr', 'To Address'
					union select 'EMTCCAddr', 'CC Address'
					union select 'EMTBCCAddr', 'BCC Address'
					union select 'EMTQuery', 'Query'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "EMTId":
					return new EmailTemplatess_EMTIdFieldDef();
							case "EMTName":
					return new EmailTemplatess_EMTNameFieldDef();
							case "EMTBody":
					return new EmailTemplatess_EMTBodyFieldDef();
							case "EMTSubject":
					return new EmailTemplatess_EMTSubjectFieldDef();
							case "EMTFromAddr":
					return new EmailTemplatess_EMTFromAddrFieldDef();
							case "EMTToAddr":
					return new EmailTemplatess_EMTToAddrFieldDef();
							case "EMTCCAddr":
					return new EmailTemplatess_EMTCCAddrFieldDef();
							case "EMTBCCAddr":
					return new EmailTemplatess_EMTBCCAddrFieldDef();
							case "EMTQuery":
					return new EmailTemplatess_EMTQueryFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, EMTName as [Description] from EmailTemplatess 
			where EMTId like @q or EMTName like @q";
	}
	
}
public class DSTypeStaff : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "StfId":
					return "Id";
							case "StfFN":
					return "Forename";
							case "StfSN":
					return "Surname";
							case "StfName":
					return "Name";
							case "StfUsername":
					return "Username";
							case "StfPassword":
					return "Password";
							case "StfEM":
					return "Email";
							case "StfSG":
					return "Security Groups";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "StfId":
					return 738;
							case "StfFN":
					return 739;
							case "StfSN":
					return 740;
							case "StfName":
					return 741;
							case "StfUsername":
					return 742;
							case "StfPassword":
					return 743;
							case "StfEM":
					return 744;
							case "StfSG":
					return 745;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "StfId":
				return IQApp.Operators.GetNumberOperators(selected);							case "StfFN":
				return IQApp.Operators.GetTextOperators(selected);							case "StfSN":
				return IQApp.Operators.GetTextOperators(selected);							case "StfName":
				return IQApp.Operators.GetTextOperators(selected);							case "StfUsername":
				return IQApp.Operators.GetTextOperators(selected);							case "StfPassword":
				return IQApp.Operators.GetTextOperators(selected);							case "StfEM":
				return IQApp.Operators.GetTextOperators(selected);							case "StfSG":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'StfId', 'Id'
					union select 'StfFN', 'Forename'
					union select 'StfSN', 'Surname'
					union select 'StfName', 'Name'
					union select 'StfUsername', 'Username'
					union select 'StfPassword', 'Password'
					union select 'StfEM', 'Email'
					union select 'StfSG', 'Security Groups'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "StfId":
					return new Staff_StfIdFieldDef();
							case "StfFN":
					return new Staff_StfFNFieldDef();
							case "StfSN":
					return new Staff_StfSNFieldDef();
							case "StfName":
					return new Staff_StfNameFieldDef();
							case "StfUsername":
					return new Staff_StfUsernameFieldDef();
							case "StfPassword":
					return new Staff_StfPasswordFieldDef();
							case "StfEM":
					return new Staff_StfEMFieldDef();
							case "StfSG":
					return new Staff_StfSGFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, StfName as [Description] from Staff 
			where StfId like @q or StfName like @q";
	}
	
}
public class DSTypeSMS : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "SMSId":
					return "Id";
							case "SMSContent":
					return "Content";
							case "SMSDestination":
					return "Destination";
							case "SMSDataset":
					return "Dataset";
							case "SMSRecordID":
					return "RecordID";
							case "SMSDateQueued":
					return "Queued";
							case "SMSDateConfirmed":
					return "Delivered";
							case "SMSStatus":
					return "Status";
							case "SMSStatusMsg":
					return "Status Message";
							case "SMSSender":
					return "Sender";
							case "SMSTemplate":
					return "Template";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "SMSId":
					return 749;
							case "SMSContent":
					return 750;
							case "SMSDestination":
					return 751;
							case "SMSDataset":
					return 752;
							case "SMSRecordID":
					return 753;
							case "SMSDateQueued":
					return 754;
							case "SMSDateConfirmed":
					return 755;
							case "SMSStatus":
					return 756;
							case "SMSStatusMsg":
					return 757;
							case "SMSSender":
					return 764;
							case "SMSTemplate":
					return 765;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "SMSId":
				return IQApp.Operators.GetNumberOperators(selected);							case "SMSContent":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSDestination":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSDataset":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSRecordID":
				return IQApp.Operators.GetNumberOperators(selected);							case "SMSDateQueued":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSDateConfirmed":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSStatus":
				return IQApp.Operators.GetComboOperators(selected);							case "SMSStatusMsg":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSSender":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSTemplate":
				return IQApp.Operators.GetComboOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'SMSId', 'Id'
					union select 'SMSContent', 'Content'
					union select 'SMSDestination', 'Destination'
					union select 'SMSDataset', 'Dataset'
					union select 'SMSRecordID', 'RecordID'
					union select 'SMSDateQueued', 'Queued'
					union select 'SMSDateConfirmed', 'Delivered'
					union select 'SMSStatus', 'Status'
					union select 'SMSStatusMsg', 'Status Message'
					union select 'SMSSender', 'Sender'
					union select 'SMSTemplate', 'Template'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "SMSId":
					return new SMS_SMSIdFieldDef();
							case "SMSContent":
					return new SMS_SMSContentFieldDef();
							case "SMSDestination":
					return new SMS_SMSDestinationFieldDef();
							case "SMSDataset":
					return new SMS_SMSDatasetFieldDef();
							case "SMSRecordID":
					return new SMS_SMSRecordIDFieldDef();
							case "SMSDateQueued":
					return new SMS_SMSDateQueuedFieldDef();
							case "SMSDateConfirmed":
					return new SMS_SMSDateConfirmedFieldDef();
							case "SMSStatus":
					return new SMS_SMSStatusFieldDef();
							case "SMSStatusMsg":
					return new SMS_SMSStatusMsgFieldDef();
							case "SMSSender":
					return new SMS_SMSSenderFieldDef();
							case "SMSTemplate":
					return new SMS_SMSTemplateFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, SMSDestination as [Description] from SMS 
			where SMSId like @q or SMSDestination like @q";
	}
	
}
public class DSTypeSMSTemplate : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "SMSTQuery":
					return "Query";
							case "SMSTId":
					return "Id";
							case "SMSTContent":
					return "Content";
							case "SMSTDestination":
					return "Destination";
							case "SMSTName":
					return "Name";
							case "SMSTDataset":
					return "Applies To";
							case "SMSTSender":
					return "Sender";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "SMSTQuery":
					return 790;
							case "SMSTId":
					return 758;
							case "SMSTContent":
					return 759;
							case "SMSTDestination":
					return 760;
							case "SMSTName":
					return 761;
							case "SMSTDataset":
					return 762;
							case "SMSTSender":
					return 763;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "SMSTQuery":
				return IQApp.Operators.GetComboOperators(selected);							case "SMSTId":
				return IQApp.Operators.GetNumberOperators(selected);							case "SMSTContent":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSTDestination":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSTName":
				return IQApp.Operators.GetTextOperators(selected);							case "SMSTDataset":
				return IQApp.Operators.GetComboOperators(selected);							case "SMSTSender":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'SMSTQuery', 'Query'
					union select 'SMSTId', 'Id'
					union select 'SMSTContent', 'Content'
					union select 'SMSTDestination', 'Destination'
					union select 'SMSTName', 'Name'
					union select 'SMSTDataset', 'Applies To'
					union select 'SMSTSender', 'Sender'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "SMSTQuery":
					return new SMSTemplate_SMSTQueryFieldDef();
							case "SMSTId":
					return new SMSTemplate_SMSTIdFieldDef();
							case "SMSTContent":
					return new SMSTemplate_SMSTContentFieldDef();
							case "SMSTDestination":
					return new SMSTemplate_SMSTDestinationFieldDef();
							case "SMSTName":
					return new SMSTemplate_SMSTNameFieldDef();
							case "SMSTDataset":
					return new SMSTemplate_SMSTDatasetFieldDef();
							case "SMSTSender":
					return new SMSTemplate_SMSTSenderFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, SMSTName as [Description] from SMSTemplate 
			where SMSTId like @q or SMSTName like @q";
	}
	
}
public class DSTypeAlerts : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "AlrtId":
					return "Id";
							case "AlrtUserID":
					return "User";
							case "AlrtData":
					return "Data";
							case "AlrtTitle":
					return "Title";
							case "AlrtQueueDate":
					return "Alert Date";
							case "AlrtCompletedDat":
					return "CompletedDate";
							case "AlrtCallbackUrl":
					return "Callback URL";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "AlrtId":
					return 777;
							case "AlrtUserID":
					return 778;
							case "AlrtData":
					return 779;
							case "AlrtTitle":
					return 780;
							case "AlrtQueueDate":
					return 781;
							case "AlrtCompletedDat":
					return 782;
							case "AlrtCallbackUrl":
					return 783;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "AlrtId":
				return IQApp.Operators.GetNumberOperators(selected);							case "AlrtUserID":
				return IQApp.Operators.GetComboOperators(selected);							case "AlrtData":
				return IQApp.Operators.GetTextOperators(selected);							case "AlrtTitle":
				return IQApp.Operators.GetTextOperators(selected);							case "AlrtQueueDate":
				return IQApp.Operators.GetNumberOperators(selected);							case "AlrtCompletedDat":
				return IQApp.Operators.GetNumberOperators(selected);							case "AlrtCallbackUrl":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'AlrtId', 'Id'
					union select 'AlrtUserID', 'User'
					union select 'AlrtData', 'Data'
					union select 'AlrtTitle', 'Title'
					union select 'AlrtQueueDate', 'Alert Date'
					union select 'AlrtCompletedDat', 'CompletedDate'
					union select 'AlrtCallbackUrl', 'Callback URL'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "AlrtId":
					return new Alerts_AlrtIdFieldDef();
							case "AlrtUserID":
					return new Alerts_AlrtUserIDFieldDef();
							case "AlrtData":
					return new Alerts_AlrtDataFieldDef();
							case "AlrtTitle":
					return new Alerts_AlrtTitleFieldDef();
							case "AlrtQueueDate":
					return new Alerts_AlrtQueueDateFieldDef();
							case "AlrtCompletedDat":
					return new Alerts_AlrtCompletedDatFieldDef();
							case "AlrtCallbackUrl":
					return new Alerts_AlrtCallbackUrlFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, AlrtTitle as [Description] from Alerts 
			where AlrtId like @q or AlrtTitle like @q";
	}
	
}
public class DSTypeReporting : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "RptId":
					return "Id";
							case "RptTitle":
					return "New Field";
							case "RptContent":
					return "New Field";
							case "RptDataset":
					return "New Field";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "RptId":
					return 814;
							case "RptTitle":
					return 815;
							case "RptContent":
					return 816;
							case "RptDataset":
					return 817;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "RptId":
				return IQApp.Operators.GetNumberOperators(selected);							case "RptTitle":
				return IQApp.Operators.GetTextOperators(selected);							case "RptContent":
				return IQApp.Operators.GetTextOperators(selected);							case "RptDataset":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'RptId', 'Id'
					union select 'RptTitle', 'New Field'
					union select 'RptContent', 'New Field'
					union select 'RptDataset', 'New Field'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "RptId":
					return new Reporting_RptIdFieldDef();
							case "RptTitle":
					return new Reporting_RptTitleFieldDef();
							case "RptContent":
					return new Reporting_RptContentFieldDef();
							case "RptDataset":
					return new Reporting_RptDatasetFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, RptTitle as [Description] from Reporting 
			where RptId like @q or RptTitle like @q";
	}
	
}
public class DSTypeDelZone : IDSTypeMapper {
	
	public string GetFieldTitle(string DF) {
		switch(DF) {
							case "DelZId":
					return "Id";
							case "DelZName":
					return "Name";
					}
		return "";
	}
	public int GetFieldID(string DF) {
		switch(DF) {
							case "DelZId":
					return 818;
							case "DelZName":
					return 819;
					}
		return -1;
	}
	public string GetFieldOperators(string DF, int selected) {
		switch(DF) {
							case "DelZId":
				return IQApp.Operators.GetNumberOperators(selected);							case "DelZName":
				return IQApp.Operators.GetTextOperators(selected);					}
		return "";
	}
	public List<Pair<string, string>> DataFieldsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DataFieldsAsQuery());
    }
	public string DataFieldsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'DelZId', 'Id'
					union select 'DelZName', 'Name'
				";
	}

	public IFieldDefinition GetDFDefinition(string DF) {
		switch(DF) {
							case "DelZId":
					return new DelZone_DelZIdFieldDef();
							case "DelZName":
					return new DelZone_DelZNameFieldDef();
					}
		return null;
	}

	public string RecordsQuery() {
		return @"select RecordID as KeyValue, DelZName as [Description] from DelZone 
			where DelZId like @q or DelZName like @q";
	}
	
}
public class DSMapper : IDSMapper {
	
	public IDSTypeMapper GetDS(string DSName) {
		switch(DSName) {
					case "Contact":										
				return new DSTypeContact();
					case "Orders":										
				return new DSTypeOrders();
					case "OrderLine":										
				return new DSTypeOrderLine();
					case "Job":										
				return new DSTypeJob();
					case "JobLine":										
				return new DSTypeJobLine();
					case "Inv":										
				return new DSTypeInv();
					case "InvLine":										
				return new DSTypeInvLine();
					case "CN":										
				return new DSTypeCN();
					case "UKOrder":										
				return new DSTypeUKOrder();
					case "FerryRoute":										
				return new DSTypeFerryRoute();
					case "InvComment":										
				return new DSTypeInvComment();
					case "VATCodes":										
				return new DSTypeVATCodes();
					case "JobCost":										
				return new DSTypeJobCost();
					case "CertShip":										
				return new DSTypeCertShip();
					case "CNLine":										
				return new DSTypeCNLine();
					case "Driver":										
				return new DSTypeDriver();
					case "ExchRate":										
				return new DSTypeExchRate();
					case "Trailer":										
				return new DSTypeTrailer();
					case "PeriodInv":										
				return new DSTypePeriodInv();
					case "Week":										
				return new DSTypeWeek();
					case "DriverHrs":										
				return new DSTypeDriverHrs();
					case "InvBatch":										
				return new DSTypeInvBatch();
					case "PackageType":										
				return new DSTypePackageType();
					case "BottleSize":										
				return new DSTypeBottleSize();
					case "PalletType":										
				return new DSTypePalletType();
					case "EADNum":										
				return new DSTypeEADNum();
					case "ShipDoc":										
				return new DSTypeShipDoc();
					case "Truck":										
				return new DSTypeTruck();
					case "TruckMileage":										
				return new DSTypeTruckMileage();
					case "Customer":										
				return new DSTypeCustomer();
					case "Country":										
				return new DSTypeCountry();
					case "REDSOrder":										
				return new DSTypeREDSOrder();
					case "REDSOrdLine":										
				return new DSTypeREDSOrdLine();
					case "REDSTax":										
				return new DSTypeREDSTax();
					case "DutyRateHist":										
				return new DSTypeDutyRateHist();
					case "REDSEAD":										
				return new DSTypeREDSEAD();
					case "IStatRec":										
				return new DSTypeIStatRec();
					case "Months":										
				return new DSTypeMonths();
					case "ChangeReq":										
				return new DSTypeChangeReq();
					case "EMail":										
				return new DSTypeEMail();
					case "WordDocument":										
				return new DSTypeWordDocument();
					case "Query":										
				return new DSTypeQuery();
					case "EmailTemplatess":										
				return new DSTypeEmailTemplatess();
					case "Staff":										
				return new DSTypeStaff();
					case "SMS":										
				return new DSTypeSMS();
					case "SMSTemplate":										
				return new DSTypeSMSTemplate();
					case "Alerts":										
				return new DSTypeAlerts();
					case "Reporting":										
				return new DSTypeReporting();
					case "DelZone":										
				return new DSTypeDelZone();
				}
		return null;
	}
	public string GetDSName(int id) {
		switch(id) {
				case 1:
			return "Contact";

				case 2:
			return "Orders";

				case 3:
			return "OrderLine";

				case 4:
			return "Job";

				case 5:
			return "JobLine";

				case 6:
			return "Inv";

				case 7:
			return "InvLine";

				case 8:
			return "CN";

				case 9:
			return "UKOrder";

				case 10:
			return "FerryRoute";

				case 11:
			return "InvComment";

				case 12:
			return "VATCodes";

				case 14:
			return "JobCost";

				case 15:
			return "CertShip";

				case 16:
			return "CNLine";

				case 17:
			return "Driver";

				case 18:
			return "ExchRate";

				case 19:
			return "Trailer";

				case 20:
			return "PeriodInv";

				case 21:
			return "Week";

				case 22:
			return "DriverHrs";

				case 23:
			return "InvBatch";

				case 26:
			return "PackageType";

				case 27:
			return "BottleSize";

				case 28:
			return "PalletType";

				case 29:
			return "EADNum";

				case 30:
			return "ShipDoc";

				case 31:
			return "Truck";

				case 32:
			return "TruckMileage";

				case 33:
			return "Customer";

				case 34:
			return "Country";

				case 35:
			return "REDSOrder";

				case 36:
			return "REDSOrdLine";

				case 37:
			return "REDSTax";

				case 38:
			return "DutyRateHist";

				case 39:
			return "REDSEAD";

				case 40:
			return "IStatRec";

				case 42:
			return "Months";

				case 43:
			return "ChangeReq";

				case 45:
			return "EMail";

				case 46:
			return "WordDocument";

				case 47:
			return "Query";

				case 50:
			return "EmailTemplatess";

				case 51:
			return "Staff";

				case 52:
			return "SMS";

				case 53:
			return "SMSTemplate";

				case 54:
			return "Alerts";

				case 56:
			return "Reporting";

				case 57:
			return "DelZone";

				}
		return "";
	}
	public string GetKeyColumnName(string DS) {
		switch(DS) {
							case "Contact":
					return "ContId";
							case "Orders":
					return "OrdId";
							case "OrderLine":
					return "OrdLOrder";
							case "Job":
					return "JobId";
							case "JobLine":
					return "JobLJobNo";
							case "Inv":
					return "InvId";
							case "InvLine":
					return "InvLInvNo";
							case "CN":
					return "CNId";
							case "UKOrder":
					return "UKOId";
							case "FerryRoute":
					return "FRId";
							case "InvComment":
					return "InvCId";
							case "VATCodes":
					return "VATId";
							case "JobCost":
					return "JobCJobNo";
							case "CertShip":
					return "CSId";
							case "CNLine":
					return "CNLNo";
							case "Driver":
					return "DrvId";
							case "ExchRate":
					return "ExRId";
							case "Trailer":
					return "TrlId";
							case "PeriodInv":
					return "PInvId";
							case "Week":
					return "WkId";
							case "DriverHrs":
					return "DrvHDriver";
							case "InvBatch":
					return "InvBId";
							case "PackageType":
					return "PackId";
							case "BottleSize":
					return "BSzId";
							case "PalletType":
					return "PallId";
							case "EADNum":
					return "EADOrder";
							case "ShipDoc":
					return "SDId";
							case "Truck":
					return "TrkId";
							case "TruckMileage":
					return "TrkMTruck";
							case "Customer":
					return "CustId";
							case "Country":
					return "CtryId";
							case "REDSOrder":
					return "RDOrdId";
							case "REDSOrdLine":
					return "RDOLRDId";
							case "REDSTax":
					return "RDTaxId";
							case "DutyRateHist":
					return "DRHId";
							case "REDSEAD":
					return "RDEADRDId";
							case "IStatRec":
					return "IStId";
							case "Months":
					return "MthId";
							case "ChangeReq":
					return "CRId";
							case "EMail":
					return "EMId";
							case "WordDocument":
					return "WrDocId";
							case "Query":
					return "QryId";
							case "EmailTemplatess":
					return "EMTId";
							case "Staff":
					return "StfId";
							case "SMS":
					return "SMSId";
							case "SMSTemplate":
					return "SMSTId";
							case "Alerts":
					return "AlrtId";
							case "Reporting":
					return "RptId";
							case "DelZone":
					return "DelZId";
					}
		return "";
	}
	
	public string GetTitleColumnName(string DS) {
		switch(DS) {
							case "Contact":
					return "ContName";
							case "Orders":
					return "OrdId";
							case "OrderLine":
					return "OrdLOrder";
							case "Job":
					return "JobNo";
							case "JobLine":
					return "JobLJobNo";
							case "Inv":
					return "InvId";
							case "InvLine":
					return "InvLInvNo";
							case "CN":
					return "CNId";
							case "UKOrder":
					return "UKOId";
							case "FerryRoute":
					return "FRName";
							case "InvComment":
					return "InvCId";
							case "VATCodes":
					return "VATCode";
							case "JobCost":
					return "JobCJobNo";
							case "CertShip":
					return "CSId";
							case "CNLine":
					return "CNLNo";
							case "Driver":
					return "DrvName";
							case "ExchRate":
					return "ExRName";
							case "Trailer":
					return "TrlFleetNo";
							case "PeriodInv":
					return "PInvId";
							case "Week":
					return "WkId";
							case "DriverHrs":
					return "DrvHDriver";
							case "InvBatch":
					return "InvBId";
							case "PackageType":
					return "PackName";
							case "BottleSize":
					return "BSzSize";
							case "PalletType":
					return "PallName";
							case "EADNum":
					return "EADNo";
							case "ShipDoc":
					return "SDId";
							case "Truck":
					return "TrkName";
							case "TruckMileage":
					return "TrkMTruck";
							case "Customer":
					return "CustName";
							case "Country":
					return "CtryName";
							case "REDSOrder":
					return "RDOrdId";
							case "REDSOrdLine":
					return "RDOLRDId";
							case "REDSTax":
					return "RDTaxCode";
							case "DutyRateHist":
					return "DRHTaxCode";
							case "REDSEAD":
					return "RDEADId";
							case "IStatRec":
					return "IStId";
							case "Months":
					return "MthName";
							case "ChangeReq":
					return "CRName";
							case "EMail":
					return "EMSubject";
							case "WordDocument":
					return "WrDocTitle";
							case "Query":
					return "QryName";
							case "EmailTemplatess":
					return "EMTName";
							case "Staff":
					return "StfName";
							case "SMS":
					return "SMSDestination";
							case "SMSTemplate":
					return "SMSTName";
							case "Alerts":
					return "AlrtTitle";
							case "Reporting":
					return "RptTitle";
							case "DelZone":
					return "DelZName";
					}
		return "";
	}

	public string GetDefaultOrderBy(string DS) {
		switch(DS) {
							case "Contact":
					return " Order by DF31";
							case "Orders":
					return " Order by DF39";
							case "OrderLine":
					return " Order by DF68";
							case "Job":
					return " Order by DF76";
							case "JobLine":
					return " Order by DF89";
							case "Inv":
					return " Order by DF94";
							case "InvLine":
					return " Order by DF118";
							case "CN":
					return " Order by DF201";
							case "UKOrder":
					return " Order by DF129";
							case "FerryRoute":
					return " Order by DF87";
							case "InvComment":
					return " Order by DF115";
							case "VATCodes":
					return " Order by DF125, DF126, DF127";
							case "JobCost":
					return " Order by DF168";
							case "CertShip":
					return " Order by DF178";
							case "CNLine":
					return " Order by DF224";
							case "Driver":
					return " Order by DF233";
							case "ExchRate":
					return " Order by DF254 DESC";
							case "Trailer":
					return " Order by DF259";
							case "PeriodInv":
					return " Order by DF271";
							case "Week":
					return " Order by DF279";
							case "DriverHrs":
					return " Order by DF277 DESC";
							case "InvBatch":
					return " Order by DF292";
							case "PackageType":
					return " Order by DF319";
							case "BottleSize":
					return " Order by DF324";
							case "PalletType":
					return " Order by DF323";
							case "EADNum":
					return " Order by DF342";
							case "ShipDoc":
					return " Order by DF347";
							case "Truck":
					return " Order by DF398";
							case "TruckMileage":
					return " Order by DF400, DF401";
							case "Customer":
					return " Order by DF410";
							case "Country":
					return " Order by DF423";
							case "REDSOrder":
					return " Order by DF521";
							case "REDSOrdLine":
					return " Order by DF530";
							case "REDSTax":
					return " Order by DF541";
							case "DutyRateHist":
					return " Order by DF547, DF546";
							case "REDSEAD":
					return " Order by DF556";
							case "IStatRec":
					return " Order by DF626";
							case "Months":
					return " Order by DF656";
							case "ChangeReq":
					return " Order by DF660";
							case "EMail":
					return " Order by DF695";
							case "WordDocument":
					return "";
							case "Query":
					return "";
							case "EmailTemplatess":
					return "";
							case "Staff":
					return "";
							case "SMS":
					return "";
							case "SMSTemplate":
					return "";
							case "Alerts":
					return "";
							case "Reporting":
					return "";
							case "DelZone":
					return "";
					}
		return "";
	}
	public string GetFilterSQL(string DS, bool AppendWithWHERE = false) {
		switch(DS) {
							case "Contact":
					return AppendWithWHERE ? "" : "";
							case "Orders":
					return AppendWithWHERE ? "" : "";
							case "OrderLine":
					return AppendWithWHERE ? "" : "";
							case "Job":
					return AppendWithWHERE ? "" : "";
							case "JobLine":
					return AppendWithWHERE ? "" : "";
							case "Inv":
					return AppendWithWHERE ? "" : "";
							case "InvLine":
					return AppendWithWHERE ? "" : "";
							case "CN":
					return AppendWithWHERE ? "" : "";
							case "UKOrder":
					return AppendWithWHERE ? "" : "";
							case "FerryRoute":
					return AppendWithWHERE ? "" : "";
							case "InvComment":
					return AppendWithWHERE ? "" : "";
							case "VATCodes":
					return AppendWithWHERE ? "" : "";
							case "JobCost":
					return AppendWithWHERE ? "" : "";
							case "CertShip":
					return AppendWithWHERE ? "" : "";
							case "CNLine":
					return AppendWithWHERE ? "" : "";
							case "Driver":
					return AppendWithWHERE ? "" : "";
							case "ExchRate":
					return AppendWithWHERE ? "" : "";
							case "Trailer":
					return AppendWithWHERE ? "" : "";
							case "PeriodInv":
					return AppendWithWHERE ? "" : "";
							case "Week":
					return AppendWithWHERE ? "" : "";
							case "DriverHrs":
					return AppendWithWHERE ? "" : "";
							case "InvBatch":
					return AppendWithWHERE ? "" : "";
							case "PackageType":
					return AppendWithWHERE ? "" : "";
							case "BottleSize":
					return AppendWithWHERE ? "" : "";
							case "PalletType":
					return AppendWithWHERE ? "" : "";
							case "EADNum":
					return AppendWithWHERE ? "" : "";
							case "ShipDoc":
					return AppendWithWHERE ? "" : "";
							case "Truck":
					return AppendWithWHERE ? "" : "";
							case "TruckMileage":
					return AppendWithWHERE ? "" : "";
							case "Customer":
					return AppendWithWHERE ? "" : "";
							case "Country":
					return AppendWithWHERE ? "" : "";
							case "REDSOrder":
					return AppendWithWHERE ? "" : "";
							case "REDSOrdLine":
					return AppendWithWHERE ? "" : "";
							case "REDSTax":
					return AppendWithWHERE ? "" : "";
							case "DutyRateHist":
					return AppendWithWHERE ? "" : "";
							case "REDSEAD":
					return AppendWithWHERE ? "" : "";
							case "IStatRec":
					return AppendWithWHERE ? "" : "";
							case "Months":
					return AppendWithWHERE ? "" : "";
							case "ChangeReq":
					return AppendWithWHERE ? "" : "";
							case "EMail":
					return AppendWithWHERE ? "" : "";
							case "WordDocument":
					return AppendWithWHERE ? "" : "";
							case "Query":
					return AppendWithWHERE ? "" : "";
							case "EmailTemplatess":
					return AppendWithWHERE ? "" : "";
							case "Staff":
					return AppendWithWHERE ? "" : "";
							case "SMS":
					return AppendWithWHERE ? "" : "";
							case "SMSTemplate":
					return AppendWithWHERE ? "" : "";
							case "Alerts":
					return AppendWithWHERE ? "" : "";
							case "Reporting":
					return AppendWithWHERE ? "" : "";
							case "DelZone":
					return AppendWithWHERE ? "" : "";
					}
		return "";
	}

	public string SQLQueryAllFileFields  { get  { return  @" select * from (
			select 'EMail' as Dataset, RecordID, EMAttach as FilePath, isnull(cast(EMSubject as varchar), 'E-mails') as Name  from EMail where EMAttach is not null
		union
			select 'WordDocument' as Dataset, RecordID, WrDocTemplate as FilePath, isnull(cast(WrDocTitle as varchar), 'Word Document') as Name  from WordDocument where WrDocTemplate is not null
		union
			select '', 0, '','') P ";
		}
	}
	public List<Pair<string, string>> DatasetsAsPairs()
    {
        return IQApp.DB.Load<Pair<string, string>>(DatasetsAsQuery());
    }
	public string DatasetsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select 'Contact', 'Customer Contacts'
					union select 'Orders', 'Orders'
					union select 'OrderLine', 'Order Lines'
					union select 'Job', 'Jobs'
					union select 'JobLine', 'Job Lines'
					union select 'Inv', 'Invoices'
					union select 'InvLine', 'Invoice Lines'
					union select 'CN', 'Credit Notes'
					union select 'UKOrder', 'UK Orders'
					union select 'FerryRoute', 'Ferry Routes'
					union select 'InvComment', 'Invoice Comments'
					union select 'VATCodes', 'VAT Codes'
					union select 'JobCost', 'Job Costs'
					union select 'CertShip', 'Certificates of Shipment'
					union select 'CNLine', 'Credit Note Lines'
					union select 'Driver', 'Drivers'
					union select 'ExchRate', 'Exchange Rates'
					union select 'Trailer', 'Trailers'
					union select 'PeriodInv', 'Period Inv Includes'
					union select 'Week', 'Weeks'
					union select 'DriverHrs', 'Driver Hours'
					union select 'InvBatch', 'Invoice Batches'
					union select 'PackageType', 'Package Types'
					union select 'BottleSize', 'Bottle Sizes'
					union select 'PalletType', 'Pallet Types'
					union select 'EADNum', 'eAD Numbers'
					union select 'ShipDoc', 'Shipping Documents'
					union select 'Truck', 'Trucks'
					union select 'TruckMileage', 'Truck Fuel / Mileage'
					union select 'Customer', 'Customers'
					union select 'Country', 'Countries'
					union select 'REDSOrder', 'REDS Order Header'
					union select 'REDSOrdLine', 'REDS Order Lines'
					union select 'REDSTax', 'REDS Tax Codes'
					union select 'DutyRateHist', 'Duty Rate History'
					union select 'REDSEAD', 'REDS eAD Numbers'
					union select 'IStatRec', 'Intrastat Records'
					union select 'Months', 'Months'
					union select 'ChangeReq', 'Change Requests'
					union select 'EMail', 'E-mails'
					union select 'WordDocument', 'Word Document'
					union select 'Query', 'Query'
					union select 'EmailTemplatess', 'Email Templates'
					union select 'Staff', 'Staff'
					union select 'SMS', 'SMS'
					union select 'SMSTemplate', 'SMS Template'
					union select 'Alerts', 'Alerts'
					union select 'Reporting', 'Reporting'
					union select 'DelZone', 'Delivery Zones'
				";
	}
}

public static class DSUtil { 
	public static string CustTypeAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Client' as Description  union select '2' as KeyValue, 'Supplier' as Description  union select '3' as KeyValue, 'Bonded Warehouse' as Description  union select '4' as KeyValue, 'Duty Paid Delivery' as Description  union select '5' as KeyValue, 'Transporter' as Description  union select '6' as KeyValue, 'Collection Point' as Description  union select '7' as KeyValue, 'Exporter' as Description  union select '8' as KeyValue, 'Importer' as Description  union select '9' as KeyValue, 'Clearing Agent' as Description ";}public static string CustCurrAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Pound Sterling' as Description  union select '2' as KeyValue, 'Euro' as Description  union select '3' as KeyValue, 'US Dollar' as Description ";}public static string OrdExpImpAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Import' as Description  union select '2' as KeyValue, 'Export' as Description ";}public static string OrdStatusAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Duty Paid' as Description  union select '2' as KeyValue, 'Under Bond' as Description ";}public static string OrdVATPaidByAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Client' as Description  union select '2' as KeyValue, 'Consignee' as Description  union select '3' as KeyValue, 'Supplier' as Description  union select '4' as KeyValue, 'Delivery' as Description ";}public static string OrdBondFromAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Client' as Description  union select '2' as KeyValue, 'Consignee' as Description  union select '3' as KeyValue, 'Supplier' as Description  union select '4' as KeyValue, 'Delivery Point' as Description ";}public static string JobLDelPointAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'As Order' as Description  union select '2' as KeyValue, 'FTL' as Description ";}public static string JobAccMonthAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '101' as KeyValue, 'JAN 2003' as Description  union select '102' as KeyValue, 'FEB 2003' as Description  union select '103' as KeyValue, 'MARCH 2003' as Description  union select '104' as KeyValue, 'APRIL 2003' as Description  union select '105' as KeyValue, 'MAY 2003' as Description  union select '106' as KeyValue, 'JUNE 2003' as Description  union select '107' as KeyValue, 'JULY  2003' as Description  union select '108' as KeyValue, 'AUG 2003' as Description  union select '109' as KeyValue, 'SEPT 2003' as Description  union select '110' as KeyValue, 'OCT 2003' as Description  union select '111' as KeyValue, 'NOV 2003' as Description  union select '112' as KeyValue, 'DEC 2003' as Description  union select '113' as KeyValue, 'JAN 2004' as Description  union select '114' as KeyValue, 'FEB 2004' as Description  union select '115' as KeyValue, 'MARCH 2004' as Description  union select '116' as KeyValue, 'APRIL 2004' as Description  union select '117' as KeyValue, 'MAY 2004' as Description  union select '118' as KeyValue, 'JUNE 2004' as Description  union select '119' as KeyValue, 'JULY  2004' as Description  union select '120' as KeyValue, 'AUG 2004' as Description  union select '121' as KeyValue, 'SEPT 2004' as Description  union select '122' as KeyValue, 'OCT 2004' as Description  union select '123' as KeyValue, 'NOV 2004' as Description  union select '124' as KeyValue, 'DEC 2004' as Description  union select '125' as KeyValue, 'JAN 2005' as Description  union select '126' as KeyValue, 'FEB 2005' as Description  union select '127' as KeyValue, 'MAR 2005' as Description  union select '128' as KeyValue, 'APR 2005' as Description  union select '129' as KeyValue, 'MAY 2005' as Description  union select '130' as KeyValue, 'JUN 2005' as Description  union select '131' as KeyValue, 'JUL 2005' as Description  union select '132' as KeyValue, 'AUG 2005' as Description  union select '133' as KeyValue, 'SEP 2005' as Description  union select '134' as KeyValue, 'OCT 2005' as Description  union select '135' as KeyValue, 'NOV 2005' as Description  union select '136' as KeyValue, 'DEC 2005' as Description  union select '137' as KeyValue, 'JAN 2006' as Description  union select '138' as KeyValue, 'FEB 2006' as Description  union select '139' as KeyValue, 'MAR 2006' as Description  union select '140' as KeyValue, 'APR 2006' as Description  union select '141' as KeyValue, 'MAY 2006' as Description  union select '142' as KeyValue, 'JUN 2006' as Description  union select '143' as KeyValue, 'JUL 2006' as Description  union select '144' as KeyValue, 'AUG 2006' as Description  union select '145' as KeyValue, 'SEP 2006' as Description  union select '146' as KeyValue, 'OCT 2006' as Description  union select '147' as KeyValue, 'NOV 2006' as Description  union select '148' as KeyValue, 'DEC 2006' as Description  union select '149' as KeyValue, 'JAN 2007' as Description  union select '150' as KeyValue, 'FEB 2007' as Description  union select '255' as KeyValue, 'DUMMY' as Description ";}public static string CustDelZoneAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '11' as KeyValue, 'Northampton (Tesco)' as Description  union select '12' as KeyValue, 'Corsham' as Description  union select '13' as KeyValue, 'Nailsea' as Description  union select '14' as KeyValue, 'Burton-on-Trent' as Description  union select '15' as KeyValue, 'Preston' as Description  union select '16' as KeyValue, 'Rotherham' as Description  union select '17' as KeyValue, 'London E16' as Description  union select '18' as KeyValue, 'Hoddesdon' as Description  union select '19' as KeyValue, 'Dorchester' as Description  union select '20' as KeyValue, 'Barking' as Description  union select '21' as KeyValue, 'Basildon (Schenker)' as Description  union select '22' as KeyValue, 'Cirencester' as Description  union select '23' as KeyValue, 'Tilbury' as Description  union select '24' as KeyValue, 'Basildon (Eurobox)' as Description  union select '25' as KeyValue, 'Coventry (Morrisons)' as Description  union select '26' as KeyValue, 'Scotland' as Description  union select '27' as KeyValue, 'Moulton (Tesco)' as Description  union select '28' as KeyValue, 'Belvedere' as Description  union select '31' as KeyValue, 'North WEST' as Description  union select '32' as KeyValue, 'East Anglia' as Description  union select '33' as KeyValue, 'Midlands' as Description  union select '34' as KeyValue, 'Wales & Bristol' as Description  union select '35' as KeyValue, 'London' as Description  union select '36' as KeyValue, 'South-East' as Description  union select '37' as KeyValue, 'South-West' as Description  union select '38' as KeyValue, 'North EAST' as Description  union select '39' as KeyValue, 'Home Counties' as Description  union select '40' as KeyValue, 'Wakefield (Morrisons)' as Description  union select '41' as KeyValue, 'Basingstoke' as Description  union select '42' as KeyValue, 'West Hallam' as Description  union select '43' as KeyValue, 'Theale (Nr Reading)' as Description  union select '44' as KeyValue, 'Northampton (Morrisons)' as Description ";}public static string InvBTypeAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Import Inv' as Description  union select '2' as KeyValue, 'Export Inv' as Description  union select '3' as KeyValue, 'Duty Inv' as Description  union select '4' as KeyValue, 'Import CN' as Description  union select '5' as KeyValue, 'Export CN' as Description ";}public static string CustAADSysAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Electronic' as Description  union select '2' as KeyValue, 'Paper' as Description ";}public static string OrdGBWKNoFromAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '4' as KeyValue, 'Delivery Point' as Description ";}public static string IStNAT1AsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, '1' as Description  union select '2' as KeyValue, '2' as Description  union select '3' as KeyValue, '3' as Description  union select '4' as KeyValue, '4' as Description  union select '5' as KeyValue, '5' as Description  union select '6' as KeyValue, '6' as Description  union select '7' as KeyValue, '7' as Description  union select '8' as KeyValue, '8' as Description  union select '9' as KeyValue, '9' as Description ";}public static string IStNAT2AsQuery() { return @"select 0 as KeyValue, '' as Description  union select '0' as KeyValue, '0' as Description  union select '6' as KeyValue, '6' as Description  union select '7' as KeyValue, '7' as Description  union select '8' as KeyValue, '8' as Description ";}public static string IStTranspModeAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Sea' as Description  union select '2' as KeyValue, 'Rail' as Description  union select '3' as KeyValue, 'Road' as Description  union select '4' as KeyValue, 'Air' as Description  union select '5' as KeyValue, 'Post' as Description  union select '6' as KeyValue, 'Not Allocated' as Description  union select '7' as KeyValue, 'Fixed Installations' as Description  union select '8' as KeyValue, 'Inland Waterway' as Description  union select '9' as KeyValue, 'Own Propulsion' as Description ";}public static string CRTypeAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Fault / bug' as Description  union select '2' as KeyValue, 'Change request' as Description  union select '3' as KeyValue, 'Question' as Description ";}public static string CRPriorityAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Urgent' as Description  union select '2' as KeyValue, 'High' as Description  union select '3' as KeyValue, 'Medium' as Description  union select '4' as KeyValue, 'Low' as Description ";}public static string CRStatusAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Open - with Intrinsiq' as Description  union select '2' as KeyValue, 'Open - with FTL' as Description  union select '3' as KeyValue, 'On hold' as Description  union select '4' as KeyValue, 'Closed' as Description ";}public static string EMStatusAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Unsent' as Description  union select '2' as KeyValue, 'Sent' as Description  union select '3' as KeyValue, 'Delete' as Description ";}public static string StfSGAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Full Rights' as Description  union select '2' as KeyValue, 'Database User' as Description  union select '3' as KeyValue, 'Customer' as Description ";}public static string WrDocQueryTypeAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '0' as KeyValue, 'User Written' as Description  union select '1' as KeyValue, 'Built In' as Description ";}public static string SMSStatusAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'Pending' as Description  union select '2' as KeyValue, 'Sent' as Description  union select '3' as KeyValue, 'Delivered' as Description ";}public static string QryTypeAsQuery() { return @"select 0 as KeyValue, '' as Description  union select '1' as KeyValue, 'SQL' as Description  union select '2' as KeyValue, 'IronRuby' as Description  union select '3' as KeyValue, 'Excel Report' as Description ";}
	public static string InvFreightDutyAsQuery() { return @"select '0' as KeyValue, '' as Description  union select 'Duty' as KeyValue, 'Duty' as Description  union select 'Freight' as KeyValue, 'Freight' as Description ";}public static string CustLangAsQuery() { return @"select '0' as KeyValue, '' as Description  union select 'ENG' as KeyValue, 'English' as Description  union select 'FRA' as KeyValue, 'French' as Description  union select 'GER' as KeyValue, 'German' as Description  union select 'ITA' as KeyValue, 'Italian' as Description  union select 'SPN' as KeyValue, 'Spanish' as Description ";}public static string InvLChargeTypeAsQuery() { return @"select '0' as KeyValue, '' as Description  union select '001001' as KeyValue, 'Services rendered' as Description  union select '001003' as KeyValue, 'CMR Haulage' as Description  union select '001004' as KeyValue, 'RHA Haulage' as Description  union select '001005' as KeyValue, 'Ferry Charges' as Description  union select '001006' as KeyValue, 'Air Freight' as Description  union select '001007' as KeyValue, 'Ancillary Charges' as Description  union select '001009' as KeyValue, 'Warehousing' as Description  union select '001010' as KeyValue, 'Claims' as Description  union select '001012' as KeyValue, 'Operations Insurance' as Description  union select '001013' as KeyValue, 'Disbursements' as Description  union select '001014' as KeyValue, 'Rent' as Description  union select '001015' as KeyValue, 'Diesel Supplies' as Description  union select '001017' as KeyValue, 'Fuel Surcharge' as Description  union select '001041' as KeyValue, 'Trailer/Vehicle Hire' as Description  union select '001085' as KeyValue, 'Interest' as Description  union select '004001' as KeyValue, 'Duties and VAT' as Description  union select '004003' as KeyValue, 'Import VAT' as Description ";}public static string InvImpExpAsQuery() { return @"select '0' as KeyValue, '' as Description  union select 'Exp' as KeyValue, 'Export' as Description  union select 'Imp' as KeyValue, 'Import' as Description ";}public static string IStDelTermsAsQuery() { return @"select '0' as KeyValue, '' as Description  union select 'CIF' as KeyValue, 'CIF' as Description  union select 'DDU/DDP' as KeyValue, 'DDU/DDP' as Description  union select 'EXW' as KeyValue, 'EXW' as Description  union select 'FOB' as KeyValue, 'FOB' as Description  union select 'XXX' as KeyValue, 'XXX' as Description ";}
	public static List<QueryRelationship> FindRelationships(List<QueryResultInfo> q1, 
            List<QueryResultInfo> q2, string ParentTable)
    {
        // Step 1 - get rid of any DS tables (if they are using the older table structure)
   
        foreach(var itm in q1)
        {
            if(itm.source_table.ToNotNull().StartsWith("DS"))
                itm.source_table = IQApp.Datasets.GetDSName(itm.source_table.Replace("DS", "").ToInt());
        }
        foreach (var itm in q2)
        {
            if (itm.source_table.ToNotNull().StartsWith("DS"))
                itm.source_table = IQApp.Datasets.GetDSName(itm.source_table.Replace("DS", "").ToInt());
        }

        List<QueryRelationship> ret = new List<QueryRelationship>();

        // Step 2 - search for relationships
        List<string> parentTables = q1.Select(f => f.source_table).Distinct().ToList();
        List<string> childTables = q2.Select(f => f.source_table).Distinct().ToList();
        foreach (var itm in parentTables) {
            foreach (var child in childTables)
            {
                var qry = DSUtil.Relationships.Where(f => f.One == itm && f.Many == child
                && 
                q1.Where(g=> g.name == f.ParentKeyDFName).Any() && q2.Where(g=> g.name == f.LinkDFName).Any()
                );
                if(qry.Any())
                {
                    ret.Add(new QueryRelationship()
                    {
                        ChildCol = qry.First().LinkDFName,
                        ParentCol = qry.First().ParentKeyDFName,
                        ParentTable = ParentTable
                    });
                }
            }
        }
        return ret;
    }

	// Relationships
	public static List<DSRelationship> Relationships { 
		get { 
			List<DSRelationship> relations = new List<DSRelationship>();
						return relations;
		}
	}

	public static string DatasetsQueryRecId(string DS) {
		switch(DS) {
							case "Contact":
					return "select RecordID as KeyValue, cast(ContName as varchar) + ' (' + cast(ContId as varchar) + ')' as [Description], ContName as Search1, ContId as Search2 from Contact";
							case "Orders":
					return "select RecordID as KeyValue, cast(OrdId as varchar) + ' (' + cast(OrdId as varchar) + ')' as [Description], OrdId as Search1, OrdId as Search2 from Orders";
							case "OrderLine":
					return "select RecordID as KeyValue, cast(OrdLOrder as varchar) + ' (' + cast(OrdLOrder as varchar) + ')' as [Description], OrdLOrder as Search1, OrdLOrder as Search2 from OrderLine";
							case "Job":
					return "select RecordID as KeyValue, cast(JobNo as varchar) + ' (' + cast(JobId as varchar) + ')' as [Description], JobNo as Search1, JobId as Search2 from Job";
							case "JobLine":
					return "select RecordID as KeyValue, cast(JobLJobNo as varchar) + ' (' + cast(JobLJobNo as varchar) + ')' as [Description], JobLJobNo as Search1, JobLJobNo as Search2 from JobLine";
							case "Inv":
					return "select RecordID as KeyValue, cast(InvId as varchar) + ' (' + cast(InvId as varchar) + ')' as [Description], InvId as Search1, InvId as Search2 from Inv";
							case "InvLine":
					return "select RecordID as KeyValue, cast(InvLInvNo as varchar) + ' (' + cast(InvLInvNo as varchar) + ')' as [Description], InvLInvNo as Search1, InvLInvNo as Search2 from InvLine";
							case "CN":
					return "select RecordID as KeyValue, cast(CNId as varchar) + ' (' + cast(CNId as varchar) + ')' as [Description], CNId as Search1, CNId as Search2 from CN";
							case "UKOrder":
					return "select RecordID as KeyValue, cast(UKOId as varchar) + ' (' + cast(UKOId as varchar) + ')' as [Description], UKOId as Search1, UKOId as Search2 from UKOrder";
							case "FerryRoute":
					return "select RecordID as KeyValue, cast(FRName as varchar) + ' (' + cast(FRId as varchar) + ')' as [Description], FRName as Search1, FRId as Search2 from FerryRoute";
							case "InvComment":
					return "select RecordID as KeyValue, cast(InvCId as varchar) + ' (' + cast(InvCId as varchar) + ')' as [Description], InvCId as Search1, InvCId as Search2 from InvComment";
							case "VATCodes":
					return "select RecordID as KeyValue, cast(VATCode as varchar) + ' (' + cast(VATId as varchar) + ')' as [Description], VATCode as Search1, VATId as Search2 from VATCodes";
							case "JobCost":
					return "select RecordID as KeyValue, cast(JobCJobNo as varchar) + ' (' + cast(JobCJobNo as varchar) + ')' as [Description], JobCJobNo as Search1, JobCJobNo as Search2 from JobCost";
							case "CertShip":
					return "select RecordID as KeyValue, cast(CSId as varchar) + ' (' + cast(CSId as varchar) + ')' as [Description], CSId as Search1, CSId as Search2 from CertShip";
							case "CNLine":
					return "select RecordID as KeyValue, cast(CNLNo as varchar) + ' (' + cast(CNLNo as varchar) + ')' as [Description], CNLNo as Search1, CNLNo as Search2 from CNLine";
							case "Driver":
					return "select RecordID as KeyValue, cast(DrvName as varchar) + ' (' + cast(DrvId as varchar) + ')' as [Description], DrvName as Search1, DrvId as Search2 from Driver";
							case "ExchRate":
					return "select RecordID as KeyValue, cast(ExRName as varchar) + ' (' + cast(ExRId as varchar) + ')' as [Description], ExRName as Search1, ExRId as Search2 from ExchRate";
							case "Trailer":
					return "select RecordID as KeyValue, cast(TrlFleetNo as varchar) + ' (' + cast(TrlId as varchar) + ')' as [Description], TrlFleetNo as Search1, TrlId as Search2 from Trailer";
							case "PeriodInv":
					return "select RecordID as KeyValue, cast(PInvId as varchar) + ' (' + cast(PInvId as varchar) + ')' as [Description], PInvId as Search1, PInvId as Search2 from PeriodInv";
							case "Week":
					return "select RecordID as KeyValue, cast(WkId as varchar) + ' (' + cast(WkId as varchar) + ')' as [Description], WkId as Search1, WkId as Search2 from Week";
							case "DriverHrs":
					return "select RecordID as KeyValue, cast(DrvHDriver as varchar) + ' (' + cast(DrvHDriver as varchar) + ')' as [Description], DrvHDriver as Search1, DrvHDriver as Search2 from DriverHrs";
							case "InvBatch":
					return "select RecordID as KeyValue, cast(InvBId as varchar) + ' (' + cast(InvBId as varchar) + ')' as [Description], InvBId as Search1, InvBId as Search2 from InvBatch";
							case "PackageType":
					return "select RecordID as KeyValue, cast(PackName as varchar) + ' (' + cast(PackId as varchar) + ')' as [Description], PackName as Search1, PackId as Search2 from PackageType";
							case "BottleSize":
					return "select RecordID as KeyValue, cast(BSzSize as varchar) + ' (' + cast(BSzId as varchar) + ')' as [Description], BSzSize as Search1, BSzId as Search2 from BottleSize";
							case "PalletType":
					return "select RecordID as KeyValue, cast(PallName as varchar) + ' (' + cast(PallId as varchar) + ')' as [Description], PallName as Search1, PallId as Search2 from PalletType";
							case "EADNum":
					return "select RecordID as KeyValue, cast(EADNo as varchar) + ' (' + cast(EADOrder as varchar) + ')' as [Description], EADNo as Search1, EADOrder as Search2 from EADNum";
							case "ShipDoc":
					return "select RecordID as KeyValue, cast(SDId as varchar) + ' (' + cast(SDId as varchar) + ')' as [Description], SDId as Search1, SDId as Search2 from ShipDoc";
							case "Truck":
					return "select RecordID as KeyValue, cast(TrkName as varchar) + ' (' + cast(TrkId as varchar) + ')' as [Description], TrkName as Search1, TrkId as Search2 from Truck";
							case "TruckMileage":
					return "select RecordID as KeyValue, cast(TrkMTruck as varchar) + ' (' + cast(TrkMTruck as varchar) + ')' as [Description], TrkMTruck as Search1, TrkMTruck as Search2 from TruckMileage";
							case "Customer":
					return "select RecordID as KeyValue, cast(CustName as varchar) + ' (' + cast(CustId as varchar) + ')' as [Description], CustName as Search1, CustId as Search2 from Customer";
							case "Country":
					return "select RecordID as KeyValue, cast(CtryName as varchar) + ' (' + cast(CtryId as varchar) + ')' as [Description], CtryName as Search1, CtryId as Search2 from Country";
							case "REDSOrder":
					return "select RecordID as KeyValue, cast(RDOrdId as varchar) + ' (' + cast(RDOrdId as varchar) + ')' as [Description], RDOrdId as Search1, RDOrdId as Search2 from REDSOrder";
							case "REDSOrdLine":
					return "select RecordID as KeyValue, cast(RDOLRDId as varchar) + ' (' + cast(RDOLRDId as varchar) + ')' as [Description], RDOLRDId as Search1, RDOLRDId as Search2 from REDSOrdLine";
							case "REDSTax":
					return "select RecordID as KeyValue, cast(RDTaxCode as varchar) + ' (' + cast(RDTaxId as varchar) + ')' as [Description], RDTaxCode as Search1, RDTaxId as Search2 from REDSTax";
							case "DutyRateHist":
					return "select RecordID as KeyValue, cast(DRHTaxCode as varchar) + ' (' + cast(DRHId as varchar) + ')' as [Description], DRHTaxCode as Search1, DRHId as Search2 from DutyRateHist";
							case "REDSEAD":
					return "select RecordID as KeyValue, cast(RDEADId as varchar) + ' (' + cast(RDEADRDId as varchar) + ')' as [Description], RDEADId as Search1, RDEADRDId as Search2 from REDSEAD";
							case "IStatRec":
					return "select RecordID as KeyValue, cast(IStId as varchar) + ' (' + cast(IStId as varchar) + ')' as [Description], IStId as Search1, IStId as Search2 from IStatRec";
							case "Months":
					return "select RecordID as KeyValue, cast(MthName as varchar) + ' (' + cast(MthId as varchar) + ')' as [Description], MthName as Search1, MthId as Search2 from Months";
							case "ChangeReq":
					return "select RecordID as KeyValue, cast(CRName as varchar) + ' (' + cast(CRId as varchar) + ')' as [Description], CRName as Search1, CRId as Search2 from ChangeReq";
							case "EMail":
					return "select RecordID as KeyValue, cast(EMSubject as varchar) + ' (' + cast(EMId as varchar) + ')' as [Description], EMSubject as Search1, EMId as Search2 from EMail";
							case "WordDocument":
					return "select RecordID as KeyValue, cast(WrDocTitle as varchar) + ' (' + cast(WrDocId as varchar) + ')' as [Description], WrDocTitle as Search1, WrDocId as Search2 from WordDocument";
							case "Query":
					return "select RecordID as KeyValue, cast(QryName as varchar) + ' (' + cast(QryId as varchar) + ')' as [Description], QryName as Search1, QryId as Search2 from Query";
							case "EmailTemplatess":
					return "select RecordID as KeyValue, cast(EMTName as varchar) + ' (' + cast(EMTId as varchar) + ')' as [Description], EMTName as Search1, EMTId as Search2 from EmailTemplatess";
							case "Staff":
					return "select RecordID as KeyValue, cast(StfName as varchar) + ' (' + cast(StfId as varchar) + ')' as [Description], StfName as Search1, StfId as Search2 from Staff";
							case "SMS":
					return "select RecordID as KeyValue, cast(SMSDestination as varchar) + ' (' + cast(SMSId as varchar) + ')' as [Description], SMSDestination as Search1, SMSId as Search2 from SMS";
							case "SMSTemplate":
					return "select RecordID as KeyValue, cast(SMSTName as varchar) + ' (' + cast(SMSTId as varchar) + ')' as [Description], SMSTName as Search1, SMSTId as Search2 from SMSTemplate";
							case "Alerts":
					return "select RecordID as KeyValue, cast(AlrtTitle as varchar) + ' (' + cast(AlrtId as varchar) + ')' as [Description], AlrtTitle as Search1, AlrtId as Search2 from Alerts";
							case "Reporting":
					return "select RecordID as KeyValue, cast(RptTitle as varchar) + ' (' + cast(RptId as varchar) + ')' as [Description], RptTitle as Search1, RptId as Search2 from Reporting";
							case "DelZone":
					return "select RecordID as KeyValue, cast(DelZName as varchar) + ' (' + cast(DelZId as varchar) + ')' as [Description], DelZName as Search1, DelZId as Search2 from DelZone";
					}
		return "select '' as KeyValue, '' as [Description]";
	}
	public static string GetTitleField(string DSName) {
		switch(DSName) {
				case "Contact":
			return "ContName";

				case "Orders":
			return "OrdId";

				case "OrderLine":
			return "OrdLOrder";

				case "Job":
			return "JobNo";

				case "JobLine":
			return "JobLJobNo";

				case "Inv":
			return "InvId";

				case "InvLine":
			return "InvLInvNo";

				case "CN":
			return "CNId";

				case "UKOrder":
			return "UKOId";

				case "FerryRoute":
			return "FRName";

				case "InvComment":
			return "InvCId";

				case "VATCodes":
			return "VATCode";

				case "JobCost":
			return "JobCJobNo";

				case "CertShip":
			return "CSId";

				case "CNLine":
			return "CNLNo";

				case "Driver":
			return "DrvName";

				case "ExchRate":
			return "ExRName";

				case "Trailer":
			return "TrlFleetNo";

				case "PeriodInv":
			return "PInvId";

				case "Week":
			return "WkId";

				case "DriverHrs":
			return "DrvHDriver";

				case "InvBatch":
			return "InvBId";

				case "PackageType":
			return "PackName";

				case "BottleSize":
			return "BSzSize";

				case "PalletType":
			return "PallName";

				case "EADNum":
			return "EADNo";

				case "ShipDoc":
			return "SDId";

				case "Truck":
			return "TrkName";

				case "TruckMileage":
			return "TrkMTruck";

				case "Customer":
			return "CustName";

				case "Country":
			return "CtryName";

				case "REDSOrder":
			return "RDOrdId";

				case "REDSOrdLine":
			return "RDOLRDId";

				case "REDSTax":
			return "RDTaxCode";

				case "DutyRateHist":
			return "DRHTaxCode";

				case "REDSEAD":
			return "RDEADId";

				case "IStatRec":
			return "IStId";

				case "Months":
			return "MthName";

				case "ChangeReq":
			return "CRName";

				case "EMail":
			return "EMSubject";

				case "WordDocument":
			return "WrDocTitle";

				case "Query":
			return "QryName";

				case "EmailTemplatess":
			return "EMTName";

				case "Staff":
			return "StfName";

				case "SMS":
			return "SMSDestination";

				case "SMSTemplate":
			return "SMSTName";

				case "Alerts":
			return "AlrtTitle";

				case "Reporting":
			return "RptTitle";

				case "DelZone":
			return "DelZName";

				}
		return "";
	}
	public static string GetKeyField(string DSName) {
		switch(DSName) {
				case "Contact":
			return "ContId";

				case "Orders":
			return "OrdId";

				case "OrderLine":
			return "OrdLOrder";

				case "Job":
			return "JobId";

				case "JobLine":
			return "JobLJobNo";

				case "Inv":
			return "InvId";

				case "InvLine":
			return "InvLInvNo";

				case "CN":
			return "CNId";

				case "UKOrder":
			return "UKOId";

				case "FerryRoute":
			return "FRId";

				case "InvComment":
			return "InvCId";

				case "VATCodes":
			return "VATId";

				case "JobCost":
			return "JobCJobNo";

				case "CertShip":
			return "CSId";

				case "CNLine":
			return "CNLNo";

				case "Driver":
			return "DrvId";

				case "ExchRate":
			return "ExRId";

				case "Trailer":
			return "TrlId";

				case "PeriodInv":
			return "PInvId";

				case "Week":
			return "WkId";

				case "DriverHrs":
			return "DrvHDriver";

				case "InvBatch":
			return "InvBId";

				case "PackageType":
			return "PackId";

				case "BottleSize":
			return "BSzId";

				case "PalletType":
			return "PallId";

				case "EADNum":
			return "EADOrder";

				case "ShipDoc":
			return "SDId";

				case "Truck":
			return "TrkId";

				case "TruckMileage":
			return "TrkMTruck";

				case "Customer":
			return "CustId";

				case "Country":
			return "CtryId";

				case "REDSOrder":
			return "RDOrdId";

				case "REDSOrdLine":
			return "RDOLRDId";

				case "REDSTax":
			return "RDTaxId";

				case "DutyRateHist":
			return "DRHId";

				case "REDSEAD":
			return "RDEADRDId";

				case "IStatRec":
			return "IStId";

				case "Months":
			return "MthId";

				case "ChangeReq":
			return "CRId";

				case "EMail":
			return "EMId";

				case "WordDocument":
			return "WrDocId";

				case "Query":
			return "QryId";

				case "EmailTemplatess":
			return "EMTId";

				case "Staff":
			return "StfId";

				case "SMS":
			return "SMSId";

				case "SMSTemplate":
			return "SMSTId";

				case "Alerts":
			return "AlrtId";

				case "Reporting":
			return "RptId";

				case "DelZone":
			return "DelZId";

				}
		return "";
	}
}
