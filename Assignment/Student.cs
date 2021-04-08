using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Student
    {
        public int rollNo;
        public string name;
        public int marks1;
        public int marks2;
        public int marks3;
        public int marks4;
        public int marks5;
        public int marks6;

        public void insertData(int rn, string n,int m1, int m2, int m3, int m4, int m5, int m6)
        {
            rollNo = rn;
            name = n;
            marks1 = m1;
            marks2 = m2;
            marks3 = m3;
            marks4 = m4;
            marks5 = m5;
            marks6 = m6;
        }
        public void displayData()
        {
            Console.WriteLine("Name of Student is " + name);
            Console.WriteLine("Roll Number of " + name + " is " + rollNo);
            Console.WriteLine("Marks obtained in subject 1 is " + marks1);
            Console.WriteLine("Marks obtained in subject 2 is " + marks2);
            Console.WriteLine("Marks obtained in subject 3 is " + marks3);
            Console.WriteLine("Marks obtained in subject 4 is " + marks4);
            Console.WriteLine("Marks obtained in subject 5 is " + marks5);
            Console.WriteLine("Marks obtained in subject 6 is " + marks6);
            Console.WriteLine("\n");


        }
    }
}
