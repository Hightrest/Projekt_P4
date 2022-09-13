using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PIV.Models
{
    public class Pracownicy
    {
        [Key]
        public int Id_Pracownika { get; set; }
        [Required]
        public string Imię_pracownika { get; set; }
        [Required]
        public string Nazwisko_pracownika { get; set; }
        [Required]
        public string Numer_telefonu_pracownika { get; set; }
        public string? PESEL_pracownika { get; set; }
        [Required]
        public string Email_pracownika { get; set; }
        [Required]
        public DateTime Data_zatrudnienia { get; set; }
        [Required]
        public DateTime Data_urodzenia { get; set; }
        [Required]
        public int Id_Adresu { get; set; }
    }
}