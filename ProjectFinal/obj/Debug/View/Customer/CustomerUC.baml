   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjectFinal.View.CustomerProjectFinal.View.Customer  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      +    %ProjectFinal.View.Customer.CustomerUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ProjectFinal.View.Customer     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%   &	         5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      ��   CUSTOMER#���  6   $
��Left=�6>   $��Center=�6Y   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5      5       �� 5!      ���	#FF4A57D8
�������$
��Left=�5&      $��Center=�64    $  MaterialDesignRaisedAccentButton#��[ 5(      $��ADD NEW��5*      ��5"      �� *AddNewCustomerCMD+��5%      Z� 5*      5,      5-        5.   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��5/      �� $��Center=�6v   $��Center=�6�   ��6   �� *CustomerList+ �� SelectedItem 6<   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 50      �� 51      .P�52      ��   NO.#���  6)    �� DisplayMemberBinding 6H   �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 �� �� 	Converter# [ 6�   �� 53      $��	Họ tên��6)    69   �� *name+6a   �� 54      $��Giới tính��6)    6<   �� *gender+6f   �� 55      $��Email��6)    68   �� *email+6a   �� 56      $��Phone��6)    68   �� *phone+6a   �� 57      $��Địa chỉ��6)    6:   �� *	address+6e   �� 59       �� CellTemplate 5:      �� 5;   "   .R�5<   &   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5@      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5A      $��70��5C   )   $��Sửa��5D   )   ��5=   +   �� 	 �� $
 ItemsControlL� �� Path$! DataContext.EditCustomerCMD���6�   �� ��5B   (   Z� 5D   )   5F   #   5H      �� 5I       5J      �� 5K   "   .R�5L   &   �� ���	#FF4A57D8
�������#��[ 5P      $ 10��5Q      $��70��5S   )   $
��Xoá��5T   )   ��5M   +   �� 	 �� $
 ItemsControlL�$# DataContext.DeleteCustomerCMD���6�   �� ��5R   (   Z� 5T   )   5V   #   5X      5Y      5[      5^      5_      5`      