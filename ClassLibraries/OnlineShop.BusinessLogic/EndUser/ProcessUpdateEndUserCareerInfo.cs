using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.EndUser.Update;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessUpdateEndUserCareerInfo:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        public void Invoke()
        {
            EndUserCareerInfoUpdateData updateData =
                new  EndUserCareerInfoUpdateData();
            updateData.EndUser = EndUser;
            updateData.Update();
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
