using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessRules.BusinessModules.Registration;


namespace WebCIS.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            RegistrationOutputBoundary regOutput = new RegistrationOutputData();
            string regOutData=regOutput.GetRegisteredPatients();
            return View();
        }
        public ActionResult NewPatient()
        {
            return View();
        }
    }
}