   M S B A M L   `   `   `  ����S  OCH06.BindingToCollection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CH06.BindingToCollectionCH06.BindingToCollection  5   	   )    #CH06.BindingToCollection.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:CH06.BindingToCollection     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ _list��5       �� DisplayMemberPath$
 Name��69   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6R   ��6!   �� 6R   �� 5   
   -   5        $	��Add��5      $��1��6-   �� 5   
   -   5         ��Name$ _combo��5      $��2��6;   $	 Age��6H   $
 TrueY�6`   ��6#   �� 6`   5      5      