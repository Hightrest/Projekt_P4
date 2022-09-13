using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using Projekt_PIV.ViewModels;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddDaneAdresowe.xaml
    /// </summary>
    public partial class AddDaneAdresowe : Page
    {
        private readonly AddDaneAdresoweViewModel _viewModel;
        public AddDaneAdresowe()
        {
            InitializeComponent();

            var model = new Model.AddDaneAdresowe()
            {
                Ulica = Ulica.Text,
                Adres = Adres.Text,
                Miasto = Miasto.Text,
                Kod_pocztowy = Kod_pocztowy.Text,
                Kraj = Kraj.Text,
            };

            _viewModel = new AddDaneAdresoweViewModel(model);
            DataContext = _viewModel;
        }
    }
}
