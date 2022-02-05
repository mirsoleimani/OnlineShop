using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

using OnlineShop.Operational;
using OnlineShop.Common.Shop;
using OnlineShop.BusinessLogic.Shop;
using System.IO;

public partial class Admin_Modules_ShopInfo : OnlineShop.Web.BaseAdminUserControl
{
    private Shop _shop;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            FillDropDowns();
        }
    }

    private void FillDropDowns()
    {

    }

    private void BindData()
    {
        _shop = new Shop();
        _shop.ShopID = ShopID;
        ProcessGetShopByID processGet =
            new ProcessGetShopByID();
        processGet.Shop = _shop;
        processGet.Invoke();

        _shop = processGet.Shop;
        if (_shop != null)
        {
            this.stxtName.Text = _shop.Name;
            this.txtDescription.Value = _shop.Description;
            this.stxtCode.Text = _shop.Code.ToString();
            this.iShopImage.ImageUrl =
                Page.ResolveUrl("~/" + string.Format("ShopImageViewer.ashx?ImageID={0}", _shop.ImageData.ImageID));

        }
        else
        {
            this.btnRemoveShopImage.Visible = false;
            this.iShopImage.Visible = false;
        }

    }
    public void DeleteInfo()
    {
        _shop = new Shop();
        _shop.ShopID = ShopID;

        ProcessDeleteShopByID processDelete =
            new ProcessDeleteShopByID();
        processDelete.Shop = _shop;

        try
        {
            processDelete.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }
    }
    public Shop SaveInfo()
    {
        _shop = new Shop();
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
       

        _shop = processGet.Shop;
        if (_shop != null)
        {
            //update
            ProcessUpdateShop processUpdate =
                new ProcessUpdateShop();

            _shop.Name = this.stxtName.Text;
            _shop.Description = this.txtDescription.Value;
            _shop.Code = this.stxtCode.Text;
            _shop.Rating = int.Parse(this.ctrlShopRating.Rate);
            _shop.Deleted = false;
            if (fuShopImage.HasFile)
            {
                _shop.ImageData.ImageData = fuShopImage.FileBytes;
            }
            else
            {
                ProcessGetShopImageByID processGetImage =
                       new ProcessGetShopImageByID();
                processGetImage.Shop = _shop;
                try
                {
                    processGetImage.Invoke();
                }
                catch (System.Exception ex)
                {
                    Response.Redirect("~/ErrorPage.aspx");
                }
                
                _shop.ImageData.ImageData = processGetImage.Shop.ImageData.ImageData;
            }
           

            processUpdate.Shop = _shop;
            try
            {
                processUpdate.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
            

        }
        else
        {
            _shop = new Shop();
            //Insert
            ProcessAddShop processAdd =
                new ProcessAddShop();
            _shop.EndUserID = new Guid(EndUserID);
            _shop.Name = this.stxtName.Text;
            _shop.Description = this.txtDescription.Value;            
            _shop.CreatedOn = Utilities.ShortDate();
            _shop.Code = this.stxtCode.Text;         
            _shop.Rating = int.Parse(this.ctrlShopRating.Rate);           
            _shop.Deleted = false;

            if (fuShopImage.HasFile)
            {
                _shop.ImageData.ImageData = fuShopImage.FileBytes;
            }
            else
            {

                FileStream stream = new FileStream(Server.MapPath("Images/NoImage.gif"), FileMode.Open, FileAccess.Read);
                BinaryReader bReader = new BinaryReader(stream);


                byte[] buffer = new byte[bReader.BaseStream.Length];
                buffer = bReader.ReadBytes((int)bReader.BaseStream.Length);

                _shop.ImageData.ImageData = buffer;
                stream.Close();
                bReader.Close();
            }
           

            processAdd.Shop = _shop;
            try
            {
                processAdd.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }

            _shop.ShopID = processAdd.Shop.ShopID;
        }
        return _shop;
    }
    protected void btnRemoveShopImage_Click(object sender, EventArgs e)
    {

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
