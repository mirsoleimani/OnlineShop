using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Product.Select.Search;
using System.Data;

namespace OnlineShop.BusinessLogic.Product
{
    public class ProcessSearchProducts:IBusinessLogic
    {
        private string _searchCriteria;
        private bool _allWords;
        private int _pageNumber;
        private int _howManyPages;
        private DataTable _resultDataTable;


        public void Invoke()
        {
            ProductSearchSelectData selectData =
                new ProductSearchSelectData();
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
