using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using Intrinsiq.Email;
using Intrinsiq.WordDocument;
using IQ6.Core;

namespace FTL
{
    public partial class InvRegister
    {
        public static void Register()
        {
            DS.AddOnDrawSingleToolbar<Inv>(data =>
            {
                List<Element> ret = new List<Element>();
                ret.Add(WebButton.CallbackButton<Inv>("Send Invoice", (SendInvoice)));
                ret.Add(WebButton.CallbackButton<Inv>("Edit Invoice", (EditInv)));

                return ret;
            });
            DS.AddOnAdd<Inv>(OnAddOrSave);
            DS.AddOnSave<Inv>(OnAddOrSave);
            DS.AddOnChange<Inv>(x => x.InvCurr, data =>
            {
                if (data.InvCurrValue == 1)
                {
                    data.InvExchRateValue = 1;
                }
                else
                {
                    data.InvExchRateValue = DS.GetDoubleByClause<ExchRate>(x => x.ExRRateValue, "ExRSDate<='" + data.InvDateValue.ToSQLString() + "' AND ExREDate>='" + data.InvDateValue.ToSQLString() + "'");
                }
            });
            DS.AddOnChange<Inv>(x => x.InvFreightDuty, data =>
            {
                if (data.InvFreightDutyValue == "Duty") data.InvImpExpValue = "Imp";
                SetInvNo(data);
            });
            DS.AddOnChange<Inv>(x => x.InvImpExp, SetInvNo);
            DS.AddOnChange<Inv>(x => x.InvProforma, SetInvNo);
            DS.AddOnChange<Inv>(x => x.InvJobLetter, data =>
            {
                var o = DS.GetByFields<Orders>(x => x.OrdJobNo, data.InvJobNoValue, x => x.OrdJobLetter, data.InvJobLetterValue);
                data.InvOrderValue = o.OrdIdValue;
                data.InvToValue = o.OrdCustValue;
                data.InvToIdValue = o.OrdCustValue;
                data.InvCustOrdValue = o.OrdCustOrdValue;
                data.InvTescoRefValue = o.OrdTescoRefValue;

                var c = DS.GetByKey<Customer>(o.OrdCustValue);
                data.InvAddrValue = c.CustAddrValue;
                data.InvTownValue = c.CustTownValue;
                data.InvPCValue = c.CustPCValue;
            });
            DS.AddOnChange<Inv>(x => x.InvJobNo, data =>
            {
                var j = DS.GetByField<Job>(x => x.JobId, data.InvJobNoValue);
                data.InvVehicleValue = j.JobVehNoValue;
                data.InvTrailerValue = j.JobTrailerNoValue;
                data.InvRouteFromValue = j.JobRouteFromValue;
                data.InvRouteToValue = j.JobRouteToValue;
                data.InvFerryNameValue = j.JobFerryNameValue;
                data.InvFerryDateValue = j.JobFerryDateValue;
                data.InvFerryTimeValue = j.JobFerryTimeValue;
            });
            DS.AddOnChange<Inv>(x => x.InvTo, data =>
            {
                data.InvToId.DataValue = data.InvToValue;
            });
            DS.AddOnChange<Inv>(x => x.InvToId, data =>
            {
                data.InvTo.DataValue = data.InvToIdValue;
            });
        }

        public static void EditInv(Inv data)
        {
            data.InvDesc.Enabled = true;
            data.InvNote1.Enabled = true;
            data.InvNote2.Enabled = true;
            data.InvNote3.Enabled = true;

            foreach (var i in DS.FetchByField<InvLine>(x => x.InvLInvNo, data.InvIdValue))
            {
                i.InvLDesc.Enabled = true;
            }

        }

        public static void SendInvoice(Inv xf)
        {
            var em = EmailModule.CreateEmailFromTemplate(FTLConst.InvoiceEmailTemplateId, new int[1] { xf.RecordID.Value });
            em.Attachments = WordModule.MergeDocumentAsPDF(
                DS.GetByKey<WordDocument>(FTLConst.InvoiceDocumentTemplateId),
                "/Invoices/Inv" + xf.InvIdValue + ".pdf", xf.RecordID.Value.ToString());
            em.Save();

            IQApp.CR.LoadScreen<EMail>(em.RecordID.Value);

        }
        public static void OnAddOrSave(Inv data)
        {
            var invoices = DS.FetchByFields<Inv>(x => x.InvOrder, data.InvOrderValue, x => x.InvFreightDuty, data.InvFreightDutyValue);

            string v1 = "";
            foreach (Inv inv in invoices.OrderBy(f => f.InvIdValue))
            {
                v1 = v1 + inv.InvIdValue + " (£" + inv.InvNetValue.ToString("f2") + "), ";
            }
            if (v1 != "")
            {
                v1 = v1.Substring(0, v1.Length - 2);
                if (data.InvFreightDutyValue == "Duty")
                    DS.SetValueByKey<Orders>(x => x.OrdDutyInv, v1, data.InvOrderValue);
                else
                    DS.SetValueByKey<Orders>(x => x.OrdFreightInv, v1, data.InvOrderValue);
            }
        }


        public static void SetInvNo(Inv data)
        {
            if (data.InvImpExpValue == "0" || data.InvFreightDutyValue == "0") return;
            if (data.RecordID.Value == 0)
            {
                string SQL = "SELECT Max(InvId) AS Last FROM Inv WHERE InvProforma=1";
                if (data.InvProformaValue == false)
                    SQL = "SELECT Max(InvId) AS Last FROM Inv WHERE InvImpExp='" + data.InvImpExpValue + "' AND InvFreightDuty='" + data.InvFreightDutyValue + "' AND InvProforma=0";
                data.InvIdValue = IQApp.DB.GetInt(SQL) + 1;
            }
        }

    }
}