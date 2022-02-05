using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUserCareerInfoByEndUserIDSelectData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        private EndUserCareerInfoByEndUserIDSelectDataParameters _selectDataParameters;

        public EndUserCareerInfoByEndUserIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUserCareerInfoByEndUserID_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUserCareerInfoByEndUserIDSelectDataParameters(EndUser);
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

    class EndUserCareerInfoByEndUserIDSelectDataParameters
    {
        private Common.EndUser.EndUser _endUser;
        private SqlParameter[] _parameters;

        public EndUserCareerInfoByEndUserIDSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",EndUser.CareerInfoData.EndUserID)
                                         
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
