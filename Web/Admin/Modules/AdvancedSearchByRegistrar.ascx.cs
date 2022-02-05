using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ApplicationServices;
using System.Web.Security;
using OnlineShop.BusinessLogic.EndUser;

public partial class Admin_Modules_AdvancedSearchShopDeputationBox : System.Web.UI.UserControl
{
    private OnlineShop.Common.EndUser.EndUser _endUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            FillDropDowns();
        }
    }

    private void FillDropDowns()
    {
        string[] roleName=Roles.GetAllRoles();


        ddlEndUsers.DataSource = Roles.GetUsersInRole(roleName[2]);
        ddlEndUsers.DataBind();
    }

    private void Search()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        string registrarName = ddlEndUsers.SelectedValue;
        _endUser.PersonalInfoData.RegisteredBy = registrarName;

        ProcessGetEndUsersByRegistrarName processGet =
            new ProcessGetEndUsersByRegistrarName();
        processGet.EndUser = _endUser;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        gvEndUsers.DataSource = processGet.ResultDataSet;
        gvEndUsers.DataBind();
    }
    protected void gvEndUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvEndUsers.PageIndex = e.NewPageIndex;
        Search();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
}
