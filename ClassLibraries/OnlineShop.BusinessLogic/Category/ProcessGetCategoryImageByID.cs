using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OnlineShop.BusinessLogic.Category
{
   public class ProcessGetCategoryImageByID:IBusinessLogic
    {
        Common.Category _category;       
        private MemoryStream _imageStream;

        public void Invoke()
        {
            DataAccess.Category.Select.CategoryImageByIDSelectData selectData =
                new OnlineShop.DataAccess.Category.Select.CategoryImageByIDSelectData();
            selectData.Category = Category;
            Category.ImageData = (byte[])selectData.Get();
            ImageStream = new MemoryStream((byte[])Category.ImageData);

        }
        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public System.IO.MemoryStream ImageStream
        {
            get { return _imageStream; }
            set { _imageStream = value; }
        }

    }
}
