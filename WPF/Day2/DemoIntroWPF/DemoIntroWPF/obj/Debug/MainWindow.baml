   M S B A M L   `   `   `  ����G  CDemoIntroWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DemoIntroWPFDemoIntroWPF  5   	   ;"clr-namespace:DemoIntroWPF.HelpersDemoIntroWPF.Helpers  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       DemoIntroWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DemoIntroWPF     5   	   6Helpers"clr-namespace:DemoIntroWPF.Helpers     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   ��5      �� 5   
   -   5         ��Name$ Layout��5      .+�5      �� ��5      �� 5       �� Type" ��6   .s�5      ��C#��6,   ��5      WPF��6-   ��5      ADO.NET��61   5      5      �� 5      -   5         ��Name$ lbOsVersion��5      $�� ��6)   66   �� 5        System.Environment   	OSVersion#��Z 6   6H   �� 5      %   DemoIntroWPF.Helpers.DateHelper   DateNow#��Z 6   6G   �� 5      -   5        $��Button1��5      $��5q�5      $��10,15q�5      
���  ��
������5   /   �� 5      -   5         ��Name$ 	btnSecond��5       
���  ��
������.��5!   )   	Button262   �� 5"      
���  ����5#      �� 5$      -   5        gradient����5&      �  � Color$	 Red��6+    � Offset$ 0Q�67   � 5'      $ Green��6+   $ 1Q�69   � 5(      $ White��6+   $	 0.5Q�69   5*      .��5,      �� 	 �� Orientation$	 
Horizontal=�6   .+�5-      �� .��6   
Click Me6)   �� 5.      .��6   Button6$   5/      50      �� 51      $��Button3��52   9   
���  ��
������55      �� 56      -   5        .��56   .   
���  ��
������	Button45:      5;      5=      