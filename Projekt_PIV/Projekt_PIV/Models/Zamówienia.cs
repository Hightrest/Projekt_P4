using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_PIV.Models
{
    public class Zamówienia
    {

        [Key]
        public int Id_Zamówienia { get; set; }
        [Required]
        public int Id_Produktu { get; set; }
        [Required]
        public double Cena_jednostkowa { get; set; }
        [Required]
        public int Ilość { get; set; }
    }
}