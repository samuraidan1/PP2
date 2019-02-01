using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
        private string name;
        private string id;
        private int year;
        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
       
        public override string ToString()
        {
            return name + " " + id + " " + year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Aidana", "18BD", 2);
            Console.Write(st);
            Console.ReadKey();
        }
    }
}
