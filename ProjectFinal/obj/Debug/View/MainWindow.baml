   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ProjectFinalProjectFinal  5   	   "    ProjectFinal.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ProjectFinal     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   $	��750��5	      $
��1400��6'     � WindowStartupLocation$  CenterScreen=�64    � AllowsTransparency .    MainViewModel � DataContext# [  5
   	   $��Regular"�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStyle$
 None=�6(    � 	Resources 5        MenuOpen �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value  	MenuClose  ContentOpen p� KeyTime p� Value  ContentClose  	ImageOpen  
ImageClose��%�  &	       &	 �     &	 �    &	 V    &	 "    &	 �    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��6a   .\�5        $
 0��6'   $ 60Q�63     5      $
 0:0:0.2��6'   $	 220Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��6a   .\�5        $
 0��6'   $	 220Q�63     5      $
 0:0:0.2��6'   $ 60Q�69   5      5      �� 5   
   .��5      r� $ Margin�6/   $	 GridContent��6R   .	�5       �� $ 0��6*   $ 65, 100, 0, 0q�66   �� 5!      $ 0:0:0.2��6*   $ 225, 100 ,0 ,0q�6<   5"      5#      �� 5$   
   .��5%      r� $ Margin�6/   $	 GridContent��6R   .	�5&      �� $ 0��6*   $ 225, 100 ,0 ,0q�66   �� 5'      $ 0:0:0.2��6*   $ 65, 100, 0, 0q�6<   5(      5)      �� 5*   
   .��5+      U� $ Width�6,   $
	 logo��6N   .\�5,        $
 0��6'   $ 60Q�63     5-      $
 0:0:0.2��6'   $	 220Q�69   5.      5/      �� 50   
   .��51      U� $ Width�6,   $
	 logo��6N   .\�52        $
 0��6'   $	 220Q�63     53      $
 0:0:0.2��6'   $ 60Q�69   54      55      57       � Triggers 59      :� 5:   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ btnOpenMenu��66   .[�5;      �� #��[ 6   5<      :� 5=   
   $ ButtonBase.Click��6   $ btnCloseMenu��66   .[�5>      �� #��[ 6   5?      :� 5@   
   $ ButtonBase.Click��6   $ btnOpenMenu��66   .[�5A      �� #��[ 6   5B      :� 5C   
   $ ButtonBase.Click��6   $ btnCloseMenu��66   .[�5D      �� #��[ 6   5E      :� 5F   
   $ ButtonBase.Click��6   $ btnOpenMenu��66   .[�5G      �� #��[ 6   5H      :� 5I   
   $ ButtonBase.Click��6   $ btnCloseMenu��66   .[�5J      �� #��[ 6   5K      .  (System.Windows.Interactivity.Interaction   Triggers 5N      /  )System.Windows.Interactivity.EventTrigger  5O   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5P      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+5Q      .��5S      )  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
MainDialog��6       CloseOnClickAway . .��5T   
   � .+�5^      � -   5         �Name$ GridBarTitle��5^      
�������$	��100��6_   $	��Top=�6l   .+�5_      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5a      ��  0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5b       � ToolTip$ Thông Báo��5c      $��50��5d      $��50��5e      $��0 0 10 0q�6    
�������
���������6E   Z� .��5f      %  MaterialDesignThemes.Wpf.Badged     BadgeBackground
 �  ��   Badge 60   �� *
NewOrder+.��5g      '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$
 Bell=�66   $��25��5h      $��25��5i      5l      5m      �� 5n      #��[ 5o      $ 
Tin nhắn��5p      $��50��5q      $��50��5r      $��0 0 10 0q�6    
�������
���������6E   Z� .��5s        $ 3��60   
 �  ��.��5t      	  $ Email=�66   $��25��5u      $��25��5v      5x      5y      �� 5z      $��Stretch=�6    $��1��6<   $��10q�6F   
�������6R   �� 5{      $	��100��6    $��Center=�6,   $��0 0 10 0q�6G   ��6Y   �� *UserCurrent.name+6}   �� 5|      #��[ 5}      $2 ,MaterialDesignFloatingActionMiniAccentButton��5~      $��50��5      $��50��5�      $��0 0 10 0q�6    ��63   Z� ��6J   Z� ��6`   Z� .��5�      �� $
��Fill=�6J   ��6    �� *UserCurrent.image_user+6[   5�      '
  !MaterialDesignThemes.Wpf.PopupBox
  5�      $��Right=�5�       
  PlacementMode$ BottomAndAlignRightEdges=�5�      $��20 0 0 0q�6<    
  	StaysOpen .   
  PopupContent. 5�      �� $	��150��6%   .+�5�      �� $��Change Password��6%   ��6?   �� *ChangePassCMD+�� 5�      �� 5�      $��Language��6%   ��68   �� *
SettingCMD+�� 5�      $
��Help��6%   �� 5�      �� 5�      -   5          ��Name$  	btnLogout��5�   %   $
��Exit��68   5�      5�      5�      5�      5�      � 5�      -   5        $ GridMenu��5�      ���	#FF4E73DF$
��Left=�6<   $��60��6W   ! J� Effect! 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      "   
BlurRadius$" 2Q�6'   #   ShadowDepth$# 1Q�66   $   Color$$ 	#FFAEAEAE��6F   .+�5�      �� .+�5�      �� .+�5�      �� -   5        % ��Name$
% logo��5�       $��/Assets/logo1.png��6.   $
��Fill=�6I   $��60��6X   $	��100��6c   6r   5�      � 5�      ���	#FF4E73DF$��Right=�62   .+�5�      �� -   5        $  btnOpenMenu��5�   !   $��Center=�6d   $��60��6   ��67   Z� ��6M   Z� .��5�      	  $
 Menu=�66   $��30��6B   $��30��6M   5�      5�      �� 5�      -   5        $  btnCloseMenu��5�   !   $y�	Collapsed=�67   $��Center=�6{   $��60��6�   ��6N   Z� ��6d   Z� .��5�      	  $ 	ArrowLeft=�66   $��30��6G   $��30��6R   5�      5�      5�      �� 5�      $��1��6   $��0 10 0 0q�6+   $	��240��5�      $
��auto��6&   ��5�   =   �� *ListItemNavigate+& �� SelectedItem& 6f   �� *SelectedView+��5�      �� 5�      ' �� 
TargetType"' ��6$    	 MaterialDesignListBoxItem( �� BasedOn#( [	 6=   .�5   "   �� ) �� Property) � ��* �� Value$	* 0 9q�6<   �� 5  "   ) � ��$* Stretch=�6O   �� 5  "   ) � ��$* Stretch=�6M   + �� Triggers+ 5  "   P� 5  &   , P� Property, �@J�IsMouseOver- P� Value- . . �5  *   �� ) � ��* �	#FF4565B76G   5  '   P� 5  &   , �@��
IsSelected- . . �5  *   �� ) � ��* �	#FF4565B76G   5	  '   5     ��5     �� 5     .R�5  "   � $��30��6'   $
��auto��63   ��5  &   �� 5  *   "' �60   .�5  .   �� ) �@J�Opacity$	* 0.6Q�6H   + 5  .   �� 5  2   . �� Binding. 6>   �� *
IsSelected+/ �� Value/ True6]   0 N� EnterActions0 5  6   �� 5  :   .��5  >   �� $ Opacity�6I   .��5  B   W� 1 g� Duration$1 0:0:0.3D�6R   	2 W� To$2 1X�6e   5  ?   5  ;   3 N� ExitActions3 5  6   �� 5  :   .��5  >   �� $ Opacity�6I   .��5  B   W� $1 0:0:0.3D�6R   $	2 0.6X�6e   5   ?   5!  ;   5#  3   5%  +   4 � ColumnDefinitions4 5'  &   �� 5(  *   $��5 �6;   �� 5)  *   $	��.8* �6;   �� 5*  *   $��* �6;   .+�5,  &   �� $��0��6-   $
��0 -5q�6=   
�������5 �� CornerRadius$5 0 7 7 0��6^   y�6u   �� *
IsSelected+	  5-  &   $��1��6>   $��10 0 0 0q�6N   $
��Auto��6v   $
��Auto��6�   
�������$��Center=�6�   $
��Left=�6�    6`   �� *Icon+6�   �� 5.  &   $��2��60   $��0 0 0 0q�6@   $��Center=�6n   $
��Left=�6�   
�������$��14(�6�   $��SemiBold"�6�   ��6Q   �� *DisplayName+6�   5/  #   50     52     53     54     � 56     -   5        $ GridContent��56     $��
65 100 0 0q�6(   .+�57     #  MaterialDesignThemes.Wpf.Card  .��58     �� ��6%   �� *ViewCurrent+6G   59     5:     5<     5=     5?     