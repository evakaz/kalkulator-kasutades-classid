using System;

namespace calculator_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv1;
            int arv2;
            string tehe;
            Console.WriteLine("Enter a number: ");
            arv1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operation: ");
            tehe = Console.ReadLine();
            Console.WriteLine(Calculator.perform(arv1, arv2, tehe));
            Console.ReadKey();
        }
    }
}
