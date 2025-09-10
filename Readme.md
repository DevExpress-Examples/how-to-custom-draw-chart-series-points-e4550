<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569601/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4550)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Chart for WPF - How to custom draw chart series points

This example shows how to change the color of each series point according to its values.

In addition, the point labels text is changed to show the color of the current interval (Green, Yellow, or Red).

![](image/chart.png)

To accomplish this, it is necessary to invoke the [ChartControl.CustomDrawSeriesPoint](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.CustomDrawSeriesPoint) event and change its drawing options in the `CorrectDrawOptions()` method.

In this example, you can deactivate the "Custom Draw" option on the stack panel to return to the default appearance of series points.

<!-- default file list -->
## Files to Review

* [MainWindow.xaml](./CS/CustomDrawChart/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomDrawChart/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomDrawChart/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomDrawChart/MainWindow.xaml.vb))
<!-- default file list end -->
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-charts-custom-draw-chart-series-points&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-charts-custom-draw-chart-series-points&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
