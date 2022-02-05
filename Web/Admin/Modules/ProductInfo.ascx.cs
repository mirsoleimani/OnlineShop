using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.Product;
using OnlineShop.BusinessLogic.Shop;
using System.IO;

public partial class Admin_Modules_ProductInfo : System.Web.UI.UserControl
{
    private OnlineShop.Common.Product.Product _product;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillDropDowns();
            BindData();
           
        }
    }

    private void FillDropDowns()
    {
        ProcessGetShops processGet =
            new ProcessGetShops();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        ddlShops.DataSource = processGet.ResultDataSet;
        ddlShops.DataTextField = "Name";
        ddlShops.DataValueField = "ShopID";
        ddlShops.DataBind();

        ddlShops.SelectedIndex = ddlShops.Items.IndexOf(ddlShops.Items.FindByValue(ShopID.ToString()));
        ddlShops.Enabled = false;
    }

    private void BindData()
    {
        _product = new OnlineShop.Common.Product.Product();
        _product.ProductID = ProductID;

        ProcessGetProductByID processGet =
            new ProcessGetProductByID();
        processGet.Product = _product;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        _product = processGet.Product;
        if (_product != null)
        {
            
            ListItem item = ddlShops.Items.FindByValue(_product.ShopID.ToString());
            if (item != null)
            {
                int index = ddlShops.Items.IndexOf(item);
                ddlShops.SelectedIndex = index;
                
            }

            this.stxtName.Text = _product.Name;      
            this.txtDescription.Value = _product.Description;
            this.txtProductPrice.Value = _product.UnitPrice;
            this.cbEnableBuyButton.Checked = _product.EnableBuyButton;
            this.iProductPicture.ImageUrl =
                 Page.ResolveUrl("~/" + string.Format("ProductImageViewer.ashx?ImageID={0}", _product.ImageID));
        }
        else { }
    }

    public OnlineShop.Common.Product.Product SaveInfo()
    {
        _product = new OnlineShop.Common.Product.Product();
        _product.ProductID = ProductID;

        ProcessGetProductByID processGet =
            new ProcessGetProductByID();
        processGet.Product = _product;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }

        _product = processGet.Product;
        if (_product != null)
        {
            //Update
            _product.ShopID = ShopID;
            _product.Name = this.stxtName.Text;
            _product.UnitPrice = this.txtProductPrice.Value;
            _product.Description = this.txtDescription.Value;
            _product.EnableBuyButton = this.cbEnableBuyButton.Checked;

            if (fuProductImage.HasFile)
            {
                _product.ImageData = fuProductImage.FileBytes;
            }
            else
            {
                ProcessGetProductImageByID processGetImage =
                       new ProcessGetProductImageByID();
                processGetImage.Product = _product;

                try
                {
                    processGetImage.Invoke();
                }
                catch (System.Exception ex)
                {
                    Response.Redirect("~/ErrorPage.aspx");
                }

                _product.ImageData = processGetImage.Product.ImageData;
            }

            ProcessUpdateProduct processUpdate =
                new ProcessUpdateProduct();
            processUpdate.Product = _product;

           
            try
            {
                processUpdate.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
            return _product;

        }
        else
        {
            //Insert
            _product = new OnlineShop.Common.Product.Product();
            _product.ShopID = ShopID;
            _product.Name = this.stxtName.Text;
            _product.UnitPrice = this.txtProductPrice.Value;
            _product.Description = this.txtDescription.Value;
            _product.EnableBuyButton = this.cbEnableBuyButton.Checked;

            if (fuProductImage.HasFile)
            {
                _product.ImageData = fuProductImage.FileBytes;
            }
            else
            {

                FileStream stream = new FileStream(Server.MapPath("Images/NoImage.gif"), FileMode.Open,FileAccess.Read);
                BinaryReader bReader = new BinaryReader(stream);

                
                byte[] buffer = new byte[bReader.BaseStream.Length];
                buffer = bReader.ReadBytes((int)bReader.BaseStream.Length);
               
                _product.ImageData = buffer;
                stream.Close();
                bReader.Close();
            }

            ProcessAddProduct processAdd =
                new ProcessAddProduct();
            processAdd.Product = _product;
            
            try
            {
                processAdd.Invoke();
            }
            catch (System.Exception ex)
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
            return _product;

        }
    }
    protected void btnRemoveProductImage_Click(object sender, EventArgs e)
    {

    }

    private int ProductID
    {
        get
        {
            return Utilities.QueryStringInt("ProductID");
        }
    }

    private int ShopID
    {
        get
        {
            return Utilities.QueryStringInt("ShopID");
        }
    }
    //private int ProductImageID
    //{
    //    set
    //    {
    //        ViewState["PRODUCTIMAGEID"] = value;
    //    }
    //    get
    //    {
    //        return (int)ViewState["PRODUCTIMAGEID"];
    //    }
    //}
}
