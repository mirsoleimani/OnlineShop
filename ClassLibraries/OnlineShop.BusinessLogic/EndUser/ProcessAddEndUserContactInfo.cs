using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessAddEndUserContactInfo:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        public void Invoke()
        {
            DataAccess.EndUser.Insert.EndUserContactInfoInsertData _insertData =
                new OnlineShop.DataAccess.EndUser.Insert.EndUserContactInfoInsertData();
            _insertData.EndUser = EndUser;
            _insertData.Add();
            EndUser.ContactInfodata.ContactInformationID=
                _insertData.EndUser.ContactInfodata.ContactInformationID;
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }

    }
}
