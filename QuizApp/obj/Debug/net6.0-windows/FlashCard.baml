   M S B A M L   `   `   `  ����B  >QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizAppQuizApp  5   	       QuizApp.FlashCard   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QuizApp     5   	     � Title$  	FlashCard��5   	   $	��450��6   $	��800��6(    � 	Resources 5	       �� 
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
 �����64   5      5!      5"      .��5#      � .+�5$   
   �� -   5        
 ��Name$
 borderFlashcard��5$      $��20,20,20,45q�6*   $ 10��6?   
���   �$��1q�6e   ._�5&      � -   5         �Name$ gridFlashcard��5&       � RowDefinitions 5'      �� 5(      $
��Auto �6$   �� 5)      $��* �6$   .+�5-      �� $��0��6   
����ح� �� Padding$ 10q�6=   $ 10��6J   ._�5.      �� -   5         ��Name$ txtFront��5.       $$��What is the capital of France?��62   $��24(�6X   $
��Bold"�6f    �� TextAlignment$ Center=�6x   5/      �� 52      $��1��6   
������$ 10q�6>   $ 10��6K   ._�53      �� -   5         ��Name$ answerOptionsStackPanel��53   !   55      56      57      58      �� 5<   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $	��Top=�6K   $��	0,404,0,0q�6c   .+�5=      �� -   5         ��Name$ btnPrevious��5=      $��Previous��6*   $��80��6W   $��20��6b   $��14(�6n   �� 5?      -   5        $ txtIndex��5?      $
��1/10��6*   $��Center=�66   $��14(�6S   $��	10,0,10,0q�6a   �� 5@      -   5        $ btnNext��5@      $
��Next��6&   $��90��6K   $��20��6V   $��14(�6b   5A      5B      5C      