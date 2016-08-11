using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class UKOrderRegister
    {
        public static void Register()
        {
            DS.AddOnChange<UKOrder>(x => x.UKOJobNo, data => {
                if (data.UKOCreatedByValue == 0) data.UKOCreatedByValue = IQApp.User.GetUserId();
            });
        }


    }
}