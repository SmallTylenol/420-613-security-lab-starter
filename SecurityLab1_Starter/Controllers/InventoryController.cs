using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }
    }
    public class UserMvcController : Controller {
        protected override void OnException(ExceptionContext filterContext) 
            {
            filterContext.ExceptionHandled = true;
            //Log the error!!
            System.Diagnostics.Debug.WriteLine(filterContext.Exception);
            //Redirect or return a view, but not both.
            filterContext.Result = RedirectToAction("Index", "ErrorHandler");
            
        }
    }
}
