using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.EndUser.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessGetEndUsers:IBusinessLogic
    {
        private DataSet _resultDataSet;

        public void Invoke()
        {
            EndUsersSelectData selectData = new EndUsersSelectData();
            ResultDataSet = selectData.Get();

        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
    }
}
