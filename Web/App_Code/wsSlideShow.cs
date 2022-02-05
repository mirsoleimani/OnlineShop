using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for wsSlideShow
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class wsSlideShow : System.Web.Services.WebService
{

    public wsSlideShow()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    //[System.Web.Script.Services.ScriptMethod]
    public AjaxControlToolkit.Slide[] GetSlides()
    {
        string[] imagenames = System.IO.Directory.GetFiles(Server.MapPath("~/Image"));
        AjaxControlToolkit.Slide[] photos = new AjaxControlToolkit.Slide[imagenames.Length];
        for (int i = 0; i < imagenames.Length; i++)
        {
            string[] file = imagenames[i].Split('\\');
            photos[i] = new AjaxControlToolkit.Slide("Image/" + file[file.Length - 1], file[file.Length - 1], "");
        }
        return photos;
    }

}

