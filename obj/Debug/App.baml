   M S B A M L   `   `   `  ����>  :KFC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KFCKFC  5          KFC.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      #localclr-namespace:KFC     5        �� 	Resources  5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border �� 
TargetType-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background 	 Button.Pressed.Border 
 Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground ��Name��%;  &	        &	 �     &	 �     &	 �     &	     &	 6    '�� Y    &	 �    &	 �    &	 �    &		 �    &	
     &	 5    &	 X    '�� {    7   7 
 7  7  �� 5   
   .�5	      ��  � �� 5
      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � �� �	#FF00BADE6,   �� 5       � ��# � ��6+   �� 5       � ��$ 2q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5        �@��IsFlicksEnabled .  67   �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      �� $ border��6!   $	 4��61   #��z��6B   #��z��6l   #��z��6�    . ._�5%      �� $
 PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5&       5'      P� 5(       � {� .  . �5)   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5*      P� 5+       �@J�IsMouseOver . . �5,   "   �� $ border��6@    � �� �	#FF00D5FF6T   5-      P� 5.       �@J�IsKeyboardFocused . . �5/   "   �� $ border��6@    � �� �	#FF00A1C16T   50      52      54       55      ]� 56       57      �� 58      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 59       �@��IsSelectionActive .  6A   ./�5;      ��  �@��SelectionBrush# � /�67   5<      5>      �� 5?   
   $ 	#FF95EEFF��6>   �� 5@   
   $ 	#FF00D5FF��6:   �� 5A   
   $ 	#FF41E0FF��6<   �� 5B   
   $ 	#FF00A1C1��68   �� 5C   
   $ 	#FFF4F4F4��6=   �� 5D   
   $ 	#FFADB2B5��69   �� 5E   
   $ 	#FF838383��6=   �� 5F   
   " ��6   .�5G      ��  �@�FocusVisualStyle8   61   �� 5H       � �� �	#FF55E4FF6+   �� 5I       � �� �	#FF00BADE6,   �� 5J       � ��
 �   �6+   �� 5K       � ��$ 2q�60   �� 5L       � ��$ Center=�6;   �� 5M       � ��$ Center=�69   �� 5N       � ��$ 1q�6(   �� 5O       � �� 5P      �� 5Q      " ��6&   .R�5R      �� $ border��6!   $	 4��61   #��z��6B   #��z��6l   #��z��6�    . ._�5S      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5T       5U      P� 5V       �@��IsDefaulted . . �5W   "   �� $ border��6@   # � ��6T    � ��5X      P� 5Y       �@J�IsMouseOver . . �5Z   "   �� $ border��6?    � �� �	#FF95EEFF6S   �� 5[   "   $ border��6@    � �� �	#FF00D5FF6T   5\      P� 5]       � �� . . �5^   "   �� $ border��6?    � �� �	#FF41E0FF6S   �� 5_   "   $ border��6@    � �� �	#FF00A1C16T   5`      P� 5a       � {� .  . �5b   "   �� $ border��6?   8   � ��6S   �� 5c   "   $ border��6@   8   � ��6T   �� 5d   "   $ contentPresenter��6K   8   � ��6i   5e      5g      5i      5j      5k      5l      