using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Update
{
    public class EndUserPersonalInfoUpdateData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;

        private EndUserPersonalInfoUpdateDataParameters _updateDataParameters;

        public EndUserPersonalInfoUpdateData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserPersonalInfo_Update.ToString();

        }

        public void Update()
        {
            _updateDataParameters =
                new EndUserPersonalInfoUpdateDataParameters(EndUser);
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

    class EndUserPersonalInfoUpdateDataParameters
    {
        private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserPersonalInfoUpdateDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@PersonalInformationID",EndUser.PersonalInfoData.PersonalInformationID),
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
