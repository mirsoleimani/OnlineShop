using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Shop;
using System.Configuration;
using System.Xml;

public partial class Admin_Modules_PublicityInfo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillDropDowns();           
            BindData();

        }
    }

    private void BindData()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(Server.MapPath("~/SiteSettings.xml"));

        XmlNode xmlNode = xmlDoc.DocumentElement;
        
        ddlShops.SelectedIndex =
            ddlShops.Items.IndexOf(ddlShops.Items.FindByValue(xmlNode["PublicityShopID"].InnerText));
    }

    private void FillDropDowns()
    {
        ProcessGetShops processGet =
    new ProcessGetShops();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ddlShops.DataSource = processGet.ResultDataSet;
        ddlShops.DataTextField = "Name";
        ddlShops.DataValueField = "ShopID";
        ddlShops.DataBind();
    }
    
    public void SaveInfo()
    {
       
        XmlDocument xmlDoc = new  XmlDocument();
        xmlDoc.Load(Server.MapPath("~/SiteSettings.xml"));

        XmlNode xmlNode = xmlDoc.DocumentElement;
        xmlNode["PublicityShopID"].InnerText = ddlShops.SelectedValue.ToString();

        xmlDoc.Save(Server.MapPath("~/SiteSettings.xml"));
       
    }
}
