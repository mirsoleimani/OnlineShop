using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Product;

namespace OnlineShop.Common.Order
{
    public class OrderDetail
    {
        private int _OrderDetailID;
        private int _OrderID;
        private int _ProductID;
        private Common.Product.Product _Product;
        private int _Quantity;

        public int OrderDetailID
        {
            get { return _OrderDetailID; }
            set { _OrderDetailID = value; }
        }
        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        internal Common.Product.Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
    }
}
