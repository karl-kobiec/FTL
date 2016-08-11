using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class EMailRegister
    {
        public static void Register()
        {
            DS.AddOnDataSource<EMail>(x=> x.EMBCCRecords, data => {
                if (data.EMDSValue != "" && data.EMDFValue != "")
                    return "select " + DSUtil.GetKeyField(data.EMDSValue) + " as KeyValue, " + DSUtil.GetTitleField(data.EMDSValue) + " as Description from " + data.EMDSValue;
                return "";
            });
            DS.AddOnDataSource<EMail>(x => x.EMCCRecords, data => {
                if (data.EMDSValue != "" && data.EMDFValue != "")
                    return "select " + DSUtil.GetKeyField(data.EMDSValue) + " as KeyValue, " + DSUtil.GetTitleField(data.EMDSValue) + " as Description from " + data.EMDSValue;
                return "";
            });
            DS.AddOnDataSource<EMail>(x => x.EMToRecords, data => {
                if (data.EMDSValue != "" && data.EMDFValue != "")
                    return "select " + DSUtil.GetKeyField(data.EMDSValue) + " as KeyValue, " + DSUtil.GetTitleField(data.EMDSValue) + " as Description from " + data.EMDSValue;
                return "";
            });
            DS.AddOnLoad<EMail>(data=> {
                if (data.EMDSValue == "" || data.EMDFValue == "")
                {
                    data.EMToRecords.Visible = false;
                    data.EMCCRecords.Visible = false;
                    data.EMBCCRecords.Visible = false;
                    data.EMToRecords.LabelVisible = false;
                    data.EMCCRecords.LabelVisible = false;
                    data.EMBCCRecords.LabelVisible = false;
                }
                if (data.EMFromValue == "0" || data.EMFromValue == "")
                {
                    data.EMFromValue = IQApp.User.GetEmail();
                }
            });
        }
       
        
    }
}