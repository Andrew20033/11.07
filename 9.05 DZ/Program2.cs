using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_CSharp_11._07
{


    public class Number
    {
        double a;
        public Number()
        { }
        public Number(double x)
        { a = x; }
        public void Print()
        {
            Console.WriteLine("a={0}", a);
        }
        public bool Prime()
        {
            bool resultprime = true;

            if (a > 1)
            {
                for (var i = 2u; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        resultprime = false;
                        break;
                    }
                }
            }
            else
            {
                resultprime = false;
            }

            return resultprime;
        }



        public bool Correct()
        {
            bool resultcorrect = false;
            if (a > 0)
                resultcorrect = true;
            return resultcorrect;
        }


    }

}
