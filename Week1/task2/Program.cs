using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // class 
    public class student
    {
        string name;
        string id;
        int year;
        // Construct
        public student(string NAME, string ID, int Year)
        {
            // first parametre
            name = NAME;
            // second parametre
            id = ID;
            //-------
            year = Year;
        }
        public void output()
        {
            //output
            Console.Write(name + " " + id + " " + " " + year);
        }
    }
    class Program
    {
        static int increment(int year)
        {
            return year + 1;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string i = Console.ReadLine();
            //convert string to int
            int y = int.Parse(Console.ReadLine());
           //method to increment
            y = increment(y);
            //class
            student s1 = new student(s, i, y);
            //method to output
            s1.output();
        }
    }
}
