   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProjectFinal.View.ProductProjectFinal.View.Product  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      )    #ProjectFinal.View.Product.ProductUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ProjectFinal.View.Product     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      +   %ProjectFinal.Converter.ImageConverter  ProductImage1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%:   &	       &	        5   
   6#     5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   66   �� 5      $
��auto �6'   66   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�66   $��0��6I   .+�5       ��   PRODUCT#���  6    $
��Left=�6A   $��Center=�6\   $��22(�5!      $��	20 0 20 0q�5"      ���	#FF4A57D8$
��Bold"�5$      5&      �� 5'      ���	#FF4A57D8
�������$
��Left=�5,      $��Center=�64    $  MaterialDesignRaisedAccentButton#��[ 5.      $��ADD NEW��50      ��5(      �� *AddNewProductCMD+��5+      Z� 50      52      �� 54      $��1��6   
�������$	��0.3q�6<   $��
15 10 5 10q�6R   $	��397��6f   $	��397��6u   $
��Left=�6�    �� CornerRadius$ 3��6�   ._�55      �  56        PrimaryHueMidBrush �� Color��%/   &	       �� 57      $ Transparent��6I   58       59      �� 5:      $	��.2* �6/   �� 5;      $��* �6/   .+�5=      �� $
��Auto��6!   $
��Auto��6.     MaterialDesignFlatButton#��[ 6a   ���	#FF4A57D8��6<   �� *SearchProductCMD+��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Search=�	   Size$	 19X�6�   �� 5>      $��1��6"   $	��5 0q�62   
 �� 
CaretBrush
 �	#FF4A57D8$��Center=�6�   $��16(�6�   ���	#FF4A57D8  ENTER_TEXT_TO_SEARCH)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   ���	#FF4A57D8��6@   �� *ContentSearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6M   J� InputBindings 5?      �� 5@   "   
 �� Key$ Return��6R    �� Command 6-   �� *SearchProductCMD+6R   .��5A   5   5B      5C      5D      5E      5G        5H   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��5I      �� $��Center=�6u   $��Center=�6�   ��6   �� *ProductList+ �� SelectedItem 6;   �� *SelectedItem+$ OneWayToSource=� �� View 5J      �� 5K      .P�5L      ��  	 NO.#��� 	 6)    �� DisplayMemberBinding 6H   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� 	Converter# [ 6�   �� 5M      $
��Name��6)    67   �� *name+6_   �� 5N      $��Hình ảnh��6)    �� CellTemplate 5O      �� 5P   "   .R�5Q   &   �� $��Uniform=�6N   $��70��6`   $��70��6l   $��Center=�6w   $��Center=�6�   ��6,   �� *image_product+6�   5R   #   5T      �� 5U      $
��Size��6)    67   �� *size+6_   �� 5V      $
��Gía��6)    66   �� *price+6_   �� 5W       5X      �� 5Y   "   .R�5Z   &   �� ���	#FF4A57D8
������� 
 MaterialDesignRaisedButton#��[
 5^      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5_      $��70��5a   )   $��Sửa��5b   )   ��5[   +   ��  �� $ ItemsControlL� �� Path$  DataContext.EditProductCMD���6�   �� ��5`   (   Z� 5b   )   5d   #   5f      �� 5g       5h      �� 5i   "   .R�5j   &   �� ���	#FF4A57D8
�������#��[
 5n      $ 10��5o      $��70��5q   )   $
��Xoá��5r   )   ��5k   +   ��  �� $ ItemsControlL�$" DataContext.DeleteProductCMD���6�   �� ��5p   (   Z� 5r   )   5t   #   5v      5w      5y      5|      5}      5~      