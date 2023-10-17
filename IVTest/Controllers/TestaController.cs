using IVTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IVTest.Controllers
{
    public class TestaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TestaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.UserData = new SelectList(_context.ShyamTb, "Id", "UserName");
            ViewBag.SecondTableData = new SelectList(_context.TableTwo, "id", "Subjects");
            return View();
        }
    }
}
