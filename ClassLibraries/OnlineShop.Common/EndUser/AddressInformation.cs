using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.EndUser
{
    public class AddressInformation
    {
        #region Fields
        private Guid _endUserID;
        
        private int _AddressInformationID;
        private string _Address1;
        private string _Address2;
        private string _City;
        private string _State;
        private string _PostalCode;
        private int _StateProvinceID;
        private bool _IsCareerAddress;
        private Byte[] _LocationMap;
        #endregion


        public AddressInformation()
        {
        }

        #region Properties
        public int AddressInformationID
        {
            get { return _AddressInformationID; }
            set { _AddressInformationID = value; }
        }
        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }
        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public string PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = value; }
        }
        public bool IsCareerAddress
        {
            get { return _IsCareerAddress; }
            set { _IsCareerAddress = value; }
        }
        public int StateProvinceID
        {
            get { return _StateProvinceID; }
            set { _StateProvinceID = value; }
        }
        public Byte[] LocationMap
        {
            get { return _LocationMap; }
            set { _LocationMap = value; }
        }
        public Guid EndUserID
        {
            get { return _endUserID; }
            set { _endUserID = value; }
        }
        #endregion

    }
}
