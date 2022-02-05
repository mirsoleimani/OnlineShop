using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using OnlineShop.Common.Shop;
using OnlineShop.BusinessLogic.Shop;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.EndUser;


public partial class Modules_Shops : System.Web.UI.UserControl
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
        int pageNumber = PageNumber;
        if (pageNumber == 0)
            pageNumber = 1;

        string searchCriteria = SearchCriteria;
        bool allWords = AllWords;

        int howManyPages = 1;
        int categoryID = CategoryID;
        string name = ShopName;

        
        //Address
        bool address = Address;
        int stateProvinceID = StateProvinceID;
        string city = City;
        string address1 = Address1;
        string address2 = Address2;
        string postalCode = PostalCode;

        //Contact
        bool contact = Contact;
        string areaCode = AreaCode;
        string phone = Phone;

        //Career
        bool career = Career;
        string deputation = Deputation;
        string activityType = ActivityType;
        string activityField = ActivityField;


        string firstPageUrl = "";
        string pagerFormat = "";

        if(address == true)
        {
            _endUser = new OnlineShop.Common.EndUser.EndUser();
            _endUser.AddressInfoData.Address1 = address1;
            _endUser.AddressInfoData.Address2= address2;
            _endUser.AddressInfoData.City = city;
            _endUser.AddressInfoData.StateProvinceID = stateProvinceID;
            _endUser.AddressInfoData.PostalCode = postalCode;
            _endUser.ShopData.CategoryID = categoryID;
            _endUser.ShopData.Name = name;

            ProcessSearchShopsByAddressInfoAdvanced processSearch =
                new ProcessSearchShopsByAddressInfoAdvanced();
            processSearch.EndUser = _endUser;
            processSearch.PageNumber = pageNumber;

            try
            {
                processSearch.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            howManyPages = processSearch.HowManyPages;

            if (howManyPages >= 1)
            {
                dataListShops.DataSource = processSearch.ResultDataTable;
                dataListShops.DataBind();

                firstPageUrl =
                   string.Format("~/ShopSearchResult.aspx?Address={0}&PageNumber={1}" +
                "&CategoryID={2}&City={3}&StateProvinceID={8}&Address1={4}&Address2={5}&PostalCode={6}&Name={7}",
                "True", 1, categoryID, city, address1, address2, postalCode, name, stateProvinceID);
                pagerFormat =
                     string.Format("~/ShopSearchResult.aspx?Address={0}&PageNumber={1}" +
                "&CategoryID={2}&StateProvinceID={8}&City={3}&Address1={4}&Address2={5}&PostalCode={6}&Name={7}",
                "True", "{0}", categoryID, city, address1, address2, postalCode, name, stateProvinceID);
            }
            else
            {
                lblMessage.Text = "جستجوی شما نتیجه ای درپی نداشت";
            }
        }
        else if(career == true)
        {
            _endUser = new OnlineShop.Common.EndUser.EndUser();
            _endUser.CareerInfoData.Deputation= deputation;
            _endUser.CareerInfoData.ActivityType = activityType;
            _endUser.CareerInfoData.ActivityField = activityField;  
            _endUser.ShopData.CategoryID = categoryID;
            _endUser.ShopData.Name = name;

            ProcessSearchShopByCareerInfoAdvanced processSearch =
                new ProcessSearchShopByCareerInfoAdvanced();
            processSearch.EndUser = _endUser;
            processSearch.PageNumber = pageNumber;

            try
            {
                processSearch.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            howManyPages = processSearch.HowManyPages;

            if (howManyPages >= 1)
            {
                dataListShops.DataSource = processSearch.ResultDataTable;
                dataListShops.DataBind();

                firstPageUrl =
                    string.Format("~/ShopSearchResult.aspx?Career={0}&PageNumber={1}" +
                "&CategoryID={2}&Deputation={3}&ActivityType={4}&ActivityField={5}&Name={6}",
                "True", 1, categoryID, deputation, activityType, activityField, name);
                pagerFormat =
                    string.Format("~/ShopSearchResult.aspx?Career={0}&PageNumber={1}" +
                "&CategoryID={2}&Deputation={3}&ActivityType={4}&ActivityField={5}&Name={6}",
                "True", "{0}", categoryID, deputation, activityType, activityField, name);
            }
            else
            {
                lblMessage.Text = "جستجوی شما نتیجه ای درپی نداشت";
            }
        }
        else if(contact == true)
        {
            _endUser = new OnlineShop.Common.EndUser.EndUser();
            _endUser.ContactInfodata.Phone = phone;
            _endUser.ContactInfodata.AreaCode = areaCode;
            _endUser.ShopData.CategoryID = categoryID;
            _endUser.ShopData.Name = name;

            ProcessSearchShopByContactInfoAdvanced processSearch =
                new ProcessSearchShopByContactInfoAdvanced();
            processSearch.EndUser = _endUser;
            processSearch.PageNumber = pageNumber;

            try
            {
                processSearch.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            howManyPages = processSearch.HowManyPages;

            if (howManyPages >= 1)
            {
                dataListShops.DataSource = processSearch.ResultDataTable;
                dataListShops.DataBind();

                firstPageUrl =
                    string.Format("~/ShopSearchResult.aspx?Contact={0}&PageNumber={1}" +
                "&CategoryID={2}&AreaCode={3}&Phone={4}&Name={5}",
                "True", 1, categoryID, areaCode, phone, name);
                pagerFormat =
                     string.Format("~/ShopSearchResult.aspx?Contact={0}&PageNumber={1}" +
                "&CategoryID={2}&AreaCode={3}&Phone={4}&Name={5}",
                "True", "{0}", categoryID, areaCode, phone, name);
            }
            else
            {
                lblMessage.Text = "جستجوی شما نتیجه ای درپی نداشت";
            }
        }
        else if(searchCriteria != string.Empty)
        {
            ProcessSearchShops processSearch =
                new ProcessSearchShops();
            processSearch.SearchCriteria = searchCriteria;
            processSearch.AllWords = allWords;
            processSearch.PageNumber = pageNumber;

            try
            {
                processSearch.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            
            howManyPages=processSearch.HowManyPages;
            if (howManyPages >= 1)
            {
                dataListShops.DataSource = processSearch.ResultDataTable;
                dataListShops.DataBind();

                firstPageUrl =
                    string.Format("~/ShopSearchResult.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
                    searchCriteria, allWords.ToString(), 1);
                pagerFormat =
                    string.Format("~/ShopSearchResult.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
                    searchCriteria, allWords.ToString(), "{0}");
            }
            else
            {
                lblMessage.Text = "جستجوی شما نتیجه ای درپی نداشت";
            }
        }
        else if (categoryID != 0)
        {
            Shop shop = new Shop();
            shop.CategoryID = categoryID;

            ProcessGetShopByCategoryID processGet =
                new ProcessGetShopByCategoryID();
            processGet.Shop = shop;
            try
            {
                processGet.Invoke();
            }
            catch
            {
                Response.Redirect("ErrorPage.aspx");
            }



            dataListShops.DataSource = processGet.ResultDataSet;
            dataListShops.DataBind();
        } 

        ctrlTopPager.Show(pageNumber, howManyPages, firstPageUrl, pagerFormat, false);
        ctrlBottomPager.Show(pageNumber, howManyPages, firstPageUrl, pagerFormat, false);
    }
    protected void dataListShops_ItemDataBound(object sender, DataListItemEventArgs e)
    {

    }
    public int CategoryID
    {
        get
        {
            return Utilities.QueryStringInt("CategoryID");
        }

    }
    public string SearchCriteria
    {
        get
        {
            return Utilities.QueryString("SearchCriteria");
        }
    }
    public int PageNumber
    {
        get{
            return Utilities.QueryStringInt("PageNumber");
        }
    }
    public bool AllWords
    {
        get
        {
            return Utilities.QueryStringBool("AllWords");
        }
    }
    private string ShopName
    {
        get
        {
            return Utilities.QueryString("Name");
        }
    }

    private bool Address
    {
        get{
            return Utilities.QueryStringBool("Address");
        }
    }
    private int StateProvinceID
    {
        get
        {
            return Utilities.QueryStringInt("StateProvinceID");
        }
    }
    private string City
    {
        get
        {
            return Utilities.QueryString("City");
        }
    }
    private string Address1
    {
        get
        {
            return Utilities.QueryString("Address1");
        }
    }
    private string Address2
    {
        get
        {
            return Utilities.QueryString("Address2");
        }
    }
    private string PostalCode
    {
        get
        {
            return Utilities.QueryString("PostalCode");
        }
    }

    private bool Contact
    {
        get
        {
            return Utilities.QueryStringBool("Contact");
        }
    }
    private string AreaCode
    {
        get
        {
            return Utilities.QueryString("AreaCode");
        }
    }
    private string Phone
    {
        get
        {
            return Utilities.QueryString("Phone");
        }
    }

    private bool Career
    {
        get{
            return Utilities.QueryStringBool("Career");
        }
    }
    private string Deputation
    {
        get
        {
            return Utilities.QueryString("Deputation");
        }
    }
    private string ActivityType
    {
        get{
            return Utilities.QueryString("ActivityType");
        }
    }
    private string ActivityField
    {
        get
        {
            return Utilities.QueryString("ActivityField");
        }
    }
   
}
