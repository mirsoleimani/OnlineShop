using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using OnlineShop.DataAccess;
using OnlineShop.DataAccess.Shop.Select;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShopCategories:IBusinessLogic
    {
        private DataSet _resultDataSet;
               
        public void Invoke()
        {
            ShopCategoriesSelectData shopCategoriesData = new ShopCategoriesSelectData();
            ResultDataSet = shopCategoriesData.Get();
            
        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
    }
}
