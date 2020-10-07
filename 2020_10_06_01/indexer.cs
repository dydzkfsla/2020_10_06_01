using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_06_01
{
    class IntegerText
    {
        char[] txtNumver;
        public IntegerText(int number)
        {
            txtNumver = number.ToString().ToCharArray();
        }

        public char this[int index]
        {
            get => txtNumver[txtNumver.Length - index - 1];
            set => txtNumver[txtNumver.Length - index - 1] = value;
        }

        public char GetPointNumber(int Point)
        {
            return txtNumver[txtNumver.Length - Point - 1];
        }
    }

    class indexer
    {
        static void Main()
        {
            IntegerText c1 = new IntegerText(123456);
            int step = 1;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{step}의 자릿수" + c1[i]);
                step = step * 10;
            }
        }
    }
}
