   M S B A M L   `   `   `  ����L  HPurchaseSellStock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PurchaseSellStock.TemplatePurchaseSellStock.Template  5   	   K*clr-namespace:PurchaseSellStock.PropertiesPurchaseSellStock.Properties  5   	   #    PurchaseSellStock.DialogLogin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   >	WTemplate(clr-namespace:PurchaseSellStock.Template     5   	   A
properties*clr-namespace:PurchaseSellStock.Properties     5   	   +   %PurchaseSellStock.Template.DialogBase    Loaded$  DialogBase_Loaded��5   �   $	��252��6T   $	��368��6a    � WindowStartupLocation$ CenterScreen=�6m    � Icon$2 ,/PurchaseSellStock;component/Images/Logo.ico��6�    � Title 6	   ��  �� Path$ Title�+   %PurchaseSellStock.Properties.Settings   Default �� Source# Z .��5      �  � RowDefinitions 5   
   �� 5	      $��30 �6   �� 5
      $��23 �6   �� 5      $��10 �6   �� 5      $��23 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��23 �6    � ColumnDefinitions 5   
   �� 5      $��90 �6   �� 5      $��* �6   �� 5      $��90 �6   .+�5   
   �� $��1��6   $��1��6%   $
��Left=�62   	 �� Orientation$	 
Horizontal=�6M   .+�5      �� $��Images/User.ico��6   $��20��6-   $��23��68   $
��Fill=�6D   $��3 0 0 0q�6S   �� 5      -   5        $��comboxUserName��5      $	��Top=�6-   $	��140��6E   $��23��6Q   5      �� 5   
   $��1��6   $��3��6%   $
��Left=�62   $	 
Horizontal=�6M   .+�5      �� $��Images/Password.ico��6   $��23��61   $��23��6<   $
��Fill=�6H   G� 5      -   5        $��textPassword��5      $	��140��6.      passwordBoxLineStyle#��[  6:   6h   5      �� 5   
   -   5        $��
labMessage��5      
���  ��$��0��63   $��4��6C   $��3��6P   $��28��6d   $��Center=�6p   $��Center=�6�   �� 5    
   -   5        $��btnLogin��5       $��登 录��6   $��40��6F   $��Center=�6R   $	��Top=�6o   $	��100��6�   $��1��6�   $��5��6�   
��� � �6�   �� 5!   
   $��6��6d   $��3��6q   $
��Left=�6�   $��Center=�6�   
�������
������ 
 �� 
IsReadOnly
 . $��0q�6�   ��.  ��6   �� $ MachineSerial�# Z 6  �� 5"   
   $��6��6   $��2��6!   $��Right=�61   $��Center=�6M    �� Padding$ 0 0 10 0q�6h   �� 5#      -   5        ��5#      �� $ HelpPage�# Z .�6�   	帮助?5%      5&      5(      5)      