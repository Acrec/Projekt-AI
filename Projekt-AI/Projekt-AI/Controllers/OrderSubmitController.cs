using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;

namespace Projekt_AI.Controllers
{
    public class OrderSubmitController : Controller
    {
        // GET: OrderSubmit
        public ActionResult Index()
        {
            Order Ordermodel = new Order();


            return View(Ordermodel);
        }
        [HttpPost]
        public ActionResult Index(Order Ordermodel)
        {
            using (AI_ProjectDBEntities dbmodels = new AI_ProjectDBEntities())
            {
                Ordermodel.Order_ID = dbmodels.Order.Count() + 1;
                Ordermodel.User_ID = System.Convert.ToInt32(Session["user_id"].ToString());
                Ordermodel.Data = System.DateTime.Now;
                Ordermodel.Price = (float)System.Convert.ToDouble(Session["Price"].ToString());
                dbmodels.Order.Add(Ordermodel);
                dbmodels.SaveChanges();

                List<Item> cart = (List<Item>)Session["cart"];
                foreach (var item in cart)
                {
                    Order_Details DO = new Order_Details();
                    DO.Order_ID = Ordermodel.Order_ID;
                    DO.Food_Name = item.Cart.Food_name;
                    DO.Food_price = item.Cart.Food_Price;
                    DO.Quantity = item.Quantity;
                    DO.OD_ID = dbmodels.Order_Details.Count() + 1;
                    DO.Menu_ID = item.Cart.Menu_ID;
                    dbmodels.Order_Details.Add(DO);
                    dbmodels.SaveChanges();



                }
                Session["cart"] = null;


            }
            return View();
        }
    }
}