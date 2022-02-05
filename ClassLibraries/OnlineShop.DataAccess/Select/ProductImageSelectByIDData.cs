using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OnlineShop.Common;
using OnlineShop.Common.Product;

namespace OnlineShop.DataAccess.Select
{
    public class ProductImageSelectByIDData:DataAccessBase
    {
        private Product _Product;
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }
        public ProductImageSelectByIDData()
        {
            base.StoredProcedureName = StoredProcedure.Name.ProductImage_Select.ToString();
        }

        public object Get()
        {
            object imageData;
            ProductImageSelectByIDDataParameters productImageSelectByIDDataParameters =
                new ProductImageSelectByIDDataParameters(Product);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            imageData = dbHelper.RunScalar(base.ConnectionString,productImageSelectByIDDataParameters.Parameters);
            return imageData;

        }
    }
    public class ProductImageSelectByIDDataParameters
    {
        private Product _Product;
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        private SqlParameter[] _Parameters;
        public SqlParameter[] Parameters
        {
            get { return _Parameters; }
            set { _Parameters = value; }
        }

        public ProductImageSelectByIDDataParameters(Product product)
        {
            Product = product;
            Build();
        }

        public void Build()
        {
            //SqlParameter[] parameters =
            //{
            //    new SqlParameter("@ProductImageID",Product.ProductImageID)
            //};
        }
    }
}
