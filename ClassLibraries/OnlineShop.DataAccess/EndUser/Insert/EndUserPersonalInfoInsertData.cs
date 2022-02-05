using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Insert
{
    public class EndUserPersonalInfoInsertData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;

        private EndUserPersonalInfoInsertDataParameters _insertDaraParameters;

        public EndUserPersonalInfoInsertData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserPersonalInfo_Insert.ToString();
        }
        public void Add()
        {
            _insertDaraParameters = new EndUserPersonalInfoInsertDataParameters(EndUser);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            object personalInfoID = dbHelper.RunScalar(base.ConnectionString, _insertDaraParameters.Parameters);
            EndUser.PersonalInfoData.PersonalInformationID = int.Parse(personalInfoID.ToString());
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }

    class EndUserPersonalInfoInsertDataParameters
    {
        private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserPersonalInfoInsertDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",EndUser.PersonalInfoData.EndUserID),
                                          new SqlParameter("@FirstName",EndUser.PersonalInfoData.FirstName),
                                          new SqlParameter("@LastName",EndUser.PersonalInfoData.LastName),
                                          new SqlParameter("@FatherName",EndUser.PersonalInfoData.FatherName),
                                          new SqlParameter("@Gender",EndUser.PersonalInfoData.Gender),                                         
                                          new SqlParameter("@MaritalStatus",EndUser.PersonalInfoData.MaritalStatus),
                                          new SqlParameter("@EducationDegree",EndUser.PersonalInfoData.EducationDegree),
                                          new SqlParameter("@Income",EndUser.PersonalInfoData.Income),
                                          new SqlParameter("@BirthDate",EndUser.PersonalInfoData.BirthDate),
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
