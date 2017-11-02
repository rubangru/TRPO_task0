using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TRPO_task0
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("text.txt");
            string a;
            a = read.ReadToEnd();
            string b = @"(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.][1-9][0-9][0-9][0-9]";
            Regex regex = new Regex(b);
            MatchCollection matches = regex.Matches(a);
            StreamWriter write = new StreamWriter("text2.txt");
            foreach (Match mat in matches)
            {
                write.Write(mat.Value + "  ");
            }
            write.Close();
        }
    }
}
