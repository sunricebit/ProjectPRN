   M S B A M L   `   `   `  ����B  >QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizAppQuizApp  5   	       QuizApp.ViewCollection   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QuizApp     5   	     � Title$  View Quiz Collection��5   	   $	��800��6&   $	��600��62    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value��%�  '��       �� 5
   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 10q�6(   �� 5       � ��$ 1q�60   �� 5       � ��
 �   �6,   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   #��z��6   $ 10��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � ��
 �����63   �� 5       � ��
 �   �63   �� 5       � ��$ 2q�68   �� 5       � ��
 �����64   5      5!      5"      .��5#      � 
 � RowDefinitions
 5$   
   �� 5%      $
��Auto �6   �� 5&      $��* �6   �� 5'      $
��Auto �6   .+�5+   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5,      �� $��Search:��6   $��Center=�6&   �� 5-      -   5         ��Name$ 	txtSearch��5-      $	��150��6)   $��5q�65   �� 5.      -   5         ��Name$ 	btnSearch��5.      $��Search��6(   $��53��69   6D   �� 5/      $��Filter by Category:��6   $��Center=�62   $��10,0,0,0q�6M   �� 50      -   5         ��Name$ cmbCategory��50      $	��150��6,   68   �� 51      -   5        $ btnDelCategory��51      $��Delete this Category��6-   $	��120��6L   6X   52      �� 55   
   -   5         ��Name$ lvCollection��55      $��1��6)   $��10q�6^   ��66   �� *QuizCollections+��56      �� 57      " ��6   .�59      ��  � ��$ 25��6/   5:       �� View 5<      �� 5=      .P�5>      �� $��Id��6%    �� Width$ 30��61    �� DisplayMemberBinding 6<   �� *Id+�� 5?      $��Title��6%   $	 410��64    6@   �� *Title+�� 5@      $��Category��6%   $	 200��67    6C   �� *Category.Content+�� 5A      $	 120��6%   $
��View��61    �� CellTemplate 5B      �� 5C      .R�5D   "   �� -   5        $
��View��5D   )   $��90��68   6C   5E      5G      5I      5K      �� 5L   
   -   5        $ 	btnToMain��5L      $��3��6$   $��
BackToMenu��61   $	��100��6F   $��22��6R   $��5q�6^   6i   5M      5N      