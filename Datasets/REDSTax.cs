using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class REDSTaxRegister
    {
        public static void Register()
        {
            DS.AddOnDrawSingleToolbar<REDSTax>(data =>
            {
                return new List<Element>()
                {
                    WebButton.CallbackButton<REDSTax>("Change Alcohol %", ChangeAlcPct),
                    WebButton.CallbackButton<REDSTax>("Change Duty Rate",ChangeDutyRate)
                };
            });

            DS.AddOnChange<REDSTax>(x=> x.RDTaxAlcPct, data=> {
                DutyRateHist d = new DutyRateHist();
                d.DRHTaxCodeValue = data.RDTaxIdValue;
                d.DRHChangeDateValue = DateTime.Now;
                d.DRHDutyRateValue = data.RDTaxDutyRateValue;
                d.DRHAlcPctValue = data.RDTaxAlcPct.PreviousValue;
                d.Save();
            });
            DS.AddOnChange<REDSTax>(x => x.RDTaxDutyRate, data =>
            {
                DutyRateHist d = new DutyRateHist();
                d.DRHTaxCodeValue = data.RDTaxIdValue;
                d.DRHChangeDateValue = DateTime.Now;
                d.DRHDutyRateValue = data.RDTaxDutyRate.PreviousValue;
                d.DRHAlcPctValue = data.RDTaxAlcPctValue;
                d.Save();
            });
        }

        public static void ChangeAlcPct(REDSTax data)
        {
            data.RDTaxAlcPct.Enabled = true;
        }

        public static void ChangeDutyRate(REDSTax data)
        {
            data.RDTaxDutyRate.Enabled = true;
        }

    }
}