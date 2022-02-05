using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Shop.Select.Search
{
    public class ShopSearchContactAdvancedSelectData:DataAccessBase
    {
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
        public ShopSearchContactAdvancedSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ShopSearchContactAdvanced_Select.ToString();

        }
        public DataTable Search(int pageNumber, out int howManyPages)
        {
            DataSet ds;

            ShopSearchContactAdvancedSelectDataParameters selectDataParameters =
                new ShopSearchContactAdvancedSelectDataParameters(pageNumber,EndUser);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, CommandType.StoredProcedure, selectDataParameters.Parameters);
            int howManyShops = Int32.Parse(selectDataParameters.Parameters[0].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyShops / (double)OnlineShopConfiguration.ShopsOnPage);
            return ds.Tables[0];
        }
    }

    class ShopSearchContactAdvancedSelectDataParameters
    {
                private SqlParameter[] _parameters;
        private Common.EndUser.EndUser _endUser;
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }

        public ShopSearchContactAdvancedSelectDataParameters(int PageNumber,Common.EndUser.EndUser endUser)
        {
            EndUser = endUser;
            Build(PageNumber);
        }

        private void Build( int pageNumber)
        {
            string phone = EndUser.ContactInfodata.Phone;
            phone = phone.Trim();
            if (phone != "")
            {
                phone = phone.Substring(0, 3);
            }
            else
                phone = null;

            EndUser.ContactInfodata.Phone = phone;

            if (EndUser.ShopData.Name == "")
                EndUser.ShopData.Name = null;

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
                                          new SqlParameter("@AreaCode",EndUser.ContactInfodata.AreaCode),
                                          new SqlParameter("@Phone",EndUser.ContactInfodata.Phone),
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
