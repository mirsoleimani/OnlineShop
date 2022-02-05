using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnlineShop.Common.Shop;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopCategoriesSelectData:DataAccessBase
    {
        public ShopCategoriesSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopCategories_select.ToString();
        }
        public DataSet Get()
        {
            DataSet ds;

            DataBaseHelper dbhelper = new DataBaseHelper(StoredProcedureName);
            ds = dbhelper.Run(ConnectionString);
            return ds;

        }
    }


}
