using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_CreDel
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete(@"C:\Users\Swift\Desktop\github\Lab 2\Task 4 CreDel\Task 4 CreDel\path2.txt");
            FileStream fs = File.Create(@"C:\Users\Swift\Desktop\github\Lab 2\Task 4 CreDel\path.txt");
            //Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            //fs.Write(info, 0, info.Length);
            fs.Close();

            File.Copy(@"C:\Users\Swift\Desktop\github\Lab 2\Task 4 CreDel\path.txt",
                @"C:\Users\Swift\Desktop\github\Lab 2\Task 4 CreDel\Task 4 CreDel\path2.txt");

            File.Delete(@"C:\Users\Swift\Desktop\github\Lab 2\Task 4 CreDel\path.txt");


        }
    }
}
