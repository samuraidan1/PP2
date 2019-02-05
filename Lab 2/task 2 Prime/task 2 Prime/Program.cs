using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_Prime
{
   
    class Program
    { static bool IsPrime(int n)
        {
            if (n < 2) {return false; }
        for(int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
             
        }return true;
    }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Swift\Desktop\github\Lab 2\1.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            string[] arr = s.Split();
            sr.Close();
            fs.Close();
            FileStream ofs = new FileStream(@"C:\Users\Swift\Desktop\github\Lab 2\output.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sr2 = new StreamWriter(ofs);
            for(int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (IsPrime(x))
                {
                    sr2.Write(x + " ");
                }
            }

            sr2.Close();
            ofs.Close();

            Console.ReadKey();
              
        }
    }
}
