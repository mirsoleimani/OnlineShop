using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop;
using OnlineShop.Operational;
using System.Data;
using OnlineShop.BusinessLogic.Product;

public partial class Modules_ProductsList : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop ;
    //private int _currentPage=-1;
    private string _searchCriteria;
	public string SearchCriteria
	{
		
        get
        {
            return Utilities.QueryString("SearchCriteria");
        }
	}
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //_shop.ShopID = ShopID;
        //_currentPage = PageNumber;

        //lnkPreviousPage.NavigateUrl = string.Format("~/Shop.aspx?ShopID={0}&PageNumber={1}&EndUserID={2}", ShopID,(_currentPage-1),EndUserID);
        //lnkNextPage.NavigateUrl = string.Format("~/Shop.aspx?ShopID={0}&PageNumber={1}&EndUserID={2}", ShopID, (_currentPage + 1),EndUserID);
        if(!Page.IsPostBack)
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
        

        if (ShopID !=0)
        {
            _shop = new OnlineShop.Common.Shop.Shop();
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

            dataListProducts.DataSource = processGet.ResultDataTable;
            dataListProducts.DataBind();

            firstPageUrl = string.Format("~/Shop.aspx?ShopID={0}&EndUserID={1}&PageNumber={2}", ShopID, EndUserID, 1);
            //       string.Format("~/Shop.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
            //       searchCriteria, allWords.ToString(), 1);
            pagerFormat = string.Format("~/Shop.aspx?ShopID={0}&EndUserID={1}&PageNumber={2}", ShopID, EndUserID, "{0}");
            //    string.Format("~/ShopSearchResult.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
            //    searchCriteria, allWords.ToString(), "{0}");
        }
        else if (SearchCriteria != string.Empty)
        {
            
            ProcessSearchProducts processSearch=
                new ProcessSearchProducts();
            processSearch.AllWords = AllWords;
            processSearch.PageNumber = PageNumber;
            processSearch.SearchCriteria = SearchCriteria;

            try
            {
                processSearch.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("ErrorPage.aspx");
            }

            howManyPages = processSearch.HowManyPages;

            dataListProducts.DataSource = processSearch.ResultDataTable;
            dataListProducts.DataBind();

            firstPageUrl =
               string.Format("~/ProductSearchResult.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
               SearchCriteria, AllWords.ToString(), 1);
            pagerFormat =
                string.Format("~/ProductSearchResult.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
                SearchCriteria, AllWords.ToString(), "{0}");


        }
      
        ctrlTopPager.Show(pageNumber, howManyPages, firstPageUrl, pagerFormat, false);
        ctrlBottomPager.Show(pageNumber, howManyPages, firstPageUrl, pagerFormat, false);
    }

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
    //    dataSource.PageSize = 4;

    //    try
    //    {
    //        if (dataSource.PageCount-1<_currentPage)
    //        {
    //            _currentPage = dataSource.PageCount - 1;
    //        } 
    //        if(_currentPage<0)
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
  
    public int ShopID
    {
        get
        {
            return Utilities.QueryStringInt("ShopID");
        }
    }

    public int PageNumber
    {
        get
        {
            return Utilities.QueryStringInt("PageNumber");
        }
    }

    public string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }

    private bool AllWords
    {
        get
        {
            return Utilities.QueryStringBool("AllWords");
        }
    }

}
