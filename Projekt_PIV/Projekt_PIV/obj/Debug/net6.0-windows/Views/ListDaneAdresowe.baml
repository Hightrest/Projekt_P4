   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      (    "Projekt_PIV.Views.ListDaneAdresowe   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  ListDaneAdresowe??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??4,0,0,0q?6-   $??ID Adresu: ??6>   $??Right=?6T   ?? 5   
   $??1??6   $??1??6    $??	250,0,0,0q?6-   $,??&0 - wyświetla wszystkie dane adresowe??6@   $
??Left=?6p   ?? 5   
   -   5         ??Name$ 	Id_Adresu??5      $??1??6P   $??1??6`   $??4q?6m   $
??Left=?6?   $	??200??6?   ??6x   ?? *	Id_Adresu+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   $??1??6   $??4??6!   $??4q?6.   $??Szukaj faktury??69   $
??Left=?6|   $	??Top=?6?   ??6R   ?? *ListDaneAdresoweClick+6?   ?? 5   
   -   5         ??Name$ Dane_Adresowe??5      $??10,99,10,-205q?6*   $??4??6B   $??2??6x    J? RenderTransformOrigin$	 1,0&?6?   $??Visible=?6?   ??6O   ?? *FindDaneAdresowe+ ?? View 5      ?? 5!       ?? AllowsColumnReorder$
 true??6   	 ?? ColumnHeaderToolTip$	 Faktury??66   .P?5"      ?? $??	ID Adresu??6z   
 ?? Width$
 50??6?    ?? DisplayMemberBinding 6%   ??  ?? Path$ 	Id_Adresu?$ PropertyChanged=?6?   ?? 5$      $??Ulica??6v   $	
 100??6?    6%   ?? $ Ulica?$ PropertyChanged=?6?   ?? 5&      $??Adres??6v   $	
 100??6?    6%   ?? $ Adres?$ PropertyChanged=?6?   ?? 5(      $??Miasto??6w   $	
 100??6?    6%   ?? $ Miasto?$ PropertyChanged=?6?   ?? 5*      $??Kod pocztowy??6}   $	
 150??6?    6%   ?? $ Kod_pocztowy?$ PropertyChanged=?6?   ?? 5,      $
??Kraj??6u   $	
 150??6?    6%   ?? $
 Kraj?$ PropertyChanged=?6?   5-      50      51      52      