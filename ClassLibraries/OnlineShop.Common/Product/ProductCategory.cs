using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.Product
{
    public class ProductCategory:Category
    {
        #region Fields
        private int _ProductCategoryID;
        private int _ProductID;
        private int _categoryID;
     
        
        #endregion
        public ProductCategory()
        {
            throw new System.NotImplementedException();
        }
        #region Properties
        public int ProductCategoryID
        {
            get { return _ProductCategoryID; }
            set { _ProductCategoryID = value; }
        }
        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        #endregion


    }
}
