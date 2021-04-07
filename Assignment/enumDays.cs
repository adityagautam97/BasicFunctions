using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class enumDays
    {
        enum WeekDays{Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        public void GetNameValue()
        {
            Console.WriteLine("Read values and Names of the WeekDays enum");
            foreach (int i in Enum.GetValues(typeof(WeekDays)))
            {
                //casting 
                var val = (WeekDays)i;
                Console.WriteLine("value of {0} is {1}", val.ToString(), i);
            }
        }
    }
}
