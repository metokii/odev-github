using System.Diagnostics;
using kitap_olışturma.Models;
using Microsoft.AspNetCore.Mvc;
using ödev.Models;

namespace ödev.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
            kitap kitapp = new kitap();

         kitapp.kitapad= "Hapishanede Felsefe";
         kitapp.yazarad = "Andy West";
         kitapp.yayinlanma = "23.10.2023";
           kitapp.türü= "Felsefe";
         kitapp.sayfasayisi = "312";
         kitapp.fiyat = "131tl";
        return View(kitapp);
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
