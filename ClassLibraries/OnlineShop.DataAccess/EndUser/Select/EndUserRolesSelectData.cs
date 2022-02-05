using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUserRolesSelectData:DataAccessBase
    {
       
       
        public EndUserRolesSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserRoles_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;

            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(ConnectionString);
            return ds;
        }

      
    }
}
