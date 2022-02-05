using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.DataAccess.Shop.Select
{
    public class ShopsSelectData:DataAccessBase
    {
        public ShopsSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_Shops_Select.ToString();
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
