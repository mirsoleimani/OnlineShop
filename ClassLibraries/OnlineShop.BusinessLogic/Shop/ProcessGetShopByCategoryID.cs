using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnlineShop.DataAccess.Shop.Select;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShopByCategoryID:IBusinessLogic
    {
        private Common.Shop.Shop _shop;
        private DataSet _resultDataSet;
      
        
        public ProcessGetShopByCategoryID()
        {
            
        }
        public void Invoke()
        {
            ShopByCategoryIDSelectData selectData =
                new ShopByCategoryIDSelectData();
            selectData.Shop = Shop;
            ResultDataSet=selectData.Get();            

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
