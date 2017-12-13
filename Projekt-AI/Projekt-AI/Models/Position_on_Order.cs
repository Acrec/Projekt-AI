namespace Projekt_AI.Models
{
    public class Position_on_Order
    {
        public int Position_on_OrderID { get; set; }
        public int OederID { get; set; }
        public int MenuID { get; set; }
        public int RestaurantID { get; set; }
        public int Amount { get; set; }


        public virtual Order Order { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}