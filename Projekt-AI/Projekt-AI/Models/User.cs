using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekt_AI.Models
{
    public class User
    {
        public int UserID { get; set; }
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "Wprowadź nick użytkownika.")]
        public string UserPassword { get; set; }
        [Required(ErrorMessage = "Wprowadź hasło użytkownika.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Wprowadź imię.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwisko.")]
        public string StreetAdress { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę ulicy.")]
        public int HomeNumber { get; set; }
        [Required(ErrorMessage = "Wprowadź numer domu.")]
        public int FlatNumber { get; set; }
        [Required(ErrorMessage = "Wprowadź numer mieszkania.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę miasta.")]
        
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Wprowadź numer telfonu.")]
        public string EmailAdress { get; set; }
        [Required(ErrorMessage = "Wprowadź adres e-mail.")]
        public bool Administrator { get; set; }

    }
}