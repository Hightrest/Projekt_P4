   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      ?$clr-namespace:Projekt_PIV.ViewModelsProjekt_PIV.ViewModels  5      #    Projekt_PIV.Views.AddProdukty   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5      :	viewModel$clr-namespace:Projekt_PIV.ViewModels     5        N? Title$  AddProdukty??5
      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??Nazwa Produktu??6-   $
??Left=?6F   $??4q?6a   $	??Top=?6l   ?? 5   
   $??0??6   $??2??6    $??Cena Jednostkowa??6-   $
??Left=?6H   $??4q?6c   $	??Top=?6n   ?? 5   
   $??0??6   $??3??6    $??Dostepna Ilosc??6-   $
??Left=?6F   $??4q?6a   $	??Top=?6l   ?? 5   
   -   5         ??Name$ NazwaProduktu??5      $??1??6)   $??1??69   $
??Left=?6F   $??4q?6a   $	??200??6?   ??6l   ?? *Nazwa_produktu+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   -   5        $ CJ??5      $??1??6   $??2??6/   $
??Left=?6<   $??4q?6W   $	??200??6?   ??6b   ?? *Cena_jednostkowa+$ PropertyChanged=?6?   ?? 5   
   -   5        $ DostepnaIlosc??5      $??1??6)   $??3??69   $
??Left=?6F   $??4q?6a   $	??200??6?   ??6l   ?? *Dostępna_ilość+$ PropertyChanged=?6?   ?? 5    
   $??1??6   $??4??6!   $??4q?6.   $??Dodaj produkt??69   $
??Left=?6v   $	??Top=?6?   ??6Q   ?? *AddProduktyClick+6?   5!      5"      