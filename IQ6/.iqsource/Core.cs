
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.Mvc;
using IQ6.Core;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;
using System.Net.Mail;

namespace FTL{

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/Menu_1.cshtml")]
    public partial class IQ6_Views_Menu_1_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_Menu_1_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/admin.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Admin</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Staff/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/staff.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Staff</a></li><li><a");
WriteLiteral(" href=\'/BottleSize/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/bottle.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Bottle Sizes</a></li><li><a");
WriteLiteral(" href=\'/Country/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/countries.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Countries</a></li><li><a");
WriteLiteral(" href=\'/Driver/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/drivers.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Drivers</a></li><li><a");
WriteLiteral(" href=\'/DutyRateHist/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Duty Rate History</a></li><li><a");
WriteLiteral(" href=\'/ExchRate/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/exchange.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Exchange Rates</a></li><li><a");
WriteLiteral(" href=\'/FerryRoute/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/ferryroutes.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Ferry Routes</a></li><li><a");
WriteLiteral(" href=\'/Months/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Months</a></li><li><a");
WriteLiteral(" href=\'/PackageType/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/content/icon/package.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Package Types</a></li><li><a");
WriteLiteral(" href=\'/PalletType/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/pallet.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Pallet Types</a></li><li><a");
WriteLiteral(" href=\'/Trailer/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/trailers.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Trailers</a></li><li><a");
WriteLiteral(" href=\'/Truck/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/trucks.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Trucks</a></li><li><a");
WriteLiteral(" href=\'/Week/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/weeks.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Weeks</a></li><li><a");
WriteLiteral(" href=\'/DelZone/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Delivery Zones</a></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/systemadmin.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />System Admin</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Query/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Queries</a></li><li><a");
WriteLiteral(" href=\'/EmailTemplatess/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">E-mail Templates</a></li><li><a");
WriteLiteral(" href=\'/SMSTemplate/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">SMS Templates</a></li><li><a");
WriteLiteral(" href=\'/WordDocument/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Word Documents</a></li></ul></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/job.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Jobs</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Job/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Job</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Job\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Jobs</a></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">Shipping Documents</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/ShipDoc/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Shipping Documents</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=ShipDoc\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Shipping Search</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">Certificates Of Shipment</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/CertShip/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Certificates of Shipment</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=CertShip\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Certificates</a></li></ul></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/order.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Orders</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Orders/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Orders</a></li><li><a");
WriteLiteral(" href=\'/UKOrder/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add UK Orders</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Orders\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Orders</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=OrderLine\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Order Lines</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=UKOrder\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">UK Order Search</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/customers.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Companies</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Customer/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Company</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Customer\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Company Search</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Contact\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Contact Search</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/accounts.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Accounts</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/invoice.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Invoices</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Inv\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Invoices</a></li><li><a");
WriteLiteral(" href=\'/Inv/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Invoice</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/credit.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Credit Notes</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=CN\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Credit Notes</a></li><li><a");
WriteLiteral(" href=\'/CN/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Credit Note</a></li></ul></li><li><a");
WriteLiteral(" href=\'/InvBatch/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Invoice Batches</a></li><li><a");
WriteLiteral(" href=\'/InvComment/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Invoice Comments</a></li><li><a");
WriteLiteral(" href=\'/VATCodes/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/vatcodes.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />VAT Codes</a></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">Intrastat</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/IStatRec/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Intrastat Records</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=IStatRec\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Intrastat Records</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">REDS</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/REDSTax/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">REDS Tax Codes</a></li><li><a");
WriteLiteral(" href=\'/REDSOrder/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add REDS Order</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=REDSEAD\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search REDS eAD Numbers</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=REDSOrder\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search REDS Orders</a></li></ul></li><li><a");
WriteLiteral(" href=\'/SendUnsentInvoices/Load/\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Send Unsent Invoices</a></li><li><a");
WriteLiteral(" href=\'/CreatePeriodInv/Load/\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Create Period Invoice</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/mileage.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Mileage</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/TruckMileage/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Fuel / Mileage</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=TruckMileage\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Fuel / Mileage</a></li></ul></li> ");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/Menu_2.cshtml")]
    public partial class IQ6_Views_Menu_2_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_Menu_2_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/admin.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Admin</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/BottleSize/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/bottle.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Bottle Sizes</a></li><li><a");
WriteLiteral(" href=\'/Country/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/countries.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Countries</a></li><li><a");
WriteLiteral(" href=\'/Driver/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/drivers.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Drivers</a></li><li><a");
WriteLiteral(" href=\'/DutyRateHist/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Duty Rate History</a></li><li><a");
WriteLiteral(" href=\'/ExchRate/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/exchange.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Exchange Rates</a></li><li><a");
WriteLiteral(" href=\'/FerryRoute/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/ferryroutes.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Ferry Routes</a></li><li><a");
WriteLiteral(" href=\'/Months/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Months</a></li><li><a");
WriteLiteral(" href=\'/PackageType/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/content/icon/package.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Package Types</a></li><li><a");
WriteLiteral(" href=\'/PalletType/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/pallet.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Pallet Types</a></li><li><a");
WriteLiteral(" href=\'/Trailer/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/trailers.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Trailers</a></li><li><a");
WriteLiteral(" href=\'/Truck/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/trucks.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Trucks</a></li><li><a");
WriteLiteral(" href=\'/Week/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/weeks.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Weeks</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/job.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Jobs</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Job/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Job</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Job\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Jobs</a></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">Shipping Documents</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/ShipDoc/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Shipping Documents</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=ShipDoc\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Shipping Search</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">Certificates Of Shipment</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/CertShip/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Certificates of Shipment</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=CertShip\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Certificates</a></li></ul></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/order.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Orders</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Orders/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Orders</a></li><li><a");
WriteLiteral(" href=\'/UKOrder/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add UK Orders</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Orders\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Orders</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=OrderLine\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Order Lines</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=UKOrder\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">UK Order Search</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/customers.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Companies</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/Customer/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Company</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Customer\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Company Search</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Contact\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Contact Search</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/accounts.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Accounts</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/invoice.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Invoices</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=Inv\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Invoices</a></li><li><a");
WriteLiteral(" href=\'/Inv/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Invoice</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/credit.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Credit Notes</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=CN\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Credit Notes</a></li><li><a");
WriteLiteral(" href=\'/CN/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Credit Note</a></li></ul></li><li><a");
WriteLiteral(" href=\'/InvBatch/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Invoice Batches</a></li><li><a");
WriteLiteral(" href=\'/InvComment/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Invoice Comments</a></li><li><a");
WriteLiteral(" href=\'/VATCodes/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/vatcodes.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />VAT Codes</a></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">Intrastat</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/IStatRec/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Intrastat Records</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=IStatRec\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Intrastat Records</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown-submenu\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral(">REDS</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/REDSTax/List\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">REDS Tax Codes</a></li><li><a");
WriteLiteral(" href=\'/REDSOrder/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add REDS Order</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=REDSEAD\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search REDS eAD Numbers</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=REDSOrder\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search REDS Orders</a></li></ul></li><li><a");
WriteLiteral(" href=\'/SendUnsentInvoices/Load/\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Send Unsent Invoices</a></li><li><a");
WriteLiteral(" href=\'/CreatePeriodInv/Load/\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Create Period Invoice</a></li></ul></li><li");
WriteLiteral(" class=\'dropdown\'");
WriteLiteral("><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" class=\'dropdown-toggle\'");
WriteLiteral(" data-toggle=\'dropdown\'");
WriteLiteral(" role=\'button\'");
WriteLiteral(" aria-haspopup=\'true\'");
WriteLiteral(" aria-expanded=\'false\'");
WriteLiteral("><img");
WriteLiteral(" src=\'/Content/icon/mileage.png\'");
WriteLiteral(" style=\'max-width:20px;\'");
WriteLiteral(" />Mileage</a><ul");
WriteLiteral(" class=\'dropdown-menu\'");
WriteLiteral("><li><a");
WriteLiteral(" href=\'/TruckMileage/Add\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Add Fuel / Mileage</a></li><li><a");
WriteLiteral(" href=\'/IQReporting/?DSName=TruckMileage\'");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(">Search Fuel / Mileage</a></li></ul></li> ");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/Menu_3.cshtml")]
    public partial class IQ6_Views_Menu_3_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_Menu_3_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral(" ");
        }
    }
}



namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/_FullLayout.cshtml")]
    public partial class IQ6_Views__FullLayout_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views__FullLayout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");
WriteLiteral(" charset=\"utf-8\"");
WriteLiteral(" />\r\n    <meta");
WriteLiteral(" name=\"viewport\"");
WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");
WriteLiteral(">\r\n    <title>");
      Write(ViewBag.Title);
WriteLiteral("</title>\r\n\t<link");
WriteLiteral(" rel=\"stylesheet\"");
WriteLiteral(" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.cs" +
"s\"");
WriteLiteral(">\r\n    <script");
WriteLiteral(" src=\"/IQ6/IQ6.js\"");
WriteLiteral(" type=\"text/javascript\"");
WriteLiteral("></script>\r\n\r\n    <link");
WriteLiteral(" rel=\"stylesheet\"");
WriteLiteral(" href=\"/IQ6/IQ6.css\"");
WriteLiteral(" />\r\n");
WriteLiteral("\t");
Write(RenderSection("Header", false));
WriteLiteral("\r\n</head>\r\n<body");
WriteLiteral(" style=\"background-color:#FEFFFF\"");
WriteLiteral(">\r\n\r\n");
 if(HttpContext.Current.IsDebuggingEnabled) {
WriteLiteral("\t<div");
WriteLiteral(" style=\'position:absolute;top:0px;left:600px;color:red;font-weight:bold;font-size" +
":16px;z-index:10000\'");
WriteLiteral(">DEBUG ENABLED</div>\r\n");
}
WriteLiteral("<form");
WriteLiteral(" method=\'post\'");
WriteLiteral(" action=\'\'");
WriteLiteral(" enctype=\"multipart/form-data\"");
WriteLiteral(">\r\n        <div");
WriteLiteral(" class=\"navbar\"");
WriteLiteral(" style=\"border:1px solid #AAAAAA;border-radius:0px;border-bottom:0px;margin-botto" +
"m:0px;\"");
WriteLiteral(">\r\n            <div");
WriteLiteral(" class=\"navbar-header\"");
WriteLiteral(">\r\n                <button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"navbar-toggle\"");
WriteLiteral(" data-toggle=\"collapse\"");
WriteLiteral(" data-target=\".navbar-collapse\"");
WriteLiteral(">\r\n                    <span");
WriteLiteral(" class=\"icon-bar\"");
WriteLiteral("></span>\r\n                    <span");
WriteLiteral(" class=\"icon-bar\"");
WriteLiteral("></span>\r\n                    <span");
WriteLiteral(" class=\"icon-bar\"");
WriteLiteral("></span>\r\n                </button>\r\n                <a");
WriteLiteral(" href=\"/\"");
WriteLiteral(" class=\"navbar-brand\"");
WriteLiteral(" style=\'padding:0px;\'");
WriteLiteral("><img");
WriteLiteral(" src=\"/Content/logo.png\"");
WriteLiteral(" alt=\"Intrinsiq\"");
WriteLiteral(" style=\'max-height:50px;\'");
WriteLiteral(" /></a>\r\n            </div>\r\n            <div");
WriteLiteral(" class=\"navbar-collapse collapse\"");
WriteLiteral(">\r\n\t\t\t\r\n                <ul");
WriteLiteral(" class=\"nav navbar-nav\"");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/IQ6/Views/Menu_" + IQ6.Core.IQApp.User.GetSecurityGroup() + ".cshtml");
WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t<li");
WriteLiteral(" style=\'margin-top:15px;\'");
WriteLiteral(">  \r\n\t\t\t\t\t<label>Search:</label>\r\n\t\t\t\t\t<select");
WriteLiteral(" name=\"QuickSearch\"");
WriteLiteral(" class=\"form-control quicksearch\"");
WriteLiteral(" style=\'min-width:150px;\'");
WriteLiteral(" placeholder=\"Search\"");
WriteLiteral("></select></li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li");
WriteLiteral(" style=\'margin-top:15px;display:none;margin-left:5px;\'");
WriteLiteral("  id=\"LoadingIndictaor\"");
WriteLiteral(">\r\n\t\t\t\t\t\t\t<img");
WriteLiteral(" src=\'/IQ6/loading.gif\'");
WriteLiteral("/>\r\n\t\t\t\t\t\t</li>\r\n                </ul>\r\n\r\n\t\t\t\r\n\t\t\t\t                <ul");
WriteLiteral(" class=\"nav navbar-nav navbar-right\"");
WriteLiteral(">\r\n");
                                     foreach(var module in IQApp.Modules) {
WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
                                         Write(Html.Raw(module.NavBarRight()));
WriteLiteral("\r\n");
									}		
WriteLiteral("\r\n\t\t\t\t\r\n\t\t\t\t\t\r\n                    <li");
WriteLiteral(" class=\"dropdown\"");
WriteLiteral(">\r\n                        <a");
WriteLiteral(" href=\"#\"");
WriteLiteral(" class=\"dropdown-toggle\"");
WriteLiteral(" data-toggle=\"dropdown\"");
WriteLiteral(" role=\"button\"");
WriteLiteral(" aria-haspopup=\"true\"");
WriteLiteral(" aria-expanded=\"false\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/login.png\"");
WriteLiteral(" style=\"height:20px;\"");
WriteLiteral(" />");
                                                                                                                                                                                        Write(IQApp.User.GetName());
WriteLiteral(" <span");
WriteLiteral(" class=\"caret\"");
WriteLiteral("></span></a>\r\n                        <ul");
WriteLiteral(" class=\"dropdown-menu\"");
WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<li><a");
WriteLiteral(" href=\"/IQFiles/Manager\"");
WriteLiteral(">File Manager</a></li>\r\n\t\t\t\t\t\t<li");
WriteLiteral(" role=\"separator\"");
WriteLiteral(" class=\"divider\"");
WriteLiteral("></li>\r\n\t\t\t\t\t\t\t\r\n                            <li><a");
WriteLiteral(" href=\"#\"");
WriteLiteral(" onclick=\'javascript:ChangePassword()\'");
WriteLiteral(">Change Password</a></li>\r\n                            \r\n                        " +
"    <li><a");
WriteLiteral(" href=\"/IQSecurity/Logout\"");
WriteLiteral(" class=\'notpjax\'");
WriteLiteral(">Log off</a></li>\r\n                        </ul>\r\n                    </li>\r\n    " +
"                </ul>\r\n            </div>\r\n        </div>\r\n    <div");
WriteLiteral(" class=\"container-fluid body-content\"");
WriteLiteral(" id=\"Main\"");
WriteLiteral(">\r\n");
     if(Request["Message"] != null) {
WriteLiteral("\t<br />\r\n");
WriteLiteral("\t\t<div");
WriteLiteral(" class=\'alert alert-success\'");
WriteLiteral(">");
                                    Write(Request["Message"]);
WriteLiteral("</div>\r\n");
	}
WriteLiteral("\r\n");
WriteLiteral("\t");
Write(RenderBody());
WriteLiteral("</div>\r\n\r\n     <script");
WriteLiteral(" type=\"text/javascript\"");
WriteLiteral(">\r\n        $(document).ready(function () {\r\n        \r\n            $(document).on(" +
"\'pjax:end\', function() {\r\n\t\t\t\tdirty = false;\r\n \t\t\t\tsetTimeout(function() { PostL" +
"oadComplete(); }, 500);\r\n\t\t\t});\r\n");
             if (ViewBag.WebAction != null)
            {
           Write(Html.Raw(ViewBag.WebAction));
            }
WriteLiteral(@"			$(document).ajaxStart(function() {
				ShowLoading();
			});
			$(document).ajaxStop(function() {
				HideLoading();
				EveryRequest();
			});
			PostLoadComplete();
			$(document).on(""click"", ""a[href=#]"", function(ev) {
				ev.preventDefault();
			});
        });
    </script>
<div");
WriteLiteral(" class=\"modal fade\"");
WriteLiteral(" id=\"PopupEditor\"");
WriteLiteral(" role=\"dialog\"");
WriteLiteral(" aria-labelledby=\"PopupEditorLabel\"");
WriteLiteral(">\r\n  <div");
WriteLiteral(" class=\"modal-dialog\"");
WriteLiteral(" role=\"document\"");
WriteLiteral(" style=\'width:100%;\'");
WriteLiteral(">\r\n    <div");
WriteLiteral(" class=\"modal-content\"");
WriteLiteral(">\r\n      <div");
WriteLiteral(" class=\"modal-header\"");
WriteLiteral(">\r\n\t  \t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-primary pull-right\"");
WriteLiteral(" onclick=\'IQPopupEditorClose();\'");
WriteLiteral(" aria-label=\"Close\"");
WriteLiteral(">Done</button>\r\n        <h4");
WriteLiteral(" class=\"modal-title\"");
WriteLiteral(" id=\"PopupEditorLabel\"");
WriteLiteral("></h4>\r\n      </div>\r\n      <div");
WriteLiteral(" class=\"modal-body\"");
WriteLiteral(">\r\n\t\t<textarea");
WriteLiteral(" style=\'width:100%;\'");
WriteLiteral(" rows=\'10\'");
WriteLiteral(" id=\"PopupEditorArea\"");
WriteLiteral("></textarea>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n<div");
WriteLiteral(" class=\"modal fade\"");
WriteLiteral(" id=\'AddAlertScreen\'");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"modal-dialog\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"modal-content\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"modal-header\"");
WriteLiteral(">\r\n\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"close\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(" aria-label=\"Close\"");
WriteLiteral("><span");
WriteLiteral(" aria-hidden=\"true\"");
WriteLiteral(">&times;</span></button>\r\n\t\t<h4");
WriteLiteral(" class=\"modal-title\"");
WriteLiteral(">Add Alert</h4>\r\n\t\t</div>\r\n\t\t<div");
WriteLiteral(" class=\"modal-body\"");
WriteLiteral(">\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><label>User</label></div>\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><select");
WriteLiteral(" name=\'Alert_UserID\'");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(">\r\n");
                     foreach(var itm in IQApp.User.GetUsersAsPairs()) {
WriteLiteral("\t\t\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 5002), Tuple.Create("\'", 5023)
, Tuple.Create(Tuple.Create("", 5010), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 5010), false)
);
WriteLiteral(" ");
                                                  Write(IQApp.User.GetUserId() == itm.KeyValue ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                      Write(itm.Description);
WriteLiteral("</option>\r\n");
					}
WriteLiteral("\t\t\t\t</select>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><label>Date</label></div>\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><input");
WriteLiteral(" type=\'text\'");
WriteLiteral(" class=\'form-control dateBox\'");
WriteLiteral(" name=\'Alert_Date\'");
WriteAttribute("value", Tuple.Create(" value=\'", 5335), Tuple.Create("\'", 5380)
                               , Tuple.Create(Tuple.Create("", 5343), Tuple.Create<System.Object, System.Int32>(DateTime.Now.ToString("dd MMM yyyy")
, 5343), false)
);
WriteLiteral(" /></div>\r\n\t\t\t</div>\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><label>Title</label></div>\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><input");
WriteLiteral(" type=\'text\'");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'Alert_Title\'");
WriteLiteral("  /></div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div");
WriteLiteral(" class=\"modal-footer\"");
WriteLiteral(">\r\n\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(">Close</button>\r\n\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" onclick=\"$(\'form\').attr(\'action\', \'/IQAlerts/AddAlert\');$(\'form\').submit();\"");
WriteLiteral(">Save Alert</button>\r\n\t\t</div>\r\n\t</div><!-- /.modal-content -->\r\n\t</div><!-- /.mo" +
"dal-dialog -->\r\n</div><!-- /.modal -->\r\n\r\n\r\n<div");
WriteLiteral(" class=\"modal fade\"");
WriteLiteral(" id=\'ChangePasswordScreen\'");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"modal-dialog\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"modal-content\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"modal-header\"");
WriteLiteral(">\r\n\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"close\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(" aria-label=\"Close\"");
WriteLiteral("><span");
WriteLiteral(" aria-hidden=\"true\"");
WriteLiteral(">&times;</span></button>\r\n\t\t<h4");
WriteLiteral(" class=\"modal-title\"");
WriteLiteral(">Change Password</h4>\r\n\t\t</div>\r\n\t\t<div");
WriteLiteral(" class=\"modal-body\"");
WriteLiteral(">\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><label>Old Password</label></div>\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><input");
WriteLiteral(" type=\"password\"");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\"OldPassword\"");
WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><label>New Password</label></div>\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><input");
WriteLiteral(" type=\'text\'");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'NewPassword\'");
WriteLiteral(" /></div>\r\n\t\t\t</div>\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><label>New Password (again)</label></div>\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-6\'");
WriteLiteral("><input");
WriteLiteral(" type=\'text\'");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'NewPassword2\'");
WriteLiteral("  /></div>\r\n\t\t\t</div>\r\n\t\t\t<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\'col-sm-12\'");
WriteLiteral("><i>So we can be sure you\'ve entered it correctly</i></div>\r\n\t\t\t</div>\r\n\t\t</div>\r" +
"\n\t\t<div");
WriteLiteral(" class=\"modal-footer\"");
WriteLiteral(">\r\n\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(">Close</button>\r\n\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" onclick=\"$(\'form\').attr(\'action\', \'/IQSecurity/ChangePassword\');$(\'form\').submit" +
"();\"");
WriteLiteral(">Change Password</button>\r\n\t\t</div>\r\n\t</div><!-- /.modal-content -->\r\n\t</div><!--" +
" /.modal-dialog -->\r\n</div><!-- /.modal -->\r\n\r\n\r\n<div");
WriteLiteral(" class=\"modal fade\"");
WriteLiteral(" id=\"FilePickerDialogBox\"");
WriteLiteral(">\r\n  <div");
WriteLiteral(" class=\"modal-dialog\"");
WriteLiteral(">\r\n    <div");
WriteLiteral(" class=\"modal-content\"");
WriteLiteral(">\r\n      <div");
WriteLiteral(" class=\"modal-header\"");
WriteLiteral(">\r\n        <button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"close\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(" aria-label=\"Close\"");
WriteLiteral("><span");
WriteLiteral(" aria-hidden=\"true\"");
WriteLiteral(">&times;</span></button>\r\n        <h4");
WriteLiteral(" class=\"modal-title\"");
WriteLiteral(">Choose or Upload a File - Selected File: <span");
WriteLiteral(" id=\"SelectedFile\"");
WriteLiteral("></span></h4>\r\n      </div>\r\n      <div");
WriteLiteral(" class=\"modal-body\"");
WriteLiteral(">\r\n\t\t<label>Upload File</label>\r\n\t\t<div><div");
WriteLiteral(" class=\'FilePathToUpload\'");
WriteLiteral(" style=\'display:inline-block\'");
WriteLiteral("></div><div");
WriteLiteral(" class=\'display:inline-block\'");
WriteLiteral("><input");
WriteLiteral(" id=\"UploadFile\"");
WriteLiteral(" name=\'UploadedFile\'");
WriteLiteral(" type=\"file\"");
WriteLiteral(" class=\"file form-control\"");
WriteLiteral(" style=\'width:150px;\'");
WriteLiteral(" onchange=\'javascript:UploadFiles()\'");
WriteLiteral(" /></div></div><br />\r\n\t\t<div");
WriteLiteral(" class=\"progress\"");
WriteLiteral(" id=\"FileUploadProgress\"");
WriteLiteral(" style=\'display:none\'");
WriteLiteral(">\r\n  <div");
WriteLiteral(" class=\"progress-bar\"");
WriteLiteral(" role=\"progressbar\"");
WriteLiteral(" aria-valuenow=\"0\"");
WriteLiteral("\r\n  aria-valuemin=\"0\"");
WriteLiteral(" aria-valuemax=\"100\"");
WriteLiteral(" style=\"width:0%\"");
WriteLiteral(">\r\n    <span");
WriteLiteral(" class=\"sr-only\"");
WriteLiteral(">0% Complete</span>\r\n  </div>\r\n</div>\r\n\t\t<hr />\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'directory\'");
WriteLiteral(" />\r\n\t\t<label>Select Existing File / Directory</label>\r\n\t\t<div");
WriteLiteral(" id=\"directoryStructure\"");
WriteLiteral(">\r\n\r\n\t\t</div>\r\n      </div>\r\n      <div");
WriteLiteral(" class=\"modal-footer\"");
WriteLiteral(">\r\n        <button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(">Close</button>\r\n        <button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" id=\'ConfirmFileSelection\'");
WriteLiteral(" onclick=\'FileChosen()\'");
WriteLiteral(" disabled=disabled");
WriteLiteral(">Confirm File Selection</button>\r\n      </div>\r\n    </div><!-- /.modal-content --" +
">\r\n  </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->\r\n\r\n</form>\r\n</body>\r\n" +
"</html>\r\n");
        }
    }
}


public class IQSettings : ISettings {

	public string DataModelNamespace => "FTL";
	public string RelativeFileStoragePath { get { return "/files/"; } }
	public string IQ6DirectoryName { get { return "IQ6";}}
	public  string SMTPHost  => "email-smtp.us-east-1.amazonaws.com";
    public int SMTPPort => 25;
    public string SMTPUser => "AKIAIWJZNFO5DZAYT5NQ";
    public string SMTPPass => "Anmq3wPsRKStJfOYg0Qx0CRvWT1t3xklX8EfXnDtltL5";
    public bool SMTPSSL => true;
	public string RootUrl => "/";

	public string InterfacesSQL { get 
		{
			return @"
			 
				IF EXISTS(select * from sys.views where name='Intrinsiq_Email_IEMail')
					DROP VIEW Intrinsiq_Email_IEMail
				GO

				CREATE VIEW Intrinsiq_Email_IEMail AS 
						SELECT RecordID as RecordID
				,EMId as [Id],EMName as [TemplateId],EMFrom as [FromAddress],EMDS as [Dataset],EMTo as [ToAddress],EMCC as [CCAddress],EMSubject as [Subject],EMBody as [Body],EMAttach as [Attachments],EMToRecords as [ToRecords],EMDF as [DataField],EMCCRecords as [CCRecords],EMBCC as [BCCAddress],EMBCCRecords as [BCCRecords] from EMail
				GO
				 
				IF EXISTS(select * from sys.views where name='Intrinsiq_WordDocument_IWordDocument')
					DROP VIEW Intrinsiq_WordDocument_IWordDocument
				GO

				CREATE VIEW Intrinsiq_WordDocument_IWordDocument AS 
						SELECT RecordID as RecordID
				,WrDocId as [Id],WrDocTemplate as [TemplateFile],WrDocTitle as [Name],WrDocDataset as [Dataset],WrDocQuery as [Query],WrDocCategory as [Category] from WordDocument
				GO
				 
				IF EXISTS(select * from sys.views where name='Intrinsiq_Query_IDynamicQuery')
					DROP VIEW Intrinsiq_Query_IDynamicQuery
				GO

				CREATE VIEW Intrinsiq_Query_IDynamicQuery AS 
						SELECT RecordID as RecordID
				,QryId as [Id],QryName as [Name],QryContent as [Content],QryPrimaryDS as [Dataset],QryScreen as [Screen],QryType as [Type],QryCategory as [Category],QryRelationships as [Relationships] from Query
				GO
				 
				IF EXISTS(select * from sys.views where name='Intrinsiq_Email_IEmailTemplate')
					DROP VIEW Intrinsiq_Email_IEmailTemplate
				GO

				CREATE VIEW Intrinsiq_Email_IEmailTemplate AS 
						SELECT RecordID as RecordID
				,EMTId as [Id],EMTName as [Name],EMTBody as [Body],EMTSubject as [Subject],EMTFromAddr as [FromAddress],EMTToAddr as [ToAddress],EMTCCAddr as [CCAddress],EMTBCCAddr as [BCCAddress],EMTQuery as [Query] from EmailTemplatess
				GO
				 
				IF EXISTS(select * from sys.views where name='FTL_UserAuthentication_IUserObj')
					DROP VIEW FTL_UserAuthentication_IUserObj
				GO

				CREATE VIEW FTL_UserAuthentication_IUserObj AS 
						SELECT RecordID as RecordID
				,StfId as [Id],StfName as [FullName],StfUsername as [Username],StfPassword as [Password],StfEM as [Email],StfSG as [SecGroup] from Staff
				GO
				 
				IF EXISTS(select * from sys.views where name='Intrinsiq_SMS_ISMS')
					DROP VIEW Intrinsiq_SMS_ISMS
				GO

				CREATE VIEW Intrinsiq_SMS_ISMS AS 
						SELECT RecordID as RecordID
				 from SMS
				GO
				 
				IF EXISTS(select * from sys.views where name='Intrinsiq_Alerts_IAlert')
					DROP VIEW Intrinsiq_Alerts_IAlert
				GO

				CREATE VIEW Intrinsiq_Alerts_IAlert AS 
						SELECT RecordID as RecordID
				,AlrtId as [Id],AlrtUserID as [User],AlrtData as [Data],AlrtTitle as [Title],AlrtQueueDate as [QueueDate],AlrtCompletedDat as [CompletedDate],AlrtCallbackUrl as [Callback] from Alerts
				GO
				 
				IF EXISTS(select * from sys.views where name='Intrinsiq_Reporting_IReportRecord')
					DROP VIEW Intrinsiq_Reporting_IReportRecord
				GO

				CREATE VIEW Intrinsiq_Reporting_IReportRecord AS 
						SELECT RecordID as RecordID
				,RptId as [Id],RptTitle as [Title],RptContent as [Content],RptDataset as [Dataset] from Reporting
				GO
							";
		}

	}
}


		
public class Operators : IOperatorManager { 

	public string GetClause(int Op, string DFName, string varName, ref string Val) {
		switch(Op) {
							case 1:
										return "<FIELD> < <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 2:
										return "<FIELD> <= <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 3:
										return "<FIELD> != '<VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 4:
										return "<FIELD> = <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 5:
										return "<FIELD> > <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 6:
										return "<FIELD> >= <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 7:
										return "<FIELD> is not null".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 8:
										return "<FIELD> is null".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 9:
										return "<FIELD> < <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 10:
										return "<FIELD> = <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 11:
										return "<FIELD> > <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 12:
										return "<FIELD> is not null".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 13:
										return "<FIELD> is null".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 14:
					Val = "%<VALUE>%".Replace("<VALUE>", Val);					return "<FIELD> like <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 15:
					Val = "%<VALUE>%".Replace("<VALUE>", Val);					return "<FIELD> not like <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 16:
					Val = "VALUE%".Replace("<VALUE>", Val);					return "<FIELD> like <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 17:
										return "<FIELD> != <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 18:
										return "<FIELD> = <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 19:
										return "(<FIELD> = '0' or <FIELD> = '')".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 20:
										return "(<FIELD> > '0' or <FIELD> != '')".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 21:
										return "".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 22:
										return "<FIELD> = 0".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 23:
										return "<FIELD> = 1".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 24:
										return "<FIELD> in (<VALUE>)".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 25:
										return "<FIELD> not in (<VALUE>)".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 27:
										return "<FIELD> = <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
							case 28:
										return "<FIELD> != <VALUE>".Replace("<FIELD>", DFName).Replace("<VALUE>", varName);
					}
		return "";
	}

	public string GetNumberOperators(int selectedItem) {
		string ret = "";
					ret += "<option value='1' " + (selectedItem == 1 ? "selected=selected" : "") + ">less than</option>";
					ret += "<option value='2' " + (selectedItem == 2 ? "selected=selected" : "") + "><=</option>";
					ret += "<option value='3' " + (selectedItem == 3 ? "selected=selected" : "") + ">not equal</option>";
					ret += "<option value='4' " + (selectedItem == 4 ? "selected=selected" : "") + ">equal</option>";
					ret += "<option value='5' " + (selectedItem == 5 ? "selected=selected" : "") + ">greater than</option>";
					ret += "<option value='6' " + (selectedItem == 6 ? "selected=selected" : "") + ">>=</option>";
					ret += "<option value='7' " + (selectedItem == 7 ? "selected=selected" : "") + ">Is Not Null</option>";
					ret += "<option value='8' " + (selectedItem == 8 ? "selected=selected" : "") + ">Is Null</option>";
					ret += "<option value='24' " + (selectedItem == 24 ? "selected=selected" : "") + ">in</option>";
					ret += "<option value='25' " + (selectedItem == 25 ? "selected=selected" : "") + ">not in</option>";
				return ret;
	}
	public string GetBooleanOperators(int selectedItem) {
		string ret = "";
					ret += "<option value='21' " + (selectedItem == 21 ? "selected=selected" : "") + ">Is Either</option>";
					ret += "<option value='22' " + (selectedItem == 22 ? "selected=selected" : "") + ">Is No/False</option>";
					ret += "<option value='23' " + (selectedItem == 23 ? "selected=selected" : "") + ">Is Yes/True</option>";
				return ret;
	}
	public string GetComboOperators(int selectedItem) {
		string ret = "";
					ret += "<option value='17' " + (selectedItem == 17 ? "selected=selected" : "") + ">not equal</option>";
					ret += "<option value='18' " + (selectedItem == 18 ? "selected=selected" : "") + ">equal</option>";
					ret += "<option value='19' " + (selectedItem == 19 ? "selected=selected" : "") + ">Is Blank</option>";
					ret += "<option value='20' " + (selectedItem == 20 ? "selected=selected" : "") + ">Is Not Blank</option>";
				return ret;
	}
	public string GetTextOperators(int selectedItem) {
		string ret = "";
					ret += "<option value='9' " + (selectedItem == 9 ? "selected=selected" : "") + ">less than</option>";
					ret += "<option value='10' " + (selectedItem == 10 ? "selected=selected" : "") + ">equal</option>";
					ret += "<option value='11' " + (selectedItem == 11 ? "selected=selected" : "") + ">greater than</option>";
					ret += "<option value='12' " + (selectedItem == 12 ? "selected=selected" : "") + ">Is Not Null</option>";
					ret += "<option value='13' " + (selectedItem == 13 ? "selected=selected" : "") + ">Is Null</option>";
					ret += "<option value='14' " + (selectedItem == 14 ? "selected=selected" : "") + ">Like</option>";
					ret += "<option value='15' " + (selectedItem == 15 ? "selected=selected" : "") + ">Not Like</option>";
					ret += "<option value='16' " + (selectedItem == 16 ? "selected=selected" : "") + ">Starts With</option>";
				return ret;
	}
	
}



	
	public class IQSearchController : IQController {
		private class IQSearchRes {
			public string label { get;set;}
			public string id { get;set;}
			public int DSID { get;set;}
		}
		public ActionResult Search(string q) {
			string sql = @"
			select * from (
				select '' as id, '' as label, '' as SearchField, 0 as DSID 
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustSortCode] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustType] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustVATNo] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustDANNo] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustBondCode] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustIntrastat] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCurr] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustRates] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustGenNotes] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContId] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContFN] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContSN] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContPhone] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContFax] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContEM] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContJobTitle] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContNotes] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdExpImp] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdId] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCustOrd] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDate] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdStatus] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdReqDate] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdSupp] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdSupPC] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCollPoint] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCollPointPC] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdSuppRef] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdConsign] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdConsignPC] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDelPoint] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDelPointPC] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdVATPaidBy] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdVATNo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDANNoFrom] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDANNo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdBondFrom] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdBondCode] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCust] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCustPC] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDateAvail] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdJob] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCollDate] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCollDate2] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDateDel] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLOrder] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLLineNo] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLQty] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLPackageType] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLSize] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLDesc] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLWeight] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLNumPallet] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLPalletType] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobNo] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobTransp] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobTranspRate] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobVehNo] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobTrailerNo] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobFerryName] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobFerryDate] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobFerryTime] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobRouteFrom] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobRouteTo] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/FerryRoute/Load/?RecId=' + cast(RecordID as varchar), 
				'[Ferry Routes] ' + cast([FRName] as varchar) as label, 
				cast([FRCode] as varchar) as SearchField, 10 as DSID from [FerryRoute]
							union select '/FerryRoute/Load/?RecId=' + cast(RecordID as varchar), 
				'[Ferry Routes] ' + cast([FRName] as varchar) as label, 
				cast([FRName] as varchar) as SearchField, 10 as DSID from [FerryRoute]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLJobNo] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLLineLetter] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLOrder] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLCust] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLCollDate] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLCollDate2] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvId] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvFreightDuty] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvJobNo] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvOrder] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvVehicle] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvTrailer] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvRouteFrom] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvRouteTo] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvFerryName] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvFerryDate] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvFerryTime] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvTo] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvDesc] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvNet] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvVAT] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvTotal] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvNote1] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvNote2] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvNote3] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/InvComment/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Comments] ' + cast([InvCId] as varchar) as label, 
				cast([InvCId] as varchar) as SearchField, 11 as DSID from [InvComment]
							union select '/InvComment/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Comments] ' + cast([InvCId] as varchar) as label, 
				cast([InvCName] as varchar) as SearchField, 11 as DSID from [InvComment]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLInvNo] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLLineNo] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLDesc] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLVATCode] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLVATRate] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLAmt] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLVATAmt] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLTotal] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/VATCodes/Load/?RecId=' + cast(RecordID as varchar), 
				'[VAT Codes] ' + cast([VATCode] as varchar) as label, 
				cast([VATCode] as varchar) as SearchField, 12 as DSID from [VATCodes]
							union select '/VATCodes/Load/?RecId=' + cast(RecordID as varchar), 
				'[VAT Codes] ' + cast([VATCode] as varchar) as label, 
				cast([VATName] as varchar) as SearchField, 12 as DSID from [VATCodes]
							union select '/VATCodes/Load/?RecId=' + cast(RecordID as varchar), 
				'[VAT Codes] ' + cast([VATCode] as varchar) as label, 
				cast([VATRate] as varchar) as SearchField, 12 as DSID from [VATCodes]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvDate] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOId] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOCollDate] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOCustRef] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOCust] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOCollFrom] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKODelTo] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKODesc] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOQty] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOTransp] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOChargeCust] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOFTLCost] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKODelProof] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOJobNo] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKONotes] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContMainContact] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdNotes] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustLang] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdJobNo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdJobLetter] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvPrintBatch] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLDelPoint] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLDelDate] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLDelTime] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/JobLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Lines] ' + cast([JobLJobNo] as varchar) as label, 
				cast([JobLDelRef] as varchar) as SearchField, 5 as DSID from [JobLine]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvJobLetter] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCJobNo] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCServProvId] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCServProv] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCDesc] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCInvAmt] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCInvNo] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/JobCost/Load/?RecId=' + cast(RecordID as varchar), 
				'[Job Costs] ' + cast([JobCJobNo] as varchar) as label, 
				cast([JobCInvDate] as varchar) as SearchField, 14 as DSID from [JobCost]
							union select '/InvLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Lines] ' + cast([InvLInvNo] as varchar) as label, 
				cast([InvLChargeType] as varchar) as SearchField, 7 as DSID from [InvLine]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvToExport] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvExported] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvCustOrd] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvToId] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdInvoiced] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdFreightInv] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSId] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSJobNo] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSJobLetter] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSOrder] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSCust] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSCustOrd] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSDelPoint] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSGoodsDesc] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSWeight] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSVehicle] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSRoute] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSShip] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSDate] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/CertShip/Load/?RecId=' + cast(RecordID as varchar), 
				'[Certificates of Shipment] ' + cast([CSId] as varchar) as label, 
				cast([CSTime] as varchar) as SearchField, 15 as DSID from [CertShip]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdTimeAvail] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustSendStatus] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOWeight] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDutyInv] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobAccMonth] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvImpExp] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustFTLNotes] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNId] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNImpExp] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNJobNo] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNOrder] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNVehicle] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNTrailer] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNRouteFrom] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNRouteTo] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNTo] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNToId] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNDesc] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNNet] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNVAT] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNTotal] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNNote1] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNNote2] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNDate] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNPrintBatch] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNJobLetter] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNToExport] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNExported] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNCustOrd] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLNo] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLLineNo] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLDesc] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLVATCode] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLVATRate] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLAmt] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLVATAmt] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLTotal] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/CNLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Note Lines] ' + cast([CNLNo] as varchar) as label, 
				cast([CNLChargeType] as varchar) as SearchField, 16 as DSID from [CNLine]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvId] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvName] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvVehicle] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOInvoiced] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobChecked] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvAddr] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvTown] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvPC] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdPriceAllowed] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdReqdChanged] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdAvailChanged] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCollChanged] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDelChanged] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustOnFTrack] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNDutyCN] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvCurr] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvExchRate] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/ExchRate/Load/?RecId=' + cast(RecordID as varchar), 
				'[Exchange Rates] ' + cast([ExRName] as varchar) as label, 
				cast([ExRId] as varchar) as SearchField, 18 as DSID from [ExchRate]
							union select '/ExchRate/Load/?RecId=' + cast(RecordID as varchar), 
				'[Exchange Rates] ' + cast([ExRName] as varchar) as label, 
				cast([ExRName] as varchar) as SearchField, 18 as DSID from [ExchRate]
							union select '/ExchRate/Load/?RecId=' + cast(RecordID as varchar), 
				'[Exchange Rates] ' + cast([ExRName] as varchar) as label, 
				cast([ExRRate] as varchar) as SearchField, 18 as DSID from [ExchRate]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNCurr] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/CN/Load/?RecId=' + cast(RecordID as varchar), 
				'[Credit Notes] ' + cast([CNId] as varchar) as label, 
				cast([CNExchRate] as varchar) as SearchField, 8 as DSID from [CN]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlFleetNo] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlLastServ] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlNextServDue] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlDaysRem] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlLastMOT] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlNextMOTDue] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlStatus] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlNotes] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdTescoRef] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvTescoRef] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvBelongsPInv] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvISPInv] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/PeriodInv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Period Inv Includes] ' + cast([PInvId] as varchar) as label, 
				cast([PInvId] as varchar) as SearchField, 20 as DSID from [PeriodInv]
							union select '/PeriodInv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Period Inv Includes] ' + cast([PInvId] as varchar) as label, 
				cast([PInvName] as varchar) as SearchField, 20 as DSID from [PeriodInv]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvSDate] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/DriverHrs/Load/?RecId=' + cast(RecordID as varchar), 
				'[Driver Hours] ' + cast([DrvHDriver] as varchar) as label, 
				cast([DrvHDriver] as varchar) as SearchField, 22 as DSID from [DriverHrs]
							union select '/DriverHrs/Load/?RecId=' + cast(RecordID as varchar), 
				'[Driver Hours] ' + cast([DrvHDriver] as varchar) as label, 
				cast([DrvHWk] as varchar) as SearchField, 22 as DSID from [DriverHrs]
							union select '/DriverHrs/Load/?RecId=' + cast(RecordID as varchar), 
				'[Driver Hours] ' + cast([DrvHDriver] as varchar) as label, 
				cast([DrvHHrs] as varchar) as SearchField, 22 as DSID from [DriverHrs]
							union select '/Week/Load/?RecId=' + cast(RecordID as varchar), 
				'[Weeks] ' + cast([WkId] as varchar) as label, 
				cast([WkId] as varchar) as SearchField, 21 as DSID from [Week]
							union select '/Week/Load/?RecId=' + cast(RecordID as varchar), 
				'[Weeks] ' + cast([WkId] as varchar) as label, 
				cast([WkSDate] as varchar) as SearchField, 21 as DSID from [Week]
							union select '/Week/Load/?RecId=' + cast(RecordID as varchar), 
				'[Weeks] ' + cast([WkId] as varchar) as label, 
				cast([WkEDate] as varchar) as SearchField, 21 as DSID from [Week]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvActive] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Week/Load/?RecId=' + cast(RecordID as varchar), 
				'[Weeks] ' + cast([WkId] as varchar) as label, 
				cast([WkBelongsTo] as varchar) as SearchField, 21 as DSID from [Week]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustDelZone] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCreatedBy] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobCreatedBy] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/UKOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[UK Orders] ' + cast([UKOId] as varchar) as label, 
				cast([UKOCreatedBy] as varchar) as SearchField, 9 as DSID from [UKOrder]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCreatedBy] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/InvBatch/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Batches] ' + cast([InvBId] as varchar) as label, 
				cast([InvBId] as varchar) as SearchField, 23 as DSID from [InvBatch]
							union select '/InvBatch/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Batches] ' + cast([InvBId] as varchar) as label, 
				cast([InvBType] as varchar) as SearchField, 23 as DSID from [InvBatch]
							union select '/InvBatch/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Batches] ' + cast([InvBId] as varchar) as label, 
				cast([InvBPrintedOn] as varchar) as SearchField, 23 as DSID from [InvBatch]
							union select '/InvBatch/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Batches] ' + cast([InvBId] as varchar) as label, 
				cast([InvBExportedDate] as varchar) as SearchField, 23 as DSID from [InvBatch]
							union select '/InvBatch/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoice Batches] ' + cast([InvBId] as varchar) as label, 
				cast([InvBExported] as varchar) as SearchField, 23 as DSID from [InvBatch]
							union select '/PackageType/Load/?RecId=' + cast(RecordID as varchar), 
				'[Package Types] ' + cast([PackName] as varchar) as label, 
				cast([PackId] as varchar) as SearchField, 26 as DSID from [PackageType]
							union select '/PackageType/Load/?RecId=' + cast(RecordID as varchar), 
				'[Package Types] ' + cast([PackName] as varchar) as label, 
				cast([PackName] as varchar) as SearchField, 26 as DSID from [PackageType]
							union select '/BottleSize/Load/?RecId=' + cast(RecordID as varchar), 
				'[Bottle Sizes] ' + cast([BSzSize] as varchar) as label, 
				cast([BSzId] as varchar) as SearchField, 27 as DSID from [BottleSize]
							union select '/BottleSize/Load/?RecId=' + cast(RecordID as varchar), 
				'[Bottle Sizes] ' + cast([BSzSize] as varchar) as label, 
				cast([BSzSize] as varchar) as SearchField, 27 as DSID from [BottleSize]
							union select '/PalletType/Load/?RecId=' + cast(RecordID as varchar), 
				'[Pallet Types] ' + cast([PallName] as varchar) as label, 
				cast([PallId] as varchar) as SearchField, 28 as DSID from [PalletType]
							union select '/PalletType/Load/?RecId=' + cast(RecordID as varchar), 
				'[Pallet Types] ' + cast([PallName] as varchar) as label, 
				cast([PallName] as varchar) as SearchField, 28 as DSID from [PalletType]
							union select '/BottleSize/Load/?RecId=' + cast(RecordID as varchar), 
				'[Bottle Sizes] ' + cast([BSzSize] as varchar) as label, 
				cast([BSzOrder] as varchar) as SearchField, 27 as DSID from [BottleSize]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvProforma] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/OrderLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[Order Lines] ' + cast([OrdLOrder] as varchar) as label, 
				cast([OrdLCustOrd] as varchar) as SearchField, 3 as DSID from [OrderLine]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustEM2] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustEM3] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustEM4] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdEMTo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdFaxTo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdAgentId] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdAgent] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/ExchRate/Load/?RecId=' + cast(RecordID as varchar), 
				'[Exchange Rates] ' + cast([ExRName] as varchar) as label, 
				cast([ExRSDate] as varchar) as SearchField, 18 as DSID from [ExchRate]
							union select '/ExchRate/Load/?RecId=' + cast(RecordID as varchar), 
				'[Exchange Rates] ' + cast([ExRName] as varchar) as label, 
				cast([ExREDate] as varchar) as SearchField, 18 as DSID from [ExchRate]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustAADSys] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdAADSys] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdARCRef] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustGBWK] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/EADNum/Load/?RecId=' + cast(RecordID as varchar), 
				'[eAD Numbers] ' + cast([EADNo] as varchar) as label, 
				cast([EADNo] as varchar) as SearchField, 29 as DSID from [EADNum]
							union select '/EADNum/Load/?RecId=' + cast(RecordID as varchar), 
				'[eAD Numbers] ' + cast([EADNo] as varchar) as label, 
				cast([EADOrder] as varchar) as SearchField, 29 as DSID from [EADNum]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdGBWKNoFrom] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdGBWKNo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdTescoPSWk] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDId] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDSuppId] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDSupp] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDSuppAddr] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDSuppVATNo] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDTransRef] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDCompAuth] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDRecipId] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDRecip] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDRecipAddr] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDRecipVATNo] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDRefNo] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDDeclareDate] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDDelPlace] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDDesc] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDCommCode1] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDQty1] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDGWeight1] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDNWeight1] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDValue1] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDDesc2] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDCommCode2] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDQty2] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDGWeight2] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDNWeight2] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDValue2] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDDesc3] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDCommCode3] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDQty3] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDGWeight3] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDNWeight3] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDValue3] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDDesc4] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDCommCode4] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDQty4] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDGWeight4] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDNWeight4] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDValue4] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDRecordControl] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDSignedBy] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDSignedByText] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDVehNo] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDCurr] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/ShipDoc/Load/?RecId=' + cast(RecordID as varchar), 
				'[Shipping Documents] ' + cast([SDId] as varchar) as label, 
				cast([SDHMRCDets] as varchar) as SearchField, 30 as DSID from [ShipDoc]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkId] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkName] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkNotes] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMTruck] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMPurchDate] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMPurchLitre] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMOdometer] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMNotes] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMNextReading] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/TruckMileage/Load/?RecId=' + cast(RecordID as varchar), 
				'[Truck Fuel / Mileage] ' + cast([TrkMTruck] as varchar) as label, 
				cast([TrkMMpg] as varchar) as SearchField, 32 as DSID from [TruckMileage]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvSentTradeshift] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCollectCtry] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustId] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustName] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustAddr] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustAddr2] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustAddr3] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustTown] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCounty] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustPC] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCtry] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustPhone] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustFax] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustEM] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Country/Load/?RecId=' + cast(RecordID as varchar), 
				'[Countries] ' + cast([CtryName] as varchar) as label, 
				cast([CtryId] as varchar) as SearchField, 34 as DSID from [Country]
							union select '/Country/Load/?RecId=' + cast(RecordID as varchar), 
				'[Countries] ' + cast([CtryName] as varchar) as label, 
				cast([CtryCode] as varchar) as SearchField, 34 as DSID from [Country]
							union select '/Country/Load/?RecId=' + cast(RecordID as varchar), 
				'[Countries] ' + cast([CtryName] as varchar) as label, 
				cast([CtryName] as varchar) as SearchField, 34 as DSID from [Country]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContCust] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Contact/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customer Contacts] ' + cast([ContName] as varchar) as label, 
				cast([ContName] as varchar) as SearchField, 1 as DSID from [Contact]
							union select '/Week/Load/?RecId=' + cast(RecordID as varchar), 
				'[Weeks] ' + cast([WkId] as varchar) as label, 
				cast([WkSDateText] as varchar) as SearchField, 21 as DSID from [Week]
							union select '/Week/Load/?RecId=' + cast(RecordID as varchar), 
				'[Weeks] ' + cast([WkId] as varchar) as label, 
				cast([WkEDateText] as varchar) as SearchField, 21 as DSID from [Week]
							union select '/Job/Load/?RecId=' + cast(RecordID as varchar), 
				'[Jobs] ' + cast([JobNo] as varchar) as label, 
				cast([JobId] as varchar) as SearchField, 4 as DSID from [Job]
							union select '/FerryRoute/Load/?RecId=' + cast(RecordID as varchar), 
				'[Ferry Routes] ' + cast([FRName] as varchar) as label, 
				cast([FRId] as varchar) as SearchField, 10 as DSID from [FerryRoute]
							union select '/VATCodes/Load/?RecId=' + cast(RecordID as varchar), 
				'[VAT Codes] ' + cast([VATCode] as varchar) as label, 
				cast([VATId] as varchar) as SearchField, 12 as DSID from [VATCodes]
							union select '/Trailer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trailers] ' + cast([TrlFleetNo] as varchar) as label, 
				cast([TrlId] as varchar) as SearchField, 19 as DSID from [Trailer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustUserName] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustPassword] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdId] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdCustId] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdDANNo] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdJobNo] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdJobLetter] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdCustOrd] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdArrDate] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdDelDate] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLRDId] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLLineNo] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLCases] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLBottleCase] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLBottleSize] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLTaxCode] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdOrder] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdCust] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLAlcPct] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLLitres] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLDutyDue] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSOrdLine/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Lines] ' + cast([RDOLRDId] as varchar) as label, 
				cast([RDOLLocked] as varchar) as SearchField, 36 as DSID from [REDSOrdLine]
							union select '/REDSTax/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Tax Codes] ' + cast([RDTaxCode] as varchar) as label, 
				cast([RDTaxCode] as varchar) as SearchField, 37 as DSID from [REDSTax]
							union select '/REDSTax/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Tax Codes] ' + cast([RDTaxCode] as varchar) as label, 
				cast([RDTaxAlcPct] as varchar) as SearchField, 37 as DSID from [REDSTax]
							union select '/REDSTax/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Tax Codes] ' + cast([RDTaxCode] as varchar) as label, 
				cast([RDTaxType] as varchar) as SearchField, 37 as DSID from [REDSTax]
							union select '/REDSTax/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Tax Codes] ' + cast([RDTaxCode] as varchar) as label, 
				cast([RDTaxDutyRate] as varchar) as SearchField, 37 as DSID from [REDSTax]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdInvCreated] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/DutyRateHist/Load/?RecId=' + cast(RecordID as varchar), 
				'[Duty Rate History] ' + cast([DRHTaxCode] as varchar) as label, 
				cast([DRHTaxCode] as varchar) as SearchField, 38 as DSID from [DutyRateHist]
							union select '/DutyRateHist/Load/?RecId=' + cast(RecordID as varchar), 
				'[Duty Rate History] ' + cast([DRHTaxCode] as varchar) as label, 
				cast([DRHChangeDate] as varchar) as SearchField, 38 as DSID from [DutyRateHist]
							union select '/DutyRateHist/Load/?RecId=' + cast(RecordID as varchar), 
				'[Duty Rate History] ' + cast([DRHTaxCode] as varchar) as label, 
				cast([DRHDutyRate] as varchar) as SearchField, 38 as DSID from [DutyRateHist]
							union select '/DutyRateHist/Load/?RecId=' + cast(RecordID as varchar), 
				'[Duty Rate History] ' + cast([DRHTaxCode] as varchar) as label, 
				cast([DRHAlcPct] as varchar) as SearchField, 38 as DSID from [DutyRateHist]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdDesc] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdLocked] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdDutyPaid] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdARCNo] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSOrder/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Order Header] ' + cast([RDOrdId] as varchar) as label, 
				cast([RDOrdHM10] as varchar) as SearchField, 35 as DSID from [REDSOrder]
							union select '/REDSEAD/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS eAD Numbers] ' + cast([RDEADId] as varchar) as label, 
				cast([RDEADId] as varchar) as SearchField, 39 as DSID from [REDSEAD]
							union select '/REDSEAD/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS eAD Numbers] ' + cast([RDEADId] as varchar) as label, 
				cast([RDEADRDId] as varchar) as SearchField, 39 as DSID from [REDSEAD]
							union select '/REDSTax/Load/?RecId=' + cast(RecordID as varchar), 
				'[REDS Tax Codes] ' + cast([RDTaxCode] as varchar) as label, 
				cast([RDTaxId] as varchar) as SearchField, 37 as DSID from [REDSTax]
							union select '/DutyRateHist/Load/?RecId=' + cast(RecordID as varchar), 
				'[Duty Rate History] ' + cast([DRHTaxCode] as varchar) as label, 
				cast([DRHId] as varchar) as SearchField, 38 as DSID from [DutyRateHist]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStId] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStOrder] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStCustId] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStCust] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStSuppId] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStSupp] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStCustOrd] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStJobNo] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStDate] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStCommCode] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStInvVal] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStInvCurr] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStSterlingVal] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStProcessed] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStDelTerms] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStNAT1] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStNAT2] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStMass] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStSuppUnitVal] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStSuppUnitType] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStConsignCtry] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStTranspMode] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStInvNo] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStOriginCtry] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStMonth] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStMonthDec] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/Months/Load/?RecId=' + cast(RecordID as varchar), 
				'[Months] ' + cast([MthName] as varchar) as label, 
				cast([MthId] as varchar) as SearchField, 42 as DSID from [Months]
							union select '/Months/Load/?RecId=' + cast(RecordID as varchar), 
				'[Months] ' + cast([MthName] as varchar) as label, 
				cast([MthName] as varchar) as SearchField, 42 as DSID from [Months]
							union select '/Months/Load/?RecId=' + cast(RecordID as varchar), 
				'[Months] ' + cast([MthName] as varchar) as label, 
				cast([MthSDate] as varchar) as SearchField, 42 as DSID from [Months]
							union select '/Months/Load/?RecId=' + cast(RecordID as varchar), 
				'[Months] ' + cast([MthName] as varchar) as label, 
				cast([MthEDate] as varchar) as SearchField, 42 as DSID from [Months]
							union select '/IStatRec/Load/?RecId=' + cast(RecordID as varchar), 
				'[Intrastat Records] ' + cast([IStId] as varchar) as label, 
				cast([IStRatePeriod] as varchar) as SearchField, 40 as DSID from [IStatRec]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRId] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRName] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRType] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRPriority] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRStatus] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRDate] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRClosed] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRIssues] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRIqNotes] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRResolved] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/ChangeReq/Load/?RecId=' + cast(RecordID as varchar), 
				'[Change Requests] ' + cast([CRName] as varchar) as label, 
				cast([CRIqNotesArch] as varchar) as SearchField, 43 as DSID from [ChangeReq]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdSelEMTo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdSelFaxTo] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustDueDiligence] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCredScoreSearch] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCredScore] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCredScoreReview] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMId] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMName] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMFrom] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMDS] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMTo] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMCC] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMSubject] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMBody] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMAttach] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMStatus] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMDateSent] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdConsOrd] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustWebsite] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdCustName] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocId] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocTemplate] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocTitle] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocDataset] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryId] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryName] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QrySysName] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryContent] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryPrimaryDS] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMToRecords] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMDF] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMCCRecords] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMBCC] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/EMail/Load/?RecId=' + cast(RecordID as varchar), 
				'[E-mails] ' + cast([EMSubject] as varchar) as label, 
				cast([EMBCCRecords] as varchar) as SearchField, 45 as DSID from [EMail]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocQuery] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryScreen] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTId] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTName] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTBody] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTSubject] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTFromAddr] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTToAddr] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTCCAddr] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTBCCAddr] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/EmailTemplatess/Load/?RecId=' + cast(RecordID as varchar), 
				'[Email Templates] ' + cast([EMTName] as varchar) as label, 
				cast([EMTQuery] as varchar) as SearchField, 50 as DSID from [EmailTemplatess]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfId] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfFN] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfSN] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfName] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfUsername] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfPassword] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfEM] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/Staff/Load/?RecId=' + cast(RecordID as varchar), 
				'[Staff] ' + cast([StfName] as varchar) as label, 
				cast([StfSG] as varchar) as SearchField, 51 as DSID from [Staff]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocCategory] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocQueryType] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocBuiltInQuery] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSId] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSContent] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSDestination] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSDataset] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSRecordID] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSDateQueued] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSDateConfirmed] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSStatus] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSStatusMsg] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTId] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTContent] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTDestination] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTName] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTDataset] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTSender] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSSender] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/SMS/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS] ' + cast([SMSDestination] as varchar) as label, 
				cast([SMSTemplate] as varchar) as SearchField, 52 as DSID from [SMS]
							union select '/Orders/Load/?RecId=' + cast(RecordID as varchar), 
				'[Orders] ' + cast([OrdId] as varchar) as label, 
				cast([OrdDelRef] as varchar) as SearchField, 2 as DSID from [Orders]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkMOTDate] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkTAXDate] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkDriver] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvPspExpiry] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustRecDueDil] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCrdChecked] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCrdScr] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustCrdRvDate] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtId] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtUserID] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtData] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtTitle] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtQueueDate] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtCompletedDat] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Alerts/Load/?RecId=' + cast(RecordID as varchar), 
				'[Alerts] ' + cast([AlrtTitle] as varchar) as label, 
				cast([AlrtCallbackUrl] as varchar) as SearchField, 54 as DSID from [Alerts]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryType] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/WordDocument/Load/?RecId=' + cast(RecordID as varchar), 
				'[Word Document] ' + cast([WrDocTitle] as varchar) as label, 
				cast([WrDocUseSimple] as varchar) as SearchField, 46 as DSID from [WordDocument]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvMobile] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Inv/Load/?RecId=' + cast(RecordID as varchar), 
				'[Invoices] ' + cast([InvId] as varchar) as label, 
				cast([InvSentToClient] as varchar) as SearchField, 6 as DSID from [Inv]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustAccContact] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/Customer/Load/?RecId=' + cast(RecordID as varchar), 
				'[Customers] ' + cast([CustName] as varchar) as label, 
				cast([CustAccEmail] as varchar) as SearchField, 33 as DSID from [Customer]
							union select '/SMSTemplate/Load/?RecId=' + cast(RecordID as varchar), 
				'[SMS Template] ' + cast([SMSTName] as varchar) as label, 
				cast([SMSTQuery] as varchar) as SearchField, 53 as DSID from [SMSTemplate]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryCategory] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/Query/Load/?RecId=' + cast(RecordID as varchar), 
				'[Query] ' + cast([QryName] as varchar) as label, 
				cast([QryRelationships] as varchar) as SearchField, 47 as DSID from [Query]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvAddress] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvDoB] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvEmpStart] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvLicense] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvTacho] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvCPC] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvPpNo] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Driver/Load/?RecId=' + cast(RecordID as varchar), 
				'[Drivers] ' + cast([DrvName] as varchar) as label, 
				cast([DrvNextOfKin] as varchar) as SearchField, 17 as DSID from [Driver]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkServiceDue] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkAS24No] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkAS24PIN] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkDKVNo] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkDKVPIN] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkShellNo] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkShellPIN] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkPermitNo] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Truck/Load/?RecId=' + cast(RecordID as varchar), 
				'[Trucks] ' + cast([TrkName] as varchar) as label, 
				cast([TrkTruckMob] as varchar) as SearchField, 31 as DSID from [Truck]
							union select '/Reporting/Load/?RecId=' + cast(RecordID as varchar), 
				'[Reporting] ' + cast([RptTitle] as varchar) as label, 
				cast([RptId] as varchar) as SearchField, 56 as DSID from [Reporting]
							union select '/Reporting/Load/?RecId=' + cast(RecordID as varchar), 
				'[Reporting] ' + cast([RptTitle] as varchar) as label, 
				cast([RptTitle] as varchar) as SearchField, 56 as DSID from [Reporting]
							union select '/Reporting/Load/?RecId=' + cast(RecordID as varchar), 
				'[Reporting] ' + cast([RptTitle] as varchar) as label, 
				cast([RptContent] as varchar) as SearchField, 56 as DSID from [Reporting]
							union select '/Reporting/Load/?RecId=' + cast(RecordID as varchar), 
				'[Reporting] ' + cast([RptTitle] as varchar) as label, 
				cast([RptDataset] as varchar) as SearchField, 56 as DSID from [Reporting]
							union select '/DelZone/Load/?RecId=' + cast(RecordID as varchar), 
				'[Delivery Zones] ' + cast([DelZName] as varchar) as label, 
				cast([DelZId] as varchar) as SearchField, 57 as DSID from [DelZone]
							union select '/DelZone/Load/?RecId=' + cast(RecordID as varchar), 
				'[Delivery Zones] ' + cast([DelZName] as varchar) as label, 
				cast([DelZName] as varchar) as SearchField, 57 as DSID from [DelZone]
						) P where P.SearchField like @q
			";
			
			var result = new {
				results = IQApp.DB.Load<IQSearchRes>(sql, new { q = q + "%"}).Select(f=> new { id = f.id, text= f.label}),
				more = false
			};
			return Json(result);
		}
	}
	

public class IQScreenMapper : IQ6.Core.IScreenMapper {
	public IReportBase GetScreenModel(string CodedScreenName) {
		switch(CodedScreenName) {
					case "DateFrom":
				return new DateFromModel();
					case "StaffAndDest":
				return new StaffAndDestModel();
					case "StaffSelect":
				return new StaffSelectModel();
					case "TransportDet":
				return new TransportDetModel();
					case "TransportCharges":
				return new TransportChargesModel();
					case "OrdersRequired":
				return new OrdersRequiredModel();
					case "DateFromTo":
				return new DateFromToModel();
					case "DateType":
				return new DateTypeModel();
					case "MonthRange":
				return new MonthRangeModel();
					case "Zone":
				return new ZoneModel();
					case "SummaryDetail":
				return new SummaryDetailModel();
					case "ShowSeparatePageAddress":
				return new ShowSeparatePageAddressModel();
					case "ShowSeparatePage":
				return new ShowSeparatePageModel();
					case "ShowFTLDAN":
				return new ShowFTLDANModel();
					case "UnDecWithDates":
				return new UnDecWithDatesModel();
					case "UnDecWithMonth":
				return new UnDecWithMonthModel();
					case "JobSingle":
				return new JobSingleModel();
					case "ExciseDetail":
				return new ExciseDetailModel();
					case "ExciseSummary":
				return new ExciseSummaryModel();
					case "HM2Form":
				return new HM2FormModel();
				}
		return null;
	}
	public string QueryScreensAsQuery() {
		return @"select '' as KeyValue, '' as [Description]
					union select 'DateFrom', 'Date From
					union select 'StaffAndDest', 'StaffAndDest
					union select 'StaffSelect', 'StaffSelect
					union select 'TransportDet', 'TransportDet
					union select 'TransportCharges', 'TransportCharges
					union select 'OrdersRequired', 'OrdersRequired
					union select 'DateFromTo', 'DateFromTo
					union select 'DateType', 'DateType
					union select 'MonthRange', 'MonthRange
					union select 'Zone', 'Zone
					union select 'SummaryDetail', 'SummaryDetail
					union select 'ShowSeparatePageAddress', 'ShowSeparatePageAddress
					union select 'ShowSeparatePage', 'ShowSeparatePage
					union select 'ShowFTLDAN', 'ShowFTLDAN
					union select 'UnDecWithDates', 'UnDecWithDates
					union select 'UnDecWithMonth', 'UnDecWithMonth
					union select 'JobSingle', 'JobSingle
					union select 'ExciseDetail', 'ExciseDetail
					union select 'ExciseSummary', 'ExciseSummary
					union select 'HM2Form', 'HM2Form
				";
	}
}


public class SecurityGroupsUtil {
	public static string SecurityGroupsAsQuery() {
		return @"select 
			'' as KeyValue, '' as [Description]
						union select '1', 'Full Rights'
					union select '2', 'Database Users'
					union select '3', 'Customers'
				";
	}
}



public class IQCallbackController : IQController
{
    	[ValidateInput(false)]
	public ActionResult ButtonClick(string Class, string Method, string Assembly, string DSName)
    {
        
        object obj = AppDomain.CurrentDomain.CreateInstance(Assembly, Class).Unwrap();
        System.Reflection.MethodInfo meth = obj.GetType().GetMethod(Method);
		switch(DSName) {
							case "Contact":
				{
				var dt = new ContactRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Contact>(dt);
					return IQJS(IQApp.CR);
				}
							case "Orders":
				{
				var dt = new OrdersRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Orders>(dt);
					return IQJS(IQApp.CR);
				}
							case "OrderLine":
				{
				var dt = new OrderLineRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<OrderLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "Job":
				{
				var dt = new JobRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Job>(dt);
					return IQJS(IQApp.CR);
				}
							case "JobLine":
				{
				var dt = new JobLineRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<JobLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "Inv":
				{
				var dt = new InvRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Inv>(dt);
					return IQJS(IQApp.CR);
				}
							case "InvLine":
				{
				var dt = new InvLineRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<InvLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "CN":
				{
				var dt = new CNRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<CN>(dt);
					return IQJS(IQApp.CR);
				}
							case "UKOrder":
				{
				var dt = new UKOrderRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<UKOrder>(dt);
					return IQJS(IQApp.CR);
				}
							case "FerryRoute":
				{
				var dt = new FerryRouteRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<FerryRoute>(dt);
					return IQJS(IQApp.CR);
				}
							case "InvComment":
				{
				var dt = new InvCommentRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<InvComment>(dt);
					return IQJS(IQApp.CR);
				}
							case "VATCodes":
				{
				var dt = new VATCodesRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<VATCodes>(dt);
					return IQJS(IQApp.CR);
				}
							case "JobCost":
				{
				var dt = new JobCostRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<JobCost>(dt);
					return IQJS(IQApp.CR);
				}
							case "CertShip":
				{
				var dt = new CertShipRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<CertShip>(dt);
					return IQJS(IQApp.CR);
				}
							case "CNLine":
				{
				var dt = new CNLineRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<CNLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "Driver":
				{
				var dt = new DriverRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Driver>(dt);
					return IQJS(IQApp.CR);
				}
							case "ExchRate":
				{
				var dt = new ExchRateRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<ExchRate>(dt);
					return IQJS(IQApp.CR);
				}
							case "Trailer":
				{
				var dt = new TrailerRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Trailer>(dt);
					return IQJS(IQApp.CR);
				}
							case "PeriodInv":
				{
				var dt = new PeriodInvRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<PeriodInv>(dt);
					return IQJS(IQApp.CR);
				}
							case "Week":
				{
				var dt = new WeekRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Week>(dt);
					return IQJS(IQApp.CR);
				}
							case "DriverHrs":
				{
				var dt = new DriverHrsRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<DriverHrs>(dt);
					return IQJS(IQApp.CR);
				}
							case "InvBatch":
				{
				var dt = new InvBatchRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<InvBatch>(dt);
					return IQJS(IQApp.CR);
				}
							case "PackageType":
				{
				var dt = new PackageTypeRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<PackageType>(dt);
					return IQJS(IQApp.CR);
				}
							case "BottleSize":
				{
				var dt = new BottleSizeRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<BottleSize>(dt);
					return IQJS(IQApp.CR);
				}
							case "PalletType":
				{
				var dt = new PalletTypeRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<PalletType>(dt);
					return IQJS(IQApp.CR);
				}
							case "EADNum":
				{
				var dt = new EADNumRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<EADNum>(dt);
					return IQJS(IQApp.CR);
				}
							case "ShipDoc":
				{
				var dt = new ShipDocRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<ShipDoc>(dt);
					return IQJS(IQApp.CR);
				}
							case "Truck":
				{
				var dt = new TruckRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Truck>(dt);
					return IQJS(IQApp.CR);
				}
							case "TruckMileage":
				{
				var dt = new TruckMileageRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<TruckMileage>(dt);
					return IQJS(IQApp.CR);
				}
							case "Customer":
				{
				var dt = new CustomerRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Customer>(dt);
					return IQJS(IQApp.CR);
				}
							case "Country":
				{
				var dt = new CountryRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Country>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSOrder":
				{
				var dt = new REDSOrderRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSOrder>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSOrdLine":
				{
				var dt = new REDSOrdLineRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSOrdLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSTax":
				{
				var dt = new REDSTaxRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSTax>(dt);
					return IQJS(IQApp.CR);
				}
							case "DutyRateHist":
				{
				var dt = new DutyRateHistRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<DutyRateHist>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSEAD":
				{
				var dt = new REDSEADRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSEAD>(dt);
					return IQJS(IQApp.CR);
				}
							case "IStatRec":
				{
				var dt = new IStatRecRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<IStatRec>(dt);
					return IQJS(IQApp.CR);
				}
							case "Months":
				{
				var dt = new MonthsRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Months>(dt);
					return IQJS(IQApp.CR);
				}
							case "ChangeReq":
				{
				var dt = new ChangeReqRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<ChangeReq>(dt);
					return IQJS(IQApp.CR);
				}
							case "EMail":
				{
				var dt = new EMailRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<EMail>(dt);
					return IQJS(IQApp.CR);
				}
							case "WordDocument":
				{
				var dt = new WordDocumentRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<WordDocument>(dt);
					return IQJS(IQApp.CR);
				}
							case "Query":
				{
				var dt = new QueryRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Query>(dt);
					return IQJS(IQApp.CR);
				}
							case "EmailTemplatess":
				{
				var dt = new EmailTemplatessRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<EmailTemplatess>(dt);
					return IQJS(IQApp.CR);
				}
							case "Staff":
				{
				var dt = new StaffRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Staff>(dt);
					return IQJS(IQApp.CR);
				}
							case "SMS":
				{
				var dt = new SMSRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<SMS>(dt);
					return IQJS(IQApp.CR);
				}
							case "SMSTemplate":
				{
				var dt = new SMSTemplateRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<SMSTemplate>(dt);
					return IQJS(IQApp.CR);
				}
							case "Alerts":
				{
				var dt = new AlertsRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Alerts>(dt);
					return IQJS(IQApp.CR);
				}
							case "Reporting":
				{
				var dt = new ReportingRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Reporting>(dt);
					return IQJS(IQApp.CR);
				}
							case "DelZone":
				{
				var dt = new DelZoneRepository().CreateFromWebData(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<DelZone>(dt);
					return IQJS(IQApp.CR);
				}
										case "CreatePeriodInvModel":
				{
					var dt = new CreatePeriodInvModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ExportBatchModel":
				{
					var dt = new ExportBatchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "CreateDutyInvModel":
				{
					var dt = new CreateDutyInvModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "LockDownPrevMonthModel":
				{
					var dt = new LockDownPrevMonthModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "SendUnsentInvoicesModel":
				{
					var dt = new SendUnsentInvoicesModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "DateFromModel":
				{
					var dt = new DateFromModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "StaffAndDestModel":
				{
					var dt = new StaffAndDestModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "StaffSelectModel":
				{
					var dt = new StaffSelectModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "TransportDetModel":
				{
					var dt = new TransportDetModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "TransportChargesModel":
				{
					var dt = new TransportChargesModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "OrdersRequiredModel":
				{
					var dt = new OrdersRequiredModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "DateFromToModel":
				{
					var dt = new DateFromToModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "DateTypeModel":
				{
					var dt = new DateTypeModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "MonthRangeModel":
				{
					var dt = new MonthRangeModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ZoneModel":
				{
					var dt = new ZoneModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "SummaryDetailModel":
				{
					var dt = new SummaryDetailModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ShowSeparatePageAddressModel":
				{
					var dt = new ShowSeparatePageAddressModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ShowSeparatePageModel":
				{
					var dt = new ShowSeparatePageModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ShowFTLDANModel":
				{
					var dt = new ShowFTLDANModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "UnDecWithDatesModel":
				{
					var dt = new UnDecWithDatesModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "UnDecWithMonthModel":
				{
					var dt = new UnDecWithMonthModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "JobSingleModel":
				{
					var dt = new JobSingleModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ExciseDetailModel":
				{
					var dt = new ExciseDetailModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ExciseSummaryModel":
				{
					var dt = new ExciseSummaryModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "HM2FormModel":
				{
					var dt = new HM2FormModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "JobSearchModel":
				{
					var dt = new JobSearchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "OrderSearchModel":
				{
					var dt = new OrderSearchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "CustomerSearchModel":
				{
					var dt = new CustomerSearchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
					}
       throw new Exception ("Unable to Handle Non-Dataset Button Click");
      
    }
	 	[ValidateInput(false)]
	public ActionResult InputButtonClick(string Class, string Method, string Assembly, string DSName)
    {
        
        object obj = AppDomain.CurrentDomain.CreateInstance(Assembly, Class).Unwrap();
        System.Reflection.MethodInfo meth = obj.GetType().GetMethod(Method);
		switch(DSName) {
							case "Contact":
				{
				var dt = new ContactRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Contact>(dt);
					return IQJS(IQApp.CR);
				}
							case "Orders":
				{
				var dt = new OrdersRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Orders>(dt);
					return IQJS(IQApp.CR);
				}
							case "OrderLine":
				{
				var dt = new OrderLineRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<OrderLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "Job":
				{
				var dt = new JobRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Job>(dt);
					return IQJS(IQApp.CR);
				}
							case "JobLine":
				{
				var dt = new JobLineRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<JobLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "Inv":
				{
				var dt = new InvRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Inv>(dt);
					return IQJS(IQApp.CR);
				}
							case "InvLine":
				{
				var dt = new InvLineRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<InvLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "CN":
				{
				var dt = new CNRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<CN>(dt);
					return IQJS(IQApp.CR);
				}
							case "UKOrder":
				{
				var dt = new UKOrderRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<UKOrder>(dt);
					return IQJS(IQApp.CR);
				}
							case "FerryRoute":
				{
				var dt = new FerryRouteRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<FerryRoute>(dt);
					return IQJS(IQApp.CR);
				}
							case "InvComment":
				{
				var dt = new InvCommentRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<InvComment>(dt);
					return IQJS(IQApp.CR);
				}
							case "VATCodes":
				{
				var dt = new VATCodesRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<VATCodes>(dt);
					return IQJS(IQApp.CR);
				}
							case "JobCost":
				{
				var dt = new JobCostRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<JobCost>(dt);
					return IQJS(IQApp.CR);
				}
							case "CertShip":
				{
				var dt = new CertShipRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<CertShip>(dt);
					return IQJS(IQApp.CR);
				}
							case "CNLine":
				{
				var dt = new CNLineRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<CNLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "Driver":
				{
				var dt = new DriverRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Driver>(dt);
					return IQJS(IQApp.CR);
				}
							case "ExchRate":
				{
				var dt = new ExchRateRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<ExchRate>(dt);
					return IQJS(IQApp.CR);
				}
							case "Trailer":
				{
				var dt = new TrailerRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Trailer>(dt);
					return IQJS(IQApp.CR);
				}
							case "PeriodInv":
				{
				var dt = new PeriodInvRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<PeriodInv>(dt);
					return IQJS(IQApp.CR);
				}
							case "Week":
				{
				var dt = new WeekRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Week>(dt);
					return IQJS(IQApp.CR);
				}
							case "DriverHrs":
				{
				var dt = new DriverHrsRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<DriverHrs>(dt);
					return IQJS(IQApp.CR);
				}
							case "InvBatch":
				{
				var dt = new InvBatchRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<InvBatch>(dt);
					return IQJS(IQApp.CR);
				}
							case "PackageType":
				{
				var dt = new PackageTypeRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<PackageType>(dt);
					return IQJS(IQApp.CR);
				}
							case "BottleSize":
				{
				var dt = new BottleSizeRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<BottleSize>(dt);
					return IQJS(IQApp.CR);
				}
							case "PalletType":
				{
				var dt = new PalletTypeRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<PalletType>(dt);
					return IQJS(IQApp.CR);
				}
							case "EADNum":
				{
				var dt = new EADNumRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<EADNum>(dt);
					return IQJS(IQApp.CR);
				}
							case "ShipDoc":
				{
				var dt = new ShipDocRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<ShipDoc>(dt);
					return IQJS(IQApp.CR);
				}
							case "Truck":
				{
				var dt = new TruckRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Truck>(dt);
					return IQJS(IQApp.CR);
				}
							case "TruckMileage":
				{
				var dt = new TruckMileageRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<TruckMileage>(dt);
					return IQJS(IQApp.CR);
				}
							case "Customer":
				{
				var dt = new CustomerRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Customer>(dt);
					return IQJS(IQApp.CR);
				}
							case "Country":
				{
				var dt = new CountryRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Country>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSOrder":
				{
				var dt = new REDSOrderRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSOrder>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSOrdLine":
				{
				var dt = new REDSOrdLineRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSOrdLine>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSTax":
				{
				var dt = new REDSTaxRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSTax>(dt);
					return IQJS(IQApp.CR);
				}
							case "DutyRateHist":
				{
				var dt = new DutyRateHistRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<DutyRateHist>(dt);
					return IQJS(IQApp.CR);
				}
							case "REDSEAD":
				{
				var dt = new REDSEADRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<REDSEAD>(dt);
					return IQJS(IQApp.CR);
				}
							case "IStatRec":
				{
				var dt = new IStatRecRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<IStatRec>(dt);
					return IQJS(IQApp.CR);
				}
							case "Months":
				{
				var dt = new MonthsRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Months>(dt);
					return IQJS(IQApp.CR);
				}
							case "ChangeReq":
				{
				var dt = new ChangeReqRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<ChangeReq>(dt);
					return IQJS(IQApp.CR);
				}
							case "EMail":
				{
				var dt = new EMailRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<EMail>(dt);
					return IQJS(IQApp.CR);
				}
							case "WordDocument":
				{
				var dt = new WordDocumentRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<WordDocument>(dt);
					return IQJS(IQApp.CR);
				}
							case "Query":
				{
				var dt = new QueryRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Query>(dt);
					return IQJS(IQApp.CR);
				}
							case "EmailTemplatess":
				{
				var dt = new EmailTemplatessRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<EmailTemplatess>(dt);
					return IQJS(IQApp.CR);
				}
							case "Staff":
				{
				var dt = new StaffRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Staff>(dt);
					return IQJS(IQApp.CR);
				}
							case "SMS":
				{
				var dt = new SMSRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<SMS>(dt);
					return IQJS(IQApp.CR);
				}
							case "SMSTemplate":
				{
				var dt = new SMSTemplateRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<SMSTemplate>(dt);
					return IQJS(IQApp.CR);
				}
							case "Alerts":
				{
				var dt = new AlertsRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Alerts>(dt);
					return IQJS(IQApp.CR);
				}
							case "Reporting":
				{
				var dt = new ReportingRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<Reporting>(dt);
					return IQJS(IQApp.CR);
				}
							case "DelZone":
				{
				var dt = new DelZoneRepository().CreateFromWebData(new WebData());
					var prms = new object[2] { dt, IQApp.WD.GetString("InputValue") };
					meth.Invoke(obj, prms);

					IQApp.CR.TransferToWebAction<DelZone>(dt);
					return IQJS(IQApp.CR);
				}
										case "CreatePeriodInvModel":
				{
					var dt = new CreatePeriodInvModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ExportBatchModel":
				{
					var dt = new ExportBatchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "CreateDutyInvModel":
				{
					var dt = new CreateDutyInvModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "LockDownPrevMonthModel":
				{
					var dt = new LockDownPrevMonthModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "SendUnsentInvoicesModel":
				{
					var dt = new SendUnsentInvoicesModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "DateFromModel":
				{
					var dt = new DateFromModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "StaffAndDestModel":
				{
					var dt = new StaffAndDestModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "StaffSelectModel":
				{
					var dt = new StaffSelectModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "TransportDetModel":
				{
					var dt = new TransportDetModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "TransportChargesModel":
				{
					var dt = new TransportChargesModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "OrdersRequiredModel":
				{
					var dt = new OrdersRequiredModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "DateFromToModel":
				{
					var dt = new DateFromToModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "DateTypeModel":
				{
					var dt = new DateTypeModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "MonthRangeModel":
				{
					var dt = new MonthRangeModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ZoneModel":
				{
					var dt = new ZoneModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "SummaryDetailModel":
				{
					var dt = new SummaryDetailModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ShowSeparatePageAddressModel":
				{
					var dt = new ShowSeparatePageAddressModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ShowSeparatePageModel":
				{
					var dt = new ShowSeparatePageModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ShowFTLDANModel":
				{
					var dt = new ShowFTLDANModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "UnDecWithDatesModel":
				{
					var dt = new UnDecWithDatesModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "UnDecWithMonthModel":
				{
					var dt = new UnDecWithMonthModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "JobSingleModel":
				{
					var dt = new JobSingleModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ExciseDetailModel":
				{
					var dt = new ExciseDetailModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "ExciseSummaryModel":
				{
					var dt = new ExciseSummaryModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "HM2FormModel":
				{
					var dt = new HM2FormModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "JobSearchModel":
				{
					var dt = new JobSearchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "OrderSearchModel":
				{
					var dt = new OrderSearchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
							case "CustomerSearchModel":
				{
					var dt = new CustomerSearchModel().PopulateFromWD(new WebData());
					var prms = new object[1] { dt };
					meth.Invoke(obj, prms);

					dt.PushChangesToWebAction();
					return IQJS(IQApp.CR);
				}
					}
       throw new Exception ("Unable to Handle Non-Dataset Button Click");
      
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/_PartialLayout.cshtml")]
    public partial class IQ6_Views__PartialLayout_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views__PartialLayout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("            ");
       Write(RenderBody());
WriteLiteral("\n\n");
             if(ViewBag.WebAction != null)
            {
WriteLiteral("                <script");
WriteLiteral(" type=\"text/javascript\"");
WriteLiteral(">\n");
WriteLiteral("                     ");
                Write(Html.Raw(ViewBag.WebAction));
WriteLiteral("\n                </script>\n");
            }
WriteLiteral("      \n");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/_ViewStart.cshtml")]
    public partial class IQ6_Views__ViewStart_cshtml : System.Web.Mvc.ViewStartPage
    {
        public IQ6_Views__ViewStart_cshtml()
        {
        }
        public override void Execute()
        {
    Layout = "~/IQ6/Views/_FullLayout.cshtml";
WriteLiteral("\n");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/Main.cshtml")]
    public partial class IQ6_Views_Main_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_Main_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");
WriteLiteral(" style=\"display:none\"");
WriteLiteral(" data-title=\"true\"");
WriteLiteral(">Home</div>\n\n");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/IQFiles_Manager.cshtml")]
    public partial class IQ6_Views_IQFiles_Manager_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_IQFiles_Manager_cshtml()
        {
        }
        public override void Execute()
        {
    ViewBag.Title = "File Manager";
WriteLiteral("\n<noscript");
WriteLiteral(" data-title=\"File Manager\"");
WriteLiteral("></noscript>\n\n<label>Upload File to <div");
WriteLiteral(" class=\'FilePathToUpload\'");
WriteLiteral(" style=\'display:inline-block\'");
WriteLiteral(">/</div></label>\n<div><div");
WriteLiteral(" class=\'display:inline-block\'");
WriteLiteral("><span");
WriteLiteral(" class=\"btn btn-default btn-file\"");
WriteLiteral("><input");
WriteLiteral(" id=\"UploadFile\"");
WriteLiteral(" name=\'FM_UploadedFile\'");
WriteLiteral(" type=\"file\"");
WriteLiteral("  style=\'width:150px;\'");
WriteLiteral(" onchange=\'javascript:UploadFileFM()\'");
WriteLiteral(" /></span>\n</div></div>\n<hr />\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'FM_directory\'");
WriteLiteral(" />\n<label>Browse Files</label>\n<div");
WriteLiteral(" id=\"FM_directoryStructure\"");
WriteLiteral(">\n\n</div>\n<script");
WriteLiteral(" type=\"text/javascript\"");
WriteLiteral(@">
    $(document).ready(function () {
        $('#FM_directoryStructure').fileTree({ root: '/', script: '/IQFiles/FileListing/' },
               function (file) {
                    var link = document.createElement(""a"");
                    link.href = $("".datadirname"").attr(""data-directoryname"") + file;
                    link.click();
               },
               function (dir) {
                   $('.FilePathToUpload').html(dir);
                   $('input[name=FM_directory]').val(dir);
               });
    });
</script>
");
        }
    }
}
}
