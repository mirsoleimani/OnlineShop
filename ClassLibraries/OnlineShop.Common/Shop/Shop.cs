using System;
using System.Collections.Generic;

using System.Text;

using OnlineShop.Common.EndUser;

namespace OnlineShop.Common.Shop
{
    public class Shop:ShopCategory
    {
        #region Fields
        private int _shopID;
        private Guid _endUserID;       
        private Media.Image _imageData;
        private string _name;
        private string _description;
        private string _createdOn;
        private int _rating;      
        private string _code;
        private bool _deleted;
       
        #endregion

        public Shop()
        {
            ImageData = new OnlineShop.Common.Media.Image();
        }
        #region Properties
        public int ShopID
        {
            get { return _shopID; }
            set { _shopID = value; }
        }

        public Guid EndUserID
        {
            get { return _endUserID; }
            set { _endUserID = value; }
        }
        public Media.Image ImageData
        {
            get { return _imageData; }
            set { _imageData = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }
        #endregion
    }
}
