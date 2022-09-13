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
    public class AddProduktyViewModel : BaseViewModel
    {
        private Model.AddProdukty _produkty;


        public string Nazwa_produktu
        {
            get { return _produkty.Nazwa_produktu; }

            set
            {
                if (_produkty.Nazwa_produktu != value)
                {
                    _produkty.Nazwa_produktu = value;
                    OnPropertyChanged(nameof(Nazwa_produktu));
                }
            }
        }
        public double Cena_jednostkowa
        {
            get { return _produkty.Cena_jednostkowa; }

            set
            {
                if (_produkty.Cena_jednostkowa != value)
                {
                    _produkty.Cena_jednostkowa = value;
                    OnPropertyChanged(nameof(Cena_jednostkowa));
                }
            }
        }

        public int Dostępna_ilość
        {
            get { return _produkty.Dostępna_ilość; }

            set
            {
                if (_produkty.Dostępna_ilość != value)
                {
                    _produkty.Dostępna_ilość = value;
                    OnPropertyChanged(nameof(Dostępna_ilość));
                }
            }
        }

        public AddProduktyViewModel(Model.AddProdukty produkty)
        {
            _produkty = new Model.AddProdukty
            {
                Cena_jednostkowa = produkty.Cena_jednostkowa,
                Dostępna_ilość =  produkty.Dostępna_ilość,
                Nazwa_produktu = produkty.Nazwa_produktu,
            };
            AddProduktyClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }

        public bool IsValid { get => !string.IsNullOrEmpty(Nazwa_produktu) && Cena_jednostkowa != 0 && Dostępna_ilość != 0; }

        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                context.Produkty.Add(new Produkty {
                    Nazwa_produktu = Nazwa_produktu,
                    Cena_jednostkowa = Cena_jednostkowa,
                    Dostępna_ilość = Dostępna_ilość });
                context.SaveChanges();
            }
            MessageBox.Show($"Produkt została dodana do bazy.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ICommand AddProduktyClick
        {
            get;
            private set;
        }
    }
}
