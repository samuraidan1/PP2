﻿using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void show(string path, int x)
        {
            DirectoryInfo d = new DirectoryInfo(@path);
            FileSystemInfo[] fsi = d.GetFileSystemInfos();
            string s = new string(' ', x);
            for (int i = 0; i < fsi.Length; i++)
            {
                FileSystemInfo fs = fsi[i];
                Console.WriteLine(s + fs.Name);
                if (fs.GetType() == typeof(DirectoryInfo))
                {
                    show(@fs.FullName, x + 4);
                }
            }

        }
        static void Main(string[] args)
        {
            string s = @"C:\Users\Swift\Desktop\уни\pp1";
            show(s,0);
            Console.ReadKey();


        }
    }
}
