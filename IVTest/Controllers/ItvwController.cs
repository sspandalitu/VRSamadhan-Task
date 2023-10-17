using IVTest.Data;
using IVTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IVTest.Controllers
{
    public class ItvwController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ItvwController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.UserData = new SelectList(_context.ShyamTb, "Id", "UserName");
            ViewBag.SecondTableData = new SelectList(_context.TableTwo, "id", "Subjects");
            return View();
        }
        [HttpPost]
        public IActionResult SaveData([FromBody] List<FinalMdl> dataItems)
        {
            if (dataItems != null && dataItems.Count > 0)
            {
                // Remove existing data in the database (optional)
                //_context.FinalTb.RemoveRange(_context.FinalTb);
                //_context.SaveChanges();

                // Save the new data to the database
                _context.FinalTb.AddRange(dataItems);
                _context.SaveChanges();

                return Ok(); // Return an HTTP 200 OK status if the data is saved successfully.
            }

            return BadRequest("Data is empty or invalid.");
        }
    }
}
