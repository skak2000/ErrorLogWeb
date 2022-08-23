/// Create by Skak2000
using BuisnessLogicLayer;
using System;
using System.Net;
using System.Web.Mvc;

namespace ErrorLogWeb.Controllers
{
    public class HomeController : Controller
    {
        BusinessController bc = new BusinessController();

        public ActionResult Index()
        {            
            return View(bc.GetErrorList());
        }

        public ActionResult Details(Guid id)
        {
            return View(bc.GetErrorById(id));
        }

        public ActionResult MessageLog()
        {
            return View(bc.GetMessageList());
        }

        public ActionResult MessageLogDetails(Guid id)
        {
            return View(bc.GetMessageById(id));
        }

        public ActionResult WebService()
        {
            return Redirect("/ErrorLogWS.svc");
        }

        public ActionResult Test()
        {
            try
            {               
                WebClient client = null;
                client.DownloadData("Http://google.com");

                int.Parse("Test");
            }
            catch (Exception ex)
            {
                // URL is not requeret but nice to have...
                string url = Request.Url.ToString();

                ErrorLogServices.ErrorLogWSClient client = new ErrorLogServices.ErrorLogWSClient();
                client.WriteToLog("ErrorLogWeb", ex.Message, ex.Source, ex.StackTrace, url);

                string test = Resources.Test;
                client.WriteToMessageLog("ErrorLogWeb", "MessageLog for logging stuff.");
                client.WriteToMessageLog("ErrorLogWeb", Resources.Test);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}