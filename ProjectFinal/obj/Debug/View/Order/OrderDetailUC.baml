   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ProjectFinal.View.OrderProjectFinal.View.Order  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      C&clr-namespace:ProjectFinal.ValidationsProjectFinal.Validations  5	      +    %ProjectFinal.View.Order.OrderDetailUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ProjectFinal.View.Order     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5      2valid&clr-namespace:ProjectFinal.Validations  5	         MaterialDesignBody#���   5
      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      +   %ProjectFinal.Converter.ImageConverter  ProductImage1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%:   &	       &	        5   
   6#     5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      �� $��Chi tiết đơn hàng��6   $
��Left=�65   $��Center=�6P   $��22(�5      $��	20 0 20 0q�5       ���	#FF4A57D8$
��Bold"�5"      5$      5%      5&        5'   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��5(      �� $��Center=�6u   $��Center=�6�   ��6   �� *OrderDetailList+ �� SelectedItem 6?   �� *ProductSelected+ �� Mode$ TwoWay=� �� View 5)      �� 5*      .P�5+      ��   NO.#���  6)    �� DisplayMemberBinding 6H   �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 �� �� 	Converter# [ 6�   �� 5,      $
��Name��6)    67   �� *name+6_   �� 5-      $��Hình ảnh��6)    �� CellTemplate 5.      �� 5/   "   .R�50   &   �� $��Uniform=�6N   $��50��6`   $��50��6l   $��Center=�6w   $��Center=�6�   ��6,   �� *image_product+6�   51   #   53      �� 54      $
��Size��6)    67   �� *size+6_   �� 55      $
��Gía��6)    66   �� *price+6_   �� 56      $��Số lượng��6)    6;   �� *
quantity+6g   �� 57       58      �� 59   "   .R�5:   &   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5>      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5?      $��70��5A   )   $
��Xoá��5B   )   ��5;   +   �� 	 �� $
 ItemsControlL� �� Path$ DataContext.DeleteCMD���6�   �� ��5@   (   Z� 5B   )   5D   #   5F      5G      5I      5J      �� 5K   
   $��7��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   $��5q�6g   .+�5L      �� -   5         ��Name$ 
btn_cancel��5L      $	��5 0q�6)    
 CANCEL#���  66     MaterialDesignFlatButton#��[ 6Y   ��6�   �� *	CancelCMD+5M      5N      5O      