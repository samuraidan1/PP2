using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        
        static int[] Dublicate(int []arr) // creating method for creating new array of duplicates
        {
            int[] arr2 = new int[2000]; // setting new array
            for(int i=0; i<arr.Length; i++)
            {
                arr2[i * 2] = arr[i]; //setting number
                arr2[i * 2 + 1] = arr[i];// duplicating number 
            }

            return arr2;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //setting size of array
            string[] s = Console.ReadLine().Split(); // Splitting array into single elements
            int[] arr = new int[n]; // new array
            for(int i=0; i<n; i++)
            {
                arr[i] = int.Parse(s[i]); //Converting char into int
            }

            int[] arr2 = Dublicate(arr); // starting method 
            for (int i=0; i < n*2; i++)
            {
                Console.Write(arr2[i] + " "); //Decaring array
            }
        }
    }
}
