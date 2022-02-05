using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUsersByregistrarNameSelectData:DataAccessBase
    {
                private Common.EndUser.EndUser _endUser;
        private EndUsersByregistrarNameSelectDataParameters _selectDataParameters;

        public EndUsersByregistrarNameSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUsersByRegistrarName_select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUsersByregistrarNameSelectDataParameters(EndUser);
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

    class EndUsersByregistrarNameSelectDataParameters
    {
                private Common.EndUser.EndUser _endUser;


        private SqlParameter[] _parameters;

        public EndUsersByregistrarNameSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@RegisteredBy",EndUser.PersonalInfoData.RegisteredBy)
                                          
                                         
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
