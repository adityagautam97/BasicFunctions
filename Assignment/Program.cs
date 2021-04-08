using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MergingSorting mergingSorting = new MergingSorting();
            mergingSorting.MergingingSorting();
            enumDays enumDayObj = new enumDays();
            enumDayObj.GetNameValue();
            Patterns pattern = new Patterns();
            pattern.RPattern();
            Result results = new Result();
            results.DisplayData();
            Console.ReadLine();
        }
    }
}
