using GFL.TestTask.Database;
using Microsoft.AspNetCore.Mvc;

namespace GFL.TestTask.ViewComponents
{
    public class FolderContentViewComponent : ViewComponent
    {
        private AppDbContext _context;
        public FolderContentViewComponent(AppDbContext context)
        {
            _context =  context;
        }
        public IViewComponentResult Invoke(int id = 1)
        {
            var folders = _context.Folders.Where(x => x.ParentId == id).ToList();
            return View(folders);
        }
        
    }
}