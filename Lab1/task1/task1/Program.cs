using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task1
{
    class Program
    {
        static bool isPrime(int n) // Declarinf boolean function
        {
            if(n < 2) //1 and negative numbers can't be counted as a prime number
            {
                return false;
            }
            for(int i = 2; i * i <= n; i++) //Declaring a cycle for checking dividers
            {
            
                if (n % i == 0)
                {
                    return false; // if any is divisible to any number return false
                }
            } return true;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // Mark limit
            string[] s = Console.ReadLine().Split();// Read array of chars
            int[] arr = new int[10000];// new array for prime numbers
            int cnt = 0; // set counter
            for(int i = 0; i < s.Length; i++) // cycle for looking prime num inside given array
            {
                int x = int.Parse(s[i]); // String to int 
                if(isPrime(x)) // checking whether given element is prime or not
                {
                    arr[cnt++] = x;//rewriting prime number into new array
                }
            }
            Console.WriteLine(cnt);
            for(int i = 0; i < cnt; i++)
            {
                Console.Write(arr[i] + " "); //printing array
            }
            Console.ReadKey();
        }
    }
}
