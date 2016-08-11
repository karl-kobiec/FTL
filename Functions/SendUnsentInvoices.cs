using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ6.Core;
using System.Web.Mvc;
using Intrinsiq.Email;
using Intrinsiq.WordDocument;

namespace FTL
{
    public static class SendUnsentInvoicesExt
    {
        public static List<Inv> UnsentInvoices(this SendUnsentInvoicesModel m)
        {
            return DS.FetchByField<Inv>(x=> x.InvSentToClient, false).OrderBy(f=> f.InvTo.DisplayValue).ThenBy(f=> f.InvDateValue).ToList();
        }
    }

    public class FTLSendUnsentInvoicesController: IQController
    {
        public ActionResult SendInvoices()
        {
            
            int CurrentCust = 0;
            List<int> RecordIDS = new List<int>();
            List<string> Attachments = new List<string>();

            foreach(var itm in DS.FetchByField<Inv>(x=> x.InvSentToClient, false).OrderBy(f => f.InvTo.DisplayValue))
            {
                if(CurrentCust != itm.InvToValue && CurrentCust > 0)
                {
                    
                    var em = EmailModule.CreateEmailFromTemplate(FTLConst.InvoiceEmailTemplateId, RecordIDS.ToArray());
                    em.Attachments += string.Join(";", Attachments.ToArray());
                    em.Save();
                    EmailModule.SendEmail(em);
                }
                if(CurrentCust != itm.InvToValue)
                {
                    RecordIDS = new List<int>();
                    CurrentCust = itm.InvToValue;
                }
                RecordIDS.Add(itm.RecordID.Value);
                Attachments.Add(
                    WordModule.MergeDocumentAsPDF(
                        DS.GetByKey<WordDocument>(FTLConst.InvoiceDocumentTemplateId), 
                        "/Invoices/Inv" + itm.InvIdValue + ".pdf", itm.RecordID.Value.ToString()));
            }
            return Redirect("/?msg=Your Invoices have been sent.");
        }
    }
}
 