using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Category;

public partial class Modules_ShopAdvancedContactSearch : System.Web.UI.UserControl
{
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
        string categoryID = ddlCategoryName.SelectedValue;
        string areaCode = txtAreaCode.Text.Trim();
        string phone = txtPhone.Text.Trim();
        string name = txtName.Text.Trim();



        Response.Redirect(
            string.Format("~/ShopSearchResult.aspx?Contact={0}&PageNumber={1}" +
            "&CategoryID={2}&AreaCode={3}&Phone={4}&Name={5}",
            "True", 1, categoryID, areaCode, phone, name));
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
