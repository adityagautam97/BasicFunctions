using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MergingSorting
    {
        public void MergingingSorting()
        {
            int i, j, N1, N2;
            Console.WriteLine("Enter the limit of First Array (Max is Ten)");
            N1 = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[10];
            int[] b = new int[10];
            Console.WriteLine("Enter the input of first array element");
            for (i = 0; i < N1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the limit of Second Array (Max is Ten)");

            N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input Elements for the Second Array");

            for (j = 0; j < N2; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());

            }
            var y = a.Union(b).Where(t => t > 0).ToArray().OrderBy(o => o);
            Console.WriteLine("sorted array is " + String.Join(",", y));
        }
    }
}
