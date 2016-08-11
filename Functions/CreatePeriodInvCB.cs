using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intrinsiq.WordDocument;
using IQ6.Core;

namespace FTL
{
    public class CreatePeriodInvRegister
    {
        public static void Register()
        {
            SC.AddOnChange<CreatePeriodInvModel>(x => x.CreateInv,
                f =>
                {
                    string Msg = "Are you sure you want to create a period invoice for " +
                                 DS.GetStringByKey<Customer>(x => x.CustNameValue, Int32.Parse(f.ClientNoValue)) + "?";
                    IQApp.CR.Popup("OK to Create?", Msg, new List<WebButton>()
                    {
                        WebButton.CallbackButton<CreatePeriodInvModel>("Yes", YesToCreate),
                        WebButton.ClosePopupButton("No")
                    });
                });
            SC.AddOnChange<CreatePeriodInvModel>(x => x.PrintInv, OnPrintInv);
        }

        public static void YesToCreate(CreatePeriodInvModel f) {
            
            if (DS.CountByClause<Inv>("InvTo='" + f.InvoiceNoValue + "' AND InvISPInv=False AND InvFreightDuty='Freight' AND InvImpExp='Imp' AND (InvBelongsPInv=0 OR InvBelongsPInv Is Null)") == 0)
            {
                IQApp.CR.Popup("None to do", "No more invoices to group for this client at this time.", new List<WebButton>() {
                    WebButton.ClosePopupButton("Close") });
            }

            int PInvNo = IQApp.DB.GetInt("SELECT isnull(Max(InvId),0)+1 AS Last FROM Inv WHERE InvFreightDuty='Freight' AND InvImpExp='Imp'");

            Inv i = new Inv();
            i.InvIdValue = PInvNo;
            i.InvFreightDutyValue = "Freight";
            i.InvToValue = f.ClientNoValue.ToInt();
            i.InvDescValue = "Period Invoice. Please see attached spreadsheet for details.";
            i.InvDateValue = DateTime.Now;
            i.InvImpExpValue = "Imp";
            i.InvCurrValue = 1;
            i.InvExchRateValue = 1;
            i.InvISPInvValue = true;

            var c = DS.GetByKey<Customer>(f.ClientNoValue.ToInt());
            i.InvAddrValue = c.CustAddrValue;
            i.InvTownValue = c.CustTownValue;
            i.InvPCValue = c.CustPCValue;

            i.Save();

            InvLine il = new InvLine();
            il.InvLInvNoValue = i.InvIdValue;
            il.InvLLineNoValue = 1;
            il.InvLDescValue = "Please see attached spreadsheet";
            il.Save();

            foreach(var invi in DS.FetchWithClause<Inv>("InvTo=" + f.InvoiceNoValue +  " AND InvISPInv=False AND InvFreightDuty='Freight' AND InvImpExp='Imp' AND (InvBelongsPInv=0 OR InvBelongsPInv Is Null)"))
            {
                PeriodInv pi = new PeriodInv();
                pi.PInvIdValue = i.InvIdValue;
                pi.PInvNameValue = invi.InvIdValue;
                pi.Save();
                invi.InvBelongsPInvValue = i.InvIdValue;
                invi.Save();
            }
            var t = IQApp.DB.Load<TempCalc>("SELECT Sum(InvNet) AS TNet, Sum(InvVAT) AS TVAT, Sum(InvTotal) AS Total FROM Inv INNER JOIN PeriodInv ON Inv.InvId = PeriodInv.PInvName WHERE PInvId=" + PInvNo).First();
            i.InvNetValue = t.TNet;
            i.InvVATValue = t.TVAT;
            i.InvTotalValue = t.Total;
            i.Save();
            il.InvLAmtValue = t.TNet;
            il.InvLVATAmtValue = t.TVAT;
            il.InvLTotalValue = t.Total;
            il.Save();

            f.InvoiceNoValue = PInvNo.ToString();

            OnPrintInv(f);
        }

        private class TempCalc
        {
            public double TNet { get; set; }
            public double TVAT { get; set; }
            public double Total { get; set; }
        }
        public static void OnPrintInv(CreatePeriodInvModel f)
        {
            WordModule.ShowWordPopup(1, IQApp.DB.GetString("select RecordID from Inv where InvId=@Id", new { Id= f.InvoiceNoValue}));
        }
    }
}
