   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      $    Projekt_PIV.Views.ListProdukty   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  ListProdukty??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??4,0,0,0q?6-   $??ID Faktury: ??6>   $??Right=?6U   ?? 5   
   $??1??6   $??1??6    $??	250,0,0,0q?6-   $'??!0 - wyświetla wszystkie produkty??6@   $
??Left=?6k   ?? 5   
   -   5         ??Name$ Id_Produktu??5      $??1??6R   $??1??6b   $??4q?6o   $
??Left=?6?   $	??200??6?   ??6z   ?? *Id_Produktu+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   $??1??6   $??4??6!   $??4q?6.   $??Szukaj produkt??69   $
??Left=?6x   $	??Top=?6?   ??6R   ?? *ListProduktyClick+6?   ?? 5   
   -   5         ??Name$ Produkty??5      $??10,99,10,-205q?6%   $??4??6=   $??2??6o    J? RenderTransformOrigin$	 1,0&?6?   $??Visible=?6?   ??6J   ?? *FindProdukty+ ?? View 5       ?? 5"       ?? AllowsColumnReorder$
 True??6   	 ?? ColumnHeaderToolTip$	 Produkty??66   .P?5#      ?? $??ID??6|   
 ?? Width$

 auto??6?    ?? DisplayMemberBinding 6%   ??  ?? Path$ Id_Produktu?$ PropertyChanged=?6?   ?? 5%      $??Nazwa??6   $

 auto??6?    6%   ?? $ Nazwa_produktu?$ PropertyChanged=?6?   ?? 5'      $??Cena Jednostkowa??6?   $

 auto??6?    6%   ?? $ Cena_jednostkowa?$ PropertyChanged=?6?   ?? 5)      $??Ilość??6   $

 auto??6?    6%   ?? $ Dostępna_ilość?$ PropertyChanged=?6?   5*      5-      5.      5/      