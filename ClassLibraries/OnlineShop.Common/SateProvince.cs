using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Common
{
    public class SateProvince
    {
        private int _stateProvinceID;
	public int StateProvinceID
	{
		get { return _stateProvinceID; }
		set { _stateProvinceID = value; }
	}
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    }
}
