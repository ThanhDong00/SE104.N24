   M S B A M L   `   `   `  ����F  BPhongMachTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PhongMachTu.PagesPhongMachTu.Pages  5      2    ,PhongMachTu.Controllers.reportPageController   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:PhongMachTu.Pages  5        N� Title$  
reportPage��5
      .��5      � 
�������.+�5   
   �� $��55 0 0 0q�5      $"��Report issues for Developers��5      $
��Sora)�5      $��34(�5      $��DemiBold"�5      ���#2672E75      �� 5   
    �� Orientation$ Vertical=�6   $��55 50 150 100q�5      .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Title��6   $��18(�5      �� 5      $��*��6   
���  ��$��18(�5      $��-2,0,0,0q�5      5      �� 5      -   5         ��Name$ txtTitle��5       !  MaterialDesignOutlinedTextBox#��[  5       $�� ��5!      $��20(�5"      $	��600��5#      $
��auto��5$      $
��0 10q�5%      $
��Left=�5&      
�������
���   �
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Summary the problem��5*         
IsFloating .     
Foreground
 �   �   
Background
 ����  �� 
CaretBrush
 �   �5.      �� 50      $ 
Horizontal=�6   $��	0 20 0 10q�51      .+�52      �� $��Description��6   $��18(�53      �� 54      $��*��6   
���  ��$��18(�56      $��-2,0,0,0q�57      58      �� 59      -   5        $ txtDescription��5:      #��[  5;      $�� ��5<      
�������
���   �
���   �$��20(�5@      $ Give more detail��5A       .  
 �   �
 ���� $	��300��5E      $	��Top=�5F       �� AcceptsReturn . 
 �   �5H      �� 5I      -   5        	 ��Name$	 btnSendIssue��5J      ���#3497F9$��0q�5L      +  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 5��5M      $
��Left=�5N      $��0 30 0 0q�5O      $��Medium"�5P      $��18(�5Q      $��45��5R       �� IsCancel .  $	��160��5T      .��5V      �� $ 
Horizontal=�6   $��10 0 0 0q�5W      $��Center=�5X      .+�5Z      �� $��Submit��6    $��Center=�5[       '  !MaterialDesignThemes.Wpf.PackIcon  5\      $��	15 15 0 0q�5]         Kind$
 Send=�5^      $��20��5_      $��20��5`      $��Center=�5a      z�5b      �� 5c       �� Angle$	 -50Q�6.   5e      5f      5g      5h      5i      5j      