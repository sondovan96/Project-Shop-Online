   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProjectFinal.View.AccountProjectFinal.View.Account  5      C&clr-namespace:ProjectFinal.ValidationsProjectFinal.Validations  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5
      0    *ProjectFinal.View.Account.ChangePasswordUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ProjectFinal.View.Account     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      2valid&clr-namespace:ProjectFinal.Validations  5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      4	converter$clr-namespace:ProjectFinal.Converter  5
      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignFont#���   5       � 	Resources 5      +   %ProjectFinal.Converter.ImageConverter  ImageConverter��%   &	         5   
   6#   5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5!   
   �� $��0��6   $��8��6!   $	��0.7q�62   
�������$��5q�6]    �� CornerRadius$ 7��6h   $	��320��6y   $	��320��6�   ._�5"      � .+�5#      �� $��Uniform=�6l   $��2q�6~   ��6   �� *UserCurrent.image_user+ �� 	Converter# [ 6~   �� 5$      $��Right=�6   $��Bottom=�65   $��5q�6P    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6[   ���#7D8085���#7D8085
������� J� Opacity$	 0.7Q�5%   �   ��6D   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Camera=�	   Size$	 19X���5&      �� *OpenDialogChooseImageCMD+5'      5(      �� 5)   
   $��0��6   $��1��6!     CHANGE_PASSWORD#���  61   $��	17 17 7 7q�6Z   $��16(�6m   $��SemiBold"�6{   G� 5*   
   -   5        
 G�Name$
 tbx_oldpass��5*   3   $��1��6   $��1��6#    # MaterialDesignFilledPasswordBox#��[ 6J   $	��320��6�   $��15q�6�   $��14(�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mật khẩu cũ��6�   .  (System.Windows.Interactivity.Interaction   Triggers 5+      /  )System.Windows.Interactivity.EventTrigger  5,         	EventName$ PasswordChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5-      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *PasswordOldCommand+   CommandParameter 5.   8   ��  �� ElementName$ tbx_oldpass��5/      51      G� 52   
   -   5        $
 tbx_newpass��52   3   $��2��6   $��1��6#   #��[ 6H   $	��320��6�   $��15q�6�   $��14(�6�   $ Mật khẩu mới��6�    53        54      $ PasswordChanged��6!   . 55         6,   �� *PasswordNewCommand+ 56   8   �� $ tbx_newpass��57      59      G� 5:   
   -   5        $
 
tbx_repass��5:   3   $��3��6   $��1��6#   #��[ 6G   $	��320��6�   $��15q�6�   $��14(�6�   $% Nhập lại mật khẩu mới��6�    5;        5<      $ PasswordChanged��6!   . 5=         6,   �� *PasswordReCommand+ 5>   8   �� $ 
tbx_repass��5?      5A      �� 5C   
   $��4��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��5q�6g   .+�5D      �� -   5         ��Name$ btn_save��5D        SAVE#���  6'     MaterialDesignFlatButton#��[ 6H   ��6z   �� $ 
btn_cancel�� �� Path$ ActualWidth���6�   �� *	SaveCMD+�� 5E      -   5        $ 
btn_cancel��5E      $	��5 0q�6)    
 CANCEL#���  66   #��[ 6Y   ��6�   �� *	CancelCMD+5F      5G      5H      