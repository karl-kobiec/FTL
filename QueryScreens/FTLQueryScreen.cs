using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public abstract class FTLQueryScreen : IReportBase
    {
        public abstract IScreenBase PopulateFromWD(WebData xf);

        public string GetView()
        {
            return "";
        }

        public void ForEachElement(Action<IElementBase> action)
        {
            // nothing here
        }

        public void PushChangesToWebAction()
        {
            // nothing to do?
        }

        public abstract WebData ToPairList();
        public abstract bool IsPopulated(WebData xf);
        public abstract string ToParams();
        public abstract string ToHTML();
        public abstract string ExecuteView();
        public abstract void UpdateFromWebData(WebData xf);
    }
}