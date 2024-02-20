using ECommerceASP.Data;
using ECommerceASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceASP.Controllers
{
    public class NUsersController : Controller
    {

        public NUsersController(AppDbContext db)
        {
            _db = db;
        }
        private readonly AppDbContext _db;  
        

        public IActionResult Index()
        {
            IEnumerable<NUser> UserList = _db.Users.ToList();
            return View(UserList);
        }


        //get
        public IActionResult AddUser()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUser(NUser user)
        {   
            //Condition (Save)
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                TempData["successData"] = "created a new User !";
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //get Edit
        public IActionResult Edit(int? ID )
        {
            if(ID==null || ID==0)
            {
                return NotFound();
            }
            var user = _db.Users.Find(ID);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NUser user)
        {
            //Condition (Save)
            if (ModelState.IsValid)
            {
                _db.Users.Update(user);
                _db.SaveChanges();
                TempData["successData"] = "updated the User !";
                return RedirectToAction("Index");
            }
            return View(user);
        }


        //get Delete
        public IActionResult Delete(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var user = _db.Users.Find(ID);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUser(int? ID)
        {
            var user = _db.Users.Find(ID);
            if (user == null)
            {
                return NotFound();
            }
            _db.Remove(user);
            _db.SaveChanges();
            TempData["successData"] = "deleted the User !";
            return RedirectToAction("Index");
        }
    }
}
