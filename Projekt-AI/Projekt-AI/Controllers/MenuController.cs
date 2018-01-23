using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;

namespace Projekt_AI.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Menu(int id)
        {
            List < Menu> list = new List<Menu>();
            using (AI_ProjectDBEntities model = new AI_ProjectDBEntities())
            {
                list = model.Menu.Where(x => x.Rest_ID == id).ToList();

            }
                return View(list);
        }
    }
}