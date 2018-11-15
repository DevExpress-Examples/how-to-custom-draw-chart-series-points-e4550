<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomDrawChart/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDrawChart/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomDrawChart/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/CustomDrawChart/MainWindow.xaml))
<!-- default file list end -->
# How to custom draw chart  series points 


<p>This example shows how to change the color of each series point  according to its values. </p><p>In addition, the point labels text is changed to show the color of the current interval (Green, Yellow, or Red).</p><p>To accomplish this, it is necessary to invoke the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_CustomDrawSeriesPointtopic"><u>ChartControl.CustomDrawSeriesPoint</u></a> event and change its drawing options in the CorrectDrawOptions() method.</p><p>In this example, you can deactivate the "Custom Draw" option on the stack panel to return to the default appearance of series points. </p>

<br/>


