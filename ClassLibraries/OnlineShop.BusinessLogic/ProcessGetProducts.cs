using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnlineShop.DataAccess.Select;

namespace OnlineShop.BusinessLogic
{
    public class ProcessGetProducts:IBusinessLogic
    {
        private DataSet _resultSet;
        

        #region IBusinessLogic Members

        public void Invoke()
        {
            ProductSelectData productData = new ProductSelectData();
            ResultSet = productData.Get();
        }

        #endregion
        public DataSet ResultSet
        {
            get { return _resultSet; }
            set { _resultSet = value; }
        }
    }
}
