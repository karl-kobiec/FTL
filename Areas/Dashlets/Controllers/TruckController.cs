using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQ6.Core;
using JDash.Models;

namespace FTL.Areas.Dashlets.Controllers
{
    public class TruckModel
    {



        DateTime TwoWeeks = DateTime.Now.AddDays(14);
        DateTime OneMonth = DateTime.Now.AddMonths(1);

        public List<Truck> Trucks { get; set; }
        public string GetStyle(DateTime dt)
        {
            if (dt < TwoWeeks)
                return "color:red";
            if (dt < OneMonth)
                return "color:mediumvioletred";
            return "";

        }

    }

    public class TruckDashController : Controller
    {

        public ActionResult Index()
        {
            var x = new TruckModel()
            {
                Trucks =
                    IQApp.DB.Load<Truck>(
                        "select * from Truck where TrkMOTDate < dateadd(m, 6, getdate()) or TrkTAXDate < dateadd(m, 6, getdate())")
            };
            return View(x);
        }
    }

    public class TruckBlock : DashletModuleModel
    {
        public TruckBlock()
        {
            this.title = "Truck Status";
            config.Add("mvcConfig", new { controller = "/Dashlets/TruckDash" });
            path = "[MVCDefault]";
            this.paneConfig.Add("builtInCommands", new string[] { "remove" });
        }
    }
}