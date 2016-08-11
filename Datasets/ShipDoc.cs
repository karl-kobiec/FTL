using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class ShipDocRegister
    {
        public static void Register()
        {
            DS.AddOnChange<ShipDoc>(x => x.SDRecip, data =>
            {
                data.SDRecipId.DataValue = data.SDRecipValue;
                RecipientDets(data);
            });
            DS.AddOnChange<ShipDoc>(x => x.SDRecipId, data =>
            {
                data.SDRecip.DataValue = data.SDRecipIdValue;
                RecipientDets(data);
            });
            DS.AddOnChange<ShipDoc>(x => x.SDSignedBy, data =>
            {
                data.SDSignedByTextValue = IQApp.User.GetName(data.SDSignedByValue);
            });

            DS.AddOnChange<ShipDoc>(x => x.SDSupp, data =>
            {
                data.SDSuppId.DataValue = data.SDSuppValue;
                SupplierDets(data);
            });
            DS.AddOnChange<ShipDoc>(x => x.SDSuppId, data =>
            {
                data.SDSupp.DataValue = data.SDSuppIdValue;
                SupplierDets(data);
            });

        }

        public static void SupplierDets(ShipDoc data)
        {
            var c = DS.GetByKey<Customer>(data.SDSuppValue);
            
            string Addr = c.CustAddrValue;
            if (!string.IsNullOrEmpty(c.CustAddr2Value)) Addr = Addr + Environment.NewLine + c.CustAddr2Value;
            if (!string.IsNullOrEmpty(c.CustAddr3Value)) Addr = Addr + Environment.NewLine + c.CustAddr3Value;
            if (!string.IsNullOrEmpty(c.CustTownValue)) Addr = Addr + Environment.NewLine + c.CustTownValue;
            if (!string.IsNullOrEmpty(c.CustCountyValue)) Addr = Addr + Environment.NewLine + c.CustCountyValue;
            if (!string.IsNullOrEmpty(c.CustPCValue)) Addr = Addr + Environment.NewLine + c.CustPCValue;
            if (c.CustCtryValue != 0) Addr = Addr + Environment.NewLine + DS.GetStringByKey<Country>(x=> x.CtryNameValue, c.CustCtryValue);
            data.SDSuppAddrValue = Addr;
            data.SDSuppVATNoValue = c.CustVATNoValue;
        }

        public static void RecipientDets(ShipDoc data)
        {
            var c = DS.GetByKey<Customer>(data.SDSuppValue);

            string Addr = c.CustAddrValue;
            if (!string.IsNullOrEmpty(c.CustAddr2Value)) Addr = Addr + Environment.NewLine + c.CustAddr2Value;
            if (!string.IsNullOrEmpty(c.CustAddr3Value)) Addr = Addr + Environment.NewLine + c.CustAddr3Value;
            if (!string.IsNullOrEmpty(c.CustTownValue)) Addr = Addr + Environment.NewLine + c.CustTownValue;
            if (!string.IsNullOrEmpty(c.CustCountyValue)) Addr = Addr + Environment.NewLine + c.CustCountyValue;
            if (!string.IsNullOrEmpty(c.CustPCValue)) Addr = Addr + Environment.NewLine + c.CustPCValue;
            if (c.CustCtryValue != 0) Addr = Addr + Environment.NewLine + DS.GetStringByKey<Country>(x => x.CtryNameValue, c.CustCtryValue);
            data.SDRecipAddrValue = Addr;
            data.SDRecipVATNoValue = c.CustVATNoValue;
        }
    }
}