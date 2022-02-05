using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Product.Select.Search
{
    public class ProductSearchSelectData : DataAccessBase
    {

        public ProductSearchSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ProductSearch_Select.ToString();

        }
        public DataTable Search(string searchCriteria, bool allWords,
            int pageNumber, out int howManyPages)
        {
            DataSet ds;

            ProductSearchSelectDataParameters selectDataParameters =
                new ProductSearchSelectDataParameters(searchCriteria, allWords, pageNumber);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, CommandType.StoredProcedure, selectDataParameters.Parameters);
            int howManyShops = Int32.Parse(selectDataParameters.Parameters[0].Value.ToString());

            howManyPages = (int)Math.Ceiling((double)howManyShops / (double)OnlineShopConfiguration.ShopsOnPage);
            return ds.Tables[0];
        }
    }

    class ProductSearchSelectDataParameters
    {
        private SqlParameter[] _parameters;

        public ProductSearchSelectDataParameters(string searchCriteria, bool allWords, int PageNumber)
        {

            Build(searchCriteria, allWords, PageNumber);
        }

        private void Build(string searchCriteria, bool allWords, int pageNumber)
        {
            int maxSearchWords = 5;
            //string[] Words = Regex.Split(searchCriteria, "[^a-zA-Z0-9]+");
            searchCriteria = searchCriteria.Replace(",", " ");
            searchCriteria = searchCriteria.Replace(";", " ");
            searchCriteria = searchCriteria.Replace(".", " ");
            searchCriteria = searchCriteria.Replace("!", " ");
            searchCriteria = searchCriteria.Replace("?", " ");
            searchCriteria = searchCriteria.Replace("-", " ");
            string[] delim = new string[] { " " };

            string[] words = searchCriteria.Split(delim, StringSplitOptions.None);

            SqlParameter[] searchWordsParameters = new SqlParameter[maxSearchWords];

            int index = 1;
            for (int i = 0; i <= words.GetUpperBound(0) && index <= maxSearchWords; i++)
            {
                if (words[i].Length >= 2)
                {
                    searchWordsParameters[i] = new SqlParameter("@Word" + index.ToString(), words[i]);
                    index++;
                }
            }
            SqlParameter outParam = new SqlParameter();
            outParam.ParameterName = "@HowManyResults";
            outParam.DbType = DbType.Int32;
            outParam.Direction = ParameterDirection.Output;


            SqlParameter[] parameters ={
                                          outParam,
                                          new SqlParameter("@DescriptionLength",OnlineShopConfiguration.ProductDescriptionLength),
                                          new SqlParameter("@ShopsPerPage",OnlineShopConfiguration.ProductsOnPage),
                                          new SqlParameter("@AllWords",allWords),
                                          new SqlParameter("@PageNumber",pageNumber), 
                                          searchWordsParameters[0],
                                          searchWordsParameters[1],
                                          searchWordsParameters[2],
                                          searchWordsParameters[3],
                                          searchWordsParameters[4]

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
