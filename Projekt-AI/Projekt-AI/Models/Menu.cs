using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Projekt_AI.Models
{
    public class Menu

    {
        public int MenuID { get; set; }
        public int RestaurantID { get; set; }



        public string Meal { get; set; }
        [Required(ErrorMessage ="Podaj nazwę dania.")]
        public string MealContents { get; set; }
        [Required(ErrorMessage = "Podaj skaład dania.")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Podaj cenę dania.")]
        
        public virtual Restaurant Restaurant { get; set; }

    }
}