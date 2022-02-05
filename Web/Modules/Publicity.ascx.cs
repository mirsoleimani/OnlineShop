using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using System.Data;
using System.Configuration;
using System.Xml;

public partial class Modules_PublicityShop : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop = new OnlineShop.Common.Shop.Shop();
    //private int _currentPage = -1;

    //protected void Page_Load(object sender, EventArgs e)
    //{

    //    _shop.ShopID = ShopID;
    //    _currentPage = PageNumber;

    //    lnkPreviousPage.NavigateUrl = string.Format("~/Shop.aspx?ShopID={0}&PageNumber={1}", ShopID, (_currentPage - 1));
    //    lnkNextPage.NavigateUrl = string.Format("~/Shop.aspx?ShopID={0}&PageNumber={1}", ShopID, (_currentPage + 1));
    //    if (!Page.IsPostBack)
    //    {
    //        BindData();
    //    }
    //}
    //public void BindData()
    //{

    //    PagedDataSource dataSource = new PagedDataSource();

    //    OnlineShop.BusinessLogic.Product.ProcessGetProductsByShopID processGet =
    //        new OnlineShop.BusinessLogic.Product.ProcessGetProductsByShopID();
    //    processGet.Shop = _shop;
    //    try
    //    {
    //        processGet.Invoke();
    //    }
    //    catch (System.Exception ex)
    //    {
    //        Response.Redirect("~/ErrorPage.aspx");
    //    }


    //    DataView dv = new DataView(processGet.ResultDataSet.Tables[0]);

    //    dataSource.DataSource = dv;
    //    dataSource.AllowPaging = true;
    //    dataSource.PageSize = 6;

    //    try
    //    {
    //        if (dataSource.PageCount - 1 < _currentPage)
    //        {
    //            _currentPage = dataSource.PageCount - 1;
    //        }
    //        if (_currentPage < 0)
    //        {
    //            _currentPage = 0;
    //        }

    //        dataSource.CurrentPageIndex = _currentPage;
    //    }
    //    catch
    //    {
    //        dataSource.CurrentPageIndex = 0;
    //    }

    //    lnkPreviousPage.Visible = !dataSource.IsFirstPage;
    //    lnkNextPage.Visible = !dataSource.IsLastPage;

    //    dataListProducts.DataSource = dataSource;
    //    dataListProducts.DataBind();

    //}

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        int pageNumber = PageNumber;
        if (pageNumber == 0)
            pageNumber = 1;
        int howManyPages = 1;
        string firstPageUrl = "";
        string pagerFormat = "";
        _shop.ShopID = ShopID;

        OnlineShop.BusinessLogic.Product.ProcessGetProductsByShopIDPaged processGet =
            new OnlineShop.BusinessLogic.Product.ProcessGetProductsByShopIDPaged();
        processGet.PageNumber = pageNumber;
        processGet.Shop = _shop;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        howManyPages = processGet.HowManyPages;
        if (pageNumber > howManyPages)
        {
            pageNumber = 1;
            processGet.PageNumber = pageNumber;
            processGet.Shop = _shop;

            try
            {
                processGet.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
        }

        dataListProducts.DataSource = processGet.ResultDataTable;
        dataListProducts.DataBind();

        firstPageUrl = string.Format("~/Publicity.aspx?ShopID={0}&PageNumber={1}", ShopID, 1);
      
        pagerFormat = string.Format("~/Publicity.aspx?ShopID={0}&PageNumber={1}", ShopID, "{0}");
       
        ctrlTopPager.Show(pageNumber, howManyPages, firstPageUrl, pagerFormat, true);
        ctrlBottomPager.Show(pageNumber, howManyPages, firstPageUrl, pagerFormat, true);
    }
    public int ShopID
    {
        get
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("~/SiteSettings.xml"));

            XmlNode xmlNode = xmlDoc.DocumentElement;
            return int.Parse(xmlNode["PublicityShopID"].InnerText.ToString());
            
        }
    }

    public int PageNumber
    {
        get
        {
            return Utilities.QueryStringInt("PageNumber");
        }
    }

    protected void dataListProducts_ItemDataBound(object sender, DataListItemEventArgs e)
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

    protected void btnDetails_Click(object sender, CommandEventArgs e)
    {
        Response.Redirect(String.Format("~/ProductDetails.aspx?ProductID={0}", e.CommandArgument));
    }
}
