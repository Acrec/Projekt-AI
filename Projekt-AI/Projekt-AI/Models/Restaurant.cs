using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Projekt_AI.Models
{
    public class Restaurant
    {
        public string LoginName { get; set; }
        [Required(ErrorMessage = "Podaj nick restauraqcji.")]
        public string LoginPassword { get; set; }
        [Required(ErrorMessage = "Podaj hasło restauraqcji.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę restauraqcji.")]
        public string StreetAdress { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę ulicy.")]
        public int HomeNumber { get; set; }
        [Required(ErrorMessage = "Wprowadź numer budunku.")]
        public int FlatNumber { get; set; }
        [Required(ErrorMessage = "Wprowadź numer lokalu.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę miasta.")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Wprowadź numer telfonu.")]
        public string EmailAdress { get; set; }
        [Required(ErrorMessage = "Wprowadź adres e-mail.")]
        public float DeliveryPrice { get; set; }
        [Required(ErrorMessage = "Podaj cenę dostawy.")]

        public int RestaurantID { get; set; }
    }
}