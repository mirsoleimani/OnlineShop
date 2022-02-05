using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Shop.Select.Search;
using System.Data;

namespace OnlineShop.BusinessLogic.Shop
{
    public  class ProcessSearchShopByCareerInfoAdvanced:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
        private int _pageNumber;
        private int _howManyPages;
        private DataTable _resultDataTable;


        public void Invoke()
        {
            ShopSearchCareerAdvancedSelectData selectData =
                new ShopSearchCareerAdvancedSelectData();
            selectData.EndUser = EndUser;
            ResultDataTable =
                selectData.Search(PageNumber, out _howManyPages);

        }

        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }
        public int HowManyPages
        {
            get { return _howManyPages; }
        }
        public System.Data.DataTable ResultDataTable
        {
            get { return _resultDataTable; }
            set { _resultDataTable = value; }
        }
    }
}
