   M S B A M L   `   `   `  ����B  >Exam.v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Exam.v3Exam.v3  5   	       Exam.v3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Exam.v3     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)    � 	Resources 5
       �� 
TargetType   TypesOfDishes �� Property �� Value  MyBorder  BorderFrame  btnCommands��%�  &	        &	 �     &	 �    &	 H    �� 5   
   " ��6   .�5      ��  � ��
 �����6,   �� 5       � ��$
 Bold"�6+   �� 5       � �� �	#FF803F066+   �� 5       � ��$	 100��6&   �� 5       � ��$ 1q�6'   5      �� 5   
   " ��6   .�5      ��  �@��CornerRadius$ 10��6-   �� 5       � ��$ 3q�6'   �� 5       � ��$ 5q�60   �� 5       � �� �	#BFD16A136,   5      �� 5   
   " ��6   .�5      ��  �@��CornerRadius$ 3��6-   �� 5       � ��$ 1q�60   �� 5       � ��
 �����6,   5      �� 5   
   " ��6   .�5      ��  � ��$
 auto��6'   �� 5       � ��$	 110��6&   �� 5        � ��$ 2,5,2,0q�6'   �� 5!       � ��
 �����6,   �� 5"       � ��$
 Bold"�6+   �� 5#       � �� �	#FF803F066+   5$      5%      .��5(      � ���	#FFE6D1AD � ColumnDefinitions 5)   
   �� 5*      $	��11* �6   �� 5+      $
��203* �6   �� 5,      $
��372* �6   �� 5-      $	��206 �6    � RowDefinitions 5/   
   �� 50      $��30 �6   �� 51      $
��223* �6   �� 52      $
��127* �6   �� 53      $��40 �6   .+�55   
   ]� $��4��6   $��10,2,5,2q�56      ��. .+�58      �� #��[  6   $��Первые блюда��59      $��Первое��5;      ��5:      �� *Dishes+5;      �� 5<      #��[  6   $��Вторые блюда��5=      $��Второе��5?      ��5>      �� *Dishes+5?      �� 5@      #��[  6   $��Салаты��5A      $��
Салат��5C      ��5B      �� *Dishes+5C      �� 5D      #��[  6   $��Десерты��5E      $��Десерт��5G      ��5F      �� *Dishes+5G      �� 5H      #��[  6   $��Напитки��5I      $��Напитки��5K      ��5J      �� *Dishes+5K      �� 5L      #��[  6   $��Все��5M      $��30��5N      ��5O      �� *All+�� 5P      -   5         ��Name$ cbSearchChoice��5P      $��5,2,2,2q�5Q      $	��100��5R       �� SelectedIndex$ 0��5S      .@�5T      �� .��6    По названию6-   �� 5U      .��6    По ингридиенту60   �� 5V      .��6    По кухне6*   5W      ]� 5X      ��. .+�5Y      �� $��Right=�6   $��30��5Z      $��2q�5[      ��5\      �� *Search+��5]      �� 	 �� ElementName$	 tbSearch��
 �� Path$

 Text���5^      �� 5_      " ��6     �� Triggers 5`      �� 5a   "    �� Binding 6.   �� $	 tbSearch��$

 Text� �� Value  6a   .a�5b   &   ��  � {� .  6B   5c   #   5e      .��5g      �� $��Images/search.png��6   $��20��67   6E   5h      �� 5i      -   5        $��tbSearch��5i      $��2,2,2,2q�6*   $��Center=�5j      5l      5n      �� 5p   
   $��2��6   6'   �� 5q   
   $��1��6   $��3��5r      #��[ 5s      $��3,3,3,0q�63   $��2��6D   ._�5u      �� -   5         ��Name$ 	lbRecipes��5u      $��2��5v      $��0q�5w      $��7q�5x       �� SelectedItem 5y      �� *SelectedItem+��5z      �� *	Recipes+��5{      �� 5|      .R�5}      �� ��6$   �� *Name+5~      5�      5�      �� 5�   
   $��1��6   $��2��5�      $��3��5�      $��2��5�      #��[ 5�      $��3,3,3,0q�63   5�      �� 5�   
   $��1��6   $��2��5�      $��2��5�      #��[ 5�      $��
15,15,15,3q�5�      
�������._�5�      ]� ��. .+�5�      �� $	��Top=�6   $��18(�5�      $
��Bold"�5�      ���	#FF803F06$��25,2,0,2q�5�      ��5�      �� $	 	lbRecipes��$
 SelectedItem.Name�5�      �� 5�      $��5q�6   ��5�      �� $	 	lbRecipes��$
 SelectedItem.Instruction�5�      5�      �� 5�   
   $��2��6   $��2��5�      #��[ 5�      $��15,3,5,3q�5�      
�������._�5�      �� $��5q�6   ��6#   �� $	 	lbRecipes��$
 SelectedItem.Ingredients�5�      �� 5�   
   $��3��6   $��2��5�      #��[ 5�      $��3,3,15,3q�5�      
�������._�5�      �� $
��Fill=�5�      ��5�      �� $	 	lbRecipes��$
 SelectedItem.Photo�5�      5�      �� 5�   
   $��2��6   $��3��5�      $��2��5�      $��	0,0,20,10q�5�       �� Orientation$ 
Horizontal=�5�      $��Right=�6.   $	��342��6J   .+�5�      �� #��[ 6   $��Добавить...��5�   .   ��5�   .   �� *	NewRecipe+5�   .   �� 5�      #��[ 6   $��Удалить...��5�   .   ��5�      �� *SelectedItem+$	 	lbRecipes����5�   .   �� *	DelRecipe+5�   .   �� 5�      #��[ 6   $��Изменить...��5�   .   ��5�   .   �� *
EditRecipe+��5�   .   �� *SelectedItem+$	 	lbRecipes��5�   .   5�      5�      5�      