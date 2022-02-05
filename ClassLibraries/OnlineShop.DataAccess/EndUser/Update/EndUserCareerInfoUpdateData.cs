using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Update
{
    public class EndUserCareerInfoUpdateData:DataAccessBase
    {
                private Common.EndUser.EndUser _endUser;

        private EndUserCareerInfoUpdateDataParameters _updateDataParameters;

        public EndUserCareerInfoUpdateData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserCareerInfo_Update.ToString();

        }

        public void Update()
        {
            _updateDataParameters =
                new  EndUserCareerInfoUpdateDataParameters(EndUser);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);
            dbhelper.Parameters = _updateDataParameters.Parameters;
            dbhelper.Run();
        }

        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }

    class EndUserCareerInfoUpdateDataParameters
    {
         private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserCareerInfoUpdateDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@CareerInformationID",EndUser.CareerInfoData.CareerInformationID),
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
