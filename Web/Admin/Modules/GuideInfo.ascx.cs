using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Admin_Modules_GuideInfo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("~/SiteSettings.xml"));

            XmlNode xmlNode = xmlDoc.DocumentElement;
            txtDescription.Value = xmlNode["Guide"].InnerText.ToString();
        }
    }

    public void SaveInfo()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(Server.MapPath("~/SiteSettings.xml"));

        XmlNode xmlNode = xmlDoc.DocumentElement;
        xmlNode["Guide"].InnerText = txtDescription.Value.ToString();

        xmlDoc.Save(Server.MapPath("~/SiteSettings.xml"));
    }
    //protected void btnSave_Click(object sender, EventArgs e)
    //{
    //    SaveInfo();
    //}
}
