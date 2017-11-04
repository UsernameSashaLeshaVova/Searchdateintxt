using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"D:\1.txt";
            string writePath = @"D:\2.txt";
                string text = "";
                {
                    using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                    {
                        text = sr.ReadToEnd();
                    }
                string pattern = @"(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.][1-9][0-9][0-9][0-9]";
                Regex newReg = new Regex(pattern);
                MatchCollection matches = newReg.Matches(text);
                foreach (Match mat in matches)
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    {
                        sw.WriteLine(mat);
                    }
                }
            }
        }
    }
}