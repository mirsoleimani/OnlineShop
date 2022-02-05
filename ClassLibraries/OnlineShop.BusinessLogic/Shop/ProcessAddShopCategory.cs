using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessAddShopCategory:IBusinessLogic
    {
        private Common.Shop.ShopCategory _shopCategory;

        public void Invoke()
        {
            DataAccess.Shop.Insert.ShopCategoryInsertData insertData =
                new OnlineShop.DataAccess.Shop.Insert.ShopCategoryInsertData();
            insertData.ShopCategory = ShopCategory;
            insertData.Add();
        }
        public Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }
    }
}
