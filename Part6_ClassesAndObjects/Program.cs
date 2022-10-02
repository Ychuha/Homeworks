using System;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Part6_ClassesAndObjects
{
    class Symbols
    {
        private char symb;

        public void Set(char s)
        {
            symb = s;
        }

        public int Get()
        {
            return (int)symb;
        }

        public void View()
        {
            Console.WriteLine("Символ: {0} Код: {1}", symb, (int)symb);
        }
    }

    class Alphabet
    {
        private char first;
        private char last;

        public Alphabet(char a, char b)
        {
            first = a;
            last = b;
        }

        public void View()
        {
            for(int i = 0; i < last - first; i++)
            {
                Console.WriteLine("{0} ", (char)(first + i));
            }
            Console.WriteLine("{0}", (char)last);
        }
    }

    class Quest3
    {
        private int x;
        private int y;

        public Quest3()
        {
            Console.WriteLine("Ничего не передалось");
        }

        public Quest3(int num)
        {
            x = num;
            Console.WriteLine("Передался только один аргумент");
            Console.WriteLine("x = {0}", x);
        }

        public Quest3(int a, int b)
        {
            x = a;
            y = b;

            Console.WriteLine("Передались два аргумента");
            Console.WriteLine("x = {0}  y = {1}", x, y);
        }
    }

    class Quest4
    {
        private int code;
        private char symb;

        public Quest4(int x, char s)
        {
            code = x;
            symb = s;

            Console.WriteLine("code = {0}  symb = {1}", code, symb);
            Console.WriteLine();
        }

        public Quest4(double codeSymb)
        {
            int temp = (int)codeSymb;
            symb = (char)temp;
            code = (int)(codeSymb % 100);

            Console.WriteLine("code = {0}  symb = {1}", code, symb);
        }
    }

    class Quest5
    {
        private int num;

        public Quest5()
        {
            num = 0;
        }

        public Quest5(int x)
        {
            if (x > 100)
            {
                num = 100;
            }
            else
            {
                num = x;
            }
        }

        public void Set()
        {
            num = 0;
        }

        public void Set(int x)
        {
            if (x > 100)
            {
                num = 100;
            }
            else
            {
                num = x;
            }
        }

        public void Get()
        {
            Console.WriteLine("num = {0}", num);
        }
    }

    class Quest6
    {
        private int max;
        private int min;

        public Quest6(int x)
        {
            min = x;

            if (min > max)
            {
                int tmp = max;
                max = min;
                min = tmp;
            }
        }

        public Quest6(int x, int y)
        {
            min = x;
            max = y;

            if (min > max)
            {
                int tmp = max;
                max = min;
                min = tmp;
            }
        }

        public void Get()
        {
            Console.WriteLine("min = {0}  max = {1}", min, max);
        }
    }

    class Quest7
    {
        private char symb;
        private string text;

        public Quest7(char cymb)
        {
            symb = cymb;
        }

        public Quest7(string tet)
        {
            text = tet;
        }

        public Quest7(char[] symbs)
        {
            foreach (char s in symbs)
            {
                text += s;
            }
        }

        public void Get()
        {
            Console.WriteLine("text = {0}\nsymb = {1}", text, symb);
            Console.WriteLine();
        }
    }

    class Quest8
    {
        static int myField = 0;

        public static void MyMethod()
        {
            Console.WriteLine("It stores {0}", myField);
            myField++;
        }
    }

    class Quest9
    {
        public static void MaxMin(params int[] array)
        {
            int min = array[0], max = array[0], mid = 0;

            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                else if (array[i] > max) max = array[i];
                mid += array[i];
            }

            mid /= 2;

            Console.WriteLine("min = {0}  max = {1}  middle = {2}", min, max, mid);
        }
    }

    class Quest10
    {

        private static int n = 10;
        static int factor(int n)
        {
            int fac = 1;
            for (int i = 1; i < n; i++)
            {
                fac *= i;
            }

            return fac;
        }

        static int stepen(int x, int n)
        {
            int xCop = x;
            for (int i = 1; i < n; i++)
            {
                x *= xCop;
            }

            return x;
        }

        public static double cosinus(int x)
        {
            double cos = 0;

            for (int i = 1; i < n; i += 2)
            {
                cos = (stepen(-1, i) * stepen(x, 2 * i)) / (factor(2 * i));
            }

            return cos;
        }

        public static double HyperSin(int x)
        {
            double hypSin = 0;

            for (int i = 0; i < n; i++)
            {
                hypSin = (stepen(x, 2 * i + 1)) / (factor(2 * i + 1));
            }

            return hypSin;
        }

        public static double HyperCos(int x)
        {
            double hypCos = 0;

            for (int i = 0; i < n; i++)
            {
                hypCos = (stepen(x, 2 * n)) / (factor(2 * n));
            }

            return hypCos;
        }
    }

    class Program
    {
        static void Main()
        {
            //P6_Q1();
            //P6_Q2();
            //P6_Q3();
            //P6_Q4();
            //P6_Q5();
            //P6_Q6();
            //P6_Q7();
            //P6_Q7();
            //P6_Q8();
            //P6_Q9();
            //P6_Q10();
        }

        static void P6_Q10()
        {
            int x = 10;
            double cos = Quest10.cosinus(x);
            Console.WriteLine("cosinus = {0}", cos);

            double sh = Quest10.HyperSin(x);
            Console.WriteLine("hyperbolic sinus = {0}", sh);

            double ch = Quest10.HyperCos(x);
            Console.WriteLine("hyperbolic cosinus = {0}", ch);
        }

        static void P6_Q9()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int a = 5, b = 1, c = 20, d = 15, e = 9;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 50);
            }
            Console.WriteLine("Array:");
            Quest9.MaxMin(array);
            Console.WriteLine();

            Console.WriteLine("Variables:");
            Quest9.MaxMin(a, b, c, d, e);
            Console.WriteLine();
        }

        static void P6_Q8()
        {
            int count = 10;

            for (int i = 0; i < count; i++)
            {
                Quest8.MyMethod();
            }
        }

        static void P6_Q7()
        {
            char symb = 'A'; string text = "World";
            char[] symbs = { 'H', 'E', 'L', 'L', 'O' };

            Quest7 obj = new Quest7(symb);
            obj.Get();
            obj = new Quest7(text);
            obj.Get();
            Quest7 obj2 = new Quest7(symbs);
            obj2.Get();
        }

        static void P6_Q6()
        {
            int max, min;

            Console.Write("Enter max: ");
            max = Int32.Parse(Console.ReadLine());
            Console.Write("Enter min: ");
            min = Int32.Parse(Console.ReadLine());

            Quest6 obj = new Quest6(min);
            obj.Get();
            obj = new Quest6(max);
            obj.Get();
            obj = new Quest6(min, max);
            obj.Get();
            obj = new Quest6(max, min);
            obj.Get();
        }

        static void P6_Q5()
        {
            Console.Write("Enter num: ");
            int num = Int32.Parse(Console.ReadLine());

            Quest5 obj = new Quest5();
            obj.Get();
            obj = new Quest5(num);
            obj.Get();
            obj.Set();
            obj.Get();
            obj.Set(num);
            obj.Get();
        }

        static void P6_Q4()
        {
            double d = 66.1267;
            int code = 65;
            char symb = 'A';

            Quest4 first = new Quest4(code, symb);
            Quest4 second = new Quest4(d);
        }

        static void P6_Q3()
        {
            int x, y;

            Console.WriteLine("Введите число x");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y");
            y = Int32.Parse(Console.ReadLine());

            Quest3 nothing = new Quest3();
            Quest3 one = new Quest3(x);
            Quest3 two = new Quest3(x, y);
        }

        static void P6_Q2()
        {
            char a = 'A', b = 'Z';

            Alphabet alphabet = new Alphabet(a, b);

            alphabet.View();
        }

        static void P6_Q1()
        {
            char symb = '*';

            Symbols obj = new Symbols();

            obj.Set(symb);
            int x = obj.Get();
            Console.WriteLine("Code: {0}", x);
            obj.View();
        }
    }
}
