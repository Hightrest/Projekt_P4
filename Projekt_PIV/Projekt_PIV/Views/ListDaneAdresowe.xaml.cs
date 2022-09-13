using Projekt_PIV.Model;
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
    /// Logika interakcji dla klasy ListDaneAdresowe.xaml
    /// </summary>
    public partial class ListDaneAdresowe : Page
    {
        private readonly ListDaneAdresoweViewModel _viewmodel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public ListDaneAdresowe()
        {
            InitializeComponent();

            int result;
            if (int.TryParse(Id_Adresu.Text, out result)) ;

            var model = new ListDaneAdresoweModel
            {
                Id_Adresu = result
            };

            _viewmodel = new ListDaneAdresoweViewModel(model);
            DataContext = _viewmodel;
        }
    }
}
