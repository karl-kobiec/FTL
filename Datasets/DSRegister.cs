using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTL.Datasets
{
    public static class DSRegister
    {
        public static void Register()
        {
            CertShipRegister.Register();
            ShipDocRegister.Register();
            OrdersRegister.Register();
            InvLineRegister.Register();
            IStatRecRegister.Register();
            REDSOrdesRegister.Register();
            JobLineRegister.Register();
            CNRegister.Register();
            JobRegister.Register();
            CNLineRegister.Register();
            ContactRegister.Register();
            DriverHrsRegister.Register();
            CustomerRegister.Register();
            EMailRegister.Register();
            JobCostRegister.Register();
            OrderLineRegister.Register();
            REDSOrdLineRegister.Register();
            REDSTaxRegister.Register();
            StaffRegister.Register();
            TrailerRegister.Register();
            TruckMileageRegister.Register();
            UKOrderRegister.Register();
        }
    }
}
