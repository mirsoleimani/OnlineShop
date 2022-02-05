using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;
using OnlineShop;
using OnlineShop.BusinessLogic.EndUser;

public partial class Admin_Modules_CustomerInfo : System.Web.UI.UserControl
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
        _endUser.PersonalInfoData.EndUserID = new Guid(EndUserID);

        ProcessGetPersonalInfoByEndUserID processGet =
            new ProcessGetPersonalInfoByEndUserID();
        processGet.PersonalInfo = _endUser.PersonalInfoData;
        processGet.Invoke();

        _endUser.PersonalInfoData = processGet.PersonalInfo;
        if (_endUser.PersonalInfoData != null)
        {
            this.stxtName.Text = _endUser.PersonalInfoData.FirstName;
            this.stxtFamily.Text = _endUser.PersonalInfoData.LastName;
            this.stxtFatherName.Text = _endUser.PersonalInfoData.FatherName;
            this.ctrlPersianCalendar.Value = _endUser.PersonalInfoData.BirthDate;
            if (_endUser.PersonalInfoData.Gender == "مرد")
            {
                this.rbtnMale.Checked = true;
            }
            else
            {
                this.rbtnFemale.Checked = true;
            }

            if (_endUser.PersonalInfoData.MaritalStatus == "متاهل")
            {
                this.rbtnMarried.Checked = true;
            }
            else
            {
                this.rbtnSingle.Checked = true;
            }
            switch (_endUser.PersonalInfoData.Income)
            {
                case "100":
                    this.rbtn100.Checked = true;
                    break;
                case "300":
                    this.rbtn300.Checked = true;
                    break;
                case "500":
                    this.rbtn500.Checked = true;
                    break;
                case "700":
                    this.rbtn700.Checked = true;
                    break;

            }


            switch (_endUser.PersonalInfoData.EducationDegree)
            {
                case "1":
                    this.rbtn1st.Checked = true;
                    break;
                case "2":
                    this.rbtn2ed.Checked = true;
                    break;
                case "3":
                    this.rbtn3rd.Checked = true;
                    break;
                case "4":
                    this.rbtn4th.Checked = true;
                    break;

            }


        }
        else
        {

        }



    }

    private void SaveInfo()
    {
        _endUser = new OnlineShop.Common.EndUser.EndUser();
        ProcessGetPersonalInfoByEndUserID processGet =
            new ProcessGetPersonalInfoByEndUserID();
        _endUser.PersonalInfoData.EndUserID = new Guid(EndUserID);
        processGet.PersonalInfo = _endUser.PersonalInfoData;

        processGet.Invoke();
        if (processGet.PersonalInfo != null)
        {
            //Update
            ProcessUpdateEndUserPersonalInfo processUpdate =
                new ProcessUpdateEndUserPersonalInfo();
            _endUser.PersonalInfoData.PersonalInformationID = processGet.PersonalInfo.PersonalInformationID;
            _endUser.PersonalInfoData.FirstName = this.stxtName.Text;
            _endUser.PersonalInfoData.LastName = this.stxtFamily.Text;
            _endUser.PersonalInfoData.FatherName = this.stxtFatherName.Text;
            _endUser.PersonalInfoData.BirthDate = this.ctrlPersianCalendar.Value;
            _endUser.PersonalInfoData.RegisteredBy = HttpContext.Current.User.Identity.Name;

            if (this.rbtnMale.Checked)
            {
                _endUser.PersonalInfoData.Gender = "مرد";
            }
            else
            {
                _endUser.PersonalInfoData.Gender = "زن";
            }

            if (this.rbtnMarried.Checked)
            {
                _endUser.PersonalInfoData.MaritalStatus = "متاهل";
            }
            else
            {
                _endUser.PersonalInfoData.MaritalStatus = "مجرد";
            }


            if (this.rbtn100.Checked)
            {
                _endUser.PersonalInfoData.Income = "100";
            }
            else if (this.rbtn300.Checked)
            {
                _endUser.PersonalInfoData.Income = "300";
            }
            else if (this.rbtn500.Checked)
            {
                _endUser.PersonalInfoData.Income = "500";
            }
            else if (this.rbtn700.Checked)
            {
                _endUser.PersonalInfoData.Income = "700";
            }
            else
            {
                _endUser.PersonalInfoData.Income = string.Empty;
            }

            if (this.rbtn1st.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "1";
            }
            else if (this.rbtn2ed.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "2";
            }
            else if (this.rbtn3rd.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "3";
            }
            else if (this.rbtn4th.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "4";
            }
            else
            {
                _endUser.PersonalInfoData.EducationDegree = string.Empty;
            }
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
            ProcessAddEndUserPersonalInfo processAdd =
                new ProcessAddEndUserPersonalInfo();
            _endUser.PersonalInfoData.FirstName = this.stxtName.Text;
            _endUser.PersonalInfoData.LastName = this.stxtFamily.Text;
            _endUser.PersonalInfoData.FatherName = this.stxtFatherName.Text;
            _endUser.PersonalInfoData.BirthDate = this.ctrlPersianCalendar.Value;
            _endUser.PersonalInfoData.RegisteredBy = HttpContext.Current.User.Identity.Name;

            if (this.rbtnMale.Checked)
            {
                _endUser.PersonalInfoData.Gender = "مرد";
            } 
            else
            {
                _endUser.PersonalInfoData.Gender = "زن";
            }

            if (this.rbtnMarried.Checked)           
            {
                _endUser.PersonalInfoData.MaritalStatus = "متاهل";
            }
            else
            {
                _endUser.PersonalInfoData.MaritalStatus = "مجرد";
            }
            

            if (this.rbtn100.Checked )
            {
                _endUser.PersonalInfoData.Income = "100";
            }
            else if(this.rbtn300.Checked)
            {
                _endUser.PersonalInfoData.Income = "300";
            }
            else if(this.rbtn500.Checked)
            {
                _endUser.PersonalInfoData.Income = "500";
            }
            else if (this.rbtn700.Checked)
            {
                _endUser.PersonalInfoData.Income = "700";
            }
            else
            {
                _endUser.PersonalInfoData.Income = string.Empty;
            }

            if (this.rbtn1st.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "1";
            }
            else if (this.rbtn2ed.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "2";
            }
            else if (this.rbtn3rd.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "3";
            }
            else if (this.rbtn4th.Checked)
            {
                _endUser.PersonalInfoData.EducationDegree = "4";
            }
            else
            {
                _endUser.PersonalInfoData.EducationDegree = string.Empty;
            }

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
    ////protected void btnDelete_Click(object sender, EventArgs e)
    ////{

    ////}
}
