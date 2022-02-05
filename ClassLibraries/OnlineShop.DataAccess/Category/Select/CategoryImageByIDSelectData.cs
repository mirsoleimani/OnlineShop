using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Category.Select
{
    public class CategoryImageByIDSelectData:DataAccessBase
    {
        Common.Category _category;
       
        public CategoryImageByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_CategoryImageByID_Select.ToString();
        }
        public object Get()
        {
            object imageData;
            CategoryImageByIDSelectDataParameters selectDataParameters =
                new CategoryImageByIDSelectDataParameters(Category);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            imageData = dbHelper.RunScalar(ConnectionString, selectDataParameters.Parameters);
            return imageData;

        }
        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }

   class CategoryImageByIDSelectDataParameters
   {
               OnlineShop.Common.Category _category;        
	
        private SqlParameter[] _parameters;

        public CategoryImageByIDSelectDataParameters(OnlineShop.Common.Category category)
        {
            Category = category;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ImageID",Category.ImageID)
                                       };
            Parameters = parameters;
        }


        public OnlineShop.Common.Category Category
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
