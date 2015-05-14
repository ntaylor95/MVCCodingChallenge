using Lib.ModelViews;
using Lib.PageViews;
using Lib.Storage;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NicoleFun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBenefitsPageView model = new EmployeeBenefitsPageView();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult Update(Employee employee)
        {
            EmployeeStorage employeeStorage = new EmployeeStorage();
            employeeStorage.Save(employee);

            return Json(employee, JsonRequestBehavior.AllowGet); 
        }

        public PartialViewResult GetEmployees(Employee employee)
        {
            EmployeeBenefitsView model = new EmployeeBenefitsView(employee);
            return PartialView("EmployeeBenefitsPartialView", model);
        }
    }
}