using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class ListZamowieniaModel
    {
        public int Id_Zamówienia { get; set; }
        public int Id_Produktu { get; set; }
        public double Cena_jednostkowa { get; set; }
        public int Ilość { get; set; }
    }
}
