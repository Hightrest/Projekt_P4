using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class AddKlienta
    {
        public string Imię_klienta { get; set; }
        public string Nazwisko_klienta { get; set; }
        public string Numer_telefonu_klienta { get; set; }
        public string? PESEL_klienta { get; set; }
        public string Email_klienta { get; set; }
        public int Id_Adresu { get; set; }
    }
}
