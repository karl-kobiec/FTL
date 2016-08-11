using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public static class JobLineRegister
    {
        public static void Register()
        {
            DS.AddOnDrawSingleToolbar<JobLine>(data => new List<Element>()
            {
                WebButton.CallbackButton<JobLine>("Delete Job Line", DelLine)
            });

            DS.AddOnAdd<JobLine>(data =>
            {
                if (data.JobLLineLetterValue == "")
                    data.JobLLineLetterValue = FTLExtensions.FTLGetNextLetter(data.Parent.JobIdValue);
            });
            DS.AddOnValidate<JobLine>(data =>
            {
                if (data.JobLLineLetterValue == "")
                {
                    data.JobLLineLetterValue = FTLExtensions.FTLGetNextLetter(data.Parent.JobIdValue);
                    string SQL = "UPDATE Orders SET OrdJobNo='" + data.JobLJobNoValue + "', OrdJobLetter='" + data.JobLLineLetterValue + "', OrdJob='" + data.JobLJobNoValue + data.JobLLineLetterValue + "' WHERE OrdId=" + data.JobLOrderValue;
                    IQApp.DB.Execute(SQL);
                }
                return true;
            });
            DS.AddOnChange<JobLine>(x=> x.JobLCollDate, data=> {
                if (FTLExtensions.FTLCheckDate(data.JobLCollDateValue) == false) data.JobLCollDate.DataValue = DateTime.MinValue;
                else
                {
                    if (data.JobLOrderValue > 0)
                    {
                        string SQL = "UPDATE Orders SET OrdCollChanged='" + DateTime.Today.ToSQLString() + "', OrdCollDate='" + data.JobLCollDateValue.ToSQLString() + "' WHERE OrdId=" + data.JobLOrderValue;
                        IQApp.DB.Execute(SQL);
                    }
                }
            });
            DS.AddOnChange<JobLine>(x => x.JobLCollDate2, data =>
            {
                if (data.JobLCollDate2Value.FTLCheckDate() == false)
                    data.JobLCollDate2.DataValue = DateTime.MinValue;
                else
                {
                    if (data.JobLOrderValue > 0)
                    {
                        string SQL = "UPDATE Orders SET OrdCollChanged='" + DateTime.Today.ToSQLString() +
                                     "', OrdCollDate2='" + data.JobLCollDate2Value.ToSQLString() + "' WHERE OrdId=" +
                                     data.JobLOrderValue;
                        IQApp.DB.Execute(SQL);
                    }
                }
            });
            DS.AddOnChange<JobLine>(x => x.JobLDelDate, data =>
            {
                if (data.JobLDelDateValue.FTLCheckDate() == false)
                    data.JobLDelDate.DataValue = DateTime.MinValue;
                else
                {
                    if (data.JobLOrderValue > 0)
                    {
                        string SQL = "UPDATE Orders SET OrdDelChanged='" + DateTime.Today.ToSQLString() +
                                     "', OrdDateDel='" + data.JobLDelDateValue.ToSQLString() + "' WHERE OrdId=" +
                                     data.JobLOrderValue;
                        IQApp.DB.Execute(SQL);
                    }
                }
            });
            DS.AddOnChange<JobLine>(x => x.JobLOrder, data =>
            {
                if (data.JobLOrderValue == 0) return;

                var j = DS.GetByField<JobLine>(x => x.JobLOrder, data.JobLOrderValue);

                string SQL = "SELECT JobLJobNo, JobLLineLetter FROM JobLine WHERE JobLOrder=" + data.JobLOrderValue;
                if (j.RecordID.HasValue)
                {
                    IQApp.CR.MessageBoxOK("This order has already been assigned to job " +
                                    DS.GetStringByKey<Job>(x=> x.JobNoValue,j.JobLJobNoValue) + j.JobLLineLetterValue +
                                    " and cannot be assigned again.");
                    data.JobLOrderValue = 0;
                    return;
                }
                data.JobLCustValue = DS.GetStringByKey<Customer>(x=> x.CustNameValue, DS.GetIntByKey<Orders>(x=> x.OrdCustValue,data.JobLOrderValue));
                SQL = "UPDATE Orders SET OrdJobNo='" + data.JobLJobNoValue + "', OrdJobLetter='" +
                      data.JobLLineLetterValue + "', OrdJob='" + data.Parent.JobNoValue + data.JobLLineLetterValue + "'";
                if (data.JobLCollDateValue == DateTime.MinValue) SQL = SQL + ", OrdCollDate=Null";
                else SQL = SQL + ", OrdCollDate='" + data.JobLCollDateValue.ToSQLString() + "'";
                if (data.JobLCollDate2Value == DateTime.MinValue) SQL = SQL + ", OrdCollDate2=Null";
                else SQL = SQL + ", OrdCollDate2='" + data.JobLCollDate2Value.ToSQLString() + "'";
                if (data.JobLDelDateValue == DateTime.MinValue) SQL = SQL + ", OrdDateDel=Null";
                else SQL = SQL + ", OrdDateDel='" + data.JobLDelDateValue.ToSQLString() + "'";
                SQL = SQL + " WHERE OrdId=" + data.JobLOrderValue;
                IQApp.DB.Execute(SQL);
            });
        }


        public static void DelLine(JobLine data)
        {
            string Msg = "Are you sure you want to delete this order: " + data.JobLOrderValue + " from this job?";
            IQApp.CR.MessageBoxYesNo<JobLine>(Msg, DelLineYes);
        }

        public static void DelLineYes(JobLine data)
        {
            string SQL = "UPDATE Orders SET OrdJobNo=0, OrdJobLetter=Null, OrdJob=Null, OrdCollDate=Null, OrdCollDate2=Null, OrdDateDel=Null WHERE OrdId=" + data.JobLOrderValue;
            IQApp.DB.Execute(SQL);
            SQL = "DELETE JobLine WHERE RecordId=" + data.RecordID.Value;   //MARKM: Should provide framework method for DeleteByRecordID
            IQApp.DB.Execute(SQL);

            IQApp.CR.UrlToLoad("/").InfoMessage("Job Line Deleted");
        }
    }
}