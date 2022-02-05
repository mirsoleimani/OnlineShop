using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using OnlineShop.Operational;

public partial class Admin_Modules_EndUserDetails : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    //protected void btnSave_Click(object sender, EventArgs e)
    //{

    //}
    protected void DeleteInfo()
    {
        
        MembershipUser endUser;
        endUser = Membership.GetUser(new Guid(EndUserID));
        
        Membership.DeleteUser(endUser.UserName, true);

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
      
        try
        {
            DeleteInfo();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        Response.Redirect("~/Admin/EndUsers.aspx");
      
    }

    private string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }

}
