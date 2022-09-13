using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using Projekt_PIV.ViewModels;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddProdukty.xaml
    /// </summary>
    public partial class AddProdukty : Page
    {
        private readonly AddProduktyViewModel _viewModel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public AddProdukty()
        {
            InitializeComponent();

            double CJResult = 0;
            if (double.TryParse(CJ.Text, out CJResult));
            int DosIlosResult = 0;
            if (int.TryParse(DostepnaIlosc.Text, out DosIlosResult));

            var model = new Model.AddProdukty()
            {
                Nazwa_produktu = NazwaProduktu.Text,
                Cena_jednostkowa = CJResult,
                Dostępna_ilość = DosIlosResult,
            };

            _viewModel = new AddProduktyViewModel(model);
            DataContext = _viewModel;
        }
    }
}
