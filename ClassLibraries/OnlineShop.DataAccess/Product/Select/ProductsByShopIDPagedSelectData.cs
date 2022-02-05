using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Product.Select
{
    public class ProductsByShopIDPagedSelectData:DataAccessBase
    {
                private Common.Shop.Shop _shop;

        public ProductsByShopIDPagedSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ProductsByShopIDPaged_Select.ToString();
        }
        public DataTable Get(int pageNumber,out int howManyPages)
        {
            DataSet ds;
            ProductsByShopIDPagedSelectDataParameters selectDataParameters =
                new ProductsByShopIDPagedSelectDataParameters(Shop, pageNumber);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString,CommandType.StoredProcedure, selectDataParameters.Parameters);
            int howManyProducts = Int32.Parse(selectDataParameters.Parameters[0].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)OnlineShopConfiguration.ProductsOnPage);
            return ds.Tables[0];
         

        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }

    }

    class ProductsByShopIDPagedSelectDataParameters
    {
            private Common.Shop.Shop _shop;

            private SqlParameter[] _parameters;

            public ProductsByShopIDPagedSelectDataParameters(Common.Shop.Shop shop, int pageNumber)
            {
                Shop = shop;

                Build(pageNumber);
            }

            private void Build(int pageNumber)
            {
                SqlParameter outParam = new SqlParameter();
                outParam.ParameterName = "@HowManyResults";
                outParam.DbType = DbType.Int32;
                outParam.Direction = ParameterDirection.Output;
                SqlParameter[] parameters ={
                                           outParam,
                                           new SqlParameter("@ShopID",Shop.ShopID),
                                           new SqlParameter("@DescriptionLength",OnlineShopConfiguration.ProductDescriptionLength),
                                           new SqlParameter("@ProductsPerPage",OnlineShopConfiguration.ProductsOnPage),
                                           new SqlParameter("@PageNumber",pageNumber)
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
