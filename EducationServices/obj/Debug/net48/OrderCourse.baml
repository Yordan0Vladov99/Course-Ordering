   M S B A M L   `   `   `  ����L  HEducationServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EducationServicesEducationServices  5      #    EducationServices.OrderCourse   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EducationServices     5      .��5	      � ���	#FFCECECE$	��450��6"   $��Bottom=�6/     � ColumnDefinitions  5
   
   �� 5      $
��199* �6   �� 5      $
��201* �6    � RowDefinitions 5   
   �� 5      $A��;50                                                        * �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   �� $��Course title��6   $
��Left=�6'   $��10,0,0,0q�6B   $��Center=�6T   $	��203��6o   $��32(�6{   $
��Bold"�6�   �� 5   
   $��Course type��6   $
��Left=�6&   $��10,0,0,0q�6A   $��Center=�6S   $	��203��6n   $��32(�6z   $
��Bold"�6�   $��1��6�   �� 5   
   $��Number of students��6   $
��Left=�6-   $��10,0,0,0q�6H   $��Center=�6Z   $	��332��6u   $��32(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   -   5         ��Name$ 	cboTitles��5      $��1��6&   $��	38,0,47,0q�66   $��53��6I   $��Center=�6U   �� 5   
   -   5        $ cboTypes��5      $��1��6%   $��	38,0,47,0q�65   $��53��6H   $��Center=�6T   $��1��6o   �� 5   
   -   5         ��Name$ txtQty��5       �� TextWrapping$
 Wrap=�6"   $��0��66   $	��120��6?   $��1��6K   $��
38,0,244,0q�6[   $��2��6o   $��53��6|   $��Center=�6�   $��28(�6�    �� TextAlignment$ Right=�6�   �� 5   
   -   5        $��1��5      $��Cancel��65   $
��Left=�6F   $��	38,36,0,0q�6a   $��3��6t   $	��Top=�6�   $��48��6�   $	��270��6�   $��28(�6�   $
��Bold"�6�   �� 5   
   -   5        $��Order��5      $
��Left=�64   $��	10,36,0,0q�6O   $��3��6b   $	��Top=�6o   $��48��6�   $	��270��6�   $��28(�6�   $
��Bold"�6�   5      5       