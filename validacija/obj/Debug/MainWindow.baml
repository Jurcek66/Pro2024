   M S B A M L   `   `   `  ����E  Avalidacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:validacija
validacija  5   	       validacija.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:validacija     5   	     � Title$  
MainWindow��5   	   $	��366��6   $	��470��6)    � 	Resources 5	        validacija.nakupkarte 	  nakup  
napakaStil �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%�   &	        &	        5
   
   6   �� 5   
   " ��6#    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   �� $
��Left=�6   $��	40,40,0,0q�6/   $
��Wrap=�6B   $��Dogodek��6V   $	��Top=�6e   �� 5   
   $
��Left=�6   $��	40,80,0,0q�6/   $
��Wrap=�6B   $��Številka kupca��6V   $	��Top=�6l   �� 5   
   $
��Left=�6   $��
40,120,0,0q�6/   $
��Wrap=�6C   $��Status��6W   $	��Top=�6e   �� 5   
   $
��Left=�6   $��
40,160,0,0q�6/   $
��Wrap=�6C   $��Število kart��6W   $	��Top=�6k   �� 5   
   $
��Left=�6   $��
178,37,0,0q�6.   $	��Top=�6B   $	��120��6Z   #���  6�    �� Text 6f   �� *
Imedogodka+ �� Mode$ TwoWay=� �� Source# [   �� ValidatesOnExceptions . .@�5      �� �� 5      $��AC/DC��6   �� 5      $��Rok Otočec��6   �� 5      $��
Omar Naber��6   �� 5      $��
Adi Smolar��6   5       �� 5!   
   $
��Left=�6   $��
178,80,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6�   $	��120��6�   #���  6�   ��6U   �� *
Štkupca+$ TwoWay=�# [   . 6�   �� 5"   
   $
��Left=�6   $��178,128,0,0q�6.   $	��Top=�6C   $	��120��6[   #���  6�    6g   �� *Nivo+$ TwoWay=�# [   . .@�5#      �� $��Standard��6   �� 5$      $��Premium��6   �� 5%      $��	Executive��6   �� 5&      $��Premium executive��6   5'      �� 5(   
   -   5         ��Name$ sldštevilo��5(      $
��Left=�6%   $��178,160,0,0q�6@   $	��Top=�6U   $	��120��6m    � SmallChange$ 1Q�6y    �� IsSnapToTickEnabled . #���  6	   � Value 6�   �� *ŠtVstopnic+$ TwoWay=�# [   . 6	  �� 5)   
   -   5         ��Name$	 box��5)      $
��Left=�6   $��330,160,0,0q�6:   $
 Wrap=�6O   $	��Top=�6�   $	��120��6�   ��6c   �� *Value+ �� ElementName$ sldštevilo��6�   �� 5*   
   -   5         ��Name$ nakup��5*      $��Nakup��6    $
��Left=�60   $��
38,218,0,0q�6K   $	��Top=�6_   $��37��6w   $��61��6�   5+      5,      