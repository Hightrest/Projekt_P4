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
    public class AddZamowieniaViewModel : BaseViewModel
    {
        private Model.AddZamowienia _zamowienie;


        public int Id_Produktu
        {
            get { return _zamowienie.Id_Produktu; }

            set
            {
                if (_zamowienie.Id_Produktu != value)
                {
                    _zamowienie.Id_Produktu = value;
                    OnPropertyChanged(nameof(Id_Produktu));
                }
            }
        }
        public double Cena_jednostkowa
        {
            get { return _zamowienie.Cena_jednostkowa; }

            set
            {
                if (_zamowienie.Cena_jednostkowa != value)
                {
                    _zamowienie.Cena_jednostkowa = value;
                    OnPropertyChanged(nameof(Cena_jednostkowa));
                }
            }
        }
        public int Ilość
        {
            get { return _zamowienie.Ilość; }

            set
            {
                if (_zamowienie.Ilość != value)
                {
                    _zamowienie.Ilość = value;
                    OnPropertyChanged(nameof(Ilość));
                }
            }
        }

        public AddZamowieniaViewModel(Model.AddZamowienia zamowienia)
        {
            _zamowienie = new Model.AddZamowienia
            {
                Id_Produktu = zamowienia.Id_Produktu,
                Cena_jednostkowa = zamowienia.Cena_jednostkowa,
                Ilość = zamowienia.Ilość,
            };
            AddZamowieniaClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }

        public bool IsValid { get => Id_Produktu!=0 && Cena_jednostkowa!=0 && Ilość!=0; }

        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                context.Zamówienia.Add(new Zamówienia { Id_Produktu = Id_Produktu, Cena_jednostkowa = Cena_jednostkowa, Ilość = Ilość});
                context.SaveChanges();
            }
            MessageBox.Show($"Zamówienie zostało dodana do bazy.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand AddZamowieniaClick
        {
            get;
            private set;
        }
    }
}
