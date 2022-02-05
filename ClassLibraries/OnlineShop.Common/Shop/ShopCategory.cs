using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.Shop
{
   public class ShopCategory : Category
    {
        #region Fields
        private int _shopCategryID;
        private int _shopID;

        #endregion
        #region Properties
        public int ShopCategryID
        {
            get { return _shopCategryID; }
            set { _shopCategryID = value; }
        }
        public int ShopID
        {
            get { return _shopID; }
            set { _shopID = value; }
        }
        #endregion
    }
}
