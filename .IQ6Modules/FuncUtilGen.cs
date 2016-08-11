

public static class FunctionsUtil {

	public static List<Pair<string, string>> FunctionsAsPairs()
    { 
        return IQApp.DB.Load<Pair<string, string>>(FunctionsAsQuery());
    }
	public static string FunctionsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select '1', 'Copy Order to New'
					union select '2', 'Delete Job Line'
					union select '3', 'Delivery / Goods Update'
					union select '5', 'E-Mail Availability'
					union select '6', 'E-Mail FreightTrack Details'
					union select '7', 'Set FreightTrack Password'
					union select '8', 'Send E-Mail'
					union select '10', 'Re-Calculate Status'
					union select '11', 'Print Trailer Report'
					union select '12', 'Create Period Invoice'
					union select '13', 'Enter Driver Hours'
					union select '14', 'Delete Job'
					union select '15', 'View Order'
					union select '16', 'Export Selected Batch'
					union select '17', 'Edit Invoice'
					union select '19', 'Create Supplier Spreadsheet'
					union select '20', 'Delete Order(s)'
					union select '21', 'View Invoice(s)'
					union select '22', 'View Job'
					union select '23', 'Print Shipping Document'
					union select '24', 'Preview Shipping Document'
					union select '25', 'REDS Create Duty Invoices'
					union select '26', 'REDS Lock Down Previous Month'
					union select '27', 'Send Unsent Invoices'
					union select '82', 'Date From'
					union select '85', 'StaffAndDest'
					union select '86', 'StaffSelect'
					union select '87', 'TransportDet'
					union select '88', 'TransportCharges'
					union select '90', 'OrdersRequired'
					union select '91', 'DateFromTo'
					union select '94', 'DateType'
					union select '95', 'MonthRange'
					union select '96', 'Zone'
					union select '97', 'SummaryDetail'
					union select '98', 'ShowSeparatePageAddress'
					union select '99', 'ShowSeparatePage'
					union select '100', 'ShowFTLDAN'
					union select '101', 'UnDecWithDates'
					union select '102', 'UnDecWithMonth'
					union select '103', 'JobSingle'
					union select '104', 'ExciseDetail'
					union select '105', 'ExciseSummary'
					union select '106', 'HM2Form'
					union select '120', 'Job Search'
					union select '121', 'Order Search'
					union select '122', 'Customer Search'
				";
	}

}