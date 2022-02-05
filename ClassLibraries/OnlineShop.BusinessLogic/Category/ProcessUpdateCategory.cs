using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.DataAccess.Category.Update;

namespace OnlineShop.BusinessLogic.Category
{
    public class ProcessUpdateCategory : IBusinessLogic
    {
        private Common.Category _category;



        public void Invoke()
        {
            CategoryUpdateData updateData =
                new CategoryUpdateData();
            updateData.Category = Category;
            updateData.Update();
        }
        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
