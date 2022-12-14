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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IContentfulClient _client;

        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index(string username)
        {
            // Check if the username is null
            if (username == null)
            {
                // If it is null, redirect to the login page
                return RedirectToAction("Index", "Login");
            }

            // Get the user with the username
            var users = await _client.GetEntries<Destiny2StatsTracker>();

            var user = users.Where(x => x.Username == username).FirstOrDefault();

            // Check if the user is null
            if (user == null)
            {
                // If it is null, redirect to the login page
                return RedirectToAction("Index", "Login");
            }
            
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
