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
    /// Logika interakcji dla klasy AddKlienta.xaml
    /// </summary>
    public partial class AddKlienta : Page
    {
        private readonly AddKlientaViewModel _viewModel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public AddKlienta()
        {
            InitializeComponent();
            int Result = 0;
            if (int.TryParse(Id_Adresu.Text, out Result));

            var model = new Model.AddKlienta()
            {
                Imię_klienta = Imię_klienta.Text,
                Nazwisko_klienta = Nazwisko_klienta.Text,
                Numer_telefonu_klienta = Numer_telefonu_klienta.Text,
                PESEL_klienta = PESEL_klienta.Text,
                Email_klienta = Email_klienta.Text,
                Id_Adresu = Result,
            };

            _viewModel = new AddKlientaViewModel(model);
            DataContext = _viewModel;
        }
    }
}
