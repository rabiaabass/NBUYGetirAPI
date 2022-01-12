using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NBUYGetirCommon.URL
{
    public static class UrlHelper
    {
        public static bool ISUrl(string url)
        {
            string pattern = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";

            var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            return regex.IsMatch(url);
        }
    }
}
