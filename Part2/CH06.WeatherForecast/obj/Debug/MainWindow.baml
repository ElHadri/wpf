   M S B A M L   `   `   `  ����O  KCH06.WeatherForecast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CH06.WeatherForecastCH06.WeatherForecast  5   	   %    CH06.WeatherForecast.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CH06.WeatherForecast     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      :  4CH06.WeatherForecast.GeneralForecastToBrushConverter   gf2brush��%   &	          5
   
   60   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $(��"Select number of days to forecast:��6   $��15(�6B   $��Center=�6P   $��4q�6k   �� 5      -   5         ��Name$ _days��5       �� SelectedIndex$ 0��6&   $��50��68   �� 5      -   5        $��4q�5      $��Get Forecast��6    $��16(�67   6E   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��4q�6;   $��15(�6F   .+�5      �� $��Select units:��6   $��4q�6-   	� 5      $��Celsius��6    d� 	IsChecked$
 TrueY�6,   $
��10,4q�6=   	� 5      $��
Fahrenheit��6   $
��20,4q�6/   5      �� 5   
   $��2��6*   $��Stretch=�67   ��6   �� ��5      �� 5       .R�5!      ��  ��Name$ _border��6\   $��4q�6   
���   � �� Padding$ 4q�6<   $��2q�6H   ��5"      �� *GeneralForecast+	 �� 	Converter#	 [  ._�5#      �� $ 
Horizontal=�6%   .+�5$      �� $��20(�6(   $
��Bold"�66   ��5%   (   �� *GeneralForecast+�� 5&      $��16(�6(   $��10,0,0,0q�66   $��Bottom=�6H   ��5'   (   �� *TemperatureLow+
 �� StringFormat$
 Low: {0:N2}���� 5(      $��16(�6(   $��10,0,0,0q�66   $��Bottom=�6H   ��5)   (   �� *TemperatureHigh+$
 High: {0:N2}���� 5*      $��16(�6(   $��20,0,0,0q�66   $��Bottom=�6H   ��5+   (   �� *Percipitation+$
 Percip: {0:N2}��5,      5-      5<      5>      5@      5A      