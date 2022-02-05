using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Modules_Pager : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Show(int currentPage,int howManyPages,string firstPageUrl,string pageUrlFormat,bool showPages)
    {
        if (howManyPages>1)
        {
            this.Visible = true;

            currentPageLabel.Text = currentPage.ToString();
            howManyPagesLabel.Text = howManyPages.ToString();
            
            if(currentPage==1)
            {
                previousLink.Enabled = false;
            }
            else
            {
                previousLink.NavigateUrl =
                    (currentPage == 2) ? firstPageUrl : string.Format(pageUrlFormat, currentPage - 1);
            }

            if(currentPage == howManyPages)
            {
                nextLink.Enabled = false;
            }
            else
            {
                nextLink.NavigateUrl =
                    string.Format(pageUrlFormat, currentPage + 1);
            }
            if (showPages)
            {
                DataTable tbpages = new DataTable("Pages");
                DataColumn tcPages1 = new DataColumn("PageNumber");
                DataColumn tcPages2 = new DataColumn("ShopID");
                DataRow trPages;
                tbpages.Columns.Add(tcPages1);
                tbpages.Columns.Add(tcPages2);
               
                for (int i = 0; i < howManyPages; i++)
                {
                    trPages = tbpages.NewRow();
                    trPages["PageNumber"]=i+1;
                    trPages["ShopID"]=156;
                    tbpages.Rows.Add(trPages);
                }
                pagesRepeater.DataSource = tbpages;
                pagesRepeater.DataBind();

            }
        }
        else
        {
            this.Visible = false;
        }
    }
}
struct PageUrl
{
    private int _pageNumber;  
    private string _url;

    public PageUrl(int pageNumber, string url)
    {
        this._pageNumber = pageNumber;
        this._url = url;
    }
    public int PageNumber
    {
        get { return _pageNumber; }
   
    }
    public string Url
    {
        get { return _url; }
      
    }


}
