   M S B A M L   `   `   `  ����G  CDemoCommands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DemoCommands.CommandsDemoCommands.Commands  5      7 clr-namespace:DemoCommands.ModelDemoCommands.Model  5      +clr-namespace:DemoCommandsDemoCommands  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5
          DemoCommands.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      >CustomCommands#clr-namespace:DemoCommands.Commands     5      2Model clr-namespace:DemoCommands.Model     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:DemoCommands     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	      9system&clr-namespace:System;assembly=mscorlib     5
        � Title$  
MainWindow��5      $	��525��5      $	��350��5       � DataContext 5      )   #DemoCommands.Model.StringRepository  5   
    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$/ )CustomCommands:ReportCommands.PrintReport��5      5        5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      5      .��5!      ]� .+�5"   
   o� $	��Top=�6   .@�5#      m� $
��File��6   .@�5$      m�  m� Command$
 Open��6   $
��Open��6*   m� 5%      $
 Save��6   $
��Save��6*   �� 5&      m� 5'      $��Close��6   5(      m� 5)      $��Report��6   .@�5*      m� *   $DemoCommands.Commands.ReportCommands   CreateReport# Z 6   m� 5+         PrintReport# Z 6   5,      m� 5-      $
��Edit��6   .@�5.      m� $
 Copy��6   $
��Copy��6*   m� 5/      $	 Cut��6   $	��Cut��6)   m� 50      $ Paste��6   $��Paste��6+   51      52      `� 53   
   $	��Top=�6   .�54      c� .@�55      �� $
��Open��56      $
��Open��58      ��57      ��  �� RelativeSource �� *Self+ �� Path$ Content�58      �� 59      $
��Save��6   $
��Save��6(   �� 5:      $��Close��6   5;      c� 5<      .@�5=      �� $
��Copy��5>      $
��Copy��5@      ��5?      �� 	 �� ElementName$	 
tbMainText��5@      �� 5A      $	��Cut��5B      $	��Cut��5D      ��5C      �� $	 
tbMainText��5D      �� 5E      $��Paste��5F      $��Paste��5H      ��5G      �� $	 
tbMainText��5H      5I      c� 5J      .@�5K      �� #��Z 6   $��Create Report��6Y   �� 5L      #��Z 6   $��Print Report��6X   5M      c� 5N      .@�5O      �� $��2��5Q      $��Add GUID��5R      ��5P      �� *
AddCommand+5R      5S      5T      �� 5U   
   $	��150��5V      $��5q�5W      ��5X      �� *
Collection+�� 5Y   
   -   5        
 ��Name$
 
tbMainText��5Y      $��5q�6&   5Z      5[      