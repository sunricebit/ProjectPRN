   M S B A M L   `   `   `  ����B  >QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizAppQuizApp  5   	       QuizApp.Review   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QuizApp     5   	     � Title$  Review��5   	   $	��320��6   $	��800��6%    � 	Resources 5	       �� 
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
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $��* �6   .+�5-   
   �� $��	Question:��6   $��0��6$   $��10q�61   �� 5.   
   -   5         ��Name$ txtQuestion��5.      $��1��6)   $��1��66   $��5q�6F   $��14(�6Q   �� 51   
   $��Answers:��6   $��2��6#   $��10q�60   �� 52   
   $��3��6   $��1��6"    �� Orientation$ Vertical=�62   $��5q�6I   .+�53      �  � ColumnDefinitions 54      �� 55      $
��Auto �6'   �� 56      $��* �6'   .+�58      �� -   5         ��Name$
 chkA��58      $��Center=�6)   ${�False��6D   �� 59      -   5        $ 
txtAnswerA��59      $��1��60   $��14(�6@   5:      � 5;       5<      �� 5=      $
��Auto �6'   �� 5>      $��* �6'   .+�5@      �� -   5        $
 chkB��5@      $��Center=�6)   ${�False��6D   �� 5A      -   5        $ 
txtAnswerB��5A      $��1��60   $	��0 2q�6@   $��14(�6M   5B      � 5C       5D      �� 5E      $
��Auto �6'   �� 5F      $��* �6'   .+�5H      �� -   5        $
 chkC��5H      $��Center=�6)   ${�False��6D   �� 5I      -   5        $ 
txtAnswerC��5I      $��1��60   $	��0 2q�6@   $��14(�6M   5J      � 5K       5L      �� 5M      $
��Auto �6'   �� 5N      $��* �6'   .+�5P      �� -   5        $
 chkD��5P      $��Center=�6)   ${�False��6D   �� 5Q      -	   5        $ 
txtAnswerD��5Q      $��1��60   $	��0 2q�6@   $��14(�6M   5R      5S      �� 5T   
   $��4��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5U      �� -
   5         ��Name$ btnPrevious��5U      $��Previous��6*   $��80��6=   $��20��6H   $��14(�6T   6b   �� 5W      -   5        $ txtIndex��5W      $
��1/10��6*   $��14(�66   $��	10,0,10,0q�6D   �� 5X      -   5        $ btnNext��5X      $
��Next��6&   $��90��65   $��20��6@   $��14(�6L   6Z   5Y      �� 5[   
   $��5��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5\      �� -   5        $ btnMainMenu��5\      $��	Main Menu��6*   $	��100��6>   $��20��6J   $��14(�6V   6d   5]      5^      5_      