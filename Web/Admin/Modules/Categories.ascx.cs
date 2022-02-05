using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using OnlineShop.BusinessLogic.Shop;
using System.Data;
using OnlineShop.DataAccess.Category.Select;
using OnlineShop.BusinessLogic.Category;
using System.Web.Security;

public partial class Admin_Modules_Categories : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] roles = Roles.GetAllRoles();
        if (!Page.User.IsInRole(roles[0]))
        {
            Response.Redirect("~/Admin/AccessDeniedPage.aspx");
        }
        else
        {
            if (!Page.IsPostBack)
            {
                LoadCategories();
            }

        }
    }
    public void LoadCategories()
    {
        ProcessGetCategories processGet =
            new ProcessGetCategories();

        try
        {
            processGet.Invoke();

        }
        catch
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        dataListShopCategories.DataSource = processGet.ResultDataSet;
        dataListShopCategories.DataBind();
    }


}
