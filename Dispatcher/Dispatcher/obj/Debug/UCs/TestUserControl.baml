   M S B A M L   `   `   `  ����E  ADispatcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Dispatcher
Dispatcher  5           Dispatcher.TestUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Dispatcher     5      -   5        .��5
      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ 
TestButton��5      $#��Тестовая кнопка��6)   6C   �� 5      -   5         ��Name$ TestRoleComboBox��5      63   5      �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   .+�5      �� -   5         ��Name$ QueryTB��5      �� 5      -   5        $ QueryButton��5      $%��Отправить запрос��6*   6E   �� 5      -   5        $ CButton��5      $��Це батон��6&   69   �� 5      -   5        $ OutTB��5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ QueryDG��5      5      �� 5   
   $��2��6   .+�5      �� -	   5        $ 	AddButton��5      $��	AddButton��6(   $y�	Collapsed=�6T   �� 5      -
   5         ��Name$ FieldsListBox��5      $	��200��6-   ��5      �� 5      .R�5       �� $ 
Horizontal=�6%   .+�5!      �� $��Center=�6=   ��6$   �� *Name+6=   �� 5"      $��5,0,0,0q�6?   ��6&   �� *Length+6?   �� 5#      y�6'   �� *
Required+   BoolToVisConverter �� 	Converter# [  5$      5%      ��5'      �� 5(      .R�5)      �  � Orientation$ 
Horizontal=�6$   ��5*      �� 	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType"
 � �� Path$ ActualHeight���5+      �� 	 �� *FindAncestor+"
 �$ ActualWidth�5,      5.      5/      50      51      