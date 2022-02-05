using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Update
{
    public class EndUserContactInfoUpdateData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;

        private EndUserContactInfoUpdateDataParameters _updateDataParameters;

        public EndUserContactInfoUpdateData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserContactInfo_Update.ToString();

        }

        public void Update()
        {
            _updateDataParameters =
                new EndUserContactInfoUpdateDataParameters(EndUser);
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

    class EndUserContactInfoUpdateDataParameters
    {
        private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserContactInfoUpdateDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@ContactInformationID",EndUser.ContactInfodata.ContactInformationID),
                                          new SqlParameter("@EndUserID",EndUser.ContactInfodata.EndUserID),
                                          new SqlParameter("@Phone",EndUser.ContactInfodata.Phone),
                                          new SqlParameter("@CellPhone",EndUser.ContactInfodata.CellPhone),
                                          new SqlParameter("@Fax",EndUser.ContactInfodata.Fax),
                                          new SqlParameter("@Email",EndUser.ContactInfodata.Email),                                         
                                          new SqlParameter("@AreaCode",EndUser.ContactInfodata.AreaCode)
                                          
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
