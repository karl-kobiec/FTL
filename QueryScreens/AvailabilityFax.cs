using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTL
{
    public class AvailabilityFax : IQYAvailabilityFax
    {
        public object BuildQueryObject(string RecIds)
        {
            int[] RecordIDs = new int[1] { 0 };

            if(!string.IsNullOrEmpty(RecIds))
                RecordIDs = RecIds.Split(',').Select(f => Int32.Parse(f)).ToArray();

            var mdl = new AvailabilityFaxModel()
            {
                
                Orders = R.DB.Load<AFMOrders>(@"
        SELECT OrdId, OrdCustOrd, OrdReqDate,
(SELECT CustName FROM Customer WHERE CustId = OrdConsign) AS ConsName, (SELECT CustLang FROM Customer WHERE CustId = OrdConsign) AS Lang,
(SELECT CustName FROM Customer WHERE CustId = OrdSupp) AS SuppName
FROM Orders WHERE RecordID IN (@RecordIDs)", new { RecordIDs = RecordIDs }),
            };
            foreach(var itm in mdl.Orders)
            {
                itm.Lines = R.DB.Load<AFMLines>(@"
SELECT OrdLCustOrd, OrdLQty, (SELECT PackName FROM PackageType WHERE PackId = OrdLPackageType) AS PackType, (SELECT BSzSize FROM BottleSize WHERE BSzId = OrdLSize) AS BSize, OrdLDesc FROM OrderLine INNER JOIN Orders
            ON OrderLine.OrdLOrder = Orders.OrdId WHERE Orders.RecordID IN (@RecordIDs)", new { RecordIDs = RecordIDs });
            }
            return mdl;
        }


    }
    public class AvailabilityFaxModel
    {
        public List<AFMOrders> Orders { get; set; }
    }

    public class AFMOrders
    {
        public int OrdId { get; set; }
        public string OrdCustOrd { get; set; }
        public DateTime OrdReqDate { get; set; }
        public string ConsName { get; set; }
        public string Lang { get; set; }
        public string SuppName { get; set; }
        public List<AFMLines> Lines { get; set; }
    }
    public class AFMLines
    {
        public int OrdLCustOrd { get; set; }
        public double OrdLQty { get; set; }
        public string PackType { get; set; }
        public string BSize { get; set; }
        public string OrdLDesc { get; set; }
    }
}