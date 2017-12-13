using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Projekt_AI.Models
{
    public class Order
    {
        public int OederID { get; set; }
        public float Praice { get; set; }
        public DateTime OrderTime { get; set; }
        public List<Position_on_Order> Composition { get; set; }
        public string Comment { get; set; }


        public int RestaurantID { get; set; }
        public int UserID { get; set; }
        public OrderState OrderState { get; set; }
        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }


    }
    public enum OrderState
    {
        New,
        Realzied

    }
}