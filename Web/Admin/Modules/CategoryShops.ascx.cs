using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using OnlineShop.BusinessLogic.Shop;
using OnlineShop.BusinessLogic.Category;
using OnlineShop.Operational;
using OnlineShop.Common;
using OnlineShop;


public partial class Admin_Modules_CategoryShops : System.Web.UI.UserControl
{
    private int _numShops;
    protected void Page_Load(object sender, EventArgs e)
    {
        FillGridView();

    }
    protected void FillGridView()
    {
        OnlineShop.Common.Category category = new OnlineShop.Common.Category();
        category.CategoryID = CategoryId;

        OnlineShop.Common.Shop.Shop _shop;
        ProcessGetShopByCategoryID processGet =
            new ProcessGetShopByCategoryID();

        _shop = new OnlineShop.Common.Shop.Shop();
        _shop.CategoryID = category.CategoryID;
        processGet.Shop = _shop;
        try
        {
            processGet.Invoke();
        }

        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        NumShops = processGet.ResultDataSet.Tables[0].Rows.Count;
        gvCateoryShops.DataSource = processGet.ResultDataSet;
        gvCateoryShops.DataBind();
    }
    protected void gvCateoryShops_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        
    }

    public int CategoryId
    {
        get
        {
            return Utilities.QueryStringInt("CategoryID");

        }
    }

    public int NumShops
    {
        set { _numShops = value; }
        get
        {
            return _numShops;
        }
    }

  
}
