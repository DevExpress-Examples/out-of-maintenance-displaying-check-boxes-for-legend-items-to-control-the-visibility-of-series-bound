<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568369/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4484)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Displaying check boxes for legend items to control the visibility of series (bound mode)


<p>This example demonstrates how you can provide each legend item with a check box, which controls the visibility of the corresponding series in the <strong>bound mode (obsolete approach)</strong>.<br />Note that starting with the DXperience version 13.2.1, the chart control supports a built-in check box in the Legend feature. For more details, see the <a href="https://documentation.devexpress.com/#WPF/CustomDocument6343">Legends</a> topic.  </p>
<p>To accomplish this, it is necessary to assign the <strong>Legend.Template</strong> property to custom template and then bind the <strong>ItemsSource</strong> property of the I<strong>temsControl</strong> object to <strong>SeriesNonVisualWrappersCollection</strong>.</p>
<p>This custom collection is synchronized with the diagram's series collection when the <strong> SeriesCollection.CollectionChanged</strong> event fires.</p>
<p>In addition, the fake series source is created in the chart's data source to avoid hiding the legend when the <a href="http://help.devexpress.com/#WPF/DevExpressXpfChartsSeries_Visibletopic"><u>Series.Visible</u></a> property is set to <strong>false</strong> for all series.</p>
<p>See also:</p>
<p>- <a href="http://www.devexpress.com/Support/Center/p/E2409.aspx"><u>How to display custom information in the legend</u></a>;</p>
<p>- <a href="http://www.devexpress.com/Support/Center/Example/Details/E4127"><u>How to display check boxes for legend items to control the visibility of series in the unbound mode</u></a></p>


<h3>Description</h3>

<p>To accomplish this, it is necessary to assign the<strong> Legend.Template</strong> property to custom template and then bind the<strong> ItemsSource</strong> property of the ItemsControl object to <strong>SeriesNonVisualWrappersCollection</strong>.</p>
<p>This custom collection is synchronized with the diagram's series collection when the <strong> SeriesCollection.CollectionChanged</strong> event fires.</p>
<p>In addition, the fake series source is created in the chart's data source to avoid hiding the legend when the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsSeries_Visibletopic"><u>Series.Visible</u></a> property is set to <strong>false</strong> for all series.</p>
<p>&nbsp;</p>

<br/>


