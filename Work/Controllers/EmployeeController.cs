using Microsoft.AspNetCore.Mvc;
using Work.Data;
using Work.Models;

namespace Work.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Employee> objEmployeeList = _db.Employees.ToList();
            return View(objEmployeeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The display order cannot exactly match the name");
            }

            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
           return View();
        }

    }
}
