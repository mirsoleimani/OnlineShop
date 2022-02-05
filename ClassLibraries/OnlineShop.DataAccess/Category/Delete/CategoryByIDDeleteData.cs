using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//write by elahe
namespace OnlineShop.DataAccess.Category.Delete
{
    public class CategoryByIDDeleteData : DataAccessBase
    {
        
         private Common.Category _category;

        private CategoryByIDDeleteDataParameters _deleteDataParameters;

        public CategoryByIDDeleteData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_CategoryByID_Delete.ToString();
          
        }
        public void Del()
        {
            _deleteDataParameters = new CategoryByIDDeleteDataParameters(Category);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            dbHelper.Parameters = _deleteDataParameters.Parameters;
            dbHelper.Run();
        }
        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
    class CategoryByIDDeleteDataParameters
    {
         private Common.Category _category;


        private SqlParameter[] _parameters;

        public CategoryByIDDeleteDataParameters(Common.Category category)
        {
            Category=category;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={new SqlParameter("@CategoryID",Category.CategoryID)};
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
