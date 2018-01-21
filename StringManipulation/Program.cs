using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManiuplation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "I need a \nnew line.";
            //string myString = "Go to c\\: drive";
            //string myString = @"Go to c\: drive";

            //string myString = String.Format("{1} = {0}", "First", "Second");
            //string myString = string.Format("{0:C}", 345.67);
            //string myString = string.Format("{0:N}", 3479793749369579);
            //string myString = string.Format("{0:P}", .4578);
            //string myString = string.Format("tel: {0:###.###.####}", 8167300011);
            //string myString = " Don't tell me the sky is the limit when there are footprints on the moon.  ";

            //myString = myString.Substring(6);
            //myString = myString.Substring(6, 14);
            //myString = myString.ToLower();
            //myString = myString.ToUpper();
            //myString = String.Format("Length Before: {0}\nLength After: {1}", myString.Length, myString.Trim().Length);

            /*string myString = "";
            for (int i = 0; i < 101; i++)
            {
                myString += "--" + i.ToString() + '\n';
            }*/

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 101; i++)
            {
                myString.Append("--");
                myString.Append(i);
                myString.Append("\n");
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
