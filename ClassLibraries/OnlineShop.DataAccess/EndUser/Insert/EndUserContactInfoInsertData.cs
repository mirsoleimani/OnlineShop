using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Insert
{
    public class EndUserContactInfoInsertData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;

        private EndUserContactInfoInsertDataParameters _insertDaraParameters;

        public EndUserContactInfoInsertData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserContactInfo_Insert.ToString();
        }
        public void Add()
        {
            _insertDaraParameters = new EndUserContactInfoInsertDataParameters(EndUser);
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

    class EndUserContactInfoInsertDataParameters
    {
        private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserContactInfoInsertDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
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


