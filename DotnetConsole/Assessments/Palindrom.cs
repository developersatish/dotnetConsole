using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotnetConsole.Assessments
{
    public class Palindrom
    {
       public static string Check(string str)
        {
            string flag = "false";
            str = Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled).Trim().ToUpper();
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = "false";
                    break;
                }
                else
                    flag = "true";
            }
            // code goes here  
            return flag;

        }
    }
}
