using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Insert
{
    public class ShopCategoryInsertData : DataAccessBase
    {
        private Common.Shop.ShopCategory _shopCategory;

        private ShopCategoryInsertDataParameters _insertDaraParameters;

        public ShopCategoryInsertData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopCategory_Insert.ToString();
        }
        public void Add()
        {
            _insertDaraParameters = new ShopCategoryInsertDataParameters(ShopCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            dbHelper.Parameters = _insertDaraParameters.Parameters;
            dbHelper.Run();
        }
        public Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }

    }

    class ShopCategoryInsertDataParameters
    {
        private Common.Shop.ShopCategory _shopCtegory;


        private SqlParameter[] _parameters;

        public ShopCategoryInsertDataParameters(Common.Shop.ShopCategory shopCategory)
        {
            ShopCategory = shopCategory;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@ShopID",ShopCategory.ShopID),  
                                          new SqlParameter("@CategoryID",ShopCategory.CategoryID),
                                          
                                      };
            Parameters = parameters;
        }
        public Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCtegory; }
            set { _shopCtegory = value; }
        }
        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
