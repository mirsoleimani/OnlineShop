using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop.BusinessLogic.Category;
public partial class Admin_Modules_CategoryDetails : OnlineShop.Web.BaseAdminUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] roles = Roles.GetAllRoles();
        this.SelectTab(this.CategoryTabs, "pnlCategoryInfo");
        if (!Page.User.IsInRole(roles[0]))
        {
            Response.Redirect("~/Admin/AccessDeniedPage.aspx");
        }
        else
        {
            if (!Page.IsPostBack)
            {
                
            }

        }

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            OnlineShop.Common.Category category = new OnlineShop.Common.Category();
            try
            {
                if (ctrlCategoryShops.NumShops == 0)
                {
                    ctrlCategoryInfo.DeleteInfo();
                }
                else if (ctrlCategoryShops.NumShops >= 0)
                {
                    //Response.Write("ابتدا باید فروشگاه ها حذف شوند");
                    ctrlCategoryInfo.DeleteInfo_shop();
                    ctrlCategoryInfo.DeleteInfo();
                }


            }
            catch (System.Exception ex)
            {
                Utilities.LogException(ex);
                Response.Redirect("~/ErrorPage.aspx");
            }
            Response.Redirect("~/Admin/Categories.aspx");
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            OnlineShop.Common.Category category = new OnlineShop.Common.Category();
            try
            {
                category = ctrlCategoryInfo.SaveInfo();


            }
            catch (System.Exception ex)
            {
                Utilities.LogException(ex);
                Response.Redirect("~/ErrorPage.aspx");
            }
            Response.Redirect(string.Format("~/Admin/CategoryDetails.aspx?CategoryID={0}&TabID={1}",
                    category.CategoryID, this.GetActiveTabID(this.CategoryTabs)));
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
