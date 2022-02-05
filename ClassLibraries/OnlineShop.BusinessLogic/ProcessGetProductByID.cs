using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common;
using OnlineShop.DataAccess.Select;
using System.Data;
using System.Data.SqlClient;
using OnlineShop.Common.Product;

namespace OnlineShop.BusinessLogic
{
    class ProcessGetProductByID:IBusinessLogic
    {
        private Product _Product;


        private DataSet _ResultSet;

   

        #region IBusinessLogic Members

        public void Invoke()
        {
            ProductSelectByIDData selectProduct = new ProductSelectByIDData();
            selectProduct.Product = Product;
            ResultSet = selectProduct.Get();
            Product.ProductName = ResultSet.Tables[0].Rows[0]["ProductName"].ToString();
            Product.ProductDescriotion = ResultSet.Tables[0].Rows[0]["Description"].ToString();
            Product.ProductPrice = Convert.ToDecimal(ResultSet.Tables[0].Rows[0]["Price"].ToString());
            Product.ProductImageID = int.Parse(ResultSet.Tables[0].Rows[0]["ProductImageID"].ToString());
            Product.ProductCategory.ProductCategoryName = ResultSet.Tables[0].Rows[0]["ProductCategoryName"].ToString();

        }

        #endregion
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }
        public DataSet ResultSet
        {
            get { return _ResultSet; }
            set { _ResultSet = value; }
        }
    }
}
