using GFL.TestTask.Database;
using Microsoft.AspNetCore.Mvc;

namespace GFL.TestTask.ViewComponents
{
    public class FolderViewComponent : ViewComponent
    {
        private AppDbContext _context;
        public FolderViewComponent(AppDbContext context)
        {
            _context =  context;
        }
        public IViewComponentResult Invoke(int id = 1)
        {
            var folder = _context.Folders.Where(x => x.Id == id).FirstOrDefault();
            return View(folder);
        }
        
    }
}