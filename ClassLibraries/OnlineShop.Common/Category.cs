using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common
{
    public class Category:Media.Image
    {
        #region Fields
        private int _CategoryID;
        //private int _ImageID;
        //private Byte[] _ImageData;
        private string _Name;
        private string _Description;
        private bool _deleted;
       
        #endregion
        #region Properties
        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
        //public int ImageID
        //{
        //    get { return _ImageID; }
        //    set { _ImageID = value; }
        //}
        //public Byte[] ImageData
        //{
        //    get { return _ImageData; }
        //    set { _ImageData = value; }
        //}
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public bool Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }
        #endregion

    }
}
