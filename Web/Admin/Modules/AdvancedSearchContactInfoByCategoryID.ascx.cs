using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Category;
using OnlineShop.BusinessLogic.Shop.Search;

public partial class Admin_Modules_AdvancedSearchContactInfoByCategoryID : System.Web.UI.UserControl
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

        ProcessSearchShopContactInfoByCategoryID processSearch =
            new ProcessSearchShopContactInfoByCategoryID();
        processSearch.EndUser = _endUser;

        try
        {
            processSearch.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        gvContactInfo.DataSource = processSearch.ResultDataSet;
        gvContactInfo.DataBind();
    }
    protected void gvContactInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvContactInfo.PageIndex = e.NewPageIndex;
        Search();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
