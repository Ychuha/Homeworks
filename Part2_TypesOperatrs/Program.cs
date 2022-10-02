using System;

namespace Part2_TypesOperatrs
{
    class Program
    {
        static void Main()
        {
            //P2_Q1();
            //P2_Q2();
            //P2_Q3();
            //P2_Q4();
            //P2_Q5();

        }

        

        static void P2_Q5()
        {
            int x, res;

            Console.Write("Enter your number: ");
            x = Int32.Parse(Console.ReadLine());

            if (x >= 1000000)
            {
                int temp;
                temp = x / 1000000;
                temp *= 1000000;
                x -= temp; 
            } 

            res = x / 1000;

            Console.WriteLine("{0} thousands in number!", res);
        }

        static void P2_Q4()
        {
            int x;

            Console.Write("Enter your number: ");
            x = Int32.Parse(Console.ReadLine());

            if (x >= 5 && x <= 10)
            {
                Console.WriteLine("Gotcha!");
            }
            else
            {
                Console.WriteLine("Miss!");
            }
        }

        static void P2_Q3()
        {
            int x;

            Console.Write("Enter your number: ");
            x = Int32.Parse(Console.ReadLine());

            if (x > 10 && x % 4 == 0)
            {
                Console.WriteLine("It's ok:)");
            }
            else
            {
                Console.WriteLine("It's not ok:(");
            }
        }

        static void P2_Q2()
        {
            int x;

            Console.Write("Enter your number: ");
            x = Int32.Parse(Console.ReadLine());

            if (x % 5 == 2 && x % 7 == 1) //Подсказка: это число 22 :)
            {
                Console.WriteLine("It's ok!");
            }
            else
            {
                Console.WriteLine("Something wen wrong:/");
            }
        }

        static void P2_Q1()
        {
            int x;

            Console.Write("Enter a number: ");
            x = Int32.Parse(Console.ReadLine());

            if (x % 3 == 0)
            {
                Console.WriteLine("Your number can be divisible by three!:)");
            }
            else
            {
                Console.WriteLine("Your number can't be divisibled by three(");
            }
        }
    }
}
