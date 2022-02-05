using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.Product
{
    public class ProcessGetProductByID:IBusinessLogic
    {
        private Common.Product.Product _product;
      
        private DataSet _resultDataSet;

        public void Invoke()
        {
            DataAccess.Product.Select.ProductByIDSelectData selectData =
                new OnlineShop.DataAccess.Product.Select.ProductByIDSelectData();
            selectData.Product = Product;
            ResultDataSet = selectData.Get();
            Product = null;
            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                Product = new OnlineShop.Common.Product.Product();
                Product.ProductID = int.Parse(ResultDataSet.Tables[0].Rows[0]["ProductID"].ToString());
                Product.Name = ResultDataSet.Tables[0].Rows[0]["Name"].ToString();
                Product.ShopID = int.Parse(ResultDataSet.Tables[0].Rows[0]["ShopID"].ToString());
                Product.UnitPrice = int.Parse(ResultDataSet.Tables[0].Rows[0]["UnitPrice"].ToString());
                Product.ImageID = int.Parse(ResultDataSet.Tables[0].Rows[0]["ImageID"].ToString());
                Product.Description = ResultDataSet.Tables[0].Rows[0]["Description"].ToString();
                Product.EnableBuyButton = bool.Parse(ResultDataSet.Tables[0].Rows[0]["EnableBuyButton"].ToString());


            }


        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }

        public Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }
}
