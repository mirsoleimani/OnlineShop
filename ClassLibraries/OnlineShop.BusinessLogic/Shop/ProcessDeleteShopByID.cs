using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessDeleteShopByID : IBusinessLogic
    {

        private Common.Shop.Shop _shop;

        public void Invoke()
        {
            DataAccess.Shop.Delete.ShopByIDDeleteData deleteData =
                new OnlineShop.DataAccess.Shop.Delete.ShopByIDDeleteData();
            deleteData.Shop = Shop;
            deleteData.Del();
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }


    }
}
