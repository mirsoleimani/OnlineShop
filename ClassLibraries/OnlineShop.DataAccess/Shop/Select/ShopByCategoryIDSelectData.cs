using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Shop;
using System.Data.SqlClient;
using System.Data;


namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopByCategoryIDSelectData:DataAccessBase
    {
        private Common.Shop.Shop _shop;
       
        public ShopByCategoryIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopByCategoryID_Select.ToString();

        }
        public DataSet Get()
        {
            DataSet ds;

            ShopByCategoryIDSelectDataParameters selectDataParameters =
                new ShopByCategoryIDSelectDataParameters(Shop);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, selectDataParameters.Parameters);

            return ds;
        }
        public OnlineShop.Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }
    class ShopByCategoryIDSelectDataParameters
    {
        private Common.Shop.Shop _shop;       
        private SqlParameter[] _parameters;
        
        public ShopByCategoryIDSelectDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;
            Build();
        }
        
        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@CategoryID",Shop.CategoryID),
                                           new SqlParameter("@ShopDescriptionLength",OnlineShopConfiguration.ShopDescriptionLength)
                                       };
            Parameters = parameters;
        }
        public OnlineShop.Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
        public System.Data.SqlClient.SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
