using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;

namespace Projekt_AI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult Reg()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult User_Page(Projekt_AI.Models.User usermodel)
        {
            using (AI_ProjectDBEntities db = new AI_ProjectDBEntities())
            {
                var Userdetails = db.User.Where(x => x.Nickname == usermodel.Nickname && x.Password == usermodel.Password).FirstOrDefault();
                if (Userdetails == null)
                {
                    usermodel.Loginerrmsg = "Zły login lub hasło.";
                    return View("Index", usermodel);
                }
                else

                {
                    Session["user_id"] = Userdetails.User_ID;
                    Session["nickname"] = Userdetails.Nickname;
                    Session["name"] = Userdetails.Name;
                    Session["email"] = Userdetails.Email;
                    Session["phone"] = Userdetails.Phone;
                    Session["surname"] = Userdetails.Surname;

                    return RedirectToAction("Index", "Usert");

                }
                
            }
                return View();
        }
        public ActionResult LogOut()
        {
            int user_id = (int)Session["user_id"];
            Session.Abandon();
            return RedirectToAction("Index", "Home");

        }
 
    }
}