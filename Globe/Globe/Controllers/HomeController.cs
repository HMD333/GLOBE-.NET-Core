using Globe.Data;
using Globe.Models;
using Globe.Models_DB;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;

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

            IEnumerable<News> News = from n in _dBContext.News
                                    select n;

            if(!string.IsNullOrEmpty(sarch))
            {
                News = News.Where(n => n.Title.Contains(sarch));
            }

            return View(News);
        }

        public IActionResult Politics()
        {
            ViewData["Title"] = "Politics";

            IEnumerable<News> News = _dBContext.News.Where(n => n.Type == "Politics");

            return View(News);
        }

        public IActionResult Health()
        {
            ViewData["Title"] = "Health";

            IEnumerable<News> News = _dBContext.News.Where(n => n.Type == "Health");

            return View(News);

        }

        public IActionResult Sport()
        {
            ViewData["Title"] = "Sport";

            IEnumerable<News> News = _dBContext.News.Where(n => n.Type == "Sport");

            return View(News);
        }

        public IActionResult Technology()
        {
            ViewData["Title"] = "Technology";

            IEnumerable<News> News = _dBContext.News.Where(n => n.Type == "Technology");

            return View(News);
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

        [HttpPost]
        public IActionResult new_auther(_Auther au)
        {

            IEnumerable<Auther> Auther = from u in _dBContext.Auther
                                     select u;
            Auther = Auther.Where(n => (n.Username == au.Username || n.Email == au.Username) && n.Password == au.Password);

            if (!Auther.Any())
            {
                if (au.Password == au.RePassword)
                {
                    _dBContext.Auther.Add(
                    new Auther
                    {
                        Fist_Name = au.First_Name,
                        Last_Name = au.Last_Name,
                        Username = au.Username,
                        Password = au.Password,
                        Email = au.Email
                    });

                    _dBContext.SaveChanges();
                }
                
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult regastration()
        {
            string r_fname = Request.Form["r_fname"];
            string r_lname = Request.Form["r_lname"];
            string r_uname = Request.Form["r_uname"];
            string r_email = Request.Form["r_email"];
            string r_password = Request.Form["r_password"];
            string r_repassword = Request.Form["r_repassword"];
            string? _usename = null;
            string? _type = null;

            if (r_fname != null && r_lname != null && r_uname != null && r_email != null && r_password != null && r_repassword != null)
            {
                IEnumerable<User> User = from u in _dBContext.User
                                         select u;
                User = User.Where(n => (n.Usar_Name == r_uname || n.Email == r_email) && n.password == r_password);

                if (!User.Any())
                {
                    if (r_password == r_repassword)
                    {
                        _dBContext.User.Add(
                        new User
                        {
                            First_Name = r_fname,
                            Last_Name = r_lname,
                            Usar_Name = r_uname,
                            password = r_password,
                            Email = r_email
                        });

                        _dBContext.SaveChanges();

                        _usename = User.First().Usar_Name;
                        _type = "ur";
                        //Admin = Admin.Where(n => n.User_Name.Contains(login));
                        //To Save User Name
                        CookieOptions ur = new CookieOptions();
                        ur.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Append("User_Name", _usename, ur);
                        // To Save Athoraies
                        CookieOptions ath = new CookieOptions();
                        ath.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Append("User_type", _type, ath);
                    }

                }
                else
                {
                    _usename = User.First().Usar_Name;
                    _type = "ur";
                    //Admin = Admin.Where(n => n.User_Name.Contains(login));
                    //To Save User Name
                    CookieOptions ur = new CookieOptions();
                    ur.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Append("User_Name", _usename, ur);
                    // To Save Athoraies
                    CookieOptions ath = new CookieOptions();
                    ath.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Append("User_type", _type, ath);
                }
            }
           return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult login()
        {
            string l_username = Request.Form["l_username"];
            string l_password = Request.Form["l_password"];
            string? _usename = null;
            string? _type = null;

            if (l_username != null && l_password != null)
            {
                IEnumerable<Admin> Admin = from u in _dBContext.Admin
                                           select u;
                Admin = Admin.Where(n => (n.User_Name == l_username || n.Email == l_username) && n.Password == l_password);

                if (Admin.Any())
                {
                    _usename = Admin.First().User_Name;
                    _type = "ad";
                    //Admin = Admin.Where(n => n.User_Name.Contains(login));
                    //To Save User Name
                    CookieOptions ur = new CookieOptions();
                    ur.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Append("User_Name", _usename, ur);
                    // To Save Athoraies
                    CookieOptions ath = new CookieOptions();
                    ath.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Append("User_type", _type, ath);
                }
                else
                {
                    IEnumerable<Auther> Auther = from u in _dBContext.Auther
                                                 select u;
                    Auther = Auther.Where(n => (n.Username == l_username || n.Email == l_username) && n.Password == l_password);

                    if (Auther.Any())
                    {
                        _usename = Auther.First().Username;
                        _type = "au";
                        //Admin = Admin.Where(n => n.User_Name.Contains(login));
                        //To Save User Name
                        CookieOptions ur = new CookieOptions();
                        ur.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Append("User_Name", _usename, ur);
                        // To Save Athoraies
                        CookieOptions ath = new CookieOptions();
                        ath.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Append("User_type", _type, ath);
                    }
                    else
                    {
                        IEnumerable<User> User = from u in _dBContext.User
                                                 select u;
                        User = User.Where(n => (n.Usar_Name == l_username || n.Email == l_username) && n.password == l_password);

                        if (User.Any())
                        {
                            _usename = User.First().Usar_Name;
                            _type = "ur";
                            //Admin = Admin.Where(n => n.User_Name.Contains(login));
                            //To Save User Name
                            CookieOptions ur = new CookieOptions();
                            ur.Expires = DateTime.Now.AddMonths(6);
                            Response.Cookies.Append("User_Name", _usename, ur);
                            // To Save Athoraies
                            CookieOptions ath = new CookieOptions();
                            ath.Expires = DateTime.Now.AddMonths(6);
                            Response.Cookies.Append("User_type", _type, ath);

                        }
                    }
                }
            }
            
            return RedirectToAction("Index");

        }

        public IActionResult logout()
        {
            Response.Cookies.Delete("User_Name");
            Response.Cookies.Delete("User_type");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
