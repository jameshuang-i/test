   M S B A M L   `   `   `  ����L  HPurchaseSellStock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PurchaseSellStock.PropertiesPurchaseSellStock.Properties  5   	   ?$clr-namespace:PurchaseSellStock.DataPurchaseSellStock.Data  5   	   G(clr-namespace:PurchaseSellStock.TemplatePurchaseSellStock.Template  5   	   "    PurchaseSellStock.WindowMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   A
properties*clr-namespace:PurchaseSellStock.Properties     5   	   5Data$clr-namespace:PurchaseSellStock.Data     5   	   >	WTemplate(clr-namespace:PurchaseSellStock.Template     5   	   
�������$	��600��5   m   $	��800��6z     � Icon$2  ,/PurchaseSellStock;component/Images/Logo.ico��6�    � WindowStartupLocation$ CenterScreen=�6�    � Title 6	   ��  �� Path$ Title�+   %PurchaseSellStock.Properties.Settings   Default �� Source# Z .��5      �  � RowDefinitions 5	   
   �� 5
      $��50 �6   �� 5      $��* �6   .+�5   
   �� ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FF21C8FF��6#   
 � Offset$
 0Q�65   � 5      $	 	#FF0064A3��6#   $
 1Q�65   � 5      $	 	#FF0093CF��6#   $
 0.554Q�65   � 5      $	 	#FF00A7E2��6#   $
 0.295Q�65   � 5      $	 	#FF0EB1E7��6#   $
 0.147Q�65   5      5      � 5   
   $��0��6    � ColumnDefinitions 5      �� 5      $��50 �6#   �� 5      $��4 �6#   �� 5      $��* �6#   �� 5      $	��120 �6#   .+�5      �� $��Center=�6   $��0��66   .+�5       �� $2��,/PurchaseSellStock;component/Images/User.ico��6   $��30��6N   $��30��6Y   �� 5!      -   5        $��txtUserName��5!      
�������$��10(�6�   ��6+   �� $ LastLoginName�# Z 6�   5"      �� 5#      $��1��6   	 �� X1$ 0��6#   	 �� Y1$ 0��6*   	 �� X2$ 0��61   	 �� Y2$ 50��68   
������� J� Opacity$	 0.8Q�6O   �� 5$      $��2��6   .+�5%      �� 
�������$��10(�6{   ��6   �� $ Version�# Z 6�   �� 5&      $��有效期：免费版��6   
�������$��10(�6=   6M   5'      �� 5(      $��5��6h   $��Right=�6|   $	��Top=�6�   
�������
������  �� 
IsReadOnly . $��0q�6�   ��.  ��6   �� $ MachineSerial�# Z 6  �� 5)      -   5        $��
btnSuggest��5)   m   $��意见建议��6   $��3��6$   $��23��64   $
��Left=�6@   $��0,27,0,0q�6[   $	��Top=�6   $��75��6�   
��� � �6�   �� 5*      -   5        $��btnHelp��5*   l   $��帮助��6   $��3��6"   $��23��62   $
��Left=�6>   $��	81,27,0,0q�6Y   $	��Top=�6{   $��34��6�   
�������6�   5+      � 5,   
   $��1��6    5-      �� 5.      $	��150 �6#   �� 5/      $��* �6#   .+�51      �� $��1q�6   
�������._�52      �� .+�53      �� -   5        $��btnNavigation��53      $��导航菜单>>��62   
���  ��$��30��6T   $
��Bold"�6`   $��3 5 3 3q�6r   6�   �� 54      $��	入库单��6   $��30��6+   $��3 10 3 3q�67   
�������$��0��6_   .   (PurchaseSellStock.Template.MyImageButton   ImageSource$ /Images/User.ico��6l   �� 55      $��	销售单��6   $��30��6+   $��3q�67   $��0��6B   
�������$2 ,/PurchaseSellStock;component/Images/User.ico��6e   56      57       � 58      -   5        $��frameNavigation��58      $��1��6+     � Source$ PageNavigation.xaml?�6;   6Z   59      � 5:   
   -   5        $��PMenu��5:      $��1��6   $
��Fade=�6-   $��Right=�6y    � AllowsTransparency .  � PlacementTarget 6C   ��  �� ElementName$ btnNavigation��.��5;      �� $��1q�6   
�������
������� �� CornerRadius$ 5��6O   ._�5<       � $ PageNavigation.xaml?�6   5=      5>      5?      5A      