using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessAddEndUser:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        public void Invoke()
        {
            DataAccess.EndUser.Insert.EndUserInsertData _insertData =
                new OnlineShop.DataAccess.EndUser.Insert.EndUserInsertData();
            _insertData.EndUser = EndUser;
            _insertData.Add();
            EndUser.EndUserID = _insertData.EndUser.EndUserID;
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
