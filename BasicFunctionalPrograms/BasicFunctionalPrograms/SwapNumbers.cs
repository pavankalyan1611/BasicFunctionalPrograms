using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class SwapNumbers
    {
        public void swap()
        {
            Console.WriteLine("enter first numbers");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second numbers");

            int secondnum = Convert.ToInt32(Console.ReadLine());

            /* secondnum = firstnum + secondnum;
             firstnum = secondnum - firstnum;
             secondnum = secondnum - firstnum;
                       OR */

            int temp = firstnum;
            firstnum = secondnum;
            secondnum = temp;
            Console.Write("after swapping , First Num is : " + firstnum + "  " + "Second num is : " + secondnum);

        }
    }
}
