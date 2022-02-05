using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Category;
using OnlineShop.BusinessLogic;

public partial class Modules_ShopAdvancedAddressSearch : System.Web.UI.UserControl
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

        ddlStateProvince.Items.Clear();
        ProcessGetStateProvinces processGetState =
            new ProcessGetStateProvinces();
        try
        {
            processGetState.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }


        ddlStateProvince.DataSource = processGetState.ResultDataSet;
        ddlStateProvince.DataTextField = "Name";
        ddlStateProvince.DataValueField = "StateProvinceID";
        ddlStateProvince.DataBind();
    }
    private void Search()
    {
        string categoryID = ddlCategoryName.SelectedValue;
        string stateProvinceID = ddlStateProvince.SelectedValue;
        string city = txtCity.Text.Trim();
        string Address1 = txtStreet.Text.Trim();
        string Address2 = txtBuilding.Text.Trim();
        string postalCode = txtPostalCode.Text.Trim();
        string name = txtName.Text.Trim();  



        Response.Redirect(
            string.Format("~/ShopSearchResult.aspx?Address={0}&PageNumber={1}" +
            "&CategoryID={2}&StateProvinceID={8}&City={3}&Address1={4}&Address2={5}&PostalCode={6}&Name={7}",
            "True", 1, categoryID, city, Address1, Address2,postalCode,name,stateProvinceID));
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
