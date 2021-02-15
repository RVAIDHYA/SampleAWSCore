using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleAWSCore.Models;
using SampleAWSCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAWSCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IWebHostEnvironment _environment;

        public HomeRepository homeRepository = new HomeRepository();

       
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            var webRoot = _environment.WebRootPath;

            var file = System.IO.Path.Combine(webRoot, "sitecontent\\resumeData.json");

            string filePath = file.ToString();

            homeViewModel.resume = homeRepository.GetResumeDetails(filePath);

            return View(homeViewModel);
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
