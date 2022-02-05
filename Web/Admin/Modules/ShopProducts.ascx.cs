using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Product;

public partial class Admin_Modules_ShopProducts : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        _shop.ShopID = ShopID;

        ProcessGetProductsByShopID processGet =
            new ProcessGetProductsByShopID();
        processGet.Shop = _shop;
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        gvProducts.DataSource = processGet.ResultDataSet;
        gvProducts.DataBind();
        
    }
    protected void gvProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProducts.PageIndex = e.NewPageIndex;
        BindData();
    }

        protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect(string.Format("~/Admin/ProductAdd.aspx?ShopID={0}&EndUserID={1}", ShopID,EndUserID));
    }

    private string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }
    private int ShopID
    {
        get
        {
            return Utilities.QueryStringInt("ShopID");
        }
    }

}
