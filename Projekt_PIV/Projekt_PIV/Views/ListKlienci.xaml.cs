using Projekt_PIV.Model;
using Projekt_PIV.ViewModels;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ListKlienci.xaml
    /// </summary>
    public partial class ListKlienci : Page
    {
        private readonly ListKlienciViewModel _viewmodel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public ListKlienci()
        {
            InitializeComponent();

            int result;
            if (int.TryParse(Id_Klienta.Text, out result));

            var model = new ListKlienciModel
            {
                Id_Klienta = result
            };

            _viewmodel = new ListKlienciViewModel(model);
            DataContext = _viewmodel;
        }

    }
}
