using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop;
using System.Data;

public partial class Admin_Modules_EndUserShops : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
        }
    }


    private void BindData()
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        DataSet ds = new DataSet();

        ProcessGetShopsByEndUserID processGet =
            new ProcessGetShopsByEndUserID();
        _shop.EndUserID = new Guid(EndUserID);
        processGet.Shop = _shop;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ds = processGet.ResultDataSet;
        gvShops.DataSource = ds;
        gvShops.DataBind();
    }
    protected void btnAddShop_Click(object sender, EventArgs e)
    {
        Response.Redirect(string.Format("ShopAdd.aspx?EndUserID={0}", EndUserID));
    }
    protected void gvShops_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void gvShops_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }

    private string EndUserID
    {
        get{
            return Utilities.QueryString("EndUserID");
        }
    }
    
}
