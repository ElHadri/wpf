   M S B A M L   `   `   `  ����X  TCH06.ElementToElementBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CH06.ElementToElementBindingsCH06.ElementToElementBindings  5   	   .    (CH06.ElementToElementBindings.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:CH06.ElementToElementBindings     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��This is a sizing text��6    �� TextAlignment$ Center=�61   $��Center=�6H   ��5      ��  �� ElementName$ _slider�� �� Path$ Value��� 5   
   -   5         ��Name$ _slider��5      $��1��6"    � Minimum$ 10Q�6/    � Maximum$ 80Q�6<    � Value$ 30Q�6I   �� 5   
   	 �� Orientation$	 
Horizontal=�6   $��2��6.   .+�5      �� -   5        
 ��Name$
 _text��5   `   $��20(�6o   ��6   �� *Value+$ _slider�� �� UpdateSourceTrigger$ Explicit=�6o   �� 5      -   5        $"��Update the source explicitly��5      6<   5      5      5      