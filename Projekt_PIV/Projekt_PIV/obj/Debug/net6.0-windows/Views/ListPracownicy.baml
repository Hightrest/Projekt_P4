   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      &     Projekt_PIV.Views.ListPracownicy   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  ListPracownicy??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??4,0,0,0q?6-   $??ID Pracownika: ??6>   $??Right=?6X   ?? 5   
   $??1??6   $??1??6    $??	250,0,0,0q?6-   $,??&0 - wyświetla wszystkich pracowników??6@   $
??Left=?6o   ?? 5   
   -   5         ??Name$ Id_Pracownika??5      $??1??6T   $??1??6d   $??4q?6q   $
??Left=?6?   $	??200??6?   ??6|   ?? *Id_Pracownika+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   $??1??6   $??4??6!   $??4q?6.   $??Szukaj pracownika??69   $
??Left=?6}   $	??Top=?6?   ??6U   ?? *ListPracownicyClick+6?   ?? 5   
   -   5         ??Name$ 
Pracownicy??5      $??10,99,10,-205q?6'   $??4??6?   $??2??6s    J? RenderTransformOrigin$	 1,0&?6?   $??Visible=?6?   ??6L   ?? *FindPracownika+ ?? View 5       ?? 5"       ?? AllowsColumnReorder$
 true??6   	 ?? ColumnHeaderToolTip$	 
Pracownicy??66   .P?5#      ?? $??ID Pracownika??6~   
 ?? Width$

 auto??6?    ?? DisplayMemberBinding 6%   ??  ?? Path$ Id_Pracownika?$ PropertyChanged=?6?   ?? 5%      $??Imię pracownika??6?   $

 auto??6?    6%   ?? $ Imię_pracownika?$ PropertyChanged=?6?   ?? 5'      $??Nazwisko pracownika??6?   $

 auto??6?    6%   ?? $ Nazwisko_pracownika?$ PropertyChanged=?6?   ?? 5)      $??Numer telefonu??6?   $

 auto??6?    6%   ?? $ Numer_telefonu_pracownika?$ PropertyChanged=?6?   ?? 5+      $??Pesel??6?   $

 auto??6?    6%   ?? $ PESEL_pracownika?$ PropertyChanged=?6?   ?? 5-      $??Email??6?   $

 auto??6?    6%   ?? $ Email_pracownika?$ PropertyChanged=?6?   ?? 5/      $??Data zatrudnienia??6?   $

 auto??6?    6%   ?? $ Data_zatrudnienia?$ PropertyChanged=?6?   ?? 51      $??Data urodzenia??6   $

 auto??6?    6%   ?? $ Data_urodzenia?$ PropertyChanged=?6?   ?? 53      $??	Id Adresu??6z   $

 auto??6?    6%   ?? $ 	Id_Adresu?$ PropertyChanged=?6?   54      57      58      59      