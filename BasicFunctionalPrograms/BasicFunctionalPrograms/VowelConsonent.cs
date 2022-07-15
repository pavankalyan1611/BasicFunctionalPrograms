using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    public class VowelConsonent
    {
        public void CheckVowelConsonent()
        {
            Console.WriteLine("Enter a lower case Alphabet : ");
            char Alphabet = char.Parse(Console.ReadLine());

            char[] array = {'a', 'e', 'i', 'o', 'u'};
            int j = 0;
            foreach (char i in array)
            {
                if (Alphabet == i)
                {
                    Console.WriteLine("User entered \" Vowel\" Alphabet");
                    j = 1;
                    break;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("User entered \"Consonent\" Alphabet");

            }
        }
    }
}
