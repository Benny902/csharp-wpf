   M S B A M L   `   `   `  ����M  IWpfApp-DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApp2_DataBinding1.ExWpfApp2_DataBinding1.Ex  5      !    WpfApp2_DataBinding1.Ex.Ex8   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:WpfApp2_DataBinding1.Ex     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��0.1* �6   �� 5      $
��0.2* �6   .+�5   
   ��  �� DisplayMemberPath$ Title��60   $	��150��6}   ��6   �� *Books+ �� SelectedItem 6J   �� *SelectedBook+ �� Mode$ TwoWay=�6}   �� 5   
   $��1��6   $��10q�6%   .+�5      �� $��Book Details��6   $
��Bold"�6,   $��0,0,0,10q�6>   �� 5      $��Title:��6   $
��Bold"�6&   �� 5      ��6   �� *SelectedBook.Title+�� 5      $��Author:��6   $
��Bold"�6'   $��0,10,0,0q�69   �� 5      ��6   �� *SelectedBook.Author+�� 5      $��Description:��6   $
��Bold"�6,   $��0,10,0,0q�6>   �� 5      ��6   �� *SelectedBook.Description+5      5      5      