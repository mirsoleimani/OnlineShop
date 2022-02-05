using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OnlineShop.DataAccess
{
    public static class OnlineShopConfiguration
    {
        private readonly static int _productsPerPage;        
        private readonly static int _productDescriptionLength;
        private readonly static int _shopsOnPage;    
        private readonly static int _shopDescriptionLength;
       
        static OnlineShopConfiguration()
        {
            _productsPerPage = Int32.Parse(ConfigurationManager.AppSettings["ProductsPerPage"]);
            _productDescriptionLength = Int32.Parse(ConfigurationManager.AppSettings["ProductDescriptionLength"]);
            _shopsOnPage = Int32.Parse(ConfigurationSettings.AppSettings["ShopsOnPage"]);
            _shopDescriptionLength = Int32.Parse(ConfigurationSettings.AppSettings["ShopDescriptionLength"]);

        }
        public static int ProductsOnPage
        {
            get { return _productsPerPage; }

        }
        public static int ProductDescriptionLength
        {
            get { return _productDescriptionLength; }
           
        }
        public static int ShopsOnPage
        {
            get { return _shopsOnPage; }
           
        }
        public static int ShopDescriptionLength
        {
            get { return _shopDescriptionLength; }
          
        }

    }
}
