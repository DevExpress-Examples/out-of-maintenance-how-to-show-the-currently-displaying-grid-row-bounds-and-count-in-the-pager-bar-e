<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128542969/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4267)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to show the currently displaying grid row bounds and count in the pager bar
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4267/)**
<!-- run online end -->


<p>This example demonstrates how to show the currently displayed row range and count in a pager bar.</p><p>To show currently displayed grid items, put the ASPxLabel control into a grid's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewTemplates_PagerBartopic"><u>PagerBar</u></a> template. Then, handle the server-side <a href="ms-help://MS.MSDNQTR.v90.en/fxref_system.web.ui/html/658e894b-5faa-036a-e26c-a50f8eec5176.htm"><u>ASPxLabel.Init</u></a> event to set the label text. Use the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_VisibleStartIndextopic"><u>ASPxGridView.VisibleStartIndex</u></a>  to get the first displayed item index. The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridViewPagerSettings_PageSizetopic"><u>ASPxGridViewPagerSettings.PageSize</u></a> property allows you to get the current page size, and the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_VisibleRowCounttopic"><u>ASPxGridView.VisibleRowCount</u></a> property returns the total item count. I have also checked if the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_PageIndextopic"><u>ASPxGridView.PageIndex</u></a> property is set to "-1",  to indicate if the "All" value was selected into the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument11489"><u>Page Size Item</u></a>.</p><p><strong>See also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/K18282">The general technique of using the Init/Load event handler</a><br />
</p>

<br/>


