using System.Windows;
using Projekt_PIV.Views;

namespace Projekt_PIV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Wyświetlanie
        private void ListFaktury_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new ListFaktury();
        }

        private void ListZamowienia_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new ListZamowienia();
        }

        private void ListKlienci_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new ListKlienci();
        }
        private void ListDaneAdresowe_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new ListDaneAdresowe();
        }
        private void ListPracownicy_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new ListPracownicy();
        }

        private void ListProdukty_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new ListProdukty();
        }

        //Dodawanie
        private void AddFaktury_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new AddFaktury();
        }
        private void AddZamowienia_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new AddZamowienia();
        }
        private void AddKlienta_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new AddKlienta();
        }
        private void AddPracownika_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new AddPracownika();
        }
        private void AddProdukty_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new AddProdukty();
        }
        private void AddDaneAdresowe_Click(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new AddDaneAdresowe();
        }

        //Reszta
        private void CurrentForm_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentForm.Content = new MainView();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
