   M S B A M L   `   `   `  ����C  ?WpfApp25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp25WpfApp25  5          WpfApp25.Remove   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      $localclr-namespace:WpfApp25   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          � Title$  Remove��5
      $	��380��5      $	��600��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �  � RowDefinitions 5   
   �� 5      $	��47* �6   �� 5      $
��153* �6   .+�5   
   � $��2��6    5      �� 5      $	��144 �6    �� 5      $��412.8 �6    �� 5      $
��43.2 �6    .+�5       �� $��3��5!      $��0,0,0,1q�5"       �� CornerRadius$ 10��5#      ��5$      �� 5%      .��5&      �  � Offset$	 0.0Q�6'    � Color$ #7be9f6��64   � 5'      $ 1Q�6'   $ #f083da��62   5(      5*      �� 5+      -   5        $��7��5,      $��18��5-      $��0,5,7,0q�5.      $��Right=�5/      $	��Top=�50      	 � Cursor$
	 Hand��51      $��	helvetica)�52      $��15(�53      
���   �x57      �� 58      -   5        
 ��Name$
 
BackButton��59      $��69��5:      $
��Left=�5;      $	��Top=�5<      
������ $��0q�5>      $��Light"�5@      
���   �.��5A   $   
Назад5C      �� 5D      $	��160��6   $��Center=�6&   .+�5F      �� $	��170��5G      $��0,15,0,0q�5H      $��Photo/MHM.png��5I      �� 5J      $��Center=�5K      $��	helvetica)�5L      $��22(�5M      $��Light"�5N      
�������$��Minsk Half Marathon��5P      �� 5Q      -   5         ��Name$ IDLable��5Q      $y�Hidden=�6-   5R      � 5S      $��1��6   $��50,1,50,4.8q�6     5T      �� 5U      $��50 �6$   �� 5V      $��50 �6$   �� 5W      $��50 �6$   �� 5X      $��50 �6$   �� 5Y      $��50 �6$   �� 5Z      $��50 �6$   �� 5[      $��45 �6$   �� 5\      $��50 �6$   .+�5^      �� -   5         ��Name$ EmailTextbox��5_      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��5`      $��15(�5a       %  !MaterialDesignFloatingHintTextBox#��[  5b      G� 5c      -   5         G�Name$ Password��5d      $��1��5e      $
��Left=�5f      $ Пароль��5g      $��	Helvetica)�5h      $��15(�5i       ) %MaterialDesignFloatingHintPasswordBox#��[ 5j      G� 5k      -   5        $ Cpass��5l      $��2��5m      $% Повторите пароль��5n      $��	Helvetica)�5o      $��15(�5p      #��[ 5q      �� 5r      -   5        $ NameTextBox��5s      $��3��5t      $ Имя��5u      $��	Helvetica)�5v      $��15(�5w      #��[  5x      �� 5y      -	   5        $ 
SurTextBox��5z      $��4��5{      $ Фамилия��5|      $��15(�5}      #��[  5~      � 5      $��7��6   $��	0,-10,0,0q�6$    � ColumnDefinitions 5�      �� 5�      �� 5�      .+�5�      	� -
   5         	�Name$ 	MaleRadio��5�      $��0��5�      $��45��5�      $��Center=�5�      $��Center=�5�         MaterialDesignTabRadioButton#��[ 5�      .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�      �� -   5        $ TextMale��5�   !   $��Center=�5�   !   $��15(�5�   !   $
��Male��5�   !   .  (MahApps.Metro.IconPacks.PackIconMaterial  5�      $��1��5�   !   $	��105��5�   !   $��5q�5�   !   $��Center=�5�   !   $��Center=�5�   !   $
	 Hand��5�   !   
�������   Kind$ 
GenderMale=�5�   !   5�      5�      	� 5�      -   5        $ FemaleRadio��5�      $��1��5�      $��45��5�      $��Center=�5�      $��Center=�5�      #��[ 5�      .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�      �� -   5        $ 	TextFMale��5�   !   $��Center=�5�   !   $��15(�5�   !   Female5�        5�      $��1��5�   !   $	��105��5�   !   $��5q�5�   !   $��Center=�5�   !   $��Center=�5�   !   $
	 Hand��5�   !   
�������$ GenderFemale=�5�   !   5�      5�      5�      �� 5�      -   5        $ TextBoxTime��5�      $��5��5�      $ День рождения��5�      $��	Helvetica)�5�      $��15(�5�      #��[  5�      �� 5�      -   5         ��Name$ CountryCombo��5�      $��6��5�      $ Страна��5�      $��	Helvetica)�5�      $��15(�5�      .@�5�      �� 
Китай6'   �� 5�      США6%   �� 5�      
Индия6'   �� 5�      Япония6(   �� 5�      Германия6*   �� 5�      Россия6(   �� 5�      Великобритания60   �� 5�      Франция6)   �� 5�      Италия6(   �� 5�      Польша6(   �� 5�      Испания6)   �� 5�      Беларусь6*   5�      5�      � 5�      $��2��6   $��	0,-10,0,0q�6     5�      �� 5�      $
��1.3* �6'   �� 5�      $��* �6'   .+�5�      �� -   5        $
 	RegButton��5�      $��0,0,20,5q�5�      $��Right=�5�      $��Подтвердить��5�      �� 5�      -   5        $
 CancelButton��5�      $��1��5�      $��0,0,0,5q�5�      $
��Left=�5�      $��Отмена��5�      5�      5�      5�      5�      