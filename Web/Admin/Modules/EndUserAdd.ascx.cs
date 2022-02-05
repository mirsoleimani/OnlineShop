using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop;

public partial class Admin_Modules_CustomerAdd : System.Web.UI.UserControl
{
    //OnlineShop.Common.EndUser.EndUser _endUser;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        
        if(Page.IsValid)
        {
            try
            {
                //_endUser = ctrlEndUserRegisterInfo.CreateUser();
                
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
            //Response.Redirect(string.Format("EndUserDetails.aspx?EndUserID={0}", _endUser.EndUserID.ToString()));

        }
    }
}
