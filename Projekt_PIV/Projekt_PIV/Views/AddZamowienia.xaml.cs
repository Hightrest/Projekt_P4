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
    /// Logika interakcji dla klasy AddZamowienia.xaml
    /// </summary>
    public partial class AddZamowienia : Page
    {
        private readonly AddZamowieniaViewModel _viewModel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public AddZamowienia()
        {
            InitializeComponent();

            int ResultIdP;
            if (int.TryParse(Id_Produktu.Text, out ResultIdP));
            double ResultCJ;
            if (double.TryParse(Cena_jednostkowa.Text, out ResultCJ));
            int ResultIlosc = 0;
            if (int.TryParse(Ilość.Text, out ResultIlosc));

            var model = new Model.AddZamowienia()
            {
                Id_Produktu = ResultIdP,
                Cena_jednostkowa = ResultCJ,
                Ilość = ResultIlosc,
            };

            _viewModel = new AddZamowieniaViewModel(model);
            DataContext = _viewModel;
        }
    }
}
