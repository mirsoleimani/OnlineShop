using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using OnlineShop.Operational;
using OnlineShop.Common;

public partial class Admin_Modules_CategoryAdd : OnlineShop.Web.BaseAdminUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            this.SelectTab(this.CategoryTabs, this.TabID);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            try
            {
                Category category = ctrlCategoryInfo.SaveInfo();
               

            }
            catch (System.Exception ex)
            {
                Utilities.LogException(ex);
                Response.Redirect("~/ErrorPage.aspx");
            }
            Response.Redirect("~/Admin/Categories.aspx");
        }
    }

    private string TabID
    {
        get
        {
            return Utilities.QueryString("TabID");
        }
    }
}
