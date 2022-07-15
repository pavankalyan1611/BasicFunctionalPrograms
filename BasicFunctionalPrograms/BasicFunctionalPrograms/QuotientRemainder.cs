using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class QuotientRemainder
    {
        public void CalQuotientRemainder()
        {

            Console.WriteLine("Enter a divident Number  : ");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a diviser Number  : ");
            int diviser = Convert.ToInt32(Console.ReadLine());

            int Quotient = divident / diviser;
            int Remainder = divident % diviser;

            Console.WriteLine(divident + " / " + diviser + " (Quotient) =  " + Quotient);
            Console.WriteLine(divident + " % " + diviser + " (Remainder) =  " + Remainder);

        }
    }
}
