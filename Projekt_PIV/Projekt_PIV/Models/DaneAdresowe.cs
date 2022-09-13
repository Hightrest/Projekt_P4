using System;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PIV.Models
{
    public partial class DaneAdresowe
    {
        [Key]
        public int Id_Adresu { get; set; }
        [Required]
        public string Ulica { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Miasto { get; set; }
        [Required]
        public string Kod_pocztowy { get; set; }
        [Required]
        public string Kraj { get; set; }     
    }
}