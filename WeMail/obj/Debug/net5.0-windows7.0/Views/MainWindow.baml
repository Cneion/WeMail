   M S B A M L   `   `   `  ����A  =WeMail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WeMail.ExtensionsWeMail.Extensions  5          WeMail.Views.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      /extclr-namespace:WeMail.Extensions     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T	 PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5      $
��1000��5
      $	��600��5      ! 	 Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5       � AllowsTransparency$
 True��5         MaterialDesignPaper#���   5        MaterialDesignFont#���  5      $��13(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStyle$
 None=�5       � Title 5	      �� *Title+.��5      )  #MaterialDesignThemes.Wpf.DialogHost     DialogTheme$ Inherit=�5   	      
Identifier$ 
RootDialog��5   	      SnackbarMessageQueue 5   	   �� 	 �� ElementName$	 MainSnackbar��
 �� Path$
 MessageQueue�.��5   
   )  #MaterialDesignThemes.Wpf.DrawerHost  -   5          Name$ 
drawerHost��5   $      IsLeftDrawerOpen 68   �� $	 MenuToggleButton��$
 	IsChecked�   LeftDrawerContent 5      ]� 5      $	��220��6   
������ .+�5       �� $
��0,20q�6!   $	��Top=�6/   .+�5!      �� $��50��5"      $��50��5#      $��/Images/qq鼠标垫.jpg��5$       J� Clip 5%      @� 5&   "    @� Center$ 25,25&�5'   %    @� RadiusX$ 25Q�5(   %    @� RadiusY$ 25Q�5)   %   5+      �� 5,      $
��0,10q�5-      $��Center=�5.      $��Cneion��5/      50      �� 52      -   5         ��Name$ menuBar��53        MyListBoxItemStyle#��[ 54      ��55      �� *
MenuBars+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 56      +  %Microsoft.Xaml.Behaviors.EventTrigger  57         	EventName$ SelectionChanged��6-   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 58   "   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 68   �� *NavigateCommand+   CommandParameter 6\   �� $	 menuBar��$
 SelectedItem�59      ��5<      �� 5=      .R�5>   "   �� $��Center=�5?   %   
������  �� Orientation$ 
Horizontal=�5A   %   .+�5B   &   '	  !MaterialDesignThemes.Wpf.PackIcon	  $
��15,0q�6>    	  Kind 6L   �� *Icon+�� 5C   &   $
��10,0q�60   ��6>   �� *Title+5D   #   5E      5G      5H      .��5K      ]� .+�5L      (
  "MaterialDesignThemes.Wpf.ColorZone
  -   5         
 Name$ 	colorZone��5M      $��10q�5N      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5O      $	��Top=�5P       
  Mode$ 
PrimaryMid=�5Q      .��5R      ]� $��False��6    .+�5T      �� $ 
Horizontal=�6%   .+�5U      d� -   5         d�Name$ MenuToggleButton��5V   !   4  .System.Windows.Automation.AutomationProperties   Name$ HamburgerToggleButton��5W   !    d� 	IsChecked$ FalseY�5X   !    ' #MaterialDesignHamburgerToggleButton#��[ 5Y   !   �� 5[      $��24,0,0,0q�5\   !     MaterialDesignToolButton#��[ 5b   !     � ToolTip$  Previous Item��5c   !   +  %MaterialDesignThemes.Wpf.RippleAssist!   Feedback! 5]   !   �� " �� RelativeSource" �� *Self+$
 
Foreground�  BrushRoundConverter# �� 	Converter## [ ��5^   !   �� *GoBackCommand+��5_   !   0  *MaterialDesignThemes.Wpf.PackIconExtension  $   Kind$$ 	ArrowLeft=�%   Size% 24��5a   !   �� " �� & �� AncestorType"& �$
 (TextElement.Foreground)�5c   !   �� 5e      $��16,0,0,0q�5f   !   #��[ 5l   !   $  	Next Item��5m   !   ! 5g   !   �� " �� *Self+$
 
Foreground�## [ ��5h   !   �� *GoForwardCommand+��5i   !     $$ 
ArrowRight=�% 24��5k   !   �� " �� "& �$
 (TextElement.Foreground)�5m   !   5o      �� 5q      $��30,0,0,0q�5r      $
��Left=�5s      $��Center=�5t      $% Material Design In XAML Toolkit��5u      $��22(�5v      $��	笔记本��5w      �� 5y      $��Right=�6%   $ 
Horizontal=�6<   .+�5z      �� $��25��5{   !   $��25��5|   !   $��	10,0,10,0q�5}   !   $��/Images/qq鼠标垫.jpg��5~   !    5   "   @� 5�   &   $ 	12.5,12.5&�5�   )   $
 12.5Q�5�   )   $
 12.5Q�5�   )   5�      �� 5�      -   5        ' ��Name$' btnMin��5�   !    ! MaterialDesignFlatMidBgButton#��[ 5�   !   ��5�   !     $$ WindowMinimize=�% 245�   !   �� 5�      -   5        $' btnMax��5�   !   #��[ 5�   !   ��5�   !     $$ WindowMaximize=�% 245�   !   �� 5�      -   5        $' btnCls��5�   !   #��[ 5�   !   ��5�   !     $$ WindowClose=�% 245�   !   5�      5�      5�      �� 5�      $   WeMail.Extensions.PrismManager(   MainViewRegionName! 	 Prism.Regions.RegionManager)   
RegionName#) Z( 6!   5�      5�      5�      5�      