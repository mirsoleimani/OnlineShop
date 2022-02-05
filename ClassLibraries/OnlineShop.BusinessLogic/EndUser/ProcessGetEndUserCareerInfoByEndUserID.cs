using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.EndUser.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessGetEndUserCareerInfoByEndUserID:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;
        
        private DataSet _resultDataSet;

        public void Invoke()
        {
            EndUserCareerInfoByEndUserIDSelectData selectData =
                new EndUserCareerInfoByEndUserIDSelectData();
            selectData.EndUser = EndUser;

            EndUser = null;
            ResultDataSet = selectData.Get();

            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                EndUser = new OnlineShop.Common.EndUser.EndUser();
                EndUser.CareerInfoData.EndUserID =
                    new Guid(ResultDataSet.Tables[0].Rows[0]["EndUserID"].ToString());
                EndUser.CareerInfoData.CareerInformationID =
                    int.Parse(ResultDataSet.Tables[0].Rows[0]["CareerInformationID"].ToString());
                EndUser.CareerInfoData.Company =
                    ResultDataSet.Tables[0].Rows[0]["Company"].ToString();
                EndUser.CareerInfoData.Career =
                    ResultDataSet.Tables[0].Rows[0]["Career"].ToString();
                EndUser.CareerInfoData.Position =
                    ResultDataSet.Tables[0].Rows[0]["Position"].ToString();
                EndUser.CareerInfoData.CareerGroup =
                    ResultDataSet.Tables[0].Rows[0]["CareerGroup"].ToString();
                EndUser.CareerInfoData.ActivityType =
                    ResultDataSet.Tables[0].Rows[0]["ActivityType"].ToString();
                EndUser.CareerInfoData.ActivityField =
                    ResultDataSet.Tables[0].Rows[0]["ActivityField"].ToString();
                EndUser.CareerInfoData.LicenseHolder =
                   bool.Parse(ResultDataSet.Tables[0].Rows[0]["LicenseHolder"].ToString());
                EndUser.CareerInfoData.Licensor =
                    ResultDataSet.Tables[0].Rows[0]["Licensor"].ToString();
                EndUser.CareerInfoData.Deputation =
                    ResultDataSet.Tables[0].Rows[0]["Deputation"].ToString();
            }
        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
