using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;

public partial class Admin_Modules_ShopDetails : OnlineShop.Web.BaseAdminUserControl
{
    OnlineShop.Common.Shop.Shop _shop;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            hlBack.NavigateUrl = string.Format("~/Admin/EndUserDetails.aspx?EndUserID={0}", this.EndUserID);
            this.SelectTab(this.shopTabs, this.TabID);
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        _shop.EndUserID = new Guid(EndUserID);
        if (Page.IsValid)
        {
            ctrlShopInfo.DeleteInfo();
            Response.Redirect(string.Format("EndUserDetails.aspx?EndUserID={0}",
                    _shop.EndUserID));
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
      
            _shop = new OnlineShop.Common.Shop.Shop();

            try
            {
                ctrlShopCategoryMap.SaveInfo();
                ctrlShopInfo.SaveInfo();
                


            }
            catch (System.Exception ex)
            {
                Utilities.LogException(ex);
                Response.Redirect("~/ErrorPage.aspx");
            }
            //Response.Redirect(string.Format("EndUserDetails.aspx?EndUserID={0}",
            //        _shop.EndUserID));
        

    }

    private string TabID
    {
        get
        {
            return Utilities.QueryString("TabID");
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
