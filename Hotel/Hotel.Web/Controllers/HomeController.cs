using Hotel.Models;
using Hotel.Web.Models;
using Hotel.Toools.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContextLPL _dbContext;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger,DataContextLPL dataContext,IEmailSender emailSender)
        {
            _logger = logger;
            _dbContext = dataContext;
            _emailSender =emailSender;
        }

        public IActionResult Index()
        {
            var hoteles = _dbContext.Hoteles.Where(c => c.Estatus == true);
            //_emailSender.SendEmailAsync("", "","");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
