using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;
namespace Projekt_AI.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Restaurant(string search)
        {
            List<Restaurant> list = new List<Restaurant>();
            using (AI_ProjectDBEntities model = new AI_ProjectDBEntities())
            {
                
                
                    
                    list = model.Restaurant.Where(x => x.City == search).ToList();

                Session["cart"] = null;

            }
            return View(list);
        }
    }
}