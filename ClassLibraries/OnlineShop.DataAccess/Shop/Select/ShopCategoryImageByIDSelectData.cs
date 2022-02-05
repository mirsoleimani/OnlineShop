using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Shop;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopCategoryImageByIDSelectData : DataAccessBase
    {
        private ShopCategory _shopCategory;

        public ShopCategoryImageByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopCategoryImage_Select.ToString();
        }
        public object Get()
        {
            object imageData;
            ShopCategoryImageByIDSelectDataParameters shopCategoryImageParameters
             = new ShopCategoryImageByIDSelectDataParameters(ShopCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            imageData = dbHelper.RunScalar(base.ConnectionString, shopCategoryImageParameters.Parameters);
            return imageData;

        }
        public OnlineShop.Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }

    }
    class ShopCategoryImageByIDSelectDataParameters
    {
        private ShopCategory _shopCategory;
        private SqlParameter[] _Parameters;

        public ShopCategoryImageByIDSelectDataParameters(ShopCategory shopCategory)
        {
            ShopCategory = shopCategory;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@ImageID", ShopCategory.ImageID)
                                        };
            Parameters = parameters;
        }


        public OnlineShop.Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }
        public SqlParameter[] Parameters
        {
            get { return _Parameters; }
            set { _Parameters = value; }
        }
    }
}
