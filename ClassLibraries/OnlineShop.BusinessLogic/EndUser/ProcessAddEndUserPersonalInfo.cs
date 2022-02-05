using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessAddEndUserPersonalInfo:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        public void Invoke()
        {
            DataAccess.EndUser.Insert.EndUserPersonalInfoInsertData _insertData =
                new OnlineShop.DataAccess.EndUser.Insert.EndUserPersonalInfoInsertData();
            _insertData.EndUser = EndUser;
            _insertData.Add();
            EndUser.PersonalInfoData.PersonalInformationID =
                _insertData.EndUser.PersonalInfoData.PersonalInformationID;
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
