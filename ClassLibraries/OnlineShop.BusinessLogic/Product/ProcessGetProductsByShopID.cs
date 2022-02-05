using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.Product
{

    public class ProcessGetProductsByShopID : IBusinessLogic
    {
        private Common.Shop.Shop _shop;
        private DataSet _resultDataSet;

        public void Invoke()
        {
            DataAccess.Product.Select.ProductsByShopIDSelectData selectData =
                new OnlineShop.DataAccess.Product.Select.ProductsByShopIDSelectData();
            selectData.Shop = Shop;
            ResultDataSet = selectData.Get();
        }

        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
    }
}
