   M S B A M L   `   `   `  ����F  BPhongMachTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PhongMachTu.Pages.StatisticsPhongMachTu.Pages.Statistics  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      E    ?PhongMachTu.Controllers.Pages.Statistics.DoanhThuPageController   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      6local*clr-namespace:PhongMachTu.Pages.Statistics  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5	        N� Title$  DoanhThuPage��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ 
backButton��5      $��50,0,0,0q�5      $
��Left=�5      $��Center=�5         MaterialDesignIconButton#��[  5       � ToolTip$ MaterialDesignIconButton��5      
�������.��5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6*   
���   �6;   5"      �� 5#      $��Biểu đồ Doanh Thu��6   $��DemiBold"�5$      $��Center=�5%      $
��Left=�5&      $��1��5'      $��50,0,0,0q�5(      $��20(�5)      5*      � 5+   
   $��1��6   $��Center=�6    5,      �� 5-      $	��300 �6#   �� 5.      $	��300 �6#   �� 5/      $	��100 �6#   �� 50      $��* �6#   .+�52      ��  �� Orientation$ 
Horizontal=�6   $��0��62   .+�53      �� $��Từ ngày: ��6   $��Center=�6-   $��0,0,10,0q�6H   (  "System.Windows.Controls.DatePicker  54      -   5          Name$ 	dtpTuNgay��54      $	��120��60   55      �� 56      $ 
Horizontal=�6   $��1��62   .+�57      �� $��Đến ngày: ��6   $��Center=�6.   $��0,0,10,0q�6I     58      -   5        $ 
dtpDenNgay��58      $	��120��61   59      �� 5:      -   5        $ 
btnTimKiem��5:      $��2��5;      $��Tìm kiếm��5<      5=      �� 5?      -   5        $ btnPDF��5?      $��3��5@      $��	100,0,0,0q�5A      $��
Xuất PDF��5B      
��� ���
��� E��5E      5G      #  LiveCharts.Wpf.CartesianChart  5H   
   -   5          Name$ chartDoanhThu��5H      $��2��5I      
�������&   LiveCharts.Wpf.Charts.Base.Chart	   LegendLocation$	 Right=�5K      $��0 0 0 0q�5L      $	��500��5M      $
��1000��5N      
   Series
 5O      �� *SeriesCollection+   AxisX 5Q        LiveCharts.Wpf.Axis     Title$ Tháng��6      Labels 6)   �� *Labels+   AxisY 5T        $ 	Doanh thu��6      LabelFormatter 6-   �� *
YFormatter+5V      5W      5X      