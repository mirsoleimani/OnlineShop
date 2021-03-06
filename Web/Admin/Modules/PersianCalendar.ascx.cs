using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Admin_Modules_PersianCalendar : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        System.Globalization.CultureInfo calture = new System.Globalization.CultureInfo("fa-IR");
        System.Globalization.DateTimeFormatInfo info = calture.DateTimeFormat;
        info.AbbreviatedDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
        info.DayNames = new string[] { "یکشنبه", "دوشنبه", "ﺳﻪشنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
        info.AbbreviatedMonthNames = new string[] { "فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
        info.MonthNames = new string[] { "فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
        info.AMDesignator = "ق.ظ";
        info.PMDesignator = "ب.ظ";
        info.ShortDatePattern = "yyyy/MM/dd";
        info.FirstDayOfWeek = DayOfWeek.Saturday;
        System.Globalization.PersianCalendar cal = new System.Globalization.PersianCalendar();

        typeof(System.Globalization.DateTimeFormatInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(info, cal);
        object obj = typeof(System.Globalization.DateTimeFormatInfo).GetField("m_cultureTableRecord", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(info);
        obj.GetType().GetMethod("UseCurrentCalendar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(obj, new object[] { cal.GetType().GetProperty("ID", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(cal, null) });
        typeof(System.Globalization.CultureInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(calture, cal);
        typeof(System.Globalization.CultureInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(calture, cal);

        System.Threading.Thread.CurrentThread.CurrentCulture = calture;
        System.Threading.Thread.CurrentThread.CurrentUICulture = calture;
        System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat = info;
        System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat = info;

    }
   
 
    protected void cldDate_SelectionChanged(object sender, EventArgs e)
    {
    
        pceDate.Commit(cldDate.SelectedDate.ToShortDateString());
    }
    public string Value
    {
        get { return txtDate.Text.ToString(); }
        set { txtDate.Text = value; }
    }

}
