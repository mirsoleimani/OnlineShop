using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Update
{
    public class ShopUpdateData:DataAccessBase
    {
        private Common.Shop.Shop _shop;
        private ShopUpdateDataParameters _updateDataParameters;

        public ShopUpdateData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_Shop_Update.ToString();
        }

        public void Update()
        {
            _updateDataParameters =
               new ShopUpdateDataParameters(Shop);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);
            dbhelper.Parameters = _updateDataParameters.Parameters;
            dbhelper.Run();
        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
    }

    class ShopUpdateDataParameters
    {
                private Common.Shop.Shop _shop;
	
        private SqlParameter[] _parameters;

        public ShopUpdateDataParameters(Common.Shop.Shop shop)
        {
            Shop = shop;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ShopID",Shop.ShopID),
                                           new SqlParameter("@ImageID",Shop.ImageData.ImageID),
                                           new SqlParameter("@Name",Shop.Name),
                                           new SqlParameter("@Description",Shop.Description),
                                           new SqlParameter("@Image",Shop.ImageData.ImageData),
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
