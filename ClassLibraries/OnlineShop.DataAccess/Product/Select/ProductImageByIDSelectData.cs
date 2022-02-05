using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Product.Select
{
    public class ProductImageByIDSelectData:DataAccessBase
    {
        OnlineShop.Common.Product.Product _product;
       
        public ProductImageByIDSelectData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_ProductImageByID_Select.ToString();
        }

        public object Get()
        {
            object imageData;
            ProductImageByIDSelectDataParameters selectDataParameters =
                new ProductImageByIDSelectDataParameters(Product);
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
            imageData = dbHelper.RunScalar(ConnectionString, selectDataParameters.Parameters);
            return imageData;

        }
        public OnlineShop.Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }

    class ProductImageByIDSelectDataParameters
    {
        OnlineShop.Common.Product.Product _product;        
        private SqlParameter[] _parameters;

        public ProductImageByIDSelectDataParameters(OnlineShop.Common.Product.Product product)
        {
            Product = product;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ImageID",Product.ImageID)
                                       };
            Parameters = parameters;
        }


        public OnlineShop.Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public SqlParameter[] Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }
}
