using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select.Search
{
    public class EndUserSearchByRegistrarNameSelectData:DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        private EndUserSearchByRegistrarNameSelectDataParameters _selectDataParameters;

        public EndUserSearchByRegistrarNameSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUserByRegistrarName_select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUserSearchByRegistrarNameSelectDataParameters(EndUser);
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

    class EndUserSearchByRegistrarNameSelectDataParameters
    {
                private Common.EndUser.EndUser _endUser;


        private SqlParameter[] _parameters;

        public EndUserSearchByRegistrarNameSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@LastName",EndUser.PersonalInfoData.LastName),
                                          new SqlParameter("@FirstName",EndUser.PersonalInfoData.FirstName),                                        
                                          new SqlParameter("@UserName",EndUser.UserName),
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
