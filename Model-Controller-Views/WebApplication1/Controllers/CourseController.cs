using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            var Course = new Course();
            Course.Id = 1;
            Course.Title = "ASP.Net Core Kampı";
            Course.Description = "ASP.NET Kampi başlamıştır";
            Course.Image = "1.jpg";
            return View(Course);
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return Redirect("/course/list");
            }
            var Course = Repository.getById(id);
            return View(Course);
        }
        public IActionResult List()
        {
            return View("List",Repository.getAllCourses);
        }
    }
}
