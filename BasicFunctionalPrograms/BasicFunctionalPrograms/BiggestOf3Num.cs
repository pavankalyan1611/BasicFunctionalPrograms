using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class BiggestOf3Num
    {
        public void BiggestOfThree()
        {
            Console.WriteLine("Enter First Number ");
            double one = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number ");
            double two = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter three Number ");
            double three = Convert.ToDouble(Console.ReadLine());

            double big = one;
            if (two > big)
                big = two;
            if (three > big)
                big = three;
            Console.WriteLine(big + " is bigger");

        }
    }
}
