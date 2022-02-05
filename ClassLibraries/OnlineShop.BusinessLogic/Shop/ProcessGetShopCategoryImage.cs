using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Shop;
using System.IO;
using OnlineShop.DataAccess.Shop.Select;

namespace OnlineShop.BusinessLogic.Shop
{
    public class ProcessGetShopCategoryImage:IBusinessLogic
    {
        private ShopCategory _shopCategory;
        private Stream _imageStream;

        public ProcessGetShopCategoryImage()
        {
            
        }
        public void Invoke()
        {
            ShopCategoryImageByIDSelectData shopCategoryImageData =
                new ShopCategoryImageByIDSelectData();
            shopCategoryImageData.ShopCategory = ShopCategory;

            ShopCategory.ImageData = (byte[])shopCategoryImageData.Get();
            ImageStream = new MemoryStream((byte[])ShopCategory.ImageData);
            
        }

        public OnlineShop.Common.Shop.ShopCategory ShopCategory
        {
            get { return _shopCategory; }
            set { _shopCategory = value; }
        }

        public System.IO.Stream ImageStream
        {
            get { return _imageStream; }
            set { _imageStream = value; }
        }
    }
}
