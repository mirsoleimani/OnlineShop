using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using AjaxControlToolkit;

namespace OnlineShop.Web
{
    public class BaseAdminUserControl:UserControl
{
    public BaseAdminUserControl()

    {
        //
        // TODO: Add constructor logic here
        //
    }
    protected void SelectTab(TabContainer tabContainer, string TabID)
    {
        if (tabContainer == null)
            throw new ArgumentNullException("tabContainer");

        if (!String.IsNullOrEmpty(TabID))
        {
            AjaxControlToolkit.TabPanel tab = tabContainer.FindControl(TabID) as AjaxControlToolkit.TabPanel;
            if (tab != null)
            {
                tabContainer.ActiveTab = tab;
            }
        }
    }
    protected string GetActiveTabID(TabContainer tabContainer)
    {
        if (tabContainer == null)
            throw new ArgumentNullException("tabContainer");

        if (tabContainer.ActiveTab != null)
            return tabContainer.ActiveTab.ID;

        return string.Empty;
    }
}

}
