   M S B A M L   `   `   `  ����B  >QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizAppQuizApp  5   	       QuizApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QuizApp     5   	     � Title$  Quiz Application��5   	   $	��450��6"   $	��800��6/    � 	Resources 5	       �� 
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
 �����64   5      5!      5"      .��5#      � 
 � ColumnDefinitions
 5$   
   �� 5%      $	��41* �6   �� 5&      $��9* �6   .+�5(   
   �� $��Quiz Practice��6   $
��Left=�6(   $	��Top=�6C   $��24(�6[   $��
326,20,0,0q�6i   �� 5)   
   -   5         ��Name$ btnViewQuizCollection��5)      $��Your Quiz Collections��60   $
��Left=�6P   $	��Top=�6k   $	��200��6�   $��50��6�   $��300,148,0,0q�6�   6�   �� 5*   
   -   5        $ btnCreateCollection��5*      $��Create New Collection��6.   $
��Left=�6N   $	��Top=�6i   $	��200��6�   $��50��6�   $��300,217,0,0q�6�   6�   5+      5,      