using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.EndUser
{
    public class EndUserRole
    {
        #region Fields
        private int _EndUserRoleID;        
        private string _RoleName;

        #endregion

        #region Properties
        public int EndUserRoleID
        {
            get { return _EndUserRoleID; }
            set { _EndUserRoleID = value; }
        }
        public string RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
        }
        #endregion
    }
}
