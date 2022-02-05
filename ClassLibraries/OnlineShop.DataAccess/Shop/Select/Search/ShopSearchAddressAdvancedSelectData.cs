using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Shop.Select.Search
{
    public class ShopSearchAddressAdvancedSelectData:DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
        public ShopSearchAddressAdvancedSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopSearchAddressAdvanced_Select.ToString();

        }
        public DataTable Search(int pageNumber, out int howManyPages)
        {
            DataSet ds;

            ShopSearchAddressAdvancedSelectDataParameters selectDataParameters =
                new ShopSearchAddressAdvancedSelectDataParameters(pageNumber,EndUser);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, CommandType.StoredProcedure, selectDataParameters.Parameters);
            int howManyShops = Int32.Parse(selectDataParameters.Parameters[0].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyShops / (double)OnlineShopConfiguration.ShopsOnPage);
            return ds.Tables[0];
        }
    }

    class ShopSearchAddressAdvancedSelectDataParameters
    {

        private SqlParameter[] _parameters;
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }

        public ShopSearchAddressAdvancedSelectDataParameters(int PageNumber,Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build(PageNumber);
        }

        private void Build( int pageNumber)
        {
            SqlParameter outParam = new SqlParameter();
            outParam.ParameterName = "@HowManyResults";
            outParam.DbType = DbType.Int32;
            outParam.Direction = ParameterDirection.Output;

            if (EndUser.AddressInfoData.Address1 == "")
                EndUser.AddressInfoData.Address1 = string.Empty;
            if (EndUser.AddressInfoData.Address2 == "")
            {
                EndUser.AddressInfoData.Address2 = string.Empty;
            }
            if (EndUser.AddressInfoData.PostalCode=="")
            {
                EndUser.AddressInfoData.PostalCode = string.Empty;
            }
            if (EndUser.ShopData.Name == "")
            {
                EndUser.ShopData.Name = string.Empty;
            }


            SqlParameter[] parameters ={
                                          outParam,
                                          new SqlParameter("@DescriptionLength",OnlineShopConfiguration.ShopDescriptionLength),
                                          new SqlParameter("@ShopsPerPage",OnlineShopConfiguration.ShopsOnPage),
                                          new SqlParameter("@PageNumber",pageNumber), 
                                          new SqlParameter("@CategoryID",EndUser.ShopData.CategoryID),
                                          new SqlParameter("@StateProvinceID",EndUser.AddressInfoData.StateProvinceID),
                                          new SqlParameter("@City",EndUser.AddressInfoData.City),
                                          new SqlParameter("@Address1",EndUser.AddressInfoData.Address1),
                                          new SqlParameter("@Address2",EndUser.AddressInfoData.Address2),
                                          new SqlParameter("@PostalCode",EndUser.AddressInfoData.PostalCode),
                                          new SqlParameter("@Name",EndUser.ShopData.Name)

                                       };

            Parameters = parameters;
        }

        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
