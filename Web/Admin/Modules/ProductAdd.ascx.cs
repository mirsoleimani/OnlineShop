using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;

public partial class Admin_Modules_ProductAdd : OnlineShop.Web.BaseAdminUserControl
{
    OnlineShop.Common.Product.Product _product;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SaveButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                _product = ctrlProductInfo.SaveInfo();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
            Response.Redirect(string.Format("~/Admin/ShopDetails.aspx?ShopID={0}&EndUserID={1}", 
                _product.ShopID, EndUserID));
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
