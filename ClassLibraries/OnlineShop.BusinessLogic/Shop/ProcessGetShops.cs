using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnlineShop.DataAccess.Shop.Select;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShops:IBusinessLogic
    {
        private DataSet _resultDataSet;

        public void Invoke()
        {
            ShopsSelectData selectData = new ShopsSelectData();
            ResultDataSet = selectData.Get();

        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
    }
}
