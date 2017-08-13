using System;

namespace _10012650_task2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            
            var number = new string[10];
            var count = 10;

            for (var i = 0; i < count; i++)
            {
                Console.WriteLine("Type in a Number");
                double number1 = double.Parse(Console.ReadLine());
                double convertedNumber = Math.Round(number1 * 10, 2);

                Console.WriteLine($"The average is {convertedNumber}");

                

            }
        }
    }
}
