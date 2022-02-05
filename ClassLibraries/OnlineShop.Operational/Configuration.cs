using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OnlineShop.Operational
{
    class Configuration
    {
        private readonly static int _productsPerPage;        
        private readonly static int _productDescriptionLength;

        static Configuration()
        {
            _productsPerPage = Int32.Parse(ConfigurationManager.AppSettings["ProductsPerPage"]);
            _productDescriptionLength = Int32.Parse(ConfigurationManager.AppSettings["ProductDescriptionLength"]);

        }
        public int ProductsPerPage
        {
            get { return _productsPerPage; }

        }
        public int ProductDescriptionLength
        {
            get { return _productDescriptionLength; }
           
        }
    }
}
