   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      %    Projekt_PIV.Views.AddZamowienia   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  AddZamowienia??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??Id Produktu??6-   $
??Left=?6C   $??4q?6^   $	??Top=?6i   ?? 5   
   $??0??6   $??2??6    $??Cena Jednostkowa??6-   $
??Left=?6H   $??4q?6c   $	??Top=?6n   ?? 5   
   $??0??6   $??3??6    $??Ilość??6-   $
??Left=?6=   $??4q?6X   $	??Top=?6c   ?? 5   
   -   5         ??Name$ Id_Produktu??5      $??1??6'   $??1??67   $
??Left=?6D   $??4q?6_   $	??200??6?   ??6j   ?? *Id_Produktu+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   -   5        $ Cena_jednostkowa??5      $??1??6,   $??2??6=   $
??Left=?6J   $??4q?6e   $	??200??6?   ??6p   ?? *Cena_jednostkowa+$ PropertyChanged=?6?   ?? 5   
   -   5        $ Ilość??5      $??1??6!   $??3??61   $
??Left=?6>   $??4q?6Y   $	??200??6?   ??6d   ?? *	Ilość+$ PropertyChanged=?6?   ?? 5   
   $??1??6   $??4??6!   $??4q?6.   $??Dodaj zamówienie??69   $
??Left=?6{   $	??Top=?6?   ??6T   ?? *AddZamowieniaClick+6?   5       5!      