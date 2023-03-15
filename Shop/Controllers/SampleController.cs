using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers;

public class SampleController : Controller
{
    public IActionResult GetMessage()
    { 
        return PartialView("_GetMessage");
    }
    public IActionResult Index()
    {
        ViewData["Message"] = "Я сообщение";
        ViewData["Apple"] = "Яблоко";

        ViewBag.Message = "Hello ASP.NET";

        MyTest obj = new  MyTest 
        {
            Id = 1,
            Name = "Мое имя",
        };

        //string myView = "Test-1";
        
        return View("~/Views/Sample/Index.cshtml", obj);
        //return View("~/Views/Sample/Index.cshtml");
        //return View(obj);
    }
    public IActionResult About() 
    {
        return View(); 
    }
}

class MyTest
{ 
    public int Id { get; set; }
    public string Name { get; set; }
}
