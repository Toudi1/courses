   M S B A M L   `   `   `  ����a  ]WPF_14C-Propery_Data_and_Event_Trigers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:WPF_14C_Propery_Data_and_Event_Trigers&WPF_14C_Propery_Data_and_Event_Trigers  5   	   7    1WPF_14C_Propery_Data_and_Event_Trigers.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:WPF_14C_Propery_Data_and_Event_Trigers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   � .+�5      �� $��Hello beloved World��6   $��32(�63   $��Center=�6A   $��Center=�6^   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 � � �67    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  � ��
 �  ��6M   �� 5   "    � ��$ 	Underline{�6D   5      5      5      5      � 5   
   .+�5      �� $��Hello, Buddy!��6   $��24(�6-   $��Center=�6;   $��Center=�6X   ��5      �� 5      " ��6    5      :� 5       :� RoutedEvent$ 
MouseEnter��6+   [�5   "   �� 5    &   .��5!   *   �� .��5"   .   W�  g� Duration$ 	0:0:0.300D�6>   	 �� TargetProperty$	 FontSize�6S   	
 W� To$
 72X�6x   5#   +   5$   '   5&      :� 5'      $ 
MouseLeave��6+   [�5(   "   �� 5)   &   .��5*   *   �� .��5+   .   W� $ 	0:0:0.500D�6>   $	 FontSize�6S   $
 24X�6x   5,   +   5-   '   5/      51      53      54      �� 55   
   $��Center=�6   $��Center=�62   .+�56      �� -   5        $��cbHello��56      $��Is someone there?��6&   �� 57      $��Center=�6   $��36(�65   ��58      �� 59      " ��6   .�5:      ��  � ��$ No��61   �� 5;       � ��
 �  ��67    5<      �� 5=       �� Binding 6*   ��  �� ElementName$ cbHello�� �� Path$ 	IsChecked� �� Value True6b   .a�5>   "   ��  � ��$ 	Of Course��69   �� 5?   "    � ��
 � � �6?   5@      5B      5D      5E      5G      5H      