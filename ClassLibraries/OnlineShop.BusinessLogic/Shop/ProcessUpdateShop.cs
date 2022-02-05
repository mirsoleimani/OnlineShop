using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Shop.Update;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessUpdateShop:IBusinessLogic
    {
        private Common.Shop.Shop _shop;

        public void Invoke()
        {
            ShopUpdateData updateData = new ShopUpdateData();
            updateData.Shop = Shop;
            updateData.Update();
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }
}
