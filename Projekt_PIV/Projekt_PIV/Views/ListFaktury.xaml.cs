using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using Projekt_PIV.Model;
using Projekt_PIV.ViewModels;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ListFaktury.xaml
    /// </summary>
    public partial class ListFaktury : Page
    {
        private readonly ListFakturyViewModel _viewmodel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public ListFaktury()
        {
            InitializeComponent();

            int result;
            if (int.TryParse(Id_Faktury.Text, out result)) ;

            var model = new ListFakturyModel
            {
                Id_Faktury = result
            };

            _viewmodel = new ListFakturyViewModel(model);
            DataContext = _viewmodel;
        }
    }
}
