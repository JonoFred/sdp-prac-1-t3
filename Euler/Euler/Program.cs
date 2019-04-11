using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {


            //Sum square difference
            int squareOfSum = 0;
            int sumOfSquare = 0;
            int difference = 0;

            for (int i = 0; i <= 100; i++)
            {
                squareOfSum += i;
                sumOfSquare += i * i;
            }

            squareOfSum = squareOfSum * squareOfSum;
            difference = squareOfSum - sumOfSquare;
            
            Console.WriteLine(difference);

//-------------------------------------------------------------------------------------------------//
            //Multiples of 3 and 5
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine(sum);

//--------------------------------------------------------------------------------------------------//

            //
        }
    }
}
