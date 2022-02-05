using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Shop.Select;
using System.Data;

namespace OnlineShop.BusinessLogic.Shop
{
   public class ProcessGetShopByID : IBusinessLogic
    {
        private Common.Shop.Shop _shop;
        private DataSet _resultDataSet;

        public void Invoke()
        {
            ShopByIDSelectData selectData =
                new ShopByIDSelectData();
            selectData.Shop = Shop;
            ResultDataSet = selectData.Get();

            Shop = null;
            if (ResultDataSet.Tables[0].Rows.Count > 0)
            {
                Shop = new OnlineShop.Common.Shop.Shop();
                Shop.ShopID = int.Parse(ResultDataSet.Tables[0].Rows[0]["ShopID"].ToString());
                Shop.ImageData.ImageID = int.Parse(ResultDataSet.Tables[0].Rows[0]["ImageID"].ToString());
                Shop.EndUserID = new Guid(ResultDataSet.Tables[0].Rows[0]["EndUserID"].ToString());
                Shop.Name = ResultDataSet.Tables[0].Rows[0]["Name"].ToString();
                Shop.Description = ResultDataSet.Tables[0].Rows[0]["Description"].ToString();
                Shop.CreatedOn = ResultDataSet.Tables[0].Rows[0]["CreatedOn"].ToString();
                Shop.Code = ResultDataSet.Tables[0].Rows[0]["Code"].ToString();
                Shop.Rating = int.Parse(ResultDataSet.Tables[0].Rows[0]["Rating"].ToString());


            }

        }
        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
    }
}
