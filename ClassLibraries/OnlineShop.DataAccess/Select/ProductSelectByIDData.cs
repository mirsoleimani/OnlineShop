using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common;
using System.Data;
using System.Data.SqlClient;
using OnlineShop.Common.Product;

namespace OnlineShop.DataAccess.Select
{
    public class ProductSelectByIDData : DataAccessBase
    {
        private Product _Product;
        public ProductSelectByIDData()
        {
            StoredProcedureName = StoredProcedure.Name.ProductByID_Select.ToString();
        }

        public DataSet Get()
        {
            DataSet ds;

            ProductSelectByIDDataParameters productSelectByIDDataParameters =
                new ProductSelectByIDDataParameters(Product);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            ds = dbHelper.Run(base.ConnectionString, productSelectByIDDataParameters.Parameters);

            return ds;
        }
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

    }
    public class ProductSelectByIDDataParameters
    {
        private Product _Product;

        private SqlParameter[] _Parameters;

        public ProductSelectByIDDataParameters(Product product)
        {
            _Product = product;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters = { new SqlParameter("@ProductID", Product.ProductID) };
            Parameters = parameters;
        }
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        public SqlParameter[] Parameters
        {
            get { return _Parameters; }
            set { _Parameters = value; }
        }
    }
}
