using GFL.TestTask.Database;
using Microsoft.AspNetCore.Mvc;

namespace GFL.TestTask.Controllers{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
             public IActionResult Index()
             {
                return View();
             }  

            [HttpGet("{id}")]
             public IActionResult Folder(int id)
             {
                var folder = _context.Folders.FirstOrDefault(x => x.Id == id);
                return View(id);
             }
     }
}