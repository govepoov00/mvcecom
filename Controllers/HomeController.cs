using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcecom.Models;


namespace mvcecom.Controllers;

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

    public IActionResult Product()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Cart()
    {
        return View();
    }

    public IActionResult Checkout()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

     public IActionResult Order()
    {
        return View();
    }

     public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


