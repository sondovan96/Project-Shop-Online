   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProjectFinal.View.AccountProjectFinal.View.Account  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      )    #ProjectFinal.View.Account.AccountUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ProjectFinal.View.Account     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5         MaterialDesignBody#���   5	      $��Regular"�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 	Resources 5      1   +ProjectFinal.Converter.ListViewIndexConvert  ListViewIndex��%   &	         5   
   6*   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      ��   ACCOUNT#���  6   $
��Left=�6=   $��Center=�6X   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5      5       �� 5!      ���	#FF4A57D8
�������$
��Left=�5&      $��Center=�64    $  MaterialDesignRaisedAccentButton#��[ 5(      $��ADD NEW��5*      ��5"      �� *AddNewAccountCMD+��5%      Z� 5*      5,      5-        5.   
   $��1��6   $��Center=�6+   $��5q�6F   $	��520��6Q   .��5/      �� $��Center=�6r   $��Center=�6�   ��6   �� *
UserList+ �� SelectedItem 68   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 50      �� 51      .P�52      ��   NO.#���  6)    �� DisplayMemberBinding 6H   �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 �� �� 	Converter# [ 6�   �� 53      $��	Họ tên��6)    �� Width$	 150��6_    69   �� *name+6m   �� 54      $��Ảnh đại diện��6)    �� CellTemplate 55      �� 56   "   .R�57   &   �� $��Uniform=�6K   $��50��6]   $��50��6i   $��Center=�6t   $��Center=�6�   ��6,   �� *
image_user+6�   58   #   5:      �� 5;      $��Username��6)    6;   �� *	user_name+6h   �� 5<      $��Loại Account��6)    6?   �� *APP_ROLE.role_name+6u   �� 5=       5>      �� 5?   "   .R�5@   &   �� ���	#FF4A57D8
�������  MaterialDesignRaisedButton#��[ 5D      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5E      $��70��5G   )   $��Sửa��5H   )   ��5A   +   �� 	 �� $
 ItemsControlL� �� Path$  DataContext.EditAccountCMD���6�   �� ��5F   (   Z� 5H   )   5J   #   5L      �� 5M       5N      �� 5O   "   .R�5P   &   �� ���	#FF4A57D8
�������#��[ 5T      $ 10��5U      $��70��5W   )   $
��Xoá��5X   )   ��5Q   +   �� 	 �� $
 ItemsControlL�$" DataContext.DeleteAccountCMD���6�   �� ��5V   (   Z� 5X   )   5Z   #   5\      �� 5]       5^      �� 5_   "   .R�5`   &   �� ���	#FF4A57D8
�������#��[ 5d      $ 10��5e      $
��auto��5g   )   $��
Reset Pass��5h   )   ��5a   +   �� 	 �� $
 ItemsControlL�$ DataContext.ResetPassCMD���6�   �� ��5f   (   Z� 5h   )   5j   #   5l      5m      5o      5r      5s      5t      