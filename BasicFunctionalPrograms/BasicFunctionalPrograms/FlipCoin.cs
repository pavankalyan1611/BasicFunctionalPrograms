using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class LeapYear
    {
        public LeapYear()
        {
            Console.WriteLine("Welcome to Leap Year Peoblem :");
        }
        public void CheckLeapYear()
        {
            Console.WriteLine(" Enter the Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());

            while (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Please Enter a Four digit Year : ");
                Year = Convert.ToInt32(Console.ReadLine());
            }

            if (Year % 400 == 0)
            {
                Console.WriteLine(Year + "  Is a Leap Year ");
            }
            else if (Year % 100 == 0)
            {
                Console.WriteLine(Year + "  Is Not a Leap Year ");
            }
            else if (Year % 4 == 0)
            {
                Console.WriteLine(Year + "  Is a Leap Year ");
            }
            else
            {
                Console.WriteLine(Year + "  Is Not a Leap Year ");
            }
        }
    }
}
