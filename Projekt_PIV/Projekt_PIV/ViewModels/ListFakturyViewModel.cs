using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Projekt_PIV.Commands;
using Projekt_PIV.Context;
using Projekt_PIV.Models;

namespace Projekt_PIV.ViewModels
{
    internal class ListFakturyViewModel : BaseViewModel
    {
        private Model.ListFakturyModel _listFaktury;

        public int Id_Faktury
        {
            get { return _listFaktury.Id_Faktury; }
            set
            {
                if (_listFaktury.Id_Faktury != value)
                {
                    _listFaktury.Id_Faktury = value;
                    OnPropertyChanged(nameof(Id_Faktury));
                }
            }
        }
            public ListFakturyViewModel(Model.ListFakturyModel listFakturyModel)
        {
            _listFaktury = listFakturyModel;

            ListFakturyClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }
        public bool IsValid { get => Id_Faktury >= 0; }

        public ObservableCollection<Model.ListFakturyModel> FindFaktury { get; } = new ObservableCollection<Model.ListFakturyModel>();
        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                if (Id_Faktury > 0)
                {
                    var fakt = context.Faktury
                        .Where(x => x.Id_Faktury == Id_Faktury)
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindFaktury.Add(new Model.ListFakturyModel()
                        { Id_Faktury = item.Id_Faktury,
                            Id_Klienta = item.Id_Klienta,
                            Id_Pracownika = item.Id_Pracownika,
                            Id_Zamówienia = item.Id_Zamówienia,
                            Termin_płatności = item.Termin_płatności,
                            Całkowita_kwota_do_zapłaty = item.Całkowita_kwota_do_zapłaty,
                            Termin_wpłaty = item.Termin_wpłaty
                        });
                    }
                }

                else if(Id_Faktury == 0)
                {
                    var fakt = context.Faktury
                                            //.Where(x => x.Id_Faktury == Id_Faktury)
                                            .ToList();

                    foreach (var item in fakt)
                    {
                        FindFaktury.Add(new Model.ListFakturyModel()
                        {
                            Id_Faktury = item.Id_Faktury,
                            Id_Klienta = item.Id_Klienta,
                            Id_Pracownika = item.Id_Pracownika,
                            Id_Zamówienia = item.Id_Zamówienia,
                            Termin_płatności = item.Termin_płatności,
                            Całkowita_kwota_do_zapłaty = item.Całkowita_kwota_do_zapłaty,
                            Termin_wpłaty = item.Termin_wpłaty
                        });
                    }
                }
            }
        }
        public ICommand ListFakturyClick
        {
            get;
            private set;
        }

    }
}

