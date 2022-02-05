using System;
using System.Collections.Generic;

using System.Text;

namespace OnlineShop.Common.Order
{
    public class Order
    {
        private int _OrderID;
        private string _EndUserID;
        private Common.EndUser.EndUser _EndUser;        
        private DateTime _CreatedOn;
        
        private int _OrderStatusID;
        
        private OrderDetail _OrderDetail;
        

        public Order()
        {
            throw new System.NotImplementedException();
        }

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        public string EndUserID
        {
            get { return _EndUserID; }
            set { _EndUserID = value; }
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _EndUser; }
            set { _EndUser = value; }
        }
        
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
      
        public int OrderStatusID
        {
            get { return _OrderStatusID; }
            set { _OrderStatusID = value; }
        }
        
        internal OrderDetail OrderDetail
        {
            get { return _OrderDetail; }
            set { _OrderDetail = value; }
        }
        
    }
}
