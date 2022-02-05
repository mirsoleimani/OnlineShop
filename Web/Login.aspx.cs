using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using OnlineShop;
using OnlineShop.BusinessLogic.EndUser;
using OnlineShop.Operational;

public partial class Login : System.Web.UI.Page
{
    //private OnlineShop.Common.EndUser.EndUser _endUser;
    protected void Page_Load(object sender, EventArgs e)
    {

        
    }


    //private bool LoginUser(string userName,string password)
    //{
    //    _endUser = new OnlineShop.Common.EndUser.EndUser();
    //    _endUser.UserName = userName;

    //    ProcessEndUserAsAdminLogin processGet =
    //        new ProcessEndUserAsAdminLogin();
    //    if (userName == null)
    //        userName = string.Empty;
    //    userName = userName.Trim();

    //    processGet.EndUser = _endUser;

    //    try
    //    {
    //        processGet.Invoke();
    //    }
    //    catch (System.Exception ex)
    //    {
    //        Response.Redirect("~/ErrorPage.aspx");
    //    }

    //    _endUser = processGet.EndUser;
    //    if(_endUser != null)
    //    {
    //        string passwordHash = Utilities.CreatePasswordHash(password, _endUser.PasswordSalt);
    //        return _endUser.PasswordHash.Equals(passwordHash);
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}
