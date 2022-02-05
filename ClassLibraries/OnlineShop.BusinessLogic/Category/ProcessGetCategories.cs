using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Category.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.Category
{
    public class ProcessGetCategories:IBusinessLogic
    {
        private DataSet _resultDataSet;

        public void Invoke()
        {
            CategoriesSelectData selectData = new CategoriesSelectData();
            ResultDataSet = selectData.Get();

        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
    }
}
