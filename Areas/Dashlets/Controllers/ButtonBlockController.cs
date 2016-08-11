using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQ6.Core;
using JDash;
using JDash.Models;

namespace FTL.Areas.Dashlets
{
    public class ButtonForBlockModel
    {
        public int Type { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
    }
    public class ButtonBlockModel
    {
        public ButtonBlockModel()
        {
            Buttons = new List<ButtonForBlockModel>();
        }
        public List<ButtonForBlockModel> Buttons { get; set; } 
        public static ButtonBlockModel FromFormCollection(FormCollection fc)
        {
            var bb= new ButtonBlockModel();
            var c = 6;

            for(int i = 0; i < c; i++)
            {
                bb.Buttons.Add(new ButtonForBlockModel()
                {
                    Url = fc["Url-" + i].ToNotNull(),
                    Title = fc["Caption-" + i].ToNotNull(),
                    Type = fc["Type-" + i].ToInt(0)
                });
            }
       
            return bb;
        }

        public string AsJSON()
        {
            return JSONUtil.ToJsonString(this);
        }

        public static ButtonBlockModel FromJSON(string js)
        {
            return JSONUtil.Decode<ButtonBlockModel>(js);
        }
    }
    public class ButtonBlockController : Controller
    {
        public ActionResult Index(string id)
        {
            var d = JDashManager.Provider.GetDashlet(id);

            ButtonBlockModel data = new ButtonBlockModel();

            try
            {
                data = ButtonBlockModel.FromJSON(d.config.Get<string>("buttonConfig"));
            }
            catch (KeyNotFoundException)
            {
                
            }
            return View(data);
        }

        public ActionResult Editor(string id)
        {
            var d = JDashManager.Provider.GetDashlet(id);
            ButtonBlockModel data = new ButtonBlockModel();
            
            try
            {
                data = ButtonBlockModel.FromJSON(d.config.Get<string>("buttonConfig"));
            }
            catch (KeyNotFoundException)
            {
            }
            return View(data);
        }

        [HttpPost]
        public ActionResult Save(string id, FormCollection fc)
        {
            var dashlet = JDashManager.Provider.GetDashlet(id);
            dashlet.LoadProperties(fc["DashletProperties"]);

            dashlet.config["buttonConfig"] = ButtonBlockModel.FromFormCollection(fc).ToJsonString();
            JDashManager.Provider.SaveDashlet(dashlet);
            return new EmptyResult();
            
        }
    }

    public class ButtonBlock : DashletModuleModel
    {
        public ButtonBlock()
        {
            this.title = "Shortcut Buttons";
            config.Add("mvcConfig", new {controller = "/Dashlets/ButtonBlock"});
            path = "[MVCDefault]";
            this.config.Add("editor", new {useWindow = true, paneConfig = new {width = "700px", Height = "500px"}});
            this.paneConfig.Add("builtInCommands", new string[] { "remove"});
        }
    }
}
