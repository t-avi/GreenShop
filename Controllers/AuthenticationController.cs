using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {            
            return View("Register");
        }

        [HttpPost]
        public string MakeAnAccount(string email, string name, string phone, string address) 
        {
            return $"Done. Your account created, {name}, try to log in!";
        }
        
        public IActionResult Login()
        {
            return View("Login");
        }


        [HttpPost]
        public string MakeALogin(string email, string password)
        {
            return $"Done. You logged in, {email}!";
        }
    }
}
