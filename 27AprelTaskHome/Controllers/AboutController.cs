using Microsoft.AspNetCore.Mvc;

namespace _27AprelTaskHome.Controllers
{
    public class AboutController:Controller
    {
        public IActionResult Index(int id)
        {
            return View("Index");
            //ViewResult viewResult = new ViewResult();
            //viewResult.ViewName = "Index";
        }
        public IActionResult Contact(int id) 
        {
            return View("Contact");
            //    ViewResult viewResult = new ViewResult();
            //    viewResult.ViewName = "Contact";
        }

       
    }
}
