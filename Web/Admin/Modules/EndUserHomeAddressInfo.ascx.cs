using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.EndUser;
using OnlineShop.BusinessLogic;
using System.Data;

public partial class Admin_Modules_CustomerHomeAddress : System.Web.UI.UserControl
{
    private OnlineShop.Common.EndUser.EndUser _endUser;
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
        ddlStateProvince.Items.Clear();
        ProcessGetStateProvinces processGet =
            new ProcessGetStateProvinces();
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }


        ddlStateProvince.DataSource = processGet.ResultDataSet;
        ddlStateProvince.DataTextField = "Name";
        ddlStateProvince.DataValueField = "StateProvinceID";
        ddlStateProvince.DataBind();
    }

    private void BindData()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.AddressInfoData.EndUserID = new Guid(EndUserID);
        _endUser.AddressInfoData.IsCareerAddress = false;

        ProcessGetEndUserAddressInfoByEndUserID processGet =
            new ProcessGetEndUserAddressInfoByEndUserID();
        processGet.EndUser = _endUser;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }


        if (processGet.EndUser != null)
        {
            _endUser = processGet.EndUser;
            txtAdd.Text = _endUser.AddressInfoData.Address1;
            txtAdd2.Text = _endUser.AddressInfoData.Address2;
            txtCity.Text = _endUser.AddressInfoData.City;
            txtPostalCode.Text = _endUser.AddressInfoData.PostalCode;
            ddlStateProvince.SelectedIndex =
                ddlStateProvince.Items.IndexOf(ddlStateProvince.Items.FindByValue(_endUser.AddressInfoData.StateProvinceID.ToString()));

        }

    }

    private void SaveInfo()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.AddressInfoData.EndUserID = new Guid(EndUserID);
        _endUser.AddressInfoData.IsCareerAddress = false;

        ProcessGetEndUserAddressInfoByEndUserID processGet =
            new ProcessGetEndUserAddressInfoByEndUserID();
        processGet.EndUser = _endUser;

        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }


        if (processGet.EndUser != null)
        {
            //update
            ProcessUpdateEndUserAddressInfo processUpdate =
                new ProcessUpdateEndUserAddressInfo();

            _endUser.AddressInfoData.AddressInformationID = 
                processGet.EndUser.AddressInfoData.AddressInformationID;
            _endUser.AddressInfoData.Address1 = txtAdd.Text;
            _endUser.AddressInfoData.Address2 = txtAdd2.Text;
            _endUser.AddressInfoData.City = txtCity.Text;
            _endUser.AddressInfoData.PostalCode = txtPostalCode.Text;
            _endUser.AddressInfoData.StateProvinceID = int.Parse(ddlStateProvince.SelectedValue);

            processUpdate.EndUser = _endUser;
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
            //Insert
            ProcessAddEndUserAddressInfo processAdd
                = new ProcessAddEndUserAddressInfo();

            _endUser.AddressInfoData.Address1 = txtAdd.Text;
            _endUser.AddressInfoData.Address2 = txtAdd2.Text;
            _endUser.AddressInfoData.City = txtCity.Text;
            _endUser.AddressInfoData.PostalCode = txtPostalCode.Text;
            _endUser.AddressInfoData.StateProvinceID = int.Parse(ddlStateProvince.SelectedValue);

            processAdd.EndUser = _endUser;

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

    private string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SaveInfo();
    }
    //protected void btnDelete_Click(object sender, EventArgs e)
    //{

    //}
}
