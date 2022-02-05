using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Category;

public partial class Modules_ShopAdvancedCareerSearchBox : System.Web.UI.UserControl
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
        string deputation = txtDeputation.Text.Trim();
        string activityType = txtActivityType.Text.Trim();
        string activityField = txtActivityField.Text.Trim();
        string name = TextName.Text.Trim();
        


        Response.Redirect(
            string.Format("~/ShopSearchResult.aspx?Career={0}&PageNumber={1}"+
            "&CategoryID={2}&Deputation={3}&ActivityType={4}&ActivityField={5}&Name={6}",
            "True", 1,categoryID,deputation,activityType,activityField,name ));
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
