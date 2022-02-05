﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OnlineShop.BusinessLogic.EndUser
{
    public class ProcessSearchEndUserByRegistrarName:IBusinessLogic
    {
        private Common.EndUser.EndUser _endUser;

        private DataSet _resultDataSet;

        public void Invoke()
        {
            DataAccess.EndUser.Select.Search.EndUserSearchByRegistrarNameSelectData selectData =
                new OnlineShop.DataAccess.EndUser.Select.Search.EndUserSearchByRegistrarNameSelectData();
            selectData.EndUser = EndUser;
            ResultDataSet = selectData.Get();
        }
        public System.Data.DataSet ResultDataSet
        {
            get { return _resultDataSet; }
            set { _resultDataSet = value; }
        }
        public Common.EndUser.EndUser EndUser
        {
            get { return _endUser; }
            set { _endUser = value; }
        }
    }
}
