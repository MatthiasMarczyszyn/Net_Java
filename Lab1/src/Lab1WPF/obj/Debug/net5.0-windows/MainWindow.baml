   M S B A M L   `   `   `  ����B  >Lab1WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lab1WPFLab1WPF  5   	       Lab1WPF.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Lab1WPF     5   	     � Title$  KanpsackProblem��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6&   $��24(�63   $��Knapsack Problem��6A   �� 5    
   $��1��6   $��2��6&   $��16(�63   $��Items Ammount��6A   �� 5!   
   $��1��6   $��3��6&   $��16(�63   $��Capacity of Bag��6A   �� 5"   
   -   5         ��Name$ itemsAmount��5"      $��2��6'   $��2��67   $	��100��6D   �� 5#   
   -   5        $ bagCapacity��5#      $��2��6'   $��3��67   $	��100��6D   �� 5$   
   -   5         ��Name$ submitButton��5$      $��Solve��6'   $��1��67   $��4��5%      $��2��6   $��10q�6&   63   5&      5'      