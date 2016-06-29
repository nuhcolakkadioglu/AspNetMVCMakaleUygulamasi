using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostApp.Utilities.StringOperations
{
    public class StringManager
    {
        public static string ToSlug(string text)
        {
            text = text.Replace("ş", "s");

            text = text.ToLower();
            text = text.Trim();

            string encodeurl = (text ?? "".ToLower());
            encodeurl = Regex.Replace(encodeurl, @"\&+", "and");

            return encodeurl;
        }
    }
}
