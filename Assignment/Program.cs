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
            Console.ReadLine();
        }
    }
}
