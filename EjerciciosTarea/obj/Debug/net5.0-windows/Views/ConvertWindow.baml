   M S B A M L   `   `   `  ����J  FEjerciciosTarea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EjerciciosTarea.ViewsEjerciciosTarea.Views  5   	   )    #EjerciciosTarea.Views.ConvertWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:EjerciciosTarea.Views     5   	     � Title$  ConvertWindow��5   	   $	��350��6   $	��413��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      $	��200 �6   6-    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��30 �6   6*   �� 5      $��45 �6   6*   �� 5      $��45 �6   6*   �� 5      $��25 �6   6*   �� 5      $
��Auto �6   6,   .+�5   
   �� $��Moneda que tengo��6   $��1��6+   $��0��68   $��	39,0,39,0q�6H   �� 5   
   $��Moneda que deseo��6   $��1��6+   $��1��68   $��	43,0,43,0q�6H   �� 5   
   -   5         ��Name$ Convert1��5      $��2��6%   $��0��62   $��
10,0,10,20q�6B   .@�5      �� .��6   	Cordoba6$   �� 5      .��6   Dolar6"   �� 5      .��6   Euro6!   5      �� 5   
   -   5        $ Convert2��5      $��2��6%   $��1��62   $��
10,0,10,20q�6B   .@�5      �� .��6   	Cordoba6$   �� 5      .��6   Dolar6"   �� 5       .��6   Euro6!   5!      �� 5"   
   $��Monto��6   $��0��6    $��3��60   $��10,7,142,13q�6=   �� 5#   
   $��Monto��6   $��1��6    $��3��60   $��10,7,142,13q�6=   �� 5$   
   -   5         ��Name$
 txt1��5$      $��0��6    $��4��60   $��	10,0,10,0q�6=   �� 5%   
   -   5        $
 txt2��5%      $��1��6    $��4��60   $��	10,0,10,0q�6=   �� 5&   
   -   5         ��Name$ btnCalc��5&      $��Calcular��6"   $��2��65   $��5��6I   $��39,23,43,-50q�6V   5'      5(      