using Projekt_PIV.Commands;
using Projekt_PIV.Context;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt_PIV.ViewModels
{
    public class ListDaneAdresoweViewModel : BaseViewModel
    {
        private Model.ListDaneAdresoweModel _listAdresy;

        public int Id_Adresu
        {
            get { return _listAdresy.Id_Adresu; }
            set
            {
                if (_listAdresy.Id_Adresu != value)
                {
                    _listAdresy.Id_Adresu = value;
                    OnPropertyChanged(nameof(Id_Adresu));
                }
            }
        }
        public ListDaneAdresoweViewModel(Model.ListDaneAdresoweModel listDaneAdresoweModel)
        {
            _listAdresy = listDaneAdresoweModel;

            ListDaneAdresoweClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }
        public bool IsValid { get => Id_Adresu >= 0; }

        public ObservableCollection<Model.ListDaneAdresoweModel> FindDaneAdresowe { get; } = new ObservableCollection<Model.ListDaneAdresoweModel>();
        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                if (Id_Adresu > 0)
                {
                    var fakt = context.DaneAdresowe
                        .Where(x => x.Id_Adresu == Id_Adresu)
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindDaneAdresowe.Add(new Model.ListDaneAdresoweModel()
                        {
                            Id_Adresu = item.Id_Adresu,
                            Ulica = item.Ulica,
                            Adres = item.Adres,
                            Miasto = item.Miasto,
                            Kod_pocztowy = item.Kod_pocztowy,
                            Kraj = item.Kraj,
                        });
                    }
                }

                else if (Id_Adresu == 0)
                {
                    var fakt = context.DaneAdresowe.ToList();

                    foreach (var item in fakt)
                    {
                        FindDaneAdresowe.Add(new Model.ListDaneAdresoweModel()
                        {
                            Id_Adresu = item.Id_Adresu,
                            Ulica = item.Ulica,
                            Adres = item.Adres,
                            Miasto = item.Miasto,
                            Kod_pocztowy = item.Kod_pocztowy,
                            Kraj = item.Kraj,
                        });
                    }
                }
            }
        }
        public ICommand ListDaneAdresoweClick
        {
            get;
            private set;
        }
    }
}
