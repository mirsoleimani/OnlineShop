using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Modules_AboutUs : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(Server.MapPath("~/SiteSettings.xml"));

        XmlNode xmlNode = xmlDoc.DocumentElement;
        lblDescription.Text = xmlNode["AboutUs"].InnerText.ToString();
    }
}
