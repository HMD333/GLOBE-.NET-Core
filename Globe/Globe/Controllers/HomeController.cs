﻿using Globe.Data;
using Globe.Models;
using Globe.Models_DB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Globe.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private char[] punc ={'\'','"',';',',','!','$','{','}','[',']','(',')','%','*'};

        private readonly ApplicationDBContext _dBContext;

        public HomeController(ApplicationDBContext dBContext, IWebHostEnvironment webHostEnvironment)
        {
            _dBContext = dBContext;
            _WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {

            ViewData["Title"] = "Home";
            return View();
        }


        [HttpPost]
        public IActionResult Create_Plog(create_plog cp)
        {
            string path = Path.GetExtension(cp.Img.FileName);
            string imgUrl = "";
            if (path == ".png" || path == ".jpg")
            {

                if (cp.Type == "Spore")
                {
                    string folder = "wwwroot/asedes/img/Spore/";
                    folder += Guid.NewGuid().ToString() + path;
                    string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                    cp.Img.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                    imgUrl = folder;
                }
                else if (cp.Type == "Politics")
                {
                    string folder = "wwwroot/asedes/img/Politics/";
                    folder += Guid.NewGuid().ToString() + path;
                    string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                    cp.Img.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                    imgUrl = folder;
                }
                else if (cp.Type == "Health")
                {
                    string folder = "wwwroot/asedes/img/Health/";
                    folder += Guid.NewGuid().ToString() + path;
                    string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                    cp.Img.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                    imgUrl = folder;
                }
                else if (cp.Type == "Technology")
                {
                    string folder = "wwwroot/asedes/img/Technology/";
                    folder += Guid.NewGuid().ToString() + path;
                    string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                    cp.Img.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                    imgUrl = folder;
                }

                string Au_Type = Request.Cookies["User_type"];
                int AU_id = 0;

                if (Au_Type == "ad")
                {
                    IEnumerable<Admin> Admin = _dBContext.Admin.Where(n => n.User_Name == Request.Cookies["User_Name"]);
                    AU_id = Admin.First().Id;
                }
                else if (Au_Type == "au")
                {
                    IEnumerable<Auther> Auther = _dBContext.Auther.Where(n => n.Username == Request.Cookies["User_Name"]);
                    AU_id = Auther.First().Id;
                }
                else if (Au_Type == "ur")
                {
                    IEnumerable<User> User = _dBContext.User.Where(n => n.Usar_Name == Request.Cookies["User_Name"]);
                    AU_id = User.First().Id;
                }

                    _dBContext.News.Add(
                    new News
                    {
                        Title = cp.Title,
                        Sup_Title = cp.Sup_Title,
                        Article = cp.Article,
                        Type = cp.Type,
                        Img_path = imgUrl,
                        Au_Type = Au_Type,
                        AU_id = AU_id,
                        Date_Time = DateTime.Now
                    });

                _dBContext.SaveChanges();
            }
            else
            {
                return View();
            }
            

            return RedirectToAction("Index");
        }

        
[HttpPost]
public IActionResult Edit_Account(Edit_Account ea)
{
    if(ea != null)
    {

        string Au_Type = Request.Cookies["User_type"];

        string Fname;
        string Lname;

        if (Au_Type == "au")
        {
            IEnumerable<Auther> Auther = _dBContext.Auther.Where(n => n.Username == Request.Cookies["User_Name"]);
            Fname = Auther.First().Fist_Name;
            Lname = Auther.First().Last_Name;
        }
        else if (Au_Type == "ur")
        {
            IEnumerable<User> User = _dBContext.User.Where(n => n.Usar_Name == Request.Cookies["User_Name"]);
        }

        _dBContext.SaveChanges();
    }
    else
    {
        return View();
    }


    return RedirectToAction("Index");
}
        public IActionResult Sarch(string sarch)
        {
            ViewData["Title"] = "Sarch";

            IEnumerable<News> News = _dBContext.News.Where(n => n.Title.Contains(sarch));
            

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
        [HttpPost]
        public IActionResult Dashbord()
        {
            ViewData["Title"] = "Dashbord";
            string Au_Type = Request.Cookies["User_type"];
            string Au_name = Request.Cookies["User_Name"];
            string Type = "";

            int ID = 0;

            if (Au_Type == "ad")
            {
                IEnumerable<Admin> Admin = _dBContext.Admin.Where(n => n.User_Name == Au_name);
                if (Admin.Any())
                {
                    ID = Admin.First().Id;
                    Type = "Admin";
                }
            }
            else if (Au_Type == "au")
            {
                IEnumerable<Auther> Auther = _dBContext.Auther.Where(n => n.Username == Au_name);
                if (Auther.Any())
                {
                    ID = Auther.First().Id;
                    Type = "Auther";
                }
            }
            IEnumerable<News> news = _dBContext.News.Where(n =>n.Au_Type == Type && n.AU_id == ID);
            return View(news);
        }

        [HttpPost]
        public IActionResult Edit_Plog()
        {
            ViewData["Title"] = "Edit Post";

            string post_id = Request.Form["ID"];

            int id = Convert.ToInt32(post_id);

            IEnumerable<News> news = _dBContext.News.Where(n => n.Id == id);


            return View(news);
        }

        [HttpPost]
        public IActionResult Update_plog()
        {
            string news_id = Request.Form["ID"];
            int id = Convert.ToInt32(news_id);
            string Title = Request.Form["Title"];
            string Sup_Title = Request.Form["Sup_Title"];
            string Img = Request.Form["Img"];
            string Article = Request.Form["Article"];
            string Type = Request.Form["Type"];

            if (id != null && Title != null && Sup_Title != null && Img != null && Article != null && Type != null
                && !Title.Any(P => punc.Contains(P)) && !Title.Any(P => punc.Contains(P)) && !Sup_Title.Any(P => punc.Contains(P)) 
                && !Img.Any(P => punc.Contains(P)) && !Article.Any(P => punc.Contains(P)) && !Type.Any(P => punc.Contains(P)))
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(Img);
                string fileName = Path.GetFileName(Img);
                IFormFile imgFile = new FormFile(new MemoryStream(fileBytes), 0, Img.Length, null, Img);
                IEnumerable<News> news = _dBContext.News.Where(n => n.Id == id);

                var update = news.First();

                update.Title = Title;
                update.Type = Type;
                update.Article = Article;
                update.Sup_Title = Sup_Title;
                update.Date_Time = DateTime.Now;

                string path = Path.GetExtension(imgFile.FileName);
                string imgUrl = "";
                if (path == ".png" || path == ".jpg")
                {

                    if (update.Type == "Spore")
                    {
                        string folder = "wwwroot/asedes/img/Spore/";
                        folder += Guid.NewGuid().ToString() + path;
                        string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                        imgFile.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                        imgUrl = folder;
                    }
                    else if (update.Type == "Politics")
                    {
                        string folder = "wwwroot/asedes/img/Politics/";
                        folder += Guid.NewGuid().ToString() + path;
                        string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                        imgFile.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                        imgUrl = folder;
                    }
                    else if (update.Type == "Health")
                    {
                        string folder = "wwwroot/asedes/img/Health/";
                        folder += Guid.NewGuid().ToString() + path;
                        string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                        imgFile.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                        imgUrl = folder;
                    }
                    else if (update.Type == "Technology")
                    {
                        string folder = "wwwroot/asedes/img/Technology/";
                        folder += Guid.NewGuid().ToString() + path;
                        string sarver_folder = Path.Combine(_WebHostEnvironment.WebRootPath + folder);

                        imgFile.CopyToAsync(new FileStream(sarver_folder, FileMode.Create));

                        imgUrl = folder;
                    }

                    update.Img_path = imgUrl;

                    _dBContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Edit_Plog");
        }


        [HttpPost]
        public IActionResult Delete_Plog()
        {
            string news_id = Request.Form["ID"];
            int id = Convert.ToInt32(news_id);

            IEnumerable<News> news = _dBContext.News.Where(n => n.Id == id);

            var delete = news.First();

            _dBContext.News.Remove(delete);

            return RedirectToAction("Index");
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

            if (r_fname != null && r_lname != null && r_uname != null && r_email != null && r_password != null && r_repassword != null
                && !r_fname.Any(P => punc.Contains(P)) && !r_lname.Any(P => punc.Contains(P)) && !r_uname.Any(P => punc.Contains(P))
                && !r_email.Any(P => punc.Contains(P)) && !r_password.Any(P => punc.Contains(P)) && !r_repassword.Any(P => punc.Contains(P)))

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

            if (l_username != null && l_password != null && !l_username.Any( P => punc.Contains(P)) && !l_password.Any(P => punc.Contains(P)))
            {
                IEnumerable<Admin> Admin = _dBContext.Admin.Where(n => 
                                            (n.User_Name == l_username || n.Email == l_username)
                                            && n.Password == l_password);

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
                    IEnumerable<Auther> Auther = _dBContext.Auther.Where(n => 
                                                (n.Username == l_username || n.Email == l_username)
                                                && n.Password == l_password);


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
                        IEnumerable<User> User = _dBContext.User.Where(n => 
                                                (n.Usar_Name == l_username || n.Email == l_username)
                                                && n.password == l_password);

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
