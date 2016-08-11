using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL
{
    public class QueryScreensRegister
    {
        public static void Register()
        {
            SC.AddOnLoad<UnDecWithMonthModel>(f =>
            {
                f.Month.SetDataSource("select MthId as KeyValue, MthName as [Description] from Months");
            });
            SC.AddOnLoad<UnDecWithDatesModel>(f =>
            {
             //   f.Type.SetDataSource(
               //     "select 1 as KeyValue, 'Summary' as [Description] union select 2 as KeyValue, 'Detail' as [Description]");
            });
          

            SC.AddOnLoad<StaffAndDestModel>(f =>
            {
                f.From.SetDataSource("select StfId as KeyValue, StfName as [Description] from Staff");
                f.EmailTo.SetDataSource(
                    "select 0 as KeyValue, 'Supplier' as [Description] union select 1 as KeyValue,'Collection Point' as Description");
            });

            SC.AddOnLoad<TransportDetModel>(f =>
            {
                f.Staff.SetDataSource("select StfId as KeyValue, StfName as [Description] from Staff");
                f.Type.SetDataSource(@"select 0 as KeyValue, 'Full Load' as [Description] union 
                                    select 1 as KeyVAlue, 'FTL Driver' as [Description]
                                union select 2 as KeyValue, 'Subcontractor' as [Description]
                                union select 3 as KeyValue, 'Tesco Load' as [Description]");
            });

            SC.AddOnLoad<TransportChargesModel>(f =>
            {
                f.TypeValue = "1";
                f.Month.SetDataSource("select MthId as KeyValue, MthName as [Description] from Months order by MthSDate");
                f.Type.SetDataSource(
                    "select 1 as KeyValue, 'Summary' as [Description] union select 2 as KeyValue, 'Detail' as [Description]");
                OnType(f);

            });

            SC.AddOnChange<TransportChargesModel>(x => x.Type, OnType);
        }

        public static void OnType(TransportChargesModel f)
        {
            {
                if (f.TypeValue == "1")
                {
                    f.JobNo.Enabled = false;
                    f.Month.Enabled = true;
                }
                else
                {
                    f.JobNo.Enabled = true;
                    f.Month.Enabled = false;
                }
            }
        }
    }

}