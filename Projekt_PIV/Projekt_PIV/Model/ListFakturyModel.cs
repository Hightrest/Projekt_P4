using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV.Model
{
    public class ListFakturyModel
    {
        public int Id_Faktury { get; set; }
        public int Id_Klienta { get; internal set; }
        public int Id_Pracownika { get; internal set; }
        public int Id_Zamówienia { get; internal set; }
        public DateTime Termin_płatności { get; internal set; }
        public double Całkowita_kwota_do_zapłaty { get; internal set; }
        public DateTime Termin_wpłaty { get; internal set; }
    }
}
