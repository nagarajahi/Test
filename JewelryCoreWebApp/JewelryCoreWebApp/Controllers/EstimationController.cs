using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryCoreWebApp.Controllers
{
    public class EstimationController : Controller
    {
        public IActionResult Index(string response)
        {
            ViewBag.Profile = response.ToString();
            return View();
        }

       
    }
}
