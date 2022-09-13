using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PIV.Models
{
    public class Faktury
    {
        [Key]
        public int Id_Faktury { get; set; }
        [Required]
        public int Id_Klienta { get; set; }
        [Required]
        public int Id_Pracownika { get; set; }
        [Required]
        public int Id_Zamówienia { get; set; }
        [Required]
        public DateTime Termin_płatności { get; set; }
        [Required]
        public double Całkowita_kwota_do_zapłaty { get; set; }
        [Required]
        public DateTime Termin_wpłaty { get; set; }
    }
}