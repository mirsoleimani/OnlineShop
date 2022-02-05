using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Security.Cryptography;
using System.Xml;

namespace OnlineShop.Operational
{
    public class Utilities
    {
        public static string FormatText(string text, bool allow)
        {
            string formatted = "";
            StringBuilder sb = new StringBuilder(text);
            sb.Replace(" ", "&nbsp;");
            if (!allow)
            {
                sb.Replace("<br>", Environment.NewLine);
                sb.Replace("&nbsp;", " ");
                formatted = sb.ToString();
            }
            else
            {
                StringReader sr = new StringReader(sb.ToString());
                StringWriter sw = new StringWriter();
                while (sr.Peek() > -1)
                {
                    string tmp = sr.ReadLine();
                    sw.Write(tmp + "<br>");

                }
                formatted = sw.GetStringBuilder().ToString();

            }
            return formatted;
        }
        public static void LogException(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath("~/ExceptionLog/LogFile.txt"), true))
            {
                //sw.WriteLine(DateTime.Now.ToString()+
                //    Environment.NewLine+
                //    ex.InnerException.ToString()+
                //    Environment.NewLine+
                //    Environment.NewLine);
            }
        }
        public static string QueryString(string Name)
        {
            string result = string.Empty;
            if (HttpContext.Current != null && HttpContext.Current.Request.QueryString[Name] != null)
                result = HttpContext.Current.Request.QueryString[Name].ToString();
            return result;
        }

        /// <summary>
        /// Gets boolean value from query string 
        /// </summary>
        /// <param name="Name">Parameter name</param>
        /// <returns>Query string value</returns>
        public static bool QueryStringBool(string Name)
        {
            string resultStr = QueryString(Name).ToUpperInvariant();
            return (resultStr == "YES" || resultStr == "TRUE" || resultStr == "1");
        }

        /// <summary>
        /// Gets integer value from query string 
        /// </summary>
        /// <param name="Name">Parameter name</param>
        /// <returns>Query string value</returns>
        public static int QueryStringInt(string Name)
        {
            string resultStr = QueryString(Name).ToUpperInvariant();
            int result;
            Int32.TryParse(resultStr, out result);
            return result;
        }

        /// <summary>
        /// Gets integer value from query string 
        /// </summary>
        /// <param name="Name">Parameter name</param>
        /// <param name="DefaultValue">Default value</param>
        /// <returns>Query string value</returns>
        public static int QueryStringInt(string Name, int DefaultValue)
        {
            string resultStr = QueryString(Name).ToUpperInvariant();
            if (resultStr.Length > 0)
            {
                return Int32.Parse(resultStr);
            }
            return DefaultValue;
        }

        /// <summary>
        /// Creates a password hash
        /// </summary>
        /// <param name="Password">Password</param>
        /// <param name="Salt">Salt</param>
        /// <returns>Password hash</returns>
        public static string CreatePasswordHash(string Password, string Salt)
        {
            //MD5, SHA1
            string passwordFormat = "MD5";
            return FormsAuthentication.HashPasswordForStoringInConfigFile(Password + Salt, passwordFormat);
        }

        /// <summary>
        /// Creates a salt
        /// </summary>
        /// <param name="size">A salt size</param>
        /// <returns>A salt</returns>
        public static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] data = new byte[size];
            provider.GetBytes(data);
            return Convert.ToBase64String(data);
        }

        public static string ShortDate()
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

            return DateTime.Now.ToShortDateString();
        }

        public static string GenerateRandomCaptchaCode(int length)
        {
            Random random = new Random();
            string str=new string('a',1);

            for (int i = 0; i < length; i++)
                str = string.Concat(str, random.Next(9).ToString());

            return str;
        }
        //public static int SiteSettings(string node)
        //{

        //}


    }
}
