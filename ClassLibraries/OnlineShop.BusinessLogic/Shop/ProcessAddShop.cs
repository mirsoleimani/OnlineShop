using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessAddShop:IBusinessLogic
    {
        private Common.Shop.Shop _shop;
       
        public void Invoke()
        {
            DataAccess.Shop.Insert.ShopInsertData insertData =
                new OnlineShop.DataAccess.Shop.Insert.ShopInsertData();
            insertData.Shop = Shop;
            insertData.Add();
            Shop.ShopID = insertData.Shop.ShopID;
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }
}
