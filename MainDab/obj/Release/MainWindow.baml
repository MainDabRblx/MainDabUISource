   M S B A M L   `   `   `  ���� B  >MainDab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MainDabMainDab  H DWPF.Bootstrap, Version=0.0.5.0, Culture=neutral, PublicKeyToken=nullV;clr-namespace:WPF.Bootstrap.Controls;assembly=WPF.BootstrapWPF.Bootstrap.Controls     MainDab.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MainDab     _ [ICSharpCode.AvalonEdit, Version=6.0.1.278, Culture=neutral, PublicKeyToken=9cc39be672370310?
avalonedit.http://icsharpcode.net/sharpdevelop/avalonedit  FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6dragablz'http://dragablz.net/winfx/xaml/dragablz  JControls;clr-namespace:WPF.Bootstrap.Controls;assembly=WPF.Bootstrap  -     � Title$  MainDab�� � Topmost .  $��448.077��$��903.706�� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������  � Icon$ MainDabLogo.png�� � 	Resources  �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName   FocusVisual J� SnapsToDevicePixels �� StrokeDashArray  ButtonStyleNoHighlighting'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState �� Color  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonStyle1 ��Name  ButtonStyle2  TabItem.Selected.Background  RoundButton  Tabs $  SystemColors.ControlTextBrushKey �Name-  'System.Windows.Input.KeyboardNavigation   TabNavigation � ColumnDefinitions ��Name � RowDefinitions ��Name ��Name �� Orientation ��Name  K� IsItemsHost!   TabIndex" K� ZIndex#   DirectionalNavigation  TextEditorStyle1'  !ICSharpCode.AvalonEdit.TextEditor$$   HorizontalScrollBarVisibility"%   VerticalScrollBarVisibility& �� RelativeSource  SystemButton  Tab' �� AncestorType( ��Name) ^� 
Conditions* �� Binding+ �� Value 	 Tabs2��%�  '��       &	  -    &	 {    &	 �    &	     &	     &	 1    &	 F    &	 [    &	 p    &		 �    &	
 �    &	 �    7   7  7  7  7  7  7  7  7 	 7 
 &	 p    7   7  7  7  7 	 7 
 &	 %	    &	 :	    7  7  7  7  &	 ?    7  &	     &	 �    &	 w    &	     �� " ��.���  � ��	 �� "
 ��.R��� ._�� .+�� .+��� $ border��$ 3,3,0,0��
��������� $��Header��#��z��#��z�� P�  �@J�IsMouseOver . . ��� $ border�� � ��	 �	#FF282828P�  �@��
IsSelected . . ��� $ border�� � ��	 �	#FF282828�� .���  � ��	 �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� " ��.���  � ��	 �� "
 ��.R�� #��z��   CommonStates��.   
Normal��  	MouseOver���� $ 	#00ffffff���� $ 	#FF707070���� $ 	#FF202020���� $ 	#FF3C7FB1���� $ 	#FF121212���� $ 	#FF2C628B���� $ 	#ff181818���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8	   ��  � ��8	  ��  � ��8	  ��  � ��#	 � ����  � ��$	 1q���  � ��$	 Center=���  � ��$	 Center=���  � ��$	 1q���  � ��	 �� "
 ��.R��� $ border��#��z��#��z��#��z�� . ._�� $
��Auto��$
��Auto��$��2q�.+��� $ contentPresenter��|�.  #��z��#��z����. # z #��z��F� ����        р�� ��� 	$��10��$��10��$��1��
�������$��0.562,0.562,0.437,0.437q�F� ����    ��� р��     	$��10��$��10��$��1��
�������$��0.562,0.562,0.437,0.437q� P�  �@��IsDefaulted . . ��� $ border��#	 � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8	   � ���� $ border��8	   � ��P�  � �� . . ��� $ border��8	   � ���� $ border��8	   � ��P�  � {� .  . ��� $ border��8	   � ���� $ border��8	   � ���� $ contentPresenter��8	 	  � ���� " ��.���  �@�FocusVisualStyle8	   ��  � ��8	  ��  � ��8	  ��  � ��#	 � ����  � ��$	 1q���  � ��$	 Center=���  � ��$	 Center=���  � ��$	 1q���  � ��	 �� "
 ��.R��� $ border��$ 3��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��#	 � �� � ��P�  �@J�IsMouseOver . . ��� $ border�� � ��	 �#1D1D1DP�  � �� . . ��� $ border�� � ��	 �#1A1A1AP�  � {� .  . ��� $ border��8	   � ���� $ border��8	   � ���� $ contentPresenter��8	   � ���� $ 	#40ffffff���� " ��.���  �@�FocusVisualStyle	 Z� ��  � ��8	   ��  � ��	 �	#FFFFFFFF��  � ��$	 1q���  � ��$	 Center=���  � ��$	 Center=���  � ��$		 6 1q���  � ��	 �� "
 ��.R��� $ border��#��z�� . $ 2��._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@J�IsMouseOver . . ��� $ border��8	   � ��P�  � �� . . ��� $ border��8	   � ��P�  � {� .  . ��� $ border��8	   � ���� " ��.���  � ��$	 2q���  � ��$	 Center=���  � ��$	 Center=���  � ��8	   ��  � ��$	 0q���  � ��#	 �  ��  � ��	 �� "
 ��.R�� $ templateRoot��}�.  . $ Local=� �� $ ColumnDefinition0���� $ ColumnDefinition1��$��0 � �� $ RowDefinition0��$
��Auto ��� $ RowDefinition1��$��* �.+��� $ TabScrollViewer��$��Disabled=����	#00FFFFFF$��Hidden=�}�. .���� $ 
Horizontal=�.+��� $ headerPanel�����	#00FFFFFF  . $! 1��$" 1��$��0 2 0 0q��� $ contentPanel��#��z��#��z��#��z��$��0��$# 	Contained=�$��1��$! 2��$ Local=�._��� $ PART_SelectedContentHost��$��SelectedContent��#��z��# z �� "  .���  � ��#	 � ����  � ��#	 � ����  � ��$	 LeftToRight=���  � ��	 �� "
  .R��� #��z��#��z��#��z��._��� $ PART_ScrollViewer����. |�.  $
��Left=�#��z$ #��z��#��z% $	��Top=����� *
TextArea+& �� *TemplatedParent+ P�  �@ WordWrap . . ��� $ PART_ScrollViewer�� � ��$	 Disabled=��� " ��.���  �@�FocusVisualStyle	 Z� ��  � ��	 �#111111��  � ��	 �	#FFFFFFFF��  � ��$	 1q���  � ��$	 Center=���  � ��$	 Center=���  � ��$		 6 1q���  � ��	 �� "
 ��.R��� $ border�����#161616 . $ 6��._��� $ ContentPres��|�.  #��z��#��z����. # z #��z�� P�  �@J�IsMouseOver . . ��� $ border�� � ��	 �#131313P�  � �� . . ��� $ border�� � ��	 �#101010�� " ��.���  �@�FocusVisualStyle	 Z� ��  � ��	 �	#FFFFFFFF��  � ��$	 0q���  � ��$	 6,2,6,2q���  � ��$	 Stretch=���  � ��$	 Stretch=���  � ��	 �� "
 ��.R�� $ templateRoot�� . ���#181818.+��� $ 
mainBorder��#��z��$ 3 3 0 0��$��0q����#2A2A2A$��0q��� $ 
Horizontal=�.+��� $ contentPresenter��$��Header��|�.  #��z����. # z ���� *HorizontalContentAlignment+& �� "' ������ *VerticalContentAlignment+& �� "' ���� $( CloseButton��$��-3 3 3 3q�$��0q�$��13��$��13��#���  .��� .+�F� ���	#FFFFFFFF$��1������        �@KL @KL 	F� ���	#FFFFFFFF$��1������    @KL �@KL     	 ^� ) �� * �� *IsMouseOver+& �� *Self++ true�� * �� *
IsSelected+& �� *Self+	+ false�� * �� *TabStripPlacement+& �� "' ��+ Top.0��� $ 
mainBorder�� � ��	 �#181818^� ) �� * �� *
IsSelected+& �� *Self++ true�� * �� *TabStripPlacement+& �� "' ��+ Top.0���  �@K�ZIndex$	 1���� $ 
mainBorder�� � ��	 �#1F1F1F�� " ��.���  � ��$	 2q���  � ��$	 Center=���  � ��$	 Center=���  � ��$	 0q���  � ��	 �� "
 ��.R�� $ templateRoot��}�.  . $ Local=� �� $ ColumnDefinition0���� $ ColumnDefinition1��$��0 � �� $ RowDefinition0��$
��Auto ��� $ RowDefinition1��$��* �.+��� $ TabScrollViewer��$��Disabled=����	#00FFFFFF$��Hidden=�}�. .���� $ 
Horizontal=�.+��� $ headerPanel�����	#00FFFFFF  . $! 1��$" 1��$��0 2 0 0q��� $( AddTabButton��$��15��$��15��$��4q�$��0q�#���  .��� .+�F� ���	#FFFFFFFF$��1������     �D �@T�  �D 	F� ���	#FFFFFFFF$��1������ �D     � �D @T� 	�� $ contentPanel��#��z��#��z��#��z��$��0��$# 	Contained=�$��1��$! 2��$ Local=�._��� $ PART_SelectedContentHost��$��SelectedContent��#��z��# z .���� -   $	 UIB��
������ $ 4��$��0,0,54,15.333q�, J� RenderTransformOrigin$, 0.755,0.806&�._�� $
��Left=�$	��578��
������ $	��320��$��57,22,0,-32q�$	��Top=� �� $
��105* ��� $��246.833 ��� $
��96.5 ��� $	��76* ��� $��36 ��� $��11.333 ��� $��6.667 � �� $��0* ��� $��0* ��� $
��Auto ��� $
��115* ��� $	��10* ��� $	��29* ��� $��6* ��� $	��66* ��� $��0* �.+��� -   - ��Name$- Border��
������ $
��Left=�$	��274��$��
-4,-13,0,0q�
������ $	��Top=�$	��578��$��7��$��8��$, 0.5,0.5&�z�V� .~��� �� . �� AngleX$. 0.346Q��� / �� Angle$/ -179.986Q�T� 0 T� X$0 0.827Q�� -   $ 	BottomBar��$
��Left=�$	��249��$��0,9,0,0q�$��2��$	��Top=�$��571.333�����	#FF19191A$��6��$��6��1 � UseLayoutRounding1 .  �� -   2 ��Name$2 TopBar��$��0.003,-10.669,0,0q�$��2��$��MainDab��$
��Left=�$	��Top=�
�������$��571.223�����	#FF282828$��27.666��$, 0.5,0.5&�$��16(�$��6��$��Calibri)�1 .  z�V� .~��� �� �� $/ -0.16Q�T� �� -   $
( Exit��$��0q����	#FFFF0505$��Right=�$��0,-7,7.334,86.667q�$��13��#���  $��2��$��15��$��Bottom=�$��2��$��4��1 .  o� -   3 o�Name$
3 Menu��$��21��$��	45,15,0,0q�$��3��$	��Top=����	#FF232323$��6��$
��Left=�$��526.333��1 .  ��Z� .@�m� -   4 m�Name$4 FileMenu��$
��File��$��21��$��33��
�������$��0q�.@�m� -	   $4 MenuKillRblx��$��Kill Roblox��$
��Left=�$��21��$	��175�����	#FF2D2D2D$��0q�$��-24,0,-11,0q�m� -
   $4 MenuOpenFile��$��	Open File��$
��Left=�$��22��$	��213�����	#FF2D2D2D$��0q�$��-24,0,-49,0q�m� -   $4 MenuSaveFile��$��Upload to Pastebin��$
��Left=�$��22��$	��217�����	#FF2D2D2D$��0q�$��-24,0,-53,0q�m� -   $4 ExecutionMenu��$��	Execution��$��21��$��60��
�������$��0q�.@�m� -   $4 MenuExec��$��Execute��$
��Left=�$��21��$	��169�����	#FF2D2D2D$��0q�$��
-25,0,-4,0q�m� -   $4 	MenuClear��$��Clear��$
��Left=�$��22��$	��179�����	#FF2D2D2D$��0q�$��-26,0,-13,0q�m� -   $4 
MenuInject��$��Inject��$
��Left=�$��22��$	��179�����	#FF2D2D2D$��0q�$��-26,0,-13,0q�m� -   $4 
UsefulMenu��$��Useful Tools��$��21��$��77��
�������$��0q�.@�m� -   $4 	FPSUNLOCK��$��FPS Unlocker��$
��Left=�$��21��$	��199�����	#FF2D2D2D$��0q�$��-26,0,-33,0q�m� -   $4 	MultiRblx��$��Multiple Roblox��$
��Left=�$��22��$	��189�����	#FF2D2D2D$��0q�$��-27,0,-22,0q�m� -   $4 ReinstallRblx��$��Reinstall Roblox��$
��Left=�$��22��$	��178�����	#FF2D2D2D$��0q�$��-28,0,-10,0q�m� -   $4 RblxTaintLogs��$��Roblox Taint Logs��$
��Left=�$��20��$	��207�����	#FF2D2D2D$��0q�$��-28,0,-39,0q�m� -   $4 RedownloadMainDab��$��Redownload MainDab��$
��Left=�$��22��$	��218�����	#FF2D2D2D$��0q�$��-28,0,-50,0q�$��10(�m� -   $4 
SelectMenu��$��
Select DLL��$��21��$��68��
�������$��0q�.@�m� -   $
4 DLL2��$��EasyExploits API��$
��Left=�$��20��$	��173�����	#FF2D2D2D$��0q�$��
-25,0,-8,0q�m� -   $
4 DLL3��$��Arch API��$
��Left=�$��20��$	��173�����	#FF2D2D2D$��0q�$��
-25,0,-8,0q�m� -   $
4 DLL4��$��	WeAreDevs��$
��Left=�$��21��$	��233�����	#FF2D2D2D$��0q�$��-25,0,-68,0q�m� -   $4 
DLL4_Copy1��$��MainDab LBI��$
��Left=�$��20��$	��233�����	#FF2D2D2D$��0q�$��-25,0,-68,0q�m� -   $4 	DLL3_Copy��$��
Custom DLL��$
��Left=�$��20��$	��173�����	#FF2D2D2D$��0q�$��
-25,0,-8,0q�m� -   $4 HelpMenu��$
��Help��$��21��$��35��
�������$��0q�.@�m� -   $4 JoinDiscord��$��Get support (Discord)��$
��Left=�$��22��$	��239�����	#FF2D2D2D$��0q�$��-28,0,-71,0q�m� -   $4 Credits��$��Credits
��$
��Left=�$��21��$	��178�����	#FF2D2D2D$��0q�$��-27,0,-11,0q�m� -   $4 ExtensionsMenu��$��
Extensions��$��21��$��65��
�������$��0q�
������ $, 0.5,0.5&�z�V� .~��� �� �� $/ -0.528Q�T� m� -    $4 ExtensionsMenu_Copy1��$��	Sniff Hub��$��21��$��58��
�������$��0q�
������ $, 0.5,0.5&�z�V� .~��� �� �� $/ -0.122Q�T� m� -!   $4 ExtensionsMenu_Copy��$��Themes��$��21��$��63��
�������$��0q�
������ .@�m� -"   $4 Credits_Copy��$��Default
��$
��Left=�$��21��$	��178�����	#FF2D2D2D$��0q�$��-27,0,-11,0q�m� -#   $4 Credits_Copy1��$��Royal Purple
��$
��Left=�$��21��$	��178�����	#FF2D2D2D$��0q�$��-27,0,-11,0q�m� -$   $4 Credits_Copy2��$��Crimson Red
��$
��Left=�$��18��$	��178�����	#FF2D2D2D$��0q�$��-27,0,-11,0q�m� -%   $4 Credits_Copy3��$��Purity Blue��$
��Left=�$��23��$	��178�����	#FF2D2D2D$��0q�$��-27,0,-11,0q�m� -&   $4 Credits_Copy5��$��MainDab Green��$
��Left=�$��23��$	��178�����	#FF2D2D2D$��0q�$��-26,0,-12,0q�m� -'   $4 	LoadTheme��$��
Load Theme��$��21��$��78��
�������$��0q�
������ {�.  $y�Hidden=�.@�m� -(   $4 LoadThemeButton��$��
Load Theme��$
��Left=�$��21��$	��162�����	#FF2D2D2D$��0q�$��	0,0,-22,0q�m� -)   $4 UnloadThemeButton��$��Unload Theme��$
��Left=�$��21��$	��162�����	#FF2D2D2D$��0q�$��	0,0,-22,0q�  -*   5  Name$5 
textEditor��$��Consolas)�$��13(�{�. 6   
IsReadOnly6 .  7   WordWrap7 . $
$ Auto=�$
% Auto=�8   LineNumbersForeground
8 �����9   ShowLineNumbers9 . 
�������: J� OpacityMask
: �   �$��199.303�����	#FF151515$��Center=�$��524.445��$��Center=�$ ��45.665,34.575,1.223,14.122q�;   Text$?; 9-- MainDab V11 Loaded! Join MainDab at discord.io/maindab��$��2��$��6��$, 0.5,0.5&�1 .  $��4��.; z�V� .~��� �� < �� AngleY$< 0.098Q��� T� = T� Y$= 0.332Q�.;  � -+   >  �Name$> 	LeftFrame��$��
��$
��Left=�$	��219��$��0,15,0,0q�$��6��$	��Top=�$��45�����	#FF2323231 .  �� -,   $( 
MiniButton��$��0q����	#FFFFFBFB$��9,-6,13,86.667q�#���  $��2��$, -1.795,0.564&�$��4��$��14��$��Bottom=�1 .   ��%9   '��       �� " ��.���  �@��CornerRadius$	 5��? � BindingGroup? &   System.Windows.Data.BindingGroup  z�V� .~��� �� �� $/ -0.378Q�T� �� --   $2 SelectedAPILabel��$��Selected API : Arch API��$
��Left=�$��3.167,14.333,0,0q�$��5��$	��Top=�$��24��
�������$��211.11��$��10(�$��2��$��4��$��Right=�$��Consolas)�1 .  $��3���� -.   @ ��Name$@ ExecuteButton��$
��Left=�$��39��$��1,12,0,0q�$��3��$	��Top=�$��42��$, 
0.13,0.354&�$��	nigge.png��$
��Fill=�1 .  z�V� .~��� �� $< 0.285Q��� $/ -0.384Q�T� $0 -0.001Q�$= -0.126Q��� -/   $
��Left=�$��20��$��	12,51,0,0q�$��3��$	��Top=�$��20��$, 
0.13,0.354&�$��
delete.png��$
��Fill=�1 .  �� -0   $
��Left=�$��21��$��	12,81,0,0q�$	��Top=�$��20��$, 
0.13,0.354&�$��
folder.png��$
��Fill=�$��2��$��2��1 .  �� -1   $��Right=�$��22��$��0,17.333,72.667,0q�$	��Top=�$��21��$, 
0.13,0.354&�$��syringe.png��$
��Fill=�$��3��1 .  �� -2   $
��Left=�$��22��$��11,47.333,0,0q�$	��Top=�$��23��$, 
0.13,0.354&�$��web-programming.png��$
��Fill=�$��3��1 .  � -3   $ 	ScriptHub��$��6��$
��Left=�$	��161��$��7,-13,-222.333,0q�$��4��$	��Top=�$	��222�����	#FF2323231 .  .+�A� -4   ���	#FFC30000$
��Left=�$��14��$��	206,3,0,0q�
���   �$	��Top=�$��14��$��0���� $��
Script Hub��$
��Left=�$��37��$��0,-1,0,0q�$	��Top=�$	��103��
��������� -5   A ��Name$A listbox��$
��Left=�$	��130��$��8,24,0,0q�$	��Top=�$	��109�����	#FF2D2D2D$��0q�$��Hidden=�$��Hidden=�
��������� -6   B ��Name$B richfuckbox��$
��Left=�$	��103��$��
122,24,0,0q�$	��Top=�$��90��$��0q�
����������	#FF2D2D2DC �� 
IsReadOnlyC . . �/� .T�J� .*�.*��� $#�Script Description goes here.��J� .*�.*��� �� -7   $��Execute��$
��Left=�$��22��$��122,132,0,0q�$	��Top=�$��90�����	#FF2D2D2D
�������$��0q�(  "System.Windows.Controls.WebBrowser  -8   D  Name$	D sex��$��1��$
��Left=�$��0��$��
77,-14,0,0q�$	��Top=�$��1��$, 0.5,0.5&�1 .  z�V� .~��� E �� ScaleX$E -1Q��� �� T� � -9   $ custom��$��6��$
��Left=�$	��100��$��7,63.333,-222.333,0q�$��3��$	��Top=�$	��222�����	#FF2323231 .  $��5��.+��� $��Custom DLL Injection��$	��Top=�$, 0.228,-0.103&�$��25��$��1,0,10,0q�
�������A� -:   ���	#FFC30000$
��Left=�$��15��$��	205,3,0,0q�
���   �$��0��$	��Top=�$��15���� -;   F ��Name$
F Pipe��$
��Left=�$��19��$��6,49,0,0q�G �� TextWrapping$
G Wrap=�$��DLL Pipe (EX. MainDab)��$	��Top=�$	��206��
����������	#FF2D2D2D$��0q��� -<   $F DLLNAME��$
��Left=�$��19��$��6,26,0,0q�$
G Wrap=�$ ��DLL Name (EX. MainDab.dll)��$	��Top=�$	��206��
����������	#FF2D2D2D$��0q��� -=   $��Apply��$
��Left=�$��	68,73,0,0q�$	��Top=�$��75��$��20�����	#FF2D2D2D
�������$��0q�]� $
��Left=�$	��100����.  $��4��$	��Top=�$	��100��1 .  �� ->   $
��Left=�$��22��$��11,78.333,0,0q�$	��Top=�$��22��$, 
0.13,0.354&�$��IconRoblox.png��$
��Fill=�$��3��1 .  �� -?   $2 SyntaxLabel��$��No errors found.��$
��Left=�$��0,13.583,0,0q�$��5��$	��Top=�$��24��
�������$	��313��$��10(�$��Consolas)�$��UltraCondensed&�$��Medium"�$��2��1 .  $��3���� -@   $@ ExecuteButton_Copy��$
��Left=�$��19��$��3,112.333,0,0q�$	��Top=�$��19��$, 
0.13,0.354&�$��Discord-Logo-White.png��$
��Fill=�$��3��1 .  $��3��z�V� .~��� �� $< 0.285Q��� $/ -0.384Q�T� $0 -0.001Q�$= -0.126Q��� -A   $@ ExecuteButton_Copy1��$
��Left=�$��15��$��24,113.333,0,0q�$	��Top=�$��15��$, 
0.13,0.354&�$ ��GitHub-Mark-Light-64px.png��$
��Fill=�$��3��1 .  $��3��z�V� .~��� �� $< 0.285Q��� $/ -0.384Q�T� $0 -0.001Q�$= -0.126Q��� -B   $2 SelectedAPILabel_Copy��$2��,Using MainDab V12 | MainDab by Main__EX#3898��$
��Left=�$��-14,25.583,0,0q�$��5��$	��Top=�$��24��
�������$	��119��$��4(�$��Right=�$��Consolas)�1 .  $��2��$��3���� -C   $2 SelectedAPILabel_Copy1��$�� ��$
��Left=�$��0.333,28.333,0,0q�$��5��$	��Top=�$��24��
�������$	��119��$��4(�$��Right=�$��Consolas)�$��3��$��3��1 .  $��3���� -D   $@ ExecuteButton_Copy2��$
��Left=�$��15��$��	35,18,0,0q�$	��Top=�$��16��$, 
0.13,0.354&�$��list.png��$
��Fill=�$��2��$��4��$��3��1 .  z�V� .~��� $E -1Q��� $< 0.285Q��� $/ -0.384Q�T� $0 -0.001Q�$= -0.126Q��� -E   $A fuckbm2��$	��Top=�$��2��$��4�����	#FF232323$��Hidden=�
�������$, 0.5,0.5&�$��0,36,2.333,0q�$	��198��$��0q�$��3��$��3��$��Hidden=�H J� Opacity$	H 0.8Q�$y�Hidden=���.  ��Z� 