using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using OnlineShop;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopByIDSelectData:DataAccessBase
    {
        private Common.Shop.Shop _shop;
       
        public ShopByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopByID_Select.ToString();

        }
        public DataSet Get()
        {
            DataSet ds;

            ShopByIDSelectDataParameters selectDataParameters =
                new ShopByIDSelectDataParameters(Shop);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, selectDataParameters.Parameters);

            return ds;
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }

    class ShopByIDSelectDataParameters
    {
                private Common.Shop.Shop _shop;       
        private SqlParameter[] _parameters;
        
        public ShopByIDSelectDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;
            Build();
        }
        
        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ShopID",Shop.ShopID)
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
