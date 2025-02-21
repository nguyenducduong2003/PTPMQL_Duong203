using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

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
    [HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput = "Ơn giời: " + FullName + " - Đây rồi: " + Address;
        ViewBag.Message = strOutput;
        return View();
    }
    
        public IActionResult Privacy()
        {
            return View();
        }
}
