   M S B A M L   `   `   `  ����C  ?WpfApp25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp25WpfApp25  5          WpfApp25.RegisterAdmin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      $localclr-namespace:WpfApp25   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          � Title$  Register��5
      $	��380��5      $	��600��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��137.6 �6    �� 5      $��396.8 �6    �� 5      $
��65.6 �6    .+�5      �� $��3��5      $��0,0,0,1q�5       �� CornerRadius$ 10��5      ��5      �� 5       .��5!      �  � Offset$	 0.0Q�6'    � Color$ #7be9f6��64   � 5"      $ 1Q�6'   $ #f083da��62   5#      5%      �� 5&      -   5        $��7��5'      $��18��5(      $��0,5,7,0q�5)      $��Right=�5*      $	��Top=�5+      	 � Cursor$
	 Hand��5,      $��	helvetica)�5-      $��15(�5.      
���   �x52      �� 53      -   5        $
��Left=�54      $	��Top=�55      
������ $��0q�57      .��58   &   
Назад5:      �� 5;      $��0��5<      $	��160��5=      $��Center=�5>      .+�5@      �� $	��200��5A      $��0,15,0,0q�5B      $��Photo/MHM.png��5C      5D      � 5E      $��1��5F      $��2��5G      $��50,2.4,50,1q�5H       5I      �� 5J      $��50 �6$   �� 5K      $��50 �6$   �� 5L      $��50 �6$   �� 5M      $��50 �6$   �� 5N      $��50 �6$   �� 5O      $��50 �6$   �� 5P      $��50 �6$   �� 5Q      $��45 �6$   .+�5S      �� -   5        
 ��Name$
 EmailTextbox��5T      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��5U      $��	Helvetica)�5V      $��16(�5W      
���   � %  !MaterialDesignFloatingHintTextBox#��[  5Y      G� 5Z      -   5         G�Name$ Password��5[      $��1��5\      $
��Left=�5]      $ Пароль��5^      $��16(�5_      
���   � ) %MaterialDesignFloatingHintPasswordBox#��[ 5a      G� 5b      -   5        $ Cpass��5c      $��2��5d      $% Повторите пароль��5e      $��16(�5f      
���   �#��[ 5h      �� 5i      -   5        $
 NameTextBox��5j      $��3��5k      $ Имя��5l      $��16(�5m      
���   �#��[  5o      �� 5p      -   5        $
 
SurTextBox��5q      $��4��5r      $ Фамилия��5s      $��16(�5t      
���   �#��[  5v      � 5w      $��7��6    � ColumnDefinitions 5x      �� 5y      �� 5z      .+�5|      	� -	   5         	�Name$ 	MaleRadio��5}      $��0��5~      $��45��5      $��Center=�5�      $��Center=�5�         MaterialDesignTabRadioButton#��[ 5�      .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�      �� -
   5         ��Name$ TextMale��5�   !   $��Center=�5�   !   $��17(�5�   !   
���   �$
��Male��5�   !   .  (MahApps.Metro.IconPacks.PackIconMaterial  5�      $��1��5�   !   $	��105��5�   !   $��5q�5�   !   $��Center=�5�   !   $��Center=�5�   !   $
	 Hand��5�   !   
�������   Kind$ 
GenderMale=�5�   !   5�      5�      	� 5�      -   5        $ FemaleRadio��5�      $��1��5�      $��45��5�      $��Center=�5�      $��Center=�5�      #��[ 5�      .��5�      �  5�      �� 5�   "   �� 5�   "   .+�5�      �� -   5        $ 	TextFMale��5�   !   $��Center=�5�   !   $��16(�5�   !   
���   �Female5�        5�      $��1��5�   !   $	��105��5�   !   $��5q�5�   !   $��Center=�5�   !   $��Center=�5�   !   $
	 Hand��5�   !   
�������$ GenderFemale=�5�   !   5�      5�      5�      �� 5�      -   5        $
 TextBoxTime��5�      $��5��5�      $ День рождения��5�      $��17(�5�      
���   �#��[  5�      �� 5�      -   5         ��Name$ CountryCombo��5�      $��6��5�      $ Страна��5�      $��16(�5�      .@�5�      �� 
Китай6'   �� 5�      США6%   �� 5�      
Индия6'   �� 5�      Япония6(   �� 5�      Германия6*   �� 5�      Россия6(   �� 5�      Великобритания60   �� 5�      Франция6)   �� 5�      Италия6(   �� 5�      Польша6(   �� 5�      Испания6)   �� 5�      Беларусь6*   5�      5�      � 5�      $��2��6   $��	0,0.6,0,0q�6    .+�5�      �� -   5         ��Name$ 	RegButton��5�      $��Center=�5�      $&�� Зарегистрировать��5�      5�      5�      5�      5�      