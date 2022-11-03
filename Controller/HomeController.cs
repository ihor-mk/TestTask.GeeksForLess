using GFL.TestTask.Database;
using Microsoft.AspNetCore.Mvc;

namespace GFL.TestTask.Controllers
{
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

/*         [HttpGet("{id}")]
        public IActionResult Folder(int id)
        {
            var folder = _context.Folders.FirstOrDefault(x => x.Id == id);
            return View(id);
        } */

        [HttpGet("{fullPath}")]
        public IActionResult Folder(string fullPath)
        {
            int id = 2;
            var subs = fullPath.Split('/', StringSplitOptions.RemoveEmptyEntries);

            if (subs.Length > 0)
            {
                var currentFolder = _context.Folders.Where(x => x.ParentId == null).FirstOrDefault();

                if (subs[0] != currentFolder.Title)
                    return View(id);

                for (int i = 1; i < subs.Length; i++)
                {
                    currentFolder = _context.Folders
                        .Where(x => x.ParentId == currentFolder.Id && x.Title == subs[i])
                        .FirstOrDefault();

                    if (currentFolder is null)
                        return View(id);
                }
                return View(currentFolder.Id);
            }
            else 
            {
                return View(id);
            }
        }
    }
}