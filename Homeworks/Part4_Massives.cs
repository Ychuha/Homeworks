using System;

namespace Homeworks
{
    class Part4_Massives
    {
        static void Main()
        {
            //P4_Q1();
            //P4_Q2();
            //P4_Q3();
            //P4_Q4();
            //P4_Q5();
            //P4_Q6();
            //P4_Q7();
            //P4_Q8();
            //P4_Q9();
            //P4_Q10();
        }

        static void P4_Q10()
        {
            int[,] array = new int[5, 5];

            int row = 0, col = 0, s = 1, step = 0, revStep = 1, i = 0, lenRow = array.GetLength(0), 
                lenCol = array.GetLength(1);

            if (lenRow == lenCol) step = lenRow;
            else if (lenRow < lenCol) step = lenRow;
            else step = lenCol;

            Console.WriteLine("step: {0}", step);

            while (revStep <= step)
            {
                if (revStep % 2 == 1)
                {
                    while (col < (lenCol - 1) - i)
                    {
                        array[row, col] = s;
                        col++;
                        s++;
                    }
                    while (row < (lenRow - 1) - i)
                    {
                        array[row, col] = s;
                        row++;
                        s++;
                    } 
                }
                else if (revStep % 2 == 0)
                {
                    while (col > 0 + i)
                    {
                        array[row, col] = s;
                        col--;
                        s++;
                    }

                    i++;

                    while (row > 0 + i)
                    {
                        array[row, col] = s;
                        row--;
                        s++;
                    }
                }

                revStep++;
            }

            array[row, col] = s;
            Console.WriteLine("Result: ");
            Print(array);
            Console.WriteLine();
        }

        static void P4_Q9()
        {
            Random rnd = new Random();
            int[,] array = new int[6, 6];
            int row = rnd.Next(array.GetLength(0) - 1);
            int col = rnd.Next(array.GetLength(1) - 1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(9);
                }
            }

            Console.WriteLine("Array before: ");
            Print(array);
            Console.WriteLine();

            int[,] temp = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = col; j < array.GetLength(1); j++)
                {
                    if (j + 1 != array.GetLength(1)) array[i, j] = array[i, j + 1];
                    else array[i, j] = 0;
                }
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = row; i < array.GetLength(0); i++)
                {
                    if (i + 1 != array.GetLength(0)) array[i, j] = array[i + 1, j];
                    else array[i, j] = 0;
                }
            }

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = array[i, j];
                }
            }

            Console.WriteLine("Array after:");
            Print(temp);
        }

        static void P4_Q8()
        {
            Random rnd = new Random();
            int[,] array = new int[5, 5];
            int[,] newAr = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1000);
                }
            }

            Console.WriteLine("Array before: ");
            Print(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newAr[j, i] = array[i, j];
                }
            }

            Console.WriteLine("After: ");
            Print(newAr);
        }

        static void P4_Q7()
        {
            Random rnd = new Random();
            char[] array = new char[rnd.Next(0, 20)];

            for (int i = 0; i < array.Length; i++) array[i] = (char)rnd.Next(0, 100);

            Console.WriteLine("Not sorted array: ");
            Print(array);

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    char temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }

            Console.WriteLine("\nSorted array: ");
            Print(array);
        }

        static void P4_Q6()
        {
            Random rnd = new Random();
            int[] array = new int[rnd.Next(0, 20)];
            int c = 0;

            Console.WriteLine("Normal array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1000);
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        c = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = c;
                    }
                }
            }

            Print(array);
        }

        static void P4_Q5()
        {
            Random rnd = new Random();
            int[] array = new int[rnd.Next(1, 20)];
            int min = 1000;
            int index = 0;

            Console.WriteLine("Printed array: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1000);
                Console.Write("|{0}|", array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            Console.WriteLine("\nMin is: {0}\nIndex of min is: {1}", min, index);
        }
        static void P4_Q4()
        {
            const int range = 10;
            char[] array = new char[range];
            char symb = 'B';
            int i = 0;

            while (i < range)
            {
                if (symb != 'E' || symb != 'I' || symb != 'O' || symb != 'U' || symb != 'Y')
                {
                    array[i] = symb;
                    symb++;
                    i++;
                }

                symb++;
            }

            Print(array);
        }

        static void P4_Q3()
        {
            const int range = 10;

            char[] array = new char[range];
            array[0] = 'a';

            for (int i = 1; i < range; i++)
            {
                array[i] = (char)(array[i - 1] + 2);
            }

            Console.WriteLine("Printet array: ");
            Print(array);
            Console.WriteLine("\nPrinted reversed array: ");
            PrintReverse(array);
        }

        static void P4_Q2()
        {
            const int range = 11;

            int[] array = new int[range];

            array[0] = 1;

            for (int i = 1; i < range; i++)
            {
                array[i] = array[i - 1] * 2;
            }

            Console.WriteLine("Printed array:");
            Print(array);
            Console.WriteLine("\nPrinted reversed array:");
            PrintReverse(array);
        }

        static void P4_Q1()
        {
            const int del = 5;
            const int ost = 2;

            int range;

            try
            {
                Console.Write("Enter range of array: ");
                range = Int32.Parse(Console.ReadLine());

                int[] arr = new int[range];
                int count = 0, i = 0;

                while (i < range)
                {
                    if (count % del == ost)
                    {
                        arr[i] = count;
                        count++;
                        i++;
                    }

                    count++;
                }

                Print(arr);
            }
            catch
            {
                Console.WriteLine("Wrong input");
            }
        }

        static void Print(int[] arr)
        {
            foreach (int s in arr)
            {
                Console.Write("|{0}|", s);
            }
        }

        static void Print(char[] arr)
        {
            foreach (char s in arr)
            {
                Console.Write("|{0}|", s);
            }
        }

        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void PrintReverse(int[] arr)
        {
            for (int i = arr.Length - 1; i != -1; i--)
            {
                Console.Write("|{0}|", arr[i]);
            }
        }

        static void PrintReverse(char[] arr)
        {
            for (int i = arr.Length - 1; i != -1; i--)
            {
                Console.Write("|{0}|", arr[i]);
            }
        }
    }
}