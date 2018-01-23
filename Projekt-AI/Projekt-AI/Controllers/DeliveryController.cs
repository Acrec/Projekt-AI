using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;

namespace Projekt_AI.Controllers
{
    public class DeliveryController : Controller
    {
        // GET: Delivery
        public ActionResult Index(int id)
        {
            List<Order> list = new List<Order>();
            using (AI_ProjectDBEntities model = new AI_ProjectDBEntities())
            {



                list = model.Order.Where(x => x.User_ID == id).ToList();



            }
            return View(list);
        }
    }
}