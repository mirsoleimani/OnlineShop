using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop;
using OnlineShop.BusinessLogic.EndUser;
using OnlineShop.Operational;
using System.Web.Security;

public partial class Admin_Modules_EndUserRegister : System.Web.UI.UserControl
{
    OnlineShop.Common.EndUser.EndUser _endUser;
    private DropDownList _ddlEndUserType;
    string[] roles;
    protected void Page_Load(object sender, EventArgs e)
    {
        roles = Roles.GetAllRoles();
        if(!IsPostBack)
        {
            if (!Page.User.IsInRole(roles[0]))
            {
                FillEndUserRoleDropDownsOthers();
            }
            else
            {
                FillEndUserRoleDropDowns(); 
            }
                       
            
        }
    }

    private void FillEndUserRoleDropDownsOthers()
    {



        _ddlEndUserType = new DropDownList();
        _ddlEndUserType = (DropDownList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddlEndUserType");
        _ddlEndUserType.Items.Clear();


        string[] roles = Roles.GetAllRoles();
        _ddlEndUserType.DataSource = Roles.GetAllRoles();
        _ddlEndUserType.DataBind();

        
        _ddlEndUserType.SelectedIndex = _ddlEndUserType.Items.IndexOf(_ddlEndUserType.Items.FindByText(roles[0]));
        _ddlEndUserType.Enabled = false;
        
    }
    private void FillEndUserRoleDropDowns()
    {
        _ddlEndUserType = new DropDownList();
        _ddlEndUserType = (DropDownList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddlEndUserType");
        _ddlEndUserType.Items.Clear();

       
        _ddlEndUserType.DataSource = Roles.GetAllRoles();
        _ddlEndUserType.DataBind();

        _ddlEndUserType.SelectedIndex = _ddlEndUserType.Items.IndexOf(_ddlEndUserType.Items.FindByText(roles[0]));
      

      
    }

    
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        if(!Page.User.IsInRole(roles[0]))
        {
            _ddlEndUserType = (DropDownList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddlEndUserType");
            Roles.AddUserToRole((sender as CreateUserWizard).UserName, _ddlEndUserType.SelectedItem.Text);

            MembershipUser endUser = Membership.GetUser(CreateUserWizard1.UserName);
            _endUser = new OnlineShop.Common.EndUser.EndUser();
            _endUser.EndUserID = new Guid(endUser.ProviderUserKey.ToString());

            (sender as CreateUserWizard).ContinueDestinationPageUrl = string.Format("~/Admin/EndUserDetails.aspx?EndUserID={0}", _endUser.EndUserID.ToString());
        }
        else
        {
            _ddlEndUserType = (DropDownList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("ddlEndUserType");
            Roles.AddUserToRole((sender as CreateUserWizard).UserName, _ddlEndUserType.SelectedItem.Text);

            MembershipUser endUser = Membership.GetUser(CreateUserWizard1.UserName);
            _endUser = new OnlineShop.Common.EndUser.EndUser();
            _endUser.EndUserID = new Guid(endUser.ProviderUserKey.ToString());

            (sender as CreateUserWizard).ContinueDestinationPageUrl = string.Format("~/Admin/EndUserDetails.aspx?EndUserID={0}", _endUser.EndUserID.ToString());
        }

   
        
   
    }
   
    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {
        }

    protected void ddlEndUserType_DataBound(object sender, EventArgs e)
    {


     

      
      
    }
}
