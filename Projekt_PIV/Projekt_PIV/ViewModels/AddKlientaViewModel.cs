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
    public class AddKlientaViewModel :BaseViewModel
    {
        private Model.AddKlienta _klient;


        public string Imię_klienta
        {
            get { return _klient.Imię_klienta; }

            set
            {
                if (_klient.Imię_klienta != value)
                {
                    _klient.Imię_klienta = value;
                    OnPropertyChanged(nameof(Imię_klienta));
                }
            }
        }
        public string Nazwisko_klienta
        {
            get { return _klient.Nazwisko_klienta; }

            set
            {
                if (_klient.Nazwisko_klienta != value)
                {
                    _klient.Nazwisko_klienta = value;
                    OnPropertyChanged(nameof(Nazwisko_klienta));
                }
            }
        }
        public string Numer_telefonu_klienta
        {
            get { return _klient.Numer_telefonu_klienta; }

            set
            {
                if (_klient.Numer_telefonu_klienta != value)
                {
                    _klient.Numer_telefonu_klienta = value;
                    OnPropertyChanged(nameof(Numer_telefonu_klienta));
                }
            }
        }
        public string PESEL_klienta
        {
            get { return _klient.PESEL_klienta; }

            set
            {
                if (_klient.PESEL_klienta != value)
                {
                    _klient.PESEL_klienta = value;
                    OnPropertyChanged(nameof(PESEL_klienta));
                }
            }
        }
        public string Email_klienta
        {
            get { return _klient.Email_klienta; }

            set
            {
                if (_klient.Email_klienta != value)
                {
                    _klient.Email_klienta = value;
                    OnPropertyChanged(nameof(Email_klienta));
                }
            }
        }

        public int Id_Adresu
        {
            get { return _klient.Id_Adresu; }

            set
            {
                if (_klient.Id_Adresu != value)
                {
                    _klient.Id_Adresu = value;
                    OnPropertyChanged(nameof(Id_Adresu));
                }
            }
        }

        public AddKlientaViewModel(Model.AddKlienta klienci)
        {
            _klient = new Model.AddKlienta
            {
                Imię_klienta = klienci.Imię_klienta,
                Nazwisko_klienta = klienci.Nazwisko_klienta,
                Numer_telefonu_klienta = klienci.Numer_telefonu_klienta,
                PESEL_klienta = klienci.PESEL_klienta,
                Email_klienta = klienci.Email_klienta,
                Id_Adresu = klienci.Id_Adresu,
            };
            AddKlientaClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }

        public bool IsValid { get => !string.IsNullOrEmpty(Imię_klienta) && !string.IsNullOrEmpty(Nazwisko_klienta) && !string.IsNullOrEmpty(Email_klienta) && !string.IsNullOrEmpty(Numer_telefonu_klienta) && Id_Adresu!=0; }

        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                context.Klienci.Add(new Klienci { Imię_klienta = Imię_klienta, Nazwisko_klienta = Nazwisko_klienta, Numer_telefonu_klienta = Numer_telefonu_klienta, PESEL_klienta = PESEL_klienta, Email_klienta= Email_klienta, Id_Adresu = Id_Adresu });
                context.SaveChanges();
            }
            MessageBox.Show($"Klient została dodana do bazy.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand AddKlientaClick
        {
            get;
            private set;
        }
    }
}
