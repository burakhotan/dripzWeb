using System;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController: Controller
    {
        public IActionResult Index(){
            int hour=DateTime.Now.Hour;

           ViewBag.Greeting= hour>12?"İyi günler":"Günaydın";
           ViewBag.Username= "Burak";
            return View();
        }
        public IActionResult About(){
            return View();
        }
    }
}