using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class CustomerRegister
    {
        public static void Register()
        {
            DS.AddOnChange<Customer>(x => x.CustCredScore, data =>
            {
                if (data.CustCredScoreReviewValue == DateTime.MinValue)
                    data.CustCredScoreReviewValue = DateTime.Today.AddMonths(6);
            });
            DS.AddOnChange<Customer>(x => x.CustName, data =>
            {
                if (data.CustCreatedByValue == 0)
                    data.CustCreatedByValue = IQApp.User.GetUserId();
            });
        }
       
    }
}