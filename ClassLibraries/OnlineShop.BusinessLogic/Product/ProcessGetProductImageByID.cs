using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OnlineShop.BusinessLogic.Product
{
    public class ProcessGetProductImageByID:IBusinessLogic
    {
        private OnlineShop.Common.Product.Product _product;        
        private Stream _imageStream;

        public void Invoke()
        {
            DataAccess.Product.Select.ProductImageByIDSelectData selectData =
                new OnlineShop.DataAccess.Product.Select.ProductImageByIDSelectData();
            selectData.Product = Product;
            Product.ImageData =((byte[]) selectData.Get());
            ImageStream = new MemoryStream((byte[])Product.ImageData);
        }


        public OnlineShop.Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public System.IO.Stream ImageStream
        {
            get { return _imageStream; }
            set { _imageStream = value; }
        }
    }
}
