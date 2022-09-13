using Projekt_PIV.Commands;
using Projekt_PIV.Context;
using Projekt_PIV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Projekt_PIV.ViewModels
{
    public class AddFakturyViewModel : BaseViewModel
    {
        private Model.AddFaktury _faktury;


        public int Id_Klienta
        {
            get { return _faktury.Id_Klienta; }

            set
            {
                if (_faktury.Id_Klienta != value)
                {
                    _faktury.Id_Klienta = value;
                    OnPropertyChanged(nameof(Id_Klienta));
                }
            }
        }
        public int Id_Pracownika
        {
            get { return _faktury.Id_Pracownika; }

            set
            {
                if (_faktury.Id_Pracownika != value)
                {
                    _faktury.Id_Pracownika = value;
                    OnPropertyChanged(nameof(Id_Pracownika));
                }
            }
        }

        public int Id_Zamówienia
        {
            get { return _faktury.Id_Zamówienia; }

            set
            {
                if (_faktury.Id_Zamówienia != value)
                {
                    _faktury.Id_Zamówienia = value;
                    OnPropertyChanged(nameof(Id_Zamówienia));
                }
            }
        }
        public DateTime Termin_płatności
        {
            get { return _faktury.Termin_płatności; }

            set
            {
                if (_faktury.Termin_płatności != value)
                {
                    _faktury.Termin_płatności =value;
                    OnPropertyChanged(nameof(Termin_płatności));
                }
            }
        }
        public double Całkowita_kwota_do_zapłaty
        {
            get { return _faktury.Całkowita_kwota_do_zapłaty; }

            set
            {
                if (_faktury.Całkowita_kwota_do_zapłaty != value)
                {
                    _faktury.Całkowita_kwota_do_zapłaty = value;
                    OnPropertyChanged(nameof(Całkowita_kwota_do_zapłaty));
                }
            }
        }
        public DateTime Termin_wpłaty
        {
            get { return _faktury.Termin_wpłaty; }

            set
            {
                if (_faktury.Termin_wpłaty != value)
                {
                    _faktury.Termin_wpłaty = value;
                    OnPropertyChanged(nameof(Termin_wpłaty));
                }
            }
        }

        public AddFakturyViewModel(Model.AddFaktury faktury)
        {
            _faktury = new Model.AddFaktury
            {
                Id_Klienta = faktury.Id_Klienta,
                Id_Pracownika = faktury.Id_Pracownika,
                Id_Zamówienia = faktury.Id_Zamówienia,
                Termin_płatności = faktury.Termin_płatności,
                Całkowita_kwota_do_zapłaty = faktury.Całkowita_kwota_do_zapłaty,
                Termin_wpłaty = faktury.Termin_wpłaty,
            };
            AddFaktureClick = new RelayCommand(x => DisplayMessage());
        }

        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                context.Faktury.Add(new Faktury { Id_Klienta = Id_Klienta, Id_Pracownika = Id_Pracownika, Id_Zamówienia = Id_Zamówienia, Termin_płatności = Termin_płatności, Całkowita_kwota_do_zapłaty = Całkowita_kwota_do_zapłaty, Termin_wpłaty = Termin_wpłaty });
                context.SaveChanges();
            }
            MessageBox.Show($"Faktura została dodana do bazy.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand AddFaktureClick
        {
            get;
            private set;
        }
    }
}
