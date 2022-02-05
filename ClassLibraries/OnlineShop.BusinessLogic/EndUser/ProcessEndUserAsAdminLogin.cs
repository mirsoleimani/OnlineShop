using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.EndUser.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessEndUserAsAdminLogin
    {
        private Common.EndUser.EndUser _endUser;

        private DataSet _resultDataSet;

        public void Invoke()
        {
            EndUserAsAdminLoginSelectData selectData =
                new EndUserAsAdminLoginSelectData();
            selectData.EndUser = EndUser;

            EndUser = null;
            ResultDataSet = selectData.Get();

            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                EndUser = new OnlineShop.Common.EndUser.EndUser();
                EndUser.EndUserID =
                    new Guid(ResultDataSet.Tables[0].Rows[0]["EndUserID"].ToString());
                EndUser.UserName =
                   ResultDataSet.Tables[0].Rows[0]["UserName"].ToString();           
                EndUser.PasswordHash =
                    ResultDataSet.Tables[0].Rows[0]["PasswordHash"].ToString();
                EndUser.PasswordSalt =
                    ResultDataSet.Tables[0].Rows[0]["PasswordSalt"].ToString();
                EndUser.CreatedOn =
                    ResultDataSet.Tables[0].Rows[0]["CreatedOn"].ToString();
               

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
