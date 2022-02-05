using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnlineShop.Common.EndUser;
using OnlineShop.DataAccess.EndUser.Select;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessGetEndUserRoles:IBusinessLogic
    {
        private DataSet _ResultDataSet;

        public void Invoke()
        {
            EndUserRolesSelectData SelectData =
                new EndUserRolesSelectData();
            ResultDataSet = SelectData.Get();

        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _ResultDataSet; }
            set { _ResultDataSet = value; }
        }
    }
}
