using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Category.Update
{
   public class CategoryUpdateData:DataAccessBase
    {
       private Common.Category _category;
       private CategoryUpdateDataParameters _updateDataParameters;
      
       public CategoryUpdateData()
       {
           base.StoredProcedureName = StoredProcedure.Name.sp_Category_Update.ToString();

       }

       public void Update()
       {
           _updateDataParameters =
               new CategoryUpdateDataParameters(Category);
           DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);
           dbhelper.Parameters = _updateDataParameters.Parameters;
           dbhelper.Run();
       }

       public Common.Category Category
       {
           get { return _category; }
           set { _category = value; }
       }
    }
    class CategoryUpdateDataParameters
    {
        private Common.Category _category;
        private SqlParameter[] _parameters;
     
        public CategoryUpdateDataParameters(Common.Category category)
        {
            Category = category;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@CategoryID",Category.CategoryID),
                                           new SqlParameter("@ImageID",Category.ImageID),
                                           new SqlParameter("@Name",Category.Name),
                                           new SqlParameter("@Description",Category.Description),
                                           new SqlParameter("@Deleted",Category.Deleted),
                                           new SqlParameter("@Image",Category.ImageData)
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
