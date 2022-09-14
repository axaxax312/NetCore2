using Microsoft.AspNetCore.Mvc;

namespace NetCore_2.Controllers;
public class PersonController : Controller {
    public IActionResult IndexPerson(){
        return View("/Person/Index.cshtml");
    }
}