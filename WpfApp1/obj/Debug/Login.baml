   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Login��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $	��200 �6   6-   �� 5      $	��200 �6   6-   �� 5      $	��200 �6   6-    � RowDefinitions 5   
   �� 5      $	��125 �6   6+   �� 5      $	��125 �6   6+   �� 5      $	��125 �6   6+   �� 5      $	��125 �6   6+   .+�5   
   �� $��	User Name��6    
  Label1#��[  6$   $��
27,10,0,52q�6D   $��1��6X   �� 5   
   $��password��6   #��[  6#   $��27,93,0,104q�6C   $��2��6X   $��1��6i   �� 5   
   -   5         ��Name$ Name_Txt��5      $��1��6$   $��Center=�64   $��0,11,0,0q�6Q   $��1��6c    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��120��6�   $��30��6�   G� 5   
   -   5         G�Name$ Pass_Txt��5      $��1��6(   $��Center=�68   $��0,93,0,0q�6U   $��1��6g   $	��Top=�6u   $	��120��6�   $��30��6�   �� 5   
   $��Login��6   #��[  6    $��1��6@   $��0,6,0,63q�6P   $��2��6b   $	��134��6v    J� RenderTransformOrigin$ 0.884,0.573&�6�   $��Center=�6�   �� 5   
   -   5        $��3��5      $��Login��6!    	 Butt1#��[ 61   $	��126��6P   $��	0,52,0,10q�6\   $��2��6o   6|   �� 5   
   $��20(�6   $
��Bold"�6"   $��2��64   $��2��6D   $��0,52,0,0q�6Q   �� 5      -   5        $��Forget.xaml?�5      .�6^   Forget Password5!      5"      �� 5#   
   $��20(�6   $
��Bold"�6"   $��1��64   $��2��6D   $��0,52,0,0q�6Q   �� 5$      -   5        $��SignUp.xaml?�5$      .�6`   	Sign Up5&      5'      5(      5)      