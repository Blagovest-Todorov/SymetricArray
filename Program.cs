using System;
using System.Linq;

namespace arrayNewReversedNumbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1, 2, 3, 4, 3 ,2 ,1 };
            bool isSymtric = true;
            //Console.WriteLine("is symetric {0}", isSymtric);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[numbers.Length - i - 1])
                {
                    isSymtric = false;
                    break;
                }
            }
            Console.WriteLine("isSymetric : {0}", isSymtric);

        }
    }
}
