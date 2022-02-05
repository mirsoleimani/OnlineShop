using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Insert
{
    public class EndUserAddressInfoInsertData:DataAccessBase
    {
                private Common.EndUser.EndUser _endUser;

        private EndUserAddressInfoInsertDataParameters _insertDaraParameters;

        public EndUserAddressInfoInsertData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserAddressInfo_Insert.ToString();
        }
        public void Add()
        {
            _insertDaraParameters = new EndUserAddressInfoInsertDataParameters(EndUser);
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

    class EndUserAddressInfoInsertDataParameters
    {
                private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserAddressInfoInsertDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",EndUser.AddressInfoData.EndUserID),
                                          new SqlParameter("@IsCareerAddress",EndUser.AddressInfoData.IsCareerAddress),
                                          new SqlParameter("@Address1",EndUser.AddressInfoData.Address1),
                                          new SqlParameter("@Address2",EndUser.AddressInfoData.Address2),
                                          new SqlParameter("@City",EndUser.AddressInfoData.City),                                         
                                          new SqlParameter("@StateProvinceID",EndUser.AddressInfoData.StateProvinceID),
                                          new SqlParameter("@PostalCode",EndUser.AddressInfoData.PostalCode)

                                          
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
