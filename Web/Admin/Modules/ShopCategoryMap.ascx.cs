using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Shop;
using System.Data;
using OnlineShop.BusinessLogic.Category;

public partial class Admin_Modules_ShopCategoryMap : System.Web.UI.UserControl
{
    private OnlineShop.Common.Shop.Shop _shop;
    private OnlineShop.Common.Shop.ShopCategory _shopCategory;

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
        _shop.ShopID = ShopID;

        ProcessGetShopByID processGet =
            new ProcessGetShopByID();
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
            ProcessGetShopCategoriesByShopID processGetShopCategories =
                new ProcessGetShopCategoriesByShopID();
            processGetShopCategories.Shop = _shop;

            try
            {
                processGetShopCategories.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }

            List<ShopCategoryMapHelper> shopCategoryMap =
                GetShopCategoryMap(processGetShopCategories.ResultDataSet);
            gvShopCategoryMap.DataSource = shopCategoryMap;
            gvShopCategoryMap.DataBind();
        }
    }
    public void SaveInfo()
    {
        _shop = new OnlineShop.Common.Shop.Shop();
        _shop.ShopID = this.ShopID;

        ProcessGetShopByID processGet =
            new ProcessGetShopByID();
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
            foreach (GridViewRow row in gvShopCategoryMap.Rows)
            {
                CheckBox cbCategoryName = (CheckBox)row.FindControl("cbShopCategoryMap");
                HiddenField hfCategoryID = row.FindControl("hfCategoryID") as HiddenField;
                HiddenField hfShopCategoryID = row.FindControl("hfShopCategoryID") as HiddenField;

                int categoryID = int.Parse(hfCategoryID.Value);
                int shopCategoryID = int.Parse(hfShopCategoryID.Value);

                if (shopCategoryID > 0 && !cbCategoryName.Checked)
                {
                    //delete
                    _shopCategory = new OnlineShop.Common.Shop.ShopCategory();
                    _shopCategory.ShopCategryID = shopCategoryID;

                    ProcessDeleteShopCategoryByID processDelete =
                        new ProcessDeleteShopCategoryByID();
                    processDelete.ShopCategory = _shopCategory;

                    try
                    {
                        processDelete.Invoke();
                    }
                    catch (System.Exception ex)
                    {
                        Response.Redirect("~/ErrorPage.aspx");
                    }

                }
                if (shopCategoryID > 0 && cbCategoryName.Checked)
                {
                    //Update
                }
                if (shopCategoryID == 0 && cbCategoryName.Checked)
                {
                    //Insert
                    _shopCategory = new OnlineShop.Common.Shop.ShopCategory();
                    _shopCategory.ShopID = ShopID;
                    _shopCategory.CategoryID = categoryID;

                    ProcessAddShopCategory processAdd =
                        new ProcessAddShopCategory();
                    processAdd.ShopCategory = _shopCategory;

                    try
                    {
                        processAdd.Invoke();
                    }
                    catch (System.Exception ex)
                    {
                        Response.Redirect("~/ErrorPage.aspx");
                    }

                }
            }
        }
    }

    private List<ShopCategoryMapHelper> GetShopCategoryMap(DataSet ds)
    {
        ProcessGetCategories processGet =
            new ProcessGetCategories();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        List<ShopCategoryMapHelper> shopCategoryMapResult =
            new List<ShopCategoryMapHelper>();
        ShopCategoryMapHelper scm;

        for (int j = 0; j < processGet.ResultDataSet.Tables[0].Rows.Count; j++)
        {

            scm = new ShopCategoryMapHelper();


            object obj =
                FindShopCategory(ds, int.Parse(processGet.ResultDataSet.Tables[0].Rows[j]["CategoryID"].ToString()));
            if (obj != null)
            {
                scm.ShopCategoryID = int.Parse(obj.ToString());
                scm.IsMapped = true;
            }
            scm.CategoryID = int.Parse(processGet.ResultDataSet.Tables[0].Rows[j]["CategoryID"].ToString());
            scm.Name = processGet.ResultDataSet.Tables[0].Rows[j]["Name"].ToString();
            shopCategoryMapResult.Add(scm);




        }
        return shopCategoryMapResult;
    }
    private object FindShopCategory(DataSet ds, int categoryID)
    {
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            if (int.Parse(ds.Tables[0].Rows[i]["CategoryID"].ToString()) == categoryID)
            {

                return ds.Tables[0].Rows[i]["ShopCategoryID"];
            }

        }
        return null;
    }
    private class ShopCategoryMapHelper
    {
        public string Name { get; set; }
        public int ShopCategoryID { get; set; }
        public int ShopID { get; set; }
        public int CategoryID { get; set; }
        public bool IsMapped { get; set; }
    }
    private int ShopID
    {

        get
        {
            return Utilities.QueryStringInt("ShopID");
        }
    }
    protected void gvShopcategoryMap_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        SaveInfo();
        gvShopCategoryMap.PageIndex = e.NewPageIndex;
        BindData();
    }
}
