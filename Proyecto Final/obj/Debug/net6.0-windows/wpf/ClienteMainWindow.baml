   M S B A M L   `   `   `  ����I  EProyecto Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Proyecto_Final.MVVM.ViewModelProyecto_Final.MVVM.ViewModel  5   	   C&clr-namespace:Proyecto_Final.MVVM.ViewProyecto_Final.MVVM.View  5   	   /clr-namespace:Proyecto_FinalProyecto_Final  5   	   &     Proyecto_Final.ClienteMainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A	viewModel+clr-namespace:Proyecto_Final.MVVM.ViewModel     5   	   7view&clr-namespace:Proyecto_Final.MVVM.View     5   	   .localclr-namespace:Proyecto_Final     5   	   -   5          � Title$  
MainWindow��5
   	   $	��863��5   	   $	��740��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      8  2Proyecto_Final.MVVM.ViewModel.ClienteMainViewModel  5   
   .��5      ��  �� CornerRadius$ 20��5   	   ��5   
   �� 5      .��5      �  � Color$ #1a5f7a��6    � Offset$	 0.0Q�6/   � 5      $ #086e7d��6   $ 1Q�6/   5      ._�5!   
   � $	��740��6   $��Center=�6   $
��Left=�67   $	��774��6R   	 � ColumnDefinitions	 5"      �� 5#      $	��200 �6#   �� 5$      
 � RowDefinitions
 5'      �� 5(      $��75 �6    �� 5)      .+�5,      �� -   5        $��CloseButton��5-         CloseButtonStyle#���   5,      $��X��5-   $   $��30��5.      $��30��5/      $��Center=�50      $��Center=�51       J� Opacity$	 0.5Q�52      $��1040,10,0,35q�54      $��1��55      
������ 
�������
�������$
��Left=�58   %   59      �� 5;      $��Soporte��5<      $��Center=�5=      $
��Left=�5>      
�������$��22(�5@      $��20,0,0,0q�5A      �� 5C      $��1��6   .+�5D      	�  d� 	IsChecked$
 TrueY�5E      $��Nueva avería��5F      $��50��5G      
�������$��14(�5I        MenuButtonStyle#��[ 5J      ��5K      �� *NuevaAveriaViewCommand+5L      	� 5N      -   5        $��1��5O      $��Cerrar Sesión��5P      $��50��5Q      
�������$��14(�5S      #��[ 5T      $ FalseY�5U      $��
0,568,0,27q�5W      �� 5Y      $��1��5Z      $��10,10,-66,10q�5[      $��1��5\   1   ��6   �� *CurrentView+61   5]      5^      5_      