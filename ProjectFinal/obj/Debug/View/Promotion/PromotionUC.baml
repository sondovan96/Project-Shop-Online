   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjectFinal.View.PromotionProjectFinal.View.Promotion  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      -    'ProjectFinal.View.Promotion.PromotionUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjectFinal.View.Promotion     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      +   %ProjectFinal.Converter.ImageConverter  ProductImage1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%:   &	       &	        5   
   6#     5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      ��   	PROMOTION#���  6   $
��Left=�6?   $��Center=�6Z   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5      5!      �� 5"      ���	#FF4A57D8
�������$
��Left=�5'      $��Center=�64    $  MaterialDesignRaisedAccentButton#��[ 5)      $��ADD NEW��5+      ��5#      �� *AddNewPromotionCMD+��5&      Z� 5+      5-      5.        5/   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��50      �� $��Center=�6w   $��Center=�6�   ��6   �� *PromotionList+ �� SelectedItem 6=   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 51      �� 52      .P�53      ��   NO.#���  6)    �� DisplayMemberBinding 6H   �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 �� �� 	Converter# [ 6�   �� 54      $
��Name��6)    67   �� *name+6_   �� 55      $��Hình ảnh��6)    �� CellTemplate 56      �� 57   "   .R�58   &   �� $��Uniform=�6P   $��70��6b   $��70��6n   $��Center=�6y   $��Center=�6�   ��6,   �� *image_promotion+6�   59   #   5;      �� 5<      $��Giảm %��6)    69   �� *percent_down+6i   �� 5=      $
��Từ��6)    65   �� *available_from+6g   �� 5>      $��Đến��6)    66   �� *available_to+6f   �� 5?       5@      �� 5A   "   .R�5B   &   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5F      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5G      $��70��5I   )   $��Sửa��5J   )   ��5C   +   �� 	 �� $
 ItemsControlL� �� Path$" DataContext.EditPromotionCMD���6�   �� ��5H   (   Z� 5J   )   5L   #   5N      �� 5O       5P      �� 5Q   "   .R�5R   &   �� ���	#FF4A57D8
�������#��[ 5V      $ 10��5W      $��70��5Y   )   $
��Xoá��5Z   )   ��5S   +   �� 	 �� $
 ItemsControlL�$$ DataContext.DeletePromotionCMD���6�   �� ��5X   (   Z� 5Z   )   5\   #   5^      5_      5a      5d      5e      5f      