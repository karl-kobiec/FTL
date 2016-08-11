using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intrinsiq.Alerts;
using IQ6.Core;

namespace FTL
{
    public class PortalController : Controller
    {
        private int GetUserId()
        {
            return IQApp.User.GetUserId() - 1000; 
        }

        public ActionResult FindClient(string q)
        {
            var data = IQApp.DB.Load<Pair<string, string>>("select CustId as KeyValue, CustName as [Description] from Customer where CustName like @query",
                new { query = q + "%" }).Select(f => new { id = f.KeyValue, text = f.Description });
          
            var result = new
            {
                results = data,
                more = false
            };
			
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [IQAuthorize]
        public ActionResult Index()
        {
            ViewBag.Welcome = DS.GetStringByKey<Customer>(x=> x.CustNameValue, GetUserId());
            //where OrdCustId=" + GetUserId() + " 
            return View("Index", IQApp.DB.Load<Orders>("select top 50 * from Orders  ORDER BY OrdDate desc"));
        }

        public ActionResult ViewOrder(int id)
        {

            return View("ViewOrder", IQApp.DB.Load<Orders>("select * from ORders where OrdId=@Id", new { Id = id }).First());
        }

        public ActionResult AddOrder()
        {
            return View();
        }
        public ActionResult AddOrders(OrderAddModel mdl)
        {
            Orders ord = new Orders();
            //ord.OrdCustIdValue = 
                ord.OrdCustValue = mdl.ClientName;
            ord.OrdReqDateValue = mdl.RequiredDate;
            ord.OrdCustOrdValue = mdl.YourOrderNo;
            ord.OrdStatusValue = mdl.Status;
            ord.OrdNotesValue = "Supplier Name: " + mdl.SupplierName + " in " + mdl.SupplierAreaCode + ", Email: " + mdl.SupplierEmail + "\nDelivery Point:" + mdl.DeliveryPoint;
            ord.OrdIdValue = IQApp.DB.GetInt("select max(OrdId)+1 from Orders"); // Shouldn't be neccessary
            ord.Save();
            OrderLine ol = new OrderLine()
            {
                OrdLOrderValue = ord.OrdIdValue,
                OrdLPackageTypeValue = mdl.PackType,
                OrdLSizeValue = mdl.Size,
                OrdLQtyValue = mdl.Quantity,
                OrdLDescValue = mdl.Description

            };
            ol.Save();
            foreach (var itm in DS.FetchAll<Staff>())
                AlertsModule.QueueAlert(itm.StfIdValue, ord.OrdIdValue, "New Portal Order: " + ord.OrdIdValue, OrderClicked);

            return Redirect("/Portal/ViewOrder/" + ord.OrdIdValue + "/?msg=Your Order has been submitted");
        }
        public void OrderClicked(object data)
        {
            int ordid = (int)data;
            AlertsModule.ClearAlert("New Portal Order: " + ordid);
            IQApp.CR.LoadScreen<Orders>(IQApp.DB.GetInt("select RecordID from Orders where OrdId=@Id", new { Id = ordid }));
        }
    }
    public class OrderAddModel
    {
        public int ClientName { get; set; }
        public string YourOrderNo { get; set; }
        public DateTime RequiredDate { get; set; }
        public int Status { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAreaCode { get; set; }
        public string SupplierEmail { get; set; }
        public string DeliveryPoint { get; set; }
        public int Quantity { get; set; }
        public int PackType { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
    }
}