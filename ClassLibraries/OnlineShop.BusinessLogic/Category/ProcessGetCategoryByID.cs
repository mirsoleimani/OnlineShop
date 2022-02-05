using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.Category
{
    public class ProcessGetCategoryByID : IBusinessLogic
    {
        private Common.Category _category;
        private DataSet _resultDataSet;

        public void Invoke()
        {
            DataAccess.Category.Select.CategoryByIDSelectData selectData =
                new OnlineShop.DataAccess.Category.Select.CategoryByIDSelectData();
            selectData.Category = Category;
            ResultDataSet = selectData.Get();
            Category = null;
            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                Category = new OnlineShop.Common.Category();
                Category.CategoryID = int.Parse(ResultDataSet.Tables[0].Rows[0]["CategoryID"].ToString());
                Category.Name = ResultDataSet.Tables[0].Rows[0]["Name"].ToString();
                Category.Description = ResultDataSet.Tables[0].Rows[0]["Description"].ToString();
                Category.ImageID = int.Parse(ResultDataSet.Tables[0].Rows[0]["ImageID"].ToString());
               
            }


        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }

        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
