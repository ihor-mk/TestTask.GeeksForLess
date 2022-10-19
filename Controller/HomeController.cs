using Microsoft.AspNetCore.Mvc;

namespace GFL.TestTask.Controllers{
    public class HomeController : Controller
    {
             public IActionResult Index() => View();   
    }

}