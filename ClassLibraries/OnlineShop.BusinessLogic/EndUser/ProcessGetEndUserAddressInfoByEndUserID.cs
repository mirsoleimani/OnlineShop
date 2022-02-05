using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.EndUser.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessGetEndUserAddressInfoByEndUserID : IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        private DataSet _resultDataSet;

        public void Invoke()
        {
            EndUserAddressInfoByEndUserIDSelectData selectData =
                new EndUserAddressInfoByEndUserIDSelectData();
            selectData.EndUser = EndUser;

            EndUser = null;
            ResultDataSet = selectData.Get();
            
            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                EndUser = new OnlineShop.Common.EndUser.EndUser();
                EndUser.AddressInfoData.EndUserID =
                    new Guid(ResultDataSet.Tables[0].Rows[0]["EndUserID"].ToString());
                EndUser.AddressInfoData.AddressInformationID =
                    int.Parse(ResultDataSet.Tables[0].Rows[0]["AddressInformationID"].ToString());
                EndUser.AddressInfoData.IsCareerAddress =
                    bool.Parse(ResultDataSet.Tables[0].Rows[0]["IsCareerAddress"].ToString());
                EndUser.AddressInfoData.StateProvinceID =
                    int.Parse(ResultDataSet.Tables[0].Rows[0]["StateProvinceID"].ToString());
                EndUser.AddressInfoData.PostalCode =
                    ResultDataSet.Tables[0].Rows[0]["PostalCode"].ToString();
                EndUser.AddressInfoData.Address1 =
                    ResultDataSet.Tables[0].Rows[0]["Address1"].ToString();
                EndUser.AddressInfoData.Address2 =
                    ResultDataSet.Tables[0].Rows[0]["Address2"].ToString();
                EndUser.AddressInfoData.City =
                    ResultDataSet.Tables[0].Rows[0]["City"].ToString();

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
