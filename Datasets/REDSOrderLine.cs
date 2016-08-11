using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class REDSOrdLineRegister
    {
        public static void Register()
        {
            DS.AddOnChange<REDSOrdLine>(x => x.RDOLCases, RDOLCasesOrBottleCase);
            DS.AddOnChange<REDSOrdLine>(x => x.RDOLBottleCase, RDOLCasesOrBottleCase);

            DS.AddOnChange<REDSOrdLine>(x => x.RDOLBottleSize, RDOLCasesOrBottleCase);
            DS.AddOnChange<REDSOrdLine>(x => x.RDOLAlcPct, RDOLCasesOrBottleCase);
            DS.AddOnChange<REDSOrdLine>(x => x.RDOLTaxCode, data =>
            {
                data.RDOLAlcPct.DataValue = DS.GetDoubleByKey<REDSTax>(x=> x.RDTaxAlcPctValue,data.RDOLTaxCodeValue);
                RDOLCasesOrBottleCase(data);
            });
        }
        

        public static void RDOLCasesOrBottleCase(REDSOrdLine data)
        {
            if (data.RDOLTaxCodeValue == 0) return;

            var t = DS.GetByKey<REDSTax>(data.RDOLTaxCodeValue);
            double Amt = data.RDOLCasesValue * data.RDOLBottleCaseValue * data.RDOLBottleSizeValue / 100;
            if (t.RDTaxTypeValue == 2) Amt = Amt * data.RDOLAlcPctValue / 100;
            data.RDOLLitresValue = Amt;

            double Duty = Amt * t.RDTaxDutyRateValue;
            if (t.RDTaxTypeValue == 3) Duty = Duty * data.RDOLAlcPctValue / 100;
            data.RDOLDutyDueValue = Duty;

            //If Adjust = 0 Then
            //    Select Case Forms(gDFN)!childSub.Form!ComboBox6
            //        Case 441
            //            EnterDuty = InputBox("Enter a manually adjusted figure if required", "Enter Manual Figure", Duty)
            //            If EnterDuty <> "" Then Forms(gDFN)!childSub.Form!TextBox9 = EnterDuty
            //    End Select
            //End If
        }

    }
}