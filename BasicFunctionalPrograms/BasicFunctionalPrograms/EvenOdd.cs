using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class EvenOdd
    {
        public void evenodd()
        {
            Console.WriteLine("Enter a Number you want to Know Wether Number is Odd or Even : ");
            double Num = Convert.ToDouble(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine(Num + " Is a Even Number ");
            }
            else
            {
                Console.WriteLine(Num + "  Is a Odd Number ");
            }
        }
    }
}
