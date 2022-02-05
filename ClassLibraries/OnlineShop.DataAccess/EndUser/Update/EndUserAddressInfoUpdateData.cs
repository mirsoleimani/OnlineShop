using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.EndUser.Update
{
    public class EndUserAddressInfoUpdateData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;

        private EndUserAddressInfoUpdateDataParameters _updateDataParameters;

        public EndUserAddressInfoUpdateData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_EndUserAddressInfo_Update.ToString();

        }

        public void Update()
        {
            _updateDataParameters =
                new EndUserAddressInfoUpdateDataParameters(EndUser);
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
    class EndUserAddressInfoUpdateDataParameters
    {
        private Common.EndUser.EndUser _endUser;

        private SqlParameter[] _parameters;

        public EndUserAddressInfoUpdateDataParameters(Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@AddressInformationID",EndUser.AddressInfoData.AddressInformationID),
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
