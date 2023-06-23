using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTestDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine("Random integer number: " + randomInt);
            int zeroToNine = random.Next(10);
            Console.WriteLine("Random integer number less than 10: " + zeroToNine);
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("Random integer number from 1 till 6: " + dieRoll);
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double number from 1 till 100: " + randomDouble * 100);
            Console.WriteLine("Random float number: " + (float)randomDouble * 100F);
            Console.WriteLine("Random decimal number: " + (decimal)randomDouble * 100M);
            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine("Random boolean: " + coinFlip);
            Console.WriteLine("Press Q or q to exit");
            char key = Console.ReadKey(true).KeyChar;
            if ((key == 'q') || (key == 'Q')) {
                return;
            }
        }
    }
}
