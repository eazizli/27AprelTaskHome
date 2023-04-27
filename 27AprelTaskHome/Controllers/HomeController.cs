using Microsoft.AspNetCore.Mvc;

namespace _27AprelTaskHome.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index(int id)
        {
            //ViewResult viewResult=new ViewResult();
            //viewResult.ViewName = "Index";
            return View();
        }
    }
}
