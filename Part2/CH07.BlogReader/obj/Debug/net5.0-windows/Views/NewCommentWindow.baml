   M S B A M L   `   `   `  ����J  FCH07.BlogReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CH07.BlogReader.ViewsCH07.BlogReader.Views  5   	   ,    &CH07.BlogReader.Views.NewCommentWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CH07.BlogReader.Views     5   	     � Title$  NewCommentWindow��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   ]� .+�5      �� $��Title:��6   $
��Left=�6&   $��Center=�6<   �� 5      $��10,0,0,0q�6   ��6(   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��4q�6   $��1��6    �� AcceptsReturn$
 True��6*   ��6?   �� *Text+$ PropertyChanged=�A� 5   
    A� Rows$ 1��6    A� Columns$ 2��6   $��2��6+   $��2,10,2,2q�68   .+�5      �� -   5        $��Right=�5      $	��6,0q�61   $��50��6>   $��OK��6k    �� 	IsDefault$
 True��6x   {�6I   �� *IsCommentOK+6�   �� 5      $
��Left=�6   $	��6,0q�60   $��50��6=   $��Cancel��6H    �� IsCancel$
 True��6Y   5      5      5      