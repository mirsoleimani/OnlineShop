using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopsByEndUserIDSelectData:DataAccessBase
    {
                private Common.Shop.Shop _shop;

                public ShopsByEndUserIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopsByEndUserID_Select.ToString();

        }
        public DataSet Get()
        {
            DataSet ds;

            ShopsByEndUserIDSelectDataParameters selectDataParameters =
                new ShopsByEndUserIDSelectDataParameters(Shop);
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

    class ShopsByEndUserIDSelectDataParameters
    {
                private Common.Shop.Shop _shop;       
        private SqlParameter[] _parameters;

        public ShopsByEndUserIDSelectDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;
            Build();
        }
        
        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@EndUserID",Shop.EndUserID)
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
