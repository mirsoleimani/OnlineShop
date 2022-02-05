using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Shop;

public partial class Modules_ShopQuickAccess : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void btnGo_Click(object sender, EventArgs e)
    //{

    //}

    private void Go()
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        if (txtCode.Text != null)
            _shop.Code = txtCode.Text;
        else
            _shop.Code = string.Empty;

        ProcessGetShopByCode processGet =
            new ProcessGetShopByCode();
        processGet.Shop = _shop;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception )
        {
            Response.Redirect("ErrorPage.aspx");
        }

        _shop = processGet.Shop;
        if (_shop != null)
        {
            Response.Redirect(string.Format("~/Shop.aspx?ShopID={0}&EndUserID={1}",
                _shop.ShopID.ToString(), _shop.EndUserID.ToString()));
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }
    protected void ibtnGo_Click(object sender, ImageClickEventArgs e)
    {
        Go();
    }
}
