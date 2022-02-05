using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common
{
    public class ShopingCart
    {
        private int _ShoppingCartID;

        public int ShoppingCartID
        {
            get { return _ShoppingCartID; }
            set { _ShoppingCartID = value; }
        }
        private string _CartGUID;

        public string CartGUID
        {
            get { return _CartGUID; }
            set { _CartGUID = value; }
        }
        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        private int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }
    }
}
