using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Insert
{
    public class EndUserInsertData : DataAccessBase
    {
         private Common.EndUser.EndUser _endUser;
	
        private EndUserInsertDataParameters _insertDaraParameters;

        public EndUserInsertData()
       {
           base.StoredProcedureName = StoredProcedure.Name.sp_EndUser_Insert.ToString();
       }
        public void Add()
        {
            _insertDaraParameters = new EndUserInsertDataParameters(EndUser);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);            
            object endUserID = dbHelper.RunScalar(base.ConnectionString, _insertDaraParameters.Parameters);
            EndUser.EndUserID = new Guid(endUserID.ToString());
        }
       public Common.EndUser.EndUser EndUser
	{
		get { return _endUser; }
		set { _endUser = value; }
	}
    }

    class EndUserInsertDataParameters
    {
        private Common.EndUser.EndUser _endUser;
      
        private SqlParameter[] _parameters;

        public EndUserInsertDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserRoleID",EndUser.EndUserRoleData.EndUserRoleID),
                                          new SqlParameter("@UserName",EndUser.UserName),
                                          new SqlParameter("@PasswordHash",EndUser.PasswordHash),
                                          new SqlParameter("@PasswordSalt",EndUser.PasswordSalt),
                                          new SqlParameter("@CreatedOn",EndUser.CreatedOn),
                                          new SqlParameter("@Deleted",EndUser.Deleted)
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
