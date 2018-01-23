using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_AI.Models;

namespace Projekt_AI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private AI_ProjectDBEntities db = new AI_ProjectDBEntities();
        // GET: ShoppingCart
        public ActionResult Cart()
        {
            
            return View();
        }
        private int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Cart.Menu_ID == id)
                { return i; }
            return -1;

        }
        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            
           // if ( cart[id].Quantity > 1)
           // { cart[id].Quantity--; }
            //else
            cart.RemoveAt(index); 

            Session["cart"] = cart;


            return View("Cart");
        }
        public ActionResult Dodaj(int id, int rid)
        {
            Session["rid"] = rid;
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.Menu.Find(id), 1,0));
                
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(db.Menu.Find(id), 1,0));
                else
                    cart[index].Quantity++;
               
                Session["cart"] = cart;
                
            }
            
            return View("Cart");
        }

    }
}