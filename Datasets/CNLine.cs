using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public  class LineSum
    {
        public double Net { get; set; }
        public double VAT { get; set; }
    }
    public static class CNLineRegister
    {
        public static void Register()
        {
            DS.AddOnValidate<CNLine>(data =>
            {
                if (data.CNLAmtValue > 0)
                {
                    if (data.CNLVATCodeValue == 0)
                    {
                        IQApp.CR.MessageBoxOK("Please select a valid VAT Code for this line");
                        return false;
                    }
                }
                return true;
            });
            DS.AddOnAdd<CNLine>(OnAddOrSave);
            DS.AddOnSave<CNLine>(OnAddOrSave);
            DS.AddOnDelete<CNLine>(data=> { OnAddOrSave(data);
                                              return true;
            });
            DS.AddOnChange<CNLine>(x=> x.CNLAmt, data=> {
                data.CNLVATAmtValue = data.CNLAmtValue * data.CNLVATRateValue / 100;
                data.CNLTotalValue = data.CNLAmtValue + data.CNLVATAmtValue;
            });

            DS.AddOnChange<CNLine>(x => x.CNLVATRate, data => {
                data.CNLVATAmtValue = data.CNLAmtValue * data.CNLVATRateValue / 100;
                data.CNLTotalValue = data.CNLAmtValue + data.CNLVATAmtValue;
            });

            DS.AddOnChange<CNLine>(x => x.CNLVATCode, data =>
            {
                data.CNLVATRateValue = DS.GetDoubleByKey<VATCodes>(x=> x.VATRateValue, data.CNLVATCodeValue);
            });
        }
      
        
        public static void OnAddOrSave(CNLine data)
        {
            var x = IQApp.DB.Load<LineSum>("SELECT Sum(CNLAmt) AS Net, Sum(CNLVATAmt) AS VAT FROM CNLine WHERE CNLNo=@No", new { No = data.CNLNoValue }).First();
            data.Parent.CNNetValue = x.Net;
            data.Parent.CNVATValue = x.VAT;
            data.Parent.CNTotalValue = x.Net + x.VAT;
            data.Parent.Save();
        }

    }
}