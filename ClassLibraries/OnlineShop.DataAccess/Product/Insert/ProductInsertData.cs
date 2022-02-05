using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace OnlineShop.DataAccess.Product.Insert
{
    public class ProductInsertData : DataAccessBase
    {
                private Common.Product.Product _product;

                private ProductInsertDataParameters _insertDaraParameters;

        public ProductInsertData()
       {
           base.StoredProcedureName = StoredProcedure.Name.sp_Product_Insert.ToString();
       }
        public void Add()
        {
            _insertDaraParameters = new ProductInsertDataParameters(Product);
            DataBaseHelper dbHelper = new DataBaseHelper(base.StoredProcedureName);
            dbHelper.Parameters = _insertDaraParameters.Parameters;
            dbHelper.Run();
        }
      	public Common.Product.Product Product
	{
		get { return _product; }
		set { _product = value; }
	}
    }

    class ProductInsertDataParameters
    {
        private Common.Product.Product _product;


        private SqlParameter[] _parameters;

        public ProductInsertDataParameters(Common.Product.Product product)
        {
            Product = product;
            Build();
        }

        private void Build()
        {
            SqlParameter[] parameters ={
                                           new SqlParameter("@ShopID",Product.ShopID),
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
