   M S B A M L   `   `   `  ����G  CProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProjectFinal.View.StatisticProjectFinal.View.Statistic  5      ?$clr-namespace:ProjectFinal.ConverterProjectFinal.Converter  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      1    +ProjectFinal.View.Statistic.StatisticMainUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProjectFinal.View.Statistic     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:ProjectFinal.Converter  5      3System&clr-namespace:System;assembly=mscorlib  5	         MaterialDesignBody#���   5
      $��Regular"�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   $��	0 20 0 20q�62   .+�5      ��   	STATISTIC#���  6   $
��Left=�6?   $��Center=�6Z   $��22(�5      $��	20 0 20 0q�5      ���	#FF4A57D8$
��Bold"�5      5      5      5         5!   
   $��1��6   .��5"      �  5#      �� 5$      6&   �� 5%      6&   �� 5&      6&   .+�5(      �� $��0��6   $��Center=�6*   $��Center=�6E   .+�5)      �  � ColumnDefinitions 5*      �� 5+      $
��auto �6/   6>   �� 5,      $
��auto �6/   6>   �� 5-      $
��auto �6/   6>   .+�5/      �� $��0��6$   $��30 0 0 0q�64   $%��Báo cáo doanh thu theo ngày:��6F   $��Center=�6j   $��16(�6�   $��SemiBold"�6�   6�   (  "System.Windows.Controls.DatePicker  50      $��1��6%   $	��200��65   $��15q�6A   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Báo Cáo Ngày��6M    $  MaterialDesignOutlinedDatePicker#��[ 51   	      SelectedDate 52   %   ��  �� Path$ DateCur� �� Mode$ TwoWay=�55      �� 56      $��2��57      ���	#FF4A57D8
�������$	��100��5<      $
��Left=�5=      $��Center=�64    $  MaterialDesignRaisedAccentButton#��[ 5>      $	��Xem��5?      ��58      �� *ReportDayCMD+��5;      Z� 5?      5@      5A      �� 5B      $��1��6   $��Center=�6*   $��Center=�6E   .+�5C      �  5D      �� 5E      $
��auto �6/   6>   �� 5F      $
��auto �6/   6>   �� 5G      $
��auto �6/   6>   .+�5I      �� $��0��6$   $��30 0 0 0q�64   $&�� Báo cáo doanh thu theo tháng:��6F   $��Center=�6k   $��16(�6�   $��SemiBold"�6�   6�     5J      $��1��6%   $
��Left=�65   $	��200��6P   $��15q�6\   $ Báo Cáo Tháng��6h   #��[ 5K   	    5L   %   �� *DateCurrent+$ TwoWay=�5N      �� 5O      $��2��5P      ���	#FF4A57D8
�������$	��100��5U      $
��Left=�5V      $��Center=�64   #��[ 5W      $	��Xem��5X      ��5Q      �� *ReportMonthCMD+��5T      Z� 5X      5Y      5Z      �� 5[      $��2��6   $��Center=�6*   $��Center=�6E   .+�5\      �  5]      �� 5^      $
��auto �6/   6>   �� 5_      $
��auto �6/   6>   �� 5`      $
��auto �6/   6>   .+�5b      �� $��0��6$   $��30 0 0 0q�64   $$��Báo cáo doanh thu theo năm:��6F   $��Center=�6i   $��16(�6�   $��SemiBold"�6�   6�     5c      $��1��6%   $	��200��65   $��15q�6A   $ Báo Cáo Năm��6M   #��[ 5d   	    5e   %   �� *DateCurrent+$ TwoWay=�5g      �� 5h      $��2��5i      ���	#FF4A57D8
�������$	��100��5n      $
��Left=�5o      $��Center=�64   #��[ 5p      $	��Xem��5q      ��5j      �� *ReportYearCMD+��5m      Z� 5q      5r      5s      5t      5u      5v      5w      