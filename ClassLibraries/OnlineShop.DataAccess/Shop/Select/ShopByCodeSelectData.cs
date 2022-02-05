using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopByCodeSelectData : DataAccessBase
    {
        private Common.Shop.Shop _shop;

        public ShopByCodeSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopByCode_Select.ToString();

        }
        public DataSet Get()
        {
            DataSet ds;

            ShopByCodeSelectDataParameters selectDataParameters =
                new ShopByCodeSelectDataParameters(Shop);
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

    class ShopByCodeSelectDataParameters
    {
        private Common.Shop.Shop _shop;
        private SqlParameter[] _parameters;

        public ShopByCodeSelectDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@Code",Shop.Code)
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
