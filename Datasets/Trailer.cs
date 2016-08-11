using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class TrailerRegister
    {
        public static void Register()
        {
            DS.AddOnDrawSingleToolbar<Trailer>(data => new List<Element>()
            {
                WebButton.CallbackButton<Trailer>("Recalculate Status", RecalculateStatus)

            });
            DS.AddOnChange<Trailer>(x => x.TrlLastMOT, data =>
            {
                data.TrlNextMOTDueValue =
                    data.TrlLastMOTValue.AddYears(1);
            });
            DS.AddOnChange<Trailer>(x => x.TrlLastServ, data =>
            {
                data.TrlNextServDueValue =
                    data.TrlLastServValue.AddYears(1);
            });

        }


        public static void RecalculateStatus(Trailer data)
    {

        IQApp.DB.Execute("UPDATE Trailer SET TrlStatusValue='OK'");
        IQApp.DB.Execute("UPDATE Trailer SET TrlStatusValue='DUE' WHERE datediff(d,TrlNextServDueValue,getdate()) < 8");
        IQApp.CR.MessageBoxOK("Trailer Statuses have been updated");

    }
}
}