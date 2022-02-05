using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessDeleteShopCategoryByID:IBusinessLogic
    {
        private Common.Shop.ShopCategory _shopCategory;

        public void Invoke()
        {
            DataAccess.Shop.Delete.ShopCategoryByIDDeleteData deleteData =
                new OnlineShop.DataAccess.Shop.Delete.ShopCategoryByIDDeleteData();
            deleteData.ShopCategory = ShopCategory;
            deleteData.Del();
        }
        public Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }
    }

}
