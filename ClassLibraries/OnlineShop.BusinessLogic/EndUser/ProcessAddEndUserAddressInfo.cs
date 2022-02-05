using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessAddEndUserAddressInfo:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        public void Invoke()
        {
            DataAccess.EndUser.Insert.EndUserAddressInfoInsertData _insertData =
                new OnlineShop.DataAccess.EndUser.Insert.EndUserAddressInfoInsertData();
            _insertData.EndUser = EndUser;
            _insertData.Add();
            EndUser.AddressInfoData.AddressInformationID =
                _insertData.EndUser.AddressInfoData.AddressInformationID;
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
