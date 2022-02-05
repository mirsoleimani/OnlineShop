using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Operational;

public partial class Modules_ProductSearchBox : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bool allWords = AllWords;
            string searchCriteria = SearchCriteria;


            cbAllWords.Checked = allWords;

            txtSearch.Text = searchCriteria;
        }
    }
    private void Search()
    {
        string searchCriteria = txtSearch.Text;
        bool allWords = cbAllWords.Checked;

        if (txtSearch.Text.Trim() != null)
            Response.Redirect(
                string.Format("~/ProductSearchResult.aspx?SearchCriteria={0}&AllWords={1}&PageNumber={2}",
                searchCriteria, allWords.ToString(), 1));
    }
    protected void ibtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        Search();
    }
    public bool AllWords
    {
        get
        {
            return Utilities.QueryStringBool("AllWords");
        }

    }
    public string SearchCriteria
    {
        get
        {
            return Utilities.QueryString("SearchCriteria");
        }
    }



}
