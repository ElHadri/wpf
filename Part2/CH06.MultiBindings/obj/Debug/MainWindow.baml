   M S B A M L   `   `   `  ����M  ICH06.MultiBindings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CH06.MultiBindingsCH06.MultiBindings  5   	   #    CH06.MultiBindings.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CH06.MultiBindings     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      %  CH06.MultiBindings.RGBConverter   rgbConverter��%   &	          5
   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� 
���   �$��1��6#   $��4q�67   ��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� ElementName$
 _red��6    �� Path$ Value�63   �� 5      $ _green��6   $ Value�63   �� 5      $ _blue��6   $ Value�63   5      5      �� 5   
   -   5         ��Name$
 _red��5   6    � Minimum$ 0Q�6    � Maximum$	 255Q�6   $��4q�6+   $��1��6D   �� 5    
   -   5        $ _green��5    6   $ 0Q�6   $	 255Q�6   $��4q�6+   $��2��6F   �� 5!   
   -   5        $ _blue��5!   6   $ 0Q�6   $	 255Q�6   $��4q�6+   $��3��6E   �� 5"   
   $��18(�6   $��Center=�6"   $��Center=�6=   $��4��6Z   ��5#      `� 5$      	 �� StringFormat$%	 R: {0:N0}, G: {1:N0}, B: {2:N0}��6   .1�5%      �� $ Value�6   $
 _red��6+   �� 5&      $ Value�6   $ _green��6+   �� 5'      $ Value�6   $ _blue��6+   5(      5*      5+      5,      