using Projekt_PIV.Commands;
using Projekt_PIV.Context;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt_PIV.ViewModels
{
    public class ListZamowieniaViewModel : BaseViewModel
    {
        private Model.ListZamowieniaModel _listZamowieniaModel;

        public int Id_Zamówienia
        {
            get { return _listZamowieniaModel.Id_Zamówienia; }
            set
            {
                if (_listZamowieniaModel.Id_Zamówienia != value)
                {
                    _listZamowieniaModel.Id_Zamówienia = value;
                    OnPropertyChanged(nameof(Id_Zamówienia));
                }
            }
        }
        public ListZamowieniaViewModel(Model.ListZamowieniaModel listZamowieniaModel)
        {
            _listZamowieniaModel = listZamowieniaModel;

            ListZamówieniaClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }
        public bool IsValid { get => Id_Zamówienia >= 0; }

        public ObservableCollection<Model.ListZamowieniaModel> FindZamowienia { get; } = new ObservableCollection<Model.ListZamowieniaModel>();
        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                if (Id_Zamówienia > 0)
                {
                    var fakt = context.Zamówienia
                        .Where(x => x.Id_Zamówienia == Id_Zamówienia)
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindZamowienia.Add(new Model.ListZamowieniaModel()
                        {
                            Id_Zamówienia = item.Id_Zamówienia,
                            Id_Produktu = item.Id_Produktu,
                            Cena_jednostkowa = item.Cena_jednostkowa,
                            Ilość = item.Ilość,
                        });
                    }
                }

                else if (Id_Zamówienia == 0)
                {
                    var fakt = context.Zamówienia.ToList();

                    foreach (var item in fakt)
                    {
                        FindZamowienia.Add(new Model.ListZamowieniaModel()
                        {
                            Id_Zamówienia = item.Id_Zamówienia,
                            Id_Produktu = item.Id_Produktu,
                            Cena_jednostkowa = item.Cena_jednostkowa,
                            Ilość = item.Ilość,
                        });
                    }
                }
            }
        }
        public ICommand ListZamówieniaClick
        {
            get;
            private set;
        }
    }
}
