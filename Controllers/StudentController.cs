using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCore_2.Models;

namespace NetCore_2.Controllers;
public class StudentController : Controller
{
    public IActionResult Index(){
        return View();
    } 
    public IActionResult Create(){
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std){
        String message = std .StudentID + "-";
        message += std.StudentName + "-";
        message += std.Age +"-";
        return View();
    }
}