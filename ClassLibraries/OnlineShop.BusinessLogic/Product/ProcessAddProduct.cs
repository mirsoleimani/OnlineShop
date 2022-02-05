using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.Product
{
    public class ProcessAddProduct:IBusinessLogic
    {
        private Common.Product.Product _product;
     
        public void Invoke()
        {
            DataAccess.Product.Insert.ProductInsertData insertData =
                new OnlineShop.DataAccess.Product.Insert.ProductInsertData();
            insertData.Product = Product;
            insertData.Add();
        }
        public Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }
}
