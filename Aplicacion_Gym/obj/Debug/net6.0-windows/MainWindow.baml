   M S B A M L   `   `   `  ����I  EAplicacion_Gym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Aplicacion_GymAplicacion_Gym  5   	       Aplicacion_Gym.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Aplicacion_Gym     5   	     � Title$&   Sistema de Gestión de Gimnasios��5   	   $	��450��61   $	��800��6>    � WindowStartupLocation$ CenterScreen=�6J   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $
��0.1* �6   6,   .+�5   
   �� $��0��6   
���   �$��5q�62    �� CornerRadius$ 10��6F   ���#8ecae66X   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Datos��5       $��0��6   $��Arial)�6/   $��16(�6B   
������    AlternatingRowBackground �#219ebc   RowBackground
 ���� $��5q�5      $��5q�6   $��0,0,0,0q�6*      AutoGenerateColumns$ False��6D      ColumnHeaderStyle 5      �� 5      	 �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"	  6   .�5      �� 
 �� Property
 � �� �� Value �#219ebc6E   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ��  �� Path$ Id�6Y     5      $	 DNI��6%   $ * 62    6<   �� $	 DNI�6[     5      $ Nombres��6%   $ * 66    6@   �� $
 Name�6`     5      $ 	Apellidos��6%   $ * 68    6B   �� $ LastName�6f     5      $ 	Teléfono��6%   $ * 67    6A   �� $ Phone�6b     5      $ Fecha de nacimiento��6%   $ * 6B    6L   �� $
 Fnac�6l     5      $
 Edad��6%   $ * 63    6=   �� $	 Age�6\     5       $
 Sexo��6%   $ * 63    6=   �� $ Gender�6_     5!      $ 
Dirección��6%   $ * 68    6B   �� $	 Dir�6a   5#      � 5%   
   $��1��6    � ColumnDefinitions 5&      �� 5'      6%   �� 5(      6%   �� 5)      6%   .+�5,      �� $��0��6   ���	#FF2A9D8F
���   �$��2q�6P   $ 15��6d   �� 5-      -   5        $��0��5-      $��Agregar��6%   $��18(�68   $��Arial)�6F   
������ 6i   �� 5.      $��1��6   ���	#FFE9C46A
���   �$��2q�6P   $ 15��6d   �� 5/      -   5        $��1��5/      $	��Ver��6%   
������ $��18(�6L   $��Arial)�6Z   6m   �� 50      $��2��6   ���	#FFE76F51
���   �$��2q�6P   $ 15��6d   �� 51      -   5        $��2��51      $��Borrar��6%   
������ $��18(�6O   $��Arial)�6]   6p   52      53      54      