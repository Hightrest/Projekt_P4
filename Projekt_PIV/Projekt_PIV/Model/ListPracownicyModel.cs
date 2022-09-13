using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class ListPracownicyModel
    {
        public int Id_Pracownika { get; set; }
        public string Imię_pracownika { get; set; }
        public string Nazwisko_pracownika { get; set; }
        public string Numer_telefonu_pracownika { get; set; }
        public string? PESEL_pracownika { get; set; }
        public string Email_pracownika { get; set; }
        public DateTime Data_zatrudnienia { get; set; }
        public DateTime Data_urodzenia { get; set; }
        public int Id_Adresu { get; set; }
    }
}
