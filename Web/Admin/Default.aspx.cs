using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_click(object sender, EventArgs e)
    {
        MembershipUser mu = Membership.GetUser("katajpresident");
        mu.ChangePassword(mu.ResetPassword(), "123456");
    }
}
