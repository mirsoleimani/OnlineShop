using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop.BusinessLogic.EndUser;

public partial class Admin_Modules_EndUserCareerInfo : System.Web.UI.UserControl
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
        _endUser.CareerInfoData.EndUserID = new Guid(EndUserID);

        ProcessGetEndUserCareerInfoByEndUserID processGet =
            new ProcessGetEndUserCareerInfoByEndUserID();
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
        if(_endUser != null)
        {
            this.txtCareer.Text = _endUser.CareerInfoData.Career;
            this.txtCompany.Text = _endUser.CareerInfoData.Company;
            this.txtActivityField.Text = _endUser.CareerInfoData.ActivityField;
            this.txtActivityType.Text = _endUser.CareerInfoData.ActivityType;
            this.txtCareerGroup.Text = _endUser.CareerInfoData.CareerGroup;
            this.txtDeputation.Text = _endUser.CareerInfoData.Deputation;
            this.txtLicensor.Text = _endUser.CareerInfoData.Licensor;
            if(_endUser.CareerInfoData.LicenseHolder == true)
            {
                rbtnYes.Checked = true;
            }
            else
            {
                rbtnNo.Checked = true;
            }
            this.txtPosition.Text = _endUser.CareerInfoData.Position;

        }
        
    }

    private void SaveInfo()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        _endUser.CareerInfoData.EndUserID = new Guid(EndUserID);

        ProcessGetEndUserCareerInfoByEndUserID processGet =
            new ProcessGetEndUserCareerInfoByEndUserID();
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
            ProcessUpdateEndUserCareerInfo processUpdate =
                new ProcessUpdateEndUserCareerInfo();

            _endUser.CareerInfoData.CareerInformationID = processGet.EndUser.CareerInfoData.CareerInformationID;
            _endUser.CareerInfoData.ActivityField = txtActivityField.Text;
            _endUser.CareerInfoData.ActivityType = txtActivityType.Text;
            _endUser.CareerInfoData.Career = txtCareer.Text;
            _endUser.CareerInfoData.CareerGroup = txtCareerGroup.Text;
            _endUser.CareerInfoData.Company = txtCompany.Text;
            _endUser.CareerInfoData.Deputation = txtDeputation.Text;
            _endUser.CareerInfoData.Licensor = txtLicensor.Text;
            if (rbtnYes.Checked)
            {
                _endUser.CareerInfoData.LicenseHolder = true;
            }
            else
            {
                _endUser.CareerInfoData.LicenseHolder = false;
            }
            _endUser.CareerInfoData.Position = txtPosition.Text;

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
            ProcessAddEndUserCareerInfo processAdd
                = new ProcessAddEndUserCareerInfo();

            _endUser.CareerInfoData.ActivityField = txtActivityField.Text;
            _endUser.CareerInfoData.ActivityType = txtActivityType.Text;
            _endUser.CareerInfoData.Career = txtCareer.Text;
            _endUser.CareerInfoData.CareerGroup = txtCareerGroup.Text;
            _endUser.CareerInfoData.Company = txtCompany.Text;
            _endUser.CareerInfoData.Deputation = txtDeputation.Text;
            _endUser.CareerInfoData.Licensor = txtLicensor.Text;
            if (rbtnYes.Checked)
            {
                _endUser.CareerInfoData.LicenseHolder = true;
            }
            else
            {
                _endUser.CareerInfoData.LicenseHolder = false;
            }
            _endUser.CareerInfoData.Position = txtPosition.Text;

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
