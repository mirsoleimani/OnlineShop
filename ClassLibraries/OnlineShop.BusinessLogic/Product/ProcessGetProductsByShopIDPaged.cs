using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.Product
{
    public class ProcessGetProductsByShopIDPaged:IBusinessLogic
    {
        private Common.Shop.Shop _shop;
        private int _pageNumber;
        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }
        private int _howManyPages;
        public int HowManyPages
        {
            get { return _howManyPages; }
            set { _howManyPages = value; }
        }
        private DataTable _resultDataTable;
        public System.Data.DataTable ResultDataTable
        {
            get { return _resultDataTable; }
            set { _resultDataTable = value; }
        }
        public void Invoke()
        {
            DataAccess.Product.Select.ProductsByShopIDPagedSelectData selectData =
                new OnlineShop.DataAccess.Product.Select.ProductsByShopIDPagedSelectData();
            selectData.Shop = Shop;
            ResultDataTable = selectData.Get(PageNumber, out _howManyPages);
        }

        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }
}
