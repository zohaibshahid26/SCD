using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(User u) {


            if (ModelState.IsValid)
            {
                return View(u);
            }
            else { 
            return View();
            }
        
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
