   M S B A M L   `   `   `  ????F  BProjekt_PIV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projekt_PIV.ViewsProjekt_PIV.Views  5      &     Projekt_PIV.Views.ListZamowienia   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Projekt_PIV.Views     5        N? Title$  ListZamowienia??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6   $??1??6    $??4,0,0,0q?6-   $??ID Zamówinia: ??6>   $??Right=?6W   ?? 5   
   $??1??6   $??1??6    $??	250,0,0,0q?6-   $*??$0 - wyświetla wszystkie zamówienia??6@   $
??Left=?6m   ?? 5   
   -   5         ??Name$ Id_Zamówienia??5      $??1??6T   $??1??6d   $??4q?6q   $
??Left=?6?   $	??200??6?   ??6|   ?? *Id_Zamówienia+ ?? UpdateSourceTrigger$ PropertyChanged=?6?   ?? 5   
   $??1??6   $??4??6!   $??4q?6.   $??Szukaj zamówienia??69   $
??Left=?6}   $	??Top=?6?   ??6U   ?? *ListZamówieniaClick+6?   ?? 5   
   -   5         ??Name$ 
Zamowienia??5      $??10,99,10,-205q?6'   $??4??6?   $??2??6s    J? RenderTransformOrigin$	 1,0&?6?   $??Visible=?6?   ??6L   ?? *FindZamowienia+ ?? View 5      ?? 5!       ?? AllowsColumnReorder$
 true??6   	 ?? ColumnHeaderToolTip$	 Zamówienia??66   .P?5"      ?? $??ID Zamówienia??6~   
 ?? Width$

 auto??6?    ?? DisplayMemberBinding 6%   ??  ?? Path$ Id_Zamówienia?$ PropertyChanged=?6?   ?? 5$      $??Id_Produktu??6|   $

 auto??6?    6%   ?? $ Id_Produktu?$ PropertyChanged=?6?   ?? 5&      $??Cena jednostkowa??6?   $

 auto??6?    6%   ?? $ Cena_jednostkowa?$ PropertyChanged=?6?   ?? 5(      $??Ilość??6v   $

 auto??6?    6%   ?? $ Ilość?$ PropertyChanged=?6?   5*      5-      5.      5/      