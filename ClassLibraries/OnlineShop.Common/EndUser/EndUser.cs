using System;
using System.Collections.Generic;

using System.Text;

namespace OnlineShop.Common.EndUser
{
    public class EndUser
    {
        #region Fields
        private Guid _EndUserID;
        private string _UserName;
        private string _PasswordHash;
        private string _PasswordSalt;
        private string _createdOn;
        private bool _deleted;
        private EndUserRole _endUserRoleData;
        private PersonalInformation _personalInfoData;
        private CareerInformation _careerInfoData;
        private ContactInformation _contactInfodata;
        private AddressInformation _addressInfoData;        
        private Shop.Shop _ShopData;
        
        public EndUser()
        {
            _endUserRoleData = new EndUserRole();
            _personalInfoData = new PersonalInformation();
            _careerInfoData = new CareerInformation();
            _contactInfodata = new ContactInformation();
            _addressInfoData = new AddressInformation();
            _ShopData = new OnlineShop.Common.Shop.Shop(); 
        }
        #endregion
        #region Properties
        public Guid EndUserID
        {
            get { return _EndUserID; }
            set { _EndUserID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string PasswordHash
        {
            get { return _PasswordHash; }
            set { _PasswordHash = value; }
        }
        public string PasswordSalt
        {
            get { return _PasswordSalt; }
            set { _PasswordSalt = value; }
        }
        public string CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }
        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }
        public OnlineShop.Common.EndUser.EndUserRole EndUserRoleData
        {
            get { return _endUserRoleData; }
            set { _endUserRoleData = value; }
        }
        public OnlineShop.Common.EndUser.PersonalInformation PersonalInfoData
        {
            get { return _personalInfoData; }
            set { _personalInfoData = value; }
        }
        public OnlineShop.Common.EndUser.CareerInformation CareerInfoData
        {
            get { return _careerInfoData; }
            set { _careerInfoData = value; }
        }
        public OnlineShop.Common.EndUser.ContactInformation ContactInfodata
        {
            get { return _contactInfodata; }
            set { _contactInfodata = value; }
        }
        public OnlineShop.Common.EndUser.AddressInformation AddressInfoData
        {
            get { return _addressInfoData; }
            set { _addressInfoData = value; }
        }
        public Shop.Shop ShopData
        {
            get { return _ShopData; }
            set { _ShopData = value; }
        }
        #endregion

    }
}
