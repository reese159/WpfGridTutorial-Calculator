   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    WpfGridTutorial    WpfGridTutorial.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6Sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � SizeToContent$ WidthAndHeight=�5	   	    � Topmost$ False��6(    � WindowState$ Normal=�68   
���   � � 	Resources 5         strHelloAgain �� 
TargetType �� Property �� Value��%�   &	        '�� #     ��5   
   Hello Again��68   �� 5   
   " ��6   .�5      ��  � ��$ 1q�6'   �� 5       � ��$ 40(�6)   �� 5       � ��$ Center=�69   �� 5       � ��$ Consolas)�6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   	 � ColumnDefinitions	 5   
   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   .+�5%   
   �� -   5        
 ��Name$
 
DisplayBox��5%      $��0��6&   $��4��63   $	��2,5q�6G   $��0��5&       �� TextWrapping$
 Wrap=�6    �� SelectionOpacity$ -7Q�6/   
���   �
�������5'   $   �� 5*   
   -   5         ��Name$ 
NumButton7��5*      $��7��6%   $��0��61   $
��Left=�6A   $��1��6\   $	��Top=�5+      $	��130��6)   $��50��65   
�������
���   �5,   '   �� 5-   
   -   5        $ 
NumButton8��5-      $��8��6%   $��1��61   $
��Left=�6A   $��1��6\   $	��Top=�5.      $	��130��6)   $��50��65   
�������
���   �5/   '   �� 50   
   -   5        $ 
NumButton9��50      $��9��6%   $��2��61   $
��Left=�6A   $��1��6\   $	��Top=�51      $	��130��6)   $��50��65   
�������
���   �52   '   �� 53   
   -   5        $ OperButtonDiv��53      $��÷��6(   $��3��64   $
��Left=�6D   $��1��6_   $	��Top=�54      $	��130��6)   $��50��65   
�������
���   �55   '   �� 58   
   -   5        $ 
NumButton4��58      $��4��6%   $��0��61   $
��Left=�6A   $��2��6\   $	��Top=�59      $	��130��6)   $��50��65   
�������
���   �5:   '   �� 5;   
   -   5        $ 
NumButton5��5;      $��5��6%   $��1��61   $
��Left=�6A   $��2��6\   $	��Top=�5<      $	��130��6)   $��50��65   
�������
���   �5=   '   �� 5>   
   -	   5        $ 
NumButton6��5>      $��6��6%   $��2��61   $
��Left=�6A   $��2��6\   $	��Top=�5?      $	��130��6)   $��50��65   
�������
���   �5@   '   �� 5A   
   -
   5        $ OperButtonMult��5A      $��*��6)   $��3��65   $
��Left=�6E   $��2��6`   $	��Top=�5B      $	��130��6)   $��50��65   
�������
���   �5C   '   �� 5F   
   -   5        $ 
NumButton1��5F      $��1��6%   $��0��61   $
��Left=�6A   $��3��6\   $	��Top=�5G      $	��130��6)   $��50��65   
�������
���   �5H   '   �� 5I   
   -   5        $ 
NumButton2��5I      $��2��6%   $��1��61   $
��Left=�6A   $��3��6\   $	��Top=�5J      $	��130��6)   $��50��65   
�������
���   �5K   '   �� 5L   
   -   5        $ 
NumButton3��5L      $��3��6%   $��2��61   $
��Left=�6A   $��3��6\   $	��Top=�5M      $	��130��6)   $��50��65   
�������
���   �5N   '   �� 5O   
   -   5        $ OperButtonMinus��5O      $��-��6*   $��3��66   $
��Left=�6F   $��3��6a   $	��Top=�5P      $	��130��6)   $��50��65   
�������
���   �5Q   '   �� 5T   
   -   5        $ OperButtonSign��5T      $	��+/-��6)   $��0��67   $
��Left=�6G   $��4��6b   $	��Top=�5U      $	��130��6)   $��50��65   
�������
���   �5V   '   �� 5W   
   -   5        $ 
NumButton0��5W      $��0��6%   $��1��61   $
��Left=�6A   $��4��6\   $	��Top=�5X      $	��130��6)   $��50��65   
�������
���   �5Y   '   �� 5Z   
   -   5        $ OperButtonClear��5Z      $��Clear��6*   $��2��6:   $
��Left=�6J   $��4��6e   $	��Top=�5[      $	��130��6)   $��50��65   
�������
���   �5\   '   �� 5]   
   -   5        $ OperButtonPlus��5]      $��+��6)   $��3��65   $
��Left=�6E   $��4��6`   $	��Top=�5^      $	��130��6)   $��50��65   
�������
���   �5_   '   �� 5b   
   -   5        $ OperButtonEquals��5b      $��=��6+   $��3��67   $
��Left=�6G   $��5��6b   $	��Top=�5c      $	��130��6)   $��50��65   
�������
���   �5d   '   5e      5g      