using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Shop.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShopsByEndUserID:IBusinessLogic
    {
                private Common.Shop.Shop _shop;
        private DataSet _resultDataSet;


        public ProcessGetShopsByEndUserID()
        {
            
        }
        public void Invoke()
        {
            ShopsByEndUserIDSelectData selectData =
                new ShopsByEndUserIDSelectData();
                
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
