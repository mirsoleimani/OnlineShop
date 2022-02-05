using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Product.Update;

namespace OnlineShop.BusinessLogic.Product
{
    public class ProcessUpdateProduct : IBusinessLogic
    {
        private Common.Product.Product _product;

        public void Invoke()
        {
            ProductUpdateData updateData =
                new ProductUpdateData();
            updateData.Product = Product;
            updateData.Update();
        }
        public Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

    }
}
