   M S B A M L   `   `   `  ����D  @AgendaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AgendaWPF.PagesAgendaWPF.Pages  5           AgendaWPF.Pages.ListBroker   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:AgendaWPF.Pages     5        N� Title$  
ListBroker��5	      .��5      � 
�������$��
0,0,0,-0.4q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dgBrokers��5         AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .    CanUserAddRows .     CanUserSortColumns . $��	0,0,0,117q�6�   $	��334��6�   $
��Auto��6�   $
��Left=�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5      $	 Nom��6%    62   �� *
lastname+  5      $ Prénom��6%    65   �� *	firstname+  5      $ Adresse Mail��6%    6;   �� *mail+  5      $ Numéro de téléphone��6%    6B   �� *phoneNumber+5      �� 5   
   -   5        $��Modifier��5      $
��Left=�6$   $��587,232,0,0q�6?   $	��Top=�6T   $��75��6l   6w   �� 5   
   -   5        $��	Supprimer��5      $
��Left=�6%   $��462,232,0,0q�6@   $	��Top=�6U   $��75��6m   	 J� RenderTransformOrigin$	 2.719,-0.216&�6x   6�   �� 5   
   -   5        $��Annuler��5      $
��Left=�6#   $��687,232,0,0q�6>   $	��Top=�6S   $��75��6k   6v   �� 5   
   -   5        $��lastname_input��5      $
��Left=�6(   $��23��6C   $��
642,63,0,0q�6O   
 �� TextWrapping$

 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $��firstname_input��5      $
��Left=�6)   $��23��6D   $��642,103,0,0q�6P   $

 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $��
mail_input��5      $
��Left=�6$   $��23��6?   $��642,144,0,0q�6K   $

 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $��phoneNumber_input��5      $
��Left=�6+   $��23��6F   $��642,184,0,0q�6R   $

 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   �� 5   
   $��Nom :��6   $
��Left=�6    $��
462,60,0,0q�6;   $	��Top=�6O   $��75��6g   �� 5   
   $��	Prénom :��6   $
��Left=�6#   $��462,100,0,0q�6>   $	��Top=�6S   $��75��6k   �� 5   
   $��Adresse Mail :��6   $
��Left=�6)   $��462,141,0,0q�6D   $	��Top=�6Y   $��95��6q   �� 5   
   $��Numéro de téléphone :��6   $
��Left=�60   $��462,181,0,0q�6K   $	��Top=�6`   $	��131��6x   �� 5    
   -	   5        $��error_message��5       $
��Left=�6)   $��462,348,0,0q�6D   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��328��6�   
���  ��6�   5!      5"      