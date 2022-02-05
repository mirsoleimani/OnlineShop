using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OnlineShop.Common.Product
{
    public class Product
    {
        #region Fields
        private int _ProductID;
        private int _shopID;    
        private int _ProductCategoryID;
        private Category _Category;
        private string _Name;
        private int _ImageID;
        private Byte[] _ImageData;
        private string _Description;
        private Decimal _UnitPrice;
        private bool _enableBuyButton;
        
        #endregion


        public Product()
        {
        }
        #region Properties
        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        public int ShopID
        {
            get { return _shopID; }
            set { _shopID = value; }
        }
        public int ProductCategoryID
        {
            get { return _ProductCategoryID; }
            set { _ProductCategoryID = value; }
        }
        public Category Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int ImageID
        {
            get { return _ImageID; }
            set { _ImageID = value; }
        }
        public Byte[] ImageData
        {
            get { return _ImageData; }
            set { _ImageData = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public Decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }
        public bool EnableBuyButton
        {
            get { return _enableBuyButton; }
            set { _enableBuyButton = value; }
        }
        #endregion

    }
}
