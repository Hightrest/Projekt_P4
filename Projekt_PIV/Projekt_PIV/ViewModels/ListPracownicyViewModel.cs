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
    public class ListPracownicyViewModel : BaseViewModel
    {
        private Model.ListPracownicyModel _listPracownicy;

        public int Id_Pracownika
        {
            get { return _listPracownicy.Id_Pracownika; }
            set
            {
                if (_listPracownicy.Id_Pracownika != value)
                {
                    _listPracownicy.Id_Pracownika = value;
                    OnPropertyChanged(nameof(Id_Pracownika));
                }
            }
        }
        public ListPracownicyViewModel(Model.ListPracownicyModel listPracownicyModel)
        {
            _listPracownicy = listPracownicyModel;

            ListPracownicyClick = new RelayCommand(x => DisplayMessage(), x => this.IsValid);
        }
        public bool IsValid { get => Id_Pracownika >= 0; }

        public ObservableCollection<Model.ListPracownicyModel> FindPracownika { get; } = new ObservableCollection<Model.ListPracownicyModel>();
        private void DisplayMessage()
        {
            using (var context = new EwidencjaContext())
            {
                if (Id_Pracownika > 0)
                {
                    var fakt = context.Pracownicy
                        .Where(x => x.Id_Pracownika == Id_Pracownika)
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindPracownika.Add(new Model.ListPracownicyModel()
                        {
                            Id_Pracownika = item.Id_Pracownika,
                            Imię_pracownika = item.Imię_pracownika,
                            Nazwisko_pracownika = item.Nazwisko_pracownika,
                            Numer_telefonu_pracownika = item.Numer_telefonu_pracownika,
                            PESEL_pracownika = item.PESEL_pracownika,
                            Email_pracownika = item.Email_pracownika,
                            Data_zatrudnienia = item.Data_zatrudnienia,
                            Data_urodzenia = item.Data_urodzenia,
                            Id_Adresu = item.Id_Adresu,
                        });
                    }
                }

                else if (Id_Pracownika == 0)
                {
                    var fakt = context.Pracownicy
                        .ToList();

                    foreach (var item in fakt)
                    {
                        FindPracownika.Add(new Model.ListPracownicyModel()
                        {
                            Id_Pracownika = item.Id_Pracownika,
                            Imię_pracownika = item.Imię_pracownika,
                            Nazwisko_pracownika = item.Nazwisko_pracownika,
                            Numer_telefonu_pracownika = item.Numer_telefonu_pracownika,
                            PESEL_pracownika = item.PESEL_pracownika,
                            Email_pracownika = item.Email_pracownika,
                            Data_zatrudnienia = item.Data_zatrudnienia,
                            Data_urodzenia = item.Data_urodzenia,
                            Id_Adresu=item.Id_Adresu,
                        });
                    }
                }
            }
        }
        public ICommand ListPracownicyClick
        {
            get;
            private set;
        }
    }
}
