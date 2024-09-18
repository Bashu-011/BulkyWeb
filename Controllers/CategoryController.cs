using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        //field that assigns _db to db
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            //we will now use _db.Category to run querries
            _db = db;
            
        }
        public IActionResult Index()
        {   
            //extract from the db and store in a list
            List<Category> objCategoryList = _db.Category.ToList();
            return View(objCategoryList);
        }
    }
}
