using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Patterns
    {
        public void RPattern()
        {
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");


            int i, j;
            for (i = 0; i <= 6; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (j == 0 || ((i == 0 || i == 3) && j != 4) || (j == 4 && (i == 1 || i == 2 || i == 6)) || (i == 4 && j == 2) || (i == 5 && j == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
