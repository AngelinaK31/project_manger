   M S B A M L   `   `   `  ����L  HProjectManagerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjectManagerApp.UI.PagesProjectManagerApp.UI.Pages  5      ,    &ProjectManagerApp.UI.Pages.PageProject   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ProjectManagerApp.UI.Pages     5        N� Title$  PageProject��5	      .��5      �    	LightBlue#��[  6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��300 �6   .+�5   
   � -   5        $��gInfo��5   !   $��1��6   .+�5      �   DarkBlue#��[ 6    J� Opacity$	 0.8Q�6:   �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�66   .+�5      �� -   5        $��tbxName��5       �� TextWrapping$
 Wrap=�6C   $	��290��6W     EditBox#��[ 6c   {�.  ��6-   �� *Name+6�   5      �� 5      -   5        $��spDescription��5   6   $ 
Horizontal=�6   $
��5 20q�6K   .+�5      ��   
BlackBlock#��[ 6    $��Описание: ��6D   $	��Top=�6V   �� 5      -   5        $��tbxDescription��5      $
 Wrap=�6Q   $	��200��6e   $
��auto��6q    �� AcceptsReturn . #��[ 6�   {�.  ��64   �� *Description+6�   5      �� 5      $ 
Horizontal=�6   $��5 20 5 5q�66   .+�5      �� #��[ 6    $"��Дата создания - ��6D   (  "System.Windows.Controls.DatePicker  5      -   5        $��tpCreationDate��5   Y   {�.     SelectedDate 6!   �� *CreationDate+6Y   5       �� 5"      $ 
Horizontal=�6   $��5q�66   .+�5#      �� #��[ 6    $��Дедлайн - ��6D     5$      -   5        $��
tpDeadline��5$   U   {�.   6!   �� *
Deadline+6U   5%      5&      �� 5'      -   5        $��btnEditInfo��5'   �   $$��Отредактировать��6   $��Center=�6/   $��Bottom=�6L   6�   �� 5(      -   5        $��btnSave��5(      $+��%Сохранить изменения��6   $��Center=�63   $��Bottom=�6P   $y�	Collapsed=�6�   5*      &   System.Windows.Controls.DataGrid  5+   
   -	   5          Name$ dgTasks��5+         AutoGenerateColumns .  #��[  6@   $	   HorizontalScrollBarVisibility$
	 auto=�6h   $
��auto��6�   5-      5.      5/      