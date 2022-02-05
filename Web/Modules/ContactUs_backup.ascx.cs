using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;

public partial class Modules_ContactUs : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            textName.Focus();
        }
    }
    private void SendMessage()
    {
        if (Page.IsValid)
        {
            EmailContents contents = new EmailContents();
            contents.FromName = textName.Text;
            contents.FromAddress = textEmail.Text;
            contents.Body = textComment.Text;
            contents.Subject = "Website feedback";

            EmailManager emailMgr = new EmailManager();
            emailMgr.Send(contents);

            if (emailMgr.IsSent)
            {
                Response.Redirect("ContactUsConfirm.aspx");


            }
        }
    }
    protected void commandSubmit_Click(object sender, EventArgs e)
    {
        SendMessage();
    }
    protected void commandReset_Click(object sender, EventArgs e)
    {
        textName.Text = "";
        textEmail.Text = "";
        textComment.Text = "";
        textName.Focus();

    }
    protected void test_Click(object sender, ImageClickEventArgs e)
    {
        // Response.Redirect(String.Format("http://maps.google.co.uk/maps?saddr={0}&daddr=&daddr=Wigan+WN6+0HS,+United+Kingdom&iwloc=1&dq=Tangent+Design", txtPostcode1.Text));
        Response.Redirect(String.Format("https://maps.google.com/maps?q=OSUN+Shopping+Center+%4032.632855,51.666373&hl=en&sll=37.0625,-95.677068&sspn=35.410182,86.572266&t=m&z=14"));
    }
}
