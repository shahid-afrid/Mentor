using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student (Landing page with Register and Login buttons)
        public IActionResult Index()
        {
            return View();
        }

        // GET: Student/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Student/Register
        [HttpPost]
        public IActionResult Register(string fullName, string year, string branch, string email, string password)
        {
            // TODO: Implement registration logic
            // For now, redirect to login
            return RedirectToAction("Login");
        }

        // GET: Student/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Student/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // TODO: Implement authentication logic
            // For now, redirect to dashboard
            return RedirectToAction("Dashboard");
        }

        // GET: Student/Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: Student/SelectFaculty
        public IActionResult SelectFaculty()
        {
            return View();
        }

        // POST: Student/SelectFaculty
        [HttpPost]
        public IActionResult SelectFaculty(/* TODO: Add model for faculty selections */)
        {
            // TODO: Implement faculty selection logic
            return RedirectToAction("SelectedFaculty");
        }

        // GET: Student/SelectedFaculty
        public IActionResult SelectedFaculty()
        {
            return View();
        }
    }
}
