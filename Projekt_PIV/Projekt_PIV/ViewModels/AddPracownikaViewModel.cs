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
    public class AddPracownikaViewModel : BaseViewModel
    {
        private Model.AddPracownika _pracownik;


        public string Imię_pracownika
        {
            get { return _pracownik.Imię_pracownika; }

            set
            {
                if (_pracownik.Imię_pracownika != value)
                {
                    _pracownik.Imię_pracownika = value;
                    OnPropertyChanged(nameof(Imię_pracownika));
                }
            }
        }
        public string Nazwisko_pracownika
        {
            get { return _pracownik.Nazwisko_pracownika; }

            set
            {
                if (_pracownik.Nazwisko_pracownika != value)
                {
                    _pracownik.Nazwisko_pracownika = value;
                    OnPropertyChanged(nameof(Nazwisko_pracownika));
                }
            }
        }
        public string Numer_telefonu_pracownika
        {
            get { return _pracownik.Numer_telefonu_pracownika; }

            set
            {
                if (_pracownik.Numer_telefonu_pracownika != value)
                {
                    _pracownik.Numer_telefonu_pracownika = value;
                    OnPropertyChanged(nameof(Numer_telefonu_pracownika));
                }
            }
        }
        public string PESEL_pracownika
        {
            get { return _pracownik.PESEL_pracownika; }

            set
            {
                if (_pracownik.PESEL_pracownika != value)
                {
                    _pracownik.PESEL_pracownika = value;
                    OnPropertyChanged(nameof(PESEL_pracownika));
                }
            }
        }
        public string Email_pracownika
        {
            get { return _pracownik.Email_pracownika; }

            set
            {
                if (_pracownik.Email_pracownika != value)
                {
                    _pracownik.Email_pracownika = value;
                    OnPropertyChanged(nameof(Email_pracownika));
                }
            }
        }
        public DateTime Data_zatrudnienia
        {
            get { return _pracownik.Data_zatrudnienia; }

            set
            {
                if (_pracownik.Data_zatrudnienia != value)
                {
                    _pracownik.Data_zatrudnienia = value;
                    OnPropertyChanged(nameof(Data_zatrudnienia));
                }
            }
        }
        public DateTime Data_urodzenia
        {
            get { return _pracownik.Data_urodzenia; }

            set
            {
                if (_pracownik.Data_urodzenia != value)
                {
                    _pracownik.Data_urodzenia = value;
                    OnPropertyChanged(nameof(Data_urodzenia));
                }
            }
        }

        public int Id_Adresu
        {
            get { return _pracownik.Id_Adresu; }

            set
            {
                if (_pracownik.Id_Adresu != value)
                {
                    _pracownik.Id_Adresu = value;
                    OnPropertyChanged(nameof(Id_Adresu));
                }
            }
        }

        public AddPracownikaViewModel(Model.AddPracownika pracownik)
        {
            _pracownik = new Model.AddPracownika
            {
                Imię_pracownika = pracownik.Imię_pracownika,
                Nazwisko_pracownika = pracownik.Nazwisko_pracownika,
                Numer_telefonu_pracownika = pracownik.Numer_telefonu_pracownika,
                PESEL_pracownika = pracownik.PESEL_pracownika,
                Email_pracownika = pracownik.Email_pracownika,  
                Data_zatrudnienia = pracownik.Data_zatrudnienia,
                Data_urodzenia = pracownik.Data_urodzenia,
                Id_Adresu = pracownik.Id_Adresu,
            };
            AddPracownikaClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }

        public bool IsValid { get => !string.IsNullOrEmpty(Imię_pracownika) && !string.IsNullOrEmpty(Nazwisko_pracownika) && !string.IsNullOrEmpty(Email_pracownika) && !string.IsNullOrEmpty(Numer_telefonu_pracownika) && Id_Adresu!=0; }

        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                context.Pracownicy.Add(new Pracownicy { Imię_pracownika = Imię_pracownika, Nazwisko_pracownika = Nazwisko_pracownika, Numer_telefonu_pracownika = Numer_telefonu_pracownika, PESEL_pracownika = PESEL_pracownika, Email_pracownika = Email_pracownika, Data_zatrudnienia = Data_zatrudnienia, Data_urodzenia = Data_urodzenia, Id_Adresu = Id_Adresu });
                context.SaveChanges();
            }
            MessageBox.Show($"Pracownik została dodana do bazy.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand AddPracownikaClick
        {
            get;
            private set;
        }
    }
}
