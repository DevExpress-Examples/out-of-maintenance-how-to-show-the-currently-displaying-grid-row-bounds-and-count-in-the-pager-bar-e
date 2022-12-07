using System;
using System.Collections.Generic;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void lbCaption_Init(object sender, EventArgs e) {
        ASPxLabel label = sender as ASPxLabel;
        GridViewPagerBarTemplateContainer container = label.NamingContainer as GridViewPagerBarTemplateContainer;

        int firstItem = container.Grid.VisibleStartIndex + 1;
        int lastItem = (container.Grid.PageIndex == -1)
            ? container.Grid.VisibleRowCount
            : Math.Min(firstItem + container.Grid.SettingsPager.PageSize - 1, container.Grid.VisibleRowCount);

        label.Text = String.Format("Displaying items {0} - {1} of {2}", firstItem, lastItem, container.Grid.VisibleRowCount);
    }
}