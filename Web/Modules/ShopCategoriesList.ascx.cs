using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using OnlineShop.BusinessLogic.Shop;
using System.Data;
using OnlineShop.BusinessLogic.Category;


public partial class Modules_ShopCategories : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            BindData();
        }
    }

    public void BindData()
    {
        //ProcessGetShopCategories processShopCategories =
        //    new ProcessGetShopCategories();
        ProcessGetCategories processGet =
            new ProcessGetCategories();
       
        try
        {
            processGet.Invoke();
        }
        catch 
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        dataListShopCategories.DataSource = processGet.ResultDataSet;
        dataListShopCategories.DataBind();
    }
}
