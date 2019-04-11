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
        }
    }
}
