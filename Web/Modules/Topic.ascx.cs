using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modules_Topic : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        lblTitle.Text = TopicName;
    }
    public string TopicName
    {
        get
        {
            object obj = this.ViewState["TopicName"];
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        set
        {
            this.ViewState["TopicName"] = value;
        }

    }
}
