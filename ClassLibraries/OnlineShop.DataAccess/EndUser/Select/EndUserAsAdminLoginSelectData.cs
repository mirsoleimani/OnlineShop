using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUserAsAdminLoginSelectData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        private EndUserAsAdminLoginSelectDataParameters _selectDataParameters;

        public EndUserAsAdminLoginSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUserAsAdminLogin_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUserAsAdminLoginSelectDataParameters(EndUser);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);

            ds = dbhelper.Run(base.ConnectionString, _selectDataParameters.Parameters);
            return ds;

        }

        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }

    class EndUserAsAdminLoginSelectDataParameters
    {
        private Common.EndUser.EndUser _endUser;
        private SqlParameter[] _parameters;

        public EndUserAsAdminLoginSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@UserName",EndUser.UserName)                                         
                                         
                                      };
            Parameters = parameters;
        }

        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
