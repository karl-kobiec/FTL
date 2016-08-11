using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FTL.Areas.Dashlets.Controllers;
using JDash;
using JDash.Provider;

namespace FTL.Areas.Dashlets
{
    public class DashletRegistration
    {
        public static void Register()
        {
            if (!JDashManager.Provider.SearchDashletModules().data.Any(f => f.title == new ButtonBlock().title))
                JDashManager.Provider.CreateDashletModule(new ButtonBlock());

            if (!JDashManager.Provider.SearchDashletModules().data.Any(f => f.title == new TruckBlock().title))
                JDashManager.Provider.CreateDashletModule(new TruckBlock());
        }

    }
}