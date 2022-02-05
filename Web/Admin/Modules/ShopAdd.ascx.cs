using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;

public partial class Admin_Modules_ShopAdd : System.Web.UI.UserControl
{
    OnlineShop.Common.Shop.Shop _shop;
    protected void Page_Load(object sender, EventArgs e)
    {
        hlReturn.NavigateUrl = string.Format("../EndUserDetails.aspx?EndUserID={0}", EndUserID);
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        
        if (Page.IsValid)
        {
            _shop = new OnlineShop.Common.Shop.Shop();

            try
            {

                _shop = ctrlShopInfo.SaveInfo();
                


            }
            catch (System.Exception ex)
            {
                Utilities.LogException(ex);
                Response.Redirect("~/ErrorPage.aspx");
            }
            Response.Redirect( string.Format("~/admin/ShopDetails.aspx?ShopID={0}&EndUserID={1}",
                _shop.ShopID,_shop.EndUserID));
        }
    }
    private string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }
}
