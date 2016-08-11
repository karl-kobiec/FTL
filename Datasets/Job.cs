using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public  class JobRegister
    {
        public static void Register()
        {
            DS.AddOnDrawSingleToolbar<Job>(data =>
            {
                
                List<Element> ret = new List<Element>();
                if (data.RecordID.HasValue)
                {
                    ret.Add(WebButton.CallbackButton<Job>("Add new line", (AddNewLine)));
                        // MCBQ: Why do you have this?  Its not needed?
                    ret.Add(WebButton.CallbackButton<Job>("Delete Job", (DelJob)));
                        // MCBQ: Why do you have this?  Why not use 'OnDelete'?
                    //   ret.Add(WebButton.CallbackButton<Job>("Send SMS to Driver", SendSMSToDriver));
                }
                return ret;
            });
            DS.AddOnChange<Job>(x=> x.JobAccMonth, data =>
            {
                if (data.JobCreatedByValue == 0) data.JobCreatedByValue = IQApp.User.GetUserId();
            });
        }
    

        public static void AddNewLine(Job j)
        {
            NewMethod(j);

            IQApp.CR.LoadScreen<Job>(j.RecordID.Value);
        }

        private static void NewMethod(Job j)
        {
            JobLine l = new JobLine();
            l.JobLJobNoValue = j.JobIdValue;
            l.JobLLineLetterValue = FTLExtensions.FTLGetNextLetter(j.JobIdValue);
            l.Save();
        }

        public static void DelJob(Job j)
        {
            string Msg = "Are you sure you want to delete this job: " + j.JobNoValue + "? All job lines and job costs will also be deleted.";
            IQApp.CR.MessageBoxYesNo<Job>(Msg, (DelJobYes));
        }

        public static void DelJobYes(Job xf)
        {

            string SQL = "SELECT JobLOrder FROM JobLine WHERE JobLJobNo=" + xf.JobIdValue;

            foreach (string JobLOrder in IQApp.DB.Load<string>(SQL))
            {
                SQL = "UPDATE Orders SET OrdJobNo=Null, OrdJobLetter=Null, OrdJob=Null, OrdCollDate=Null, OrdCollDate2=Null, OrdDateDel=Null WHERE OrdId=" + JobLOrder;
                IQApp.DB.Execute(SQL);
            }
            DS.DeleteByField<JobLine>(x => x.JobLJobNo, xf.JobIdValue);
            DS.DeleteByField<JobCost>(x => x.JobCJobNo, xf.JobIdValue);
            DS.DeleteByField<Job>(x => x.JobId, xf.JobIdValue);
            IQApp.CR.UrlToLoad("/").InfoMessage("Job Deleted");
        }
    }
}