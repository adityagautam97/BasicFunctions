using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public class Result : Exam
    {
        /// <summary>
        /// Creating List for Exam Model
        /// </summary>
        List<Exam> StudentsData = new List<Exam>();
        /// <summary>
        /// Constructor for calling marks() on Page load
        /// </summary>
        public Result()
        {
            marks();
        }
        public void insertData(Exam exam)
        {
            StudentsData.Add(exam);
        }
        /// <summary>
        ///For calculating Average 
        /// </summary>
        /// <param name="exam"></param>
        /// <returns> Average</returns>
        public int AvgCalc(Exam exam)
        {
            return (exam.Marks1 + exam.Marks2 + exam.Marks3 + exam.Marks4 + exam.Marks5 + exam.Marks6) / 6;
            
        }
        /// <summary>
        /// Inserting Data in a Model Exam List
        /// </summary>
        public void marks()
        {
            Exam AdityaRes = new Exam();
            AdityaRes.name = "Aditya";
            AdityaRes.rollNo = 1;
            AdityaRes.Marks1 = 90;
            AdityaRes.Marks2 = 80;
            AdityaRes.Marks3 = 75;
            AdityaRes.Marks4 = 100;
            AdityaRes.Marks5 = 50;
            AdityaRes.Marks6 = 85;
            AdityaRes.Average = AvgCalc(AdityaRes);
            insertData(AdityaRes);

            Exam SumitRes = new Exam();
            SumitRes.name = "Sumit";
            SumitRes.rollNo = 4;
            SumitRes.Marks1 = 90;
            SumitRes.Marks2 = 80;
            SumitRes.Marks3 = 80;
            SumitRes.Marks4 = 100;
            SumitRes.Marks5 = 50;
            SumitRes.Marks6 = 85;
            SumitRes.Average = AvgCalc(SumitRes);
            insertData(SumitRes);

            Exam AnkitRes = new Exam();
            AnkitRes.name = "Ankit";
            AnkitRes.rollNo = 2;
            AnkitRes.Marks1 = 90;
            AnkitRes.Marks2 = 88;
            AnkitRes.Marks3 = 75;
            AnkitRes.Marks4 = 100;
            AnkitRes.Marks5 = 50;
            AnkitRes.Marks6 = 85;
            AnkitRes.Average = AvgCalc(AnkitRes); 
            insertData(AnkitRes);

            Exam NehaRes = new Exam();
            NehaRes.name = "Neha";
            NehaRes.rollNo = 3;
            NehaRes.Marks1 = 90;
            NehaRes.Marks2 = 80;
            NehaRes.Marks3 = 75;
            NehaRes.Marks4 = 100;
            NehaRes.Marks5 = 70;
            NehaRes.Marks6 = 85;
            NehaRes.Average = AvgCalc(NehaRes); 

        }
        public void DisplayData()
        {
            foreach (var i in StudentsData)
            {
                Console.WriteLine("Name of Student is " + i.name);
                Console.WriteLine("Roll Number of " + i.name + " is " + i.rollNo);
                Console.WriteLine("Marks obtained in subject 1 is " + i.Marks1);
                Console.WriteLine("Marks obtained in subject 2 is " + i.Marks2);
                Console.WriteLine("Marks obtained in subject 3 is " + i.Marks3);
                Console.WriteLine("Marks obtained in subject 4 is " + i.Marks4);
                Console.WriteLine("Marks obtained in subject 5 is " + i.Marks5);
                Console.WriteLine("Marks obtained in subject 6 is " + i.Marks6);
                Console.WriteLine("Average Marks Obtained is " + i.Average);
                
                Console.WriteLine("\n");
            }
        }
    }
}
