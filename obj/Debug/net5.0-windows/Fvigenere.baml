   M S B A M L   `   `   `  ����G  Cencrytionapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:encrytionappencrytionapp  5   	       encrytionapp.Fvigenere   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:encrytionapp     5   	     � Title$  	Fvigenere��5   	   $	��450��6   $	��800��6(   .��5	      � ��5
   
   �� 5       �� ImageSource$1 +Images/4e591f352012791f90143fe92106730a.jpg��6   .+�5   
   �� -   5         ��Name$ lblvigenere��5      $��	Vigenère��6%   $��Center=�68   $��0,10,0,0q�6U   $	��Top=�6g    J� RenderTransformOrigin$ 0.368,-1.308&�6   $��27(�6�   $��Calibri)�6�   $
��Bold"�6�   
�������6�   �� 5   
   -   5         ��Name$ 
tbVigenere��5      $
��Left=�6&   $��337,312,0,0q�6A    �� TextWrapping$
 Wrap=�6V   $��
��6j   $	��Top=�6|   $	��145��6�   $��30��6�   $ 0.483,0.335&�6�   $��24(�6�   $��Calibri)�6�   �� 5   
   -   5         ��Name$	 img��5      $
��Left=�6   $	��136��68   $��322,133,0,0q�6E   $	��Top=�6Z   $	��160��6r   $g��a/kisspng-padlock-computer-icons-icon-design-symbol-lock-5b360157147cb9.8543979615302659430839.png��6~   $ 0.542,0.719&�6�   �� 5   
   -   5         ��Name$ 
btnValider��5      $��Valider��6%   $
��Left=�67   $��367,372,0,0q�6R   $	��Top=�6g   $��85��6   $��28��6�   $��Calibri)�6�   $��18(�6�   �� 5   
   -   5        $ 
lblMessage��5      $��	Message :��6$   $
��Left=�68   $��241,308,0,0q�6S   $	��Top=�6h   $��Calibri)�6�   
�������$��20(�6�   	� 5   
   -   5         	�Name$ rbDechiffrer��5      $��Déchiffrer��6,   $
��Left=�6A   $��410,283,0,0q�6\   $	��Top=�6q   $��Calibri)�6�   $��15(�6�   
�������$ 0.388,-1.384&�6�   	� 5   
   -   5        $ 
rbChiffrer��5      $��Chiffrer��6*   $
��Left=�6=   $��322,283,0,0q�6X   $	��Top=�6m   $��Calibri)�6�   $��15(�6�   
�������$��RightToLeft=�6�   5      5      