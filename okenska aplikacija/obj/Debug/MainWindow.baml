   M S B A M L   `   `   `  ����M  Iokenska aplikacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:okenska_aplikacijaokenska_aplikacija  5   	   #    okenska_aplikacija.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:okenska_aplikacija     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         mojstil �� 
TargetType �� Property �� Value 	 radio��%�   &	        &	 v     �� 5
   
   " ��6    .�5      ��  � ��$ 
Comic Sans)�6+   �� 5       � ��
 ����6+   5      �� 5   
   " 	�6   .�5      ��  � ��$ 0,10,0,0q�6'   5      5      .��5      � $��0,0,0,3q�6   .+�5   
   �� -   5         ��Name$ prvaST��5      $
��Left=�6"   $��
143,54,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   #���   6�   �� 5   
   -   5        $ drugaST��5      $
��Left=�6#   $��143,130,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   #���   6�   �� 5   
   -   5        $ rezultat��5      $
��Left=�6$   $��	143,0,0,0q�6?   $
 Wrap=�6R   $��Center=�6f   $	��120��6�   #���   6�    �� 
IsReadOnly . 6�   �� 5   
   $��Prvo število��6   $
��Left=�6'   $��	33,50,0,0q�6B   $	��Top=�6U   �� 5   
   $��Drugo število��6   $
��Left=�6(   $��
33,126,0,0q�6C   $	��Top=�6W   �� 5   
   $��Rezultat��6   $
��Left=�6#   $��33,0,0,0q�6>   $��Center=�6P   �� 5   
   -   5         ��Name$ 
izračunaj��5      $��
Izračunaj��6$   $
��Left=�68   $��104,347,0,0q�6S   $	��Top=�6h   6�   �� 5   
   $��Izhod��6   $
��Left=�6!   $��279,347,0,0q�6<   $	��Top=�6Q   �� 5   
   $��GroupBox��6   $��320,49,330,217q�6%   .��5      �� .+�5      	� -   5        	 	�Name$	 seštevanje��5      $��Seštevanje��62   #���  6G   
 d� 	IsChecked$

 TrueY�6g   	� 5      -   5        $	 odštevanje��5      $��Odštevanje��62   #���  6G   	� 5      -   5        $	 	Množenje��5      $��	Množenje��60   #���  6C   	� 5       -   5        $	 deljenje��5       $��Deljenje��60   #���  6C   5!      5"      �� 5#   
   -	   5         ��Name$ neg_vr��5#      $(��"Pobarvaj če je vrednost negativna��6#   $
��Left=�6O   $��320,238,0,0q�6j   $	��Top=�6   5$      5%      