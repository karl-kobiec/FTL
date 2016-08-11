using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class ContactRegister
    {
        public static void Register()
        {
            DS.AddOnValidate<Contact>(data =>
            {
                if (IQApp.DB.GetInt("SELECT count(*) FROM Contact WHERE RecordID<>@RecId AND ContMainContact=1 AND ContCust=@ContCust", new { RecId = data.RecordID, ContCust = data.ContCustValue }) > 0)
                {
                    IQApp.CR.MessageBoxOK("Another contact is already designated as 'Main'. Untick the other contact first.");
                    return false;
                }
                return true;
            });

            DS.AddOnChange<Contact>(x=> x.ContFN, data=> {
                data.ContNameValue = data.ContFNValue + " " + data.ContSNValue;
            } ); DS.AddOnChange<Contact>(x => x.ContSN, data=> {
                data.ContNameValue = data.ContFNValue + " " + data.ContSNValue;
            } );
        }
        
    }
}