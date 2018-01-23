using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekt_AI.Models;
namespace Projekt_AI.Controllers
{
    public class Item
    {
        private Menu cart = new Menu();
        public Menu Cart
        {
            get { return cart; }
            set { cart = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private float cost;
        public float Cost
        {
            get { return cost;}
            set { cost = value; }
        }
        public Item(Menu cart, int quantity, float cost)
        {
            this.cart=cart;
            this.quantity = quantity;
            this.cost = cost;

        }
    }
}