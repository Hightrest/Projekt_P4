   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      "    Projekt_PIV.Views.AddKlienta   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  
AddKlienta??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??Imię klienta??6-   $
??Left=?6D   $??4q?6_   $	??Top=?6j   ?? 5   
   $??0??6   $??2??6    $??Nazwisko klienta??6-   $
??Left=?6H   $??4q?6c   $	??Top=?6n   ?? 5   
   $??0??6   $??3??6    $??Numer telefonu??6-   $
??Left=?6F   $??4q?6a   $	??Top=?6l   ?? 5   
   $??0??6   $??4??6    $??Pesel??6-   $
??Left=?6=   $??4q?6X   $	??Top=?6c   ?? 5   
   $??0??6   $??5??6    $??Email??6-   $
??Left=?6=   $??4q?6X   $	??Top=?6c   ?? 5    
   $??0??6   $??6??6    $??	Id Adresu??6-   $
??Left=?6A   $??4q?6\   $	??Top=?6g   ?? 5"   
   -   5         ??Name$ Imię_klienta??5"      $??1??6(   $??1??68   $
??Left=?6E   $??4q?6`   $	??200??6?   ??6k   ?? *Imię_klienta+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5#   
   -   5        $ Nazwisko_klienta??5#      $??1??6,   $??2??6=   $
??Left=?6J   $??4q?6e   $	??200??6?   ??6p   ?? *Nazwisko_klienta+$ PropertyChanged=?6?   ?? 5$   
   -   5        $ Numer_telefonu_klienta??5$      $??1??62   $??3??6B   $
??Left=?6O   $??4q?6j   $	??200??6?   ??6u   ?? *Numer_telefonu_klienta+$ PropertyChanged=?6?   ?? 5%   
   -   5        $ PESEL_klienta??5%      $??1??6)   $??4??69   $
??Left=?6F   $??4q?6a   $	??200??6?   ??6l   ?? *PESEL_klienta+$ PropertyChanged=?6?   ?? 5&   
   -   5        $ Email_klienta??5&      $??1??6)   $??5??69   $
??Left=?6F   $??4q?6a   $	??200??6?   ??6l   ?? *Email_klienta+$ PropertyChanged=?6?   ?? 5'   
   -   5        $ 	Id_Adresu??5'      $??1??6%   $??6??65   $
??Left=?6B   $??4q?6]   $	??200??6?   ??6h   ?? *	Id_Adresu+$ PropertyChanged=?6?   ?? 5)   
   $??1??6   $??7??6!   $??4q?6.   $??Dodaj produkt??69   $
??Left=?6u   $	??Top=?6?   ??6Q   ?? *AddKlientaClick+6?   5*      5+      