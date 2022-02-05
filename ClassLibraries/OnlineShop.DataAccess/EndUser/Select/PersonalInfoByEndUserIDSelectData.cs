using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnlineShop.Common.EndUser;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Select
{
   public class PersonalInfoByEndUserIDSelectData:DataAccessBase
    {
        private Common.EndUser.PersonalInformation _personalInfo;
        private PersonalInfoByEndUserIDSelectDataParameters _selectDataParameters;
        public PersonalInfoByEndUserIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUserPersonalInfoByEndUserID_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new PersonalInfoByEndUserIDSelectDataParameters(PersonalInfo);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);

            ds = dbhelper.Run(base.ConnectionString, _selectDataParameters.Parameters);
            return ds;

        }

        public Common.EndUser.PersonalInformation PersonalInfo
        {
            get { return _personalInfo; }
            set { _personalInfo = value; }
        }
    }

    class PersonalInfoByEndUserIDSelectDataParameters
    {
                private PersonalInformation _personalInfo;
	
        private SqlParameter[] _parameters;

        public PersonalInfoByEndUserIDSelectDataParameters(PersonalInformation personalInfo)
        {

            PersonalInfo = personalInfo;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",PersonalInfo.EndUserID)
                                         
                                      };
            Parameters = parameters;
        }

        public Common.EndUser.PersonalInformation PersonalInfo
	{
		get { return _personalInfo; }
		set { _personalInfo = value; }
	}
        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
