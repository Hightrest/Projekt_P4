using Projekt_PIV.ViewModels;
using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projekt_PIV.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddFaktury.xaml
    /// </summary>
    public partial class AddFaktury : Page
    {
        private readonly AddFakturyViewModel _viewmodel;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public AddFaktury()
        {
            InitializeComponent();

            int resultIdK = 0;
            if (int.TryParse(Id_Klienta.Text, out resultIdK));

            int resultIdP = 0;
            if (int.TryParse(Id_Pracownika.Text, out resultIdP));

            int resultIdZ = 0;
            if (int.TryParse(Id_Zamówienia.Text, out resultIdZ));

            DateTime resultTP;
            if (DateTime.TryParse(Termin_płatności.Text, out resultTP)) ;

            double resultCKDZ = 0;
            if (double.TryParse(Całkowita_kwota_do_zapłaty.Text, out resultCKDZ)) ;

            DateTime resultDW;
            if (DateTime.TryParse(Termin_wpłaty.Text, out resultDW)) ;

            var model = new Model.AddFaktury
            {
                Id_Klienta = resultIdK,
                Id_Pracownika = resultIdP,
                Id_Zamówienia = resultIdZ,
                Termin_płatności = resultTP,
                Całkowita_kwota_do_zapłaty = resultCKDZ,
                Termin_wpłaty = resultDW
            };

            _viewmodel = new AddFakturyViewModel(model);
            DataContext = _viewmodel;
        }
    }
}
