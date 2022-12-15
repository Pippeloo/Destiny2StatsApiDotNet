using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Destiny2StatsApiDotNet.Models;
using Contentful.Core;

namespace Destiny2StatsApiDotNet.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        private readonly IContentfulClient _client;

        public LoginController(ILogger<LoginController> logger, IContentfulClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index(string error)
        {
            // Show the error if there is one in the page
            if (error != null)
            {
                ViewBag.Error = error;
            }

            // Get the logo from contentful
            var logo = await _client.GetAsset("4iHXZYm87N3Q2C3Ld9GCyR");

            // Set the logo url to the viewbag
            ViewBag.Logo = logo.File.Url;

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            var user = await _client.GetEntries<Login>();

            for (int i = 0; i < user.Count(); i++)
            {
                if (user.ElementAt(i).Username == model.Username)
                {
                    // Return to the home page with the models username
                    return RedirectToAction("Index", "Home", new { username = model.Username });
                }
            }

            // Return to the login page and display an error
            return RedirectToAction("Index", "Login", new { error = "User doesn't exist!" });
        }
    }
}