using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.EndUser.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessGetEndUserContactInfoByEndUserID:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        private DataSet _resultDataSet;

        public void Invoke()
        {
            EndUserContactInfoByEndUserIDSelectData selectData =
                new EndUserContactInfoByEndUserIDSelectData();
            selectData.EndUser = EndUser;

            EndUser = null;
            ResultDataSet = selectData.Get();

            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                EndUser = new OnlineShop.Common.EndUser.EndUser();
                EndUser.ContactInfodata.EndUserID =
                    new Guid(ResultDataSet.Tables[0].Rows[0]["EndUserID"].ToString());
                EndUser.ContactInfodata.ContactInformationID =
                    int.Parse(ResultDataSet.Tables[0].Rows[0]["ContactInformationID"].ToString());
                EndUser.ContactInfodata.CellPhone =
                    ResultDataSet.Tables[0].Rows[0]["CellPhone"].ToString();
                EndUser.ContactInfodata.Phone =
                    ResultDataSet.Tables[0].Rows[0]["Phone"].ToString();
                EndUser.ContactInfodata.Fax =
                    ResultDataSet.Tables[0].Rows[0]["Fax"].ToString();
                EndUser.ContactInfodata.Email =
                    ResultDataSet.Tables[0].Rows[0]["Email"].ToString();
                EndUser.ContactInfodata.AreaCode =
                    ResultDataSet.Tables[0].Rows[0]["AreaCode"].ToString();  
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
