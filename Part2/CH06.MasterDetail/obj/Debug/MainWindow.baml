   M S B A M L   `   `   `  ����L  HCH06.MasterDetail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CH06.MasterDetailCH06.MasterDetail  5   	   "    CH06.MasterDetail.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CH06.MasterDetail     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� -   5         ��Name$ _master��5   X   $��16(�6*    �� DisplayMemberPath$ ProcessName��68    �� SelectedIndex$ 0��6i   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6{   ��6   �� 6{   � 5   
   $��1��6   $��16(�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $��6q�6%   ��60   �� *ProcessName+ �� StringFormat$ 	Name: {0}���� 5      $��1��6   $��6q�6%   ��60   �� *Id+$ ID: 0���� 5      $��2��6   $��6q�6%   ��60   �� *PriorityClass+$ Priority Class: {0}���� 5      $��3��6   $��6q�6%   ��60   �� *Threads.Count+$ 
Threads: 0���� 5      $��4��6   $��6q�6%   ��60   �� *TotalProcessorTime+$ Processor Time: {0:G}��5      5      5      