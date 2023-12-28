using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
   

        public IActionResult Index()
        {
            return View(Repository.getAllCourses);
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


    }
}
