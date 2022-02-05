using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop;
using OnlineShop.Operational;

public partial class Admin_Modules_ShopRating : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
    private string _rate;

    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (!IsPostBack)
        {
            
            BindData();
        }
        
    }

    private void BindData()
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        ProcessGetShopByID processGet =
            new ProcessGetShopByID();
        _shop.ShopID = ShopID;
        processGet.Shop = _shop;
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        
        if (processGet.Shop != null)
        {
            ShopRating.CurrentRating = processGet.Shop.Rating;
            Rate = ShopRating.CurrentRating.ToString();
        } 
        else
        {
            //nothing
            Rate = ShopRating.CurrentRating.ToString();
        }
        
        
    }
    protected void ShopRating_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
    {
        Rate = e.Value;
        
    }
    public string Rate
    {
        get { return ViewState["ShopRating"].ToString(); }
        set { ViewState["ShopRating"]= value; }
    
    }

    private int ShopID
    {
        get {return Utilities.QueryStringInt("ShopID"); }
    }
}
