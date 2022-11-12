using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ClassBank;
using Interface;


namespace TuMak
{
    class Format : System.IFormattable
    {
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format is String)
            {
                format = format as String;
                return format;

            }
            else
            {
                return "не переводит";
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 8.1");
            Bank bank = new Bank(); // 8.1
            var bank1 = new Tinkof();
            bank1.Translate(bank, 100, bank1);
            Console.WriteLine(bank.Balanse);
            Console.WriteLine(bank1.Balanse);

            string a = "abvgd"; //8.2
            Console.WriteLine($"\n\nTask 8.2\n{ Program.Reverse(a)}\n\n");

            Console.WriteLine("Task 8.3");
            string b;
            Console.WriteLine();


            Console.WriteLine("Task 8.4");
            Format format = new Format();
            format.ToString("xyi",(IFormatProvider)format);


            Console.Read();
        }


        public static string Reverse(string a)
        {
            string areverse = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                try
                {
                    areverse += a[i];
                }
                catch { }
            }
            return areverse;
        }
    }
}
