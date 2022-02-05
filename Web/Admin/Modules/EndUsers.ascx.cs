using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.EndUser;
using System.Data;
using System.Web.ApplicationServices;
using System.Web.Security;

public partial class Admin_Modules_Customers : System.Web.UI.UserControl
{
    private OnlineShop.Common.EndUser.EndUser _endUser;
    string[] roles;
    protected void Page_Load(object sender, EventArgs e)
    {
        roles = Roles.GetAllRoles();
        bool flag = Page.User.IsInRole(roles[0]);
        if (!Page.User.IsInRole(roles[0]))
        {
            if(!IsPostBack)
                BindDataInRole();
        }
        else
        {
            if (!IsPostBack)
            {
                BindData();
            }

        }

    }
    protected void gvEndUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvEndUsers.PageIndex = e.NewPageIndex;

        if (!Page.User.IsInRole(roles[0]))
        {
            BindDataInRole();
        }
        else
        {
            BindData();
        }
    }
    protected void gvEndUsersSearch_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvEndUsersSearch.PageIndex = e.NewPageIndex;
        if (!Page.User.IsInRole(roles[0]))
        {
            SearchOthers();
        }
        else
        {
            Search();
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (!Page.User.IsInRole(roles[0]))
        {
            SearchOthers();
        }
        else
        {
            Search();
        }
    }

    private void BindDataInRole()
    {
        string endUserName = HttpContext.Current.User.Identity.Name;
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.PersonalInfoData.RegisteredBy = endUserName;

        ProcessGetEndUsersByRegistrarName processGet
            = new ProcessGetEndUsersByRegistrarName();
        processGet.EndUser = _endUser;
        DataSet ds = new DataSet();

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        ds = processGet.ResultDataSet;

        gvEndUsers.DataSource = ds;
        gvEndUsers.DataBind();





    }

    private void BindData()
    {

        ProcessGetEndUsers processGet =
            new ProcessGetEndUsers();

        DataSet ds = new DataSet();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ds = processGet.ResultDataSet;

        gvEndUsers.DataSource = ds;
        gvEndUsers.DataBind();

    }
    private void Search()
    {

        ProcessGetEndUser processGet =
            new ProcessGetEndUser();

        _endUser = new OnlineShop.Common.EndUser.EndUser();

        if (txtUserName.Text == "")
            _endUser.UserName = null;
        else
            _endUser.UserName = txtUserName.Text;

        if (txtFirstName.Text == "")
        {
            _endUser.PersonalInfoData.FirstName = null;
        }
        else
        {
            _endUser.PersonalInfoData.FirstName = this.txtFirstName.Text;
        }

        if (txtLastName.Text == "")
        {
            _endUser.PersonalInfoData.LastName = null;
        }
        else
        {
            _endUser.PersonalInfoData.LastName = this.txtLastName.Text;
        }


        processGet.EndUser = _endUser;
        DataSet ds = new DataSet();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ds = processGet.ResultDataSet;

        gvEndUsersSearch.DataSource = ds;
        gvEndUsersSearch.DataBind();
    }
    private void SearchOthers()
    {

        ProcessSearchEndUserByRegistrarName processSearch =
            new ProcessSearchEndUserByRegistrarName();

        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.PersonalInfoData.RegisteredBy = HttpContext.Current.User.Identity.Name;

        if (txtUserName.Text == "")
            _endUser.UserName = null;
        else
            _endUser.UserName = txtUserName.Text;

        if (txtFirstName.Text == "")
        {
            _endUser.PersonalInfoData.FirstName = null;
        }
        else
        {
            _endUser.PersonalInfoData.FirstName = this.txtFirstName.Text;
        }

        if (txtLastName.Text == "")
        {
            _endUser.PersonalInfoData.LastName = null;
        }
        else
        {
            _endUser.PersonalInfoData.LastName = this.txtLastName.Text;
        }


        processSearch.EndUser = _endUser;
        DataSet ds = new DataSet();
        try
        {
            processSearch.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ds = processSearch.ResultDataSet;

        gvEndUsersSearch.DataSource = ds;
        gvEndUsersSearch.DataBind();
    }

    protected void gvEndUsers_DataBinding(object sender, EventArgs e)
    {

    }
}
