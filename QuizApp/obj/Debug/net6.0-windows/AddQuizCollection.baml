   M S B A M L   `   `   `  ����B  >QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizAppQuizApp  5   	       QuizApp.AddQuizCollection   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QuizApp     5   	     � Title$  Add Quiz Collection��5   	   $	��400��6%   $	��250��61    � 	Resources 5	       �� 
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
 �����64   5      5!      5"      .��5#      � $��20q�6   
 � RowDefinitions
 5$   
   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   .+�5-   
   �� $��Title:��6   $��18(�6"   $
��Bold"�60   �� 5.   
   -   5         ��Name$ txtTitle��5.      $��1��6$   $	��0,5q�61   $��14(�6>   �� 51   
   $��	Category:��6   $��18(�6%   $
��Bold"�63   $��2��6E   $��0,10,0,5q�6R   �� 52   
   -   5         ��Name$ cmbCategoryId��52      $��3��6*   $��0,0,0,10q�67    �� DisplayMemberPath$
 Name��6I    �� SelectedValuePath$ Id��6b   ��54      -  'System.Windows.Data.CompositeCollection  55      �� 56       �� 
Collection 6*   �� *ExistingCategories+�� 57      .��58      �� $��Add New Category��6$   59      5:      5<      �� 5?   
   -   5        $ txtNewCategory��5?      $��4��6*   $	��0,5q�67   $y�	Collapsed=�6D   $��14(�6[   �� 5B   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��Center=�6;   $��
0,33,0,-33q�6X   .+�5C      �� -   5        $	��Add��5C      $	��100��6#   $��5q�6D   �� 5D      -   5        $��Cancel��5D      $	��100��6&   $��5q�6J   5E      5F      5G      