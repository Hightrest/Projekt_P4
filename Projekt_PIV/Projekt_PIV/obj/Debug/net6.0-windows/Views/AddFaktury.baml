   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      "    Projekt_PIV.Views.AddFaktury   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  
AddFaktury??5	      .??5      ?  ? ColumnDefinitions 5   
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
   ?? $??0??6   $??1??6    $??
Id Klienta??6-   $
??Left=?6B   $??4q?6]   $	??Top=?6h   ?? 5   
   $??0??6   $??2??6    $??Id Pracownika??6-   $
??Left=?6E   $??4q?6`   $	??Top=?6k   ?? 5   
   $??0??6   $??3??6    $??Id Zamówienia??6-   $
??Left=?6E   $??4q?6`   $	??Top=?6k   ?? 5   
   $??0??6   $??4??6    $??Termin płatności??6-   $
??Left=?6H   $??4q?6c   $	??Top=?6n   ?? 5   
   $??0??6   $??5??6    $??Kwota do zapłaty??6-   $
??Left=?6H   $??4q?6c   $	??Top=?6n   ?? 5    
   $??0??6   $??6??6    $??Termin wpłaty??6-   $
??Left=?6E   $??4q?6`   $	??Top=?6k   ?? 5"   
   -   5         ??Name$ 
Id_Klienta??5"      $??1??6&   $??1??66   $
??Left=?6C   $??4q?6^   $	??200??6?   ??6i   ?? *
Id_Klienta+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5#   
   -   5        $ Id_Pracownika??5#      $??1??6)   $??2??6:   $
??Left=?6G   $??4q?6b   $	??200??6?   ??6m   ?? *Id_Pracownika+$ PropertyChanged=?6?   ?? 5$   
   -   5        $ Id_Zamówienia??5$      $??1??6)   $??3??69   $
??Left=?6F   $??4q?6a   $	??200??6?   ??6l   ?? *Id_Zamówienia+$ PropertyChanged=?6?   ?? 5%   
   -   5        $ Termin_płatności??5%      $??1??6,   $??4??6<   $
??Left=?6I   $??4q?6d   $	??200??6?   ??6o   ?? *Termin_płatności+$ PropertyChanged=?6?   ?? 5&   
   -   5        $" Całkowita_kwota_do_zapłaty??5&      $??1??66   $??5??6F   $
??Left=?6S   $??4q?6n   $	??200??6?   ??6y   ?? *Całkowita_kwota_do_zapłaty+$ PropertyChanged=?6?   ?? 5'   
   -   5        $ Termin_wpłaty??5'      $??1??6)   $??6??69   $
??Left=?6F   $??4q?6a   $	??200??6?   ??6l   ?? *Termin_wpłaty+$ PropertyChanged=?6?   ?? 5)   
   $??1??6   $??7??6!   $??4q?6.   $??Dodaj fakturę??69   $
??Left=?6u   $	??Top=?6?   ??6Q   ?? *AddFaktureClick+6?   5*      5+      