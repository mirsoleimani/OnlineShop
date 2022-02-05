using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessAddEndUserCareerInfo
    {
        private Common.EndUser.EndUser _endUser;

        public void Invoke()
        {
            DataAccess.EndUser.Insert.EndUserCareerInfoInsertData _insertData =
                new OnlineShop.DataAccess.EndUser.Insert.EndUserCareerInfoInsertData();
            _insertData.EndUser = EndUser;
            _insertData.Add();
            EndUser.CareerInfoData.CareerInformationID =
                _insertData.EndUser.CareerInfoData.CareerInformationID;
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
