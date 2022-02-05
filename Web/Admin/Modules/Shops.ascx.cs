using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop.BusinessLogic.Category;
using System.Web.Security;

public partial class Admin_Modules_Shops : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
    //private DataSet _resultDataSet;
    string[] roles;
    protected void Page_Load(object sender, EventArgs e)
    {
        roles = Roles.GetAllRoles();
        if (!Page.User.IsInRole(roles[0]))
        {
            Response.Redirect("~/Admin/AccessDeniedPage.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                FillDropDowns();
                BindData();
            }
        }


    }

    private void FillDropDowns()
    {
        ProcessGetCategories processGet =
         new ProcessGetCategories();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ddlCategoryName.DataSource = processGet.ResultDataSet;
        ddlCategoryName.DataTextField = "Name";
        ddlCategoryName.DataValueField = "CategoryID";
        ddlCategoryName.DataBind();
    }
    private void BindData()
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

        gvShops.DataSource = processGet.ResultDataSet;
        gvShops.DataBind();
    }
    private void Search()
    {
        ProcessGetShopByCategoryID processGet =
            new ProcessGetShopByCategoryID();
        _shop = new OnlineShop.Common.Shop.Shop();
        _shop.CategoryID = int.Parse(ddlCategoryName.SelectedValue.ToString());

        processGet.Shop = _shop;
        try
        {
            processGet.Invoke();
        }

        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        gvShopsSearch.DataSource = processGet.ResultDataSet;
        gvShopsSearch.DataBind();
    }

    protected void gvShops_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
    protected void gvShops_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvShops.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gvShopsSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvShops.PageIndex = e.NewPageIndex;
        Search();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
