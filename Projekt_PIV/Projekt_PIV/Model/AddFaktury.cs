using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class AddFaktury
    {
        public int Id_Klienta { get; set; }
        public int Id_Pracownika { get; set; }
        public int Id_Zamówienia { get; set; }
        public DateTime Termin_płatności { get; set; }
        public double Całkowita_kwota_do_zapłaty { get; set; }
        public DateTime Termin_wpłaty { get; set; }
    }
}
