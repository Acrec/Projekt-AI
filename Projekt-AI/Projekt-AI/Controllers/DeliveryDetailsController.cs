using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;
namespace Projekt_AI.Controllers
{
    public class DeliveryDetailsController : Controller
    {
        // GET: DeliveryDetails
        public ActionResult Index(int id)
        {
            List<Order_Details> list = new List<Order_Details>();
            using (AI_ProjectDBEntities model = new AI_ProjectDBEntities())
            {



                list = model.Order_Details.Where(x => x.Order_ID == id).ToList();



            }
            return View(list);
            
        }
    }
}