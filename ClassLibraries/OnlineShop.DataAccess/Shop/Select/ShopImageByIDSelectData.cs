using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopImageByIDSelectData:DataAccessBase
    {
        private Common.Shop.Shop _shop;
        
        public ShopImageByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopImage_Select.ToString();

        }
        public object Get()
        {
            object imageData;
            ShopImageByIDSelectDataParameters selectDataParameters
             = new ShopImageByIDSelectDataParameters(Shop);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            imageData = dbHelper.RunScalar(base.ConnectionString, selectDataParameters.Parameters);
            return imageData;

        }

        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }

    class ShopImageByIDSelectDataParameters 
    {
        private Common.Shop.Shop _shop;
        
        private SqlParameter[] _parameters;
       
        public ShopImageByIDSelectDataParameters(Common.Shop.Shop shop)
        {
            Shop=shop;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ImageID",Shop.ImageData.ImageID)
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
