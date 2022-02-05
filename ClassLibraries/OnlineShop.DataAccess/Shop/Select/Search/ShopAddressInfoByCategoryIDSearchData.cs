using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Select.Search
{
    public class ShopAddressInfoByCategoryIDSearchData : DataAccessBase
    {
        private OnlineShop.Common.EndUser.EndUser _endUser;
        private ShopAddressInfoByCategoryIDSearchDataParameters _searchDataParameters;

        public ShopAddressInfoByCategoryIDSearchData()
        {
            base.StoredProcedureName = StoredProcedure.Name
                .sp_ShopAddressInfoByCategoryID_Search.ToString();
        }

        public DataSet Search()
        {
            DataSet ds;
            _searchDataParameters = new ShopAddressInfoByCategoryIDSearchDataParameters(EndUser);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);

            ds = dbhelper.Run(base.ConnectionString, _searchDataParameters.Parameters);
            return ds;

        }

        public OnlineShop.Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }

    class ShopAddressInfoByCategoryIDSearchDataParameters
    {
        private OnlineShop.Common.EndUser.EndUser _endUser;


        private SqlParameter[] _parameters;

        public ShopAddressInfoByCategoryIDSearchDataParameters(OnlineShop.Common.EndUser.EndUser endUser)
        {

            EndUser = endUser;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@CategoryID",EndUser.ShopData.CategoryID)
                                          
                                         
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
