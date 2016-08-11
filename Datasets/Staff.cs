using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL
{
    public class StaffRegister
    {
        public static void Register()
        {
            DS.AddOnChange<Staff>(x => x.StfFN, data =>
            {
                data.StfNameValue = data.StfFNValue + " " +
                                    data.StfNameValue;
            });
            DS.AddOnChange<Staff>(x => x.StfSN, data =>
            {
                data.StfNameValue = data.StfFNValue + " " +
                                    data.StfNameValue;
            });
        }
    }
}