   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ProjectFinal.View.OrderProjectFinal.View.Order  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      %    ProjectFinal.View.Order.OrderUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ProjectFinal.View.Order     5      :	converter$clr-namespace:ProjectFinal.Converter     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          >�Name$  oderuc��5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      +   %ProjectFinal.Converter.ImageConverter  ProductImage1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%:   &	       &	        5   
   6#     5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      ��  	 ORDER#���  6   $
��Left=�6;   $��Center=�6V   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5       5"      �� 5#      ���	#FF4A57D8
�������$
��Left=�5(      $��Center=�60    $  MaterialDesignRaisedAccentButton#��[ 5)      $��ADD NEW��5*      ��5$      �� *AddNewOrderCMD+��5'      Z� 5*      5,      5-        5.   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��5/      �� $
��Left=�6s   $��Center=�6�   ��6   �� *	OrderList+ �� SelectedItem 69   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 50      �� 51      .P�52      ��   NO.#���  6)   	 �� DisplayMemberBinding	 6H   �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" �� �� 	Converter# [ 6�   �� 53      $
��Name��6)   	 67   �� *CUSTOMER.name+6h   �� 54      $��Email��6)   	 68   �� *CUSTOMER.email+6j   �� 55      $��Total Price��6)   	 6>   �� *total_price+6m   �� 56      $��
Time Order��6)   	 6=   �� *delivery_time+6n   �� 57      $��Status��6)   	 69   �� *status_order+6i   �� 58       �� CellTemplate 59      �� 5:   "   .R�5;   &   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5?      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5@      $��70��5B   )   $��Sửa��5C   )   ��5<   +   �� 
 �� $ ItemsControlL� �� Path$ DataContext.EditOrderCMD���6�   �� ��5A   (   Z� 5C   )   5E   #   5G      �� 5I       5J      �� 5K   "   .R�5L   &   �� ���	#FF4A57D8
�������#��[ 5P      $ 10��5Q      $
��auto��5S   )   $��Trạng thái��5T   )   ��5M   +   �� 
 �� $ ItemsControlL�$$ DataContext.EditStatusOrderCMD���6�   �� ��5R   (   Z� 5T   )   5V   #   5X      �� 5Y       5Z      �� 5[   "   .R�5\   &   �� ���	#FF4A57D8
�������#��[ 5`      $ 10��5a      $��70��5c   )   $	��Xem��5d   )   ��5]   +   �� 
 �� $ ItemsControlL�$% DataContext.CheckOrderDetailCMD���6�   �� ��5b   (   Z� 5d   )   5f   #   5h      �� 5i       5j      �� 5k   "   .R�5l   &   �� ���	#FF4A57D8
�������#��[ 5p      $ 10��5q      $
��auto��5s   )   $��Thêm sản phẩm��5t   )   ��5m   +   �� 
 �� $ ItemsControlL�$* $DataContext.AddProductOrderDetailCMD���6�   �� ��5r   (   Z� 5t   )   5v   #   5x      �� 5y       5z      �� 5{   "   .R�5|   &   �� ���	#FF4A57D8
�������#��[ 5�      $ 10��5�      $
��auto��5�   )   $��In hoá đơn��5�   )   ��5}   +   �� 
 �� $ ItemsControlL�$ DataContext.PrintBillCMD���6�   �� ��5�   (   Z� 5�   )   5�   #   5�      5�      5�      5�      5�      5�      