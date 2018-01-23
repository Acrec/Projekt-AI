using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;

namespace Projekt_AI.Controllers
    
{
    public class UsertController : Controller
    {
        // GET: Usert
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddorEdit()
        {
            User Usermodel = new User();
          
            return View(Usermodel);
        }
        [HttpPost]
        public ActionResult AddorEdit(User Usermodel)
        {
            using (AI_ProjectDBEntities dbmodels = new AI_ProjectDBEntities())
            {
                Usermodel.User_ID = dbmodels.User.Count() + 1;
                dbmodels.User.Add(Usermodel);
                dbmodels.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccesfulMessage = "Użytkownik zarejestrowany.";
                return View("AddorEdit",new User());
        }
    }
}