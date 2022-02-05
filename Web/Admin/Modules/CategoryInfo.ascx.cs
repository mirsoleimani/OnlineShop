using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using OnlineShop.Operational;
using OnlineShop.Common;
using OnlineShop.BusinessLogic.Category;
using OnlineShop;
using System.IO;

public partial class Admin_Modules_CategoryInfo : OnlineShop.Web.BaseAdminUserControl
{
    private Category _category;
    private OnlineShop.Common.Shop.ShopCategory _shopcategory;//added by elahe 1/16
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            BindData();
        }
    }

    private void BindData()
    {
        _category = new Category();
        _category.CategoryID = CategoryID;
        ProcessGetCategoryByID processGet = new ProcessGetCategoryByID();
        processGet.Category = _category;
        processGet.Invoke();

        _category = processGet.Category;
        if (_category != null)
        {
            this.stxtName.Text = _category.Name;
            this.txtDescription.Value = _category.Description;
            this.iCategoryImage.Visible = true;
            this.CategoryImageID = _category.ImageID;
            this.iCategoryImage.ImageUrl =
                Page.ResolveUrl("~/" + string.Format("ShopCategoryImageViewer.ashx?ImageID={0}", _category.ImageID));



        }
        else
        {
            this.btnRemoveCategoryImage.Visible = false;
            this.iCategoryImage.Visible = false;
        }
    }
    //added by elahe 1/14
    public void DeleteInfo()
    {
        _category = new Category();
        _category.CategoryID = CategoryID;
        OnlineShop.BusinessLogic.Category.ProcessDeleteCategoryByID processDelete = new ProcessDeleteCategoryByID();
        processDelete.Category = _category;
        processDelete.Invoke();
    }
    //added by elahe 1/16
    public void DeleteInfo_shop()
    {
        _shopcategory = new OnlineShop.Common.Shop.ShopCategory();
        _shopcategory.CategoryID = CategoryID;
        OnlineShop.BusinessLogic.Shop.ProcessDeleteShopCategoryByID processDelete =new OnlineShop.BusinessLogic.Shop.ProcessDeleteShopCategoryByID();
        processDelete.ShopCategory = _shopcategory;
        processDelete.Invoke();

    }
    public Category SaveInfo()
    {
        _category = new Category();
        _category.CategoryID = CategoryID;
        ProcessGetCategoryByID processGet = new ProcessGetCategoryByID();
        processGet.Category = _category;
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
        //processGet.Invoke();
        _category = processGet.Category;
        if (_category != null)
        {
            //Update
            ProcessUpdateCategory processUpdate =
                new ProcessUpdateCategory();
            _category.Name = this.stxtName.Text;
            _category.Description = this.txtDescription.Value;
            _category.Deleted = false;
            if (fuCategoryImage.HasFile)
            {
                _category.ImageData = this.fuCategoryImage.FileBytes;
            }
            else
            {
                ProcessGetCategoryImageByID processGetImage =
                       new ProcessGetCategoryImageByID();
                processGetImage.Category = _category;
                try
                {
                    processGetImage.Invoke();
                }
                catch (System.Exception ex)
                {
                    Response.Redirect("~/ErrorPage.aspx");
                }
                
                _category.ImageData = processGetImage.Category.ImageData;
            }

            processUpdate.Category = _category;
            processUpdate.Invoke();

        }
        else
        {
            //Insert

            ProcessAddCategory processAdd =
                new ProcessAddCategory();
            _category = new Category();
            _category.Name = this.stxtName.Text;
            _category.Description = this.txtDescription.Value;
            
            if (fuCategoryImage.HasFile)
            {
                _category.ImageData = this.fuCategoryImage.FileBytes;
            }
            else
            {

                FileStream stream = new FileStream(Server.MapPath("Images/NoImage.gif"), FileMode.Open, FileAccess.Read);
                BinaryReader bReader = new BinaryReader(stream);


                byte[] buffer = new byte[bReader.BaseStream.Length];
                buffer = bReader.ReadBytes((int)bReader.BaseStream.Length);

                _category.ImageData = buffer;
                stream.Close();
                bReader.Close();
            }

            _category.Deleted = false;
            processAdd.Category = _category;
            try
            {
                processAdd.Invoke();
            }

            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
            



        }
        return _category;
    }
    protected void btnRemoveCategoryImage_Click(object sender, EventArgs e)
    {

    }

    public int CategoryID
    {
        get
        {
            return Utilities.QueryStringInt("CategoryID");

        }
    }
    private int CategoryImageID
    {
        set
        {
            ViewState["CATEGORYIMAGEID"] = value;
        }
        get
        {
            return (int)ViewState["CATEGORYIMAGEID"];
        }
    }
}
