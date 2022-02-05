using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Insert
{
    public class EndUserCareerInfoInsertData:DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        private EndUserCareerInfoInsertDataParameters _insertDaraParameters;

        public EndUserCareerInfoInsertData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserCareerInfo_Insert.ToString();
        }
        public void Add()
        {
            _insertDaraParameters = new EndUserCareerInfoInsertDataParameters(EndUser);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            object ID = dbHelper.RunScalar(base.ConnectionString, _insertDaraParameters.Parameters);
            EndUser.AddressInfoData.AddressInformationID = int.Parse(ID.ToString());
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }

    class EndUserCareerInfoInsertDataParameters
    {
                private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserCareerInfoInsertDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",EndUser.CareerInfoData.EndUserID),
                                          new SqlParameter("@Company",EndUser.CareerInfoData.Company),
                                          new SqlParameter("@Career",EndUser.CareerInfoData.Career),
                                          new SqlParameter("@Position",EndUser.CareerInfoData.Position),
                                          new SqlParameter("@CareerGroup",EndUser.CareerInfoData.CareerGroup),                                         
                                          new SqlParameter("@ActivityType",EndUser.CareerInfoData.ActivityType),
                                          new SqlParameter("@ActivityField",EndUser.CareerInfoData.ActivityField),
                                          new SqlParameter("@LicenseHolder",EndUser.CareerInfoData.LicenseHolder),
                                          new SqlParameter("@Licensor",EndUser.CareerInfoData.Licensor),                                         
                                          new SqlParameter("@Deputation",EndUser.CareerInfoData.Deputation)

                                          
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
