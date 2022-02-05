using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Admin_Modules_AdvancedSearch : System.Web.UI.UserControl
{
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
            

        }
    }
}
