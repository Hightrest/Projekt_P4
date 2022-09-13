using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class AddZamowienia
    {
        public int Id_Produktu { get; set; }
        public double Cena_jednostkowa { get; set; }
        public int Ilość { get; set; }
    }
}
