using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.EndUser;
using OnlineShop.DataAccess.EndUser.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
   public class ProcessGetPersonalInfoByEndUserID : IBusinessLogic
    {
        private PersonalInformation _personalInfo;
        private DataSet _resultDataSet;

        public void Invoke()
        {
            PersonalInfoByEndUserIDSelectData selectData =
                new PersonalInfoByEndUserIDSelectData();
            selectData.PersonalInfo = PersonalInfo;

            PersonalInfo = null;
            ResultDataSet = selectData.Get();
            
            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                PersonalInfo = new PersonalInformation();
                PersonalInfo.EndUserID =
                    new Guid(ResultDataSet.Tables[0].Rows[0]["EndUserID"].ToString());
                PersonalInfo.PersonalInformationID =
                    int.Parse(ResultDataSet.Tables[0].Rows[0]["PersonalInformationID"].ToString());
                PersonalInfo.FirstName =
                    ResultDataSet.Tables[0].Rows[0]["FirstName"].ToString();
                PersonalInfo.LastName =
                    ResultDataSet.Tables[0].Rows[0]["LastName"].ToString();
                PersonalInfo.EducationDegree =
                    ResultDataSet.Tables[0].Rows[0]["EducationDegree"].ToString();
                PersonalInfo.FatherName =
                    ResultDataSet.Tables[0].Rows[0]["FatherName"].ToString();
                PersonalInfo.Gender =
                    ResultDataSet.Tables[0].Rows[0]["Gender"].ToString();
                PersonalInfo.MaritalStatus =
                    ResultDataSet.Tables[0].Rows[0]["MaritalStatus"].ToString();
                PersonalInfo.Income =
                    ResultDataSet.Tables[0].Rows[0]["Income"].ToString();
                PersonalInfo.BirthDate =
                    ResultDataSet.Tables[0].Rows[0]["BirthDate"].ToString();
            }
        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
        public OnlineShop.Common.EndUser.PersonalInformation PersonalInfo
        {
            get { return _personalInfo; }
            set { _personalInfo = value; }
        }
    }
}
