using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUserContactInfoByEndUserIDSelectData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        private EndUserContactInfoByEndUserIDSelectDataParameters _selectDataParameters;

        public EndUserContactInfoByEndUserIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUserContactInfoByEndUserID_select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUserContactInfoByEndUserIDSelectDataParameters(EndUser);
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
    class EndUserContactInfoByEndUserIDSelectDataParameters
    {
        private Common.EndUser.EndUser _endUser;
        private SqlParameter[] _parameters;

        public EndUserContactInfoByEndUserIDSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",EndUser.ContactInfodata.EndUserID),
                                         


                                         
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
