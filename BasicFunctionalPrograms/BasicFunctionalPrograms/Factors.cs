using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class Factors
    {
        public void factors()
        {
            Console.WriteLine("Enter the num as you want to know the factors that num : ");
            int Num = Convert.ToInt32(Console.ReadLine());
            while (Num < 0)
            {
                Console.WriteLine("Invaild input, please enter the num more then 0 : ");
                Num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("prime factors for " + Num + " are :");

            for (int i = 2; i * i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
