using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.EndUser
{
    public class ContactInformation
    {
        #region Fields
        private Guid _EndUserID;
        private int _ContactInformationID;
        private string _Phone;
        private string _CellPhone;
        private string _Fax;
        private string _Email;
        private string _areaCode;
        
        #endregion
        #region Properties
        public Guid EndUserID
        {
            get { return _EndUserID; }
            set { _EndUserID = value; }
        }
        public int ContactInformationID
        {
            get { return _ContactInformationID; }
            set { _ContactInformationID = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string CellPhone
        {
            get { return _CellPhone; }
            set { _CellPhone = value; }
        }
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string AreaCode
        {
            get { return _areaCode; }
            set { _areaCode = value; }
        }
        #endregion

    }
}
