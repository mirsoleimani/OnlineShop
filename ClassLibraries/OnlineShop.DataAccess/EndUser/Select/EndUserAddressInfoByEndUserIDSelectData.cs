using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.EndUser.Select
{
    public class EndUserAddressInfoByEndUserIDSelectData : DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;

        private EndUserAddressInfoByEndUserIDSelectDataParameters _selectDataParameters;
        public EndUserAddressInfoByEndUserIDSelectData()
        {
            //base.StoredProcedureName = StoredProcedure.Name
            //    .sp_EndUserAddressInfoByEndUserID_Select.ToString();
            base.StoredProcedureName = StoredProcedure.Name
                .sp_EndUserAddressInfoByEndUserID_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new EndUserAddressInfoByEndUserIDSelectDataParameters(EndUser);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);

            ds = dbhelper.Run(base.ConnectionString, _selectDataParameters.Parameters);
            return ds;

        }

        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }

    class EndUserAddressInfoByEndUserIDSelectDataParameters
    {
        private Common.EndUser.EndUser _endUser;
        private SqlParameter[] _parameters;

        public EndUserAddressInfoByEndUserIDSelectDataParameters(Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@EndUserID",EndUser.AddressInfoData.EndUserID),
                                          new SqlParameter("@IsCareerAddress",EndUser.AddressInfoData.IsCareerAddress)


                                         
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
