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
    public class ListKlienciViewModel : BaseViewModel
    {
        private Model.ListKlienciModel _listKlienci;

        public int Id_Klienta
        {
            get { return _listKlienci.Id_Klienta; }
            set
            {
                if (_listKlienci.Id_Klienta != value)
                {
                    _listKlienci.Id_Klienta = value;
                    OnPropertyChanged(nameof(Id_Klienta));
                }
            }
        }
        public ListKlienciViewModel(Model.ListKlienciModel listKlienciModel)
        {
            _listKlienci = listKlienciModel;

            ListKlienciClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }
        public bool IsValid { get => Id_Klienta >= 0; }

        public ObservableCollection<Model.ListKlienciModel> FindKlienci { get; } = new ObservableCollection<Model.ListKlienciModel>();
        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                if (Id_Klienta > 0)
                {
                    var fakt = context.Klienci
                        .Where(x => x.Id_Klienta == Id_Klienta)
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindKlienci.Add(new Model.ListKlienciModel()
                        {
                            Id_Klienta = item.Id_Klienta,
                            Imię_klienta = item.Imię_klienta,
                            Nazwisko_klienta = item.Nazwisko_klienta,
                            Numer_telefonu_klienta = item.Numer_telefonu_klienta,
                            PESEL_klienta = item.PESEL_klienta,
                            Email_klienta = item.Email_klienta,
                            Id_Adresu = item.Id_Adresu,
                        });
                    }
                }

                else if (Id_Klienta == 0)
                {
                    var fakt = context.Klienci.ToList();

                    foreach (var item in fakt)
                    {
                        FindKlienci.Add(new Model.ListKlienciModel()
                        {
                            Id_Klienta = item.Id_Klienta,
                            Imię_klienta = item.Imię_klienta,
                            Nazwisko_klienta = item.Nazwisko_klienta,
                            Numer_telefonu_klienta = item.Numer_telefonu_klienta,
                            PESEL_klienta = item.PESEL_klienta,
                            Email_klienta = item.Email_klienta,
                            Id_Adresu = item.Id_Adresu,
                        });
                    }
                }
            }
        }
        public ICommand ListKlienciClick
        {
            get;
            private set;
        }
    }
}
