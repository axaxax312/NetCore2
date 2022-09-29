using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore_2.Models;

namespace NetCore_2.Controllers;

public class HomeController : Controller
{
    GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult GiaiPhuongTrinh(){
        return View();
    }
    // [HttpPost]
    // public IActionResult GiaiPhuongtrinh(string hesoA,string hesoB, string hesoC, string del ){
    //     String ThongBaoBacNhat=gpt.GiaiPhuongTrinhBacNhat( hesoA, hesoB);
        
    //     ViewBag.message = ThongBaoBacNhat;
    //     return View();
        
    // }
}

