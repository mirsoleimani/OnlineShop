using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUserSelectData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        private EndUsersSelectDataParameters _selectDataParameters;

        public EndUserSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUser_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUsersSelectDataParameters(EndUser);
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

    class EndUsersSelectDataParameters
    {
        private Common.EndUser.EndUser _endUser;


        private SqlParameter[] _parameters;

        public EndUsersSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@LastName",EndUser.PersonalInfoData.LastName),
                                          new SqlParameter("@FirstName",EndUser.PersonalInfoData.FirstName),                                        
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
