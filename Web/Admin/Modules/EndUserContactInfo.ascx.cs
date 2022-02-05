using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.BusinessLogic.EndUser;
using OnlineShop.Operational;

public partial class Admin_Modules_CustomerContactInfo : System.Web.UI.UserControl
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
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.ContactInfodata.EndUserID = new Guid(EndUserID);

        ProcessGetEndUserContactInfoByEndUserID processGet =
            new ProcessGetEndUserContactInfoByEndUserID();
        processGet.EndUser = _endUser;
        try
        {
            processGet.Invoke();
        }
        catch (System.Exception ex)
        {
            Response.Redirect("~/ErrorPage.aspx");
        }


        _endUser = processGet.EndUser;
        if (_endUser != null)
        {
            this.txtAreaCode.Text = _endUser.ContactInfodata.AreaCode;
            this.txtCellPhone.Text = _endUser.ContactInfodata.CellPhone;
            this.txtFax.Text = _endUser.ContactInfodata.Fax;
            this.txtPhone.Text = _endUser.ContactInfodata.Phone;
            this.etxtEmail.Text = _endUser.ContactInfodata.Email;
        

        }

    }

    private void SaveInfo()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.ContactInfodata.EndUserID = new Guid(EndUserID);

        ProcessGetEndUserContactInfoByEndUserID processGet =
            new ProcessGetEndUserContactInfoByEndUserID();
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
            ProcessUpdateEndUserContactInfo processUpdate =
                new ProcessUpdateEndUserContactInfo();

            _endUser.ContactInfodata.ContactInformationID = processGet.EndUser.ContactInfodata.ContactInformationID;
            _endUser.ContactInfodata.AreaCode = txtAreaCode.Text.Trim();
            _endUser.ContactInfodata.CellPhone = txtCellPhone.Text.Trim();
            _endUser.ContactInfodata.Fax = txtFax.Text.Trim();
            _endUser.ContactInfodata.Phone = txtPhone.Text.Trim();
            _endUser.ContactInfodata.Email = etxtEmail.Text.Trim();


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
            ProcessAddEndUserContactInfo processAdd
                = new ProcessAddEndUserContactInfo();

            _endUser.ContactInfodata.AreaCode = txtAreaCode.Text.Trim();
            _endUser.ContactInfodata.CellPhone = txtCellPhone.Text.Trim();
            _endUser.ContactInfodata.Fax = txtFax.Text.Trim();
            _endUser.ContactInfodata.Phone = txtPhone.Text.Trim();
            _endUser.ContactInfodata.Email = etxtEmail.Text.Trim();
        

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
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SaveInfo();
    }
    //protected void btnDelete_Click(object sender, EventArgs e)
    //{

    //}

    private string EndUserID
    {
        get
        {
            return Utilities.QueryString("EndUserID");
        }
    }
}
