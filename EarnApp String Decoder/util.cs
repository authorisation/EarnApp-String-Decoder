using System;
using System.Text;

namespace EarnApp_String_Decoder
{
    public static class util
    {
        public static string decode(this string s)
        {
            int num = s.IndexOf('=');
            int length = s.Length;
            string s2;
            if (num == -1)
            {
                s2 = s.Substring(length - 3) + s.Substring(0, length - 3);
            }
            else
            {
                s2 = s.Substring(num - 3, 3) + s.Substring(0, num - 3) + s.Substring(num);
            }
            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(s2));
            }
            catch
            {
            }
            return null;
        }
    }
}
