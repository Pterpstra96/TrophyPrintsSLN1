using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrophyPrints.Models;
using TrophyPrints.Services;

namespace TrophyPrints.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult regpage()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel newUser)
        {
            /* if ()  WILL NEED IF THEN STATEMENT TO VERIFY USER LOGIN INFORMATION */

            SecurityService security = new SecurityService();
            if (security.isValid(newUser))
            {
                return View("LoginSuccess", newUser);
            }
            else 
            
            {
                return View("LoginFailure", newUser);
            }

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
