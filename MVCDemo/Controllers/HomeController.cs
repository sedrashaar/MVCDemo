using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View(); 
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }



        //public ActionResult Index()
        //{
        //    //ContentResult contentResult = new ContentResult();
        //    //contentResult.Content = "Hello from content result";
        //    //return contentResult;

        //    return Content("Hello from content"); 
        //}


        //public ActionResult AboutUs()
        //{
        //  
        //    return RedirectToAction("Index");
        //}
    }
}
