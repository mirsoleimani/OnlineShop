using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineShop.Common.Shop;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop.BusinessLogic.EndUser;
using OnlineShop.Operational;


public partial class Modules_ShopDetails : System.Web.UI.UserControl
{
    private OnlineShop.Common.EndUser.EndUser _endUser;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        Shop shop = new Shop();
        DataTable dt = new DataTable();
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        DataSet ds = new DataSet();

        shop.ShopID = ShopID;

        ProcessGetShopByID processGetShop =
            new ProcessGetShopByID();
        processGetShop.Shop = shop;
        try
        {
            processGetShop.Invoke();
        }
        catch
        {
            Response.Redirect("ErrorPage.aspx");
        }
        dataListShop.DataSource = processGetShop.ResultDataSet;
        dataListShop.DataBind();



    }

    protected void dataListShop_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        ProcessGetEndUserAddressInfoByEndUserID processGetAddressInfo
            = new ProcessGetEndUserAddressInfoByEndUserID();

        _endUser.AddressInfoData.IsCareerAddress = true;
        _endUser.AddressInfoData.EndUserID = new Guid(EndUserID);
        processGetAddressInfo.EndUser = _endUser;

        try
        {
            processGetAddressInfo.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        Repeater rptrAddressInfo = (Repeater)e.Item.FindControl("rptrAddressInfo");
        rptrAddressInfo.DataSource = processGetAddressInfo.ResultDataSet;
        rptrAddressInfo.DataBind();

        ProcessGetEndUserContactInfoByEndUserID processGetContactInfo
            = new ProcessGetEndUserContactInfoByEndUserID();

        _endUser.ContactInfodata.EndUserID = new Guid(EndUserID);
        processGetContactInfo.EndUser = _endUser;

        try
        {
            processGetContactInfo.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        Repeater rptrContactInfo = (Repeater)e.Item.FindControl("rptrContactInfo");
        rptrContactInfo.DataSource = processGetContactInfo.ResultDataSet;
        rptrContactInfo.DataBind();

        ProcessGetEndUserCareerInfoByEndUserID processGetCareerInfo =
            new ProcessGetEndUserCareerInfoByEndUserID();

        _endUser.CareerInfoData.EndUserID = new Guid(EndUserID);
        processGetCareerInfo.EndUser = _endUser;

        try
        {
            processGetCareerInfo.Invoke();
        }
        catch (System.Exception ex)
        {
             Response.Redirect("~/ErrorPage.aspx");
           
        }
        Repeater rptrCareerInfo = (Repeater)e.Item.FindControl("rptrCareerInfo");
        rptrCareerInfo.DataSource = processGetCareerInfo.ResultDataSet;
        rptrCareerInfo.DataBind();


    }

    private int ShopID
    {
        get
        {
            return Utilities.QueryStringInt("ShopID");
        }
    }
    private string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }
}
