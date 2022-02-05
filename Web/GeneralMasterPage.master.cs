using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GeneralMasterPage : System.Web.UI.MasterPage
{
    public GeneralMasterPage()
    {

    }
    public string process()
    {
        return "1";
    }
    public string TopicName
    {
        set
        {
            ctrlTopic.TopicName = value;
        }
        get
        {
            return ctrlTopic.TopicName;
        }
    }
}

