using Globe.Data;
using Globe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Globe.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDBContext _dBContext;

        public HomeController(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }

        public IActionResult Sarch(string sarch)
        {
            ViewData["Title"] = "Sarch";

            ViewData["Sarching"] = sarch;

            IEnumerable<News> News = from n in _dBContext.News
                                    select n;

            if(!string.IsNullOrEmpty(sarch))
            {
                News = News.Where(n => n.Title.Contains(sarch));
            }

            return View(News);
        }

        public IActionResult News()
        {
            ViewData["Title"] = "News";
            return View();
        }

        public IActionResult Politics()
        {
            ViewData["Title"] = "Politics";
            return View();
        }

        public IActionResult Health()
        {
            ViewData["Title"] = "Health";
            return View();
        }

        public IActionResult Sport()
        {
            ViewData["Title"] = "Sport";
            return View();
        }

        public IActionResult Technology()
        {
            ViewData["Title"] = "Technology";
            return View();
        }

        public IActionResult Favorite()
        {
            ViewData["Title"] = "Favorite";
            return View();
        }

        public IActionResult Post()
        {
            ViewData["Title"] = "Post";
            return View();
        }

        public IActionResult Create_Plog()
        {
            ViewData["Title"] = "Create Plog";
            return View();
        }

        public IActionResult Dashbord()
        {
            ViewData["Title"] = "Dashbord";
            return View();
        }

        public IActionResult Edit_Account()
        {
            ViewData["Title"] = "Edit Account";
            return View();
        }

        public IActionResult Create_Account()
        {
            ViewData["Title"] = "Create Account";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
