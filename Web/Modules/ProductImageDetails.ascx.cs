using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modules_ImageDetails : System.Web.UI.UserControl
{
    static string prevPage = String.Empty;//added by elahe
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            prevPage = Request.UrlReferrer.AbsoluteUri.ToString();//added by elahe
            imgProductImage.ImageUrl=string.Format("~/ProductImageViewer.ashx?ImageID={0}",HttpContext.Current.Request.QueryString["ImageID"].ToString());
	
        }

    }
        protected void  return_PrePage(object sender, EventArgs e)//addded by elahe
        {
             Response.Redirect("Gallery.aspx");
        }
}
