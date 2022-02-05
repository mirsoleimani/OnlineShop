using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic
{
   public class ProcessGetStateProvinces:IBusinessLogic
    {
       private Common.SateProvince _stateProvince;
       
        private DataSet _resultDataSet;

        public void Invoke()
        {
            DataAccess.StateProvincesSelectData selectData =
                new OnlineShop.DataAccess.StateProvincesSelectData();
           
            ResultDataSet = selectData.Get();

        }
        public DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }


    }
}
