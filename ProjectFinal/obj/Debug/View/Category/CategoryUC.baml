   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjectFinal.View.CategoryProjectFinal.View.Category  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      +    %ProjectFinal.View.Category.CategoryUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ProjectFinal.View.Category     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%   &	         5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      ��   CATEGORY#���  6   $
��Left=�6>   $��Center=�6Y   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5      5       �� 5!      ���	#FF4A57D8
�������$
��Left=�5&      $��Center=�64    $  MaterialDesignRaisedAccentButton#��[ 5(      $��ADD NEW��5*      ��5"      �� *AddNewCategoryCMD+��5%      Z� 5*      5,      5-        5.   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��5/      �� $��Center=�6v   $��Center=�6�   ��6   �� *CategoryList+ �� SelectedItem 6<   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 50      �� 51      .P�52      ��   NO.#���  6)    �� DisplayMemberBinding 6H   �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 �� �� 	Converter# [ 6�   �� 53      $��Tên danh mục��6)    6?   �� *type_product+6o   �� 55       �� CellTemplate 56      �� 57   "   .R�58   &   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5<      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5=      $��70��5?   )   $��Sửa��5@   )   ��59   +   �� 	 �� $
 ItemsControlL� �� Path$! DataContext.EditCategoryCMD���6�   �� ��5>   (   Z� 5@   )   5B   #   5D      �� 5E       5F      �� 5G   "   .R�5H   &   �� ���	#FF4A57D8
�������#��[ 5L      $ 10��5M      $��70��5O   )   $
��Xoá��5P   )   ��5I   +   �� 	 �� $
 ItemsControlL�$# DataContext.DeleteCategoryCMD���6�   �� ��5N   (   Z� 5P   )   5R   #   5T      5U      5W      5Z      5[      5\      