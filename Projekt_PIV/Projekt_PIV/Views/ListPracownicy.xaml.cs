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
    /// Logika interakcji dla klasy ListPracownicy.xaml
    /// </summary>
    public partial class ListPracownicy : Page
    {
        private readonly ListPracownicyViewModel _viewmodel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public ListPracownicy()
        {
            InitializeComponent();

            int result;
            if (int.TryParse(Id_Pracownika.Text, out result)) ;

            var model = new ListPracownicyModel
            {
                Id_Pracownika = result
            };

            _viewmodel = new ListPracownicyViewModel(model);
            DataContext = _viewmodel;
        }
    }
}
