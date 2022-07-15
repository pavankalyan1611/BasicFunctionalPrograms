using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class PowerOfTwo
    {
        public PowerOfTwo()
        {
            Console.WriteLine("Welcome to Power Of Two Peoblem :");
        }
        public void powerof2()
        {
            Console.WriteLine("Enter The Number as you Want to know the power of 2 : ");
            int table = Convert.ToInt32(Console.ReadLine());

            while (table < 0)
            {
                Console.WriteLine("please enter valid number: ");
                table = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i <= table; i++)
            {
                int value = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine(" 2 power " + i + " = " + value);
            }
        }
    }
}
