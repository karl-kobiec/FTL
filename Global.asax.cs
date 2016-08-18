using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebPages;
using FTL.Functions;
using IQ6.Core;

namespace FTL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            

          //  JDash.Mvc.Core.App.Initialize();

            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            try {
                PrecompiledMvcEngine engine = new IQ6.Core.PrecompiledMvcEngine(typeof(MvcApplication).Assembly);
                ViewEngines.Engines.Add(engine);
                VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);

            }
            catch (Exception ex)
            {
                string Error = "";
                Error += ex.Message + "\n";
                if (ex.InnerException != null)
                {
                    Error += ex.InnerException.Message + "\n";
                    if (ex.InnerException.InnerException != null)
                        Error += ex.InnerException.InnerException.Message + "\n"; 
                }
                throw new Exception(Error);
            }
            ControllerBuilder.Current.SetControllerFactory(typeof(IQExtendableControllerFactory));
            IQ6.Core.IQApp.RunAppStartup(new FTL.UserAuthentication.User(), new IQ6.Core.Database("IQ6"), new Intrinsiq.LocalFileHandler.FileHandler(),
                new DSMapper(), new IQSettings(), new FTL.QueryScreens.FTLScreenMapper(), new Operators());

            FTL.Datasets.DSRegister.Register(); // custom ftl callbacks
            Intrinsiq.Query.QM.Register<Query>();
            Intrinsiq.Email.EmailModule.Register<EMail, EmailTemplatess>();
            Intrinsiq.WordDocument.WordModule.Register<WordDocument>();
            Intrinsiq.Reporting.ReportingRegister.Register<FTL.Reporting>();
           
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exe = Server.GetLastError();

          
            /*string sql = "IF EXISTS ( SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ErrorLog' ) INSERT INTO ErrorLog (UserId, ErrorDate, ErrorText, Status, StatusText, RequestURL) VALUES ("
                + IQApp.User.GetUserId() + ", GetDate(),'','','" + exe.Message.Replace("'", "''") + exe.StackTrace + "','" + HttpContext.Current.Request.Url.ToString() + "')";
            IQApp.DB.Execute(sql);
            */
         //   Server.TransferRequest("/?message=An error occured with your last request, please try again or contact support");
        }
    }
}
