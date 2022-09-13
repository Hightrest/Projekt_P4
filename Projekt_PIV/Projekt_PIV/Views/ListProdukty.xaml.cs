using Projekt_PIV.Model;
using Projekt_PIV.ViewModels;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ListProdukty.xaml
    /// </summary>
    public partial class ListProdukty : Page
    {
        private readonly ListProduktyViewModel _viewmodel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public ListProdukty()
        {
            InitializeComponent();

            int result = 0;
            if (int.TryParse(Id_Produktu.Text, out result)) ;

            var model = new ListProduktyModel
            {
                Id_Produktu = result
            };

            _viewmodel = new ListProduktyViewModel(model);
            DataContext = _viewmodel;
        }
    }
}
