using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common.EndUser
{
    public class PersonalInformation
    {
        #region Fields
        private int _PersonalInformationID;
        private Guid _EndUserID;
        private string _FirstName;
        private string _LastName;
        private string _FatherName;
        private string _Gender;
        private string _MaritalStatus;
        private string _EducationDegree;
        private string _income;
        private string _birthDate;
        private string _registeredBy;
        public string RegisteredBy
        {
            get { return _registeredBy; }
            set { _registeredBy = value; }
        }
        #endregion

        #region Properties
        public int PersonalInformationID
        {
            get { return _PersonalInformationID; }
            set { _PersonalInformationID = value; }
        }
        public Guid EndUserID
        {
            get { return _EndUserID; }
            set { _EndUserID = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string FatherName
        {
            get { return _FatherName; }
            set { _FatherName = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public string MaritalStatus
        {
            get { return _MaritalStatus; }
            set { _MaritalStatus = value; }
        }
        public string EducationDegree
        {
            get { return _EducationDegree; }
            set { _EducationDegree = value; }
        }
        public string Income
        {
            get { return _income; }
            set { _income = value; }
        }
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        #endregion
    }
}
