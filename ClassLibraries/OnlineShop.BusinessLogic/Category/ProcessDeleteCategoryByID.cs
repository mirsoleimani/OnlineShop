using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.Category
{
    //Added by elahe
   public class ProcessDeleteCategoryByID:IBusinessLogic
    {
         private Common.Category _category;
       

         public void Invoke()
         {
             
             DataAccess.Category.Delete.CategoryByIDDeleteData  deleteData =
               new OnlineShop.DataAccess.Category.Delete.CategoryByIDDeleteData();
             deleteData.Category = Category;
             deleteData.Del();

         }
         public Common.Category Category
         {
             get { return _category; }
             set { _category = value; }
         }

    }
}
