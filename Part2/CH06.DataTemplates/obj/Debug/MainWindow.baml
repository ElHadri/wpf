   M S B A M L   `   `   `  ����M  ICH06.DataTemplates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CH06.DataTemplatesCH06.DataTemplates  5   	   #    CH06.DataTemplates.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CH06.DataTemplates     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         personTemplate �� TextAlignment �� DataType  CH06.DataTemplates.Book��%P  &	        (��     5      *, +)�� 5   
   .R�5      �� 
��� � �$��2q�6)   ._�5      �� $��4q�6   .+�5      �� 
���  ��$��20(�61   $ Center=�6U   ��6?   �� *Name+6U   �� 5      $��16(�6    $ Right=�6C   ��6.   �� *Age+6C   5      5      5      �� 5   
   "  6   .R�5      �� 
����  �$��2q�6(   ._�5      �� $��4q�6   .+�5      �� 
���   �$��20(�63   $ Center=�6X   ��6A   �� *Title+6X   �� 5      $��16(�6    $ Right=�6E   ��6.   �� *Pages+6E   5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       �� 5!      �� 5"      �� 5#      .+�5&   
   �� #��[  6%   ��6   �� 6%   �� 5'   
   -   5         ��Name$ _list��5'      $��1��6   $��Stretch=�6.   #��[  6S   �� 5)   
   -   5        $��2��5)      $��Add an item��6   64   �� 5*   
   -   5        $ _list2��5*      $��3��6   $��Stretch=�6/   #��[  6T   �� 5,   
   -   5        $ 	_bookList��5,      $��4��6   $��Stretch=�62   5.      5/      