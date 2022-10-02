using System;
using System.ComponentModel.DataAnnotations;

namespace Part5_StaticMethods
{
    class Program
    {
        static void Main()
        {
            //P5_Q1();
            //P5_Q2();
            //P5_Q3();
            //P5_Q4();
            //P5_Q5();
            //P5_Q6();
            //P5_Q7();
            //P5_Q8();
            //P5_Q9();
            //P5_Q10();
        }

        static void P5_Q10()
        {
            string text;
            char a = '!', b = '?';

            Console.Write("Enter text: ");
            text = Console.ReadLine();

            Console.WriteLine("Your new text: ");
            Console.WriteLine(TextAdd(text, a, b));
        }

        static string TextAdd(string text, params char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                text += array[i];
            }

            return text;
        }

        static void P5_Q9()
        {
            int a, b, c, d, e;
            Random rnd = new Random();

            a = rnd.Next(1, 50);
            b = rnd.Next(1, 50);
            c = rnd.Next(1, 50);
            d = rnd.Next(1, 50);
            e = rnd.Next(1, 50);

            int[] oneArr = MaxMin(a);
            int[] twoArr = MaxMin(a, b);
            int[] threeArr = MaxMin(a, b, c);
            int[] fourArr = MaxMin(a, b, c, d);
            int[] fiveArr = MaxMin(a, b, c, d, e);

            Console.WriteLine("with one element");
            Console.WriteLine("|{0}|", a);
            Print(oneArr);
            Console.WriteLine();
            Console.WriteLine("with two elements");
            Console.WriteLine("|{0}|{1}|", a, b);
            Print(twoArr);
            Console.WriteLine();
            Console.WriteLine("with three elements");
            Console.WriteLine("|{0}|{1}|{2}|", a, b, c);
            Print(threeArr);
            Console.WriteLine();
            Console.WriteLine("with four elements");
            Console.WriteLine("|{0}|{1}|{2}|{3}|", a, b, c, d);
            Print(fourArr);
            Console.WriteLine();
            Console.WriteLine("with five elements");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", a, b, c, d, e);
            Print(fiveArr);
            Console.WriteLine();

        }

        static int[] MaxMin(params int[] array)
        {
            int[] maxMin = new int[2];

            maxMin[0] = array[0]; maxMin[1] = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < maxMin[1])
                {
                    maxMin[1] = array[i];
                }
                else if (array[i] > maxMin[0])
                {
                    maxMin[0] = array[i];
                }
            }

            return maxMin;
        }

        static void Print(int[] array)
        {
            Console.WriteLine("Array:");
            foreach(int s in array)
            {
                Console.Write("|{0}|", s);
            }
            Console.WriteLine();
        }

        static void P5_Q8()
        {
            int x = 1, y = 20;
            char a = 'a', z = 'z';

            int[] array = Array(x, y);
            char[] charray = Array(a, z);

            Console.WriteLine("Int array:");
            for (int i =  0; i < array.Length; i++)
            {
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Char array:");
            for (int i = 0; i < charray.Length; i++)
            {
                Console.Write("|{0}|", charray[i]);
            }
            Console.WriteLine();
        }

        static int[] Array(int x, int y)
        {
            int[] array = new int[y];

            for (int i = 0; i < y; i++)
            {
                array[i] = x;
                x++;
            }

            return array;
        }

        static char[] Array(char x, char y)
        {
            int range = (y - x) + 1;
            char[] array = new char[range];

            for (int i = 0; i < range; i++)
            {
                array[i] = x;
                x++;
            }

            return array;
        }

        static void P5_Q7()
        {
            char s = 'A';
            int range = 10;
            char[] array = new char[range];

            Console.WriteLine("Array before:");
            for (int i = 0; i < range; i++)
            {
                array[i] = s;
                s++;
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();

            Swap(array);

            Console.WriteLine("Array after:");
            foreach (char c in array) Console.Write("|{0}|", c);
            Console.WriteLine();
        }

        static void Swap(char[] array)
        {
            for (int i = 0; i < (array.Length / 2); i++)
            {
                char temp = array[i];
                array[i] = array[(array.Length - 1) - i];
                array[(array.Length - 1) - i] = temp;
            }
        }

        static void P5_Q6()
        {
            int index, max, range;
            Random rnd = new Random();
            range = rnd.Next(5, 10);
            int[] array = new int[range];

            Console.WriteLine("Array:");
            for (int i = 0; i < range; i++)
            {
                array[i] = rnd.Next(1, 50);
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();

            Max(array, out index, out max);

            Console.WriteLine("max of array is {0} in poition [{1}]", max, index);
        }

        static void Max(int[] array, out int index, out int max)
        {
            max = array[0];
            index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
        }

        static void P5_Q5()
        {
            Random rnd = new Random();
            int range = rnd.Next(5, 10);
            int[] array = new int[range];
            double res;

            Console.WriteLine("Array:");
            for (int i = 0; i < range; i++)
            {
                array[i] = rnd.Next(1, 9);
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();

            res = CenterOfArray(array);

            Console.WriteLine("Center of array: {0}", res);
        }

        static double CenterOfArray(int[] array)
        {
            double res, sum = 0;

            foreach (int s in array)
            {
                sum += s;
            }

            res = sum / array.Length;

            return res;
        }

        static void P5_Q4()
        {
            string text;
            Console.Write("Enter Text: ");
            text = Console.ReadLine();

            char[] charray = text.ToCharArray();

            Console.WriteLine("Symbol array:");
            foreach(char s in charray)
            {
                Console.Write("|{0}|", s);
            }
            Console.WriteLine();

            int[] array = ConvertArray(charray);

            Console.WriteLine("Converted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|{0}|", array[i]);
            }

            Console.WriteLine();
        }

        static int[] ConvertArray(char[] array)
        {
            int[] convArray = new int[array.Length];

            for (int i = 0; i < convArray.Length; i++)
            {
                convArray[i] = (int) array[i];
            }

            return convArray;
        }

        static void P5_Q3()
        {
            const int range = 10;
            int n;
            char[] array = new char[range];
            char s = 'a';

            Console.Write("Enter new range: ");
            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Array: ");
            for (int i = 0; i < range; i++)
            {
                array[i] = s;
                Console.Write("|{0}|", array[i]);
                s++;
            }
            Console.WriteLine();

            char[] copyArray = GetFromArray(array, n);

            Console.WriteLine("New Array:");

            for (int i = 0; i < copyArray.Length; i++)
            {
                Console.Write("|{0}|", copyArray[i]);
            }
            
        }

        static char[] GetFromArray(char[] array, int n)
        {
            if (n > array.Length) return array;

            char[] copyArray = new char[n];

            for (int i = 0; i < n; i++)
            {
                copyArray[i] = array[i];
            }

            return copyArray;
        }

        static void P5_Q2()
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Classic result is: {0}", SumSquares(n));

            int k = 0;

            SumSquaresRec(n, k);
        }

        //Рекурсивный метод нахождения суммы квадратов чисел
        static void SumSquaresRec(int n, int k)
        {
            k += n * n;
            n--;

            if (n > 0) SumSquaresRec(n, k);
            else Console.WriteLine("Result of recursive is: {0}", k);
        }

        //Обычный метод нахождения суммы квадратов чисел
        static int SumSquares(int n)
        {
            int k = 0;
            while (n > 0)
            {
                k += n * n;
                n--;
            }

            return k;
        }

        static void P5_Q1()
        {
            int n, res;

            Console.Write("Enter your number: ");
            n = Int32.Parse(Console.ReadLine());

            res = DoubleFactorial(n);

            Console.WriteLine("Classic result is: {0}", res);

            int i = n - 2;

            DoubleFactorialRec(n, i);
        }

        //Рекурсивный метод нахождения двойного факториала
        static void DoubleFactorialRec(int n, int i)
        {
            n *= i;
            i -= 2;

            if (i > 0) DoubleFactorialRec(n, i);
            else Console.WriteLine("result of Recursive is: {0}", n);
        }

        //Обычный метод нахождения двойного факториала
        static int DoubleFactorial(int n)
        {
            int i = n - 2;

            while (i > 0)
            {
                n *= i;
                i -= 2;
            }
            return n;
        }
    }
}
