   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      #    Projekt_PIV.Views.ListKlienci   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  ListKlienci??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??4,0,0,0q?6-   $??ID Klienta: ??6>   $??Right=?6U   ?? 5   
   $??1??6   $??1??6    $??	250,0,0,0q?6-   $)??#0 - wyświetla wszystkich klientów??6@   $
??Left=?6l   ?? 5   
   -   5         ??Name$ 
Id_Klienta??5      $??1??6Q   $??1??6a   $??4q?6n   $
??Left=?6?   $	??200??6?   ??6y   ?? *
Id_Klienta+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   $??1??6   $??4??6!   $??4q?6.   $??Szukaj klienta??69   $
??Left=?6w   $	??Top=?6?   ??6R   ?? *ListKlienciClick+6?   ?? 5   
   -   5         ??Name$ Klienci??5      $??10,99,10,-205q?6$   $??4??6<   $??2??6m    J? RenderTransformOrigin$	 1,0&?6?   $??Visible=?6?   ??6I   ?? *FindKlienci+ ?? View 5      ?? 5!       ?? AllowsColumnReorder$
 true??6   	 ?? ColumnHeaderToolTip$	 Klienci??66   .P?5"      ?? $??
ID Klienta??6{   
 ?? Width$
 50??6?    ?? DisplayMemberBinding 6%   ??  ?? Path$ 
Id_Klienta?$ PropertyChanged=?6?   ?? 5$      $??Imię klienta??6}   $	
 100??6?    6%   ?? $ Imię_klienta?$ PropertyChanged=?6?   ?? 5&      $??Nazwisko klienta??6?   $	
 100??6?    6%   ?? $ Nazwisko_klienta?$ PropertyChanged=?6?   ?? 5(      $??Numer telefonu??6?   $	
 100??6?    6%   ?? $ Numer_telefonu_klienta?$ PropertyChanged=?6?   ?? 5*      $??Pesel??6~   $	
 150??6?    6%   ?? $ PESEL_klienta?$ PropertyChanged=?6?   ?? 5,      $??Email??6~   $	
 150??6?    6%   ?? $ Email_klienta?$ PropertyChanged=?6?   ?? 5.      $??	Id Adresu??6z   $	
 150??6?    6%   ?? $ 	Id_Adresu?$ PropertyChanged=?6?   5/      52      53      54      