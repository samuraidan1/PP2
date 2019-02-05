using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
       public string name; //identify name as string
        public string id; // identify id as string
        public int year; //identify year as int number

       public Student(string name,string id) // create pointer for initialization
        {
            this.name = name;
            this.id = id;
        }
        public void addYear() //increment of  the year
        {
            this.year++;
        }
        public void Printi() //method for printing info
        {
            Console.Write(name+" "+id+" "+year);
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Aidana", "18Bd110701"); //Declaring new object in Student class
            st.year = 3;// Setting an info about year
            st.addYear(); // execution of the increment
            st.Printi(); // Printing info
            Console.ReadKey();
        }
    }
}
