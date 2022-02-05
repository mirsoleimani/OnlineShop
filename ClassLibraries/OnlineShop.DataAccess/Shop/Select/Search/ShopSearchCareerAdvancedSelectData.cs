using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Shop.Select.Search
{
    public class ShopSearchCareerAdvancedSelectData:DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
        public ShopSearchCareerAdvancedSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopSearchCareerAdvanced_Select.ToString();

        }
        public DataTable Search(int pageNumber, out int howManyPages)
        {
            DataSet ds;

            ShopSearchCareerAdvancedSelectDataParameters selectDataParameters =
                new ShopSearchCareerAdvancedSelectDataParameters(pageNumber,EndUser);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, CommandType.StoredProcedure, selectDataParameters.Parameters);
            int howManyShops = Int32.Parse(selectDataParameters.Parameters[0].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyShops / (double)OnlineShopConfiguration.ShopsOnPage);
            return ds.Tables[0];
        }
    }

    class ShopSearchCareerAdvancedSelectDataParameters
    {
                        private SqlParameter[] _parameters;
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }

        public ShopSearchCareerAdvancedSelectDataParameters(int PageNumber,Common.EndUser.EndUser endUser)
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


            SqlParameter[] parameters ={
                                          outParam,
                                          new SqlParameter("@DescriptionLength",OnlineShopConfiguration.ShopDescriptionLength),
                                          new SqlParameter("@ShopsPerPage",OnlineShopConfiguration.ShopsOnPage),
                                          new SqlParameter("@PageNumber",pageNumber), 
                                          new SqlParameter("@CategoryID",EndUser.ShopData.CategoryID),
                                          new SqlParameter("@Deputation",EndUser.CareerInfoData.Deputation),
                                          new SqlParameter("@ActivityType",EndUser.CareerInfoData.ActivityType),
                                          new SqlParameter("@ActivityField",EndUser.CareerInfoData.ActivityField),
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
