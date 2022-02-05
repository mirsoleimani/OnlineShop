using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.Shop.Search
{
   public class ProcessSearchShopContactInfoByCategoryID:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        private DataSet _resultDataSet;

        public void Invoke()
        {
            DataAccess.Shop.Select.Search.ShopContactInfoByCategoryIDSearchData selectData =
                new OnlineShop.DataAccess.Shop.Select.Search.ShopContactInfoByCategoryIDSearchData();
            selectData.EndUser = EndUser;
            ResultDataSet = selectData.Search();
        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
