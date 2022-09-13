using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Projekt_PIV.Commands;
using Projekt_PIV.Context;
using Projekt_PIV.Models;

namespace Projekt_PIV.ViewModels
{
    public class AddDaneAdresoweViewModel : BaseViewModel
    {
        private Model.AddDaneAdresowe _daneAdresowe;


        public string Ulica
        {
            get { return _daneAdresowe.Ulica; }

            set
            {
                if (_daneAdresowe.Ulica != value)
                {
                    _daneAdresowe.Ulica = value;
                    OnPropertyChanged(nameof(Ulica));
                }
            }
        }
        public string Adres
        {
            get { return _daneAdresowe.Adres; }

            set
            {
                if (_daneAdresowe.Adres != value)
                {
                    _daneAdresowe.Adres = value;
                    OnPropertyChanged(nameof(Adres));
                }
            }
        }

        public string Miasto
        {
            get { return _daneAdresowe.Miasto; }

            set
            {
                if (_daneAdresowe.Miasto != value)
                {
                    _daneAdresowe.Miasto = value;
                    OnPropertyChanged(nameof(Miasto));
                }
            }
        }
        public string Kod_pocztowy
        {
            get { return _daneAdresowe.Kod_pocztowy; }

            set
            {
                if (_daneAdresowe.Kod_pocztowy != value)
                {
                    _daneAdresowe.Kod_pocztowy = value;
                    OnPropertyChanged(nameof(Kod_pocztowy));
                }
            }
        }
        public string Kraj
        {
            get { return _daneAdresowe.Kraj; }

            set
            {
                if (_daneAdresowe.Kraj != value)
                {
                    _daneAdresowe.Kraj = value;
                    OnPropertyChanged(nameof(Kraj));
                }
            }
        }

        public AddDaneAdresoweViewModel(Model.AddDaneAdresowe adresy)
        {
            _daneAdresowe = new Model.AddDaneAdresowe 
            { 
                Ulica = adresy.Ulica,
                Adres = adresy.Adres,
                Miasto = adresy.Miasto,
                Kod_pocztowy = adresy.Kod_pocztowy,
                Kraj = adresy.Kraj,
            };
            AddDaneAdresoweClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }

        public bool IsValid { get => !string.IsNullOrEmpty(Ulica) && !string.IsNullOrEmpty(Adres) && !string.IsNullOrEmpty(Miasto) && !string.IsNullOrEmpty(Kod_pocztowy) && !string.IsNullOrEmpty(Kraj); }

        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                context.DaneAdresowe.Add(new DaneAdresowe { Ulica = Ulica, Adres = Adres, Miasto = Miasto, Kod_pocztowy = Kod_pocztowy, Kraj = Kraj });
                context.SaveChanges();
            }
            MessageBox.Show($"Adres został dodany do bazy.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand AddDaneAdresoweClick
        {
            get;
            private set;
        }
    }
}
