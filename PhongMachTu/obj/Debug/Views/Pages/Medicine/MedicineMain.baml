   M S B A M L   `   `   `  ����F  BPhongMachTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PhongMachTu.Pages.MedicinePhongMachTu.Pages.Medicine  5      C    =PhongMachTu.Controllers.Pages.Medicine.MedicineMainController   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:PhongMachTu.Pages.Medicine     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  MedicineMain��5
      .��5      � ���#F1F8FF � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $
��auto �6   �� 5      �� 5      $	��100 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��859* �6#   �� 5      $��58 �6#   �� 5      $
��294* �6#   .+�5      �� $��Center=�5      $��50,0,0,0q�5      $��Medicine��5      $
��Sora)�5       $��35(�5!      $��DemiBold"�5"      ���#2672E75#      �� 5%      -   5         ��Name$ imgCurrentUser��5%   H   $��1��6   $ ��/Resources/EmployeeNam.png��6$   $��Center=�5&      �� 5(      $��2��6   $��Center=�5)      $��10 0 0 0q�5*      .+�5+      �� -   5         ��Name$ txtCurrentUser��5,      $��Nguyen Thi Cam Tu��5-      $
��Sora)�5.      $��23(�5/      $��DemiBold"�50      ���#56577252      �� 53      -   5        $ txtCurrentUserRole��54      $��Admin��55      $
��Sora)�56      $��14(�57      $��DemiBold"�58      ���#9697955:      5;      5=      � 5@   
   $��1��6    5A      �� 5B      �� 5C      �� 5D      .+�5G      �� -   5         ��Name$ 
txt_Filter��5H      $��0��5G       !  MaterialDesignOutlinedTextBox#��[  5J      $	��Top=�5K      $��50��5L      $��50,0,0,0q�5M       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5O      " �� VerticalScrollBarVisibility$
 Auto=�5P      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Search��5Q      �� 5T      $��1��6   $��50��5U      $��50��6    $
��Left=�5V      $��20,0,0,0q�5W      ���#2672E7.��5Y      � .+�5Z      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Magnify=�6.   $��25��5[   .   $��25��5\   .   $��Center=�5]   .   $��Center=�5^   .   $��Expanded&�5_   .   5`      5a      �� 5c      -   5         ��Name$ btnAddMedicine��5c      $��2��5e      $	��150��5f      $��50��5g      $
��50 0q�5h      ���#2672E7$��DemiBold"�5j      $
��Left=�5k      $��+ Add Medicine��5l      5m      �� 5o   
   -   5         ��Name$ 
lvMedicine��5o       $��2��6   $��Center=�5p      $��
50 50 50 0q�5q       �� View 5t      �� 5u      .P�5v      �� $	��_ID��6%    �� Width$ 0��62    �� DisplayMemberBinding 5w   %   �� *ID+�� 5x      $��ID��6%   $	 100��61    5y   %   �� *	MaThuoc+�� 5z      $��Tên thuốc��6%   $	 300��68    5{   %   �� *
TenThuoc+�� 5|      $��
Đơn vị��6%   $	 200��65    5}   %   �� *	LoaiThuoc+�� 5~      $��Số lượng��6%   $
 auto��67    5   %   �� *TonKho+�� 5�      $��
Đơn giá��6%   $	 300��66    5�   %   �� *
GiaThuoc+5�      5�      �� 5�   
   -   5        $ btnXoa��5�      {�.  $��3��5�      $��2��5�      $	��150��5�      $��50��5�      $��200 0q�5�      ���#2672E7$��DemiBold"�5�      $��Right=�5�      $��Xóa thuốc��5�      5�      5�      