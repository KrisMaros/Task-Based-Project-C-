   M S B A M L   `   `   `  ����J  FFinantialDataUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FinantialDataUIFinantialDataUI  5   	        FinantialDataUI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f42da)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   Y UXceed.Wpf.DataGrid, Version=3.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f43dg*http://schemas.xceed.com/wpf/xaml/datagrid  5   	   )localclr-namespace:FinantialDataUI  5   	     � Title$  
MainWindow��5
   	   $��1082.377��6   $��1015.335��6.   .��5      � $��1,0,-1,0q�6   .+�5   
   �� -   5         ��Name$ txtView��5      $��
630,22,0,0q�6%   $
��Wrap=�69   $	��Top=�6M   $
��1007��6e   $
��Left=�6s   $	��350��6�    J� RenderTransformOrigin$ 0.346,0.495&�6�   5      �� 5   
   -   5         ��Name$ button��5      $��Display option 1��6!   $
��Left=�6<   $��
121,19,0,0q�6W   $	��Top=�6k   $��99��6�   $��23��6�   �� 5   
   -   5        $ button1��5      $��Display option 2��6"   $
��Left=�6=   $��
121,80,0,0q�6X   $	��Top=�6l   $��99��6�   6�   �� 5   
   -   5        $ button2��5      $��Display option 3��6"   $
��Left=�6=   $��121,141,0,0q�6X   $	��Top=�6m   $��99��6�   6�   �� 5   
   -   5        $ button3��5      $��Display option 4��6"   $
��Left=�6=   $��121,203,0,0q�6X   $	��Top=�6m   $��99��6�   6�   �� 5   
   -   5        $ button4��5      $��Display option 5��6"   $
��Left=�6=   $��121,262,0,0q�6X   $	��Top=�6m   $��99��6�   $ 
0.522,1.66&�6�   6�   �� 5   
   -   5        $ button5��5      $��Display option 6��6"   $
��Left=�6=   $��121,320,0,0q�6X   $	��Top=�6m   $��99��6�   6�   �� 5   
   -   5        $ button6��5      $��Display option 7��6"   $
��Left=�6=   $��121,381,0,0q�6X   $	��Top=�6m   $��99��6�   6�   �� 5   
   -	   5        $ button7��5      $��Display option 8��6"   $
��Left=�6=   $��121,442,0,0q�6X   $	��Top=�6m   $��99��6�   6�   �� 5   
   -
   5        $ button8��5      $��Display option 9��6"   $
��Left=�6=   $��121,503,0,0q�6X   $	��Top=�6m   $��99��6�   6�   �� 5   
   -   5         ��Name$ label��5      $C��=1.The total cost of all orders available in the supplied data��6   $
��Left=�6g   $��	23,42,0,0q�6�   $	��Top=�6�   $	��319��6�   �� 5   
   -   5        $ label1��5      $7��12.The total cost of all orders for a single store��6    $
��Left=�6\   $��
23,105,0,0q�6w   $	��Top=�6�   $	��319��6�   �� 5   
   -   5        $ label2��5      $9��33.The total cost of orders in a week for all stores��6    $
��Left=�6^   $��
23,161,0,0q�6y   $	��Top=�6�   $	��319��6�   �� 5   
   -   5        $ label3��5      $=��74.The total cost of orders in a week for a single store��6    $
��Left=�6b   $��
23,223,0,0q�6}   $	��Top=�6�   $	��319��6�   �� 5   
   -   5        $ label4��5      $2��,5.The total cost of all orders to a supplier��6    $
��Left=�6W   $��
23,282,0,0q�6r   $	��Top=�6�   $	��319��6�   �� 5   
   -   5        $ label5��5      $3��-6.The cost of all orders from a supplier type��6    $
��Left=�6X   $��
23,340,0,0q�6s   $	��Top=�6�   $	��319��6�   �� 5    
   -   5        $ label6��5       $8��27.The cost of orders in a week for a supplier type��6    $
��Left=�6]   $��
23,401,0,0q�6x   $	��Top=�6�   $	��319��6�   �� 5!   
   -   5        $ label7��5!      $:��48.The cost of orders for a supplier type for a store��6    $
��Left=�6_   $��
23,462,0,0q�6z   $	��Top=�6�   $ 0.512,-0.182&�6�   $	��319��6�   �� 5"   
   -   5        $ label8��5"      $D��>9.The cost of orders in a week for a supplier type for a store��6    $
��Left=�6i   $��
23,523,0,0q�6�   $	��Top=�6�   $	��338��6�   �� 5#   
   -   5        $ label9��5#      $��
Store code��6    $
��Left=�65   $��
390,42,0,0q�6P   $	��Top=�6d   $	��119��6|   �� 5$   
   -   5        $ label10��5$      $��Week number��6!   $
��Left=�67   $��390,100,0,0q�6R   $	��Top=�6g   $	��119��6   �� 5%   
   -   5        $ label11��5%      $��Supplier name��6!   $
��Left=�69   $��390,156,0,0q�6T   $	��Top=�6i   $	��119��6�   �� 5&   
   -   5        $ label12��5&      $��Supplier type��6!   $
��Left=�69   $��390,215,0,0q�6T   $	��Top=�6i   $	��119��6�   �� 5'   
   -   5         ��Name$ storeB��5'      $
��Left=�6"   $��23��6=   $��
389,19,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $
��ABE1��6q   $	��Top=�6}   $	��120��6�   �� 5(   
   -   5        $ weekB��5(      $
��Left=�6!   $��23��6<   $��
389,77,0,0q�6H   $
 Wrap=�6\   $��10��6p   $	��Top=�6z   $	��120��6�   �� 5)   
   -   5        $ sNameB��5)      $
��Left=�6"   $��23��6=   $��389,133,0,0q�6I   $
 Wrap=�6^   $��Muller��6r   $	��Top=�6�   $	��120��6�   �� 5*   
   -   5        $ sTypeB��5*      $
��Left=�6"   $��23��6=   $��389,192,0,0q�6I   $
 Wrap=�6^   $��	Groceries��6r   $	��Top=�6�   $	��120��6�   �� 5+   
   -   5        $ button9��5+      $��Browse for store files��6"   $
��Left=�6C   $��389,247,0,0q�6^   $	��Top=�6s   $	��127��6�   6�   �� 5,   
   -   5        $ textBox4��5,      $
��Left=�6$   $��46��6?   $��347,272,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��207��6�   �� 5-   
   -   5        $ button10��5-      $��Browse for stores data��6#   $
��Left=�6D   $��390,325,0,0q�6_   $	��Top=�6t   $	��127��6�   6�   �� 5.   
   -   5        $ textBox5��5.      $
��Left=�6$   $��49��6?   $��347,350,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��207��6�   �� 5/   
   -    5        $ button11��5/      $��All stores view��6#   $
��Left=�6=   $��347,412,0,0q�6X   $	��Top=�6m   $	��207��6�   6�   �� 50   
   -!   5        $ button12��50      $��Supplier types view��6#   $
��Left=�6A   $��347,447,0,0q�6\   $	��Top=�6q   $	��207��6�   6�   �� 51   
   -"   5        $ button13��51      $��All suppliers view��6#   $
��Left=�6@   $��347,488,0,0q�6[   $	��Top=�6p   $	��207��6�   6�   53      54      