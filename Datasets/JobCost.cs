using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class JobCostRegister
    {
        public static void Register()
        {
            DS.AddOnChange<JobCost>(x=> x.JobCServProv, data=> { data.JobCServProvId.DataValue = data.JobCServProvValue; });
            DS.AddOnChange<JobCost>(x=> x.JobCServProvId, data=> { data.JobCServProv.DataValue = data.JobCServProvIdValue; });
        }
      
    }
}