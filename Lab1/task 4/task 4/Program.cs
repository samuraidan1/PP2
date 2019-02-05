using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Setting size

            for (int i = 1; i <= n; i++) //Creating 2 d array
            {
                for (int j = 1; j <= n; j++) 
                {
                    if (j <= i) //Condition to crate a pyramid
                        Console.Write("[*]"); // picture

                }
                Console.WriteLine();// to move to the next Line
            }
            Console.ReadKey();
        }
                }
            }
        
   

