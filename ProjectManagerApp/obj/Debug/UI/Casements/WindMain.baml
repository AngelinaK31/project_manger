   M S B A M L   `   `   `  ����L  HProjectManagerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ProjectManagerApp.UI.CasementsProjectManagerApp.UI.Casements  5   	   -    'ProjectManagerApp.UI.Casements.WindMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:ProjectManagerApp.UI.Casements     5   	     � Title$  ProjectManager��5   	   $	��600��6    $
��1000��60    � WindowStartupLocation$ CenterScreen=�6@   .��5	      �    	LightBlue#��[  6    � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   � $��2��6     DarkBlue#��[ 6#   .+�5      �� $��/Resources/Logo.png��6   $
��Left=�61   $��2q�6L   5      � 5   
   #��[ 6   $��1��66   .+�5      �� .+�5      �� -   5        $#��Текущие проекты��5      $��
10 15 10 5q�63   $��0q�6g   $
��Left=�6{   �� 5      -   5        $��lvCurrentProjects��5   4   
������ $y�	Collapsed=�6M   $��0q�6d   ��5      �� 5      .R�5      �� $��16(�6>     
WhiteBlock#��[ 6L   ��6(   �� *Name+6L   5      ��5       �� 5!       �� 
TargetType" ��6    .�5"      -   5        5#      5%      �� 5&      -   5        $��
Архив��5&      $��	10 5 10 5q�6)   $��0q�6X   $
��Left=�6l   �� 5'      -   5        $��lvOldProjects��5'   4   
������ $y�	Collapsed=�6I   $��0q�6`   ��5(      �� 5)      .R�5*      �� $��16(�6>   #��[ 6L   ��6(   �� *Name+6L   5+      ��5-      �� 5.      " ��6    .�5/      -   5        50      52      53      �� 54      -   5        $��Bottom=�54      $��
Выход��60    	 Brown#��[ 6@   $��5q�6d   $	��200��6o   6{   55       � 56   
   -   5          �Name$ 	MainFrame��56      $��1��6#   $��1��60     � NavigationUIVisibility$ Hidden=�6@   |�.  6`   57      58      