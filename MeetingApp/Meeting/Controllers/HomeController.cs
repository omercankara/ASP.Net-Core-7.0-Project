using Microsoft.AspNetCore.Mvc;
using Meeting.Models;

namespace Meeting.Controllers
{
    public class HomeController : Controller
    {
        //localhost/
        public IActionResult Index()
        {
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            int saat = DateTime.Now.Hour;
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewData["UserName"] = "Ömercan";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Mavi Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }

    }
}
