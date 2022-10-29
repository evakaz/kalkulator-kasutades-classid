using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_classes
{
    struct Args
    {
        public int arg1;
        public int arg2;
    }


    interface ICalc
    {
        int calc(Args args);
    }



    class Liita : ICalc
    {
        public int calc(Args args) { return args.arg1 + args.arg2; }
    }

    class Lahuta : ICalc
    {
        public int calc(Args args) { return args.arg1 - args.arg2; }
    }

    class Korruta : ICalc
    {
        public int calc(Args args) { return args.arg1 * args.arg2; }
    }


    class Jaga : ICalc
    {
        public int calc(Args args)
        {
            if (args.arg2 == 0)
            {
                throw new Exception("error");
            }
            return args.arg1 / args.arg2;
        }
    }

    class CalculatorFactory
    {
        public static ICalc get(string tehe)
        {
            if (tehe == "+")
            {
                return new Liita();
            }
            else if (tehe == "-")
            {
                return new Lahuta();
            }
            else if (tehe == "*")
            {
                return new Korruta();
            }
            else if (tehe == "/")
            {
                return new Jaga();
            }
            throw new Exception("Not supported operation");
        }
    }


    class Calculator
    {
        public static int perform(int arv1, int arv2, string aTehe)
        {
            ICalc calculator = CalculatorFactory.get(aTehe);

            Args a;
            a.arg1 = arv1;
            a.arg2 = arv2;
                      
            return calculator.calc(a);
        }
    }
}
