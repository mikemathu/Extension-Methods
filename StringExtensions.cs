using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        private static Random random = new Random();
        //Extention Method
        public static string ToRandomCase(this string text)
        {
            string result = "";

            for (int index = 0; index < text.Length; index++)
            {
                if (random.Next(2) == 0) //We still need to create the random object
                {
                    result += text.Substring(index, 1).ToUpper();
                }
                else
                {
                    result += text.Substring(index, 1).ToLower();
                }
            }
            return result;
        }
    }
}
