using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OnlineShop.DataAccess
{
    public class DataAccessBase
    {
        private string _StoredProcedureName;

      
        public DataAccessBase()
        {
        }
        public string StoredProcedureName
        {
            get { return _StoredProcedureName; }
            set { _StoredProcedureName = value; }
        }
        protected string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SQLCONN"].ToString();
            }
        }

    }
}
