using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.BusinessLogic.Category
{
   public class ProcessAddCategory:IBusinessLogic
    {
        private Common.Category _category;
        

        public void Invoke()
        {
            DataAccess.Category.Insert.CategoryInsertData insertData =
                new OnlineShop.DataAccess.Category.Insert.CategoryInsertData();
            insertData.Category = Category;
            insertData.Add();
           
           
        }
        public Common.Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
      
    

    }
}
