using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Delete
{
    public class ShopByIDDeleteData:DataAccessBase
    {
                private Common.Shop.Shop _shop;

        private ShopByIDDeleteDataParameters _deleteDaraParameters;

        public ShopByIDDeleteData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopByID_Delete.ToString();
        }
        public void Del()
        {
            _deleteDaraParameters = new  ShopByIDDeleteDataParameters(Shop);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            dbHelper.Parameters = _deleteDaraParameters.Parameters;
            dbHelper.Run();
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }

    class ShopByIDDeleteDataParameters
    {
                private Common.Shop.Shop _shop;


        private SqlParameter[] _parameters;

        public ShopByIDDeleteDataParameters(Common.Shop.Shop shop)
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
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
