using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class FlipCoin
    {
        public FlipCoin()
        {
            Console.WriteLine("Welcome to Flip Coin Peoblem :");
        }
        public void FlipPercentage()
        {
            int Head = 0;
            int Tail = 0;
            Console.WriteLine("Enter the number of times you want to flip the coin : ");
            int NumofFlips = Convert.ToInt32(Console.ReadLine());

            while (NumofFlips <= 0)
            {
                Console.WriteLine("You Are Entered Lessthen 0, please Enter Greterthen 0");
                Console.WriteLine("Please Enter again :");
                NumofFlips = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < NumofFlips; i++)
            {
                Random flip = new Random();
                int Head_Tail = flip.Next(0, 2);

                if (Head_Tail < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
            }
            float HeadPer = (float)Head * 100 / NumofFlips;
            float TailPer = (float)Tail * 100 / NumofFlips;

            Console.WriteLine("Heads :"+Head +" -> "+ HeadPer + " % of the times the result was heads. ");
            Console.WriteLine("Tails :"+Tail +" -> "+ TailPer + "% of the times the result was tails");
        }
    }
}
