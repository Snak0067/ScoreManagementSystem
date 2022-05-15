using ScoreManagementSystem.Dao;
using ScoreManagementSystem.Dao.DaoImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScoreManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        ILoginDao loginDao = new LoginDao();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminLogin()
        {
            Models.User user = new Models.User();
            user.Username = Request["id"];
            user.Password = Request["password"];
            if (loginDao.Login(user))
                return View("SuperAdmin_main");
            else
                return View();
        }


    }
}