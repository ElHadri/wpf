   M S B A M L   `   `   `  ����N  JCH07.RoutedCommands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CH07.RoutedCommandsCH07.RoutedCommands  5   	   $    CH07.RoutedCommands.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CH07.RoutedCommands     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6(     5   
   -   5        $ IncreaseZoom��5      6D     5   
   -   5        $ DecreaseZoom��5      6E     5   
   -   5        $&  local:Commands.ZoomNormalCommand��5      6\   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   c� $��14(�6   .@�5      �� $��Open...��6   $
��Open��6'   $��6q�66   �� 5      $��Zoom In��6   $��IncreaseZoom��6'   $��6q�6>   �� 5      $��Zoom Out��6   $��DecreaseZoom��6(   $��6q�6?   �� 5      $��Normal��6   $&�� local:Commands.ZoomNormalCommand��6&   $��6q�6Q   5      �� 5   
   $
��Auto=�6   $
��Auto=�6<   $��1��6_   .��5      �� $
��None=�61   ��6   �� *	ImagePath+ � LayoutTransform 5       �� 5!       �� ScaleX 6%   �� *Zoom+ �� ScaleY 6=   �� *Zoom+5#      5$      5%      5&      