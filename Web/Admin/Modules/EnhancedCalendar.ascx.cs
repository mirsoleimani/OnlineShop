using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class CustomControls_EnhancedCalendar : System.Web.UI.UserControl
{
    #region Regular expressions
    private static Regex regPrevMonth = new Regex(
    @"(?<PrevMonth><a.*?>&lt;</a>)",
    RegexOptions.IgnoreCase
    | RegexOptions.Singleline
    | RegexOptions.CultureInvariant
    | RegexOptions.IgnorePatternWhitespace
    | RegexOptions.Compiled
    );

    private static Regex regNextMonth = new Regex(
    @"(?<NextMonth><a.*?>&gt;</a>)",
    RegexOptions.IgnoreCase
    | RegexOptions.Singleline
    | RegexOptions.CultureInvariant
    | RegexOptions.IgnorePatternWhitespace
    | RegexOptions.Compiled
    );
	#endregion

    protected override void Render(HtmlTextWriter writer)
    {
        // turn user control to html code
        string output = CustomControls_EnhancedCalendar.RenderToString(calDate);

        // look for the previous year button
        MatchEvaluator mev = new MatchEvaluator(AppendPrevYear);
        output = regPrevMonth.Replace(output, mev);

        // look for the next year button
        mev = new MatchEvaluator(AppendNextYear);
        output = regNextMonth.Replace(output, mev);

        // output the modified code
        writer.Write(output);
    }

    /// <summary>
    /// The date displayed on the popup calendar
    /// </summary>
    public DateTime? SelectedDate
    {
        get
        {
            // null date stored or not set
            if (ViewState["SelectedDate"] == null)
            {
                return null;
            }
            return (DateTime)ViewState["SelectedDate"];
        }
        set
        {
            ViewState["SelectedDate"] = value;
            if (value != null)
            {
                calDate.SelectedDate = (DateTime)value;
                calDate.VisibleDate = (DateTime)value;
            }
            else
            {
                calDate.SelectedDate = new DateTime(0);
                calDate.VisibleDate = DateTime.Now.Date;
            }
        }
    }

    /// <summary>
    /// Called when a match to the previous month link is found
    /// </summary>
    /// <param name="m"></param>
    /// <returns></returns>
    private string AppendPrevYear(Match m)
    {
        // append the previous year link to the front of the previous month link
        return CustomControls_EnhancedCalendar.RenderToString(btnPrevYear) + "&nbsp" + m.Groups["PrevMonth"].Value;
    }

    /// <summary>
    /// Called when a match to the next month link is found
    /// </summary>
    /// <param name="m"></param>
    /// <returns></returns>
    private string AppendNextYear(Match m)
    {
        // append the previous year link to the front of the previous month link
        return m.Groups["NextMonth"].Value + "&nbsp" + CustomControls_EnhancedCalendar.RenderToString(btnNextYear);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnPrevYear_Click(object sender, EventArgs e)
    {
        calDate.VisibleDate = calDate.VisibleDate.AddYears(-1);
    }

    protected void btnNextYear_Click(object sender, EventArgs e)
    {
        calDate.VisibleDate = calDate.VisibleDate.AddYears(1);
    }

    /* User has selected a date manually with the popup */
    protected void calDate_SelectionChanged(object sender, EventArgs e)
    {
        SelectedDate = calDate.SelectedDate;
    }

    /// <summary>
    /// Resets the date to the current days date
    /// </summary>
    public void ResetDate()
    {
        SelectedDate = null;
    }

    /// <summary>
    /// Gets the HTML representation of a control
    /// </summary>
    /// <param name="c">The control to get the html code for</param>
    /// <returns>HTML code for the control</returns>
    public static string RenderToString(Control c)
    {
        bool previousVisibility = c.Visible;
        c.Visible = true; // make visible if not

        // get html code for control
        System.IO.StringWriter sw = new System.IO.StringWriter();
        HtmlTextWriter localWriter = new HtmlTextWriter(sw);
        c.RenderControl(localWriter);
        string output = sw.ToString();

        // restore visibility
        c.Visible = previousVisibility;

        return output;
    }
}
