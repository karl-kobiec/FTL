using IQ6.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using JDash;
using JDash.Configuration;
using JDash.JDashRegistrationService;
using JDash.Models;
using JDash.Mvc.Core;

namespace FTL
{
   
    public class HomeController : IQController
    {
        public ActionResult Test()
        {
            CTrack.Membership.MembershipClient mc = new CTrack.Membership.MembershipClient();
            var val = mc.AcquireSecurityToken("charlie.richards@freighttransport.co.uk", "password");
            return Content(val.Message + "-" + val.SecurityToken);
        }

        [IQ6.Core.IQAuthorize]
        public ActionResult Index()
        {

            var dashboard = JDashManager.Provider.GetDashboardsOfUser(HttpContext.User.Identity.Name).FirstOrDefault();
            if (dashboard == null)
            {
                dashboard = new DashboardModel()
                {
                    title = "FTL Dashboard",
                };

                dashboard.metaData.created = DateTime.Now;
                dashboard.metaData.createdBy = HttpContext.User.Identity.Name;
                JDashManager.Provider.CreateDashboard(dashboard);
            }

            FTL.Areas.Dashlets.DashletRegistration.Register();

            // Get a list of dashlet modules
            ViewBag.DashletModules = JDashManager.Provider.SearchDashletModules().data;
            ViewBag.CurrentDashboard = dashboard.id;
            

            return IQView("Index");
            
        }
       
       
    }
}