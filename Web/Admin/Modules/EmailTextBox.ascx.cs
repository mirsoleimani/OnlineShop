﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Modules_EmailTextBox : OnlineShop.Web.BaseAdminUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string Text
    {
        get
        {
            return txtValue.Text;
        }
        set
        {
            txtValue.Text = value;
        }
    }

    public Unit Width
    {
        get
        {
            return txtValue.Width;
        }
        set
        {
            txtValue.Width = value;
        }
    }

    public string ValidationGroup
    {
        get
        {
            return revValue.ValidationGroup;
        }
        set
        {
            txtValue.ValidationGroup = value;
            //rfvValue.ValidationGroup = value;
            revValue.ValidationGroup = value;
        }
    }

    public string CssClass
    {
        get
        {
            return txtValue.CssClass;
        }
        set
        {
            txtValue.CssClass = value;
        }
    }
}
