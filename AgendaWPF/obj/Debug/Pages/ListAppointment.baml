   M S B A M L   `   `   `  ����D  @AgendaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AgendaWPF.PagesAgendaWPF.Pages  5      %    AgendaWPF.Pages.ListAppointment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:AgendaWPF.Pages     5        N� Title$  ListAppointment��5	      .��5      � 
�������$��
0,0,0,-0.4q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgAppointments��5         AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .    CanUserAddRows .     CanUserSortColumns . $��0,0,401,117q�6�   $	��405��6�   $
��Auto��6�   $
��Left=�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5      $ Heure dur RDV��6%    6<   �� *
dateHour+  5      $ Sujet��6%    64   �� *	subject+  5      $ Courtier��6%    67   �� *id_af458_brokers+  5      $ Client��6%    65   �� *id_af458_customers+5      �� 5   
   -   5        $��Modifier��5      $
��Left=�6$   $��587,284,0,0q�6?   $	��Top=�6T   $��75��6l   6w   �� 5   
   -   5        $��	Supprimer��5      $
��Left=�6%   $��462,284,0,0q�6@   $	��Top=�6U   $��75��6m   	 J� RenderTransformOrigin$	 2.719,-0.216&�6x   6�   �� 5   
   -   5        $��Annuler��5      $
��Left=�6#   $��687,284,0,0q�6>   $	��Top=�6S   $��75��6k   6v   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
date_input��5      
   DisplayDate$
  ��6'   $
��Left=�66   $��23��6Q   $��
642,63,0,0q�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $��
hour_input��5      $
��Left=�6$   $��23��6?   $��642,103,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $��52��6�   �� 5   
   -   5        $��minute_input��5      $
��Left=�6&   $��23��6A   $��710,103,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $��52��6�   �� 5   
   -   5        $��subject_input��5      $
��Left=�6'   $��23��6B   $��642,144,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   -	   5        $��brokers_list��5      $
��Left=�6'   $��642,184,0,0q�6B   $	��Top=�6W   $	��120��6o    �� DisplayMemberPath$ lastname��6{   $	 0.483,1.369&�6�   �� 5   
   -
   5        $��customers_list��5      $
��Left=�6)   $��642,226,0,0q�6D   $	��Top=�6Y   $	��120��6q   $ lastname��6}   $	 0.483,1.369&�6�   �� 5   
   $��Date :��6   $
��Left=�6!   $��
462,60,0,0q�6<   $	��Top=�6P   $��75��6h   �� 5   
   $��Heure :��6   $
��Left=�6"   $��462,100,0,0q�6=   $	��Top=�6R   $��75��6j   �� 5    
   $��Sujet :��6   $
��Left=�6"   $��462,141,0,0q�6=   $	��Top=�6R   $��95��6j   �� 5!   
   $��
Courtier :��6   $
��Left=�6%   $��462,181,0,0q�6@   $	��Top=�6U   $	��131��6m   �� 5"   
   $��Client :��6   $
��Left=�6#   $��462,223,0,0q�6>   $	��Top=�6S   $��75��6k   �� 5#   
   -   5        $��error_message��5#      $
��Left=�6)   $��462,348,0,0q�6D   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��328��6�   
���  ��6�   �� 5$   
   $
��Left=�6   $��700,105,0,0q�6/   $
��Wrap=�6D   $��:��6X   $	��Top=�6a   $��5��6y   5%      5&      