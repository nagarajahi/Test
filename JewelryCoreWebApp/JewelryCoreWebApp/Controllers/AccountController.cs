using JewelryCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JewelryCoreWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<ActionResult>MyLogin(AccountModel AccountModel)
        {
            string response = string.Empty;
            string stringData = JsonConvert.SerializeObject(AccountModel);
            var Data = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
            using (var httpClientHandler = new HttpClientHandler())
            {
                using (var client = new HttpClient(httpClientHandler))
                {
                    var url = _configuration.GetValue<string>("AppSettings:APIUrl");
                    

                    var result = await client.PostAsync(url, Data);
                    if (result.IsSuccessStatusCode)
                    {
                        response = await result.Content.ReadAsStringAsync();
                    }
                }
            }
            if (response != null && response != "")
            {
                return RedirectToAction("Index", "Estimation", new { response });
            }
            else
            {
                ViewBag.ErrorMsg = "Invalid Login";
                //return RedirectToAction("Login", "Account", new { response });

            }
            return View("Login");
        }
    }
}
