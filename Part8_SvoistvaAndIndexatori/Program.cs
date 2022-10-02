using System;
using System.Buffers;

namespace Part8_SvoistvaAndIndexatori
{
    class Quest1
    {
        private char c;

        public char alphabet
        {
            get
            {
                return c;
            }

            set
            {
                if (value < 'A') c = 'A';
                else if (value > 'z') c = 'Z';
                else c = value;
            }
        }
    }

    class Quest3
    {
        private int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int svArr
        {
            get
            {
                int num = 0;

                for (int i = 0; i < array.Length; i++) num += array[i];

                return num;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            //P8Q1();
            //P8Q2();
            //P8Q3();
        }

        static void P8Q4()
        {

        }

        static void P8Q3()
        {
            Quest3 obj = new Quest3();

            Console.WriteLine(obj.svArr);
        }

        static void P8Q2()
        {
           
        }

        static void P8Q1()
        {
            char c = 'B', s = '-';

            Quest1 symb = new Quest1();

            symb.alphabet = c;

            Console.WriteLine("c of symb = {0}", symb.alphabet);

            Quest1 symb2 = new Quest1();

            symb2.alphabet = s;

            Console.WriteLine("c of symb2 = {0}", symb2.alphabet);
        }
    }
}
