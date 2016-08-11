using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class InvLineRegister
    {
        public static void Register()
        {
            DS.AddOnValidate<InvLine>(data =>
            {
                if (data.InvLAmtValue > 0)
                {
                    if (data.InvLVATCodeValue == 0)
                    {
                        IQApp.CR.MessageBoxOK("Please select a valid VAT Code for this line");
                        return false;
                    }
                }
                return true;
            });
            DS.AddOnAdd<InvLine>(OnAddOrSave);
            DS.AddOnSave<InvLine>(OnAddOrSave);

            DS.AddOnDelete<InvLine>(data=> { OnAddOrSave(data);
                                               return true;
            });
            DS.AddOnChange<InvLine>(x => x.InvLAmt, CalculateValues);
            DS.AddOnChange<InvLine>(x => x.InvLVATRate, CalculateValues);
            DS.AddOnChange<InvLine>(x=> x.InvLVATCode,data => {
                data.InvLVATRateValue = DS.GetDoubleByKey<VATCodes>(x=> x.VATRateValue, data.InvLVATCodeValue);
            });
        }

        public static void CalculateValues(InvLine data)
        {
            data.InvLVATAmtValue = data.InvLAmtValue * data.InvLVATRateValue / 100;
            data.InvLTotalValue = data.InvLAmtValue + data.InvLVATAmtValue;
        }
        


        public static void OnAddOrSave(InvLine data)
        {
            string SQL = "SELECT Sum(InvLAmt) AS Net, Sum(InvLVATAmt) AS VAT FROM InvLine WHERE InvLInvNo=" + data.InvLInvNoValue;
            LineSum l = IQApp.DB.Load<LineSum>(SQL).First();
            data.Parent.InvNetValue = l.Net;
            data.Parent.InvVATValue = l.VAT;
            data.Parent.InvTotalValue = l.Net + l.VAT;
            data.Parent.Save();
        }

    }
}