using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class Harmonics
    {
        public void harmonics()
        {
            Console.WriteLine("Enter the value of N for Nth Harmonic : ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N == 0)
            {
                Console.WriteLine(" Invalid input, please Enter the valid input: ");
                N = Convert.ToInt32(Console.ReadLine());
            }

            double Harmonic = 0;

            for (double i = 1; i <= N; i++)
            {
                Harmonic += (1 / i);

            }
            Console.WriteLine("The " + N + "th Harmonic is given by " + Harmonic);
        }
    }
}
