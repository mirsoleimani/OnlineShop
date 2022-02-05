using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Category.Select
{
    public class CategoryByIDSelectData:DataAccessBase
    {
        private Common.Category _category;
        
        private CategoryByIDSelectDataParameters _selectDataParameters;

        public CategoryByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_CategoryByID_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;
            _selectDataParameters = new CategoryByIDSelectDataParameters(Category);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);

            ds=dbhelper.Run(base.ConnectionString,_selectDataParameters.Parameters);
            return ds;
            
        }
        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

    }

    class CategoryByIDSelectDataParameters
    {
        private Common.Category _category;
        private SqlParameter[] _parameters;

        public CategoryByIDSelectDataParameters(Common.Category category)
        {

            Category = category;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@CategoryID",Category.CategoryID)
                                         
                                      };
            Parameters = parameters;
        }

        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
