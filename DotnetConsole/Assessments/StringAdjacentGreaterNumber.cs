using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetConsole.Assessments
{
    public class StringAdjacentGreaterNumber
    {
       public static string Check(string str)
        {
            char[] chars = str.ToCharArray();
            string flag = "false";

            for (int i = 0; i < chars.Length - 1; i++)
            {
                int nextIndex = i + 1;
                if (nextIndex < chars.Length && Char.IsNumber(chars[i]) && Char.IsNumber(chars[nextIndex]))
                {
                    int first = chars[i];
                    int next = chars[i + 1];

                    if (ValidateAdjacentNumber(first, next))
                    {
                        flag = "true";
                        break;
                    }
                    else
                    {
                        int furtherNext = nextIndex + 1;
                        if (furtherNext < chars.Length && Char.IsNumber(chars[furtherNext]))
                        {
                            string nextNumber = (next + "" + chars[furtherNext]).Trim();
                            next = Convert.ToInt32(nextNumber);
                            if (ValidateAdjacentNumber(first, next))
                            {
                                flag = "true";
                                break;
                            }
                        }
                    }
                }

            }
            return flag;
        }

        static bool ValidateAdjacentNumber(int first, int next)
        {
            return (first % 2 == 0) && (next % 2 == 0) && (next > first);
        }
    }
}
