   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjectFinal.View.ParameterProjectFinal.View.Parameter  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      -    'ProjectFinal.View.Parameter.ParameterUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjectFinal.View.Parameter     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      +   %ProjectFinal.Converter.ImageConverter  ProductImage1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%:   &	       &	        5   
   6#     5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��	0 20 0 20q�6;   $��Center=�6N   .+�5      ��   	PARAMETER#���  6   $��Center=�6;   $��Center=�6X   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5      5       5!      � 5"   
   $��1��6    � ColumnDefinitions 5#      �� 5$      $��* �6#   6/   �� 5%      $��* �6#   6/   .+�5'      � $��0��6    5(      �� 5)      $
��auto �6$   64   �� 5*      $
��auto �6$   64   .+�5,      #  MaterialDesignThemes.Wpf.Card  $��0��6&   $��0��66   .��5-      �� $ 
Horizontal=�6!   $��	0 20 0 20q�6:   .+�5.      ��   SIZE#���  6$   $
��Left=�6B   $��Center=�6]   $��22(�5/      $��	20 0 20 0q�50      ���	#FF4A57D8$
��Bold"�52      54      �� 57      ���	#FF4A57D8
�������$
��Left=�5=      $��Center=�60    $  MaterialDesignRaisedAccentButton#��[ 5>      $��ADD NEW��5?      ��59      �� *AddNewParaSizeCMD+��5<      Z� 5?      5A      5B        5C      $��1��6(   $��Center=�65   $��5q�6P   $	��520��6[   .��5D      �� $��Center=�6z   $��Center=�6�   ��6   �� *
SizeList+ �� SelectedItem 6@   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 5E      �� 5F      .P�5G   "   ��   NO.#���  61   	 �� DisplayMemberBinding	 6P   �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" �� �� 	Converter# [ 6�   �� 5H   "   $
��Name��61    �� Width$
 auto��6j   	 6?   �� *	name_size+6y   �� 5I   "    �� CellTemplate 5J   &   �� 5K   *   .R�5L   .   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5P      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5Q      $��70��5S   )   $��Sửa��5T   )   ��5M   +   �� 
 �� $ ItemsControlL� �� Path$! DataContext.EditParaSizeCMD���6�   �� ��5R   (   Z� 5T   )   5V   +   5X   #   �� 5Y   "    5Z   &   �� 5[   *   .R�5\   .   �� ���	#FF4A57D8
�������#��[ 5`      $ 10��5a      $��70��5c   )   $
��Xoá��5d   )   ��5]   +   �� 
 �� $ ItemsControlL�$# DataContext.DeleteParaSizeCMD���6�   �� ��5b   (   Z� 5d   )   5f   +   5h   #   5i      5k      5n      5o      � 5p      $��1��6    5q      �� 5r      $
��auto �6$   64   �� 5s      $
��auto �6$   64   .+�5u        $��0��6&   .��5v      �� $ 
Horizontal=�6!   $��	0 20 0 20q�6:   .+�5w      ��  		 COLOR#��� 	 6$   $
��Left=�6C   $��Center=�6^   $��22(�5x      $��	20 0 20 0q�5y      ���	#FF4A57D8$
��Bold"�5{      5}      �� 5�      ���	#FF4A57D8
�������$
��Left=�5�      $��Center=�60   #��[ 5�      $��ADD NEW��5�      ��5�      �� *AddNewParaColorCMD+��5�      Z� 5�      5�      5�        5�      $��1��6'   $��Center=�64   $��5q�6O   $	��520��6Z   .��5�      �� $��Center=�6{   $��Center=�6�   ��6   �� *	ColorList+ 6A   �� *SelectedItem+$ OneWayToSource=� 5�      �� 5�      .P�5�   "   �� #���  61   	 6P   �� 
 �� *FindAncestor+" ��# [ 6�   �� 5�   "   $
��Name��61   $
 auto��6k   	 6?   �� *
name_color+6z   �� 5�   "    5�   &   �� 5�   *   .R�5�   .   �� ���	#FF4A57D8
�������#��[ 5�      $ 10��5�      $��70��5�   )   $��Sửa��5�   )   ��5�   +   �� 
 �� $ ItemsControlL�$" DataContext.EditParaColorCMD���6�   �� ��5�   (   Z� 5�   )   5�   +   5�   #   �� 5�   "    5�   &   �� 5�   *   .R�5�   .   �� ���	#FF4A57D8
�������#��[ 5�      $ 10��5�      $��70��5�   )   $
��Xoá��5�   )   ��5�   +   �� 
 �� $ ItemsControlL�$$ DataContext.DeleteParaColorCMD���6�   �� ��5�   (   Z� 5�   )   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      