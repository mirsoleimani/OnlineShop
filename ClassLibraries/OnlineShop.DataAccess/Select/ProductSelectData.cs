using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.DataAccess.Select
{
    public class ProductSelectData:DataAccessBase
    {
        public ProductSelectData()
        {
            StoredProcedureName = StoredProcedure.Name.Products_Select.ToString();
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
