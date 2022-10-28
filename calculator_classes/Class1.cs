using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_classes
{
    class Calculator
    {
        public int arv1;
        public int arv2;
        private string tehe;
        public static int history = 0;


        public Calculator(int aArv1, int aArv2, string aTehe)
        {
            arv1 = aArv1;
            arv2 = aArv2;
            Tehe = aTehe;
            history++;
        }


        public string Tehe
        {
            get { return tehe; }
            set
            {
                if (value == "+" || value == "-" || value == "*" || value == "/" )
                {
                    tehe = value;
                }
                else
                {
                    throw new ApplicationException("Not supported operation");
                }
            }
        }
    }
}
