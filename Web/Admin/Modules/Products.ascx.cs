using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop.BusinessLogic.Product;
using System.Web.Security;

public partial class Admin_Modules_Products : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
    string[] roles;
    protected void Page_Load(object sender, EventArgs e)
    {
        roles= Roles.GetAllRoles();
        if (!Page.User.IsInRole(roles[0]))
        {
            Response.Redirect("~/Admin/AccessDeniedPage.aspx");
        }
        else
        {
            if (!IsPostBack)
            {

                //BindData();
                FillDropDowns();
            }
        }
       
    }

    private void FillDropDowns()
    {
        ProcessGetShops processGet =
     new ProcessGetShops();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ddlShops.DataSource = processGet.ResultDataSet;
        ddlShops.DataTextField = "Name";
        ddlShops.DataValueField = "ShopID";
        ddlShops.DataBind();
    }

    private void BindData()
    {
        throw new NotImplementedException();
    }

    private void Search()
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        _shop.ShopID = int.Parse(ddlShops.SelectedValue);

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
        Search();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
