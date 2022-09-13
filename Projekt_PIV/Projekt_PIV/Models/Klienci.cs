using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PIV.Models
{
    public class Klienci
    {
        [Key]
        public int Id_Klienta { get; set; }
        [Required]
        public string Imię_klienta { get; set; }
        [Required]
        public string Nazwisko_klienta { get; set; }
        [Required]
        public string Numer_telefonu_klienta { get; set; }
        public string? PESEL_klienta { get; set; }
        [Required]
        public string Email_klienta { get; set; }
        [Required]
        public int Id_Adresu { get; set; }
    }
}