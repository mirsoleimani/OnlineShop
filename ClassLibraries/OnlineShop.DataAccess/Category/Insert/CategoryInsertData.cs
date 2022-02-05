using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Category.Insert
{
    public class CategoryInsertData:DataAccessBase
    {
        private Common.Category _category;
        private CategoryInsertDataParameters _insertDaraParameters;

       public CategoryInsertData()
       {
           base.StoredProcedureName = StoredProcedure.Name.sp_Category_Insert.ToString();
       }
        public void Add()
        {
            _insertDaraParameters = new CategoryInsertDataParameters(Category);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            dbHelper.Parameters = _insertDaraParameters.Parameters;
            dbHelper.Run();
        }
       public Common.Category Category
       {
           get { return _category; }
           set { _category = value; }
       }

    }

    class CategoryInsertDataParameters
    {
        private Common.Category _category;
        
        private SqlParameter[] _parameters;
        
        public CategoryInsertDataParameters(Common.Category category)
        {
            Category = category;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                          new SqlParameter("@Image",Category.ImageData),
                                          new SqlParameter("@Name",Category.Name),
                                          new SqlParameter("@Description",Category.Description),
                                          new SqlParameter("@Deleted",Category.Deleted)
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
