using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessRules.DataAccess;

namespace WebCIS.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            DataAccessBoundary dataAccessBoundary = new DataAccessor();
            List<BusinessRules.HCard> hospitalCards=dataAccessBoundary.GetRegisteredHospitalCards();
            return View();
        }
        public ActionResult NewPatient()
        {
            return View();
        }
    }
}