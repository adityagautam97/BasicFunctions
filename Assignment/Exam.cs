using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Exam : Student
    {
        public void marks()
        {
            Student Aditya = new Student();
            Student Sumit = new Student();
            Student Ankit = new Student();
            Student Neha = new Student();
            Aditya.insertData(1, "Aditya", 80, 90, 100, 100, 90, 90);
            Sumit.insertData(4, "Sumit", 100, 100, 100, 100, 100, 100);
            Ankit.insertData(2, "Ankit", 100, 100, 100, 100, 100, 100);
            Neha.insertData(3, "Neha", 100, 100, 100, 100, 100, 100);
            Aditya.displayData();
            Sumit.displayData();
            Ankit.displayData();
            Neha.displayData();
        }

    }
}
