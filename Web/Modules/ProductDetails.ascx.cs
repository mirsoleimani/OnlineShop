using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Product;
using System.Data;

public partial class Modules_ProductDetails : System.Web.UI.UserControl
{
    OnlineShop.Common.Product.Product _product;
    static string prevPage = String.Empty;//added by elahe
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //ViewState["RefUrl"] = Request.UrlReferrer.ToString();
          prevPage = Request.UrlReferrer .AbsoluteUri.ToString();//added by elahe
            //this.txtRequestUri.Text = this.Page.Request.UrlReferrer.AbsolutePath.ToString(); 
            BindData();
        }
    }

    private void BindData()
    {
        _product = new OnlineShop.Common.Product.Product();
        _product.ProductID = ProductID;

        ProcessGetProductByID processGet =
            new ProcessGetProductByID();
        processGet.Product = Product;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        dataListProduct.DataSource = processGet.ResultDataSet;
        dataListProduct.DataBind();
    }

    private int ProductID
    {
        get
        {
            return Utilities.QueryStringInt("ProductID");
        }
    }
    public OnlineShop.Common.Product.Product Product
    {
        get { return _product; }
        set { _product = value; }
    }

    protected void dataListProduct_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            DataRowView product = e.Item.DataItem as DataRowView;
            Button btnAdd = e.Item.FindControl("btnAdd") as Button;
            if (btnAdd != null)
            {
                btnAdd.Visible = (bool)product.Row.ItemArray.GetValue(Int32.Parse("6"));
            }


        }
    }
    protected void return_PrePage(object sender, EventArgs e)
    {
        //object refUrl = ViewState["RefUrl"];
        //if (refUrl != null)
        //    Response.Redirect((string)refUrl);
       Response.Redirect(prevPage);
        //string requestPage = this.txtRequestUri.Text.ToString();
        //Response.Redirect(requestPage, true); 
    }
}
