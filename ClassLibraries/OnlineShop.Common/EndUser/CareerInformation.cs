using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.EndUser
{
    public class CareerInformation
    {
        #region Fields
        private int _CareerInformationID;

        private Guid _EndUserID;

        private string _Company;

        private string _Career;

        private string _Position;

        private string _CareerGroup;

        private string _ActivityType;

        private string _ActivityField;

        private bool _LicenseHolder;

        private string _Licensor;
        private string _deputation;
        
        #endregion
        #region Properties
        public int CareerInformationID
        {
            get { return _CareerInformationID; }
            set { _CareerInformationID = value; }
        }
        public Guid EndUserID
        {
            get { return _EndUserID; }
            set { _EndUserID = value; }
        }
        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }
        public string Career
        {
            get { return _Career; }
            set { _Career = value; }
        }
        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        public string CareerGroup
        {
            get { return _CareerGroup; }
            set { _CareerGroup = value; }
        }
        public string ActivityType
        {
            get { return _ActivityType; }
            set { _ActivityType = value; }
        }
        public string ActivityField
        {
            get { return _ActivityField; }
            set { _ActivityField = value; }
        }
        public bool LicenseHolder
        {
            get { return _LicenseHolder; }
            set { _LicenseHolder = value; }
        }
        public string Licensor
        {
            get { return _Licensor; }
            set { _Licensor = value; }
        }
        public string Deputation
        {
            get { return _deputation; }
            set { _deputation = value; }
        }
        #endregion
    }
}
