   M S B A M L   `   `   `  ����F  BDesktop.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Desktop.App.PagesDesktop.App.Pages  5      !    Desktop.App.Pages.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Desktop.App.Pages     5      $
��1083��5	      $	��800��6     � 	Resources  5         TextBoxTemplate �� 
TargetType �� CornerRadius J� SnapsToDevicePixels ��Name  PasswordTemplate  ButtonTemplate � Color��%�  &	        &	 �     &	 �    �� 5   
   " ��62   .R�5      �� $ 7��6   #��z��5      #��z��6B   #��z��6v    . ._�5      �� $ PART_ContentHost��6   |�.  $��Hidden=�6K   $��Hidden=�6r   5      5      �� 5   
   " G�63   .R�5      �� $ 7��6   #��z��5      #��z��6B   #��z��6v    . ._�5      �� $ PART_ContentHost��6   |�.  $��Hidden=�6K   $��Hidden=�6r   5      5      �� 5   
   " ��61   .R�5      �� 
��� � �$��0q�6)   $ 10��6=   ���#0E8BDC$��0 0 0 0q�5   4   $��30��6E   ��5      �� 5      .��5       � $ White��6'   67   5!      ._�5#      �� ��. $��Center=�6>   $��Center=�6Y   6x   5$      5%      5&      .��5(      � ��5*   
   �� 5+       �� ImageSource$8 2/Desktop.App;component/Resources/img/back_main.png��6    j� Stretch$ UniformToFill=�6Z   .+�5.   
   ]� -   5        $��LoginDockPanel��5.      $
��Left=�6+   $	��268��6F   $��302,265,0,0q�6S   $	��Top=�6h   $	��390��6�   $	��390��6�   $	��268��6�   ���	#B20E8BDC$	��390��6�   $	��267��6�   .+�5/      �� $��Вход��6   $
��Left=�6$   $��15,24,-89,0q�6?   $	��Top=�6T   $��PT Sans)�6l   
�������$��26(�6�   $
��Bold"�6�   
�������6�   �� 50      $��
Логин��6   $
��Left=�6%   $��	15,82,0,0q�6@   $	��Top=�6S   
�������$��PT Sans)�6~   $��14(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.533,0.576&�6�   �� 51      $��Пароль��6   $
��Left=�6&   $��-50,147,0,0q�6A   $	��Top=�6V   
�������$��PT Sans)�6�   $��14(�6�   $
��Bold"�6�   $ 0.533,0.576&�6�   �� 52      -   5        $��	LoginText��52      $
��Left=�6(   $��30��6C   $��-61,104,0,0q�6O   	 �� TextWrapping$
	 Wrap=�6d   $	��Top=�6x   $	��360��6�   $��Center=�6�   
 �� MaxLines$
 1��6�   #��[  6�   $��Roboto)�6�   $��14(�6  6  G� 53      -   5        $��PasswordText��53      $��30��6/   $	��Top=�6;    G� PasswordChar$ *��6S   #��[ 6d   $	��360��6�   $��-360,170,0,0q�6�   $��Center=�6�   $��Roboto)�6�   $��14(�6�   6�   �� 54      -   5        $��LoginButton��55      $!��Выполнить вход��56      $��1��57      $
��Left=�58      $��-131,220,0,18q�59      $	��131��5:      $��PT Sans)�5;      $
��Bold"�5<      ���	#FF0E8BDC#��[ 5>      ��5?      �� *LoginButton_Click+67   5A      �� 5B   
   $��293,104,385,585q�6   �� 5C      $��96(�6   ���	#7F000000$
��Bold"�67   $��PT Sans)�6I   .�6_   Time6e    �� 5D      $��96(�6   ���	#7F000000$��PT Sans)�67   .�6L   Line6R   5E      5G      5H      