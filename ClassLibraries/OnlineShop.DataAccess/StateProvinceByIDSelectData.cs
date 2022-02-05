using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess
{
    public class StateProvincesSelectData : DataAccessBase
    {


        public StateProvincesSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_StateProvinces_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);

            ds = dbhelper.Run(base.ConnectionString);
            return ds;

        }

    }


}
