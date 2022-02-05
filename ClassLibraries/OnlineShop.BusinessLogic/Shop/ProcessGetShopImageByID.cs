using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Shop;
using System.IO;
using OnlineShop.DataAccess.Shop.Select;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShopImageByID:IBusinessLogic
    {
        private Common.Shop.Shop _shop;
        private Stream _imageStream;
        
        public void Invoke()
        {
            ShopImageByIDSelectData selectData =
                new ShopImageByIDSelectData();
            selectData.Shop = Shop;

            Shop.ImageData.ImageData = (byte[])selectData.Get();
            ImageStream = new MemoryStream((byte[])Shop.ImageData.ImageData);
        }

        public Common.Shop.Shop Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }
        public System.IO.Stream ImageStream
        {
            get { return _imageStream; }
            set { _imageStream = value; }
        }
    }
}
