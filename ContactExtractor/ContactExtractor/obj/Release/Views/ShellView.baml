   M S B A M L   `   `   `  ���� H  DLaurCRMSecond, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LaurCRMSecond.ViewsLaurCRMSecond.Views  #    LaurCRMSecond.Views.ShellView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:LaurCRMSecond.Views       � Title$  LaurCRM�� � Icon$ laurLogo.ico��$	��450��$	��900�� � WindowStartupLocation$ CenterOwner=� � WindowState$ 	Maximized=�.���  � ColumnDefinitions �� $��20 ��� $
��auto ��� $��* ��� $��* ��� $��* ��� $
��auto ��� $
��auto ��� $��* ��� $��* ��� $��* ��� $
��auto ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+�o� -    o�Name$
 Menu��$��0��$��1��$��10��
�������.@�m� $��Pliki��.@�m� -    m�Name$ MenuJobEdit��$��Edytuj Profesje��m� -   $ MenuRegionEdit��$��Edytuj Miasta��m� -   $ MenuDataBaseEdit��$��Edytuj Baze���� .��
Ustawieniao� $��1��$��1��$��10��
�������.@��� -   $��
webisteBox��$��1��$��10q�$	��100��$��40��$��SemiBold"� �� Text$ 	Strona...��$��Center=�	 �� 
IsEditable	 . 
 �� 
IsReadOnly
 . ���� *	WebSite+�� -   $��jobBox��$��1��$��10q�$	��100��$��40��$��SemiBold"�$ Profesja...��$��Center=�	 . 
 . ���� *Job+�� -   $��cityBox��$��1��$��10q�$	��100��$��40��$��SemiBold"�$ 	Miasto...��$��Center=�	 . 
 . ���� *City+�� -   $��
numbersBox��$��1��$��10q�$��40��$��40��$��SemiBold"�
�������$��Center=�	 . 
 . ���� *	Numbers+�� -	    ��Name$ LeadGenerateButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
������
�������.��	Generuj�� -
   $ ContactSpreadButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��
Kontakty�� -   $ CalendarSpreadButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��	Kalendarz�� -   $ SalesSpreadButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��	Sprzedaż�� -    ��Name$ 	SearchBox��$��10q�$	��300��$��40��$��SemiBold"�. �/�  /� TextAlignment$
 Left=��� -   $ SearchButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
����·�
�������.��Szukaj&   System.Windows.Controls.DataGrid  -     Name$ LeadsDataGrid��   AlternatingRowBackground
 �����   CanUserAddRows .     AutoGenerateColumns .  $��2��$��1��$��5��$��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Firma��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    FontSize$ 14Q�  $ Telefon��$ * $ 14Q�  $ Email��$ * $ 14Q�4  .System.Windows.Controls.DataGridTemplateColumn  $ Dodaj��$ * �� -    ��Name$ 
ActiveItem��$��2��$��6��$��10��$��2��