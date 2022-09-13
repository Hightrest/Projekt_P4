using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class AddDaneAdresowe
    {
        public string Ulica { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Kraj { get; set; }
    }
}
