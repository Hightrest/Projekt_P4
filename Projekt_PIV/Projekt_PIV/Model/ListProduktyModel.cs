using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class ListProduktyModel
    {
            public int Id_Produktu { get; set; }
            public string Nazwa_produktu { get; set; }
            public double Cena_jednostkowa { get; set; }
            public int Dostępna_ilość { get; set; }
    }
}
