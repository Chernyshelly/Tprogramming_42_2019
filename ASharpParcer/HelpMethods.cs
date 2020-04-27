using System;
using System.IO;
using System.Collections.Generic;

namespace ASharpParcer
{
    public class HelpMethods
    {
        public static string CharArrToString(char[] mass)
        {
            string s = string.Empty;
            foreach (var item in mass)
            {
                s = s + item;
            }

            return s;
        }
    }
}
