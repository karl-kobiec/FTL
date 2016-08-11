using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL
{
    public class UKOrdInvModel
    {
        public string CustomerName { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Reference { get; set; }
        public List<UkOrderModel> Orders { get; set; }
    }
    public class UkOrderModel
    {
        public string CollDate { get; set; }
    }
    public class ReportModel
    {
        public List<UKOrdInvModel> Data { get; set; }
    }
   
}