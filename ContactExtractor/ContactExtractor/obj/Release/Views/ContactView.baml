   M S B A M L   `   `   `  ���� H  DLaurCRMSecond, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LaurCRMSecond.ViewsLaurCRMSecond.Views  %    LaurCRMSecond.Views.ContactView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:LaurCRMSecond.Views     
�������.���   � RowDefinitions  �� $��* ��� $
��auto �.+��� .���� .+��   �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $��* �.+�(  "System.Windows.Controls.DatePicker  -     Name$ DatePickerBox��$��0��$��0���� $��5q�$��1��$��0��$��Nazwa Firmy:���� -    ��Name$ CompanyNameTextBox��$��2��$��0��$��5q��� $��5q�$��3��$��0��$��Telefon:���� -   $ PhoneNumberTextBox��$��4��$��0��$��5q��� $��5q�$��5��$��0��$��Email:���� -   $ EmailTextBox��$��6��$��0��$��5q��� $��5q�$��7��$��Info:���� -   $ InfoTextBox��$��8��$��4��$��0��$��5q��� $��5q�$��12��$��0��$��Imię:���� -   $ ClientNameTextBox��$��13��$��0��$��5q��� $��5q�$��14��$��0��$��	Nazwisko:���� -   $ SurnameNameTextBox��$��15��$��0��$��5q��� $��5q�$��16��$��PESEL:���� -   $ PESELTextBox��$��17��$��0��$��5q��� $��5q�$��18��$
��NIP:���� -	   $ 
NIPTextBox��$��19��$��0��$��5q��� $��5q�$��20��$-��'Seria i Numer Dowodu / do kiedy ważny:���� -
   $ 	IDTextBox��$��21��$��0��$��5q��� $��5q�$��22��$��Umowa:���� -   $ AgrimentTextBox��$��23��$��0��$��5q��� $��5q�$��24��$��Stanowisko:���� -   $ JobPositionTextBox��$��25��$��0��$��5q��� $��5q�$��26��$��Zarobki:���� -   $ MoneyTextBox��$��27��$��0��$��5q��� $��1��$��5��$��Stretch=�o� -    o�Name$ 
MenuButton��$��1��$��1��$��10��
�������.@��� -    ��Name$ PdfGenerateButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
����p��
�������.��Generuj Wniosek�� -   $ NewContactButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��Nowy�� -   $ EditContactButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��Edytuj�� -   $ DeleteContactButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��Usuń�� -   $ SaveContactButton��$��1��$��10q�$	��100��$��40��$��SemiBold"�
�������.��Zapisz