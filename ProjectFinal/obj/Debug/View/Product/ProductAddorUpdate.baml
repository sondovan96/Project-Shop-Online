   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProjectFinal.View.ProductProjectFinal.View.Product  5      C&clr-namespace:ProjectFinal.ValidationsProjectFinal.Validations  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5
      2    ,ProjectFinal.View.Product.ProductAddorUpdate   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ProjectFinal.View.Product     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      2valid&clr-namespace:ProjectFinal.Validations  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      4	converter$clr-namespace:ProjectFinal.Converter  5
      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont#���   5       � 	Resources 5       �� 
TargetType  Slt_btn_save  MaterialDesignFlatButton �� BasedOn �� Property �� Value �� Triggers ^� 
Conditions	 �� Binding
 �� ElementName �� Path �� Value+   %ProjectFinal.Converter.ImageConverter  ImageConverter��%�  &	       7  &	 ^    �� 5   
   " ��6   8   .�5      ��  � {� .  6*    5      ^� 5       5      �� 5      	 6$   �� $
 tbx_name��$ (Validation.HasError)�	 False6h   �� 5      	 6$   �� $
 cbx_cat��$ (Validation.HasError)�	 False6g   �� 5      	 6$   �� $
 cbx_promotion��$ (Validation.HasError)�	 False6m   �� 5      	 6$   �� $
 cbx_size��$ (Validation.HasError)�	 False6h   �� 5      	 6$   �� $
 	tbx_price��$ (Validation.HasError)�	 False6i   0�5      �� 5       � {� . 66   5       5"        5#   
   6#   5$      .��5%      � 
������� � RowDefinitions 5&   
   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6    � ColumnDefinitions 5/   
   �� 50      $��* �6   �� 51      $��* �6   .+�53   
   �� $��0��6   $��8��6!   $	��0.7q�62   
�������$��5q�6]    �� CornerRadius$ 7��6h   $	��320��6y   $	��320��6�   ._�54      � .+�55      �� $��Uniform=�6r   $��2q�6�   ��6   �� *ProductCurrent.image_product+ �� 	Converter# [ 6�   �� 56      $��Right=�6   $��Bottom=�65   $��5q�6P    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6[   ���#7D8085���#7D8085
������� J� Opacity$	 0.7Q�57   �   ��6D   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Camera=�   Size$ 19X���58      �� *OpenDialogChooseImageCMD+59      5:      �� 5;   
   $��0��6   $��1��6!   $��	17 17 7 7q�6I   $��16(�6\   $��SemiBold"�6j   ��61   �� *Header+6j   �� 5<   
   -   5         ��Name$ tbx_name��5<   /   $��1��6   $��1��6    ! MaterialDesignOutlinedTextBox#��[ 6A   $	��320��6x   $��15q�6�   $��14(�6�     NAME)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6�   .��6�   ��5=      �� 5>      $ ProductCurrent.name�6    �� UpdateSourceTrigger$ PropertyChanged=�65    �� Mode$ TwoWay=�6[    �� ValidationRules 5?      2   ,ProjectFinal.Validations.EmptyRuleValidation  5@      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 64   5B      .��5C      5D      �� 5E   
   -   5         ��Name$ cbx_cat��5E   0   $��2��6   $��1��6     �� DisplayMemberPath$ type_product��6d    " MaterialDesignOutlinedComboBox#��[ 6�   $	��320��6�   $��15q�6�   $ 
Danh Mục��6�   $��14(�6  ��6A   �� *
Categories+ �� SelectedItem 5F      �� 5G      $ CategorySelected�6   $ PropertyChanged=�62   $ TwoWay=�6X    5H      9   3ProjectFinal.Validations.NullSelectedItemValidation  5I       . 6;   5K      5M      �� 5N   
   -   5        $ cbx_promotion��5N   0   $��3��6   $��1��6    $
 name��6i   #��[ 6�   $	��320��6�   $��15q�6�   $��14(�6�   $" Chương trình quảng cáo��6�   ��6G   �� *	Promotion+ 5O      �� 5P      $ PromotionSelected�6   $ PropertyChanged=�63   $ TwoWay=�6Y    5Q        5R       . 6;   5T      5V      �� 5W   
   -   5        $ cbx_size��5W   0   $��4��6   $��1��6    $ 	name_size��6_   #��[ 6}   $	��160��6�   $��15 15 215 15q�6�   $��14(�6�   $ Chọn Size��6�   ��6B   �� *Size+ 5X      �� 5Y      $ SizeSelected�6   $ PropertyChanged=�6.   $ TwoWay=�6T    5Z        5[       . 6;   5]      5_      �� 5`   
   -   5        $ 	cbx_color��5`   0   $��4��6   $��1��6    $ 
name_color��6a   #��[ 6�   $	��160��6�   $��215 15 15 15q�6�   $��14(�6�   $ Chọn Màu��6�   ��6C   �� *Color+ 5a      �� 5b      $ ColorSelected�6   $ PropertyChanged=�6/   $ TwoWay=�6U    5c        5d       . 6;   5f      5h      �� 5i   
   -   5        $ 	tbx_price��5i   /   $��5��6   $��1��6   #��[ 6B   $	��320��6y   $��15q�6�   $��14(�6�   $ Gía Sản Phẩm��6�   .��6�   ��5j      �� 5k      $ ProductCurrent.price�6   $ PropertyChanged=�66   $ TwoWay=�6\    5l        5m       . 64   5o      .��5p      5q      �� 5r   
   $��7��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��5q�6g   .+�5s      �� -   5         ��Name$ btn_save��5s      #��[ 6'     SAVE#���  6M    �� 	IsDefault . ��6n   �� $
 
btn_cancel��$ ActualWidth���6�   �� *	SaveCMD+6�   �� 5t      -   5        $ 
btn_cancel��5t      $	��5 0q�6)    
	 CANCEL#��� 	 66   #��[ 6Y   ��6�   �� *	CancelCMD+5u      5v      5w      