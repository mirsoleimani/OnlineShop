using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Shop.Select.search;
using System.Data;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessSearchShops:IBusinessLogic
    {
        private string _searchCriteria;
        private bool _allWords;
        private int _pageNumber;
        private int _howManyPages;
        private DataTable _resultDataTable;
       
        
        public void Invoke()
        {
            ShopSearchSelectData selectData =
                new ShopSearchSelectData();
            ResultDataTable = 
                selectData.Search(SearchCriteria, AllWords, PageNumber, out _howManyPages);
            
        }

        public string SearchCriteria
        {
            get { return _searchCriteria; }
            set { _searchCriteria = value; }
        }

        public bool AllWords
        {
            get { return _allWords; }
            set { _allWords = value; }
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
