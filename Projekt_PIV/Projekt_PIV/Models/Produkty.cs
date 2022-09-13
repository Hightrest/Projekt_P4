using System;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PIV.Models
{
    public partial class Produkty
    {
        [Key]
        public int Id_Produktu { get; set; }
        [Required]
        public string Nazwa_produktu { get; set; }
        [Required]
        public double Cena_jednostkowa { get; set; }
        [Required]
        public int Dostępna_ilość { get; set; }

    }
}