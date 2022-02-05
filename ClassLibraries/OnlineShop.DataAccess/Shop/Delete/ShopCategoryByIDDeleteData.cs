using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Delete
{
    public class ShopCategoryByIDDeleteData : DataAccessBase
    {
        private Common.Shop.ShopCategory _shopCategory;

        private ShopCategoryByIDDeleteDataParameters _deleteDaraParameters;

        public ShopCategoryByIDDeleteData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopCategory_Delete.ToString();
        }
        public void Del()
        {
            _deleteDaraParameters = new ShopCategoryByIDDeleteDataParameters(ShopCategory);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            dbHelper.Parameters = _deleteDaraParameters.Parameters;
            dbHelper.Run();
        }
        public Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }
    }
    class ShopCategoryByIDDeleteDataParameters
    {
        private Common.Shop.ShopCategory _shopCtegory;


        private SqlParameter[] _parameters;

        public ShopCategoryByIDDeleteDataParameters(Common.Shop.ShopCategory shopCategory)
        {
            ShopCategory = shopCategory;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@ShopCategoryID",ShopCategory.ShopCategryID)
                                          
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
