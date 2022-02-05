using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Authentication;
using System.Web.Security;

public partial class Modules_EndUserLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox txtUserName = (TextBox)Login1.FindControl("UserName");
        txtUserName.Focus();
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        TextBox txtUserName = (TextBox)Login1.FindControl("UserName");
        TextBox txtPassword = (TextBox)Login1.FindControl("Password");
        CheckBox rememberMe = (CheckBox)Login1.FindControl("RememberMe");
        //if(FormsAuthentication.Authenticate(txtUserName.Text,txtPassword.Text))
        if(Membership.ValidateUser(txtUserName.Text,txtPassword.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, rememberMe.Checked);
        }
    }
}
