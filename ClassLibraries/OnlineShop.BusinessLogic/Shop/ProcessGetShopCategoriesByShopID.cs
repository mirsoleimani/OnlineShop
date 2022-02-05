using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Shop.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShopCategoriesByShopID : IBusinessLogic
    {
        private Common.Shop.Shop _shop;
        private DataSet _resultDataSet;


        public ProcessGetShopCategoriesByShopID()
        {

        }
        public void Invoke()
        {
            ShopCategoriesByShopIDSelectData selectData =
                new ShopCategoriesByShopIDSelectData();

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
