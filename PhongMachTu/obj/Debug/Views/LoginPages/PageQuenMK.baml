   M S B A M L   `   `   `  ����F  BPhongMachTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PhongMachTu.LoginPagesPhongMachTu.LoginPages  5      =    7PhongMachTu.Controllers.LoginPages.PageQuenMKController   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5ui&http://schemas.lepo.co/wpfui/2022/xaml     5      6local$clr-namespace:PhongMachTu.LoginPages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N�Name$  MainA��5       N� Title$ 
PageQuenMK��5      .��5      � 
�������.+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� -   5         ��Name$ imgLogo��5      $��0��5      $��/Resources/logo.png��5      $��Center=�5      $	��Top=�5      $��0,0,0,0q�5      $	��100��5       $	��100��6!   �� 5"      -   5         ��Name$ 	lbAccount��5$      $��1��5"      $��Account Recovery��5#      $��	0,20,0,30q�5%      $��Center=�5&      $��28(�5'      
���   �$
��Bold"�5)      �� 5*      -   5        $ lbUserNameIN��5+      $��2��5*      $��Enter your UserName:��5,      $
��Left=�5-      $��340,30,0,10q�5.      $��16(�5/      ���#56577250      �� 51      -   5         ��Name$ txtUserName��52      $��2��51      $��Center=�53      $	��350��54      $
��Auto��55      $��	0,20,0,10q�56       !  MaterialDesignOutlinedTextBox#��[  57      �� 59      -   5        $ lbPass��5:      $��3��59      $��Enter new Password:��5;      $
��Left=�5<      $��340,20,0,10q�5=      $��16(�5>      ���#5657725?      G� 5@      -   5         G�Name$ txtNewPassw��5A      $��3��5@      $��Center=�5B      $	��350��5C      $
��Auto��5D      $��	0,10,0,10q�5E       + 'MaterialDesignOutlinedRevealPasswordBox#��[ 5F      {�5G      ��  �� ElementName$# RevealPasswordOutlinedEnabled�� �� Path$ 	IsChecked��� 5I      -   5        $ 	lbConfirm��5J      $��4��5I      $��Confirm new Password:��5K      $
��Left=�5L      $��340,20,0,10q�5M      $��16(�5N      ���#5657725O      G� 5P      -	   5        $ 
txtConfirm��5Q      $��4��5P      $��Center=�5R      $	��350��5S      $
��Auto��5T      $��	0,10,0,10q�5U      #��[ 5V      {�5W      �� $# RevealPasswordOutlinedEnabled��$ 	IsChecked��� 5Y      -
   5        	 ��Name$	 btnNext��5Z      $��5��5[      $
��Next��5]      $��Center=�5^      ���#6788FF
�������$��40��5a      $	��100��6!   $��
150,35,0,0q�5b      $��18(�5c      $	��Top=�6#   $��3��6;   �� 5d      -   5        $	 btnBack��5e      $��5��5g      $
��Back��5h      $��Center=�5i      ���#6788FF
�������$��40��5l      $	��100��6!   $��
0,35,100,0q�5m      $��18(�5n      $	��Top=�6#   $��3��6;   5o      5p      5q      