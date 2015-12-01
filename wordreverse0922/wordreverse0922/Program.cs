using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordreverse0922
{
    class Program
    {


        static void Main()
        {
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            //add a call to extract Capitals
            string caps = ExtractCapitals(text);
            Console.WriteLine(caps);
        }



        /*  static void Main() //changed this from []args
        {
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);


            // Console output:
            // tide ME
        }
        */
        static string ReverseText(string text) //hey, this is a method! Look, you’ve created your own.
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
        

        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
                
            }
            return result.ToString(); //return value outside for loop
        }

    }
}
