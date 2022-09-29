using Microsoft.AspNetCore.Mvc;
using NetCore_2.Models;

namespace NetCore_2.Controllers;
public class DemoController : Controller{
    StringProcess strPro = new StringProcess();
    public IActionResult XuLyChuoi()
    {
        return View();
    }
    [HttpPost]
    public IActionResult XuLyChuoi(string strInput)
    {   
        ViewBag.thongTin = strPro.RemoveRemainingWhiteSpace(strInput);
       
        return View();    
    }
}