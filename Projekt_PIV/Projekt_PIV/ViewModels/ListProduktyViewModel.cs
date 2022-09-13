using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Projekt_PIV.Commands;
using Projekt_PIV.Context;

namespace Projekt_PIV.ViewModels
{
    public class ListProduktyViewModel : BaseViewModel
    {

        private Model.ListProduktyModel _listProdukty;

        public int Id_Produktu
        {
            get { return _listProdukty.Id_Produktu; }
            set
            {
                if (_listProdukty.Id_Produktu != value)
                {
                    _listProdukty.Id_Produktu = value;
                    OnPropertyChanged(nameof(Id_Produktu));
                }
            }
        }
        public ListProduktyViewModel(Model.ListProduktyModel listProduktyModel)
        {
            _listProdukty = listProduktyModel;

            ListProduktyClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }
        public bool IsValid { get => Id_Produktu >= 0; }

        public ObservableCollection<Model.ListProduktyModel> FindProdukty { get; } = new ObservableCollection<Model.ListProduktyModel>();
        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                if (Id_Produktu > 0)
                {
                    var fakt = context.Produkty
                        .Where(x => x.Id_Produktu == Id_Produktu)
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindProdukty.Add(new Model.ListProduktyModel()
                        {
                            Id_Produktu = item.Id_Produktu,
                            Nazwa_produktu = item.Nazwa_produktu,
                            Cena_jednostkowa = item.Cena_jednostkowa,
                            Dostępna_ilość = item.Dostępna_ilość,
                        });
                    }
                }

                else if (Id_Produktu == 0)
                {
                    var fakt = context.Produkty.ToList();

                    foreach (var item in fakt)
                    {
                        FindProdukty.Add(new Model.ListProduktyModel()
                        {
                            Id_Produktu = item.Id_Produktu,
                            Nazwa_produktu = item.Nazwa_produktu,
                            Cena_jednostkowa = item.Cena_jednostkowa,
                            Dostępna_ilość = item.Dostępna_ilość,
                        });
                    }
                }
            }
        }
        public ICommand ListProduktyClick
        {
            get;
            private set;
        }
    }
}
