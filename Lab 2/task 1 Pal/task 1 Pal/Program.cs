using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_Pal
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"C:\Users\Swift\Desktop\github\Lab 2\txt.txt", FileMode.Open,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string st1 = sr.ReadLine();
            string st2=Reverse(st1);
            
            if (st1 == st2)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

          
            Console.ReadKey();

            
        }
    }
}
