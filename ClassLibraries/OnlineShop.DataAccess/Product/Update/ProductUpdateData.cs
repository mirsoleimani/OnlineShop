using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Product.Update
{
    public class ProductUpdateData : DataAccessBase
    {

        private Common.Product.Product _product;

        private ProductUpdateDataParameters _updateDataParameters;

        public ProductUpdateData()
        {
            base.StoredProcedureName = StoredProcedure.Name.sp_Product_Update.ToString();

        }

        public void Update()
        {
            _updateDataParameters =
                new ProductUpdateDataParameters(Product);
            DataBaseHelper dbhelper = new DataBaseHelper(base.StoredProcedureName);
            dbhelper.Parameters = _updateDataParameters.Parameters;
            dbhelper.Run();
        }

        public Common.Product.Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
    }

    class ProductUpdateDataParameters
    {
        private Common.Product.Product _product;

        private SqlParameter[] _parameters;

        public ProductUpdateDataParameters(Common.Product.Product product)
        {
            Product = product;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ProductID",Product.ProductID),
                                           new SqlParameter("@ShopID",Product.ShopID),
                                           new SqlParameter("@ImageID",Product.ImageID),
                                           new SqlParameter("@Image",Product.ImageData),
                                           new SqlParameter("@Name",Product.Name),
                                           new SqlParameter("@Description",Product.Description),
                                           new SqlParameter("@UnitPrice",Product.UnitPrice),
                                           new SqlParameter("@EnableBuyButton",Product.EnableBuyButton)
                                       };
            Parameters = parameters;
        }

        public Common.Product.Product Product
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
