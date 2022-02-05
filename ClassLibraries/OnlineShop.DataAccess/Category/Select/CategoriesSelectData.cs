using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.DataAccess.Category.Select
{
    public class CategoriesSelectData:DataAccessBase
    {
        public CategoriesSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_Categories_Select.ToString();
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
