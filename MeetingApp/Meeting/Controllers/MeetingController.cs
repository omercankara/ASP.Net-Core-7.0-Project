using Microsoft.AspNetCore.Mvc;
using Meeting.Models;
namespace Meeting.Controllers
{
    public class MeetingController : Controller
    {
   
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if(ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
           
        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }


        //Meeting/details/1
        public IActionResult Details(int Id)
        {
            return View(Repository.GetById(Id));
        }
    }
}