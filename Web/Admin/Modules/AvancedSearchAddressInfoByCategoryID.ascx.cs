using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Shop.Search;
using OnlineShop.BusinessLogic.Category;

public partial class Admin_Modules_AvancedSearchAddressInfoByCategoryID : System.Web.UI.UserControl
{
    private OnlineShop.Common.EndUser.EndUser _endUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillDropDowns();
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

    private void Search()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.ShopData.CategoryID = int.Parse(ddlCategoryName.SelectedValue);

        ProcessSearchShopAddressInfoByCategoryID processSearch =
            new ProcessSearchShopAddressInfoByCategoryID();
        processSearch.EndUser = _endUser;

        try
        {
            processSearch.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        gvAddressInfo.DataSource = processSearch.ResultDataSet;
        gvAddressInfo.DataBind();
    }
    protected void gvAddressInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvAddressInfo.PageIndex = e.NewPageIndex;
        Search();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
