using Projekt_PIV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddPracownika.xaml
    /// </summary>
    public partial class AddPracownika : Page
    {
        private readonly AddPracownikaViewModel _viewModel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public AddPracownika()
        {
            InitializeComponent();

            DateTime Resultdu;
            if (DateTime.TryParse(Data_zatrudnienia.Text, out Resultdu)) ;
            DateTime Resultdz;
            if (DateTime.TryParse(Data_urodzenia.Text, out Resultdz)) ;
            int ResultId = 0;
            if (int.TryParse(Id_Adresu.Text, out ResultId)) ;

            var model = new Model.AddPracownika()
            {
                Imię_pracownika = Imię_pracownika.Text,
                Nazwisko_pracownika = Nazwisko_pracownika.Text,
                Numer_telefonu_pracownika = Numer_telefonu_pracownika.Text,
                PESEL_pracownika = PESEL_pracownika.Text,
                Email_pracownika = Email_pracownika.Text,
                Data_zatrudnienia = Resultdu,
                Data_urodzenia = Resultdz,
                Id_Adresu = ResultId,
            };

            _viewModel = new AddPracownikaViewModel(model);
            DataContext = _viewModel;
        }
    }
}
