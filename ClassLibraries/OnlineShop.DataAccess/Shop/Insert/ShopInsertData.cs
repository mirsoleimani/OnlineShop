using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Insert
{
    public class ShopInsertData : DataAccessBase
    {
        private Common.Shop.Shop _shop;

        private ShopInsertDataParameters _insertDaraParameters;

        public ShopInsertData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_Shop_Insert.ToString();
        }
        public void Add()
        {
            _insertDaraParameters = new ShopInsertDataParameters(Shop);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            //dbHelper.Parameters = _insertDaraParameters.Parameters;
            object shopID = dbHelper.RunScalar(this.ConnectionString, _insertDaraParameters.Parameters);
            Shop.ShopID = int.Parse(shopID.ToString());
            //dbHelper.Run();
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }

    class ShopInsertDataParameters
    {
        private Common.Shop.Shop _shop;


        private SqlParameter[] _parameters;

        public ShopInsertDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",Shop.EndUserID),  
                                          new SqlParameter("@Image",Shop.ImageData.ImageData),
                                          new SqlParameter("@Name",Shop.Name),
                                          new SqlParameter("@Description",Shop.Description),
                                          new SqlParameter("@CreatedOn",Shop.CreatedOn),                                         
                                          new SqlParameter("@Rating",Shop.Rating),
                                           new SqlParameter("@Code",Shop.Code),
                                          new SqlParameter("@Deleted",Shop.Deleted)
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
