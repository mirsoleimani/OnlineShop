using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Product.Select
{

    public class ProductsByShopIDSelectData : DataAccessBase
    {
        private Common.Shop.Shop _shop;

        public ProductsByShopIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ProductsByShopID_Select.ToString();
        }
        public DataSet Get()
        {
            DataSet ds;
            ProductsByShopIDSelectDataParameters selectDataParameters =
                new ProductsByShopIDSelectDataParameters(Shop);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, selectDataParameters.Parameters);
            return ds;

        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }

    class ProductsByShopIDSelectDataParameters
    {
        private Common.Shop.Shop _shop;

        private SqlParameter[] _parameters;

        public ProductsByShopIDSelectDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;

            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ShopID",Shop.ShopID),
                                           new SqlParameter("@DescriptionLength",OnlineShopConfiguration.ProductDescriptionLength),
                                          
                                       };
            Parameters = parameters;
        }

        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }

    }
}
