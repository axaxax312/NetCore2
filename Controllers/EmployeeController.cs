using Microsoft.AspNetCore.Mvc;

namespace NetCore_2.Controllers;
public class Employee : Controller{
    public IActionResult IndexEmployee(){
        return View("/Employee/Index.cshtml");
    }
}