using ECommerceASP.Data;
using ECommerceASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceASP.Controllers
{


    //Inheritance from Controller for HTTP requests handling and responses
    public class CategoriesController : Controller
    {


        /// <summary>
        /// DEPENDENCY INJECTION
        /// </summary>
        /// <param name="db"></param>
        //
        //Constructor that inject AppDbContext
        public CategoriesController(AppDbContext db)
        {
            _db = db;
        }
        //Here, a private readonly field _db is declared to hold an instance of the AppDbContext class.
        //This field will be used to interact with the database in various controller actions.
        private readonly AppDbContext _db; 


        
        public IActionResult Categories()
        {
            IEnumerable<Categories> categoriesList = _db.Categories.ToList(); // Fetch categories from the database
            return View(categoriesList);
        }


        //get
        public IActionResult AddCategory()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Categories Category)
        {   
            //Condition (Save)
            if (ModelState.IsValid)
            {
                _db.Categories.Add(Category);
                _db.SaveChanges();
                TempData["successData"] = "created a new Category item !";
                return RedirectToAction("Categories");
            }
            return View(Category);
        }
    }




}