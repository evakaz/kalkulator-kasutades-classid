using System;

namespace calculator_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv1 = 1;
            int arv2 = 4;
            string tehe = "+";
            Calculator calc = new Calculator(arv1, arv2, tehe);
        }
    }
}
