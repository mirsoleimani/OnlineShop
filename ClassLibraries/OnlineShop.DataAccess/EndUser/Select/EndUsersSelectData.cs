using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUsersSelectData:DataAccessBase
    {
        public EndUsersSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUsers_Select.ToString();
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
