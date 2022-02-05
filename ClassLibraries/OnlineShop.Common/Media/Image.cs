using System;
using System.Collections.Generic;

using System.Text;

namespace OnlineShop.Common.Media
{
    public class Image
    {
        private int _imageID;
        private Byte[] _imageData;

        public int ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }
        public Byte[] ImageData
        {
            get { return _imageData; }
            set { _imageData = value; }
        }
    }
}
