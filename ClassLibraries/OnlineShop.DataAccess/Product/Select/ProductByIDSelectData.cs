using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OnlineShop.DataAccess.Product.Select
{
    public class ProductByIDSelectData:DataAccessBase
    {
        private Common.Product.Product _product;
        
                public ProductByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ProductByID_Select.ToString();

        }
        public DataSet Get()
        {
            DataSet ds;

            ProductByIDSelectDataParameters selectDataParameters =
                new ProductByIDSelectDataParameters(Product);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            ds = dbHelper.Run(ConnectionString, selectDataParameters.Parameters);

            return ds;
        }
        public Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }
    

    class ProductByIDSelectDataParameters
    {
                        private Common.Product.Product _product;      

        private SqlParameter[] _parameters;

        public ProductByIDSelectDataParameters(Common.Product.Product product)
        {
            Product = product;
            Build();
        }
        
        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ProductID",Product.ProductID)
                                       };
            Parameters = parameters;
        }
     	public Common.Product.Product Product
	{
		get { return _product; }
		set { _product = value; }
	}
        public System.Data.SqlClient.SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
