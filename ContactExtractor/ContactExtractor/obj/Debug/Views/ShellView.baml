   M S B A M L   `   `   `  ����K  GContactExtractor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ContactExtractor.ViewsContactExtractor.Views  5   	   &     ContactExtractor.Views.ShellView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ContactExtractor.Views     5   	     � Title$  	Extractor��5   	    � Icon$ laurLogo.ico��6   $	��450��6/   $	��900��6<    � WindowStartupLocation$ CenterOwner=�5	   	    � WindowState$ 	Maximized=�6-   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   o� -   5         o�Name$
 Menu��5      $��0��6   $��1��6*   $��10��6:   
�������.@�5       m� $
��Edit��6   .@�5!      m� -   5         m�Name$ MenuJobEdit��5!      $��Edit Professions��60   m� 5"      -   5        $ MenuRegionEdit��5"      $��Edit Cities��63   m� 5#      -   5        $ MenuNumberEdit��5#      $��Edit Converted Numbers��63   m� 5$      -   5        $ MenuNotInterested��5$      $��Edit Not Interested��66   5%      5'      o� 5)   
   $��1��6   $��1��6   $��3��6,   
�������.@�5*      �� 
Website:6"   �� 5+      -   5         ��Name$ Websites��5+      $��1��6N   $��10q�6[   $	��100��6g   $��40��6s   $��SemiBold"�6   	 �� Text$	 	Strona...��6�   $��Center=�6�   
 �� SelectedItem
 6)   �� *SelectedWeb+��5,      �� 5-      .R�5.      �� ��6$   �� *Web+6;   5/      51      �� 52      Profession:6%   �� 53      -   5        $ Professions��53      $��1��6X   $��10q�6e   $	��100��6q   $��40��6}   $��SemiBold"�6�   $	 Profesja...��6�   $��Center=�6�   
 6,   �� *SelectedProfession+��54      �� 55      .R�56      �� ��6$   �� *
Profession+6B   57      59      �� 5:      City:6   �� 5;      -   5        $ Cities��5;      $��1��6'   $��10q�6\   $	��100��6h   $��40��6t   $��SemiBold"�6�   $	 	Miasto...��6�   $��Center=�6�   
 64   �� *SelectedCities+��5<      �� 5=      .R�5>      �� ��6$   �� *City+6<   5?      5A      �� 5B      Page number:6&   �� 5C      -	   5        $ Numbers��5C      $��1��6P   $��10q�6]   $��40��6i   $��40��6t   $��SemiBold"�6�   $��Center=�6�   
 6(   �� *SelectedNumber+��5D      �� 5E      .R�5F      �� ��6$   �� *Number+6>   5G      5I      �� 5K      -
   5         ��Name$ LeadGenerateButton��5K      $��1��61   $��10q�6>   $	��100��6J   $��40��6V   $��SemiBold"�6c   
������
�������.��6�   
Generate6�   5L      �� 5O   
   -   5         ��Name$ 
ActiveItem��5O      $��2��6-   $��3��6;   $��1��6L   $��3��6\   
�������6q   5Q      5R      