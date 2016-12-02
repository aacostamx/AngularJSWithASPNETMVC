using AngularJSWithASPNETMVC.Models;
using System.Web.Mvc;

namespace AngularJSWithASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var employee = new Employee() { FirstName = "Antonio", LastName = "Acosta" };
            return View(employee);
        }


        public ActionResult UpdateDate(Employee param)
        {
            var emp = new Employee() { FirstName = "Ing. Antonio", LastName = "Acosta Murillo", Input = param.Input + " -- Sucessful Update --"};
            return Json(emp, JsonRequestBehavior.AllowGet);
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
    }
}